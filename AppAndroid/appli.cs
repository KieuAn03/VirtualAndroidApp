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
    public partial class appli : Form
    {
        public appli()
        {
            InitializeComponent();
            string path = Directory.GetParent("Users").Parent.Parent.FullName + "\\Users";
            string user;
            StreamReader rd = new StreamReader(path + "\\LoggingUser.txt");
            user = rd.ReadLine();
            rd.Close();

            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (DirectoryInfo inf in dir.GetDirectories())
            {
                if (inf.Name == user)
                {
                    dir = inf;
                    break;
                }
            }
            rd = new StreamReader(dir.FullName + "\\info.txt");
            lblName.Text = rd.ReadLine();
            rd.ReadLine();
            rd.ReadLine();
            txtAdress.Text = rd.ReadLine();
            txtMoney.Text = rd.ReadLine();
            rd.Close();

        }

        private void appli_Load(object sender, EventArgs e)
        {

        }
        public bool islogout { get; set; }
        private void label1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            islogout = true;
            this.Close();            
        }

        private void appli_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!islogout)
                Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
