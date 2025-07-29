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
        public supplierform()
        {
            InitializeComponent();
            ReadSuppliers();
        }

        public void ReadSuppliers()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Supplier Name", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("Phone", typeof(string));
            dataTable.Columns.Add("Update Time", typeof(DateTime));
            dataTable.Columns.Add("Creation Time", typeof(DateTime));

            var repo = new SupplierRepository();
            var suppliers = repo.GetSuppliers();

            foreach (var supplier in suppliers)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = supplier.Id;
                row["Supplier Name"] = supplier.SupplierName;
                row["Email"] = supplier.Email;
                row["Phone"] = supplier.Phone;
                row["Update Time"] = supplier.ModifiedAt;
                row["Creation Time"] = supplier.CreatedAt;

                dataTable.Rows.Add(row);
            }

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
                ReadSuppliers();
            }
        }

        private void btnRefreshSupplier_Click(object sender, EventArgs e)
        {
            ReadSuppliers();
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
                    ReadSuppliers();
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

                ReadSuppliers();

                MessageBox.Show("Supplier has been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
