using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AppAndroid.Properties;
namespace AppAndroid
{
    public partial class HistoryPanel : UserControl
    {
        public HistoryPanel()
        {
            InitializeComponent();
            
            string dir = Directory.GetParent("Users").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir + "\\Users\\LoggingUser.txt");
            if (fi.Exists)
            {
                StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                string line = rd.ReadLine();
                rd.Close();
                rd = new StreamReader(dir + "\\Users\\" + line + "\\history.txt");

                string[] Item = new string[6];
                List<string> ItemName = new List<string>();
                List<string> ItemPrice = new List<string>();
                List<string> ItemTime = new List<string>();
                List<string> ItemAdress = new List<string>();
                List<string> ItemStatus = new List<string>();
                List<string> ItemRating = new List<string>();
                while (!rd.EndOfStream)
                {
                    Item = rd.ReadLine().Split(new[] { '\t' }, StringSplitOptions.None);
                    ItemName.Add(Item[0]);
                    ItemPrice.Add(Item[1]);
                    ItemTime.Add(Item[2]);
                    ItemAdress.Add(Item[3]);
                    ItemStatus.Add(Item[4]);
                    ItemRating.Add(Item[5]);
                }

                rd.Close();
                HistoryItem item;
                rd = new StreamReader(dir + "\\Users\\" + line + "\\info.txt");
                rd.ReadLine();
                rd.ReadLine();
                rd.ReadLine();

                string defAdress = rd.ReadLine();
                rd.Close();

                for (int i = 0; i < ItemName.Count; i++)
                {
                    item = new HistoryItem();
                    item.lblName.Text = ItemName[i];
                    item.lblPrice.Text = ItemPrice[i];
                    item.lblAdress.Text = ItemAdress[i];
                    item.lblStatus.Text = ItemStatus[i];
                    item.lblRating.Text = ItemRating[i];
                    item.txtDate.Text = ItemTime[i];
                    item.imgItem.Image = ImgSelect(ItemName[i]);
                    item.imgItem.SizeMode = PictureBoxSizeMode.StretchImage;
                    flowLayoutPanel1.Controls.Add(item);
                }

            }


        }
        public void refreshHistory()
        {
            flowLayoutPanel1.Controls.Clear();
            string dir = Directory.GetParent("Users").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir + "\\Users\\LoggingUser.txt");
            if (fi.Exists)
            {
                StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                string line = rd.ReadLine();
                rd.Close();
                rd = new StreamReader(dir + "\\Users\\" + line + "\\history.txt");

                string[] Item = new string[6];
                List<string> ItemName = new List<string>();
                List<string> ItemPrice = new List<string>();
                List<string> ItemTime = new List<string>();
                List<string> ItemAdress = new List<string>();
                List<string> ItemStatus = new List<string>();
                List<string> ItemRating = new List<string>();
                while (!rd.EndOfStream)
                {
                    Item = rd.ReadLine().Split(new[] { '\t' }, StringSplitOptions.None);
                    ItemName.Add(Item[0]);
                    ItemPrice.Add(Item[1]);
                    ItemTime.Add(Item[2]);
                    ItemAdress.Add(Item[3]);
                    ItemStatus.Add(Item[4]);
                    ItemRating.Add(Item[5]);
                }

                rd.Close();
                HistoryItem item;
                rd = new StreamReader(dir + "\\Users\\" + line + "\\info.txt");
                rd.ReadLine();
                rd.ReadLine();
                rd.ReadLine();

                string defAdress = rd.ReadLine();
                rd.Close();

                for (int i = 0; i < ItemName.Count; i++)
                {
                    item = new HistoryItem();
                    item.lblName.Text = ItemName[i];
                    item.lblPrice.Text = ItemPrice[i];
                    item.lblAdress.Text = ItemAdress[i];
                    item.lblStatus.Text = ItemStatus[i];
                    item.lblRating.Text = ItemRating[i];
                    item.txtDate.Text = ItemTime[i];
                    item.imgItem.Image = ImgSelect(ItemName[i]);
                    item.imgItem.SizeMode = PictureBoxSizeMode.StretchImage;
                    flowLayoutPanel1.Controls.Add(item);
                }

            }
        }
        private Image ImgSelect(string name)
        {

            switch (name)
            {
                case "Giặt quần áo":
                    {
                        return Resources.Giatui01;
                    }
                case "Giặt quần áo & chăn ga":
                    {
                        return Resources.GiatUi04;
                    }
                case "Ủi là":
                    {
                        return Resources.giat_ui;
                    }
                case "Combo Giặt, ủi":
                    {
                        return Resources.Giatui02;
                    }
                case "Mâm nhỏ":
                    {
                        return Resources.com031;
                    }
                case "Mâm vừa":
                    {
                        return Resources.com03;
                    }
                case "Mâm lớn":
                    {
                        return Resources.com04;
                    }
                case "Siêu tiệc":
                    {
                        return Resources.com05;
                    }
                case "Dọn 0-100m2":
                    {
                        return Resources.canho01;
                    }
                case "Dọn 100-200m2":
                    {
                        return Resources.canho02;
                    }
                case "Dọn 200-400m2":
                    {
                        return Resources.canho03;
                    }
                case "Dọn khác":
                    {
                        return Resources.canho04;
                    }

            }
            return Resources.canho01;


        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
