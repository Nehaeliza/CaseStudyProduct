namespace CaseStudyProduct
{
    partial class FeedBack_Page
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
            this.lblFeedbackPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFeedbackPage
            // 
            this.lblFeedbackPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFeedbackPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFeedbackPage.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedbackPage.Location = new System.Drawing.Point(0, 0);
            this.lblFeedbackPage.Name = "lblFeedbackPage";
            this.lblFeedbackPage.Size = new System.Drawing.Size(800, 99);
            this.lblFeedbackPage.TabIndex = 1;
            this.lblFeedbackPage.Text = "Feedback Page ";
            this.lblFeedbackPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FeedBack_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFeedbackPage);
            this.Name = "FeedBack_Page";
            this.Text = "FeedBack_Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FeedBack_Page_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFeedbackPage;
    }
}