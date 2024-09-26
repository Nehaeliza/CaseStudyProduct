namespace CaseStudyProduct
{
    partial class DigitalTwinCreationPage
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
            this.lblDigitalTwinCreationPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDigitalTwinCreationPage
            // 
            this.lblDigitalTwinCreationPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDigitalTwinCreationPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDigitalTwinCreationPage.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigitalTwinCreationPage.Location = new System.Drawing.Point(0, 0);
            this.lblDigitalTwinCreationPage.Name = "lblDigitalTwinCreationPage";
            this.lblDigitalTwinCreationPage.Size = new System.Drawing.Size(800, 99);
            this.lblDigitalTwinCreationPage.TabIndex = 0;
            this.lblDigitalTwinCreationPage.Text = "Digital Twin Creation Page ";
            this.lblDigitalTwinCreationPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DigitalTwinCreationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDigitalTwinCreationPage);
            this.Name = "DigitalTwinCreationPage";
            this.Text = "DigitalTwinCreationPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DigitalTwinCreationPage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDigitalTwinCreationPage;
    }
}