using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAndroid
{
    public partial class Services : UserControl
    {
        public Services()
        {
            InitializeComponent();
            pnlCooking.BringToFront();

            
        }

        private void Services_Load(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cookingService1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlCooking.BringToFront();
            tabcooking.BackColor = Color.MistyRose;
            tabCleaning.BackColor = Color.White;
            tabLaundry.BackColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            cleaningService1.BringToFront();
            tabcooking.BackColor = Color.White;
            tabLaundry.BackColor= Color.White;
            tabCleaning.BackColor= Color.MistyRose;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            laundryService1.BringToFront();
            tabcooking.BackColor = Color.White;
            tabCleaning.BackColor = Color.White;
            tabLaundry.BackColor = Color.MistyRose;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
