namespace KaMiFood
{
    partial class FrmFoodInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFoodInfo));
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.lbRMB = new System.Windows.Forms.Label();
            this.lbVipPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbxImage.Location = new System.Drawing.Point(8, 12);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(162, 108);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFoodName.Location = new System.Drawing.Point(11, 125);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(49, 19);
            this.lbFoodName.TabIndex = 1;
            this.lbFoodName.Text = "xxxx";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(12, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "RMB：";
            // 
            // pbxAdd
            // 
            this.pbxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbxAdd.Image")));
            this.pbxAdd.Location = new System.Drawing.Point(70, 146);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(45, 45);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAdd.TabIndex = 4;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            this.pbxAdd.MouseLeave += new System.EventHandler(this.pbxAdd_MouseLeave);
            this.pbxAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseMove);
            // 
            // lbRMB
            // 
            this.lbRMB.AutoSize = true;
            this.lbRMB.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRMB.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbRMB.Location = new System.Drawing.Point(78, 218);
            this.lbRMB.Name = "lbRMB";
            this.lbRMB.Size = new System.Drawing.Size(38, 25);
            this.lbRMB.TabIndex = 5;
            this.lbRMB.Text = "xx";
            // 
            // lbVipPrice
            // 
            this.lbVipPrice.AutoSize = true;
            this.lbVipPrice.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVipPrice.ForeColor = System.Drawing.Color.Gold;
            this.lbVipPrice.Location = new System.Drawing.Point(89, 194);
            this.lbVipPrice.Name = "lbVipPrice";
            this.lbVipPrice.Size = new System.Drawing.Size(38, 25);
            this.lbVipPrice.TabIndex = 7;
            this.lbVipPrice.Text = "xx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(23, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "V I P：";
            // 
            // FrmFoodInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbVipPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRMB);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFoodName);
            this.Controls.Add(this.pbxImage);
            this.DoubleBuffered = true;
            this.Name = "FrmFoodInfo";
            this.Size = new System.Drawing.Size(180, 250);
            this.Load += new System.EventHandler(this.FrmFoodInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbxAdd;
        public System.Windows.Forms.PictureBox pbxImage;
        public System.Windows.Forms.Label lbFoodName;
        public System.Windows.Forms.Label lbRMB;
        public System.Windows.Forms.Label lbVipPrice;
        private System.Windows.Forms.Label label3;
    }
}
