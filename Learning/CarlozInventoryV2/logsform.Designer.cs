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
            this.cbRoles = new System.Windows.Forms.ComboBox();
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
            this.panelHeaderLog.Controls.Add(this.cbRoles);
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
            this.btnRefreshLog.Click += new System.EventHandler(this.btnRefreshLog_Click);
            // 
            // dtpCreatedAtLog
            // 
            this.dtpCreatedAtLog.Location = new System.Drawing.Point(300, 12);
            this.dtpCreatedAtLog.Name = "dtpCreatedAtLog";
            this.dtpCreatedAtLog.Size = new System.Drawing.Size(194, 20);
            this.dtpCreatedAtLog.TabIndex = 3;
            this.dtpCreatedAtLog.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpCreatedAtLog.ValueChanged += new System.EventHandler(this.dtpCreatedAtLog_ValueChanged);
            // 
            // cbRoles
            // 
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(220, 11);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(74, 21);
            this.cbRoles.TabIndex = 1;
            this.cbRoles.Text = "Role";
            this.cbRoles.SelectedIndexChanged += new System.EventHandler(this.cbRoles_SelectedIndexChanged);
            // 
            // tbSearchLog
            // 
            this.tbSearchLog.Location = new System.Drawing.Point(13, 12);
            this.tbSearchLog.Name = "tbSearchLog";
            this.tbSearchLog.Size = new System.Drawing.Size(178, 20);
            this.tbSearchLog.TabIndex = 0;
            this.tbSearchLog.Text = "Search...";
            this.tbSearchLog.Click += new System.EventHandler(this.tbSearchLog_Click);
            this.tbSearchLog.TextChanged += new System.EventHandler(this.tbSearchLog_TextChanged);
            this.tbSearchLog.Leave += new System.EventHandler(this.tbSearchLog_Leave);
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
            this.logGridView.Size = new System.Drawing.Size(774, 497);
            this.logGridView.TabIndex = 2;
            // 
            // logsform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
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
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.TextBox tbSearchLog;
        private System.Windows.Forms.DataGridView logGridView;
    }
}