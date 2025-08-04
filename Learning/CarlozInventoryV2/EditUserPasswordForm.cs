using CarlozInventoryV2.Models;
using CarlozInventoryV2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlozInventoryV2
{
    public partial class EditUserPasswordForm : Form
    {
        private int id;
        public EditUserPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                    {
                        string query = @"UPDATE UsersTbl SET password = @Password WHERE id = @Id";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            connection.Open();
                            command.Parameters.AddWithValue("@Password", tbRetypePassword.Text);
                            command.Parameters.AddWithValue("@Id", id);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Password updated succesfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while updating password: " + ex.Message);
            }
        }

        public void EditUserPassword(User user)
        {
            id = user.id;
            tbUsername.Text = user.username;
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
                MessageBox.Show("Confirm Password is required", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRetypePassword.Focus();
                return false;
            }

            bool isPasswordMatched = false;
            try
            {
                var repo = new UserRepository();
                var user = repo.GetUser(id);

                if (user != null)
                {
                    if (user.password == tbPassword.Text)
                    {
                        isPasswordMatched = true;
                    }
                }
                isPasswordMatched = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retriving user: " + ex.Message);
            }

            

            if (tbPassword.Text != tbRetypePassword.Text)
            {
                MessageBox.Show("Error changing password.", "Validateion Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbRetypePassword.Focus();
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
