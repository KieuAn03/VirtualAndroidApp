namespace AppAndroid
{
    partial class Chat
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
            this.txbContent = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 158);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(456, 303);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // txbContent
            // 
            this.txbContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(247)))), ((int)(((byte)(238)))));
            this.txbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContent.Location = new System.Drawing.Point(21, 133);
            this.txbContent.Name = "txbContent";
            this.txbContent.Size = new System.Drawing.Size(368, 19);
            this.txbContent.TabIndex = 0;
            this.txbContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbContent_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::AppAndroid.Properties.Resources.chating;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txbContent);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 158);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(411, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(42, 43);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(456, 461);
            this.Load += new System.EventHandler(this.Chat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbContent;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
