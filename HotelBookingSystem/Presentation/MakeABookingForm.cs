using System;
using System.Collections;
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
        private Booking currentBooking;
        private bool isInitialising = true;

        public MakeABookingForm()
        {
            InitializeComponent();
            isInitialising = true;

            // Initialise the Booking object
            currentBooking = new Booking();

            // Attach the FormClosing event
            this.FormClosing += Close_Form;

            // Set the MinDate of both DateTimePickers to today's date
            checkInDateTimePicker.MinDate = DateTime.Today;

            // Set the initial value for the CheckIn date
            checkInDateTimePicker.Value = DateTime.Today;

            // Set the initial CheckOut date to one day later
            checkOutDateTimePicker.MinDate = DateTime.Today.AddDays(1);
            checkOutDateTimePicker.Value = DateTime.Today.AddDays(1);

            // Set the initial values for the currentBooking dates
            currentBooking.CheckInDate = checkInDateTimePicker.Value;
            currentBooking.CheckOutDate = checkOutDateTimePicker.Value;

            roomController = new RoomController();

            // Initialize ListView event handlers for item movement
            availableRoomsListView.ItemSelectionChanged += availableRoomsListView_ItemSelectionChanged;
            selectedRoomsListView.ItemSelectionChanged += selectedRoomsListView_ItemSelectionChanged;

            // Attach event handlers
            checkInDateTimePicker.ValueChanged += checkInDateTimePicker_ValueChanged;
            checkOutDateTimePicker.ValueChanged += checkOutDateTimePicker_ValueChanged;

            // Sync the column structure of both ListViews
            InitialiseRoomListViewColumns();

            // Populate the Available Rooms ListView when the form loads
            setUpRoomListView();

            isInitialising = false;
        }

        // Method to set up the columns for both ListViews at initialization
        private void InitialiseRoomListViewColumns()
        {
            // Set up columns for Available Rooms ListView
            availableRoomsListView.Columns.Add("Room No.", 100, HorizontalAlignment.Left);
            availableRoomsListView.Columns.Add("Rate per Night*", 200, HorizontalAlignment.Left);
            availableRoomsListView.Columns.Add("Description", 200, HorizontalAlignment.Left);

            // Set up columns for Selected Rooms ListView
            selectedRoomsListView.Columns.Add("Room No.", 100, HorizontalAlignment.Left);
            selectedRoomsListView.Columns.Add("Rate per Night*", 200, HorizontalAlignment.Left);
            selectedRoomsListView.Columns.Add("Description", 200, HorizontalAlignment.Left);

            // Set ListView properties to ensure proper appearance even when empty
            availableRoomsListView.View = View.Details;  // Ensure the ListView is in Details view mode
            availableRoomsListView.GridLines = true;     // Add gridlines for better table-like appearance
            availableRoomsListView.FullRowSelect = true; // Make sure the entire row is selectable

            selectedRoomsListView.View = View.Details;
            selectedRoomsListView.GridLines = true;
            selectedRoomsListView.FullRowSelect = true;
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

        #region ListView set up for Rooms
        public void setUpRoomListView()
        {
            ListViewItem roomDetails;
            availableRoomsListView.Items.Clear(); // Clear only the items, not the columns

            // Assume we get all available rooms from the RoomController
            rooms = roomController.AllRooms;

            // Loop through all rooms and add details to the ListView
            foreach (Room room in rooms)
            {
                // Create a new ListViewItem for the room
                roomDetails = new ListViewItem();

                // Room number
                roomDetails.Text = room.RoomNumber.ToString();

                // Set the price per night
                roomDetails.SubItems.Add(room.GetPriceForSeason("mid").ToString("C") + "/person");

                // Set the description or features
                roomDetails.SubItems.Add(string.Join(", ", room.RoomFeatures)); // Join features as a single string

                // Store the Room object in the Tag property
                roomDetails.Tag = room;

                // Add the ListViewItem to the ListView
                availableRoomsListView.Items.Add(roomDetails);
            }

            // Set Max Occupants Count
            maxOccupantsCountLabel.Text = (rooms.Count * 4).ToString();

            // Refresh the ListView to reflect the changes
            availableRoomsListView.Refresh();
        }



        public void setUpSelectedRoomsListView()
        {
            selectedRoomsListView.Clear();

            // Set up the columns for the Selected Rooms ListView to match the Available Rooms ListView
            selectedRoomsListView.Columns.Add("Room No.", 100, HorizontalAlignment.Left);
            selectedRoomsListView.Columns.Add("Rate per Night*", 200, HorizontalAlignment.Left);
            selectedRoomsListView.Columns.Add("Description", 200, HorizontalAlignment.Left);

            // Set ListView properties
            selectedRoomsListView.View = View.Details;  // Ensure the ListView is in Details view mode
            selectedRoomsListView.GridLines = true;     // Add gridlines for better table-like appearance
            selectedRoomsListView.FullRowSelect = true; // Make sure the entire row is selectable
            selectedRoomsListView.Refresh();            // Refresh the ListView
        }
        #endregion

        // Move room from Available to Selected
        private void availableRoomsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                // Get the selected item and remove it from the Available Rooms list
                ListViewItem selectedItem = e.Item;

                // Retrieve the Room object from the Tag property
                Room selectedRoom = (Room)selectedItem.Tag;

                // Add Room to the currentBooking
                currentBooking.AddRoom(selectedRoom);

                // Remove the item from the available rooms list
                availableRoomsListView.Items.Remove(selectedItem);

                // Clone the selected item and ensure the font is maintained
                ListViewItem clonedItem = (ListViewItem)selectedItem.Clone();
                clonedItem.Font = availableRoomsListView.Font;  // Set font explicitly
                selectedRoomsListView.Items.Add(clonedItem);    // Add to Selected Rooms

                // Sort the Selected Rooms by Room No.
                SortListViewByRoomNumber(selectedRoomsListView);
            }
        }


        // Move room from Selected back to Available
        private void selectedRoomsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                // Get the selected item and remove it from the Selected Rooms list
                ListViewItem selectedItem = e.Item;

                // Retrieve the Room object from the Tag property
                Room selectedRoom = (Room)selectedItem.Tag;

                // Remove Room from the currentBooking
                currentBooking.RemoveRoom(selectedRoom);

                selectedRoomsListView.Items.Remove(selectedItem);

                // Clone the selected item and ensure the font is maintained
                ListViewItem clonedItem = (ListViewItem)selectedItem.Clone();
                clonedItem.Font = selectedRoomsListView.Font;  // Set font explicitly
                availableRoomsListView.Items.Add(clonedItem);  // Add back to Available Rooms

                // Sort the Available Rooms by Room No.
                SortListViewByRoomNumber(availableRoomsListView);
            }
        }


        // Method to sort the ListView by Room Number (first column)
        private void SortListViewByRoomNumber(ListView listView)
        {
            listView.ListViewItemSorter = new ListViewItemComparer();
            listView.Sort();
        }

        // IComparer for sorting ListView items based on Room Number
        public class ListViewItemComparer : IComparer
        {
            public int Compare(object x, object y)
            {
                ListViewItem itemX = x as ListViewItem;
                ListViewItem itemY = y as ListViewItem;

                int roomNumberX = int.Parse(itemX.SubItems[0].Text); // Room number is in the first column
                int roomNumberY = int.Parse(itemY.SubItems[0].Text);

                return roomNumberX.CompareTo(roomNumberY);
            }
        }

        private void searchForRooms()
        {
            // Clear all Rooms in the currentBooking
            currentBooking.ClearRooms();

            // Clear the selectedRoomsListView items (but keep column headers)
            selectedRoomsListView.Items.Clear();

            // Re-populate the available rooms list
            setUpRoomListView();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (currentBooking.CheckInDate.Date >= currentBooking.CheckOutDate.Date)
            {
                invalidTimeFrameLabel.Visible = true;
            }
            else
            {
                invalidTimeFrameLabel.Visible = false;

                // Clear all Rooms in the currentBooking
                currentBooking.ClearRooms();

                // Clear the selectedRoomsListView items (but keep column headers)
                selectedRoomsListView.Items.Clear();

                // Re-populate the available rooms list
                setUpRoomListView();
            }
        }


        private void checkInDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (isInitialising) return;  // Skip validation during initialisation

            currentBooking.CheckInDate = checkInDateTimePicker.Value;

            if (currentBooking.CheckInDate.Date >= currentBooking.CheckOutDate.Date)
            {
                invalidTimeFrameLabel.Visible = true;
            }
            else
            {
                invalidTimeFrameLabel.Visible = false;
                searchForRooms();
            }
        }

        private void checkOutDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (isInitialising) return;  // Skip validation during initialisation

            currentBooking.CheckOutDate = checkOutDateTimePicker.Value;

            if (currentBooking.CheckInDate.Date >= currentBooking.CheckOutDate.Date)
            {
                invalidTimeFrameLabel.Visible = true;
            }
            else
            {
                invalidTimeFrameLabel.Visible = false;
                searchForRooms();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

            // Check if the check-in date is equal to the check-out date
            if (currentBooking.CheckInDate.Date == currentBooking.CheckOutDate.Date)
            {
                // Display an error message if the check-in date equals the check-out date
                MessageBox.Show("Check-in date cannot equal the check-out date.", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the dates are invalid
            }

            // Check if the check-in date is before the check-out date
            if (currentBooking.CheckInDate >= currentBooking.CheckOutDate)
            {
                // Display an error message if the check-in date is not before the check-out date
                MessageBox.Show("Check-in date must be before the check-out date.", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the dates are invalid
            }

            // Check if at least one room is selected
            if (currentBooking.Rooms.Count == 0)
            {
                // Display an error message if no rooms are selected
                MessageBox.Show("Please select at least one room for your booking.", "No Rooms Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if no rooms are selected
            }
        }

    }
}
