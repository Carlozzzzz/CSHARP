using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_List_Appppp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create columns
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            // Point our datagrid view to the source
            todoListView.DataSource = todoList;

        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleBox.Text = "";
            descBox.Text = "";
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // Fille text field with data from table
            titleBox.Text = todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descBox.Text = todoList.Rows[todoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[todoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[todoListView.CurrentCell.RowIndex]["Title"] = titleBox.Text;
                todoList.Rows[todoListView.CurrentCell.RowIndex]["Description"] = descBox.Text;
            }
            else
            {
                todoList.Rows.Add(titleBox.Text, descBox.Text);
            }

            // Clear fields
            titleBox.Text = "";
            descBox.Text = "";

        }
    }
}
