using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CaseStudyProduct
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }
        //    private User user = new User { Name = "", Email = "", Password = "", Role = "" };
        //    private bool IsNew { get; set; } = true;
        //    private string SaveActionText { get => (IsNew ? "Create Contact" : "Update Contact"); }
        //    private IRepo repo = new ListMemoryRepo();

        private void Edit_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        //    private void DoLoadContacts()
        //    {
        //        lstEdit.DataSource = null;
        //        lstEdit.DataSource = repo.ReadAll();//Db ReadAll in CRUD 
        //    }

        //    private void DoNewUser()
        //    {
        //        //new user object
        //        user = new User { Name = "", Email = "", Password = "", Role = "" };
        //        //object to UIs
        //        txtName.Text = user.Name;
        //        txtEmail.Text = user.Email;
        //        txtPassword.Text = user.Password;
        //        txtRole.Text = user.Role;
        //        //new mode out of edit & new modes
        //        IsNew = true;
        //        btnCreate.Text = SaveActionText;
        //        txtEmail.Enabled = IsNew;
        //        //
        //        txtName.Focus();
        //    }

        //    private void OnEdit()
        //    {
        //        //selected contact
        //        User selectedUser = (User)lstEdit.SelectedItem;
        //        //db read by email in CRUD
        //        this.user = repo.ReadByEmail(selectedUser.Email);
        //        //object to UIs
        //        txtEmail.Text = user.Email;
        //        txtName.Text = user.Name;
        //        txtPhone.Text = user.Phone;

        //        //edit mode out of edit & new modes
        //        IsNew = false;
        //        btnUpdate.Text = SaveActionText;
        //        txtEmail.Enabled = IsNew;
        //        //
        //        txtName.Focus();
        //    }
    }
}
