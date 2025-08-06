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
            loadform(new dashboardform());
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

            int userId = Session.UserId;

            var repo = new ThemeRepository();
            var theme = repo.GetTheme(userId);
            repo.ApplyThemeToControls(this.mainpanel.Controls, theme.SelectionTheme);

            f.Show();
        }
        private void btndashboard_Click(object sender, EventArgs e)
        {
            LogRepo.CreateLog("user view dashboard");
            loadform(new dashboardform());
        }

        private void btnproducts_Click(object sender, EventArgs e)
        {
            LogRepo.CreateLog("user view products");
            loadform(new productsform());
        }

        private void btnsupplier_Click(object sender, EventArgs e)
        {
            LogRepo.CreateLog("user view suppliers");
            loadform(new supplierform());
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            LogRepo.CreateLog("user view settings");
            loadform(new settingsform());
        }

        private void btnusermanagement_Click(object sender, EventArgs e)
        {
            LogRepo.CreateLog("user view users");
            loadform(new usermanagementform());
        }

        private void btnlogs_Click(object sender, EventArgs e)
        {
            LogRepo.CreateLog("user view logs");
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

            LogRepo.CreateLog("user logged out");

            MessageBox.Show("Logged out successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close(); // Close login when dashboard closes
            loginForm.Show();
        }
    }
}
