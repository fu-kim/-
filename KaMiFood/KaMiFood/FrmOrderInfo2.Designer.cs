namespace KaMiFood
{
    partial class FrmOrderInfo2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderInfo2));
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lbFName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbxAdd = new System.Windows.Forms.PictureBox();
            this.pbxMinus = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFNumber = new System.Windows.Forms.Label();
            this.lbRMB = new System.Windows.Forms.Label();
            this.lbVIP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinus)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(10, 10);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(91, 77);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.BackColor = System.Drawing.Color.Transparent;
            this.lbFName.Font = new System.Drawing.Font("华文琥珀", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFName.ForeColor = System.Drawing.Color.Orange;
            this.lbFName.Location = new System.Drawing.Point(111, 11);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(50, 21);
            this.lbFName.TabIndex = 1;
            this.lbFName.Text = "XXXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(112, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "RMB：";
            // 
            // pbxAdd
            // 
            this.pbxAdd.BackColor = System.Drawing.Color.Transparent;
            this.pbxAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAdd.Image = ((System.Drawing.Image)(resources.GetObject("pbxAdd.Image")));
            this.pbxAdd.Location = new System.Drawing.Point(324, 24);
            this.pbxAdd.Name = "pbxAdd";
            this.pbxAdd.Size = new System.Drawing.Size(50, 50);
            this.pbxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAdd.TabIndex = 3;
            this.pbxAdd.TabStop = false;
            this.pbxAdd.Click += new System.EventHandler(this.pbxAdd_Click);
            this.pbxAdd.MouseLeave += new System.EventHandler(this.pbxAdd_MouseLeave);
            this.pbxAdd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxAdd_MouseMove);
            // 
            // pbxMinus
            // 
            this.pbxMinus.BackColor = System.Drawing.Color.Transparent;
            this.pbxMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxMinus.Image = ((System.Drawing.Image)(resources.GetObject("pbxMinus.Image")));
            this.pbxMinus.Location = new System.Drawing.Point(381, 24);
            this.pbxMinus.Name = "pbxMinus";
            this.pbxMinus.Size = new System.Drawing.Size(50, 50);
            this.pbxMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMinus.TabIndex = 3;
            this.pbxMinus.TabStop = false;
            this.pbxMinus.Click += new System.EventHandler(this.pbxMinus_Click);
            this.pbxMinus.MouseLeave += new System.EventHandler(this.pbxMinus_MouseLeave);
            this.pbxMinus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxMinus_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(249, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 4;
            this.label3.Text = "份数：";
            // 
            // lbFNumber
            // 
            this.lbFNumber.AutoSize = true;
            this.lbFNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbFNumber.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFNumber.ForeColor = System.Drawing.Color.Orange;
            this.lbFNumber.Location = new System.Drawing.Point(293, 32);
            this.lbFNumber.Name = "lbFNumber";
            this.lbFNumber.Size = new System.Drawing.Size(27, 30);
            this.lbFNumber.TabIndex = 5;
            this.lbFNumber.Text = "X";
            // 
            // lbRMB
            // 
            this.lbRMB.AutoSize = true;
            this.lbRMB.BackColor = System.Drawing.Color.Transparent;
            this.lbRMB.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRMB.ForeColor = System.Drawing.Color.Orange;
            this.lbRMB.Location = new System.Drawing.Point(154, 59);
            this.lbRMB.Name = "lbRMB";
            this.lbRMB.Size = new System.Drawing.Size(69, 30);
            this.lbRMB.TabIndex = 6;
            this.lbRMB.Text = "XXXX";
            // 
            // lbVIP
            // 
            this.lbVIP.AutoSize = true;
            this.lbVIP.BackColor = System.Drawing.Color.Transparent;
            this.lbVIP.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVIP.ForeColor = System.Drawing.Color.Gold;
            this.lbVIP.Location = new System.Drawing.Point(154, 32);
            this.lbVIP.Name = "lbVIP";
            this.lbVIP.Size = new System.Drawing.Size(69, 30);
            this.lbVIP.TabIndex = 8;
            this.lbVIP.Text = "XXXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文琥珀", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(112, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "V I P：";
            // 
            // FrmOrderInfo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbVIP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbRMB);
            this.Controls.Add(this.lbFNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbxMinus);
            this.Controls.Add(this.pbxAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbFName);
            this.Controls.Add(this.pbxImage);
            this.DoubleBuffered = true;
            this.Name = "FrmOrderInfo2";
            this.Size = new System.Drawing.Size(469, 97);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMinus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.PictureBox pbxImage;
        public System.Windows.Forms.Label lbFName;
        public System.Windows.Forms.PictureBox pbxAdd;
        public System.Windows.Forms.PictureBox pbxMinus;
        public System.Windows.Forms.Label lbFNumber;
        public System.Windows.Forms.Label lbRMB;
        public System.Windows.Forms.Label lbVIP;
        private System.Windows.Forms.Label label4;
    }
}
