namespace CaseStudyProduct
{
    partial class PerformanceAnalysisPage
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
            this.lblPerformanceAnalysisPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPerformanceAnalysisPage
            // 
            this.lblPerformanceAnalysisPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPerformanceAnalysisPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPerformanceAnalysisPage.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerformanceAnalysisPage.Location = new System.Drawing.Point(0, 0);
            this.lblPerformanceAnalysisPage.Name = "lblPerformanceAnalysisPage";
            this.lblPerformanceAnalysisPage.Size = new System.Drawing.Size(800, 99);
            this.lblPerformanceAnalysisPage.TabIndex = 1;
            this.lblPerformanceAnalysisPage.Text = "Performance Analaysis Page ";
            this.lblPerformanceAnalysisPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PerformanceAnalysisPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPerformanceAnalysisPage);
            this.Name = "PerformanceAnalysisPage";
            this.Text = "PerformanceAnalysisPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PerformanceAnalysisPage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPerformanceAnalysisPage;
    }
}