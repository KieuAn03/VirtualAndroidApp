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
using System.IO;
namespace AppAndroid
{
    public partial class SignUp : UserControl
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pnlBack_Click(object sender, EventArgs e)
        {
            this.Visible= false;
        }
        
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetParent("Users").Parent.Parent.FullName;
            
            if (txtPassword.Text == txtRepassword.Text)
            {
                string Usr = txtUserName.Text;
                string Password =txtPassword.Text;
                string Phone = txtPhone.Text;
                string Adressing = txtAdress.Text;
                int Money = 0;
                Directory.CreateDirectory(dir + "\\Users\\" + Usr);
                File.Create(dir + "\\Users\\" + Usr + "\\history.txt");
                StreamWriter wt = File.CreateText(dir + "\\Users\\" + Usr + "\\info.txt");
                wt.WriteLine(Usr);
                wt.WriteLine(Password);
                wt.WriteLine(Phone);
                wt.WriteLine(Adressing);
                wt.WriteLine(Money);
                wt.Close();
                StreamReader rd = new StreamReader(dir + "\\Users\\UserControl.txt");
                string line = rd.ReadToEnd();
                rd.Close();
                StreamWriter wt2 = new StreamWriter(dir +"\\Users\\UserControl.txt");
                if(line != "")
                {
                    wt2.WriteLine(line);
                }
                wt2.Write(Usr + "\t" + Password);
                wt2.Close();
            }
            else
            {
                //sth like password doesn't match ~
            }
            
        }
    }
}
