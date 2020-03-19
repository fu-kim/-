namespace KaMiFood
{
    partial class FrmCActivityInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxFoodImage = new System.Windows.Forms.PictureBox();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbFNumber = new System.Windows.Forms.Label();
            this.lbRMB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbRMB);
            this.panel1.Controls.Add(this.lbFNumber);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbFoodName);
            this.panel1.Controls.Add(this.pbxFoodImage);
            this.panel1.Location = new System.Drawing.Point(4, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 294);
            this.panel1.TabIndex = 0;
            // 
            // pbxFoodImage
            // 
            this.pbxFoodImage.Location = new System.Drawing.Point(1, 2);
            this.pbxFoodImage.Name = "pbxFoodImage";
            this.pbxFoodImage.Size = new System.Drawing.Size(227, 206);
            this.pbxFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoodImage.TabIndex = 0;
            this.pbxFoodImage.TabStop = false;
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFoodName.ForeColor = System.Drawing.Color.Orange;
            this.lbFoodName.Location = new System.Drawing.Point(59, 212);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(45, 19);
            this.lbFoodName.TabIndex = 1;
            this.lbFoodName.Text = "XXXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(38, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "份数：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(38, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "价格：";
            // 
            // lbFNumber
            // 
            this.lbFNumber.AutoSize = true;
            this.lbFNumber.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFNumber.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbFNumber.Location = new System.Drawing.Point(101, 241);
            this.lbFNumber.Name = "lbFNumber";
            this.lbFNumber.Size = new System.Drawing.Size(45, 19);
            this.lbFNumber.TabIndex = 1;
            this.lbFNumber.Text = "XXXX";
            // 
            // lbRMB
            // 
            this.lbRMB.AutoSize = true;
            this.lbRMB.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRMB.ForeColor = System.Drawing.Color.Red;
            this.lbRMB.Location = new System.Drawing.Point(110, 268);
            this.lbRMB.Name = "lbRMB";
            this.lbRMB.Size = new System.Drawing.Size(45, 19);
            this.lbRMB.TabIndex = 1;
            this.lbRMB.Text = "XXXX";
            // 
            // FrmCActivityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.Controls.Add(this.panel1);
            this.Name = "FrmCActivityInfo";
            this.Size = new System.Drawing.Size(237, 311);
            this.Load += new System.EventHandler(this.FrmCActivityInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoodImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbFoodName;
        public System.Windows.Forms.PictureBox pbxFoodImage;
        public System.Windows.Forms.Label lbRMB;
        public System.Windows.Forms.Label lbFNumber;
    }
}
