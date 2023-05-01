namespace AppAndroid
{
    partial class appli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAccount = new System.Windows.Forms.PictureBox();
            this.btnChat = new System.Windows.Forms.PictureBox();
            this.btnCart = new System.Windows.Forms.PictureBox();
            this.btnService = new System.Windows.Forms.PictureBox();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtAdress = new System.Windows.Forms.Label();
            this.txtMoney = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.HomePanel = new AppAndroid.UserControl1();
            this.ServicePanel = new AppAndroid.Services();
            this.cart1 = new AppAndroid.Cart();
            this.chat1 = new AppAndroid.Chat();
            this.account1 = new AppAndroid.Account();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAccount);
            this.panel2.Controls.Add(this.btnChat);
            this.panel2.Controls.Add(this.btnCart);
            this.panel2.Controls.Add(this.btnService);
            this.panel2.Controls.Add(this.btnHome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 579);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 65);
            this.panel2.TabIndex = 2;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.White;
            this.btnAccount.BackgroundImage = global::AppAndroid.Properties.Resources._5;
            this.btnAccount.Location = new System.Drawing.Point(365, 0);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(91, 65);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.TabStop = false;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.White;
            this.btnChat.BackgroundImage = global::AppAndroid.Properties.Resources._4;
            this.btnChat.Location = new System.Drawing.Point(281, 0);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(90, 65);
            this.btnChat.TabIndex = 3;
            this.btnChat.TabStop = false;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.White;
            this.btnCart.BackgroundImage = global::AppAndroid.Properties.Resources._3;
            this.btnCart.Location = new System.Drawing.Point(189, 0);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(94, 65);
            this.btnCart.TabIndex = 2;
            this.btnCart.TabStop = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnService
            // 
            this.btnService.BackColor = System.Drawing.Color.White;
            this.btnService.BackgroundImage = global::AppAndroid.Properties.Resources._2;
            this.btnService.Location = new System.Drawing.Point(94, 0);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(94, 65);
            this.btnService.TabIndex = 1;
            this.btnService.TabStop = false;
            this.btnService.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnHome.BackgroundImage = global::AppAndroid.Properties.Resources._11;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(94, 65);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppAndroid.Properties.Resources.title;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.txtAdress);
            this.panel1.Controls.Add(this.txtMoney);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 118);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.White;
            this.pictureBox7.BackgroundImage = global::AppAndroid.Properties.Resources._1564524_adress_gps_location_pin_position_icon;
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox7.Location = new System.Drawing.Point(72, 80);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(34, 24);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox6.BackgroundImage = global::AppAndroid.Properties.Resources._290143_cash_money_payment_wallet_icon;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(72, 46);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 24);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // txtAdress
            // 
            this.txtAdress.AutoSize = true;
            this.txtAdress.BackColor = System.Drawing.Color.White;
            this.txtAdress.Font = new System.Drawing.Font("Georgia", 15F);
            this.txtAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAdress.Location = new System.Drawing.Point(103, 80);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(70, 24);
            this.txtAdress.TabIndex = 4;
            this.txtAdress.Text = "Adress";
            // 
            // txtMoney
            // 
            this.txtMoney.AutoSize = true;
            this.txtMoney.BackColor = System.Drawing.Color.White;
            this.txtMoney.Font = new System.Drawing.Font("Georgia", 15F);
            this.txtMoney.ForeColor = System.Drawing.Color.Navy;
            this.txtMoney.Location = new System.Drawing.Point(103, 46);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(72, 24);
            this.txtMoney.TabIndex = 2;
            this.txtMoney.Text = "Money";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Georgia", 20F);
            this.lblName.ForeColor = System.Drawing.Color.MistyRose;
            this.lblName.Location = new System.Drawing.Point(66, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "User Name";
            // 
            // HomePanel
            // 
            this.HomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomePanel.Location = new System.Drawing.Point(0, 0);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(2);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(456, 644);
            this.HomePanel.TabIndex = 6;
            this.HomePanel.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // ServicePanel
            // 
            this.ServicePanel.Location = new System.Drawing.Point(-3, 118);
            this.ServicePanel.Name = "ServicePanel";
            this.ServicePanel.Size = new System.Drawing.Size(459, 461);
            this.ServicePanel.TabIndex = 7;
            // 
            // cart1
            // 
            this.cart1.AutoScroll = true;
            this.cart1.Location = new System.Drawing.Point(0, 118);
            this.cart1.Name = "cart1";
            this.cart1.Size = new System.Drawing.Size(456, 461);
            this.cart1.TabIndex = 8;
            // 
            // chat1
            // 
            this.chat1.Location = new System.Drawing.Point(0, 118);
            this.chat1.Name = "chat1";
            this.chat1.Size = new System.Drawing.Size(456, 461);
            this.chat1.TabIndex = 9;
            // 
            // account1
            // 
            this.account1.Location = new System.Drawing.Point(0, 118);
            this.account1.Name = "account1";
            this.account1.Size = new System.Drawing.Size(456, 461);
            this.account1.TabIndex = 10;
            // 
            // appli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 644);
            this.Controls.Add(this.account1);
            this.Controls.Add(this.chat1);
            this.Controls.Add(this.cart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HomePanel);
            this.Controls.Add(this.ServicePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.appli_FormClosed);
            this.Load += new System.EventHandler(this.appli_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnAccount;
        private System.Windows.Forms.PictureBox btnChat;
        private System.Windows.Forms.PictureBox btnCart;
        private System.Windows.Forms.PictureBox btnService;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label txtAdress;
        private System.Windows.Forms.Label txtMoney;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private UserControl1 HomePanel;
        private Services ServicePanel;
        private Cart cart1;
        private Chat chat1;
        private Account account1;
    }
}