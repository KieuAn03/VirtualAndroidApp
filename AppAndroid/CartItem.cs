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
namespace AppAndroid
{
    public partial class CartItem : UserControl
    {
        public CartItem()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetParent("user").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir+ "\\Users\\LoggingUser.txt");
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
                if (Int32.Parse(info[4]) > Int32.Parse(txtPrice.Text))
                {
                    info[4] = (Int32.Parse(info[4]) - Int32.Parse(txtPrice.Text)).ToString();
                    StreamWriter wt = new StreamWriter(dir + "\\info.txt");
                    for (int i = 0; i < 6; i++)
                    {
                        wt.WriteLine(info[i]);
                    }
                    wt.Close();
                    MessageBox.Show("Chúng tôi sẽ xử lý yêu cầu của bạn sớm nhất có thể! Kiểm tra lịch sử");
                    rd = new StreamReader(dir + "\\history.txt");
                    string content = rd.ReadToEnd();
                    rd.Close();
                    wt = new StreamWriter(dir + "\\history.txt");
                    if (content != "")
                    {
                        wt.WriteLine(content);

                    }
                    wt.Write(lblName.Text + "\t" + txtPrice.Text + "\t" + dtmService.Text + "\t" + txtAdress.Text + "\t" + "On Going" + "\t" + "N/A");
                    wt.Close();
                    


                    dir = Directory.GetParent("user").Parent.Parent.FullName;
                    rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                    string Namuser = rd.ReadLine();
                    rd.Close();
                    dir += "\\Users\\" + Namuser + "\\cart.txt";
                    rd = new StreamReader(dir);
                    List<string> list = new List<string>();
                    while (!rd.EndOfStream)
                    {
                        list.Add(rd.ReadLine());
                    }
                    rd.Close();
                    list.Remove(lblName.Text + "\t" + txtPrice.Text);

                    wt = new StreamWriter(dir);
                    int u = 0;
                    for (; u < list.Count - 1; u++)
                    {
                        wt.WriteLine(list[u]);
                    }
                    if(list.Count!=0)
                        wt.Write(list[u]);
                    wt.Close();

                    this.Parent.Controls.Remove(this);
                    return;
                }
            
            
            
            }
            MessageBox.Show("You don't have enough money, try again!");
            
                        
        }
        public void buy()
        {
            string dir = Directory.GetParent("user").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir + "\\Users\\LoggingUser.txt");
            if (fi.Exists)
            {
                StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                string Nameuser = rd.ReadLine();
                rd.Close();
                dir += "\\Users\\" + Nameuser;
                                
                   rd = new StreamReader(dir + "\\history.txt");
                    string content = rd.ReadToEnd();
                    rd.Close();
                    StreamWriter wt = new StreamWriter(dir + "\\history.txt");
                    if (content != "")
                    {
                        wt.WriteLine(content);

                    }
                    wt.Write(lblName.Text + "\t" + txtPrice.Text + "\t" + dtmService.Text + "\t" + txtAdress.Text + "\t" + "On Going" + "\t" + "N/A");
                    wt.Close();
                    return;
                



            }
            MessageBox.Show("You don't have enough money, try again!");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetParent("user").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir + "\\Users\\LoggingUser.txt");
            if (fi.Exists)
            {
                StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                string Nameuser = rd.ReadLine();
                rd.Close();
                dir += "\\Users\\" + Nameuser + "\\cart.txt";
                rd = new StreamReader(dir);




                List<string> list = new List<string>();
                while (!rd.EndOfStream)
                {
                    list.Add(rd.ReadLine());
                }
                rd.Close();
                list.Remove(lblName.Text + "\t" + txtPrice.Text);
                




                StreamWriter wt = new StreamWriter(dir);
                int i = 0;
                for (; i < list.Count - 1; i++)
                {
                    
                    wt.WriteLine(list[i]);
                }
                if(list.Count!=0)
                     wt.Write(list[i]);
                wt.Close();

                this.Parent.Controls.Remove(this);
               
               
               
            }
                
        }

        private void Parent_BackColorChanged(object sender, EventArgs e)
        {
        }

        private void Parent_Move(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void CartItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void CartItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor= Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string dir = Directory.GetParent("Users").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir + "\\Users\\LoggingUser.txt");
            if (fi.Exists)
            {
                StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                string usr = rd.ReadLine();
                rd.Close();
                rd = new StreamReader(dir + "\\Users\\" + usr + "\\info.txt");
                rd.ReadLine();
                rd.ReadLine();
                rd.ReadLine();
                txtAdress.Text = rd.ReadLine();
                rd.Close();
            }
            
        }

        private void CartItem_Load(object sender, EventArgs e)
        {

        }
    }
}
