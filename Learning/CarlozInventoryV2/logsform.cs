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
    public partial class logsform : Form
    {

        private Timer debounceTimer;
        private bool isInitializing;
        bool isRoleSelected = false;
        bool isDateSelected = false;
        public logsform()
        {
            isInitializing = true;
            InitializeComponent();
            ReadLogs();
            PopulateRoles();

            debounceTimer = new Timer();
            debounceTimer.Interval = 500;
            debounceTimer.Tick += DebounceTimer_Tick;
            tbSearchLog.TextChanged += tbSearchLog_TextChanged;
            isInitializing = false;
        }

        public void ReadLogs()
        {
            var repo = new LogRepository();
            var logs = repo.GetLogs();

            DataTable dataTable = DisplayList(logs);

            this.logGridView.DataSource = dataTable;

            logGridView.DataSource = dataTable;
            logGridView.Columns["ID"].Visible = false;
        }

        private void PopulateRoles()
        {
            var repo = new UserLevelRepository();
            var roles = repo.GetUserLevels();

            cbRoles.Items.Clear();

            var comboItems = new List<ComboItem>();

            comboItems.Add(new ComboItem() { ID = 0, Name = "--Roles--" });

            foreach (var role in roles)
            {
                comboItems.Add(new ComboItem() { ID = role.id, Name = role.level });
            }

            cbRoles.DataSource = comboItems;
            cbRoles.ValueMember = "ID";
            cbRoles.DisplayMember = "Name";
        }

        private void btnRefreshLog_Click(object sender, EventArgs e)
        {
            RefreshLogs();
        }

        private void tbSearchLog_TextChanged(object sender, EventArgs e)
        {
            debounceTimer.Stop();
            debounceTimer.Start();
        }

        private void tbSearchLog_Click(object sender, EventArgs e)
        {
            if (tbSearchLog.Text.ToLower().Trim() == "search...") tbSearchLog.Text = "";
        }
        private void tbSearchLog_Leave(object sender, EventArgs e)
        {
            if (tbSearchLog.Text.ToLower().Trim() == "") tbSearchLog.Text = "Search...";
        }

        private void cbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;

            if (cbRoles.SelectedIndex == 0) isRoleSelected = false;
            else isRoleSelected = true;

            FilterTable();
        }

        private void dtpCreatedAtLog_ValueChanged(object sender, EventArgs e)
        {
            if (isInitializing) return;

            isDateSelected = true;

            FilterTable();
        }

        public void DebounceTimer_Tick(object sender, EventArgs e)
        {
            if (isInitializing) return;

            debounceTimer.Stop();

            FilterTable();
        }

        public void FilterTable()
        {
            string searchText = tbSearchLog.Text.Trim().ToLower();
            if (tbSearchLog.Text.ToLower().Trim() == "search...") searchText = "";

            var repo = new LogRepository();
            var logs = repo.GetLogs();
            int userLevelId = 0;

            if (cbRoles.SelectedValue is int)
                userLevelId = (int)cbRoles.SelectedValue;
            else if (cbRoles.SelectedItem is ComboItem item)
                userLevelId = item.ID;

            DateTime selectedDate = dtpCreatedAtLog.Value.Date;


            var filtered = logs.Where(l =>
                    l.Username.ToLower().Contains(searchText) ||
                    l.Level.ToLower().Contains(searchText) ||
                    l.Action.ToLower().Contains(searchText)
                );

            if (isRoleSelected)
                filtered = filtered.Where(p => p.UserLevelId == userLevelId);

            if (isDateSelected)
                filtered = filtered.Where(p => Convert.ToDateTime(p.ModificationTime) >= selectedDate);

            logs = filtered.ToList();

            DataTable dataTable = DisplayList(logs);

            logGridView.DataSource = dataTable;
            logGridView.Columns["ID"].Visible = false;
        }

        public DataTable DisplayList(List<Log> logs)
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("USERNAME");
            dataTable.Columns.Add("LEVEL");
            dataTable.Columns.Add("ACTION");
            dataTable.Columns.Add("MODIFICATION TIME");

            foreach (var log in logs)
            {
                DataRow row = dataTable.NewRow();
                row["ID"] = log.Id;
                row["USERNAME"] = log.Username;
                row["LEVEL"] = log.Level;
                row["ACTION"] = log.Action;
                row["MODIFICATION TIME"] = log.ModificationTime.ToString("yyyy-MM-dd HH:mm:ss");
                dataTable.Rows.Add(row);
            }
            return dataTable;
        }

        public void RefreshLogs()
        {
            tbSearchLog.Text = "Search...";
            cbRoles.Text = "--Roles--";
            dtpCreatedAtLog.Value = new DateTime(1900, 1, 1);
            isDateSelected = false;
            isRoleSelected = false;
            cbRoles.SelectedIndex = 0;
            ReadLogs();
        }

    }
}
