namespace CRUDV1
{
    partial class Form1
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tcDataDisplay = new System.Windows.Forms.TabControl();
            this.tpUsers = new System.Windows.Forms.TabPage();
            this.userGridView = new System.Windows.Forms.DataGridView();
            this.tpProducts = new System.Windows.Forms.TabPage();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.tcDataDisplay.SuspendLayout();
            this.tpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).BeginInit();
            this.tpProducts.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(830, 44);
            this.panelHeader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(123, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.tcDataDisplay);
            this.panelBody.Controls.Add(this.panelMenu);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 44);
            this.panelBody.Name = "panelBody";
            this.panelBody.Padding = new System.Windows.Forms.Padding(10);
            this.panelBody.Size = new System.Drawing.Size(830, 486);
            this.panelBody.TabIndex = 1;
            // 
            // tcDataDisplay
            // 
            this.tcDataDisplay.Controls.Add(this.tpUsers);
            this.tcDataDisplay.Controls.Add(this.tpProducts);
            this.tcDataDisplay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tcDataDisplay.Location = new System.Drawing.Point(10, 64);
            this.tcDataDisplay.Name = "tcDataDisplay";
            this.tcDataDisplay.SelectedIndex = 0;
            this.tcDataDisplay.Size = new System.Drawing.Size(810, 412);
            this.tcDataDisplay.TabIndex = 2;
            // 
            // tpUsers
            // 
            this.tpUsers.Controls.Add(this.userGridView);
            this.tpUsers.Location = new System.Drawing.Point(4, 22);
            this.tpUsers.Name = "tpUsers";
            this.tpUsers.Padding = new System.Windows.Forms.Padding(10);
            this.tpUsers.Size = new System.Drawing.Size(802, 386);
            this.tpUsers.TabIndex = 0;
            this.tpUsers.Text = "Users";
            this.tpUsers.UseVisualStyleBackColor = true;
            // 
            // userGridView
            // 
            this.userGridView.AllowUserToAddRows = false;
            this.userGridView.AllowUserToDeleteRows = false;
            this.userGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGridView.Location = new System.Drawing.Point(13, 13);
            this.userGridView.Name = "userGridView";
            this.userGridView.ReadOnly = true;
            this.userGridView.RowHeadersVisible = false;
            this.userGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userGridView.Size = new System.Drawing.Size(776, 360);
            this.userGridView.TabIndex = 0;
            this.userGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGridView_CellContentClick);
            // 
            // tpProducts
            // 
            this.tpProducts.Controls.Add(this.productGridView);
            this.tpProducts.Location = new System.Drawing.Point(4, 22);
            this.tpProducts.Name = "tpProducts";
            this.tpProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tpProducts.Size = new System.Drawing.Size(802, 386);
            this.tpProducts.TabIndex = 1;
            this.tpProducts.Text = "Products";
            this.tpProducts.UseVisualStyleBackColor = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelMenu.Controls.Add(this.lblSearch);
            this.panelMenu.Controls.Add(this.tbSearch);
            this.panelMenu.Controls.Add(this.btnNew);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(10, 10);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(810, 48);
            this.panelMenu.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(14, 16);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(69, 17);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search :";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(89, 16);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(160, 20);
            this.tbSearch.TabIndex = 1;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNew.Location = new System.Drawing.Point(742, 0);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(68, 48);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(13, 13);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.RowHeadersVisible = false;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(776, 360);
            this.productGridView.TabIndex = 1;
            this.productGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 530);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD Practice V1";
            this.panelHeader.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.tcDataDisplay.ResumeLayout(false);
            this.tpUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userGridView)).EndInit();
            this.tpProducts.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TabControl tcDataDisplay;
        private System.Windows.Forms.TabPage tpUsers;
        private System.Windows.Forms.TabPage tpProducts;
        private System.Windows.Forms.DataGridView userGridView;
        private System.Windows.Forms.DataGridView productGridView;
    }
}

