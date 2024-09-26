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
    public partial class DigitalTwinCreationPage : Form
    {
        public DigitalTwinCreationPage()
        {
            InitializeComponent();
        }

        private void DigitalTwinCreationPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;// disposed, we cant use the instance
            this.Hide(); //visibility
        }
    }
}
