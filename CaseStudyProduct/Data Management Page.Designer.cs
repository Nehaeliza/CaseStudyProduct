namespace CaseStudyProduct
{
    partial class Data_Management_Page
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
            this.lblDataMangementPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataMangementPage
            // 
            this.lblDataMangementPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDataMangementPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDataMangementPage.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataMangementPage.Location = new System.Drawing.Point(0, 0);
            this.lblDataMangementPage.Name = "lblDataMangementPage";
            this.lblDataMangementPage.Size = new System.Drawing.Size(800, 99);
            this.lblDataMangementPage.TabIndex = 1;
            this.lblDataMangementPage.Text = "Data Mangement Page ";
            this.lblDataMangementPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Data_Management_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDataMangementPage);
            this.Name = "Data_Management_Page";
            this.Text = "Data_Management_Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Data_Management_Page_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDataMangementPage;
    }
}