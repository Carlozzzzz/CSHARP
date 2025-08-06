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

        Themes selectedTheme = Themes.None;
        public supplierform()
        {
            InitializeComponent();
            AttachClickEvent(panelLightMode, panelLightMode_Click);
            AttachClickEvent(panelDarkMode, panelDarkMode_Click);
            AttachClickEvent(panelClassicMode, panelClassicMode_Click);
            SetTheme();
        }

        public void SetTheme()
        {
            int userId = Session.UserId;

            var repo = new ThemeRepository();
            var theme = repo.GetTheme(userId);
            ApplyTheme(theme.SelectionTheme);
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

            var repo = new ThemeRepository();
            var theme = repo.GetTheme(userId);

            Theme currTheme = new Theme();
            currTheme.UserId = userId;
            currTheme.SelectionTheme = selectedTheme;

            if(selectedTheme == Themes.None)
            {
                MessageBox.Show("Please select a theme.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            ApplyTheme(selectedTheme);


            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ApplyTheme(Themes theme)
        {
            // Apply to the form itself
            panelHeader.BackColor = ThemeColors.GetPanelHeaderColor(theme);
            panelThemeBody.BackColor = ThemeColors.GetPanelBodyCOlor(theme);
            this.ForeColor = ThemeColors.GetForeColor(theme, this.BackColor);

            // Recursively apply to all controls
            //ApplyThemeToControls(this.Controls, theme);
        }

        private void ApplyThemeToControls(Control.ControlCollection controls, Themes theme)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is Panel)
                {
                    if (ctrl.Name.IndexOf("Header", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        ctrl.BackColor = ThemeColors.GetPanelHeaderColor(theme);
                    }
                    else if (ctrl.Name.IndexOf("Body", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        ctrl.BackColor = ThemeColors.GetPanelBodyCOlor(theme);
                    }
                    ctrl.ForeColor = ThemeColors.GetForeColor(theme, ctrl.BackColor);
                }
                else if (ctrl is Button)
                {
                    ctrl.BackColor = ThemeColors.GetButtonBackColor(theme);
                    ctrl.ForeColor = ThemeColors.GetForeColor(theme, ctrl.BackColor);
                }
                else
                {
                    // For other controls, you can set only the font color if you wish
                    ctrl.ForeColor = ThemeColors.GetForeColor(theme, this.BackColor);
                }

                // Recursively apply to child controls
                if (ctrl.HasChildren)
                    ApplyThemeToControls(ctrl.Controls, theme);
            }
        }
    }
}
