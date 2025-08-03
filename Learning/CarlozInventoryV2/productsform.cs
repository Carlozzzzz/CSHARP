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
    public partial class productsform : Form
    {

        private Timer debounceTimer;
        private bool isInitializing;
        bool isSupplierSelected = false;
        bool isStatusSelected = false;
        bool isDateSelected = false;

        public productsform()
        {
            InitializeComponent();
            isInitializing = true;
            ReadProducts();
            PopulateSuppliers();

            debounceTimer = new Timer();
            debounceTimer.Interval = 500;
            debounceTimer.Tick += DebounceTimer_Tick;

            tbSearchProduct.TextChanged += tbSearchProduct_TextChanged;
            isInitializing = false;

        }

        private void PopulateSuppliers()
        {
            var repo = new SupplierRepository();
            var suppliers = repo.GetSuppliers();

            cbSupplier.Items.Clear();

            var comboItems = new List<ComboItem>();

            comboItems.Add(new ComboItem() { ID = 0, Name = "--Suppliers--" });

            foreach (var supplier in suppliers)
            {
                comboItems.Add(new ComboItem() { ID = supplier.Id, Name = supplier.SupplierName });
            }

            cbSupplier.DataSource = comboItems;
            cbSupplier.ValueMember = "ID";
            cbSupplier.DisplayMember = "Name";

        }

        public List<Product> ReadProducts()
        {
            var repo = new ProductRepository();
            var products = repo.GetProducts();

            DataTable dataTable = DisplayList(products);

            productsGridView.DataSource = dataTable;
            productsGridView.Columns["Id"].Visible = false;
            productsGridView.Columns["SupplierId"].Visible = false;

            if (!productsGridView.Columns.Contains("Edit") && !productsGridView.Columns.Contains("Delete"))
            {
                // Edit Button
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                productsGridView.Columns.Add(editButton);
                // Delete Button
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                productsGridView.Columns.Add(deleteButton);
            }

            return products;

        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            CreateEditProduct form = new CreateEditProduct();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                ReadProducts();
            }
        }

        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row clicks

            string columnName = productsGridView.Columns[e.ColumnIndex].Name;

            string id = productsGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString();

            if (id == null || id.Length == 0) return;

            int productId = int.Parse(id);

            var repo = new ProductRepository();


            if (columnName == "Edit")
            {
                var product = repo.GetProduct(productId);

                if (product == null) return;

                CreateEditProduct form = new CreateEditProduct();
                form.EditProduct(product);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefreshProducts();
                }
            }
            else if (columnName == "Delete")
            {
                DialogResult dialogResult =
                MessageBox.Show("Are you sure you want to delete this product?",
                    "Delete Product",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                repo.DeleteProduct(productId);

                RefreshProducts();

                LogRepo.CreateLog("user deleted a product : " + productId);

                MessageBox.Show("Product has been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRefreshProduct_Click(object sender, EventArgs e)
        {
            RefreshProducts();
        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        public void DebounceTimer_Tick(object sender, EventArgs e)
        {
            if (isInitializing) return;

            debounceTimer.Stop();

            FilterTable();
        }
        
        private void cbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;

            if (cbSupplier.SelectedIndex == 0) isSupplierSelected = false;
            else isSupplierSelected = true;

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

        public void FilterTable()
        {
            string searchText = tbSearchProduct.Text.Trim().ToLower();
            if (tbSearchProduct.Text.ToLower().Trim() == "search...") searchText = "";

            var repo = new ProductRepository();
            var products = repo.GetProducts();
            int supplierId = 0;

            if (cbSupplier.SelectedValue is int)
                supplierId = (int)cbSupplier.SelectedValue;
            else if (cbSupplier.SelectedItem is ComboItem item)
                supplierId = item.ID;

            bool status = cbStatus.SelectedIndex != 0 ? false : true;

            DateTime selectedDate = dtpCreatedAt.Value.Date;

            var filtered = products.Where(p =>
                    p.ProductName.ToLower().Contains(searchText) ||
                    p.Description.ToLower().Contains(searchText) ||
                    p.SupplierName.ToLower().Contains(searchText)
                );

            if (isSupplierSelected)
                filtered = filtered.Where(p => p.SupplierId == supplierId);

            if (isStatusSelected)
                filtered = filtered.Where(p => p.IsActive == status);

            if (isDateSelected)
                filtered = filtered.Where(p => p.CreatedAt >= selectedDate);

            products = filtered.ToList();

            DataTable dataTable = DisplayList(products);

            productsGridView.DataSource = dataTable;
            productsGridView.Columns["Id"].Visible = false;
            productsGridView.Columns["SupplierId"].Visible = false;
        }

        public DataTable DisplayList(List<Product> products)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("SupplierId", typeof(int));
            dataTable.Columns.Add("Supplier", typeof(string));
            dataTable.Columns.Add("Product", typeof(string));
            dataTable.Columns.Add("Description", typeof(string));
            dataTable.Columns.Add("Quantity", typeof(int));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Modified At", typeof(DateTime));
            dataTable.Columns.Add("Created At", typeof(DateTime));

            foreach (var product in products)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = product.Id;
                row["SupplierId"] = product.SupplierId;
                row["Supplier"] = product.SupplierName;
                row["Product"] = product.ProductName;
                row["Description"] = product.Description;
                row["Quantity"] = product.Quantity;
                row["Status"] = product.IsActive ? "Active" : "Inactive";
                row["Modified At"] = product.ModifiedAt;
                row["Created At"] = product.CreatedAt;
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void tbSearchProduct_Click(object sender, EventArgs e)
        {
            if (tbSearchProduct.Text.ToLower().Trim() == "search...") tbSearchProduct.Text = "";
        }

        private void tbSearchProduct_Leave(object sender, EventArgs e)
        {
            if (tbSearchProduct.Text.ToLower().Trim() == "") tbSearchProduct.Text = "Search...";

        }

        public void RefreshProducts()
        {
            tbSearchProduct.Text = "Search...";
            cbStatus.Text = "--Status--";
            isStatusSelected = false;
            dtpCreatedAt.Value = new DateTime(1900, 1, 1);
            isDateSelected = false;
            isSupplierSelected = false;
            cbSupplier.SelectedIndex = 0;
            ReadProducts();
        }
    }
}
