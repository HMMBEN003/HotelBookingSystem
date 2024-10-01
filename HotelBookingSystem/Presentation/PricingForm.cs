using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HotelBookingSystem.Business;

namespace HotelBookingSystem.Presentation
{
    public partial class PricingForm : Form
    {
        private Booking currentBooking;
        private Room selectedRoom;
        private bool backButtonPressed = false;
        private decimal totalPrice;
        private const decimal LOW_SEASON_RATE = 550;
        private const decimal MID_SEASON_RATE = 750;
        private const decimal HIGH_SEASON_RATE = 995;

        public PricingForm(Booking currentBooking)
        {
            InitializeComponent();
            this.currentBooking = currentBooking;

            // Display the Booking Time Frame
            timeFrameLabel.Text = FormatTimeFrame(currentBooking);

            // Check if the date falls within 8-31 December
            CheckImportantInfoVisibility();

            // Attach the FormClosing event
            this.FormClosing += Close_Form;

            // Set up the columns for the Selected Rooms ListView
            InitializeSelectedRoomsListViewColumns();

            // Call method to populate the list view
            PopulateSelectedRoomsListView();

            // Initialise the total price
            UpdateTotalPrice();

            // Subscribe to NumericUpDown value changed events
            adultUpDown.ValueChanged += numAdults_ValueChanged;
            childrenUpDown.ValueChanged += numChildren_ValueChanged;
            infantsUpDown.ValueChanged += numInfants_ValueChanged;

            // Attach the ItemSelectionChanged event for selectedRoomsListView
            selectedRoomsListView.ItemSelectionChanged += SelectedRoomsListView_ItemSelectionChanged;
        }

