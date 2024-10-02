using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using HotelBookingSystem.Business;

namespace HotelBookingSystem.Data
{
    // This class handles database communication for Guest-related data
    public class GuestDB : DB
    {
        #region Data Members
        private string table = "Guest"; // Table name in the database
        private string sqlLocal = "SELECT * FROM Guest"; // SQL query to select all guests
        private Collection<Guest> guests; // Collection to hold Guest objects
        #endregion

        #region Property Method: Collection
        // Expose all guests as a collection
        public Collection<Guest> AllGuests
        {
            get
            {
                return guests;
            }
        }
        #endregion

        #region Constructor
        // Constructor initializes the guest collection and fills it with data from the database
        public GuestDB() : base()
        {
            guests = new Collection<Guest>();
            FillDataSet(sqlLocal, table); // Fill the dataset with guest data from the database
            Add2Collection(table); // Convert dataset rows into Guest objects
        }
        #endregion

        #region Utility Methods
        // Get the dataset containing the guests
        public DataSet GetDataSet()
        {
            return dsMain; // Return the main dataset from the base class (DB)
        }

        // Convert the rows in the dataset into Guest objects and add them to the collection
        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Guest aGuest;

            // Loop through each row in the dataset and create Guest objects
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted)) // Check if the row is not marked for deletion
                {
                    // Create a Guest object from the data in the current row
                    aGuest = new Guest(
                        Convert.ToInt32(myRow["guest_id"]),
                        Convert.ToString(myRow["first_name"]).TrimEnd(),
                        Convert.ToString(myRow["last_name"]).TrimEnd(),
                        Convert.ToString(myRow["email"]).TrimEnd(),
                        Convert.ToString(myRow["phone"]).TrimEnd(),
                        Convert.ToString(myRow["street_address"]).TrimEnd(),
                        Convert.ToString(myRow["suburb"]).TrimEnd(),
                        Convert.ToString(myRow["postal_code"]).TrimEnd()
                    );

                    // Add the Guest object to the collection
                    guests.Add(aGuest);
                }
            }
        }

        // Fill the dataset with guest data and map the Guest object to a DataRow
        private void FillRow(DataRow aRow, Guest aGuest, DB.DBOperation operation)
        {
            /*if (operation == DBOperation.Add)
            {
                aRow["guest_id"] = aGuest.GuestId;  // Auto-assigned Guest ID
            }*/
            aRow["first_name"] = aGuest.FirstName; // Assign first name
            aRow["last_name"] = aGuest.LastName;   // Assign last name
            aRow["email"] = aGuest.Email;          // Assign email
            aRow["phone"] = aGuest.Phone;          // Assign phone
            aRow["street_address"] = aGuest.StreetAddress; // Assign street address
            aRow["suburb"] = aGuest.Suburb;        // Assign suburb
            aRow["postal_code"] = aGuest.PostalCode; // Assign postal code
        }

        // Find the index of a specific guest by Guest ID
        private int FindRow(Guest aGuest, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1; // Default return value if not found

            // Loop through dataset to find the row with the matching guest_id
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (aGuest.GuestId == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["guest_id"]))
                    {
                        returnValue = rowIndex; // If guest found, return the row index
                        break;
                    }
                }

                rowIndex++;
            }

            return returnValue; // Return the index of the found guest, or -1 if not found
        }

        #endregion

        #region Database Operations CRUD
        // Method to get all guests from the database
        public Collection<Guest> GetAllGuests()
        {
            guests.Clear(); // Clear the collection before loading
            FillDataSet(sqlLocal, table); // Refill the dataset
            Add2Collection(table); // Populate the collection from the dataset

            return guests; // Return the collection of guests
        }

        // Method to add a new guest
        // GuestDB.cs

        public void AddGuest(Guest guest)
        {
            try
            {
                // Build the INSERT command
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Guest (first_name, last_name, email, phone, street_address, suburb, postal_code) " +
                    "OUTPUT INSERTED.guest_id " +
                    "VALUES (@FirstName, @LastName, @Email, @Phone, @StreetAddress, @Suburb, @PostalCode)", cnMain);

                // Add parameters
                cmd.Parameters.AddWithValue("@FirstName", guest.FirstName);
                cmd.Parameters.AddWithValue("@LastName", guest.LastName);
                cmd.Parameters.AddWithValue("@Email", guest.Email);
                cmd.Parameters.AddWithValue("@Phone", guest.Phone);
                cmd.Parameters.AddWithValue("@StreetAddress", guest.StreetAddress);
                cmd.Parameters.AddWithValue("@Suburb", guest.Suburb);
                cmd.Parameters.AddWithValue("@PostalCode", guest.PostalCode);

                if (cnMain.State == ConnectionState.Closed)
                {
                    cnMain.Open();
                }

                // Execute the command and retrieve the new guest_id
                var result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    int guestId = Convert.ToInt32(result);
                    guest.GuestId = guestId; // Assign the new guest_id to the guest object
                }
                else
                {
                    throw new Exception("Failed to retrieve the inserted guest ID.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in AddGuest: " + ex.Message, ex);
            }
            finally
            {
                if (cnMain.State == ConnectionState.Open)
                {
                    cnMain.Close();
                }
            }
        }


        // Method to edit an existing guest
        public void EditGuest(Guest guest)
        {
            DataRow rowToEdit = dsMain.Tables[table].Rows[FindRow(guest, table)]; // Find the row to edit
            FillRow(rowToEdit, guest, DBOperation.Edit); // Update the row with the new data
            UpdateDataSource(guest); // Update the database with the modified guest
        }

        // Method to delete a guest
        public void DeleteGuest(Guest guest)
        {
            DataRow rowToDelete = dsMain.Tables[table].Rows[FindRow(guest, table)]; // Find the row to delete
            rowToDelete.Delete(); // Mark the row for deletion
            UpdateDataSource(guest); // Update the database to remove the guest
        }

        // Perform CRUD operations (Add, Edit, Delete) on guests
        public void DataSetChange(Guest aGuest, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow(); // Create a new row
                    FillRow(aRow, aGuest, operation); // Fill the row with data
                    dsMain.Tables[table].Rows.Add(aRow); // Add the row to the dataset
                    break;

                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(aGuest, table)]; // Find the row to edit
                    FillRow(aRow, aGuest, operation);  // Fill with updated data
                    break;

                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[table].Rows[FindRow(aGuest, table)]; // Find the row to delete
                    aRow.Delete();  // Mark the row as deleted
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update Database
        // Prepare parameters for an INSERT command
        private void Build_INSERT_Parameters(Guest aGuest)
        {
            SqlParameter param = new SqlParameter("@guest_id", SqlDbType.Int, 10, "guest_id");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@first_name", SqlDbType.NVarChar, 50, "first_name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@last_name", SqlDbType.NVarChar, 50, "last_name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@email", SqlDbType.NVarChar, 100, "email");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@phone", SqlDbType.NVarChar, 20, "phone");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@street_address", SqlDbType.NVarChar, 100, "street_address");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@suburb", SqlDbType.NVarChar, 50, "suburb");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@postal_code", SqlDbType.NVarChar, 10, "postal_code");
            daMain.InsertCommand.Parameters.Add(param);
        }

        // Prepare parameters for an UPDATE command
        private void Build_UPDATE_Parameters(Guest aGuest)
        {
            SqlParameter param = new SqlParameter("@first_name", SqlDbType.NVarChar, 50, "first_name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@last_name", SqlDbType.NVarChar, 50, "last_name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@email", SqlDbType.NVarChar, 100, "email");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@phone", SqlDbType.NVarChar, 20, "phone");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@street_address", SqlDbType.NVarChar, 100, "street_address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@suburb", SqlDbType.NVarChar, 50, "suburb");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@postal_code", SqlDbType.NVarChar, 10, "postal_code");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_guest_id", SqlDbType.Int, 10, "guest_id");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        // Create the INSERT SQL command to insert a new guest
        private void Create_INSERT_Command(Guest aGuest)
        {
            daMain.InsertCommand = new SqlCommand(
                "INSERT INTO Guest (guest_id, first_name, last_name, email, phone, street_address, suburb, postal_code) " +
                "VALUES (@guest_id, @first_name, @last_name, @email, @phone, @street_address, @suburb, @postal_code)", cnMain);
            Build_INSERT_Parameters(aGuest); // Build parameters for the query
        }

        // Create the UPDATE SQL command to update an existing guest
        private void Create_UPDATE_Command(Guest aGuest)
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE Guest SET first_name = @first_name, last_name = @last_name, email = @email, " +
                "phone = @phone, street_address = @street_address, suburb = @suburb, postal_code = @postal_code " +
                "WHERE guest_id = @Original_guest_id", cnMain);
            Build_UPDATE_Parameters(aGuest); // Build parameters for the query
        }

        // Finalize changes by updating the database with new or updated guest data
        public bool UpdateDataSource(Guest aGuest)
        {
            bool success = true;
            Create_INSERT_Command(aGuest); // Build the INSERT command
            Create_UPDATE_Command(aGuest); // Build the UPDATE command
            success = UpdateDataSource(sqlLocal, table); // Call the base class method to update the data source
            return success;
        }
        #endregion
    }
}
