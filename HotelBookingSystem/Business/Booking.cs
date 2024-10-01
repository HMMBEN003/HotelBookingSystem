using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Business
{
    public class Booking
    {
        private Collection<Room> _rooms;
        private float _total = 0;
        private DateTime _checkInDate;
        private DateTime _checkOutDate;
        private Guest _guest;

        public Booking()
        {
            _rooms = new Collection<Room>(); // Initialize the collection in the constructor
            _guest = new Guest();
        }

        // Property for _rooms
        public Collection<Room> Rooms
        {
            get { return _rooms; }
            set { _rooms = value; }
        }

        // Property for _total
        public float Total
        {
            get { return _total; }
            set { _total = value; }
        }

        // Property for _checkInDate
        public DateTime CheckInDate
        {
            get { return _checkInDate; }
            set { _checkInDate = value; }
        }

        // Property for _checkOutDate
        public DateTime CheckOutDate
        {
            get { return _checkOutDate; }
            set { _checkOutDate = value; }
        }

        // Property for _guest
        public Guest Guest
        {
            get { return _guest; }
            set { _guest = value; }
        }

        // Method to add a room to the booking
        public void AddRoom(Room room)
        {
            if (!_rooms.Contains(room))
            {
                _rooms.Add(room);
            }
        }

        // Method to remove a room from the booking
        public void RemoveRoom(Room room)
        {
            if (_rooms.Contains(room))
            {
                _rooms.Remove(room);
            }
        }

        // Method to clear all rooms from the booking
        public void ClearRooms()
        {
            _rooms.Clear();  // Clear all rooms from the collection
            _total = 0;      // Reset the total to 0
        }
    }
}
