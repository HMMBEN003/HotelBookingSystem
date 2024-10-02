using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HotelBookingSystem.Presentation
{
    public partial class HomeForm : Form
    {
        private string employeeName;
        private bool logOutButtonPressed = false;

        public HomeForm()
        {
            InitializeComponent();
        }

        #region Constructor
        public HomeForm(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
            nameLabel.Text = employeeName;  // Display employee name in label1

            // Attach the FormClosing event
            this.FormClosing += Close_Form;
        }
        #endregion

        private void makeABookingButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            MakeABookingForm makeABookingForm = new MakeABookingForm();
            makeABookingForm.Show(); // Show the new MakeABookingForm
        }

        // This function is called when the form is closing
        private void Close_Form(object sender, FormClosingEventArgs e)
        {

            if (!logOutButtonPressed) Application.Exit(); // Terminate the entire program

        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                logOutButtonPressed = true;
                this.Close();
                // Find the LoginForm in the collection of open forms
                foreach (Form form in Application.OpenForms)
                {
                    if (form is LoginForm)
                    {
                        form.Show(); // Show the LoginForm if found
                        break;
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            TestForm testForm = new TestForm();
            testForm.Show(); // Show the new MakeABookingForm
        }
    }
}
