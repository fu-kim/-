namespace KaMiFood
{
    partial class FrmTipsOKCancel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipsOKCancel));
            this.lbTips = new System.Windows.Forms.Label();
            this.pbxOK = new System.Windows.Forms.PictureBox();
            this.pbxCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTips
            // 
            this.lbTips.AutoSize = true;
            this.lbTips.BackColor = System.Drawing.Color.Transparent;
            this.lbTips.Font = new System.Drawing.Font("华文行楷", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTips.ForeColor = System.Drawing.Color.Gold;
            this.lbTips.Location = new System.Drawing.Point(19, 22);
            this.lbTips.Name = "lbTips";
            this.lbTips.Size = new System.Drawing.Size(64, 30);
            this.lbTips.TabIndex = 3;
            this.lbTips.Text = "label1";
            this.lbTips.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxOK
            // 
            this.pbxOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxOK.Image = ((System.Drawing.Image)(resources.GetObject("pbxOK.Image")));
            this.pbxOK.Location = new System.Drawing.Point(29, 102);
            this.pbxOK.Name = "pbxOK";
            this.pbxOK.Size = new System.Drawing.Size(85, 25);
            this.pbxOK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxOK.TabIndex = 2;
            this.pbxOK.TabStop = false;
            this.pbxOK.Click += new System.EventHandler(this.pbxOK_Click);
            this.pbxOK.MouseLeave += new System.EventHandler(this.pbxOK_MouseLeave);
            this.pbxOK.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxOK_MouseMove);
            // 
            // pbxCancel
            // 
            this.pbxCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxCancel.Image = ((System.Drawing.Image)(resources.GetObject("pbxCancel.Image")));
            this.pbxCancel.Location = new System.Drawing.Point(143, 102);
            this.pbxCancel.Name = "pbxCancel";
            this.pbxCancel.Size = new System.Drawing.Size(85, 25);
            this.pbxCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCancel.TabIndex = 4;
            this.pbxCancel.TabStop = false;
            this.pbxCancel.Click += new System.EventHandler(this.pbxCancel_Click);
            this.pbxCancel.MouseLeave += new System.EventHandler(this.pbxCancel_MouseLeave);
            this.pbxCancel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxCancel_MouseMove);
            // 
            // FrmTipsOKCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(256, 139);
            this.Controls.Add(this.pbxCancel);
            this.Controls.Add(this.lbTips);
            this.Controls.Add(this.pbxOK);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTipsOKCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTipsOKCanal";
            ((System.ComponentModel.ISupportInitialize)(this.pbxOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbTips;
        private System.Windows.Forms.PictureBox pbxOK;
        private System.Windows.Forms.PictureBox pbxCancel;
    }
}