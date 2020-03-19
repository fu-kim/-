namespace KaMiFood
{
    partial class flpSchedules
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flpSchedules));
            this.lbFName = new System.Windows.Forms.Label();
            this.pbxSee = new System.Windows.Forms.PictureBox();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFName.ForeColor = System.Drawing.Color.Snow;
            this.lbFName.Location = new System.Drawing.Point(12, 7);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(45, 19);
            this.lbFName.TabIndex = 0;
            this.lbFName.Text = "XXXX";
            // 
            // pbxSee
            // 
            this.pbxSee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSee.Image = ((System.Drawing.Image)(resources.GetObject("pbxSee.Image")));
            this.pbxSee.Location = new System.Drawing.Point(109, 33);
            this.pbxSee.Name = "pbxSee";
            this.pbxSee.Size = new System.Drawing.Size(54, 53);
            this.pbxSee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSee.TabIndex = 1;
            this.pbxSee.TabStop = false;
            this.pbxSee.Click += new System.EventHandler(this.pbxSee_Click);
            this.pbxSee.MouseLeave += new System.EventHandler(this.pbxSee_MouseLeave);
            this.pbxSee.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxSee_MouseMove);
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOrderId.ForeColor = System.Drawing.Color.Snow;
            this.lbOrderId.Location = new System.Drawing.Point(3, 61);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(60, 25);
            this.lbOrderId.TabIndex = 2;
            this.lbOrderId.Text = "XXXX";
            this.lbOrderId.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.lbOrderId);
            this.panel1.Controls.Add(this.pbxSee);
            this.panel1.Controls.Add(this.lbFName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 89);
            this.panel1.TabIndex = 3;
            // 
            // flpSchedules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "flpSchedules";
            this.Size = new System.Drawing.Size(173, 95);
            ((System.ComponentModel.ISupportInitialize)(this.pbxSee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxSee;
        public System.Windows.Forms.Label lbFName;
        public System.Windows.Forms.Label lbOrderId;
        private System.Windows.Forms.Panel panel1;
    }
}
