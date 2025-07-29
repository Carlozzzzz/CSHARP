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
    public partial class usermanagementform : Form
    {
        public usermanagementform()
        {
            InitializeComponent();
            ReadUsers();
            this.usersGridView.CellContentClick += UsersGridView_CellContentClick;
        }

        private void UsersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row clicks

            string columnName = usersGridView.Columns[e.ColumnIndex].Name;

            string id = usersGridView.Rows[e.RowIndex].Cells["id"].Value.ToString();

            if (id == null || id.Length == 0) return;

            int userId = int.Parse(id);

            var repo = new UserRepository();

            if (columnName == "Edit")
            {
                //MessageBox.Show("Edit has been Clicked!" + id, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Open the CreateEditUser form with the user ID for editing
                // display the user information in the form

                var user = repo.GetUser(userId);

                if (user == null) return;

                EditUserForm form = new EditUserForm();
                form.EditUser(user);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ReadUsers(); // refresh the user list after editing
                }
            }
            else if (columnName == "Delete")
            {
                DialogResult dialogResult =
                MessageBox.Show("Are you sure you want to delete this client?",
                    "Delete Client",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                repo.DeleteUser(userId);

                ReadUsers();
            }
        }

        public void ReadUsers()
        {
            // Initialize Datatable and create columns
            // initialize userRepository
            // create list of users
            // loop through the users and add them to the datatable
            // bind the datatable to the datagridview

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("Created_At");
            dataTable.Columns.Add("User_Level");
            dataTable.Columns.Add("Manage");

            var userRepository = new UserRepository();
            var users = userRepository.GetUsers();

            foreach (var user in users)
            {
                var row = dataTable.NewRow();
                row["ID"] = user.id;
                row["Username"] = user.username;
                row["Email"] = user.email;
                row["Status"] = user.is_active == 1 ? "Active" : "Inactive";
                row["Created_At"] = user.createdAt;
                row["User_Level"] = user.level;

                dataTable.Rows.Add(row);
            }

            this.usersGridView.DataSource = dataTable;
            usersGridView.Columns["ID"].Visible = false; // Hide ID column

            // Prevent multiple additions
            if (!usersGridView.Columns.Contains("Edit") && !usersGridView.Columns.Contains("Delete"))
            {
                // Edit Button
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                usersGridView.Columns.Add(editButton);

                // Delete Button
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                usersGridView.Columns.Add(deleteButton);
            }
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            // create dialog for new user
            // update the datagridview with the new user

            CreateUserForm form = new CreateUserForm();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                ReadUsers();
            }
        }
    }
}
