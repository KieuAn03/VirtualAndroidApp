namespace AppAndroid
{
    partial class SignUp
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
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtAdress
            // 
            this.txtAdress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.txtAdress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAdress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.ForeColor = System.Drawing.Color.Snow;
            this.txtAdress.Location = new System.Drawing.Point(113, 485);
            this.txtAdress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(252, 19);
            this.txtAdress.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Snow;
            this.txtUserName.Location = new System.Drawing.Point(113, 231);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(226, 19);
            this.txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Snow;
            this.txtPassword.Location = new System.Drawing.Point(113, 294);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(226, 19);
            this.txtPassword.TabIndex = 3;
            // 
            // txtRepassword
            // 
            this.txtRepassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.txtRepassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRepassword.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepassword.ForeColor = System.Drawing.Color.Snow;
            this.txtRepassword.Location = new System.Drawing.Point(113, 356);
            this.txtRepassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.PasswordChar = '*';
            this.txtRepassword.Size = new System.Drawing.Size(226, 19);
            this.txtRepassword.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(22)))), ((int)(((byte)(31)))));
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Snow;
            this.txtPhone.Location = new System.Drawing.Point(113, 422);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(226, 19);
            this.txtPhone.TabIndex = 5;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.Location = new System.Drawing.Point(179, 532);
            this.btnSignUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(103, 31);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            this.btnSignUp.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.Transparent;
            this.pnlBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlBack.Location = new System.Drawing.Point(2, 2);
            this.pnlBack.Margin = new System.Windows.Forms.Padding(2);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(55, 57);
            this.pnlBack.TabIndex = 6;
            this.pnlBack.Click += new System.EventHandler(this.pnlBack_Click);
            this.pnlBack.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AppAndroid.Properties.Resources.SIgn_up;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pnlBack);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtRepassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtAdress);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUp";
            this.Size = new System.Drawing.Size(472, 683);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.FlowLayoutPanel btnSignUp;
    }
}
