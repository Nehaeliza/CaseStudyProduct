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
    public partial class FeedBack_Page : Form
    {
        public FeedBack_Page()
        {
            InitializeComponent();
        }

        private void FeedBack_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;// disposed, we cant use the instance
            this.Hide(); //visibility
        }
    }
}
