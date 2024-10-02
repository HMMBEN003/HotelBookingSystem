using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using HotelBookingSystem.Business;

namespace HotelBookingSystem.Data
{
    public class BookingDB : DB
    {
        #region Data Members

        private string table = "Booking"; // Table name in the database
        private string bookingRoomsTable = "Booking_Rooms"; // Table for booking rooms
        private string sqlLocal = "SELECT * FROM Booking"; // SQL query to select all bookings
        private Collection<Booking> bookings; // Collection to hold Booking objects

        #endregion

        #region Property Method: Collection

        // Expose all bookings as a collection
        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }

        #endregion

        #region Constructor

        // Constructor initializes the booking collection and fills it with data from the database
        public BookingDB() : base()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sqlLocal, table); // Fill the dataset with booking data
            Add2Collection(table); // Convert dataset rows into Booking objects
        }

        #endregion

        #region Utility Methods

        // Convert the rows in the dataset into Booking objects and add them to the collection
        private void Add2Collection(string table)
        {
            Booking aBooking;

            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    aBooking = new Booking
                    {
                        Guest = new Guest { GuestId = Convert.ToInt32(row["guest_id"]) },
                        CheckInDate = Convert.ToDateTime(row["check_in_date"]),
                        CheckOutDate = Convert.ToDateTime(row["check_out_date"]),
                        Total = Convert.ToSingle(row["total_price"])
                    };

                    bookings.Add(aBooking);
                }
            }
        }

        // Fill the dataset with booking data and map the Booking object to a DataRow
        private void FillRow(DataRow aRow, Booking aBooking, DB.DBOperation operation)
        {
            // Do not set booking_id manually; it's an identity column
            aRow["guest_id"] = aBooking.Guest.GuestId;
            aRow["check_in_date"] = aBooking.CheckInDate;
            aRow["check_out_date"] = aBooking.CheckOutDate;
            aRow["total_price"] = aBooking.Total;
            aRow["status"] = "Pending"; // Default status
        }

        // Find the index of a specific booking by Guest ID
        private int FindRow(Booking aBooking, string table)
        {
            int rowIndex = 0;
            int returnValue = -1;

            foreach (DataRow myRow in dsMain.Tables[table].Rows)
            {
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (aBooking.Guest.GuestId == Convert.ToInt32(myRow["guest_id"]))
                    {
                        returnValue = rowIndex; // If booking found, return the row index
                        break;
                    }
                }
                rowIndex++;
            }

            return returnValue;
        }

        // Save the booking and its rooms to the database
        public bool SaveBooking(Booking booking)
        {
            bool success = true;

            try
            {
                Create_INSERT_Command(booking); // Build the INSERT command for booking
                cnMain.Open(); // Open the connection

                // Execute the insert query and get the inserted booking_id
                var result = daMain.InsertCommand.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    int bookingId = Convert.ToInt32(result);
                    booking.ID = bookingId;
                }
                else
                {
                    throw new Exception("Failed to retrieve the inserted booking ID.");
                }

                cnMain.Close();
            }
            catch (Exception ex)
            {
                // Rethrow the exception with additional context
                throw new Exception("Error in SaveBooking: " + ex.Message, ex);
            }

            return success;
        }

        // Method to save associated rooms into the Booking_Rooms table
        public void SaveBookingRooms(Booking booking)
        {
            string sql = "INSERT INTO Booking_Rooms (booking_id, room_id) VALUES (@bookingId, @roomId)";

            try
            {
                if (cnMain.State == ConnectionState.Closed)
                {
                    cnMain.Open();
                }

                SqlCommand cmd = new SqlCommand(sql, cnMain);

                // Loop through each room and save it to the Booking_Rooms table
                foreach (Room room in booking.Rooms)
                {
                    cmd.Parameters.Clear(); // Clear previous parameters
                    cmd.Parameters.AddWithValue("@bookingId", booking.ID); // Ensure booking.ID has been retrieved after saving the booking
                    cmd.Parameters.AddWithValue("@roomId", room.RoomId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error in SaveBookingRooms: " + ex.Message, ex);
            }
            finally
            {
                if (cnMain.State == ConnectionState.Open)
                {
                    cnMain.Close();
                }
            }
        }

        // Perform CRUD operations (Add, Edit, Delete) on bookings
        public void DataSetChange(Booking aBooking, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table].NewRow();
                    FillRow(aRow, aBooking, operation);
                    dsMain.Tables[table].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[table].Rows[FindRow(aBooking, table)];
                    FillRow(aRow, aBooking, operation);
                    break;
                case DB.DBOperation.Delete:
                    aRow = dsMain.Tables[table].Rows[FindRow(aBooking, table)];
                    aRow.Delete();
                    break;
            }
        }

        // Finalize changes by updating the database with new or updated booking data
        public bool UpdateDataSource(Booking aBooking)
        {
            bool success = true;
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }

        #region Build Parameters and Create Commands

        // Prepare parameters for an INSERT command
        private void Build_INSERT_Parameters(Booking aBooking)
        {
            daMain.InsertCommand.Parameters.AddWithValue("@guest_id", aBooking.Guest.GuestId);
            daMain.InsertCommand.Parameters.AddWithValue("@booking_date", DateTime.Now);

            daMain.InsertCommand.Parameters.Add("@check_in_date", SqlDbType.Date);
            daMain.InsertCommand.Parameters["@check_in_date"].Value = aBooking.CheckInDate != DateTime.MinValue
                ? (object)aBooking.CheckInDate
                : DBNull.Value;

            daMain.InsertCommand.Parameters.Add("@check_out_date", SqlDbType.Date);
            daMain.InsertCommand.Parameters["@check_out_date"].Value = aBooking.CheckOutDate != DateTime.MinValue
                ? (object)aBooking.CheckOutDate
                : DBNull.Value;

            daMain.InsertCommand.Parameters.AddWithValue("@total_price", aBooking.Total);
            daMain.InsertCommand.Parameters.AddWithValue("@status", "Confirmed");
        }

        // Create the INSERT SQL command to insert a new booking using OUTPUT clause
        private void Create_INSERT_Command(Booking aBooking)
        {
            daMain.InsertCommand = new SqlCommand(
                "INSERT INTO Booking (guest_id, booking_date, check_in_date, check_out_date, total_price, status) " +
                "OUTPUT INSERTED.booking_id " +
                "VALUES (@guest_id, @booking_date, @check_in_date, @check_out_date, @total_price, @status)", cnMain);
            Build_INSERT_Parameters(aBooking); // Build parameters for the query
        }

        // Prepare parameters for an UPDATE command
        private void Build_UPDATE_Parameters(Booking aBooking)
        {
            daMain.UpdateCommand.Parameters.AddWithValue("@check_in_date", aBooking.CheckInDate);
            daMain.UpdateCommand.Parameters.AddWithValue("@check_out_date", aBooking.CheckOutDate);
            daMain.UpdateCommand.Parameters.AddWithValue("@total_price", aBooking.Total);
            daMain.UpdateCommand.Parameters.AddWithValue("@status", "Confirmed");

            SqlParameter param = new SqlParameter("@Original_booking_id", SqlDbType.Int);
            param.Value = aBooking.ID;
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        // Create the UPDATE SQL command to update an existing booking
        private void Create_UPDATE_Command(Booking aBooking)
        {
            daMain.UpdateCommand = new SqlCommand(
                "UPDATE Booking SET check_in_date = @check_in_date, check_out_date = @check_out_date, " +
                "total_price = @total_price, status = @status WHERE booking_id = @Original_booking_id", cnMain);
            Build_UPDATE_Parameters(aBooking); // Build parameters for the query
        }

        #endregion
        #endregion
    }
}
