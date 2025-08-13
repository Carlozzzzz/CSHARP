namespace MVP_V1.Views
{
    partial class PetView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPet = new System.Windows.Forms.Label();
            this.tcPet = new System.Windows.Forms.TabControl();
            this.tpPetList = new System.Windows.Forms.TabPage();
            this.btnDeletePet = new System.Windows.Forms.Button();
            this.btnEditPet = new System.Windows.Forms.Button();
            this.btnSearchPet = new System.Windows.Forms.Button();
            this.lblSearchPet = new System.Windows.Forms.Label();
            this.tbSearchPet = new System.Windows.Forms.TextBox();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.petListGridView = new System.Windows.Forms.DataGridView();
            this.tpPetDetail = new System.Windows.Forms.TabPage();
            this.panelPetDetails = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbPetColour = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPetType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPetName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPetId = new System.Windows.Forms.TextBox();
            this.lblPetId = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tcPet.SuspendLayout();
            this.tpPetList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petListGridView)).BeginInit();
            this.tpPetDetail.SuspendLayout();
            this.panelPetDetails.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblPet);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 49);
            this.panel1.TabIndex = 0;
            // 
            // lblPet
            // 
            this.lblPet.AutoSize = true;
            this.lblPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPet.Location = new System.Drawing.Point(12, 16);
            this.lblPet.Name = "lblPet";
            this.lblPet.Size = new System.Drawing.Size(114, 17);
            this.lblPet.TabIndex = 0;
            this.lblPet.Text = "Petssss Peave";
            // 
            // tcPet
            // 
            this.tcPet.Controls.Add(this.tpPetList);
            this.tcPet.Controls.Add(this.tpPetDetail);
            this.tcPet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPet.Location = new System.Drawing.Point(15, 15);
            this.tcPet.Name = "tcPet";
            this.tcPet.SelectedIndex = 0;
            this.tcPet.Size = new System.Drawing.Size(928, 425);
            this.tcPet.TabIndex = 2;
            // 
            // tpPetList
            // 
            this.tpPetList.Controls.Add(this.btnDeletePet);
            this.tpPetList.Controls.Add(this.btnEditPet);
            this.tpPetList.Controls.Add(this.btnSearchPet);
            this.tpPetList.Controls.Add(this.lblSearchPet);
            this.tpPetList.Controls.Add(this.tbSearchPet);
            this.tpPetList.Controls.Add(this.btnAddPet);
            this.tpPetList.Controls.Add(this.petListGridView);
            this.tpPetList.Location = new System.Drawing.Point(4, 22);
            this.tpPetList.Name = "tpPetList";
            this.tpPetList.Padding = new System.Windows.Forms.Padding(3);
            this.tpPetList.Size = new System.Drawing.Size(920, 399);
            this.tpPetList.TabIndex = 0;
            this.tpPetList.Text = "Pete List";
            this.tpPetList.UseVisualStyleBackColor = true;
            // 
            // btnDeletePet
            // 
            this.btnDeletePet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePet.Location = new System.Drawing.Point(790, 100);
            this.btnDeletePet.Name = "btnDeletePet";
            this.btnDeletePet.Size = new System.Drawing.Size(91, 23);
            this.btnDeletePet.TabIndex = 6;
            this.btnDeletePet.Text = "Delete";
            this.btnDeletePet.UseVisualStyleBackColor = true;
            // 
            // btnEditPet
            // 
            this.btnEditPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPet.Location = new System.Drawing.Point(790, 71);
            this.btnEditPet.Name = "btnEditPet";
            this.btnEditPet.Size = new System.Drawing.Size(91, 23);
            this.btnEditPet.TabIndex = 5;
            this.btnEditPet.Text = "Edit";
            this.btnEditPet.UseVisualStyleBackColor = true;
            // 
            // btnSearchPet
            // 
            this.btnSearchPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchPet.Location = new System.Drawing.Point(703, 16);
            this.btnSearchPet.Name = "btnSearchPet";
            this.btnSearchPet.Size = new System.Drawing.Size(51, 23);
            this.btnSearchPet.TabIndex = 4;
            this.btnSearchPet.Text = "Search";
            this.btnSearchPet.UseVisualStyleBackColor = true;
            // 
            // lblSearchPet
            // 
            this.lblSearchPet.AutoSize = true;
            this.lblSearchPet.Location = new System.Drawing.Point(6, 19);
            this.lblSearchPet.Name = "lblSearchPet";
            this.lblSearchPet.Size = new System.Drawing.Size(41, 13);
            this.lblSearchPet.TabIndex = 3;
            this.lblSearchPet.Text = "Search";
            // 
            // tbSearchPet
            // 
            this.tbSearchPet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchPet.Location = new System.Drawing.Point(47, 16);
            this.tbSearchPet.Name = "tbSearchPet";
            this.tbSearchPet.Size = new System.Drawing.Size(650, 20);
            this.tbSearchPet.TabIndex = 2;
            // 
            // btnAddPet
            // 
            this.btnAddPet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddPet.Location = new System.Drawing.Point(790, 42);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(91, 23);
            this.btnAddPet.TabIndex = 1;
            this.btnAddPet.Text = "Add";
            this.btnAddPet.UseVisualStyleBackColor = true;
            // 
            // petListGridView
            // 
            this.petListGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.petListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.petListGridView.Location = new System.Drawing.Point(6, 42);
            this.petListGridView.Name = "petListGridView";
            this.petListGridView.Size = new System.Drawing.Size(748, 351);
            this.petListGridView.TabIndex = 0;
            // 
            // tpPetDetail
            // 
            this.tpPetDetail.Controls.Add(this.panelPetDetails);
            this.tpPetDetail.Location = new System.Drawing.Point(4, 22);
            this.tpPetDetail.Name = "tpPetDetail";
            this.tpPetDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tpPetDetail.Size = new System.Drawing.Size(920, 399);
            this.tpPetDetail.TabIndex = 1;
            this.tpPetDetail.Text = "Pet Details";
            this.tpPetDetail.UseVisualStyleBackColor = true;
            // 
            // panelPetDetails
            // 
            this.panelPetDetails.Controls.Add(this.btnCancel);
            this.panelPetDetails.Controls.Add(this.btnSave);
            this.panelPetDetails.Controls.Add(this.tbPetColour);
            this.panelPetDetails.Controls.Add(this.label5);
            this.panelPetDetails.Controls.Add(this.tbPetType);
            this.panelPetDetails.Controls.Add(this.label4);
            this.panelPetDetails.Controls.Add(this.tbPetName);
            this.panelPetDetails.Controls.Add(this.label3);
            this.panelPetDetails.Controls.Add(this.tbPetId);
            this.panelPetDetails.Controls.Add(this.lblPetId);
            this.panelPetDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPetDetails.Location = new System.Drawing.Point(3, 3);
            this.panelPetDetails.Name = "panelPetDetails";
            this.panelPetDetails.Size = new System.Drawing.Size(914, 393);
            this.panelPetDetails.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(472, 275);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 27);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Cyan;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSave.Location = new System.Drawing.Point(266, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 27);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // tbPetColour
            // 
            this.tbPetColour.Location = new System.Drawing.Point(266, 241);
            this.tbPetColour.Name = "tbPetColour";
            this.tbPetColour.Size = new System.Drawing.Size(386, 20);
            this.tbPetColour.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Pet Colour:";
            // 
            // tbPetType
            // 
            this.tbPetType.Location = new System.Drawing.Point(499, 174);
            this.tbPetType.Name = "tbPetType";
            this.tbPetType.Size = new System.Drawing.Size(153, 20);
            this.tbPetType.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Pet Type:";
            // 
            // tbPetName
            // 
            this.tbPetName.Location = new System.Drawing.Point(266, 174);
            this.tbPetName.Name = "tbPetName";
            this.tbPetName.Size = new System.Drawing.Size(153, 20);
            this.tbPetName.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Pet Name:";
            // 
            // tbPetId
            // 
            this.tbPetId.Location = new System.Drawing.Point(266, 106);
            this.tbPetId.Name = "tbPetId";
            this.tbPetId.ReadOnly = true;
            this.tbPetId.Size = new System.Drawing.Size(153, 20);
            this.tbPetId.TabIndex = 21;
            this.tbPetId.Text = "0";
            // 
            // lblPetId
            // 
            this.lblPetId.AutoSize = true;
            this.lblPetId.Location = new System.Drawing.Point(263, 90);
            this.lblPetId.Name = "lblPetId";
            this.lblPetId.Size = new System.Drawing.Size(40, 13);
            this.lblPetId.TabIndex = 20;
            this.lblPetId.Text = "Pet ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tcPet);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15);
            this.panel2.Size = new System.Drawing.Size(958, 455);
            this.panel2.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(904, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // PetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 504);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PetView";
            this.Text = "PetView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tcPet.ResumeLayout(false);
            this.tpPetList.ResumeLayout(false);
            this.tpPetList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.petListGridView)).EndInit();
            this.tpPetDetail.ResumeLayout(false);
            this.panelPetDetails.ResumeLayout(false);
            this.panelPetDetails.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPet;
        private System.Windows.Forms.TabControl tcPet;
        private System.Windows.Forms.TabPage tpPetList;
        private System.Windows.Forms.TabPage tpPetDetail;
        private System.Windows.Forms.DataGridView petListGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeletePet;
        private System.Windows.Forms.Button btnEditPet;
        private System.Windows.Forms.Button btnSearchPet;
        private System.Windows.Forms.Label lblSearchPet;
        private System.Windows.Forms.TextBox tbSearchPet;
        private System.Windows.Forms.Button btnAddPet;
        private System.Windows.Forms.Panel panelPetDetails;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbPetColour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPetType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPetName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPetId;
        private System.Windows.Forms.Label lblPetId;
        private System.Windows.Forms.Button btnClose;
    }
}