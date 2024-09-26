﻿using System;
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
    public partial class User_Management_Page : Form
    {
        public User_Management_Page()
        {
            InitializeComponent();
        }
        private New_User new_User = new New_User();
        private Edit edit = new Edit();
        private View view = new View();


        private void User_Management_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;// disposed, we cant use the instance
            this.Hide(); //visibility
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            new_User.MdiParent = MyConfig.frmHome;
            new_User.Show();
            new_User.Activate();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            edit.MdiParent = MyConfig.frmHome;
            edit.Show();
            edit.Activate();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            view.MdiParent = MyConfig.frmHome;
            view.Show();
            view.Activate();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
