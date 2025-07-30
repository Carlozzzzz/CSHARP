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
        public logsform()
        {
            InitializeComponent();
            ReadLogs();
        }

        public void ReadLogs()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("USERNAME");
            dataTable.Columns.Add("LEVEL");
            dataTable.Columns.Add("ACTION");
            dataTable.Columns.Add("MODIFICATION TIME");

            var repo = new LogRepository();
            var logs = repo.GetLogs(); // create this

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

            this.logGridView.DataSource = dataTable;
        }
    }
}
