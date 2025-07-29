namespace CarlozInventoryV2
{
    partial class logsform
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
            this.panelHeaderLog = new System.Windows.Forms.Panel();
            this.btnRefreshLog = new System.Windows.Forms.Button();
            this.dtpCreatedAtLog = new System.Windows.Forms.DateTimePicker();
            this.cbStatusLog = new System.Windows.Forms.ComboBox();
            this.cbRolesLog = new System.Windows.Forms.ComboBox();
            this.tbSearchLog = new System.Windows.Forms.TextBox();
            this.logGridView = new System.Windows.Forms.DataGridView();
            this.panelHeaderLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderLog
            // 
            this.panelHeaderLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelHeaderLog.Controls.Add(this.btnRefreshLog);
            this.panelHeaderLog.Controls.Add(this.dtpCreatedAtLog);
            this.panelHeaderLog.Controls.Add(this.cbStatusLog);
            this.panelHeaderLog.Controls.Add(this.cbRolesLog);
            this.panelHeaderLog.Controls.Add(this.tbSearchLog);
            this.panelHeaderLog.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderLog.Location = new System.Drawing.Point(0, 0);
            this.panelHeaderLog.Name = "panelHeaderLog";
            this.panelHeaderLog.Size = new System.Drawing.Size(800, 47);
            this.panelHeaderLog.TabIndex = 1;
            // 
            // btnRefreshLog
            // 
            this.btnRefreshLog.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRefreshLog.FlatAppearance.BorderSize = 0;
            this.btnRefreshLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshLog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefreshLog.Location = new System.Drawing.Point(711, 8);
            this.btnRefreshLog.Name = "btnRefreshLog";
            this.btnRefreshLog.Size = new System.Drawing.Size(77, 33);
            this.btnRefreshLog.TabIndex = 4;
            this.btnRefreshLog.Text = "Refresh";
            this.btnRefreshLog.UseVisualStyleBackColor = false;
            // 
            // dtpCreatedAtLog
            // 
            this.dtpCreatedAtLog.Location = new System.Drawing.Point(374, 12);
            this.dtpCreatedAtLog.Name = "dtpCreatedAtLog";
            this.dtpCreatedAtLog.Size = new System.Drawing.Size(194, 20);
            this.dtpCreatedAtLog.TabIndex = 3;
            // 
            // cbStatusLog
            // 
            this.cbStatusLog.FormattingEnabled = true;
            this.cbStatusLog.Location = new System.Drawing.Point(300, 11);
            this.cbStatusLog.Name = "cbStatusLog";
            this.cbStatusLog.Size = new System.Drawing.Size(68, 21);
            this.cbStatusLog.TabIndex = 2;
            this.cbStatusLog.Text = "Status";
            // 
            // cbRolesLog
            // 
            this.cbRolesLog.FormattingEnabled = true;
            this.cbRolesLog.Location = new System.Drawing.Point(220, 11);
            this.cbRolesLog.Name = "cbRolesLog";
            this.cbRolesLog.Size = new System.Drawing.Size(74, 21);
            this.cbRolesLog.TabIndex = 1;
            this.cbRolesLog.Text = "Role";
            // 
            // tbSearchLog
            // 
            this.tbSearchLog.Location = new System.Drawing.Point(13, 12);
            this.tbSearchLog.Name = "tbSearchLog";
            this.tbSearchLog.Size = new System.Drawing.Size(178, 20);
            this.tbSearchLog.TabIndex = 0;
            this.tbSearchLog.Text = "Search...";
            // 
            // logGridView
            // 
            this.logGridView.AllowUserToAddRows = false;
            this.logGridView.AllowUserToDeleteRows = false;
            this.logGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.logGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logGridView.Location = new System.Drawing.Point(13, 61);
            this.logGridView.Name = "logGridView";
            this.logGridView.ReadOnly = true;
            this.logGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logGridView.ShowEditingIcon = false;
            this.logGridView.Size = new System.Drawing.Size(774, 370);
            this.logGridView.TabIndex = 2;
            // 
            // logsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logGridView);
            this.Controls.Add(this.panelHeaderLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "logsform";
            this.Text = "logsform";
            this.panelHeaderLog.ResumeLayout(false);
            this.panelHeaderLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeaderLog;
        private System.Windows.Forms.Button btnRefreshLog;
        private System.Windows.Forms.DateTimePicker dtpCreatedAtLog;
        private System.Windows.Forms.ComboBox cbStatusLog;
        private System.Windows.Forms.ComboBox cbRolesLog;
        private System.Windows.Forms.TextBox tbSearchLog;
        private System.Windows.Forms.DataGridView logGridView;
    }
}