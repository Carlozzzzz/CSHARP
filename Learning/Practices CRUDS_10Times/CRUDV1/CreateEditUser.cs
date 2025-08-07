using CRUDV1.Model;
using CRUDV1.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDV1
{
    public partial class CreateEditUser : Form
    {
        public CreateEditUser()
        {
            InitializeComponent();
        }

        public void EditUser(User user)
        {

            tbUsername.Text = user.Username;
            tbPassword.Text = user.Password;
            tbEmail.Text = user.Email;
            cbUserLevel.SelectedIndex = user.User_level;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Username = tbUsername.Text;
            user.Password = tbPassword.Text;
            user.Email = tbEmail.Text;
            user.User_level = cbUserLevel.SelectedIndex;
            user.Created_at = DateTime.Now;

            var userRepo = new UserRepository();

            if (userRepo.CreateUser(user))
            {
                MessageBox.Show("User has been created successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
