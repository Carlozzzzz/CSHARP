namespace Todo_List_Appppp
{
    partial class TodoV2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.todoLbl = new System.Windows.Forms.Label();
            this.completedTaskGridView = new System.Windows.Forms.DataGridView();
            this.currentTaskGridView = new System.Windows.Forms.DataGridView();
            this.currentTaskListLbl = new System.Windows.Forms.Label();
            this.completedTaskListLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taskLbl = new System.Windows.Forms.Label();
            this.taskTextBox = new System.Windows.Forms.TextBox();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.descLbl = new System.Windows.Forms.Label();
            this.newBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.markDoneBtn = new System.Windows.Forms.Button();
            this.markNotDoneBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.completedTaskGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTaskGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // todoLbl
            // 
            this.todoLbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.todoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.todoLbl.Location = new System.Drawing.Point(-1, -1);
            this.todoLbl.Name = "todoLbl";
            this.todoLbl.Size = new System.Drawing.Size(1153, 105);
            this.todoLbl.TabIndex = 0;
            this.todoLbl.Text = "Todo List V2";
            this.todoLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // completedTaskGridView
            // 
            this.completedTaskGridView.AllowUserToAddRows = false;
            this.completedTaskGridView.AllowUserToDeleteRows = false;
            this.completedTaskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.completedTaskGridView.Location = new System.Drawing.Point(766, 152);
            this.completedTaskGridView.Name = "completedTaskGridView";
            this.completedTaskGridView.ReadOnly = true;
            this.completedTaskGridView.Size = new System.Drawing.Size(381, 468);
            this.completedTaskGridView.TabIndex = 1;
            // 
            // currentTaskGridView
            // 
            this.currentTaskGridView.AllowUserToAddRows = false;
            this.currentTaskGridView.AllowUserToDeleteRows = false;
            this.currentTaskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentTaskGridView.Location = new System.Drawing.Point(371, 152);
            this.currentTaskGridView.Name = "currentTaskGridView";
            this.currentTaskGridView.ReadOnly = true;
            this.currentTaskGridView.Size = new System.Drawing.Size(381, 468);
            this.currentTaskGridView.TabIndex = 2;
            // 
            // currentTaskListLbl
            // 
            this.currentTaskListLbl.AutoSize = true;
            this.currentTaskListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTaskListLbl.Location = new System.Drawing.Point(367, 129);
            this.currentTaskListLbl.Name = "currentTaskListLbl";
            this.currentTaskListLbl.Size = new System.Drawing.Size(151, 20);
            this.currentTaskListLbl.TabIndex = 5;
            this.currentTaskListLbl.Text = "Current Task List:";
            // 
            // completedTaskListLbl
            // 
            this.completedTaskListLbl.AutoSize = true;
            this.completedTaskListLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedTaskListLbl.Location = new System.Drawing.Point(786, 129);
            this.completedTaskListLbl.Name = "completedTaskListLbl";
            this.completedTaskListLbl.Size = new System.Drawing.Size(177, 20);
            this.completedTaskListLbl.TabIndex = 6;
            this.completedTaskListLbl.Text = "Completed Task List:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Manage Section:";
            // 
            // taskLbl
            // 
            this.taskLbl.AutoSize = true;
            this.taskLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskLbl.Location = new System.Drawing.Point(15, 177);
            this.taskLbl.Name = "taskLbl";
            this.taskLbl.Size = new System.Drawing.Size(36, 15);
            this.taskLbl.TabIndex = 9;
            this.taskLbl.Text = "Task:";
            // 
            // taskTextBox
            // 
            this.taskTextBox.Location = new System.Drawing.Point(18, 195);
            this.taskTextBox.Name = "taskTextBox";
            this.taskTextBox.Size = new System.Drawing.Size(338, 20);
            this.taskTextBox.TabIndex = 10;
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(18, 254);
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(338, 20);
            this.descTextBox.TabIndex = 12;
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLbl.Location = new System.Drawing.Point(15, 236);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(72, 15);
            this.descLbl.TabIndex = 11;
            this.descLbl.Text = "Description:";
            // 
            // newBtn
            // 
            this.newBtn.BackColor = System.Drawing.Color.Blue;
            this.newBtn.ForeColor = System.Drawing.Color.White;
            this.newBtn.Location = new System.Drawing.Point(18, 290);
            this.newBtn.Name = "newBtn";
            this.newBtn.Size = new System.Drawing.Size(111, 35);
            this.newBtn.TabIndex = 13;
            this.newBtn.Text = "New";
            this.newBtn.UseVisualStyleBackColor = false;
            this.newBtn.Click += new System.EventHandler(this.newBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(245, 290);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(111, 35);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.Location = new System.Drawing.Point(564, 621);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(188, 35);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(131, 290);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(111, 35);
            this.editBtn.TabIndex = 15;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // markDoneBtn
            // 
            this.markDoneBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.markDoneBtn.ForeColor = System.Drawing.Color.White;
            this.markDoneBtn.Location = new System.Drawing.Point(368, 621);
            this.markDoneBtn.Name = "markDoneBtn";
            this.markDoneBtn.Size = new System.Drawing.Size(192, 35);
            this.markDoneBtn.TabIndex = 17;
            this.markDoneBtn.Text = "Mark as Done";
            this.markDoneBtn.UseVisualStyleBackColor = false;
            this.markDoneBtn.Click += new System.EventHandler(this.markDoneBtn_Click);
            // 
            // markNotDoneBtn
            // 
            this.markNotDoneBtn.BackColor = System.Drawing.Color.SandyBrown;
            this.markNotDoneBtn.ForeColor = System.Drawing.Color.White;
            this.markNotDoneBtn.Location = new System.Drawing.Point(856, 621);
            this.markNotDoneBtn.Name = "markNotDoneBtn";
            this.markNotDoneBtn.Size = new System.Drawing.Size(202, 35);
            this.markNotDoneBtn.TabIndex = 18;
            this.markNotDoneBtn.Text = "Mark Not Done";
            this.markNotDoneBtn.UseVisualStyleBackColor = false;
            this.markNotDoneBtn.Click += new System.EventHandler(this.markNotDoneBtn_Click);
            // 
            // TodoV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 662);
            this.Controls.Add(this.markNotDoneBtn);
            this.Controls.Add(this.markDoneBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.newBtn);
            this.Controls.Add(this.descTextBox);
            this.Controls.Add(this.descLbl);
            this.Controls.Add(this.taskTextBox);
            this.Controls.Add(this.taskLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.completedTaskListLbl);
            this.Controls.Add(this.currentTaskListLbl);
            this.Controls.Add(this.currentTaskGridView);
            this.Controls.Add(this.completedTaskGridView);
            this.Controls.Add(this.todoLbl);
            this.Name = "TodoV2";
            this.Text = "TodoV2";
            this.Load += new System.EventHandler(this.TodoV2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.completedTaskGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentTaskGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label todoLbl;
        private System.Windows.Forms.DataGridView completedTaskGridView;
        private System.Windows.Forms.DataGridView currentTaskGridView;
        private System.Windows.Forms.Label currentTaskListLbl;
        private System.Windows.Forms.Label completedTaskListLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label taskLbl;
        private System.Windows.Forms.TextBox taskTextBox;
        private System.Windows.Forms.TextBox descTextBox;
        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Button newBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button markDoneBtn;
        private System.Windows.Forms.Button markNotDoneBtn;
    }
}