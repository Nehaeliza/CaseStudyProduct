using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseStudyProduct
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
            MyConfig.frmHome = this;
        }
        private DigitalTwinCreationPage frmDigitalTwin = new DigitalTwinCreationPage();
        private Collaboration_Page frmCollaboration = new Collaboration_Page();
        private Data_Management_Page frmManagment = new Data_Management_Page();
        private DesignIterationPage frmDesign = new DesignIterationPage();
        private FeedBack_Page frmFeedback = new FeedBack_Page();
        private Help_And_Support_Page frmHelp = new Help_And_Support_Page();
        private PerformanceAnalysisPage frmPerformance = new PerformanceAnalysisPage();
        private Settings_Page frmSettings = new Settings_Page();
        private SimulationManagementPage frmSimulation = new SimulationManagementPage();
        private User_Management_Page frmUser = new User_Management_Page();



        private void digitalTwinCreationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDigitalTwin.MdiParent = this;
            frmDigitalTwin.Show();
            frmDigitalTwin.Activate();
        }

        private void simulationManagementPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSimulation.MdiParent = this;
            frmSimulation.Show();
            frmSimulation.Activate();
        }

        private void performanceAnalysisPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmPerformance.MdiParent = this;
            frmPerformance.Show();
            frmPerformance.Activate();
        }

        private void designIterationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmDesign.MdiParent = this;
            frmDesign.Show();
            frmDesign.Activate();
        }

        private void dataManagementPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmManagment.MdiParent = this;
            frmManagment.Show();
            frmManagment.Activate();
        }

        private void collaborationPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCollaboration.MdiParent = this;
            frmCollaboration.Show();
            frmCollaboration.Activate();
        }

        private void userManagementPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUser.MdiParent = this;
            frmUser.Show();
            frmUser.Activate();
        }

        private void settingsPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmSettings.MdiParent = this;
            frmSettings.Show();
            frmSettings.Activate();
        }

        private void helpAndSupportPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmHelp.MdiParent = this;
            frmHelp.Show();
            frmHelp.Activate();
        }

        private void feedbackPageToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmFeedback.MdiParent = this;
            frmFeedback.Show();
            frmFeedback.Activate();
        }
    }
}
