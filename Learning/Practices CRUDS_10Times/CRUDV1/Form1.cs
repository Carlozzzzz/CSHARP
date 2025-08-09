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
    public partial class Form1 : Form
    {

        private Timer debounceTimer;
        private bool isInitializing;

        public Form1()
        {
            isInitializing = true;
            InitializeComponent();
            DisplayUsers();

            debounceTimer = new Timer();
            debounceTimer.Interval = 500;
            debounceTimer.Tick += DebounceTimer_Tick;
            isInitializing = false;

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
                row["USER LEVEL"] = user.Userlevel;
                row["CREATION DATE"] = user.Created_at;
                row["MODIFIED DATE"] = user.Modified_at;


                dataTable.Rows.Add(row);
            }

            userGridView.DataSource = dataTable;
            userGridView.Columns["ID"].Visible = false;

            PopulateEditDeleteButtons(userGridView);
        }

        public void DisplayProducts()
        {

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("USER ID");
            dataTable.Columns.Add("PRODUCT");
            dataTable.Columns.Add("QUANTITY");
            dataTable.Columns.Add("CREATION DATE");
            dataTable.Columns.Add("MODIFIED DATE");

            var productRepo = new ProductRepository();
            var products = productRepo.GetProducts();

            foreach (var product in products)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = product.Id;
                row["USER ID"] = product.User_id;
                row["PRODUCT"] = product.ProductName;
                row["QUANTITY"] = product.Quantity;
                row["CREATION DATE"] = product.Created_at;
                row["MODIFIED DATE"] = product.Modified_at;


                dataTable.Rows.Add(row);
            }

            productGridView.DataSource = dataTable;
            productGridView.Columns["ID"].Visible = false;
            productGridView.Columns["USER ID"].Visible = false;

            PopulateEditDeleteButtons(productGridView);
        }

        private void PopulateEditDeleteButtons(DataGridView gridView)
        {
            if (!gridView.Columns.Contains("Edit") && !gridView.Columns.Contains("Delete"))
            {
                // Edit Button
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                gridView.Columns.Add(editButton);

                // Delete Button
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                gridView.Columns.Add(deleteButton);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tcDataDisplay.SelectedIndex == 0)
            {
                CreateEditUser form = new CreateEditUser();
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    DisplayUsers();
                }
            } else if (tcDataDisplay.SelectedIndex == 1)
            {
                CreateEditProduct form = new CreateEditProduct();
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    DisplayProducts();
                }
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

                bool result = repo.DeleteUser(userId);

                if (result)
                {
                    MessageBox.Show("User has been deleted. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete the user. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DisplayUsers();
            }

        }

        private void productGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row clicks

            string columnName = productGridView.Columns[e.ColumnIndex].Name;

            string id = productGridView.Rows[e.RowIndex].Cells["ID"].Value.ToString();

            if (id == null || id.Length == 0) return;

            int productId = int.Parse(id);

            var productRepo = new ProductRepository();

            if (columnName == "Edit")
            {
                var product = productRepo.GetProduct(productId);

                if (product == null) return;

                CreateEditProduct form = new CreateEditProduct();
                form.EditProduct(product);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DisplayProducts();
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

                bool result = productRepo.DeleteProduct(productId);

                if (result)
                {
                    MessageBox.Show("Product has been deleted. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete Product. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                DisplayProducts();
            }
        }

        private void tcDataDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSearch.Text = "Search...";

            if (tcDataDisplay.SelectedIndex == 0)
            {
                DisplayUsers();
            }
            else if (tcDataDisplay.SelectedIndex == 1)
            {
                DisplayProducts();

            }
        }

        private void DebounceTimer_Tick(object sender, EventArgs e)
        {
            if (isInitializing) return;
            debounceTimer.Stop();
            FilterTable();
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
        public void FilterTable()
        {
            string searchText = tbSearch.Text.Trim().ToLower();

            if (tbSearch.Text.ToLower().Trim() == "search...") searchText = "";

            if (tcDataDisplay.SelectedIndex == 0)
            {
                var userRepository = new UserRepository();
                var users = userRepository.GetUsers();

                var filtered = users.Where(u =>
                        u.Username.ToLower().Contains(searchText) ||
                        u.Email.ToLower().Contains(searchText) ||
                        u.Userlevel.ToLower().Contains(searchText)
                    );

                users = filtered.ToList();
                DataTable dataTable = DisplayList(users);

                userGridView.DataSource = dataTable;
                userGridView.Columns["ID"].Visible = false;
            }
            
            if (tcDataDisplay.SelectedIndex == 1)
            {
                var productRepository = new ProductRepository();
                var products = productRepository.GetProducts();

                var filtered = products.Where(p =>
                        p.ProductName.ToLower().Contains(searchText) ||
                        p.Quantity.ToString().Contains(searchText)
                    );

                products = filtered.ToList();

                DataTable dataTable = DisplayList(products);

                Console.WriteLine(products.Count);

                productGridView.DataSource = dataTable;
                productGridView.Columns["ID"].Visible = false;
                productGridView.Columns["USER ID"].Visible = false;
            }
        }

        private DataTable DisplayList(List<User> users)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("USERNAME");
            dataTable.Columns.Add("EMAIL");
            dataTable.Columns.Add("USER LEVEL");
            dataTable.Columns.Add("CREATION DATE");
            dataTable.Columns.Add("MODIFIED DATE");

            foreach (var user in users)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = user.Id;
                row["USERNAME"] = user.Username;
                row["EMAIL"] = user.Email;
                row["USER LEVEL"] = user.Userlevel;
                row["CREATION DATE"] = user.Created_at;
                row["MODIFIED DATE"] = user.Modified_at;


                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private DataTable DisplayList(List<Product> products)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("USER ID");
            dataTable.Columns.Add("PRODUCT");
            dataTable.Columns.Add("QUANTITY");
            dataTable.Columns.Add("CREATION DATE");
            dataTable.Columns.Add("MODIFIED DATE");

            foreach (var product in products)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = product.Id;
                row["USER ID"] = product.User_id;
                row["PRODUCT"] = product.ProductName;
                row["QUANTITY"] = product.Quantity;
                row["CREATION DATE"] = product.Created_at;
                row["MODIFIED DATE"] = product.Modified_at;


                dataTable.Rows.Add(row);
            }

            return dataTable;
        }
    }
}
