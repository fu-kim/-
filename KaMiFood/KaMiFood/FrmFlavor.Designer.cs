namespace KaMiFood
{
    partial class FrmFlavor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFlavor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxCancel = new System.Windows.Forms.PictureBox();
            this.pbxOK = new System.Windows.Forms.PictureBox();
            this.cboSpicy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pbxCancel);
            this.panel1.Controls.Add(this.pbxOK);
            this.panel1.Controls.Add(this.cboSpicy);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 165);
            this.panel1.TabIndex = 0;
            // 
            // pbxCancel
            // 
            this.pbxCancel.BackColor = System.Drawing.Color.Transparent;
            this.pbxCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCancel.Image = ((System.Drawing.Image)(resources.GetObject("pbxCancel.Image")));
            this.pbxCancel.Location = new System.Drawing.Point(284, 98);
            this.pbxCancel.Name = "pbxCancel";
            this.pbxCancel.Size = new System.Drawing.Size(145, 50);
            this.pbxCancel.TabIndex = 2;
            this.pbxCancel.TabStop = false;
            this.pbxCancel.Click += new System.EventHandler(this.pbxCancel_Click);
            // 
            // pbxOK
            // 
            this.pbxOK.BackColor = System.Drawing.Color.Transparent;
            this.pbxOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxOK.Image = ((System.Drawing.Image)(resources.GetObject("pbxOK.Image")));
            this.pbxOK.Location = new System.Drawing.Point(65, 98);
            this.pbxOK.Name = "pbxOK";
            this.pbxOK.Size = new System.Drawing.Size(145, 50);
            this.pbxOK.TabIndex = 2;
            this.pbxOK.TabStop = false;
            this.pbxOK.Click += new System.EventHandler(this.pbxOK_Click);
            // 
            // cboSpicy
            // 
            this.cboSpicy.BackColor = System.Drawing.Color.Orange;
            this.cboSpicy.Font = new System.Drawing.Font("华文琥珀", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboSpicy.ForeColor = System.Drawing.Color.White;
            this.cboSpicy.FormattingEnabled = true;
            this.cboSpicy.Items.AddRange(new object[] {
            "不辣",
            "微辣",
            "中辣",
            "重辣",
            "变态辣"});
            this.cboSpicy.Location = new System.Drawing.Point(229, 28);
            this.cboSpicy.Name = "cboSpicy";
            this.cboSpicy.Size = new System.Drawing.Size(211, 41);
            this.cboSpicy.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文琥珀", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(59, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "口味：";
            // 
            // FrmFlavor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(502, 177);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFlavor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFlavor";
            this.Load += new System.EventHandler(this.FrmFlavor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxCancel;
        private System.Windows.Forms.PictureBox pbxOK;
        private System.Windows.Forms.ComboBox cboSpicy;
        private System.Windows.Forms.Label label1;
    }
}