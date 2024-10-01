using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Business;

namespace HotelBookingSystem.Presentation
{
    public partial class FindCustomerForm : Form
    {
        private bool backButtonPressed = false;
        private GuestController guestController;
        private Booking currentBooking;

        public FindCustomerForm(Booking currentBooking)
        {
            InitializeComponent();

            // Attach the FormClosing event
            this.FormClosing += Close_Form;

            guestController = new GuestController();

            // Disable the search button until a valid email is entered
            searchButton.Enabled = false;
            this.currentBooking = currentBooking;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backButtonPressed = true;
            this.Close();
            // Find the HomeForm in the collection of open forms
            foreach (Form form in Application.OpenForms)
            {
                if (form is PricingForm)
                {
                    form.Show(); // Show the LoginForm if found
                    break;
                }
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            backButtonPressed = true;
            this.Close();

            // Create a copy of the currently open forms
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();

            // Iterate over the copied array of open forms
            foreach (Form form in openForms)
            {
                if (form is PricingForm)
                {
                    form.Close(); // Close the PricingForm if found
                }
                else if (form is MakeABookingForm)
                {
                    form.Close(); // Close the MakeABookingForm if found
                }
                else if (form is HomeForm)
                {
                    form.Show(); // Show the HomeForm if found
                }
            }
        }

        private void Close_Form(object sender, FormClosingEventArgs e)
        {
            if (!backButtonPressed && this.Visible) Application.Exit();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text.Trim();
            bool userFound = guestController.FindByGuestEmail(email);

            if (userFound)
            {
                MessageBox.Show($"Email: {email}\nSend OTP to email?", "Customer found", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                currentBooking.Guest = guestController.FindGuestByEmail(email);
                this.Hide(); // Hide the current form
                OTPForm otpForm = new OTPForm(currentBooking);
                otpForm.Show(); // Show the new OTPForm
            }
            else
            {
                DialogResult result = MessageBox.Show("Customer not found. Please register new customer.", "Customer not found", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    currentBooking.Guest.Email = emailTextBox.Text;
                    this.Hide(); // Hide the current form
                    RegisterNewCustomerForm registerNewCustomer = new RegisterNewCustomerForm(currentBooking);
                    registerNewCustomer.Show(); // Show the new RegisterNewCustomerForm
                }
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEmail(emailTextBox.Text))
            {
                searchButton.Enabled = true; // Enable search button if the email is valid
                searchButton.BackColor = Color.Black;
            }
            else
            {
                searchButton.Enabled = false; // Disable search button if the email is invalid
                searchButton.BackColor = Color.LightGray;
            }
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
    }
}
