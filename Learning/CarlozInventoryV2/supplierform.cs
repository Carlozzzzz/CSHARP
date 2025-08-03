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
    public partial class supplierform : Form
    {
        private Timer debounceTimer;
        private bool isInitializing;
        private bool isStatusSelected = false;
        private bool isDateSelected = false;

        public supplierform()
        {
            isInitializing = true;
            InitializeComponent();
            ReadSuppliers();

            debounceTimer = new Timer();
            debounceTimer.Interval = 500;
            debounceTimer.Tick += DebounceTimer_Tick;

            tbSearchSupplier.TextChanged += tbSearchSupplier_TextChanged;
            isInitializing = false;
        }

        public void ReadSuppliers()
        {
           
            var repo = new SupplierRepository();
            var suppliers = repo.GetSuppliers();
            DataTable dataTable = DisplayList(suppliers);

            this.supplierGridView.DataSource = dataTable;

            supplierGridView.Columns["ID"].Visible = false; // Hide ID column

            // Prevent multiple additions
            if (!supplierGridView.Columns.Contains("Edit") && !supplierGridView.Columns.Contains("Delete"))
            {
                // Edit Button
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                supplierGridView.Columns.Add(editButton);

                // Delete Button
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                supplierGridView.Columns.Add(deleteButton);

            }
        }

        private void btnNewSupplier_Click(object sender, EventArgs e)
        {
            CreateEditSupplier form = new CreateEditSupplier();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                RefreshSuppliers();
            }
        }

        private void btnRefreshSupplier_Click(object sender, EventArgs e)
        {
            RefreshSuppliers();
        }

        private void supplierGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Ignore header row clicks

            string columnName = supplierGridView.Columns[e.ColumnIndex].Name;

            string id = supplierGridView.Rows[e.RowIndex].Cells["id"].Value.ToString();

            if (id == null || id.Length == 0) return;

            int supplierId = int.Parse(id);

            var repo = new SupplierRepository();


            if (columnName == "Edit")
            {
                var supplier = repo.GetSupplier(supplierId);

                if (supplier == null) return;

                CreateEditSupplier form = new CreateEditSupplier();
                form.EditSupplier(supplier);
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefreshSuppliers();
                }
            }
            else if (columnName == "Delete")
            {
                DialogResult dialogResult =
                MessageBox.Show("Are you sure you want to delete this supplier?",
                    "Delete Supplier",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }

                repo.DeleteSupplier(supplierId);

                RefreshSuppliers();

                LogRepo.CreateLog("user deleted a supplier : " + supplierId);

                MessageBox.Show("Supplier has been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tbSearchSupplier_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void cbStatusSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;

            isStatusSelected = true;

            FilterTable();
        }

        private void dtpCreatedAtSupplier_ValueChanged(object sender, EventArgs e)
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

        public DataTable DisplayList(List<Supplier> suppliers)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Supplier Name", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Update Time", typeof(DateTime));
            dataTable.Columns.Add("Creation Time", typeof(DateTime));

            foreach (var supplier in suppliers)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = supplier.Id;
                row["Supplier Name"] = supplier.SupplierName;
                row["Email"] = supplier.Email;
                row["Phone"] = supplier.Phone;
                row["Status"] = supplier.IsActive ? "Active" : "Inactive";
                row["Update Time"] = supplier.ModifiedAt;
                row["Creation Time"] = supplier.CreatedAt;

                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        public void FilterTable()
        {
            string searchText = tbSearchSupplier.Text.Trim().ToLower();
            if (tbSearchSupplier.Text.ToLower().Trim() == "search...") searchText = "";

            var repo = new SupplierRepository();
            var suppliers = repo.GetSuppliers();

            bool status = cbStatusSupplier.SelectedIndex != 0 ? false : true;

            DateTime selectedDate = dtpCreatedAtSupplier.Value.Date;

            var filtered = suppliers.Where(s =>
                    s.SupplierName.ToLower().Contains(searchText) ||
                    s.Email.ToLower().Contains(searchText) ||
                    s.Phone.ToLower().Contains(searchText)
                );


            if (isStatusSelected)
                filtered = filtered.Where(p => p.IsActive == status);

            if (isDateSelected)
                filtered = filtered.Where(p => p.CreatedAt >= selectedDate);

            suppliers = filtered.ToList();

            DataTable dataTable = DisplayList(suppliers);

            supplierGridView.DataSource = dataTable;
            supplierGridView.Columns["Id"].Visible = false;
        }

        public void RefreshSuppliers()
        {
            tbSearchSupplier.Text = "Search...";
            cbStatusSupplier.Text = "--Status--";
            isStatusSelected = false;
            dtpCreatedAtSupplier.Value = new DateTime(1900, 1, 1);
            isDateSelected = false;
            ReadSuppliers();
        }

        private void tbSearchSupplier_Click(object sender, EventArgs e)
        {
            if (tbSearchSupplier.Text.ToLower().Trim() == "search...") tbSearchSupplier.Text = "";
        }

        private void tbSearchSupplier_MouseLeave(object sender, EventArgs e)
        {
            if (tbSearchSupplier.Text.ToLower().Trim() == "") tbSearchSupplier.Text = "Search...";
        }
    }
}
