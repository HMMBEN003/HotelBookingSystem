using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HotelBookingSystem.Presentation
{
    public partial class MakeABookingForm : Form
    {
        private bool backButtonPressed = false;
        private Collection<Room> rooms;
        private RoomController roomController;

        public MakeABookingForm()
        {
            InitializeComponent();
            // Attach the FormClosing event
            this.FormClosing += Close_Form;

            // Set the MinDate of both DateTimePickers to today's date
            checkInDateTimePicker.MinDate = DateTime.Today;
            checkOutDateTimePicker.MinDate = DateTime.Today;

            roomController = new RoomController();
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
                if (form is HomeForm)
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
            // Find the HomeForm in the collection of open forms
            foreach (Form form in Application.OpenForms)
            {
                if (form is HomeForm)
                {
                    form.Show(); // Show the HomeForm if found
                    break;
                }
            }

        }

        private void availableRoomsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void occupantsCounter_ValueChanged(object sender, EventArgs e)
        {

        }

        #region ListView set up for Rooms
        public void setUpRoomListView()
        {
            ListViewItem roomDetails;
            rooms = null;
            availableRoomsListView.Clear();

            // Set up the columns for the Room ListView
            availableRoomsListView.Columns.Add("Room No.", 100, HorizontalAlignment.Left);
            availableRoomsListView.Columns.Add("Rate per Night*", 200, HorizontalAlignment.Left);
            availableRoomsListView.Columns.Add("Description", 200, HorizontalAlignment.Left);

            // Assume we get all available rooms from the RoomController
            rooms = roomController.AllRooms;

            // Loop through all rooms and add details to the ListView
            foreach (Room room in rooms)
            {
                // Create a new ListViewItem for the room
                roomDetails = new ListViewItem();

                // Room number
                roomDetails.Text = room.RoomNumber.ToString();

                // Set the price per night (assuming it's a fixed price, or you could pass a season parameter)
                roomDetails.SubItems.Add(room.GetPriceForSeason("mid").ToString("C") + "/person");

                // Set the description or features
                roomDetails.SubItems.Add(string.Join(", ", room.RoomFeatures)); // Join features as a single string

                // Add the ListViewItem to the ListView
                availableRoomsListView.Items.Add(roomDetails);
            }

            // Set ListView properties
            availableRoomsListView.View = View.Details;  // Ensure the ListView is in Details view mode
            availableRoomsListView.GridLines = true;     // Add gridlines for better table-like appearance
            availableRoomsListView.FullRowSelect = true; // Make sure the entire row is selectable
            availableRoomsListView.Refresh();            // Refresh the ListView
        }
        #endregion



        private void searchButton_Click(object sender, EventArgs e)
        {
            if (checkOutDateTimePicker.Value < checkInDateTimePicker.Value)
            {
                invalidTimeFrameLabel.Visible = true;
            }
            else
            {
                invalidTimeFrameLabel.Visible = false;
                // Re-populate the available rooms list
                setUpRoomListView();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
