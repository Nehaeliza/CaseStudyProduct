namespace CaseStudyProduct
{
    partial class Collaboration_Page
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
            this.lblCollaborationPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCollaborationPage
            // 
            this.lblCollaborationPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCollaborationPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCollaborationPage.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollaborationPage.Location = new System.Drawing.Point(0, 0);
            this.lblCollaborationPage.Name = "lblCollaborationPage";
            this.lblCollaborationPage.Size = new System.Drawing.Size(800, 99);
            this.lblCollaborationPage.TabIndex = 1;
            this.lblCollaborationPage.Text = "Collaboration Page ";
            this.lblCollaborationPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Collaboration_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCollaborationPage);
            this.Name = "Collaboration_Page";
            this.Text = "Collaboration_Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Collaboration_Page_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCollaborationPage;
    }
}