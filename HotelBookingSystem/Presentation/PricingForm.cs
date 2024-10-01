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

namespace HotelBookingSystem.Presentation
{
    public partial class PricingForm : Form
    {
        private Booking currentBooking;
        public PricingForm(Booking currentBooking)
        {
            InitializeComponent();
            this.currentBooking = currentBooking;
        }

 
    }
}
