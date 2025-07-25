using CarlozInventoryV2.Models;
using CarlozInventoryV2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlozInventoryV2
{
    public partial class CreateUserForm : Form
    {
        public CreateUserForm()
        {
            InitializeComponent();
            GetUserLevels();
        }

        private void GetUserLevels()
        {
            // Initialize UserLevelRepository
            // Get the user levels
            // Loop through the user levels and add them to the combobox
            // Set the selected index to 0


            var userLevelRepository = new UserLevelRepository();
            var userLevels = userLevelRepository.GetUserLevels();
            foreach (var userLevel in userLevels)
            {
                this.cbLevel.Items.Add(userLevel.level);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Initialize User object
            // save the inputs to user object
            // Initialize the UserRepository
            // check the ID if 0 or has value
            // if ID is 0, then create a new user
            // if ID has value, then update the user
            // update the dialogresult to OK

            var userLevelRepository = new UserLevelRepository();
            User user = new User();

            if (ValidateForm())
            {
                user.username = this.tbUsername.Text;
                user.email = this.tbEmail.Text;
                user.password = this.tbPassword.Text;
                user.userlevel_id = userLevelRepository.GetUserLevelId(this.cbLevel.SelectedItem.ToString());
                user.is_active = this.cbStatus.SelectedIndex == 0 ? 1 : 0;

                var userRepository = new UserRepository();

                userRepository.CreateUser(user);

                MessageBox.Show("User has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
            }

            

        }

       

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Username is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Password is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbRetypePassword.Text))
            {
                MessageBox.Show("Please retype the password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRetypePassword.Focus();
                return false;
            }

            if (tbPassword.Text != tbRetypePassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRetypePassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail.Focus();
                return false;
            }

            if (cbLevel.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a user level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbLevel.Focus();
                return false;
            }

            if (cbStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbStatus.Focus();
                return false;
            }

            return true; // All fields are valid
        }
    }

}
