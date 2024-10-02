using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using HotelBookingSystem.Business;

namespace HotelBookingSystem.Data
{
    public class TestDB : DB
    {
        #region Data Members
        private string table = "TestTable"; // Table name in the database
        private string sqlLocal = "SELECT * FROM TestTable"; // SQL query to select all records
        private Collection<TestClass> tests; // Collection to hold TestClass objects
        #endregion

        #region Property Method: Collection
        // Expose all tests as a collection
        public Collection<TestClass> AllTests
        {
            get { return tests; }
        }
        #endregion

        #region Constructor
        // Constructor initializes the test collection and fills it with data from the database
        public TestDB() : base()
        {
            tests = new Collection<TestClass>();
            FillDataSet(sqlLocal, table); // Fill the dataset with test data from the database
            Add2Collection(table); // Convert dataset rows into TestClass objects
        }
        #endregion

        #region Utility Methods
        // Convert the rows in the dataset into TestClass objects and add them to the collection
        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            TestClass aTest;

            // Loop through each row in the dataset and create TestClass objects
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted)) // Check if the row is not marked for deletion
                {
                    // Create a TestClass object from the data in the current row
                    aTest = new TestClass
                    {
                        Id = Convert.ToInt32(myRow["Id"]),
                        Name = Convert.ToString(myRow["name"]).TrimEnd()
                    };

                    // Add the TestClass object to the collection
                    tests.Add(aTest);
                }
            }
        }

        // Fill the dataset with TestClass data and map the TestClass object to a DataRow
        private void FillRow(DataRow aRow, TestClass aTest, DB.DBOperation operation)
        {
            if (operation == DBOperation.Add)
            {
                aRow["Id"] = aTest.Id; // Auto-assigned ID
            }
            aRow["name"] = aTest.Name; // Assign name
        }

        // Find the index of a specific test by Test ID
        private int FindRow(TestClass aTest, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (aTest.Id == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["Id"]))
                    {
                        returnValue = rowIndex; // If test found, return the row index
                        break;
                    }
                }

                rowIndex++;
            }

            return returnValue; // Return the index of the found test, or -1 if not found
        }
        #endregion

        #region Database Operations CRUD
        // Method to get all tests from the database
        public Collection<TestClass> GetAllTests()
        {
            tests.Clear();  // Clear the collection before loading

            // Clear the dataset before refilling to avoid old data conflicts
            if (dsMain.Tables.Contains(table))
            {
                dsMain.Tables[table].Clear();
            }

            FillDataSet(sqlLocal, table);  // Fetch the data from the database

            if (dsMain.Tables[table].Rows.Count == 0)
            {
                MessageBox.Show("No data found in the database.");
            }

            Add2Collection(table);  // Populate the collection from the dataset

            return tests;  // Return the collection of tests
        }



        // Method to add a new test
        public void AddTest(TestClass test)
        {
            try
            {
                // Open the connection
                if (cnMain.State == ConnectionState.Closed)
                    cnMain.Open();

                // Create a new row in the dataset
                DataRow newRow = dsMain.Tables[table].NewRow();
                FillRow(newRow, test, DB.DBOperation.Add); // Fill the new row with data
                dsMain.Tables[table].Rows.Add(newRow); // Add the new row to the dataset

                // Use the DataAdapter to insert the data into the database
                daMain.InsertCommand = new SqlCommand("INSERT INTO TestTable (Id, name) VALUES (@Id, @Name)", cnMain);
                daMain.InsertCommand.Parameters.AddWithValue("@Id", test.Id);
                daMain.InsertCommand.Parameters.AddWithValue("@Name", test.Name);

                // Ensure the data is updated in the database
                daMain.Update(dsMain, table); // Update the data source

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding test");
            }
            finally
            {
                if (cnMain.State == ConnectionState.Open)
                    cnMain.Close();
            }
        }




        // Method to edit an existing test
        public void EditTest(TestClass test)
        {
            // Create a new UPDATE SQL Command
            Create_UPDATE_Command(test);

            try
            {
                // Open the connection
                if (cnMain.State == ConnectionState.Closed)
                    cnMain.Open();

                // Execute the Update command
                daMain.UpdateCommand.ExecuteNonQuery();
            }
            finally
            {
                // Ensure the connection is closed
                if (cnMain.State == ConnectionState.Open)
                    cnMain.Close();
            }
        }


        // Method to delete a test
        public void DeleteTest(TestClass test)
        {
            DataRow rowToDelete = dsMain.Tables[table].Rows[FindRow(test, table)]; // Find the row to delete
            rowToDelete.Delete(); // Mark the row for deletion
            UpdateDataSource(test); // Update the database to remove the test
        }

        // Perform CRUD operations (Add, Edit, Delete) on tests
        // Perform CRUD operations (Add, Edit, Delete) on tests
        public void DataSetChange(TestClass aTest, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow(); // Create a new row
                    FillRow(aRow, aTest, operation); // Fill the row with data
                    dsMain.Tables[table].Rows.Add(aRow); // Add the row to the dataset
                    UpdateDataSource(sqlLocal, table);  // Ensure the database is updated
                    break;

                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(aTest, table)]; // Find the row to edit
                    FillRow(aRow, aTest, operation);  // Fill with updated data
                    UpdateDataSource(sqlLocal, table);  // Ensure the database is updated
                    break;

                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[table].Rows[FindRow(aTest, table)]; // Find the row to delete
                    aRow.Delete();  // Mark the row as deleted
                    UpdateDataSource(sqlLocal, table);  // Ensure the database is updated
                    break;
            }
        }

        #endregion

        #region Build Parameters, Create Commands & Update Database
        // Prepare parameters for an INSERT command
        private void Build_INSERT_Parameters(TestClass aTest)
        {
            SqlParameter param = new SqlParameter("@Id", SqlDbType.Int);
            param.Value = aTest.Id;
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            param.Value = aTest.Name;
            daMain.InsertCommand.Parameters.Add(param);
        }


        // Prepare parameters for an UPDATE command
        private void Build_UPDATE_Parameters(TestClass aTest)
        {
            SqlParameter param = new SqlParameter("@Id", SqlDbType.Int);
            param.Value = aTest.Id;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.VarChar, 50);
            param.Value = aTest.Name;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        // Create the INSERT SQL command to insert a new test
        private void Create_INSERT_Command(TestClass aTest)
        {
            daMain.InsertCommand = new SqlCommand(
                "INSERT INTO TestTable (Id, name) VALUES (@Id, @Name)", cnMain);
            Build_INSERT_Parameters(aTest); // Build parameters for the query
        }

        // Create the UPDATE SQL command to update an existing test
        private void Create_UPDATE_Command(TestClass aTest)
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE TestTable SET name = @Name WHERE Id = @Id", cnMain);
            Build_UPDATE_Parameters(aTest); // Build parameters for the query
        }

        // Finalize changes by updating the database with new or updated test data
        public bool UpdateDataSource(TestClass aTest)
        {
            bool success = true;
            Create_INSERT_Command(aTest); // Build the INSERT command
            Create_UPDATE_Command(aTest); // Build the UPDATE command
            success = UpdateDataSource(sqlLocal, table); // Call the base class method to update the data source
            return success;
        }
        #endregion

        public int GetHighestId()
        {
            int highestId = 0;

            try
            {
                if (cnMain.State == ConnectionState.Closed)
                    cnMain.Open();

                SqlCommand cmd = new SqlCommand("SELECT MAX(Id) FROM TestTable", cnMain);
                var result = cmd.ExecuteScalar();  // Get the highest ID from the database

                if (result != DBNull.Value)
                {
                    highestId = Convert.ToInt32(result);  // Convert result to integer
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error fetching highest ID");
            }
            finally
            {
                if (cnMain.State == ConnectionState.Open)
                    cnMain.Close();
            }

            return highestId;  // Return the highest ID
        }

    }
}
