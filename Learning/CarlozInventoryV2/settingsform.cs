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
    public partial class settingsform : Form
    {

        Themes selectedTheme = Themes.None;
        public settingsform()
        {
            InitializeComponent();
            AttachClickEvent(panelLightMode, panelLightMode_Click);
            AttachClickEvent(panelDarkMode, panelDarkMode_Click);
            AttachClickEvent(panelClassicMode, panelClassicMode_Click);
        }

        // Recursively attach the click event to the panel and all its children
        private void AttachClickEvent(Control parent, EventHandler handler)
        {
            parent.Click += handler;
            foreach (Control child in parent.Controls)
            {
                AttachClickEvent(child, handler);
            }
        }

        private void panelLightMode_Click(object sender, EventArgs e)
        {
            // check if the theme exists
            // create | update theme
            ckbLightMode.Checked = true;
            ckbDarkMode.Checked = false;
            ckbClassicMode.Checked = false;

            selectedTheme = Themes.LightMode;

        }

        private void panelDarkMode_Click(object sender, EventArgs e)
        {
            ckbLightMode.Checked = false;
            ckbDarkMode.Checked = true;
            ckbClassicMode.Checked = false;

            selectedTheme = Themes.DarkMode;

        }

        private void panelClassicMode_Click(object sender, EventArgs e)
        {
            ckbLightMode.Checked = false;
            ckbDarkMode.Checked = false;
            ckbClassicMode.Checked = true;

            selectedTheme = Themes.ClassicMode;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string message = "";
            int userId = Session.UserId;

            Theme currTheme = new Theme();
            currTheme.UserId = userId;
            currTheme.SelectionTheme = selectedTheme;

            if(selectedTheme == Themes.None)
            {
                MessageBox.Show("Please select a theme.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var repo = new ThemeRepository();
            var theme = repo.GetTheme(userId);
            if (theme != null)
            {
                repo.UpdateTheme(currTheme);
                message = "Theme succesfully updated.";
            }
            else
            {
                repo.CreateTheme(currTheme);
                message = "Theme succesfully created.";
            }

            repo.ApplyThemeToControls(this.Controls, currTheme.SelectionTheme);

            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
