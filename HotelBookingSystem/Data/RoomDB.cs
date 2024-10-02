using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using HotelBookingSystem.Business;

namespace HotelBookingSystem.Data
{
    // This class handles database communication for Room-related data
    public class RoomDB : DB
    {
        #region Data Members
        private string table = "Room"; // Table name in the database
        private string roomFeaturesTable = "RoomFeatures"; // Table name in the database
        private string sqlLocal = "SELECT * FROM Room"; // SQL query to select all rooms
        private Collection<Room> rooms; // Collection to hold Room objects
        #endregion

        #region Property Method: Collection
        // Expose all rooms as a collection
        public Collection<Room> AllRooms
        {
            get
            {
                return rooms;
            }
        }
        #endregion

        #region Constructor
        // Constructor initializes the room collection and fills it with data from the database
        public RoomDB() : base()
        {
            rooms = new Collection<Room>();
            FillDataSet(sqlLocal, table); // Fill the dataset with room data from the database
            Add2Collection(table); // Convert dataset rows into Room objects
        }

        public RoomDB(DateTime checkInTime, DateTime checkOutTime) : base()
        {
            rooms = GetAvailableRooms(checkInTime, checkOutTime);
        }
        #endregion

        #region Utility Methods
        // Get the dataset containing the rooms
        public DataSet GetDataSet()
        {
            return dsMain; // Return the main dataset from the base class (DB)
        }

