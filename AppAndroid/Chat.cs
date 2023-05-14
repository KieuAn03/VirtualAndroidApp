using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAndroid
{
    public partial class Chat : UserControl
    {
        int count = 0;
        public Chat()
        {
            InitializeComponent();
            ChatItem1 chat1 = new ChatItem1();
            chat1.txtContent.Text = "Liệu tôi có thể đổi địa điểm thực hiện";
            flowLayoutPanel1.Controls.Add(chat1);
            ChatItem2 chat2 = new ChatItem2();
            chat2.txtContent.Text = "Xin chào, tất nhiên là được ạ";
            flowLayoutPanel1.Controls.Add(chat2);
            
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                ChatItem1 chat = new ChatItem1();
                chat.txtContent.Text = txbContent.Text;
                
                flowLayoutPanel1.Controls.Add(chat);
                count++;
                txbContent.Text = "";
                return;
            }
            else
            {
                ChatItem2 chat = new ChatItem2();
                chat.txtContent.Text = txbContent.Text;
                flowLayoutPanel1.Controls.Add(chat);
                txbContent.Text = "";
                count--;
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (count == 0)
                {
                    ChatItem1 chat = new ChatItem1();
                    chat.txtContent.Text = txbContent.Text;

                    flowLayoutPanel1.Controls.Add(chat);
                    count++;
                    txbContent.Text = "";
                    return;
                }
                else
                {
                    ChatItem2 chat = new ChatItem2();
                    chat.txtContent.Text = txbContent.Text;
                    flowLayoutPanel1.Controls.Add(chat);
                    txbContent.Text = "";
                    count--;
                }
            }
        }
    }
}
