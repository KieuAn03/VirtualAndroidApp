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
    public partial class HistoryItem : UserControl
    {
        public HistoryItem()
        {
            InitializeComponent();
            
        }

        private void HistoryItem_Load(object sender, EventArgs e)
        {

        }

        private void HistoryItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void HistoryItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor= Color.White;
        }

        private void HistoryItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
