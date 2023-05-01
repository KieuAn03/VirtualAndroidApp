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
    public partial class CleaningService : UserControl
    {
        public CleaningService()
        {
            InitializeComponent();
            ServiceItem item = new ServiceItem();
            item.ckcChoose.Text = "0-100m2";
            item.lblPrice.Text = "200000";
            item.picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            item.picImg.Image = Resources.canho01;
            flowLayoutPanel1.Controls.Add(item);
            item = new ServiceItem();
            item.ckcChoose.Text = "100-200m2";
            item.lblPrice.Text="350000";
            item.picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            item.picImg.Image = Resources.canho02;
            flowLayoutPanel1.Controls.Add(item);
            item = new ServiceItem();
            item.ckcChoose.Text = "200-400m2";
            item.lblPrice.Text = "500000";
            item.picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            item.picImg.Image = Resources.canho03;
            flowLayoutPanel1.Controls.Add(item);
            item = new ServiceItem();
            item.ckcChoose.Text = "other";
            item.lblPrice.Text = "700000";
            item.picImg.SizeMode = PictureBoxSizeMode.StretchImage;
            item.picImg.Image = Resources.canho04;
            flowLayoutPanel1.Controls.Add(item);

        }

        private void CleaningService_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
