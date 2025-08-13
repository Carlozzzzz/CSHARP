namespace MVP_V1.Views
{
    partial class MainView
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
            this.panelSideMain = new System.Windows.Forms.Panel();
            this.btnPet = new System.Windows.Forms.Button();
            this.panelSideMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMain
            // 
            this.panelSideMain.Controls.Add(this.btnPet);
            this.panelSideMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMain.Location = new System.Drawing.Point(0, 0);
            this.panelSideMain.Name = "panelSideMain";
            this.panelSideMain.Size = new System.Drawing.Size(210, 450);
            this.panelSideMain.TabIndex = 0;
            // 
            // btnPet
            // 
            this.btnPet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPet.Location = new System.Drawing.Point(0, 65);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(210, 41);
            this.btnPet.TabIndex = 0;
            this.btnPet.Text = "Pet";
            this.btnPet.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSideMain);
            this.IsMdiContainer = true;
            this.Name = "MainView";
            this.Text = "MainView";
            this.panelSideMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMain;
        private System.Windows.Forms.Button btnPet;
    }
}