        private void SelectedRoomsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected) // Check if an item is selected
            {
                // Retrieve the Room object from the Tag property of the selected ListViewItem
                selectedRoom = (Room)e.Item.Tag;

                // Set the max and min values before setting the values
                //adultUpDown.Maximum = 2; // Max 2 adults
                childrenUpDown.Maximum = 4 - (int)adultUpDown.Value; // Adjust based on the remaining occupants
                infantsUpDown.Maximum = 4 - (int)(adultUpDown.Value + childrenUpDown.Value); // Adjust based on the remaining occupants

                // Set the values for the upDowns based on the selected room's configuration
                if (selectedRoom.Adults >= adultUpDown.Minimum && selectedRoom.Adults <= adultUpDown.Maximum)
                {
                    adultUpDown.Value = selectedRoom.Adults;  // Set adult count
                }

                if (selectedRoom.Teens >= childrenUpDown.Minimum && selectedRoom.Teens <= childrenUpDown.Maximum)
                {
                    childrenUpDown.Value = selectedRoom.Teens;  // Set children count
                }

                if (selectedRoom.Infants >= infantsUpDown.Minimum && selectedRoom.Infants <= infantsUpDown.Maximum)
                {
                    infantsUpDown.Value = selectedRoom.Infants;  // Set infants count
                }

                numberOfAdultsLabel.Visible = true;
                adultUpDown.Visible = true;

                numberOfChildrenLabel.Visible = true;
                childrenUpDown.Visible = true;

                numberOfInfantsLabel.Visible = true;
                infantsUpDown.Visible = true;
            }
        }


        private void setNewMaxes()
        {
            // Get the current values of the numericUpDown controls
            int currentAdults = (int)adultUpDown.Value;
            int currentChildren = (int)childrenUpDown.Value;
            int currentInfants = (int)infantsUpDown.Value;

            // Total occupants
            int totalOccupants = currentAdults + currentChildren + currentInfants;

            // Ensure there is at least 1 adult
            if (currentAdults < 1)
            {
                adultUpDown.Value = 1;
                currentAdults = 1;
            }

            // Calculate how many more occupants can be added based on the total max of 4 occupants
            int remainingOccupants = 4 - totalOccupants;

            // Set the maximum for adults between 0 and 2, we can't have more than 2 adults
            adultUpDown.Maximum = Math.Min(2, 4 - (currentChildren + currentInfants)); // Max is either 2 or enough to reach 4 total

            // Set the maximum values for children and infants based on remaining space
            childrenUpDown.Maximum = Math.Max(0, 4 - (currentAdults + currentInfants));  // No negative max
            infantsUpDown.Maximum = Math.Max(0, 4 - (currentAdults + currentChildren));  // No negative max
        }


        // Method for when the Number of Adults value is changed
        private void numAdults_ValueChanged(object sender, EventArgs e)
        {
            selectedRoom.Adults = (int) adultUpDown.Value;
            setNewMaxes();
        }

        // Method for when the Number of Children value is changed
        private void numChildren_ValueChanged(object sender, EventArgs e)
        {
            selectedRoom.Teens = (int)childrenUpDown.Value;
            setNewMaxes();
        }

        // Method for when the Number of Infants value is changed
        private void numInfants_ValueChanged(object sender, EventArgs e)
        {
            selectedRoom.Infants = (int)infantsUpDown.Value;
            setNewMaxes();
        }

        // Validate total occupants in the room
        private void ValidateOccupants()
        {
            int totalOccupants = (int)(adultUpDown.Value + childrenUpDown.Value + infantsUpDown.Value);
            if (totalOccupants > 4)
            {
                MessageBox.Show("A maximum of 4 occupants is allowed per room.", "Invalid Occupants", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        // Calculate the total price based on the currentBooking and selected occupants
        private void UpdateTotalPrice()
        {
            totalPrice = 0;

            // Loop through the selected time frame
            for (DateTime date = currentBooking.CheckInDate; date < currentBooking.CheckOutDate; date = date.AddDays(1))
            {
                // Determine the room rate based on the season
                decimal dailyRate = GetDailyRate(date);

                // Multiply by the number of rooms and add to total
                totalPrice += dailyRate;
            }

            totalPrice = totalPrice * currentBooking.Rooms.Count;

            // Update the price and deposit labels
            totalPriceLabel.Text = "R" + totalPrice.ToString("N2");
            depositLabel.Text = "R" + (totalPrice * 0.1M).ToString("N2");
        }


        // Determine the daily rate based on the season
        private decimal GetDailyRate(DateTime date)
        {
            // December pricing rules
            if (date.Month == 12)
            {
                if (date.Day >= 1 && date.Day <= 7)
                {
                    return LOW_SEASON_RATE;
                }
                else if (date.Day >= 8 && date.Day <= 15)
                {
                    return MID_SEASON_RATE;
                }
                else if (date.Day >= 16 && date.Day <= 31)
                {
                    return HIGH_SEASON_RATE;
                }
            }

            // Default to Low Season for other months
            return LOW_SEASON_RATE;
        }

        // Method to check if the selected dates fall within 8-31 December
        private void CheckImportantInfoVisibility()
        {
            DateTime checkInDate = currentBooking.CheckInDate;
            DateTime checkOutDate = currentBooking.CheckOutDate;

            // Check if the check-in or check-out dates are within 8-31 December
            bool isWithinRange = (checkInDate.Month == 12 && checkInDate.Day >= 8 && checkInDate.Day <= 31) ||
                                 (checkOutDate.Month == 12 && checkOutDate.Day >= 8 && checkOutDate.Day <= 31);

            // Show or hide the important info label based on the date range
            importantInfoLabel.Visible = isWithinRange;
        }

        // Method to set up the columns for selectedRoomsListView
        private void InitializeSelectedRoomsListViewColumns()
        {
            selectedRoomsListView.Clear(); // Clear any existing columns or items

            // Add columns similar to the availableRoomsListView
            selectedRoomsListView.Columns.Add("Room No.", 100, HorizontalAlignment.Left);
            selectedRoomsListView.Columns.Add("Rate per Night*", 150, HorizontalAlignment.Left);
            selectedRoomsListView.Columns.Add("Description", 161, HorizontalAlignment.Left);

            // Set ListView properties
            selectedRoomsListView.View = View.Details;  // Ensure the ListView is in Details view mode
            selectedRoomsListView.GridLines = true;     // Add gridlines for better table-like appearance
            selectedRoomsListView.FullRowSelect = true; // Make sure the entire row is selectable
        }

        // Method to populate the selectedRoomsListView with rooms from currentBooking
        private void PopulateSelectedRoomsListView()
        {
            // Clear existing items in the list view
            selectedRoomsListView.Items.Clear();

            // Loop through the rooms in the booking and add them to the ListView
            foreach (Room room in currentBooking.Rooms)
            {
                // Create a new ListViewItem for the room
                ListViewItem roomItem = new ListViewItem(room.RoomNumber);

                // Add the price per night as a sub-item
                roomItem.SubItems.Add(room.GetPriceForSeason("low").ToString("C") + "/room");

                // Add the room description or features as a sub-item
                roomItem.SubItems.Add(string.Join(", ", room.RoomFeatures));

                // Add the room object to the Tag property of the ListViewItem
                roomItem.Tag = room;

                // Add the item to the ListView
                selectedRoomsListView.Items.Add(roomItem);
            }

            // Ensure the ListView is refreshed
            selectedRoomsListView.Refresh();
        }

        // Method to format the time frame string
        private string FormatTimeFrame(Booking currentBooking)
        {
            // Format the CheckInDate and CheckOutDate to "dd MMM yyyy"
            string checkIn = currentBooking.CheckInDate.ToString("d MMM yyyy");
            string checkOut = currentBooking.CheckOutDate.ToString("d MMM yyyy");

            // Return the formatted string
            return $"Time Frame: {checkIn} - {checkOut}";
        }

        private void Close_Form(object sender, FormClosingEventArgs e)
        {
            if (!backButtonPressed) Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backButtonPressed = true;
            this.Close();
            // Find the HomeForm in the collection of open forms
            foreach (Form form in Application.OpenForms)
            {
                if (form is MakeABookingForm)
                {
                    form.Show(); // Show the LoginForm if found
                    break;
                }
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            backButtonPressed = true;
            this.Close();

            // Create a copy of the currently open forms
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();

            // Iterate over the copied array of open forms
            foreach (Form form in openForms)
            {
                if (form is MakeABookingForm)
                {
                    form.Close(); // Close the MakeABookingForm if found
                }
                else if (form is HomeForm)
                {
                    form.Show(); // Show the HomeForm if found
                }
            }
        }

        private void confirmDepositPricingButton_Click(object sender, EventArgs e)
        {
            foreach(Room room in currentBooking.Rooms)
            {
                if(room.Adults == 0)
                {
                    MessageBox.Show("Ensure at least 1 adult per room.", "Invalid Occupants", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            this.Hide(); // Hide the current form
            FindCustomerForm findCustomerForm = new FindCustomerForm();
            findCustomerForm.Show(); // Show the new FindCustomerForm
        }
    }
}
