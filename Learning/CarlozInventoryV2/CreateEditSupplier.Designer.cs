namespace CarlozInventoryV2
{
    partial class CreateEditSupplier
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbSupplierStatus = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbSupplierMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.tbSupplierEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbSupplierId = new System.Windows.Forms.TextBox();
            this.tbSupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.lbHeaderTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(86, 243);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 51;
            this.lblStatus.Text = "Status:";
            // 
            // tbSupplierStatus
            // 
            this.tbSupplierStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSupplierStatus.FormattingEnabled = true;
            this.tbSupplierStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.tbSupplierStatus.Location = new System.Drawing.Point(184, 240);
            this.tbSupplierStatus.Name = "tbSupplierStatus";
            this.tbSupplierStatus.Size = new System.Drawing.Size(266, 21);
            this.tbSupplierStatus.TabIndex = 50;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.Location = new System.Drawing.Point(269, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 29);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(164, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 29);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbSupplierMobile
            // 
            this.tbSupplierMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSupplierMobile.Location = new System.Drawing.Point(184, 211);
            this.tbSupplierMobile.Name = "tbSupplierMobile";
            this.tbSupplierMobile.Size = new System.Drawing.Size(266, 20);
            this.tbSupplierMobile.TabIndex = 43;
            // 
            // lblMobile
            // 
            this.lblMobile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(86, 214);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(51, 13);
            this.lblMobile.TabIndex = 42;
            this.lblMobile.Text = "Mobile #:";
            // 
            // tbSupplierEmail
            // 
            this.tbSupplierEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSupplierEmail.Location = new System.Drawing.Point(184, 185);
            this.tbSupplierEmail.Name = "tbSupplierEmail";
            this.tbSupplierEmail.Size = new System.Drawing.Size(266, 20);
            this.tbSupplierEmail.TabIndex = 41;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(86, 188);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 40;
            this.lblEmail.Text = "Email:";
            // 
            // tbSupplierId
            // 
            this.tbSupplierId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSupplierId.Location = new System.Drawing.Point(184, 133);
            this.tbSupplierId.Name = "tbSupplierId";
            this.tbSupplierId.ReadOnly = true;
            this.tbSupplierId.Size = new System.Drawing.Size(266, 20);
            this.tbSupplierId.TabIndex = 39;
            // 
            // tbSupplierName
            // 
            this.tbSupplierName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSupplierName.Location = new System.Drawing.Point(184, 159);
            this.tbSupplierName.Name = "tbSupplierName";
            this.tbSupplierName.Size = new System.Drawing.Size(266, 20);
            this.tbSupplierName.TabIndex = 38;
            // 
            // lblSupplier
            // 
            this.lblSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(86, 162);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(48, 13);
            this.lblSupplier.TabIndex = 37;
            this.lblSupplier.Text = "Supplier:";
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.Location = new System.Drawing.Point(86, 136);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(62, 13);
            this.lblSupplierId.TabIndex = 36;
            this.lblSupplierId.Text = "Supplier ID:";
            // 
            // lbHeaderTitle
            // 
            this.lbHeaderTitle.BackColor = System.Drawing.Color.DimGray;
            this.lbHeaderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbHeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderTitle.ForeColor = System.Drawing.Color.White;
            this.lbHeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.lbHeaderTitle.Name = "lbHeaderTitle";
            this.lbHeaderTitle.Size = new System.Drawing.Size(540, 46);
            this.lbHeaderTitle.TabIndex = 35;
            this.lbHeaderTitle.Text = "Create Supplier";
            this.lbHeaderTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateEditSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 351);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.tbSupplierStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbSupplierMobile);
            this.Controls.Add(this.lblMobile);
            this.Controls.Add(this.tbSupplierEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbSupplierId);
            this.Controls.Add(this.tbSupplierName);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.lblSupplierId);
            this.Controls.Add(this.lbHeaderTitle);
            this.Name = "CreateEditSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateEditSupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox tbSupplierStatus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbSupplierMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox tbSupplierEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbSupplierId;
        private System.Windows.Forms.TextBox tbSupplierName;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.Label lbHeaderTitle;
    }
}