using System;
using System.Drawing;
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

            /*// Initialise the total price
            UpdateTotalPrice();*/

            // Attach the ItemSelectionChanged event for selectedRoomsListView
            selectedRoomsListView.ItemSelectionChanged += SelectedRoomsListView_ItemSelectionChanged;

            currentBooking.Total = 0;

            foreach (Room room in currentBooking.Rooms)
            {
                room.Adults = room.Adults == 0 ? 1: room.Adults;

                room.TotalPrice = GetTotalPrice();
                currentBooking.Total += room.TotalPrice;
            }

            totalPriceLabel.Text = $"R{currentBooking.Total},00";
            depositLabel.Text = $"R{currentBooking.Total * 0.1},00";
        }

        private void SelectedRoomsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                // Retrieve the Room object from the Tag property of the selected ListViewItem
                selectedRoom = (Room)e.Item.Tag;
                updateButtons();


                // Make configuration options visible (only on inital load)
                if(occupantsLabel.Visible == false)
                {
                    occupantsLabel.Visible = true;
                    oneLabel.Visible = true;
                    twoLabel.Visible = true;
                    threeLabel.Visible = true;
                    fourLabel.Visible = true;

                    adultLabel.Visible = true;
                    childLabel.Visible = true;
                    infantLabel.Visible = true;

                    occupant1AdultButton.Visible = true;
                    occupant1ChildPictureBox.Visible = true;
                    occupant1InfantPictureBox.Visible = true;

                    occupant2AdultButton.Visible = true;
                    occupant2ChildButton.Visible = true;
                    occupant2InfantButton.Visible = true;

                    occupant3AdultPictureBox.Visible = true;
                    occupant3ChildButton.Visible = true;
                    occupant3InfantButton.Visible = true;

                    occupant4AdultPictureBox.Visible = true;
                    occupant4ChildButton.Visible = true;
                    occupant4InfantButton.Visible = true;
                }
            }
        }

        // Calculate the total price based on the currentBooking and selected occupants
        private int GetTotalPrice()
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

            return (int)totalPrice;
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

            // Sort rooms by Room Number before populating
            var sortedRooms = currentBooking.Rooms.OrderBy(room => room.RoomNumber).ToList();

            // Loop through the sorted rooms and add them to the ListView
            foreach (Room room in sortedRooms)
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
            if (!backButtonPressed && this.Visible) Application.Exit();
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

            if(!currentBooking.Guest.Verified)
            {
                this.Hide(); // Hide the current form
                FindCustomerForm findCustomerForm = new FindCustomerForm(currentBooking);
                findCustomerForm.Show(); // Show the new FindCustomerForm
            } else {
                this.Hide(); // Hide the current form
                BookingSummaryForm bookingSummary = new BookingSummaryForm(currentBooking);
                bookingSummary.Show(); // Show the new BookingSummaryForm
            }
            
        }

        // Unselects a button (resets its style)
        private void unselectButton(Button button)
        {
            button.BackColor = Color.FromArgb(229, 229, 229);
            button.ForeColor = Color.Black;
        }

        // Selects a button (changes its style to selected)
        private void selectButton(Button button)
        {
            button.BackColor = Color.Black;
            button.ForeColor = Color.White;
        }

        public void updateButtons()
        {
            int adultCount = 1; // There must be at least one adult
            int childCount = 0;
            int infantCount = 0;

            // Occupant 2
            if (selectedRoom.Occupants.Occupant2 == OccupantTye.Adult)
            {
                selectButton(occupant2AdultButton);
                unselectButton(occupant2ChildButton);
                unselectButton(occupant2InfantButton);
                adultCount++;
            }
            else if (selectedRoom.Occupants.Occupant2 == OccupantTye.Child)
            {
                unselectButton(occupant2AdultButton);
                selectButton(occupant2ChildButton);
                unselectButton(occupant2InfantButton);
                childCount++;
            }
            else if (selectedRoom.Occupants.Occupant2 == OccupantTye.Infant)
            {
                unselectButton(occupant2AdultButton);
                unselectButton(occupant2ChildButton);
                selectButton(occupant2InfantButton);
                infantCount++;
            }
            else if (selectedRoom.Occupants.Occupant2 == OccupantTye.None)
            {
                unselectButton(occupant2AdultButton);
                unselectButton(occupant2ChildButton);
                unselectButton(occupant2InfantButton);
            }

            // Occupant 3
            if (selectedRoom.Occupants.Occupant3 == OccupantTye.Adult)
            {
                unselectButton(occupant3ChildButton);
                unselectButton(occupant3InfantButton);
                adultCount++;
            }
            else if (selectedRoom.Occupants.Occupant3 == OccupantTye.Child)
            {
                selectButton(occupant3ChildButton);
                unselectButton(occupant3InfantButton);
                childCount++;
            }
            else if (selectedRoom.Occupants.Occupant3 == OccupantTye.Infant)
            {
                unselectButton(occupant3ChildButton);
                selectButton(occupant3InfantButton);
                infantCount++;
            }
            else if (selectedRoom.Occupants.Occupant3 == OccupantTye.None)
            {
                unselectButton(occupant3ChildButton);
                unselectButton(occupant3InfantButton);
            }

            // Occupant 4
            if (selectedRoom.Occupants.Occupant4 == OccupantTye.Adult)
            {
                unselectButton(occupant4ChildButton);
                unselectButton(occupant4InfantButton);
                adultCount++;
            }
            else if (selectedRoom.Occupants.Occupant4 == OccupantTye.Child)
            {
                selectButton(occupant4ChildButton);
                unselectButton(occupant4InfantButton);
                childCount++;
            }
            else if (selectedRoom.Occupants.Occupant4 == OccupantTye.Infant)
            {
                unselectButton(occupant4ChildButton);
                selectButton(occupant4InfantButton);
                infantCount++;
            }
            else if (selectedRoom.Occupants.Occupant4 == OccupantTye.None)
            {
                unselectButton(occupant4ChildButton);
                unselectButton(occupant4InfantButton);
            }

            // Update room properties
            selectedRoom.Adults = adultCount;
            selectedRoom.Teens = childCount;
            selectedRoom.Infants = infantCount;
        }



        // Occupant 2 Row
        private void occupant2AdultButton_Click(object sender, EventArgs e)
        {
            selectedRoom.Occupants.Occupant2 = selectedRoom.Occupants.Occupant2 == OccupantTye.Adult ? OccupantTye.None : OccupantTye.Adult;
            updateButtons();
        }

        private void occupant2ChildButton_Click(object sender, EventArgs e)
        {
            selectedRoom.Occupants.Occupant2 = selectedRoom.Occupants.Occupant2 == OccupantTye.Child ? OccupantTye.None : OccupantTye.Child;
            updateButtons();
        }

        private void occupant2InfantButton_Click(object sender, EventArgs e)
        {
            selectedRoom.Occupants.Occupant2 = selectedRoom.Occupants.Occupant2 == OccupantTye.Infant ? OccupantTye.None : OccupantTye.Infant;
            updateButtons();
        }

        // Occupant 3 Row

        private void occupant3ChildButton_Click(object sender, EventArgs e)
        {
            selectedRoom.Occupants.Occupant3 = selectedRoom.Occupants.Occupant3 == OccupantTye.Child ? OccupantTye.None : OccupantTye.Child;
            updateButtons();
        }

        private void occupant3InfantButton_Click(object sender, EventArgs e)
        {
            selectedRoom.Occupants.Occupant3 = selectedRoom.Occupants.Occupant3 == OccupantTye.Infant ? OccupantTye.None : OccupantTye.Infant;
            updateButtons();
        }

        // Occupant 4 Row
        private void occupant4ChildButton_Click(object sender, EventArgs e)
        {
            selectedRoom.Occupants.Occupant4 = selectedRoom.Occupants.Occupant4 == OccupantTye.Child ? OccupantTye.None : OccupantTye.Child;
            updateButtons();
        }

        private void occupant4InfantButton_Click(object sender, EventArgs e)
        {
            selectedRoom.Occupants.Occupant4 = selectedRoom.Occupants.Occupant4 == OccupantTye.Infant ? OccupantTye.None : OccupantTye.Infant;
            updateButtons();
        }
    }
}
