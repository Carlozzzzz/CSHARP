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
    public partial class dashboardform : Form
    {
        public dashboardform()
        {
            InitializeComponent();
            PopulateCounts();

            lblAdmin.Text += $" {Session.Username}";
        }

        private void PopulateCounts()
        {
            var productsRepo = new ProductRepository();
            var productsCount = productsRepo.GetProducts().Count;
            lblProductsCount.Text = productsCount.ToString();

            var usersRepo = new UserRepository();
            var usersCount = usersRepo.GetUsers().Count;
            lblUsersCount.Text = usersCount.ToString();

            var supplierRepo = new SupplierRepository();
            var suppliersCount = supplierRepo.GetSuppliers().Count;
            lblSupplierCount.Text= suppliersCount.ToString();
        }
    }
}
