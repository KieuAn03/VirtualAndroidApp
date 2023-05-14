namespace AppAndroid
{
    partial class Cart
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lable123 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(456, 385);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.VisibleChanged += new System.EventHandler(this.flowLayoutPanel1_VisibleChanged);
            this.flowLayoutPanel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.flowLayoutPanel1_ControlRemoved);
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            this.flowLayoutPanel1.Move += new System.EventHandler(this.flowLayoutPanel1_Move);
            // 
            // lable123
            // 
            this.lable123.AutoSize = true;
            this.lable123.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable123.ForeColor = System.Drawing.Color.IndianRed;
            this.lable123.Location = new System.Drawing.Point(69, 388);
            this.lable123.Name = "lable123";
            this.lable123.Size = new System.Drawing.Size(131, 29);
            this.lable123.TabIndex = 1;
            this.lable123.Text = "Tổng tiền:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.IndianRed;
            this.lblMoney.Location = new System.Drawing.Point(206, 388);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(131, 29);
            this.lblMoney.TabIndex = 2;
            this.lblMoney.Text = "Tổng tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(390, 388);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "VND";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Location = new System.Drawing.Point(346, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đặt ngay";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lable123);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Cart";
            this.Size = new System.Drawing.Size(456, 461);
            this.Load += new System.EventHandler(this.Cart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lable123;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
