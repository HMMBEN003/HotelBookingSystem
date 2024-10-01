using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Business;

namespace HotelBookingSystem.Presentation
{
    public partial class BookingConfirmationForm : Form
    {
        private bool backButtonPressed;
        private Booking currentBooking;
        public BookingConfirmationForm(Booking currentBooking)
        {
            InitializeComponent();
            this.currentBooking = currentBooking;

            nameLabel.Text = currentBooking.Guest.FirstName + " " + currentBooking.Guest.LastName;
            timeFrameLabel.Text = FormatTimeFrame(currentBooking);
            emailLabel.Text = currentBooking.Guest.Email;
            totalPriceLabel.Text = $"R{currentBooking.Total},00";

            // Initialize the ListView
            InitializeBookingSummaryListView();

            // Populate the ListView with data from the current booking
            PopulateBookingSummary();
        }

        private string FormatTimeFrame(Booking currentBooking)
        {
            // Format the CheckInDate and CheckOutDate to "dd MMM yyyy"
            string checkIn = currentBooking.CheckInDate.ToString("d MMM yyyy");
            string checkOut = currentBooking.CheckOutDate.ToString("d MMM yyyy");

            // Return the formatted string
            return $"Time Frame: {checkIn} - {checkOut}";
        }

        // Initialize the columns in the ListView
        private void InitializeBookingSummaryListView()
        {
            bookingSummaryListView.Clear(); // Clear any existing columns

            // Add columns similar to the layout you provided
            bookingSummaryListView.Columns.Add("Room Number", 200, HorizontalAlignment.Left);
            bookingSummaryListView.Columns.Add("Description", 300, HorizontalAlignment.Left);
            bookingSummaryListView.Columns.Add("Number of Adults", 250, HorizontalAlignment.Left);
            bookingSummaryListView.Columns.Add("Number of Children", 250, HorizontalAlignment.Left);
            bookingSummaryListView.Columns.Add("Number of Infants", 250, HorizontalAlignment.Left);
            bookingSummaryListView.Columns.Add("Total", 200, HorizontalAlignment.Left);

            // Set ListView properties
            bookingSummaryListView.View = View.Details;  // Ensure the ListView is in Details view mode
            bookingSummaryListView.GridLines = true;     // Add gridlines for better table-like appearance
            bookingSummaryListView.FullRowSelect = true; // Make sure the entire row is selectable
        }

        // Method to populate the ListView with data from currentBooking
        private void PopulateBookingSummary()
        {
            // Clear any existing items
            bookingSummaryListView.Items.Clear();

            // Sort rooms by Room Number before populating
            var sortedRooms = currentBooking.Rooms.OrderBy(room => room.RoomNumber).ToList();

            // Loop through each room in the sorted rooms and add it to the ListView
            foreach (Room room in sortedRooms)
            {
                ListViewItem listItem = new ListViewItem(room.RoomNumber); // Room Number

                // Add the rest of the sub-items (description, occupants, and total price)
                listItem.SubItems.Add(string.Join(", ", room.RoomFeatures)); // Description
                listItem.SubItems.Add(room.Adults.ToString());  // Number of Adults
                listItem.SubItems.Add(room.Teens.ToString());   // Number of Children
                listItem.SubItems.Add(room.Infants.ToString()); // Number of Infants

                // Calculate the total price for the room (assuming low season for simplicity)
                decimal totalRoomPrice = room.TotalPrice;
                listItem.SubItems.Add("R" + totalRoomPrice.ToString("N2")); // Total price

                // Add the listItem to the ListView
                bookingSummaryListView.Items.Add(listItem);
            }

            // Ensure the ListView is refreshed to display the data
            bookingSummaryListView.Refresh();
        }

        private void returnToHomePageButton_Click(object sender, EventArgs e)
        {
            homeButton_Click(sender, e);
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
                if (form is BookingSummaryForm)
                {
                    form.Close(); // Close the OTPForm if found
                }
                else if (form is OTPForm)
                {
                    form.Close(); // Close the OTPForm if found
                }
                else if (form is RegisterNewCustomerForm)
                {
                    form.Close(); // Close the RegisterNewCustomerForm if found
                }
                else if (form is FindCustomerForm)
                {
                    form.Close(); // Close the FindCustomerForm if found
                }
                else if (form is MakeABookingForm)
                {
                    form.Close(); // Close the MakeABookingForm if found
                }
                else if (form is HomeForm)
                {
                    form.Show(); // Show the HomeForm if found
                }
            }
        }
    }
}
