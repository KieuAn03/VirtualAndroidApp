using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppAndroid.Properties;
namespace AppAndroid
{
    public partial class LaundryService : UserControl
    {
        public LaundryService()
        {
            InitializeComponent();
            ServiceItem item = new ServiceItem();
            item.ckcChoose.Text = "Giặt quần áo";
            item.lblPrice.Text = "100000";
            item.picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            item.picImg.Image = Resources.Giatui01;
            flowLayoutPanel1.Controls.Add(item);
            item = new ServiceItem();
            item.ckcChoose.Text = "Giặt quần áo & chăn ga";
            item.lblPrice.Text =  "150000";
            item.picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            item.picImg.Image = Resources.GiatUi04;
            flowLayoutPanel1.Controls.Add(item);
            item = new ServiceItem();
            item.ckcChoose.Text = "Ủi là";
            item.lblPrice.Text = "100000";
            item.picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            item.picImg.Image = Resources.giat_ui;
            flowLayoutPanel1.Controls.Add(item);
            item = new ServiceItem();
            item.ckcChoose.Text = "Combo Giặt, ủi";
            item.lblPrice.Text = "325000";
            item.picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            item.picImg.Image = Resources.Giatui02;
            flowLayoutPanel1.Controls.Add(item);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
