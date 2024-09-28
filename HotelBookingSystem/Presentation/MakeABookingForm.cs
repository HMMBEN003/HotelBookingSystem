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
    public partial class MakeABookingForm : Form
    {
        private bool backButtonPressed = false;

        public MakeABookingForm()
        {
            InitializeComponent();
            // Attach the FormClosing event
            this.FormClosing += Close_Form;
        }


        private void Close_Form(object sender, FormClosingEventArgs e)
        {
            if (!backButtonPressed) Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backButtonPressed = true;
            this.Close();
            // Find the HomeForm in the collection of open forms
            foreach (Form form in Application.OpenForms)
            {
                if (form is HomeForm)
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
            // Find the HomeForm in the collection of open forms
            foreach (Form form in Application.OpenForms)
            {
                if (form is HomeForm)
                {
                    form.Show(); // Show the HomeForm if found
                    break;
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
