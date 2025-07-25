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
    public partial class CreateEditUser : Form
    {
        public CreateEditUser()
        {
            InitializeComponent();
            GetUserLevels();
        }

        private int userId = 0;

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

            User user = new User();
            user.username = this.tbUsername.Text;
            user.email = this.tbEmail.Text;
            user.password = CheckPassword(this.tbPassword.Text, this.tbRetypePassword.Text) ? this.tbPassword.Text : string.Empty; // modify this
            user.status = this.cbStatus.SelectedIndex == 0 ? 1 : 0;
           
        }

        public bool CheckPassword(string password, string retypePass)
        {
            if(password != retypePass)
            {
                MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                // Proceed with saving the user
                return true;
            }
        }
    }
}
