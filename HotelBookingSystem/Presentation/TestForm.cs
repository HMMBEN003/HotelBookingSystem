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
        private Collection<TestClass> tests;
        private TestController testController;

        public TestForm()
        {
            InitializeComponent();
            testController = new TestController();
            LoadTests();  // Load data from database
            SetUpListView();  // Set up ListView columns and layout
        }

        // Method to load tests from the database
        private void LoadTests()
        {
            tests = testController.tests;
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


        // Method to populate ListView with data from tests
        private void PopulateListView()
        {
            bookingsListView.Items.Clear();  // Clear any existing items
            if (tests != null && tests.Count > 0)
            {
                foreach (var test in tests)
                {
                    var item = new ListViewItem(test.Id.ToString());  // Add ID as the first column
                    item.SubItems.Add(test.Name);  // Add Name as the second column
                    bookingsListView.Items.Add(item);  // Add the ListViewItem to the ListView
                }
            }
            else
            {
                MessageBox.Show("No records to display.");
            }
            bookingsListView.Refresh();  // Refresh the ListView after updating
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Create a dummy TestClass object
            var dummyTest = new TestClass
            {
                Id = GetNewId(), // You need a method to get a unique ID
                Name = "Dummy Test"
            };

            // Add the dummy test to the database via the TestController
            testController.AddTestRecord(dummyTest);

            // Reload the data from the database to ensure persistence and update the ListView
            tests = testController.testDB.GetAllTests();
            PopulateListView();  // Repopulate the ListView with the new data
        }


        // Method to generate a new unique ID
        // Method to generate a new unique ID by fetching the highest ID from the database
        private int GetNewId()
        {
            // Ensure you're using the database to determine the next available ID
            int highestId = testController.GetHighestIdFromDB();  // This will return the highest ID from the database
            return highestId + 1;  // Increment the highest ID to get a new unique ID
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
