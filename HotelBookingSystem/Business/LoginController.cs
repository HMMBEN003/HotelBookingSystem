using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelBookingSystem.Data;

namespace HotelBookingSystem.Business
{
    public class LoginController
    {
        private LoginDB loginDB;

        public LoginController()
        {
            // Instantiate the LoginDB to communicate with the database.
            loginDB = new LoginDB();
        }

        // Method to check if the provided staff number and password are correct.
        public bool Login(string staffNumber, string password)
        {
            return loginDB.VerifyCredentials(staffNumber, password);
        }

        public string GetEmployeeName(string staffNumber)
        {
            return loginDB.GetEmployeeName(staffNumber);
        }
    }
}
