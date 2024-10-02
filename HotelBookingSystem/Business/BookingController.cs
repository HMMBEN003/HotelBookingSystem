using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Business
{
    public class BookingController
    {
        #region Data Members
        private BookingDB bookingDB; // Database communication object
        private Collection<Booking> bookings; // Collection to store bookings in memory
        #endregion

        #region Properties
        // Expose all bookings as a collection
        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }
        #endregion

        #region Constructor
        // Initialise the bookingDB object and load all bookings into memory
        public BookingController()
        {
            bookingDB = new BookingDB(); // Initialise the DB object
            bookings = bookingDB.AllBookings; // Populate bookings from the database
        }
        #endregion

        #region Database Communication
        // Perform CRUD operations (Add, Edit, Delete) on bookings
        public void DataMaintenance(Booking aBooking, DB.DBOperation operation)
        {
            int index = 0;
            bookingDB.DataSetChange(aBooking, operation); // Call database communication layer

            switch (operation)
            {
                case DB.DBOperation.Add:
                    bookings.Add(aBooking); // Add to collection
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aBooking); // Find index
                    if (index >= 0)
                    {
                        bookings[index] = aBooking; // Update booking in collection
                    }
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(aBooking); // Find index
                    if (index >= 0)
                    {
                        bookings.RemoveAt(index); // Remove booking from collection
                    }
                    break;
            }
        }

        // Commit changes made to the booking collection to the database
        public bool FinaliseChanges(Booking booking)
        {
            return bookingDB.UpdateDataSource(booking); // Call BookingDB to commit changes
        }
        #endregion

        #region Search Method
        // Find a booking by its unique booking ID
        public Booking Find(int bookingId)
        {
            int index = 0;
            bool found = (bookings[index].Guest.GuestId == bookingId); // Check if booking is found

            int count = bookings.Count;
            while (!found && index < (count - 1))
            {
                index++;
                found = (bookings[index].Guest.GuestId == bookingId);
            }

            return found ? bookings[index] : null;
        }

        // Find the index of a booking within the booking collection
        public int FindIndex(Booking aBooking)
        {
            int counter = 0;
            bool found = (aBooking.Guest.GuestId == bookings[counter].Guest.GuestId); // Compare booking IDs

            int count = bookings.Count;
            while (!found && counter < (count - 1))
            {
                counter++;
                found = (aBooking.Guest.GuestId == bookings[counter].Guest.GuestId);
            }

            return found ? counter : -1;
        }
        #endregion

        #region FindByGuest Method
        // Find bookings by a guest's ID
        public Collection<Booking> FindByGuest(int guestId)
        {
            Collection<Booking> matches = new Collection<Booking>();
            foreach (Booking booking in bookings)
            {
                if (booking.Guest.GuestId == guestId)
                {
                    matches.Add(booking); // Add matching booking to collection
                }
            }
            return matches; // Return all bookings matching the guest ID
        }
        #endregion

        #region Add Methods
        // Method to confirm and save the booking
        public void ConfirmBooking(Booking booking)
        {
            if (booking.Guest == null || booking.Guest.GuestId <= 0)
            {
                throw new Exception("Invalid Guest ID: The guest does not exist.");
            }

            if (booking.CheckInDate == DateTime.MinValue || booking.CheckOutDate == DateTime.MinValue)
            {
                throw new Exception("Check-in and check-out dates must be provided.");
            }

            if (booking.CheckOutDate <= booking.CheckInDate)
            {
                throw new Exception("Check-out date must be after check-in date.");
            }

            if (booking.Total <= 0)
            {
                throw new Exception("Total price must be greater than zero.");
            }



            // Insert the booking into the Booking table
            AddBooking(booking);

            // Save the rooms associated with this booking
            RoomDB roomDB = new RoomDB();
            // Now update the room occupants in the Room table
            foreach (Room room in booking.Rooms)
            {
                roomDB.UpdateRoomOccupants(room.RoomId, room.Adults, room.Teens, room.Infants);
            }
        }

        // Method to add a booking to the database and update Booking_Rooms
        public bool AddBooking(Booking booking)
        {
            // Validate that the booking has at least one room and a guest
            if (booking.Guest == null || booking.Rooms.Count == 0)
            {
                throw new ArgumentException("A booking must have at least one guest and one room.");
            }

            // Insert the booking into the Booking table
            bool bookingInserted = bookingDB.SaveBooking(booking);

            if (!bookingInserted)
            {
                throw new Exception("Failed to insert booking.");
            }

            // Save associated rooms into the Booking_Rooms table
            bookingDB.SaveBookingRooms(booking);

            return bookingInserted;
        }
        #endregion
    }
}
