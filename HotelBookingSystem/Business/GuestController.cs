using System;
using System.Collections.ObjectModel;
using System.Text;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Business
{
    public class GuestController
    {
        #region Data Members
        private GuestDB guestDB; // Reference to the GuestDB class for database interaction
        private Collection<Guest> guests; // Collection to hold guest data
        #endregion

        #region Constructor
        // Constructor initializes the guestDB object and loads guest data
        public GuestController()
        {
            guestDB = new GuestDB(); // Instantiate GuestDB class
            guests = guestDB.GetAllGuests(); // Load all guests from the database
        }
        #endregion

        #region Property Methods
        // Property to expose the collection of guests
        public Collection<Guest> Guests
        {
            get { return guests; }
        }
        #endregion

        #region CRUD Operations
        // Method to add a new guest
        public void AddGuest(Guest guest)
        {
            guestDB.AddGuest(guest); // Add guest to database
            guests.Add(guest); // Add guest to collection
        }

        // Method to edit an existing guest
        public void EditGuest(Guest guest)
        {
            guestDB.EditGuest(guest); // Update guest in database
        }

        // Method to delete a guest
        public void DeleteGuest(Guest guest)
        {
            guestDB.DeleteGuest(guest); // Delete guest from the database
            guests.Remove(guest); // Remove guest from the collection
        }

        // Method to find a guest by their email address and return the guest object
        public Guest FindGuestByEmail(string email)
        {
            foreach (Guest guest in guests)
            {
                if (guest.Email == email)
                {
                    return guest; // Return the guest if found
                }
            }
            return null; // Return null if no guest is found with the given email
        }

        // Method to check if a guest with the given email exists and return a boolean
        public bool FindByGuestEmail(string email)
        {
            foreach (Guest guest in guests)
            {
                if (guest.Email.Equals(email, StringComparison.OrdinalIgnoreCase))
                {
                    return true; // Return true if the email is found
                }
            }
            return false; // Return false if the email is not found
        }
        #endregion

        #region Utility Methods
        // Method to get a formatted list of all guests (useful for displaying in the UI)
        public string GetFormattedGuestList()
        {
            StringBuilder guestList = new StringBuilder();

            foreach (Guest guest in guests)
            {
                guestList.AppendLine(guest.ToString());
            }

            return guestList.ToString(); // Return the formatted string
        }
        #endregion
    }
}
