namespace CarlozInventoryV2
{
    partial class usermanagementform
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtpCreatedAt = new System.Windows.Forms.DateTimePicker();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelBody.Controls.Add(this.usersGridView);
            this.panelBody.Location = new System.Drawing.Point(12, 12);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(776, 546);
            this.panelBody.TabIndex = 0;
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGridView.Location = new System.Drawing.Point(13, 57);
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.RowHeadersVisible = false;
            this.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersGridView.Size = new System.Drawing.Size(750, 477);
            this.usersGridView.TabIndex = 0;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelHeader.Controls.Add(this.btnRefresh);
            this.panelHeader.Controls.Add(this.btnNewUser);
            this.panelHeader.Controls.Add(this.dtpCreatedAt);
            this.panelHeader.Controls.Add(this.cbStatus);
            this.panelHeader.Controls.Add(this.cbRoles);
            this.panelHeader.Controls.Add(this.tbSearch);
            this.panelHeader.Location = new System.Drawing.Point(12, 12);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(776, 47);
            this.panelHeader.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(13, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(178, 20);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Search...";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.Leave += new System.EventHandler(this.tbSearch_Leave);
            // 
            // cbRoles
            // 
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(220, 11);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(74, 21);
            this.cbRoles.TabIndex = 1;
            this.cbRoles.Text = "--Roles--";
            this.cbRoles.SelectedIndexChanged += new System.EventHandler(this.cbRoles_SelectedIndexChanged);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbStatus.Location = new System.Drawing.Point(300, 11);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(68, 21);
            this.cbStatus.TabIndex = 2;
            this.cbStatus.Text = "--Status--";
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // dtpCreatedAt
            // 
            this.dtpCreatedAt.Location = new System.Drawing.Point(374, 12);
            this.dtpCreatedAt.Name = "dtpCreatedAt";
            this.dtpCreatedAt.Size = new System.Drawing.Size(194, 20);
            this.dtpCreatedAt.TabIndex = 3;
            this.dtpCreatedAt.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpCreatedAt.ValueChanged += new System.EventHandler(this.dtpCreatedAt_ValueChanged);
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewUser.Location = new System.Drawing.Point(687, 5);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(77, 33);
            this.btnNewUser.TabIndex = 0;
            this.btnNewUser.Text = "New";
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefresh.Location = new System.Drawing.Point(604, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 33);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelHeader);
            this.panel1.Controls.Add(this.panelBody);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 570);
            this.panel1.TabIndex = 0;
            // 
            // usermanagementform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usermanagementform";
            this.Text = "usermanagementform";
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.DateTimePicker dtpCreatedAt;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panel1;
    }
}