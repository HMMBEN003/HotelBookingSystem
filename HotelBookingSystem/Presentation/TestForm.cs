using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HotelBookingSystem.Business;

namespace HotelBookingSystem.Presentation
{
    public partial class TestForm : Form
    {
        private Collection<Booking> bookings;
        private BookingController bookingController;

        public TestForm()
        {
            InitializeComponent();
            bookingController = new BookingController();
            SetUpListView();  // Set up ListView columns and layout
            LoadBookings();  // Load data from database
        }

        // Method to load bookings from the database
        private void LoadBookings()
        {
            bookings = bookingController.AllBookings;
            PopulateListView();
        }

        // Method to set up the ListView with columns
        private void SetUpListView()
        {
            bookingsListView.Clear();  // Ensure previous columns are removed
            bookingsListView.Columns.Add("ID", 100, HorizontalAlignment.Left);
            bookingsListView.Columns.Add("Name", 200, HorizontalAlignment.Left);

            bookingsListView.View = View.Details;  // Make sure ListView is set to 'Details' view
            bookingsListView.GridLines = true;  // Enable grid lines for better clarity
            bookingsListView.FullRowSelect = true;  // Allow full row to be selected
        }


        // Method to populate ListView with data from bookings
        private void PopulateListView()
        {
            bookingsListView.Items.Clear();  // Clear any existing items
            if (bookings != null && bookings.Count > 0)
            {
                foreach (Booking booking in bookings)
                {
                    var item = new ListViewItem(booking.ID.ToString());  // Add ID as the first column
                    item.SubItems.Add(booking.Guest.Email);  // Add Name as the second column
                    bookingsListView.Items.Add(item);  // Add the ListViewItem to the ListView
                }
            }
            else
            {
                MessageBox.Show("No records to display.");
            }
            bookingsListView.Refresh();  // Refresh the ListView after updating
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
            // Find the HomeForm in the collection of open forms
            foreach (Form form in Application.OpenForms)
            {
                if (form is HomeForm)
                {
                    form.Show(); // Show the LoginForm if found
                    break;
                }
            }
        }
    }
}
