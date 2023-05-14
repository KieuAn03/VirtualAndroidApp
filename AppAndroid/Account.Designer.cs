namespace AppAndroid
{
    partial class Account
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.historyPanel1 = new AppAndroid.HistoryPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtGmail = new System.Windows.Forms.TextBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 213);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 248);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Turquoise;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(94, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 41);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thống kê";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.historyPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 201);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // historyPanel1
            // 
            this.historyPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.historyPanel1.Location = new System.Drawing.Point(0, 0);
            this.historyPanel1.Name = "historyPanel1";
            this.historyPanel1.Size = new System.Drawing.Size(456, 201);
            this.historyPanel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Turquoise;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(0, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "Lịch sử";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtGmail);
            this.panel2.Controls.Add(this.txtAdress);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 461);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thay đổi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppAndroid.Properties.Resources._370076_account_avatar_client_male_person_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(24, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 98);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(248, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(139, 126);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(314, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtGmail
            // 
            this.txtGmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGmail.Location = new System.Drawing.Point(139, 100);
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Size = new System.Drawing.Size(314, 20);
            this.txtGmail.TabIndex = 3;
            this.txtGmail.Text = "Gmail";
            // 
            // txtAdress
            // 
            this.txtAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdress.Location = new System.Drawing.Point(139, 74);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(314, 20);
            this.txtAdress.TabIndex = 2;
            this.txtAdress.Text = "Adress";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(139, 48);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(314, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Text = "Phone Number";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(139, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(314, 20);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Text = "UserName";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Account";
            this.Size = new System.Drawing.Size(456, 461);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtGmail;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Panel panel2;
        public HistoryPanel historyPanel1;
    }
}
