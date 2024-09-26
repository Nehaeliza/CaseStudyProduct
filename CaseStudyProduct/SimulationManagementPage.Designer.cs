namespace CaseStudyProduct
{
    partial class SimulationManagementPage
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
            this.lblSimulationManagementPage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSimulationManagementPage
            // 
            this.lblSimulationManagementPage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSimulationManagementPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSimulationManagementPage.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimulationManagementPage.Location = new System.Drawing.Point(0, 0);
            this.lblSimulationManagementPage.Name = "lblSimulationManagementPage";
            this.lblSimulationManagementPage.Size = new System.Drawing.Size(800, 95);
            this.lblSimulationManagementPage.TabIndex = 0;
            this.lblSimulationManagementPage.Text = "Simulation Management Page";
            this.lblSimulationManagementPage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SimulationManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSimulationManagementPage);
            this.Name = "SimulationManagementPage";
            this.Text = "SimulationManagementPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimulationManagementPage_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSimulationManagementPage;
    }
}