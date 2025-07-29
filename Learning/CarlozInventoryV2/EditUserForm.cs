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
    public partial class EditUserForm : Form
    {
        public EditUserForm()
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

        public void EditUser(User user)
        {
            this.Text = "Edit User";
            this.lbTitle.Text = "Edit User";

            this.tbId.Text = user.id.ToString();
            this.tbUsername.Text = user.username;
            this.tbEmail.Text = user.email;
            this.cbLevel.SelectedItem = user.level;
            this.cbStatus.SelectedIndex = user.is_active == 1 ? 0 : 1;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var userLevelRepository = new UserLevelRepository();
            var userRepository = new UserRepository();
            User user = new User();

            if (ValidateForm())
            { 
                user.id = Convert.ToInt32(this.tbId.Text);
                user.username = this.tbUsername.Text;
                user.email = this.tbEmail.Text;
                user.userlevel_id = userLevelRepository.GetUserLevelId(this.cbLevel.SelectedItem.ToString());
                user.is_active = this.cbStatus.SelectedIndex == 0 ? 1 : 0;

                userRepository.UpdateUser(user);

                MessageBox.Show("User has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
