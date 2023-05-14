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
    public partial class ServiceItem : UserControl
    {
        public ServiceItem()
        {
            InitializeComponent();
        }

        private void picImg_Click(object sender, EventArgs e)
        {
      

        }

        private void picImg_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        public void ServiceItem_Click(object sender, EventArgs e)
        {
            ServiceDetail detail = new ServiceDetail();
            detail.lblNameService.Text = ckcChoose.Text;
            detail.lblPrice.Text = lblPrice.Text;
            detail.pictureBox1.Image = picImg.Image;
            
            detail.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            detail.Show();
            detail.Visible = true;
            detail.BringToFront();

        }

        private void ServiceItem_Load(object sender, EventArgs e)
        {

        }

        public void ServiceItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        public void ServiceItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor= Color.White;
        }
    }
}
