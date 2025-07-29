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
    public partial class CreateEditSupplier : Form
    {
        public CreateEditSupplier()
        {
            InitializeComponent();
        }

        private int id = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    var repo = new SupplierRepository();
                    Supplier supplier = new Supplier();

                    string logMessage = "";

                    supplier.SupplierName = this.tbSupplierName.Text;
                    supplier.Email = this.tbSupplierEmail.Text;
                    supplier.Phone = this.tbSupplierMobile.Text;
                    supplier.IsActive = this.tbSupplierStatus.SelectedIndex == 0 ? true : false;
                    supplier.ModifiedAt = DateTime.Now;

                    if (id == 0)
                    {
                        supplier.CreatedAt = DateTime.Now;
                        repo.CreateSupplier(supplier);
                        logMessage = "create supplier : " + supplier.Id;
                        MessageBox.Show("Supplier has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else if(id != 0)
                    {
                        supplier.Id = id;
                        repo.UpdateSupplier(supplier);
                        logMessage = "update supplier : " + +supplier.Id;
                        MessageBox.Show("Supplier has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    var log = new Log();
                    log.UserId = Session.UserId;
                    log.Action = logMessage;
                    var logsRepo = new LogsRepository();
                    logsRepo.CreateLog(log);

                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void EditSupplier(Supplier supplier)
        {
            id = supplier.Id;
            this.Text = "Edit Supplier";
            this.lbTitle.Text = "Edit Supplier";
            this.tbSupplierName.Text = supplier.SupplierName;
            this.tbSupplierEmail.Text = supplier.Email;
            this.tbSupplierMobile.Text = supplier.Phone;
            this.tbSupplierStatus.SelectedIndex = supplier.IsActive ? 0 : 1;
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(tbSupplierName.Text))
            {
                MessageBox.Show("Supplier name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSupplierName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbSupplierEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSupplierEmail.Focus();
                return false;
            }

            // Optional: Basic email structure check
            if (!tbSupplierEmail.Text.Contains("@") || !tbSupplierEmail.Text.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSupplierEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbSupplierMobile.Text))
            {
                MessageBox.Show("Mobile number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSupplierMobile.Focus();
                return false;
            }

            // Optional: Ensure mobile number contains only digits
            if (!tbSupplierMobile.Text.All(char.IsDigit))
            {
                MessageBox.Show("Mobile number must contain only digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSupplierMobile.Focus();
                return false;
            }

            // Check ComboBox (e.g., "Active", "Inactive", etc.)
            if (string.IsNullOrWhiteSpace(tbSupplierStatus.Text) || tbSupplierStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a supplier status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSupplierStatus.Focus();
                return false;
            }

            return true; // All checks passed
        }

    }
}
