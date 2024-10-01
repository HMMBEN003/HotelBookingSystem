using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelBookingSystem.Business;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HotelBookingSystem.Presentation
{
    public partial class OTPForm : Form
    {
        private bool backButtonPressed = false;
        private Booking currentBooking;

        public OTPForm(Booking currentBooking)
        {
            InitializeComponent();
            this.currentBooking = currentBooking;

            emailLabel.Text = currentBooking.Guest.Email;

            // Attach the FormClosing event
            this.FormClosing += Close_Form;
        }

        private void Close_Form(object sender, FormClosingEventArgs e)
        {
            if (!backButtonPressed && this.Visible) Application.Exit();
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
                if (form is RegisterNewCustomerForm)
                {
                    form.Close(); // Close the PricingForm if found
                }
                else if (form is PricingForm)
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

        private void backButton_Click(object sender, EventArgs e)
        {
            backButtonPressed = true;
            this.Close();

            // Check if a form of type 'FindCustomerForm' is open
            bool isFormOpen = Application.OpenForms.OfType<RegisterNewCustomerForm>().Any();

            // Find the HomeForm in the collection of open forms
            foreach (Form form in Application.OpenForms)
            {
                if (form is RegisterNewCustomerForm)
                {
                    form.Show(); // Show the LoginForm if found
                    break;
                }
                if (form is FindCustomerForm && !isFormOpen)
                {
                    form.Show(); // Show the LoginForm if found
                    break;
                }
            }
        }

        private void resendOTPButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Email: {currentBooking.Guest.Email}\nOTP has been resent to the customer's email", "OTP resent", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            if(OTPtextBox.Text == "1234")
            {
                currentBooking.Guest.Verified = true;
                MessageBox.Show($"The OTP has been verified", "OTP Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                summariseBookingButton.Enabled = true;
                summariseBookingButton.BackColor = Color.Black;
            } else
            {
                MessageBox.Show($"The OTP is invalid\nPlease try again", "OTP Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void summariseBookingButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            BookingSummaryForm bookingSummaryForm = new BookingSummaryForm(currentBooking);
            bookingSummaryForm.Show(); // Show the new BookingSummaryForm
        }
    }
}
