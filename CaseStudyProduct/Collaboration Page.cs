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
    public partial class Collaboration_Page : Form
    {
        public Collaboration_Page()
        {
            InitializeComponent();
        }

        private void Collaboration_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;// disposed, we cant use the instance
            this.Hide(); //visibility
        }
    }
}
