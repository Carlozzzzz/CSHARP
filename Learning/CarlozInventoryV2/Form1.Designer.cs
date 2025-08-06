namespace CarlozInventoryV2
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
            this.panelside = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnlogs = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnusermanagement = new System.Windows.Forms.Button();
            this.btnsupplier = new System.Windows.Forms.Button();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btndashboard = new System.Windows.Forms.Button();
            this.btnproducts = new System.Windows.Forms.Button();
            this.panelheader = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panelside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelheader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelside
            // 
            this.panelside.BackColor = System.Drawing.Color.DimGray;
            this.panelside.Controls.Add(this.btnLogout);
            this.panelside.Controls.Add(this.btnlogs);
            this.panelside.Controls.Add(this.pictureBox1);
            this.panelside.Controls.Add(this.btnusermanagement);
            this.panelside.Controls.Add(this.btnsupplier);
            this.panelside.Controls.Add(this.btnsettings);
            this.panelside.Controls.Add(this.btndashboard);
            this.panelside.Controls.Add(this.btnproducts);
            this.panelside.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelside.Location = new System.Drawing.Point(0, 30);
            this.panelside.Name = "panelside";
            this.panelside.Size = new System.Drawing.Size(200, 570);
            this.panelside.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Gray;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnLogout.Location = new System.Drawing.Point(0, 533);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 37);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnlogs
            // 
            this.btnlogs.BackColor = System.Drawing.Color.DimGray;
            this.btnlogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlogs.FlatAppearance.BorderSize = 0;
            this.btnlogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogs.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogs.ForeColor = System.Drawing.Color.White;
            this.btnlogs.Image = global::CarlozInventoryV2.Properties.Resources.logs;
            this.btnlogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogs.Location = new System.Drawing.Point(0, 316);
            this.btnlogs.Name = "btnlogs";
            this.btnlogs.Size = new System.Drawing.Size(200, 30);
            this.btnlogs.TabIndex = 5;
            this.btnlogs.Text = "LOGS";
            this.btnlogs.UseVisualStyleBackColor = false;
            this.btnlogs.Click += new System.EventHandler(this.btnlogs_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarlozInventoryV2.Properties.Resources.inventory_logo;
            this.pictureBox1.Location = new System.Drawing.Point(50, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnusermanagement
            // 
            this.btnusermanagement.BackColor = System.Drawing.Color.DimGray;
            this.btnusermanagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnusermanagement.FlatAppearance.BorderSize = 0;
            this.btnusermanagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusermanagement.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusermanagement.ForeColor = System.Drawing.Color.White;
            this.btnusermanagement.Image = global::CarlozInventoryV2.Properties.Resources.users;
            this.btnusermanagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusermanagement.Location = new System.Drawing.Point(0, 280);
            this.btnusermanagement.Name = "btnusermanagement";
            this.btnusermanagement.Size = new System.Drawing.Size(200, 30);
            this.btnusermanagement.TabIndex = 4;
            this.btnusermanagement.Text = "USER MANAGEMENT";
            this.btnusermanagement.UseVisualStyleBackColor = false;
            this.btnusermanagement.Click += new System.EventHandler(this.btnusermanagement_Click);
            // 
            // btnsupplier
            // 
            this.btnsupplier.BackColor = System.Drawing.Color.DimGray;
            this.btnsupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsupplier.FlatAppearance.BorderSize = 0;
            this.btnsupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupplier.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupplier.ForeColor = System.Drawing.Color.White;
            this.btnsupplier.Image = global::CarlozInventoryV2.Properties.Resources.supplier;
            this.btnsupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupplier.Location = new System.Drawing.Point(0, 208);
            this.btnsupplier.Name = "btnsupplier";
            this.btnsupplier.Size = new System.Drawing.Size(200, 30);
            this.btnsupplier.TabIndex = 2;
            this.btnsupplier.Text = "SUPPLIER";
            this.btnsupplier.UseVisualStyleBackColor = false;
            this.btnsupplier.Click += new System.EventHandler(this.btnsupplier_Click);
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.DimGray;
            this.btnsettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettings.ForeColor = System.Drawing.Color.White;
            this.btnsettings.Image = global::CarlozInventoryV2.Properties.Resources.settings;
            this.btnsettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.Location = new System.Drawing.Point(0, 244);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(200, 30);
            this.btnsettings.TabIndex = 3;
            this.btnsettings.Text = "SETTINGS";
            this.btnsettings.UseVisualStyleBackColor = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btndashboard
            // 
            this.btndashboard.BackColor = System.Drawing.Color.DimGray;
            this.btndashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndashboard.FlatAppearance.BorderSize = 0;
            this.btndashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndashboard.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndashboard.ForeColor = System.Drawing.Color.White;
            this.btndashboard.Image = global::CarlozInventoryV2.Properties.Resources.home;
            this.btndashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndashboard.Location = new System.Drawing.Point(0, 136);
            this.btndashboard.Name = "btndashboard";
            this.btndashboard.Size = new System.Drawing.Size(200, 30);
            this.btndashboard.TabIndex = 0;
            this.btndashboard.Text = "DASHBOARD";
            this.btndashboard.UseVisualStyleBackColor = false;
            this.btndashboard.Click += new System.EventHandler(this.btndashboard_Click);
            // 
            // btnproducts
            // 
            this.btnproducts.BackColor = System.Drawing.Color.DimGray;
            this.btnproducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnproducts.FlatAppearance.BorderSize = 0;
            this.btnproducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproducts.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproducts.ForeColor = System.Drawing.Color.White;
            this.btnproducts.Image = global::CarlozInventoryV2.Properties.Resources.products;
            this.btnproducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproducts.Location = new System.Drawing.Point(0, 172);
            this.btnproducts.Name = "btnproducts";
            this.btnproducts.Size = new System.Drawing.Size(200, 30);
            this.btnproducts.TabIndex = 1;
            this.btnproducts.Text = "PRODUCTS";
            this.btnproducts.UseVisualStyleBackColor = false;
            this.btnproducts.Click += new System.EventHandler(this.btnproducts_Click);
            // 
            // panelheader
            // 
            this.panelheader.BackColor = System.Drawing.Color.Gray;
            this.panelheader.Controls.Add(this.button1);
            this.panelheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelheader.Location = new System.Drawing.Point(0, 0);
            this.panelheader.Name = "panelheader";
            this.panelheader.Size = new System.Drawing.Size(1000, 30);
            this.panelheader.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(970, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 7;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(200, 30);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(800, 570);
            this.mainpanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panelside);
            this.Controls.Add(this.panelheader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelheader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelside;
        private System.Windows.Forms.Panel panelheader;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Button btnsupplier;
        private System.Windows.Forms.Button btnproducts;
        private System.Windows.Forms.Button btndashboard;
        private System.Windows.Forms.Button btnlogs;
        private System.Windows.Forms.Button btnusermanagement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLogout;
    }
}

