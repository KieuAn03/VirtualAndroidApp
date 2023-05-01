namespace AppAndroid
{
    partial class Services
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabLaundry = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tabCleaning = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tabcooking = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.laundryService1 = new AppAndroid.LaundryService();
            this.pnlCooking = new AppAndroid.CookingService();
            this.cleaningService1 = new AppAndroid.CleaningService();
            this.panel3.SuspendLayout();
            this.tabLaundry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabCleaning.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tabcooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(47, 461);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(410, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(46, 461);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabLaundry);
            this.panel3.Controls.Add(this.tabCleaning);
            this.panel3.Controls.Add(this.tabcooking);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(47, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(363, 86);
            this.panel3.TabIndex = 0;
            // 
            // tabLaundry
            // 
            this.tabLaundry.Controls.Add(this.label3);
            this.tabLaundry.Controls.Add(this.pictureBox3);
            this.tabLaundry.Controls.Add(this.panel10);
            this.tabLaundry.Location = new System.Drawing.Point(222, 0);
            this.tabLaundry.Name = "tabLaundry";
            this.tabLaundry.Size = new System.Drawing.Size(77, 81);
            this.tabLaundry.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Laundry";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::AppAndroid.Properties.Resources._7150138_washing_machine_clean_wash_technology_icon;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 61);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(83, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(77, 81);
            this.panel10.TabIndex = 1;
            // 
            // tabCleaning
            // 
            this.tabCleaning.Controls.Add(this.label2);
            this.tabCleaning.Controls.Add(this.pictureBox2);
            this.tabCleaning.Controls.Add(this.panel8);
            this.tabCleaning.Location = new System.Drawing.Point(119, 0);
            this.tabCleaning.Name = "tabCleaning";
            this.tabCleaning.Size = new System.Drawing.Size(77, 81);
            this.tabCleaning.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cleaning";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AppAndroid.Properties.Resources._9016844_cleaning_house_covid_19_virus_pandemic_icon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 61);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel8
            // 
            this.panel8.Location = new System.Drawing.Point(83, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(77, 81);
            this.panel8.TabIndex = 1;
            // 
            // tabcooking
            // 
            this.tabcooking.BackColor = System.Drawing.Color.MistyRose;
            this.tabcooking.Controls.Add(this.label1);
            this.tabcooking.Controls.Add(this.pictureBox1);
            this.tabcooking.Controls.Add(this.panel6);
            this.tabcooking.Location = new System.Drawing.Point(22, 0);
            this.tabcooking.Name = "tabcooking";
            this.tabcooking.Size = new System.Drawing.Size(77, 81);
            this.tabcooking.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cooking";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AppAndroid.Properties.Resources._379504_chef_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 61);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(83, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(77, 81);
            this.panel6.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.laundryService1);
            this.panel4.Controls.Add(this.pnlCooking);
            this.panel4.Controls.Add(this.cleaningService1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(47, 86);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 375);
            this.panel4.TabIndex = 0;
            // 
            // laundryService1
            // 
            this.laundryService1.Location = new System.Drawing.Point(0, 1);
            this.laundryService1.Name = "laundryService1";
            this.laundryService1.Size = new System.Drawing.Size(363, 376);
            this.laundryService1.TabIndex = 2;
            // 
            // pnlCooking
            // 
            this.pnlCooking.Location = new System.Drawing.Point(3, 3);
            this.pnlCooking.Name = "pnlCooking";
            this.pnlCooking.Size = new System.Drawing.Size(357, 376);
            this.pnlCooking.TabIndex = 0;
            this.pnlCooking.Load += new System.EventHandler(this.cookingService1_Load);
            // 
            // cleaningService1
            // 
            this.cleaningService1.Location = new System.Drawing.Point(0, 3);
            this.cleaningService1.Name = "cleaningService1";
            this.cleaningService1.Size = new System.Drawing.Size(360, 376);
            this.cleaningService1.TabIndex = 1;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Services";
            this.Size = new System.Drawing.Size(456, 461);
            this.Load += new System.EventHandler(this.Services_Load);
            this.panel3.ResumeLayout(false);
            this.tabLaundry.ResumeLayout(false);
            this.tabLaundry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabCleaning.ResumeLayout(false);
            this.tabCleaning.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tabcooking.ResumeLayout(false);
            this.tabcooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel tabcooking;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel tabLaundry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel tabCleaning;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CookingService pnlCooking;
        private CleaningService cleaningService1;
        private LaundryService laundryService1;
    }
}
