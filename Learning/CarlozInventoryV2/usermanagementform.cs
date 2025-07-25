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
    public partial class usermanagementform : Form
    {
        public usermanagementform()
        {
            InitializeComponent();
            ReadUsers();
        }

        public void ReadUsers()
        {
            // Initialize Datatable and create columns
            // initialize userRepository
            // create list of users
            // loop through the users and add them to the datatable
            // bind the datatable to the datagridview

            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Status");
            dataTable.Columns.Add("Created_At");
            dataTable.Columns.Add("User_Level");

            var userRepository = new UserRepository();
            var users = userRepository.GetUsers();

            foreach (var user in users)
            {
                var row = dataTable.NewRow();
                row["Username"] = user.username;
                row["Email"] = user.email;
                row["Status"] = user.status == 1 ? "Active" : "Inactive";
                row["Created_At"] = user.createdAt;
                row["User_Level"] = user.userlevel_id;

                dataTable.Rows.Add(row);
            }

            this.usersGridView.DataSource = dataTable;

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            // create dialog for new user
            // update the datagridview with the new user

            Console.WriteLine("New User Button Clicked");

            CreateEditUser form = new CreateEditUser();
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                ReadUsers();
            }
        }
    }
}
