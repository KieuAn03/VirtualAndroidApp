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
    public partial class Cart : UserControl
    {
        public Cart()
        {
            InitializeComponent();
            string dir = Directory.GetParent("Users").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir + "\\Users\\LoggingUser.txt");
            if (fi.Exists)
            {
                
                StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                string line = rd.ReadLine();
                rd.Close();
                rd = new StreamReader(dir + "\\Users\\" + line + "\\cart.txt");

                string[] Item = new string[2];
                List<string> ItemName = new List<string>();
                List<string> ItemPrice = new List<string>();
                while (!rd.EndOfStream)
                {
                    Item = rd.ReadLine().Split(new[] { '\t' }, StringSplitOptions.None);
                    ItemName.Add(Item[0]);
                    ItemPrice.Add(Item[1]);
                }

                rd.Close();
                CartItem item;
                rd = new StreamReader(dir + "\\Users\\" + line + "\\info.txt");
                rd.ReadLine();
                rd.ReadLine();
                rd.ReadLine();

                string defAdress = rd.ReadLine();
                rd.Close();

                for (int i = 0; i < ItemName.Count; i++)
                {
                    item = new CartItem();
                    item.lblName.Text = ItemName[i];
                    item.txtAdress.Text = defAdress;
                    item.txtPrice.Text = ItemPrice[i];
                    item.dtmService.Value = DateTime.UtcNow;
                    item.imgItem.Image = ImgSelect(ItemName[i]);
                    item.imgItem.SizeMode = PictureBoxSizeMode.StretchImage;
                    flowLayoutPanel1.Controls.Add(item);

                }
            }

            calculateMoney();

        }

        public void calculateMoney()
        {
            int sum =0;
            foreach(CartItem it in flowLayoutPanel1.Controls.Cast<CartItem>())
            {
                sum += Int32.Parse(it.txtPrice.Text);
            }
            lblMoney.Text= sum.ToString();
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
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Cart_Load(object sender, EventArgs e)
        {
           

        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
           
            flowLayoutPanel1.Controls.Clear();
            string dir = Directory.GetParent("Users").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir + "\\Users\\LoggingUser.txt");
            if (fi.Exists)
            {



                StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                string line = rd.ReadLine();
                rd.Close();
                rd = new StreamReader(dir + "\\Users\\" + line + "\\cart.txt");





                string[] Item = new string[2];
                List<string> ItemName = new List<string>();
                List<string> ItemPrice = new List<string>();





                while (!rd.EndOfStream)
                {
                    Item = rd.ReadLine().Split(new[] { '\t' }, StringSplitOptions.None);
                    ItemName.Add(Item[0]);
                    ItemPrice.Add(Item[1]);
                }


                rd.Close();
                CartItem item;
                rd = new StreamReader(dir + "\\Users\\" + line + "\\info.txt");
                rd.ReadLine();
                rd.ReadLine();
                rd.ReadLine();

                string defAdress = rd.ReadLine();
                rd.Close();

                for (int i = 0; i < ItemName.Count; i++)
                {
                    item = new CartItem();
                    item.lblName.Text = ItemName[i];
                    item.txtAdress.Text = defAdress;
                    item.txtPrice.Text = ItemPrice[i];
                    item.dtmService.Value = DateTime.UtcNow;
                    item.imgItem.Image = ImgSelect(ItemName[i]);
                    item.imgItem.SizeMode = PictureBoxSizeMode.StretchImage;
                    flowLayoutPanel1.Controls.Add(item);
                }
            }
                
            
        }

        private void flowLayoutPanel1_Move(object sender, EventArgs e)
        {
            calculateMoney();
        }

        private void flowLayoutPanel1_VisibleChanged(object sender, EventArgs e)
        {
            
         
        }

        private void flowLayoutPanel1_ControlRemoved(object sender, ControlEventArgs e)
        {
            calculateMoney();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string dir = Directory.GetParent("user").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir + "\\Users\\LoggingUser.txt");
            if (fi.Exists)
            {
                StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                string Nameuser = rd.ReadLine();
                rd.Close();
                dir += "\\Users\\" + Nameuser;
                rd = new StreamReader(dir + "\\info.txt");
                string[] info = new string[6];
                for (int i = 0; i < 6; i++)
                {
                    info[i] = rd.ReadLine();
                }
                rd.Close();
                if (Int32.Parse(info[4]) > Int32.Parse(lblMoney.Text))
                {
                    info[4] = (Int32.Parse(info[4]) - Int32.Parse(lblMoney.Text)).ToString();
                    StreamWriter wt = new StreamWriter(dir + "\\info.txt");
                    for (int i = 0; i < 6; i++)
                    {
                        wt.WriteLine(info[i]);
                    }
                    wt.Close();
                    foreach (CartItem it in flowLayoutPanel1.Controls)
                    {
                        it.buy();
                    }
                    wt = new StreamWriter(dir + "\\cart.txt");
                    wt.Write("");
                    MessageBox.Show("Đặt đơn thành công!");
                    wt.Close();
                    
                    this.button1_Click(sender, new EventArgs());
                }
            }
            
        }
    }
}
