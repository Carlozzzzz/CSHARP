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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        private void btndashboard_Click(object sender, EventArgs e)
        {
            loadform(new dashboardform());
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            loadform(new productsform());
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            loadform(new supplierform());
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            loadform(new settingsform());
        }

        private void btnusermanagement_Click(object sender, EventArgs e)
        {
            loadform(new usermanagementform());
        }

        private void btnlogs_Click(object sender, EventArgs e)
        {
            loadform(new logsform());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginRepo = new LoginRepository();
            loginRepo.LogoutUser();

            MessageBox.Show("Logged out successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close(); // Close login when dashboard closes
            loginForm.Show();
        }
    }
}
