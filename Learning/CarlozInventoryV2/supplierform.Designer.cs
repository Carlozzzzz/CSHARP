namespace CarlozInventoryV2
{
    partial class supplierform
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
            this.panel1Supplier = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefreshSupplier = new System.Windows.Forms.Button();
            this.btnNewSupplier = new System.Windows.Forms.Button();
            this.dtpCreatedAtSupplier = new System.Windows.Forms.DateTimePicker();
            this.cbStatusSupplier = new System.Windows.Forms.ComboBox();
            this.tbSearchSupplier = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.supplierGridView = new System.Windows.Forms.DataGridView();
            this.panel1Supplier.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1Supplier
            // 
            this.panel1Supplier.Controls.Add(this.panel3);
            this.panel1Supplier.Controls.Add(this.panel2);
            this.panel1Supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1Supplier.Location = new System.Drawing.Point(0, 0);
            this.panel1Supplier.Name = "panel1Supplier";
            this.panel1Supplier.Size = new System.Drawing.Size(800, 570);
            this.panel1Supplier.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnRefreshSupplier);
            this.panel3.Controls.Add(this.btnNewSupplier);
            this.panel3.Controls.Add(this.dtpCreatedAtSupplier);
            this.panel3.Controls.Add(this.cbStatusSupplier);
            this.panel3.Controls.Add(this.tbSearchSupplier);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(776, 47);
            this.panel3.TabIndex = 0;
            // 
            // btnRefreshSupplier
            // 
            this.btnRefreshSupplier.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRefreshSupplier.FlatAppearance.BorderSize = 0;
            this.btnRefreshSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefreshSupplier.Location = new System.Drawing.Point(604, 5);
            this.btnRefreshSupplier.Name = "btnRefreshSupplier";
            this.btnRefreshSupplier.Size = new System.Drawing.Size(77, 33);
            this.btnRefreshSupplier.TabIndex = 4;
            this.btnRefreshSupplier.Text = "Refresh";
            this.btnRefreshSupplier.UseVisualStyleBackColor = false;
            this.btnRefreshSupplier.Click += new System.EventHandler(this.btnRefreshSupplier_Click);
            // 
            // btnNewSupplier
            // 
            this.btnNewSupplier.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNewSupplier.FlatAppearance.BorderSize = 0;
            this.btnNewSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewSupplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewSupplier.Location = new System.Drawing.Point(687, 5);
            this.btnNewSupplier.Name = "btnNewSupplier";
            this.btnNewSupplier.Size = new System.Drawing.Size(77, 33);
            this.btnNewSupplier.TabIndex = 0;
            this.btnNewSupplier.Text = "New";
            this.btnNewSupplier.UseVisualStyleBackColor = false;
            this.btnNewSupplier.Click += new System.EventHandler(this.btnNewSupplier_Click);
            // 
            // dtpCreatedAtSupplier
            // 
            this.dtpCreatedAtSupplier.Location = new System.Drawing.Point(286, 12);
            this.dtpCreatedAtSupplier.Name = "dtpCreatedAtSupplier";
            this.dtpCreatedAtSupplier.Size = new System.Drawing.Size(194, 20);
            this.dtpCreatedAtSupplier.TabIndex = 3;
            this.dtpCreatedAtSupplier.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtpCreatedAtSupplier.ValueChanged += new System.EventHandler(this.dtpCreatedAtSupplier_ValueChanged);
            // 
            // cbStatusSupplier
            // 
            this.cbStatusSupplier.FormattingEnabled = true;
            this.cbStatusSupplier.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cbStatusSupplier.Location = new System.Drawing.Point(212, 11);
            this.cbStatusSupplier.Name = "cbStatusSupplier";
            this.cbStatusSupplier.Size = new System.Drawing.Size(68, 21);
            this.cbStatusSupplier.TabIndex = 2;
            this.cbStatusSupplier.Text = "Status";
            this.cbStatusSupplier.SelectedIndexChanged += new System.EventHandler(this.cbStatusSupplier_SelectedIndexChanged);
            // 
            // tbSearchSupplier
            // 
            this.tbSearchSupplier.Location = new System.Drawing.Point(13, 12);
            this.tbSearchSupplier.Name = "tbSearchSupplier";
            this.tbSearchSupplier.Size = new System.Drawing.Size(178, 20);
            this.tbSearchSupplier.TabIndex = 0;
            this.tbSearchSupplier.Text = "Search...";
            this.tbSearchSupplier.Click += new System.EventHandler(this.tbSearchSupplier_Click);
            this.tbSearchSupplier.TextChanged += new System.EventHandler(this.tbSearchSupplier_TextChanged);
            this.tbSearchSupplier.MouseLeave += new System.EventHandler(this.tbSearchSupplier_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.supplierGridView);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 546);
            this.panel2.TabIndex = 0;
            // 
            // supplierGridView
            // 
            this.supplierGridView.AllowUserToAddRows = false;
            this.supplierGridView.AllowUserToDeleteRows = false;
            this.supplierGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.supplierGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.supplierGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierGridView.Location = new System.Drawing.Point(13, 57);
            this.supplierGridView.Name = "supplierGridView";
            this.supplierGridView.ReadOnly = true;
            this.supplierGridView.RowHeadersVisible = false;
            this.supplierGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.supplierGridView.Size = new System.Drawing.Size(750, 477);
            this.supplierGridView.TabIndex = 0;
            this.supplierGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.supplierGridView_CellContentClick_1);
            // 
            // supplierform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.panel1Supplier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "supplierform";
            this.Text = "supplierform";
            this.panel1Supplier.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1Supplier;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefreshSupplier;
        private System.Windows.Forms.Button btnNewSupplier;
        private System.Windows.Forms.DateTimePicker dtpCreatedAtSupplier;
        private System.Windows.Forms.ComboBox cbStatusSupplier;
        private System.Windows.Forms.TextBox tbSearchSupplier;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView supplierGridView;
    }
}