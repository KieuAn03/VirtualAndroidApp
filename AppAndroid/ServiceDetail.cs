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
    public partial class ServiceDetail : Form
    {
        public ServiceDetail()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã đặt, vui lòng kiểm tra giỏ hàng!");
            string dir = Directory.GetParent("Users").Parent.Parent.FullName;
            FileInfo fi = new FileInfo(dir + "\\Users\\LoggingUser.txt");
            if (fi.Exists)
            {





                StreamReader rd = new StreamReader(dir + "\\Users\\LoggingUser.txt");
                string usr = rd.ReadLine();
                rd.Close();



                rd = new StreamReader(dir + "\\Users\\" + usr + "\\cart.txt");
                string content = rd.ReadToEnd();
                rd.Close();




                StreamWriter wt = new StreamWriter(dir + "\\Users\\" + usr + "\\cart.txt");
                if (content != "")
                {
                    wt.WriteLine(content);
                }
                wt.Write(lblNameService.Text + "\t" + lblPrice.Text);
                wt.Close();
                
                this.Close();
            }
                
           
            
        }

        private void ServiceDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
