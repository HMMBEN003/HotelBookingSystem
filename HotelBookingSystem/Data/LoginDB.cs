using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBookingSystem.Data
{
    public class LoginDB : DB
    {
        private string table = "LoginCredentials";
        private string sqlLocal = "SELECT * FROM LoginCredentials";

        public LoginDB() : base()
        {
            FillDataSet(sqlLocal, table);  // Load login data from the database.
        }

        // Method to verify if a staff number exists and if the password is correct.
        public bool VerifyCredentials(string staffNumber, string password)
        {
            DataRow myRow = null;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    string dbStaffNumber = Convert.ToString(myRow["staff_number"]).TrimEnd();
                    string dbPassword = Convert.ToString(myRow["password"]).TrimEnd();

                    // Check if the provided staff number matches and if the password is correct.
                    if (dbStaffNumber == staffNumber && dbPassword == password)
                    {
                        return true;  // Credentials are correct.
                    }
                }
            }
            return false;  // Credentials are incorrect.
        }

        // Method to get the name of the employee with the given staff number.
        public string GetEmployeeName(string staffNumber)
        {
            DataRow myRow = null;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    string dbStaffNumber = Convert.ToString(myRow["staff_number"]).TrimEnd();

                    // If the staff number matches, return the employee's name.
                    if (dbStaffNumber == staffNumber)
                    {
                        return Convert.ToString(myRow["name"]).TrimEnd();
                    }
                }
            }
            // If no match is found, return null.
            return null;
        }

    }
}
