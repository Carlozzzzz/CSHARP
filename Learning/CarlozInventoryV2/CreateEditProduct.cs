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
    public partial class CreateEditProduct : Form
    {
        public CreateEditProduct()
        {
            InitializeComponent();
            PopulateSuppliers();
        }

        private int id = 0;

        private void PopulateSuppliers()
        {
            var repo = new SupplierRepository();
            var suppliers = repo.GetSuppliers();

            cbSupplier.Items.Clear();

            var comboItems = new List<ComboItem>();

            comboItems.Add(new ComboItem() { ID = 0, Name = "--Select Supplier--" });

            foreach (var supplier in suppliers)
            {
                comboItems.Add(new ComboItem() { ID = supplier.Id, Name = supplier.SupplierName });
            }

            cbSupplier.DataSource = comboItems;
            cbSupplier.ValueMember = "ID";
            cbSupplier.DisplayMember = "Name";

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    Product product = new Product();
                    product.SupplierId = Convert.ToInt32(cbSupplier.SelectedValue);
                    product.ProductName = tbProduct.Text;
                    product.Description = tbDescription.Text;
                    product.Quantity = Convert.ToInt32(tbQuantity.Text);
                    product.IsActive = cbStatus.SelectedIndex == 0 ? true : false;

                    product.ModifiedAt = DateTime.Now;

                    string logMessage = "";
                    string dialogMessage = "";

                    var repo = new ProductRepository();

                    if (this.id == 0)
                    {
                        product.CreatedAt = DateTime.Now;
                        repo.CreateProduct(product);

                        logMessage = "create product : " + product.Id;
                        dialogMessage = "Supplier has been created successfully!";
                    }
                    else if (this.id > 0)
                    {
                        product.Id = this.id;
                        product.ModifiedAt = DateTime.Now;
                        repo.UpdateProduct(product);
                        Console.WriteLine(product.ProductName);

                        logMessage = "update product : " + product.Id;
                        dialogMessage = "Supplier has been updated successfully!";

                    }
                    LogRepo.CreateLog(logMessage);
                    MessageBox.Show(dialogMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void EditProduct(Product product)
        {
            this.id = product.Id;
            tbSupplierId.Text = Convert.ToString(product.Id);
            cbSupplier.SelectedValue = Convert.ToInt32(product.SupplierId);
            tbProduct.Text = product.ProductName;
            tbDescription.Text = product.Description;
            tbQuantity.Text = product.Quantity.ToString();
            cbStatus.SelectedIndex = product.IsActive ? 0 : 1;
            return;
        }

        private bool ValidateForm()
        {
            if (Convert.ToInt32(cbSupplier.SelectedValue) < 1)
            {
                MessageBox.Show("Please select a supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbStatus.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbSupplier.Text) || cbSupplier.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a supplier.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbSupplier.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbProduct.Text))
            {
                MessageBox.Show("Product name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbProduct.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbDescription.Text))
            {
                MessageBox.Show("Description is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbDescription.Focus();
                return false;
            }


            if (string.IsNullOrWhiteSpace(tbQuantity.Text))
            {
                MessageBox.Show("Quantity is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbQuantity.Focus();
                return false;
            }

            // Optional: Ensure mobile number contains only digits
            if (!tbQuantity.Text.All(char.IsDigit))
            {
                MessageBox.Show("Quantity must contain only digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbQuantity.Focus();
                return false;
            }

            // Check ComboBox (e.g., "Active", "Inactive", etc.)
            if (string.IsNullOrWhiteSpace(cbStatus.Text) || cbStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbStatus.Focus();
                return false;
            }

            

            return true; // All checks passed
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
