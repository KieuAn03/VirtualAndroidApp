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
            DirectoryInfo dir = new DirectoryInfo(path+"\\"+user);
            rd = new StreamReader(dir.FullName + "\\info.txt");
            lblName.Text = rd.ReadLine();
            rd.ReadLine();
            rd.ReadLine();
            txtAdress.Text = rd.ReadLine();
            txtMoney.Text = rd.ReadLine();
            rd.Close();
            HomePanel.BringToFront();
            btnHome.BackColor = Color.LightGoldenrodYellow;


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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomePanel.BringToFront();
            btnHome.BackColor = Color.LightGoldenrodYellow;
            btnAccount.BackColor = Color.White;
            btnCart.BackColor = Color.White;
            btnService.BackColor = Color.White;
            btnChat.BackColor = Color.White;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ServicePanel.BringToFront();
            btnHome.BackColor = Color.White;
            btnAccount.BackColor= Color.White;
            btnCart.BackColor= Color.White;
            btnChat.BackColor =Color.White;
            btnService.BackColor = Color.LightGoldenrodYellow;

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            cart1.BringToFront();
            btnHome.BackColor = Color.White;
            btnChat.BackColor= Color.White;
            btnService.BackColor= Color.White;
            btnCart.BackColor = Color.LightGoldenrodYellow;
            btnAccount.BackColor= Color.White;
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            chat1.BringToFront();
            btnAccount.BackColor = Color.White;
            btnCart.BackColor = Color.White;
            btnChat.BackColor = Color.LightGoldenrodYellow;
            btnHome.BackColor = Color.White;
            btnService.BackColor = Color.White;

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            account1.BringToFront();
            btnAccount.BackColor = Color.LightGoldenrodYellow;
            btnHome.BackColor= Color.White;
            btnCart.BackColor = Color.White;
            btnService.BackColor=Color.White;
            btnChat.BackColor = Color.White;
        }
    }
}
