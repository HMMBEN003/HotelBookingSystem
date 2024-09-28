using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelBookingSystem.Presentation
{
    public partial class HomeForm : Form
    {
        private string employeeName;
        public HomeForm()
        {
            InitializeComponent();
        }

        public HomeForm(string employeeName)
        {
            InitializeComponent();
            this.employeeName = employeeName;
            label1.Text = employeeName;  // Display employee name in label1
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Close the current HomeForm and return to LoginForm
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
}
