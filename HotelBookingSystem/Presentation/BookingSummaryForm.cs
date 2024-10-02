using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HotelBookingSystem.Business;

namespace HotelBookingSystem.Presentation
{
    public partial class BookingSummaryForm : Form
    {
        private bool backButtonPressed = false;
        private Booking currentBooking;
        private BookingController bookingController;

        public BookingSummaryForm(Booking currentBooking)
        {
            InitializeComponent();
            this.currentBooking = currentBooking;
            this.bookingController = new BookingController();

            // Attach the FormClosing event
            this.FormClosing += Close_Form;

            // Display the Booking Time Frame
            timeFrameLabel.Text = FormatTimeFrame(currentBooking);
            totalPriceLabel.Text = $"R{currentBooking.Total},00";
            totalDepositPriceLabel.Text = $"R{currentBooking.Total * 0.1},00";

            // Initialize the ListView
            InitializeBookingSummaryListView();

            // Populate the ListView with data from the current booking
            PopulateBookingSummary();
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

            // Create a copy of the currently open forms
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();

            // Iterate over the copied array of open forms
            foreach (Form form in openForms)
            {
                if (form is OTPForm)
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
                    form.Show(); // Show the MakeABookingForm if found
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
                if (form is OTPForm)
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

        private void proceedToPaymentButton_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(currentBooking.ToString());
            bookingController.ConfirmBooking(currentBooking);
            DialogResult result = MessageBox.Show($"Booking confirmation has been sent to the customer's email: {currentBooking.Guest.Email}", "Payment Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide(); // Hide the current form
            BookingConfirmationForm bookingConfirmationForm = new BookingConfirmationForm(currentBooking);
            bookingConfirmationForm.Show(); // Show the new BookingConfirmationForm
        }
    }
}
