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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = this.tbUsername.Text;
            string password = this.tbPassword.Text;

            bool isFormNotNull = ValidateForm(username, password);

            if (isFormNotNull)
            {
                LoginRepository loginRepository = new LoginRepository();
                bool isLoginSuccessful = loginRepository.LoginUser(username, password);

                if (isLoginSuccessful)
                {
                    MessageBox.Show("Logged in successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Hide the login form
                    this.Hide();

                    // Show the dashboard
                    Form1 dashboardForm = new Form1();
                    dashboardForm.FormClosed += (s, args) => this.Close(); // Close login when dashboard closes
                    dashboardForm.Show();
                }
                else
                {
                    MessageBox.Show("Failed to log in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private bool ValidateForm(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
