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
    public partial class CreateEditProduct : Form
    {
        private int productId = 0;
        public CreateEditProduct()
        {
            InitializeComponent();
            PopulateUsers();
        }

        public void PopulateUsers()
        {
            var userRepo = new UserRepository();
            var users = userRepo.GetUsers();

            cbUsers.Items.Clear();
            var comboItems = new List<ComboItem>();

            foreach (var user in users)
            {
                comboItems.Add(new ComboItem() { Id = user.Id, Name = user.Username });
            }

            cbUsers.DataSource = comboItems;
            cbUsers.ValueMember = "ID";
            cbUsers.DisplayMember = "Name";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Product product = new Product();
                product.User_id = Convert.ToInt32(cbUsers.SelectedValue);
                product.ProductName = tbProduct.Text;
                product.Quantity = Convert.ToInt32(tbQuantity.Text);
                product.Modified_at = DateTime.Now;

                var productRepo = new ProductRepository();
                bool result = productRepo.CreateProduct(product);
                string successMessage = "";
                string errorMessage = "";

                if (productId == 0)
                {
                    product.Created_at = DateTime.Now;
                    result = productRepo.CreateProduct(product);
                    successMessage = "Product has been created successfully. ";
                    errorMessage = "Failed to create product.";
                }
                else if(productId > 0)
                {
                    product.Id = productId;
                    result = productRepo.UpdateProduct(product);
                    successMessage = "Product has been updated successfully. ";
                    errorMessage = "Failed to update product.";
                }


                if (result)
                {
                    MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(errorMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        public void EditProduct(Product product)
        {
            btnSave.Text = "Update";
            lblCreateEditUser.Text = "Update";
            productId = product.Id;
            cbUsers.SelectedValue = product.User_id;
            tbProduct.Text = product.ProductName;
            tbQuantity.Text = product.Quantity.ToString();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(tbProduct.Text))
            {
                MessageBox.Show("Product is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbProduct.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(tbQuantity.Text))
            {
                MessageBox.Show("Quantity is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbQuantity.Focus();
                return false;
            }

            if (!tbQuantity.Text.All(char.IsDigit))
            {
                MessageBox.Show("Quantity must be a number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbQuantity.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(cbUsers.Text) || cbUsers.SelectedIndex < 0)
            {
                MessageBox.Show("Please select user.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbUsers.Focus();
                return false;
            }

            return true;
        }
    }
}
