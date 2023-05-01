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
            StreamReader rd = new StreamReader(dir+ "\\Users\\LoggingUser.txt");
            string Nameuser = rd.ReadLine();
            rd.Close();
            dir += "\\Users\\" + Nameuser + "\\history.txt";
            rd = new StreamReader(dir);
            string content = rd.ReadToEnd();
            rd.Close();
            StreamWriter wt = new StreamWriter(dir);
            wt.WriteLine(content);
            wt.Write(lblName.Text + "\t" + dtmService.Text + "\t" + txtAdress.Text + "\t" + "On Going" + "\t" + "N/A");
            wt.Close();
                        
        }
    }
}
