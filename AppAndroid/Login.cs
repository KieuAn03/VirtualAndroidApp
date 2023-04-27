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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            UsrSigup.Visible = false;

        }
        public bool loginOK { get; set; }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           // 
        }

        private void RegisterClick(object sender, EventArgs e)
        {
           
            UsrSigup.Visible = true;
            
        }

        private void Back_Click(object sender, EventArgs e)
        {
           
            UsrSigup.Visible = false;
        }

        private void btnBack_Paint(object sender, PaintEventArgs e)
        {
            
        }
        /*
                StreamReader rd = new StreamReader(pth);
                
                string reader = rd.ReadToEnd();
                rd.Close();
             
                StreamWriter wr = new StreamWriter(pth);
                if (reader != "")
                {
                    wr.WriteLine(reader);
                }
                */
        private void btnLogin_Click(object sender, EventArgs e)
        {

            StreamReader rd = new StreamReader(Directory.GetParent("Users").Parent.Parent.FullName + "\\Users\\UserControl.txt");
            while (!rd.EndOfStream)
            {
                string loginn = txtAccount.Text +"\t"+ txtPassword.Text;
                if (loginn== rd.ReadLine())
                {
                    
                    StreamWriter wt = new StreamWriter(Directory.GetParent("Users").Parent.Parent.FullName + "\\Users\\LoggingUser.txt");
                    wt.WriteLine(txtAccount.Text);
                    wt.Close();
                    if (ckcRemember.Checked)
                    {
                        string pth = Directory.GetParent("Users").Parent.Parent.FullName + "\\Users\\CurUser.txt";

                        StreamWriter wr = new StreamWriter(pth);
                        wr.Write(txtAccount.Text);
                        wr.Close();
                    }
                    // Do sth like open the app;
                    appli app = new appli();
                    app.Show();
                    rd.Close();
                    this.Hide();
                    return;
                                       
                }              
            }
            MessageBox.Show("USER NAME OR PASSWORD IS INCORRECT!");        
            }

        private void UsrSigup_Load(object sender, EventArgs e)
        {

        }
    }
}
