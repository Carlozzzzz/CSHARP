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
    public partial class TodoV2 : Form
    {
        public TodoV2()
        {
            InitializeComponent();
        }
        
        DataTable currentTodoList = new DataTable();
        DataTable completedTodoList = new DataTable();

        // todo List storage
        List<TodoItem> todoList = new List<TodoItem>();

        bool isEditing = false;
        private void TodoV2_Load(object sender, EventArgs e)
        {
            // Create columns for currentTodoList
            currentTodoList.Columns.Add("ID", typeof(int));
            currentTodoList.Columns.Add("Title");
            currentTodoList.Columns.Add("Description");
            currentTodoList.Columns.Add("Date");

            currentTaskGridView.DataSource = currentTodoList;
            currentTaskGridView.Columns["ID"].Visible = false; // Hide ID column    

            // Create columns for completedTodoList
            completedTodoList.Columns.Add("ID", typeof(int));
            completedTodoList.Columns.Add("Title");
            completedTodoList.Columns.Add("Description");
            completedTodoList.Columns.Add("Date");

            completedTaskGridView.DataSource = completedTodoList;
            completedTaskGridView.Columns["ID"].Visible = false; // Hide ID column    

        }

        private void clearFields()
        {
            taskTextBox.Text = "";
            descTextBox.Text = "";
            isEditing = false;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool isCompleted = false;
            TodoItem todoItem = new TodoItem(taskTextBox.Text, descTextBox.Text, isCompleted);

            if (isEditing)
            {
                // add code when editing
                currentTodoList.Rows[currentTaskGridView.CurrentCell.RowIndex]["Title"] = todoItem.Title;
                currentTodoList.Rows[currentTaskGridView.CurrentCell.RowIndex]["Description"] = todoItem.Description;
                currentTodoList.Rows[currentTaskGridView.CurrentCell.RowIndex]["Date"] = todoItem.CreatedAt;

                int currentId = (int)currentTodoList.Rows[currentTaskGridView.CurrentCell.RowIndex]["ID"];

                // TodoList array update
                foreach (TodoItem item in todoList)
                {
                    if (item.Id == currentId)
                    {
                        item.Title = todoItem.Title;
                        item.Description = todoItem.Description;
                        item.CreatedAt = todoItem.CreatedAt;
                        break;
                    }
                }

            }
            else
            {
                int taskId = todoList.Count + 1;

                todoItem.Id = taskId;

                todoList.Add(todoItem);

                currentTodoList.Rows.Add(todoItem.Id, todoItem.Title, todoItem.Description, todoItem.CreatedAt);
            }

            clearFields();

            printItems();

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // Fill text fields with data from table
            taskTextBox.Text = currentTodoList.Rows[currentTaskGridView.CurrentCell.RowIndex]["Title"].ToString();
            descTextBox.Text = currentTodoList.Rows[currentTaskGridView.CurrentCell.RowIndex]["Description"].ToString();
        }

       

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                currentTodoList.Rows[currentTaskGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void markDoneBtn_Click(object sender, EventArgs e)
        {

            completedTodoList.Rows.Add(
                currentTodoList.Rows[currentTaskGridView.CurrentCell.RowIndex]["ID"],
                currentTodoList.Rows[currentTaskGridView.CurrentCell.RowIndex]["Title"],
                currentTodoList.Rows[currentTaskGridView.CurrentCell.RowIndex]["Description"],
                DateTime.Now.ToString("MM/dd/yyyy hh:mm:tt")
                );

            int currentId = (int)currentTodoList.Rows[currentTaskGridView.CurrentCell.RowIndex]["ID"];

            // TodoList array update
            foreach (TodoItem item in todoList)
            {
                if (item.Id == currentId)
                {
                    item.IsCompleted = true;
                    break;
                }
            }

            currentTodoList.Rows[currentTaskGridView.CurrentCell.RowIndex].Delete();

            Console.WriteLine("===========");
            printItems();
        }

        private void markNotDoneBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string prevDate = "";
                int currentId = (int)completedTodoList.Rows[completedTaskGridView.CurrentCell.RowIndex]["ID"];
                foreach (TodoItem item in todoList)
                {
                    if (item.Id == currentId)
                    {
                        item.IsCompleted = false;
                        prevDate = item.CreatedAt.ToString("MM/dd/yyyy hh:mm");
                        break;
                    }
                }


                Console.WriteLine("Current ID: " + currentId);

                // Reisert the item back to the currentTodoList
                DataRow newRow = currentTodoList.NewRow();
                newRow["ID"] = currentId;
                newRow["Title"] = completedTodoList.Rows[completedTaskGridView.CurrentCell.RowIndex]["Title"];
                newRow["Description"] = completedTodoList.Rows[completedTaskGridView.CurrentCell.RowIndex]["Description"];
                newRow["Date"] = prevDate;

                currentTodoList.Rows.InsertAt(newRow, currentId - 1);

                // remove the undone item
                completedTodoList.Rows[completedTaskGridView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mali gar: " + ex);
            }

        }

        void printItems()
        {
            TodoItem[] items = todoList.ToArray();

            foreach (TodoItem item in items)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}
