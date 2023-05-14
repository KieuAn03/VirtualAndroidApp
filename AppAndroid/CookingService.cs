using AppAndroid.Properties;
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
    public partial class CookingService : UserControl
    {
        public CookingService()
        {
            InitializeComponent();
            ServiceItem a = new ServiceItem();
            a.ckcChoose.Text = "Mâm nhỏ";
            a.lblPrice.Text = "150000";
            a.picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            a.picImg.Image = Resources.com031;  
            flowLayoutPanel1.Controls.Add(a);
            a= new ServiceItem();
            a.picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            a.ckcChoose.Text = "Mâm vừa";
            a.lblPrice.Text = "200000";
            a.picImg.Image = Resources.com03;
            flowLayoutPanel1.Controls.Add(a);
            a = new ServiceItem();
            a.picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            a.ckcChoose.Text = "Mâm lớn";
            a.lblPrice.Text = "250000";
            a.picImg.Image= Resources.com04;
            flowLayoutPanel1.Controls.Add(a);
            a = new ServiceItem();
            a.picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            a.ckcChoose.Text = "Siêu tiệc";
            a.lblPrice.Text = "300000";
            a.picImg.Image = Resources.com05;
            flowLayoutPanel1.Controls.Add (a);
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
            
        }
    }
}
