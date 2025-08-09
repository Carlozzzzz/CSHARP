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

        public int userId = 0;
        public CreateEditUser()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {

                User user = new User();
                user.Username = tbUsername.Text;
                user.Password = tbPassword.Text;
                user.Email = tbEmail.Text;
                user.User_level = cbUserLevel.SelectedIndex;
                user.Modified_at = DateTime.Now;

                var userRepo = new UserRepository();
                bool result;
                string successMessage = "";
                string errorMessage = "";

                if (userId == 0)
                {
                    user.Created_at = DateTime.Now;
                    result = userRepo.CreateUser(user);
                    successMessage = "User has been created successfully. ";
                    errorMessage = "Failed to crate user.";
                }
                else
                {
                    user.Id = userId;
                    result = userRepo.UpdateUser(user);
                    successMessage = "User has been updated successfully. ";
                    errorMessage = "Failed to update user.";
                }


                if (result)
                {
                    MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(errorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

        }

        public void EditUser(User user)
        {
            btnSave.Text = "Update";
            lblCreateEditUser.Text = "Update";
            userId = user.Id;
            tbUsername.Text = user.Username;
            tbPassword.Text = user.Password;
            tbEmail.Text = user.Email;
            cbUserLevel.SelectedIndex = user.User_level;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("User is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail.Focus();
                return false;
            }

            // Optional: Basic email structure check
            if (!tbEmail.Text.Contains("@") || !tbEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbUserLevel.Text) || cbUserLevel.SelectedIndex < 0)
            {
                MessageBox.Show("Please select User Level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbUserLevel.Focus();
                return false;
            }

            return true;
        }
    }
}
