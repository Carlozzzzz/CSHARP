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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DisplayUsers();
        }

        public void DisplayUsers()
        {
            
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("USERNAME");
            dataTable.Columns.Add("EMAIL");
            dataTable.Columns.Add("USER LEVEL");
            dataTable.Columns.Add("CREATION DATE");
            dataTable.Columns.Add("MODIFIED DATE");

            var userRepo = new UserRepository();
            var users = userRepo.GetUsers();

            foreach (var user in users)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = user.Id;
                row["USERNAME"] = user.Username;
                row["EMAIL"] = user.Email;
                row["USER LEVEL"] = user.User_level == 0 ? "Admin" : "User";
                row["CREATION DATE"] = user.Created_at;
                row["MODIFIED DATE"] = user.Modified_at;


                dataTable.Rows.Add(row);
            }

            userGridView.DataSource = dataTable;

            if (!userGridView.Columns.Contains("Edit") && !userGridView.Columns.Contains("Delete"))
            {
                // Edit Button
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                userGridView.Columns.Add(editButton);

                // Delete Button
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                userGridView.Columns.Add(deleteButton);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            CreateEditUser form = new CreateEditUser();
            DialogResult result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                DisplayUsers();
            }
        }
        private void userGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return; // Ignore header row clicks

            string columnName = userGridView.Columns[e.ColumnIndex].Name;

            string id = userGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            Console.WriteLine("Clicked users: " + id);


            if (id == null || id.Length == 0) return;

            int userId = int.Parse(id);

            var repo = new UserRepository();

            if (columnName == "Edit")
            {
                var user = repo.GetUser(userId);

                if (user == null) return;

                CreateEditUser form = new CreateEditUser();
                form.EditUser(user);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DisplayUsers();
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

                DisplayUsers();
            }

        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
