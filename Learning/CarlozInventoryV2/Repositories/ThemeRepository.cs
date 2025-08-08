using CarlozInventoryV2.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarlozInventoryV2.Repositories
{
    public class ThemeRepository
    {
        // create theme
        // update theme

        public Theme GetTheme(int userId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "SELECT * FROM ThemesTbl WHERE user_id = @Id";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Id", userId);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Theme theme = new Theme();
                                theme.Id = reader.GetInt32(0);
                                theme.UserId = reader.GetInt32(1);
                                theme.SelectionTheme = (Themes)reader.GetInt32(2);

                                return theme;
                            }
                        }
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting theme: " + ex.Message);
            }

            return null;
        }
        public void CreateTheme(Theme theme)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = 
                        "INSERT INTO ThemesTbl (user_id, theme) " +
                        "VALUES (@UserId, @SelectionTheme)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", theme.UserId);
                        command.Parameters.AddWithValue("@SelectionTheme", theme.SelectionTheme);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed creating theme: " + ex.Message);
            }
        }

        public void UpdateTheme(Theme theme)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Database.GetConnectionString()))
                {
                    connection.Open();
                    string query = "UPDATE ThemesTbl " +
                        "SET theme = @SelectionTheme " +
                        "WHERE user_id = @UserId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SelectionTheme", theme.SelectionTheme);
                        command.Parameters.AddWithValue("@UserId", theme.UserId);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to update theme: " + ex.Message);
            }
        }

        public void ApplyThemeToControls(Control.ControlCollection controls, Themes theme)
        {
            foreach (Control ctrl in controls)
            {
                if (ctrl is DataGridView grid)
                {
                    grid.BackgroundColor = ThemeColors.GetPanelBodyColor(theme);
                    grid.DefaultCellStyle.BackColor = ThemeColors.GetPanelBodyColor(theme);
                    grid.DefaultCellStyle.ForeColor = ThemeColors.GetForeColor(theme, grid.DefaultCellStyle.BackColor);
                    grid.ColumnHeadersDefaultCellStyle.BackColor = ThemeColors.GetPanelHeaderColor(theme);
                    grid.ColumnHeadersDefaultCellStyle.ForeColor = ThemeColors.GetForeColor(theme, grid.ColumnHeadersDefaultCellStyle.BackColor);
                }
                else if (ctrl is Panel)
                {
                    if (ctrl.Name.IndexOf("Header", StringComparison.OrdinalIgnoreCase) >= 0 && ctrl.Name.IndexOf("Mode", StringComparison.OrdinalIgnoreCase) < 0)
                    {
                        ctrl.BackColor = ThemeColors.GetPanelHeaderColor(theme);
                        Console.WriteLine("Header Detected");

                    }
                    else if (ctrl.Name.IndexOf("Body", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        ctrl.BackColor = ThemeColors.GetPanelBodyColor(theme);
                        Console.WriteLine("Body Detected : " + ctrl.Name);
                    }
                    ctrl.ForeColor = ThemeColors.GetForeColor(theme, ctrl.BackColor);
                    Console.WriteLine("Inside Panel : " + ctrl.Name);
                } 
                //else if (ctrl is Button)
                //{
                //    ctrl.BackColor = ThemeColors.GetButtonBackColor(theme);
                //    ctrl.ForeColor = ThemeColors.GetForeColor(theme, ctrl.BackColor);
                //}
                //else
                //{
                //    // For other controls, you can set only the font color if you wish
                //    ctrl.ForeColor = ThemeColors.GetForeColor(theme, this.BackColor);
                //}

                //// Recursively apply to child controls
                if (ctrl.HasChildren)
                    ApplyThemeToControls(ctrl.Controls, theme);
            }
        }
    }
}
