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

        private Timer debounceTimer;
        private bool isInitializing;
        bool isRoleSelected = false;
        bool isStatusSelected = false;
        bool isDateSelected = false;
        public usermanagementform()
        {
            isInitializing = true;
            InitializeComponent();
            ReadUsers();
            PopulateRoles();
            this.usersGridView.CellContentClick += UsersGridView_CellContentClick;

            debounceTimer = new Timer();
            debounceTimer.Interval = 500;
            debounceTimer.Tick += DebounceTimer_Tick;
            tbSearch.TextChanged += tbSearch_TextChanged;
            isInitializing = false;
        }

        private void PopulateRoles()
        {
            var repo = new UserLevelRepository();
            var roles = repo.GetUserLevels();

            cbRoles.Items.Clear();

            var comboItems = new List<ComboItem>();

            comboItems.Add(new ComboItem() { ID = 0, Name = "--Roles--" });

            foreach (var role in roles)
            {
                comboItems.Add(new ComboItem() { ID = role.id, Name = role.level });
            }

            cbRoles.DataSource = comboItems;
            cbRoles.ValueMember = "ID";
            cbRoles.DisplayMember = "Name";
        }

        private void UsersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row clicks

            string columnName = usersGridView.Columns[e.ColumnIndex].Name;

            string id = usersGridView.Rows[e.RowIndex].Cells["id"].Value.ToString();

            if (id == null || id.Length == 0) return;

            int userId = int.Parse(id);

            var repo = new UserRepository();

            if (columnName == "Manage")
            {
                var user = repo.GetUser(userId);

                if (user == null) return;

                EditUserPasswordForm form = new EditUserPasswordForm();
                form.EditUserPassword(user);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    ReadUsers(); // refresh the user list after editing
                }
            }
            else if (columnName == "Edit")
            {
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
            // bind the datatable to the 

            var userRepository = new UserRepository();
            var users = userRepository.GetUsers();
            DataTable dataTable = DisplayList(users);

            this.usersGridView.DataSource = dataTable;
            usersGridView.Columns["ID"].Visible = false; // Hide ID column

            // Prevent multiple additions
            if (!usersGridView.Columns.Contains("Manage") &&  !usersGridView.Columns.Contains("Edit") && !usersGridView.Columns.Contains("Delete"))
            {
                // Manage Button
                DataGridViewButtonColumn manageButton = new DataGridViewButtonColumn();
                manageButton.Name = "Manage";
                manageButton.HeaderText = "Manage";
                manageButton.Text = "Manage";
                manageButton.UseColumnTextForButtonValue = true;
                usersGridView.Columns.Add(manageButton);

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }
        private void tbSearch_Click(object sender, EventArgs e)
        {
            if (tbSearch.Text.ToLower().Trim() == "search...") tbSearch.Text = "";
        }

        private void tbSearch_Leave(object sender, EventArgs e)
        {
            if (tbSearch.Text.ToLower().Trim() == "") tbSearch.Text = "Search...";
        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;

            if (cbRoles.SelectedIndex == 0) isRoleSelected = false;
            else isRoleSelected = true;

            FilterTable();
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;

            isStatusSelected = true;

            FilterTable();
        }

        private void dtpCreatedAt_ValueChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;

            isDateSelected = true;

            FilterTable();
        }


        public void DebounceTimer_Tick(object sender, EventArgs e)
        {
            if (isInitializing) return;

            debounceTimer.Stop();

            FilterTable();
        }

        public void FilterTable()
        {
            string searchText = tbSearch.Text.Trim().ToLower();
            if (tbSearch.Text.ToLower().Trim() == "search...") searchText = "";

            var repo = new UserRepository();
            var users = repo.GetUsers();
            int userLevelId = 0;

            if (cbRoles.SelectedValue is int)
                userLevelId = (int)cbRoles.SelectedValue;
            else if (cbRoles.SelectedItem is ComboItem item)
                userLevelId = item.ID;

            int status = cbStatus.SelectedIndex;

            Console.WriteLine("status: " + status);

            DateTime selectedDate = dtpCreatedAt.Value.Date;

            var filtered = users.Where(p =>
                    p.username.ToLower().Contains(searchText) ||
                    p.email.ToLower().Contains(searchText) ||
                    p.level.ToLower().Contains(searchText)
                );

            if (isRoleSelected)
                filtered = filtered.Where(p => p.userlevel_id == userLevelId);

            if (isStatusSelected)
                filtered = filtered.Where(p => p.is_active != status);

            if (isDateSelected)
                filtered = filtered.Where(p => Convert.ToDateTime(p.createdAt) >= selectedDate);

            users = filtered.ToList();

            DataTable dataTable = DisplayList(users);

            usersGridView.DataSource = dataTable;
            usersGridView.Columns["ID"].Visible = false;
        }

        public DataTable DisplayList(List<User> users)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("Created_At");
            dataTable.Columns.Add("User_Level");

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

            return dataTable;
        }

        public void RefreshProducts()
        {
            tbSearch.Text = "Search...";
            cbStatus.Text = "--Status--";
            isStatusSelected = false;
            dtpCreatedAt.Value = new DateTime(1900, 1, 1);
            isDateSelected = false;
            isRoleSelected = false;
            cbRoles.Text = "--Roles--";
            cbRoles.SelectedIndex = 0;
            ReadUsers();
        }
    }
}
