namespace AppAndroid
{
    partial class ServiceItem
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.ckcChoose = new System.Windows.Forms.Label();
            this.picImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblPrice.Location = new System.Drawing.Point(-4, 151);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 17);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "price";
            // 
            // ckcChoose
            // 
            this.ckcChoose.AutoSize = true;
            this.ckcChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckcChoose.Location = new System.Drawing.Point(-3, 131);
            this.ckcChoose.Name = "ckcChoose";
            this.ckcChoose.Size = new System.Drawing.Size(50, 16);
            this.ckcChoose.TabIndex = 4;
            this.ckcChoose.Text = "label1";
            // 
            // picImg
            // 
            this.picImg.Location = new System.Drawing.Point(0, 0);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(170, 128);
            this.picImg.TabIndex = 0;
            this.picImg.TabStop = false;
            this.picImg.Click += new System.EventHandler(this.picImg_Click);
            this.picImg.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picImg_MouseClick);
            // 
            // ServiceItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ckcChoose);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.picImg);
            this.Name = "ServiceItem";
            this.Size = new System.Drawing.Size(170, 180);
            this.Load += new System.EventHandler(this.ServiceItem_Load);
            this.Click += new System.EventHandler(this.ServiceItem_Click);
            this.MouseEnter += new System.EventHandler(this.ServiceItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ServiceItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picImg;
        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label ckcChoose;
    }
}
