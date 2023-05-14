namespace AppAndroid
{
    partial class CartItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.imgItem = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtmService = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dịch vụ";
            // 
            // imgItem
            // 
            this.imgItem.Location = new System.Drawing.Point(3, 3);
            this.imgItem.Name = "imgItem";
            this.imgItem.Size = new System.Drawing.Size(79, 82);
            this.imgItem.TabIndex = 0;
            this.imgItem.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(154, 2);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 18);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(86, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thời gian:";
            // 
            // dtmService
            // 
            this.dtmService.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dtmService.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmService.Location = new System.Drawing.Point(158, 23);
            this.dtmService.Name = "dtmService";
            this.dtmService.Size = new System.Drawing.Size(222, 20);
            this.dtmService.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(157, 44);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(223, 20);
            this.txtAdress.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 20);
            this.button1.TabIndex = 8;
            this.button1.Text = "O";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(101, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "Xác nhận";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(225, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 40);
            this.button3.TabIndex = 10;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Giá:";
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(155, 67);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(48, 18);
            this.txtPrice.TabIndex = 12;
            this.txtPrice.Text = "Name";
            // 
            // CartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtmService);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imgItem);
            this.Name = "CartItem";
            this.Size = new System.Drawing.Size(452, 133);
            this.Load += new System.EventHandler(this.CartItem_Load);
            this.MouseEnter += new System.EventHandler(this.CartItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.CartItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.imgItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.PictureBox imgItem;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.DateTimePicker dtmService;
        public System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label txtPrice;
    }
}
