namespace AppAndroid
{
    partial class ChatItem2
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
            this.txtContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.AutoSize = true;
            this.txtContent.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold);
            this.txtContent.ForeColor = System.Drawing.Color.Black;
            this.txtContent.Location = new System.Drawing.Point(29, 44);
            this.txtContent.Name = "txtContent";
            this.txtContent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContent.Size = new System.Drawing.Size(51, 16);
            this.txtContent.TabIndex = 2;
            this.txtContent.Text = "label2";
            // 
            // ChatItem2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::AppAndroid.Properties.Resources._13;
            this.Controls.Add(this.txtContent);
            this.Name = "ChatItem2";
            this.Size = new System.Drawing.Size(456, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label txtContent;
    }
}
