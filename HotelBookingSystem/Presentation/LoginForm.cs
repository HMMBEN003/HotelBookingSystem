using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Business;
using HotelBookingSystem.Presentation;

namespace HotelBookingSystem
{
    public partial class LoginForm : Form
    {
        #region Data Members
        private LoginController loginController;
        #endregion

        #region Constructor
        public LoginForm()
        {
            InitializeComponent();
            loginController = new LoginController();
        }
        #endregion

        private void logInButton_Click(object sender, EventArgs e)
        {
            string staffNumber = staffNumberTextBox.Text;
            string password = passwordTextBox.Text;
            bool isValid = loginController.Login(staffNumber, password);

            if (isValid)
            {
                // Login Successful
                incorrectLabel.Visible = false;
                string employeeName = loginController.GetEmployeeName(staffNumber);

                staffNumberTextBox.Text = "";
                passwordTextBox.Text = "";

                // Pass employeeName to the new form
                HomeForm homeForm = new HomeForm(employeeName);
                this.Hide(); // Hide the current form
                homeForm.Show(); // Show the new HomeForm
            }
            else
            {
                // Login Unsuccessful
                incorrectLabel.Visible = true;
                Console.WriteLine("Invalid staff number or password.");
            }
        }
    }
}
