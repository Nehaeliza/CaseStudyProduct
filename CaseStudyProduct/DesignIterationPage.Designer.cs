namespace CaseStudyProduct
{
    partial class DesignIterationPage
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
            this.lblDesignIterationPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDesignIterationPage
            // 
            this.lblDesignIterationPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDesignIterationPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDesignIterationPage.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesignIterationPage.Location = new System.Drawing.Point(0, 0);
            this.lblDesignIterationPage.Name = "lblDesignIterationPage";
            this.lblDesignIterationPage.Size = new System.Drawing.Size(800, 99);
            this.lblDesignIterationPage.TabIndex = 1;
            this.lblDesignIterationPage.Text = "Design Iteration Page ";
            this.lblDesignIterationPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DesignIterationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDesignIterationPage);
            this.Name = "DesignIterationPage";
            this.Text = "DesignIterationPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DesignIterationPage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDesignIterationPage;
    }
}