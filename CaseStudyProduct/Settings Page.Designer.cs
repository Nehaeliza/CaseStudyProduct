namespace CaseStudyProduct
{
    partial class Settings_Page
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
            this.lblSettingsPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSettingsPage
            // 
            this.lblSettingsPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSettingsPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSettingsPage.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingsPage.Location = new System.Drawing.Point(0, 0);
            this.lblSettingsPage.Name = "lblSettingsPage";
            this.lblSettingsPage.Size = new System.Drawing.Size(800, 99);
            this.lblSettingsPage.TabIndex = 1;
            this.lblSettingsPage.Text = "Settings Page";
            this.lblSettingsPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Settings_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSettingsPage);
            this.Name = "Settings_Page";
            this.Text = "Settings_Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_Page_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSettingsPage;
    }
}