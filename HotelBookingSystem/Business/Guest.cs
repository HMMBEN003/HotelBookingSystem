using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Business
{
    public class Guest
    {
        // Private fields
        private int _guestId;
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _phone;
        private string _streetAddress;
        private string _suburb;
        private string _postalCode;
        private bool _verified;

        // Constructor
        public Guest()
        {
            _verified = false;
        }

        public Guest(int guestId, string firstName, string lastName, string email, string phone, string streetAddress, string suburb, string postalCode)
        {
            _guestId = guestId;
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _phone = phone;
            _streetAddress = streetAddress;
            _suburb = suburb;
            _postalCode = postalCode;
            _verified = false;
        }

        // Properties
        public int GuestId
        {
            get { return _guestId; }
            set { _guestId = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }

        public string Suburb
        {
            get { return _suburb; }
            set { _suburb = value; }
        }

        public string PostalCode
        {
            get { return _postalCode; }
            set { _postalCode = value; }
        }

        public bool Verified
        {
            get { return _verified; }
            set { _verified = value; }
        }

        // ToString method for a quick display of guest info
        public override string ToString()
        {
            return $"{_firstName} {_lastName}, {_email}, {_phone}, {_streetAddress}, {_suburb}, {_postalCode}";
        }
    }
}
