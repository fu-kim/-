namespace KaMiFood
{
    partial class FrmOrderInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderInfo));
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.pbxMinus = new System.Windows.Forms.PictureBox();
            this.lbFNumber = new System.Windows.Forms.Label();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.lbFoodName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbRMB = new System.Windows.Forms.Label();
            this.flpSpicy = new System.Windows.Forms.FlowLayoutPanel();
            this.lbVIP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(20, 17);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(153, 116);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // pbxMinus
            // 
            this.pbxMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinus.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinus.Image")));
            this.pbxMinus.Location = new System.Drawing.Point(644, 72);
            this.pbxMinus.Name = "pbxMinus";
            this.pbxMinus.Size = new System.Drawing.Size(50, 50);
            this.pbxMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinus.TabIndex = 1;
            this.pbxMinus.TabStop = false;
            this.pbxMinus.Click += new System.EventHandler(this.pbxMinus_Click);
            this.pbxMinus.MouseLeave += new System.EventHandler(this.pbxMinus_MouseLeave);
            this.pbxMinus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxMinus_MouseMove);
            // 
            // lbFNumber
            // 
            this.lbFNumber.AutoSize = true;
            this.lbFNumber.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFNumber.ForeColor = System.Drawing.Color.Orange;
            this.lbFNumber.Location = new System.Drawing.Point(660, 33);
            this.lbFNumber.Name = "lbFNumber";
            this.lbFNumber.Size = new System.Drawing.Size(24, 25);
            this.lbFNumber.TabIndex = 2;
            this.lbFNumber.Text = "X";
            // 
            // pbxAdd
            // 
            this.pbxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbxAdd.Image")));
            this.pbxAdd.Location = new System.Drawing.Point(588, 72);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(50, 50);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAdd.TabIndex = 1;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            this.pbxAdd.MouseLeave += new System.EventHandler(this.pbxAdd_MouseLeave);
            this.pbxAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseMove);
            // 
            // lbFoodName
            // 
            this.lbFoodName.AutoSize = true;
            this.lbFoodName.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFoodName.ForeColor = System.Drawing.Color.Orange;
            this.lbFoodName.Location = new System.Drawing.Point(179, 21);
            this.lbFoodName.Name = "lbFoodName";
            this.lbFoodName.Size = new System.Drawing.Size(48, 25);
            this.lbFoodName.TabIndex = 3;
            this.lbFoodName.Text = "XXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(179, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "RMB：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(583, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "份数：";
            // 
            // lbRMB
            // 
            this.lbRMB.AutoSize = true;
            this.lbRMB.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRMB.ForeColor = System.Drawing.Color.Orange;
            this.lbRMB.Location = new System.Drawing.Point(249, 111);
            this.lbRMB.Name = "lbRMB";
            this.lbRMB.Size = new System.Drawing.Size(48, 25);
            this.lbRMB.TabIndex = 5;
            this.lbRMB.Text = "XXX";
            // 
            // flpSpicy
            // 
            this.flpSpicy.AutoScroll = true;
            this.flpSpicy.Location = new System.Drawing.Point(337, 16);
            this.flpSpicy.Name = "flpSpicy";
            this.flpSpicy.Size = new System.Drawing.Size(241, 118);
            this.flpSpicy.TabIndex = 6;
            // 
            // lbVIP
            // 
            this.lbVIP.AutoSize = true;
            this.lbVIP.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVIP.ForeColor = System.Drawing.Color.Gold;
            this.lbVIP.Location = new System.Drawing.Point(250, 80);
            this.lbVIP.Name = "lbVIP";
            this.lbVIP.Size = new System.Drawing.Size(48, 25);
            this.lbVIP.TabIndex = 8;
            this.lbVIP.Text = "XXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(181, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "V I P：";
            // 
            // FrmOrderInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbVIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFNumber);
            this.Controls.Add(this.lbRMB);
            this.Controls.Add(this.flpSpicy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbFoodName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.pbxMinus);
            this.Controls.Add(this.pbxImage);
            this.DoubleBuffered = true;
            this.Name = "FrmOrderInfo";
            this.Size = new System.Drawing.Size(739, 150);
            this.Load += new System.EventHandler(this.FrmOrderInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.PictureBox pbxImage;
        public System.Windows.Forms.Label lbFNumber;
        public System.Windows.Forms.Label lbFoodName;
        public System.Windows.Forms.Label lbRMB;
        public System.Windows.Forms.PictureBox pbxMinus;
        public System.Windows.Forms.PictureBox pbxAdd;
        public System.Windows.Forms.FlowLayoutPanel flpSpicy;
        public System.Windows.Forms.Label lbVIP;
        private System.Windows.Forms.Label label2;
    }
}
