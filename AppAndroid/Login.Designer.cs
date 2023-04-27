namespace AppAndroid
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Panel();
            this.ckcRemember = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UsrSigup = new AppAndroid.SignUp();
            this.SuspendLayout();
            // 
            // txtAccount
            // 
            this.txtAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAccount.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.ForeColor = System.Drawing.Color.Snow;
            this.txtAccount.Location = new System.Drawing.Point(112, 311);
            this.txtAccount.Margin = new System.Windows.Forms.Padding(2);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(153, 19);
            this.txtAccount.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Snow;
            this.txtPassword.Location = new System.Drawing.Point(112, 389);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(153, 19);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(169, 450);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(127, 50);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ckcRemember
            // 
            this.ckcRemember.AutoSize = true;
            this.ckcRemember.BackColor = System.Drawing.Color.Transparent;
            this.ckcRemember.Location = new System.Drawing.Point(106, 428);
            this.ckcRemember.Name = "ckcRemember";
            this.ckcRemember.Size = new System.Drawing.Size(15, 14);
            this.ckcRemember.TabIndex = 3;
            this.ckcRemember.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(106, 595);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 30);
            this.panel2.TabIndex = 4;
            this.panel2.Click += new System.EventHandler(this.RegisterClick);
            // 
            // UsrSigup
            // 
            this.UsrSigup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UsrSigup.BackgroundImage")));
            this.UsrSigup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UsrSigup.Location = new System.Drawing.Point(0, -2);
            this.UsrSigup.Margin = new System.Windows.Forms.Padding(2);
            this.UsrSigup.Name = "UsrSigup";
            this.UsrSigup.Size = new System.Drawing.Size(472, 683);
            this.UsrSigup.TabIndex = 5;
            this.UsrSigup.Load += new System.EventHandler(this.UsrSigup_Load);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::AppAndroid.Properties.Resources.REMEMBER_ME;
            this.ClientSize = new System.Drawing.Size(472, 683);
            this.ControlBox = false;
            this.Controls.Add(this.UsrSigup);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ckcRemember);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel btnLogin;
        private System.Windows.Forms.CheckBox ckcRemember;
        private System.Windows.Forms.Panel panel2;
        private SignUp UsrSigup;
    }
}