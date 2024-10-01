using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions; // Import for Regex validation
using System.Windows.Forms;
using HotelBookingSystem.Business;

namespace HotelBookingSystem.Presentation
{
    public partial class RegisterNewCustomerForm : Form
    {
        private bool backButtonPressed = false;
        private Booking currentBooking;

        public RegisterNewCustomerForm(Booking currentBooking)
        {
            InitializeComponent();

            // Attach the FormClosing event
            this.FormClosing += Close_Form;

            this.currentBooking = currentBooking;
            emailAddressTextBox.Text = currentBooking.Guest.Email;
            emailAddressTextBox.Enabled = false;
            emailAddressTextBox.BackColor = Color.LightGray;

            // Attach validation to the text boxes
            firstNameTextBox.TextChanged += ValidateForm;
            surnameTextBox.TextChanged += ValidateForm;
            phoneNumberTextBox.TextChanged += ValidateForm;
            streetAddressTextBox.TextChanged += ValidateForm;
            suburbTextBox.TextChanged += ValidateForm;
            postalCodeTextBox.TextChanged += ValidateForm;

            // Initially disable the Verify button
            verifyButton.Enabled = false;
        }

        private void ValidateForm(object sender, EventArgs e)
        {
            bool isValid = true;

            // Validate First Name
            if (!IsValidName(firstNameTextBox.Text))
            {
                firstNameTextBox.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                firstNameTextBox.BackColor = Color.White;
            }

            // Validate Surname
            if (!IsValidName(surnameTextBox.Text))
            {
                surnameTextBox.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                surnameTextBox.BackColor = Color.White;
            }

            // Validate Phone Number
            if (!IsValidPhoneNumber(phoneNumberTextBox.Text))
            {
                phoneNumberTextBox.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                phoneNumberTextBox.BackColor = Color.White;
            }

            // Validate Street Address
            if (!IsValidAddress(streetAddressTextBox.Text))
            {
                streetAddressTextBox.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                streetAddressTextBox.BackColor = Color.White;
            }

            // Validate Suburb
            if (!IsValidAddress(suburbTextBox.Text))
            {
                suburbTextBox.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                suburbTextBox.BackColor = Color.White;
            }

            // Validate Postal Code
            if (!IsValidPostalCode(postalCodeTextBox.Text))
            {
                postalCodeTextBox.BackColor = Color.LightCoral;
                isValid = false;
            }
            else
            {
                postalCodeTextBox.BackColor = Color.White;
            }

            // Enable or disable the Verify button based on overall validity
            verifyButton.Enabled = isValid;
            verifyButton.BackColor = isValid ? Color.Black : Color.LightGray;
        }

        // Validation methods
        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^[a-zA-Z]+$");
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\+?[0-9]{7,15}$"); // Allows + for international numbers
        }

        private bool IsValidAddress(string address)
        {
            return !string.IsNullOrWhiteSpace(address);
        }

        private bool IsValidPostalCode(string postalCode)
        {
            return Regex.IsMatch(postalCode, @"^\d{4,5}$"); // 4-5 digit postal codes
        }

        private void Close_Form(object sender, FormClosingEventArgs e)
        {
            if (!backButtonPressed && this.Visible) Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backButtonPressed = true;
            this.Close();
            // Find the FindCustomerForm in the collection of open forms
            foreach (Form form in Application.OpenForms)
            {
                if (form is FindCustomerForm)
                {
                    form.Show(); // Show the FindCustomerForm if found
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
                if (form is FindCustomerForm)
                {
                    form.Close(); // Close the MakeABookingForm if found
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

        private void verifyButton_Click(object sender, EventArgs e)
        {
            currentBooking.Guest.FirstName = firstNameTextBox.Text;
            currentBooking.Guest.LastName = surnameTextBox.Text;
            currentBooking.Guest.Phone = phoneNumberTextBox.Text;
            currentBooking.Guest.StreetAddress = streetAddressTextBox.Text;
            currentBooking.Guest.Suburb = suburbTextBox.Text;
            currentBooking.Guest.PostalCode = postalCodeTextBox.Text;

            DialogResult result = MessageBox.Show("Verify customer.\nSend OTP to email?", "Customer Verification", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK) 
            {
                this.Hide(); // Hide the current form
                OTPForm otpForm = new OTPForm(currentBooking);
                otpForm.Show(); // Show the new OTPForm
            }

        }
    }
}