        // Convert the rows in the dataset into Room objects and add them to the collection
        private void Add2Collection(string table)
        {
            DataRow myRow = null;
            Room aRoom;

            // Loop through each row in the dataset and create Room objects
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted)) // Check if the row is not marked for deletion
                {
                    // Retrieve features for the room
                    List<string> features = GetRoomFeatures(Convert.ToInt32(myRow["room_id"]));

                    // Create a Room object from the data in the current row and pass the features
                    aRoom = new Room(
                        Convert.ToInt32(myRow["room_id"]),
                        Convert.ToString(myRow["room_number"]).TrimEnd(),
                        features,  // Pass the list of features here
                        Convert.ToDecimal(myRow["low_season_price"]),
                        Convert.ToDecimal(myRow["mid_season_price"]),
                        Convert.ToDecimal(myRow["high_season_price"]),
                        Convert.ToInt32(myRow["adults"]),
                        Convert.ToInt32(myRow["teens"]),
                        Convert.ToInt32(myRow["infants"])
                    );

                    // Add the Room object to the collection
                    rooms.Add(aRoom);
                }
            }
        }

        public void UpdateRoomOccupants(int roomId, int adults, int teens, int infants)
        {
            string sql = "UPDATE Room SET adults = @adults, teens = @teens, infants = @infants WHERE room_id = @room_id";

            try
            {
                if (cnMain.State == ConnectionState.Closed)
                {
                    cnMain.Open(); // Open the connection
                }

                SqlCommand cmd = new SqlCommand(sql, cnMain);
                cmd.Parameters.AddWithValue("@room_id", roomId);
                cmd.Parameters.AddWithValue("@adults", adults);
                cmd.Parameters.AddWithValue("@teens", teens);
                cmd.Parameters.AddWithValue("@infants", infants);

                cmd.ExecuteNonQuery(); // Execute the query
            }
            finally
            {
                if (cnMain.State == ConnectionState.Open)
                {
                    cnMain.Close(); // Ensure connection is closed
                }
            }
        }


        // Fill the dataset with room data and map the Room object to a DataRow
        private void FillRow(DataRow aRow, Room aRoom, DB.DBOperation operation)
        {
            if (operation == DBOperation.Add)
            {
                aRow["room_id"] = aRoom.RoomId;  // Auto-assigned Room ID
            }
            aRow["room_number"] = aRoom.RoomNumber; // Assign room number
            aRow["low_season_price"] = aRoom.LowSeasonPrice; // Assign prices for seasons
            aRow["mid_season_price"] = aRoom.MidSeasonPrice;
            aRow["high_season_price"] = aRoom.HighSeasonPrice;
            aRow["adults"] = aRoom.Adults; // Assign adults
            aRow["teens"] = aRoom.Teens; // Assign teens
            aRow["infants"] = aRoom.Infants; // Assign infants
        }

        // Find the index of a specific room by Room ID
        private int FindRow(Room aRoom, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1; // Default return value if not found

            // Loop through dataset to find the row with the matching room_id
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;

                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    if (aRoom.RoomId == Convert.ToInt32(dsMain.Tables[table].Rows[rowIndex]["room_id"]))
                    {
                        returnValue = rowIndex; // If room found, return the row index
                        break;
                    }
                }

                rowIndex++;
            }

            return returnValue; // Return the index of the found room, or -1 if not found
        }

        #region GetRoomFeatures Method

        // Method to get room features for a given room ID
        private List<string> GetRoomFeatures(int roomId)
        {
            List<string> features = new List<string>();

            try
            {
                string sql = @"
            SELECT feature_name
            FROM RoomFeatures
            WHERE room_id = @roomId";

                using (SqlConnection conn = new SqlConnection(cnMain.ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomId", roomId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string featureName = reader["feature_name"].ToString();
                                features.Add(featureName);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetRoomFeatures: " + ex.Message, ex);
            }

            return features;
        }


        #endregion

        #region GetAvailableRooms Method

        // Method to get available rooms for a given date range
        public Collection<Room> GetAvailableRooms(DateTime checkInDate, DateTime checkOutDate)
        {
            Collection<Room> availableRooms = new Collection<Room>();

            try
            {
                string sql = @"
                    SELECT * FROM Room WHERE room_id NOT IN (
                        SELECT DISTINCT br.room_id
                        FROM Booking_Rooms br
                        INNER JOIN Booking b ON br.booking_id = b.booking_id
                        WHERE b.check_in_date < @checkOutDate AND b.check_out_date > @checkInDate
                    )";

                using (SqlCommand cmd = new SqlCommand(sql, cnMain))
                {
                    cmd.Parameters.AddWithValue("@checkInDate", checkInDate);
                    cmd.Parameters.AddWithValue("@checkOutDate", checkOutDate);

                    if (cnMain.State == ConnectionState.Closed)
                    {
                        cnMain.Open();
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Room room = new Room(
                                Convert.ToInt32(reader["room_id"]),
                                Convert.ToString(reader["room_number"]).TrimEnd(),
                                GetRoomFeatures(Convert.ToInt32(reader["room_id"])),  // Pass the list of features here
                                Convert.ToDecimal(reader["low_season_price"]),
                                Convert.ToDecimal(reader["mid_season_price"]),
                                Convert.ToDecimal(reader["high_season_price"]),
                                Convert.ToInt32(reader["adults"]),
                                Convert.ToInt32(reader["teens"]),
                                Convert.ToInt32(reader["infants"])
                            );
                            availableRooms.Add(room);
                        }
                    }

                    cnMain.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in GetAvailableRooms: " + ex.Message, ex);
            }

            return availableRooms;
        }

        #endregion
        #endregion

        #region Database Operations CRUD
        // Perform CRUD operations (Add, Edit, Delete) on rooms
        public void DataSetChange(Room aRoom, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow(); // Create a new row
                    FillRow(aRow, aRoom, operation); // Fill the row with data
                    dsMain.Tables[table].Rows.Add(aRow); // Add the row to the dataset
                    break;

                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(aRoom, table)]; // Find the row to edit
                    FillRow(aRow, aRoom, operation);  // Fill with updated data
                    break;

                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[table].Rows[FindRow(aRoom, table)]; // Find the row to delete
                    aRow.Delete();  // Mark the row as deleted
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update Database
        // Prepare parameters for an INSERT command
        private void Build_INSERT_Parameters(Room aRoom)
        {
            SqlParameter param = new SqlParameter("@room_id", SqlDbType.Int, 10, "room_id");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@room_number", SqlDbType.NVarChar, 10, "room_number");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@low_season_price", SqlDbType.Decimal, 10, "low_season_price");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@mid_season_price", SqlDbType.Decimal, 10, "mid_season_price");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@high_season_price", SqlDbType.Decimal, 10, "high_season_price");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@adults", SqlDbType.Int, 10, "adults");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@teens", SqlDbType.Int, 10, "teens");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@infants", SqlDbType.Int, 10, "infants");
            daMain.InsertCommand.Parameters.Add(param);
        }

        // Prepare parameters for an UPDATE command
        private void Build_UPDATE_Parameters(Room aRoom)
        {
            SqlParameter param = new SqlParameter("@room_number", SqlDbType.NVarChar, 10, "room_number");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@low_season_price", SqlDbType.Decimal, 10, "low_season_price");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@mid_season_price", SqlDbType.Decimal, 10, "mid_season_price");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@high_season_price", SqlDbType.Decimal, 10, "high_season_price");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@adults", SqlDbType.Int, 10, "adults");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@teens", SqlDbType.Int, 10, "teens");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@infants", SqlDbType.Int, 10, "infants");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_room_id", SqlDbType.Int, 10, "room_id");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        // Create the INSERT SQL command to insert a new room
        private void Create_INSERT_Command(Room aRoom)
        {
            daMain.InsertCommand = new SqlCommand(
                "INSERT INTO Room (room_id, room_number, low_season_price, mid_season_price, high_season_price, adults, teens, infants) " +
                "VALUES (@room_id, @room_number, @low_season_price, @mid_season_price, @high_season_price, @adults, @teens, @infants)", cnMain);
            Build_INSERT_Parameters(aRoom); // Build parameters for the query
        }

        // Create the UPDATE SQL command to update an existing room
        private void Create_UPDATE_Command(Room aRoom)
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE Room SET room_number = @room_number, low_season_price = @low_season_price, " +
                "mid_season_price = @mid_season_price, high_season_price = @high_season_price, " +
                "adults = @adults, teens = @teens, infants = @infants " +
                "WHERE room_id = @Original_room_id", cnMain);
            Build_UPDATE_Parameters(aRoom); // Build parameters for the query
        }

        // Finalize changes by updating the database with new or updated room data
        public bool UpdateDataSource(Room aRoom)
        {
            bool success = true;
            Create_INSERT_Command(aRoom); // Build the INSERT command
            Create_UPDATE_Command(aRoom); // Build the UPDATE command
            success = UpdateDataSource(sqlLocal, table); // Call the base class method to update the data source
            return success;
        }
        #endregion
    }
}
