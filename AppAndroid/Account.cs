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
using System.Drawing;
using System.Drawing.Imaging;
namespace AppAndroid
{
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
            string dir = Directory.GetParent("user").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir + "\\Users\\LoggingUser.txt");
            if (fi.Exists)
            {
                
                StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                txtUsername.Text = rd.ReadLine();
                rd.Close();
                rd = new StreamReader(dir + "\\Users\\" + txtUsername.Text + "\\info.txt");
                rd.ReadLine();
                txtPassword.Text = rd.ReadLine();
                txtPhone.Text = rd.ReadLine();
                txtAdress.Text = rd.ReadLine();
                rd.ReadLine();
                txtGmail.Text = rd.ReadLine();
                string img= rd.ReadLine();
                if(img !="none"&& img != "")
                {
                    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    this.pictureBox1.Image = Image.FromFile(img);
                }
                    
                
                
                rd.Close();
            }
                
          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
            
            openFileDialog1.Title = "choose a picture";
            openFileDialog1.Multiselect = false;
            openFileDialog1.Filter = "All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string pth = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(pth);

                string dir = Directory.GetParent("user").Parent.Parent.FullName;
                FileInfo fi = new FileInfo(dir + "\\Users\\LoggingUser.txt");
                if (fi.Exists)
                {

                    StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                    string usrname = rd.ReadLine();
                    rd.Close();
                    rd = new StreamReader(dir + "\\Users\\" + txtUsername.Text + "\\info.txt");
                    rd.ReadLine();
                    rd.ReadLine();
                    rd.ReadLine();
                    rd.ReadLine();
                    int money = Int32.Parse(rd.ReadLine());
                    
                    rd.Close();
                    StreamWriter wt = new StreamWriter(dir + "\\Users\\" + txtUsername.Text + "\\info.txt");
                    wt.WriteLine(txtUsername.Text);
                    wt.WriteLine(txtPassword.Text);
                    wt.WriteLine(txtPhone.Text);
                    wt.WriteLine(txtAdress.Text);
                    wt.WriteLine(money);
                    wt.WriteLine(txtGmail.Text);
                    wt.WriteLine(pth);

                    wt.Close();
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetParent("user").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir + "\\Users\\LoggingUser.txt");
            if (fi.Exists)
            {
                
                StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                string usrname = rd.ReadLine();
                rd.Close();
                rd = new StreamReader(dir + "\\Users\\" + txtUsername.Text + "\\info.txt");
                rd.ReadLine();
                rd.ReadLine();
                rd.ReadLine();
                rd.ReadLine();
                int money = Int32.Parse(rd.ReadLine());
                rd.ReadLine();
                string zzz = rd.ReadLine();
                rd.Close();
                StreamWriter wt = new StreamWriter(dir + "\\Users\\" + txtUsername.Text + "\\info.txt");
                wt.WriteLine(txtUsername.Text);
                wt.WriteLine(txtPassword.Text);
                wt.WriteLine(txtPhone.Text);
                wt.WriteLine(txtAdress.Text);
                wt.WriteLine(money);
                wt.WriteLine(txtGmail.Text);
                wt.WriteLine(zzz);
                wt.Close();
            }
                
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Load(object sender, EventArgs e)
        {

        }
    }
}
