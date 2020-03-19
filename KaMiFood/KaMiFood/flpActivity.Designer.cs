namespace KaMiFood
{
    partial class flpActivity
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flpActivity));
            this.pbxActivityImage = new System.Windows.Forms.PictureBox();
            this.pbxFind = new System.Windows.Forms.PictureBox();
            this.lbActivityName = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbATime = new System.Windows.Forms.Label();
            this.lbATimeEnd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxActivityImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFind)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxActivityImage
            // 
            this.pbxActivityImage.BackColor = System.Drawing.Color.PapayaWhip;
            this.pbxActivityImage.Location = new System.Drawing.Point(3, 3);
            this.pbxActivityImage.Name = "pbxActivityImage";
            this.pbxActivityImage.Size = new System.Drawing.Size(268, 209);
            this.pbxActivityImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxActivityImage.TabIndex = 0;
            this.pbxActivityImage.TabStop = false;
            // 
            // pbxFind
            // 
            this.pbxFind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxFind.Image = ((System.Drawing.Image)(resources.GetObject("pbxFind.Image")));
            this.pbxFind.Location = new System.Drawing.Point(218, 218);
            this.pbxFind.Name = "pbxFind";
            this.pbxFind.Size = new System.Drawing.Size(53, 114);
            this.pbxFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFind.TabIndex = 1;
            this.pbxFind.TabStop = false;
            this.pbxFind.Click += new System.EventHandler(this.pbxFind_Click);
            this.pbxFind.MouseLeave += new System.EventHandler(this.pbxFind_MouseLeave);
            this.pbxFind.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxFind_MouseMove);
            // 
            // lbActivityName
            // 
            this.lbActivityName.AutoSize = true;
            this.lbActivityName.Font = new System.Drawing.Font("华文隶书", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbActivityName.ForeColor = System.Drawing.Color.Gold;
            this.lbActivityName.Location = new System.Drawing.Point(11, 218);
            this.lbActivityName.Name = "lbActivityName";
            this.lbActivityName.Size = new System.Drawing.Size(74, 30);
            this.lbActivityName.TabIndex = 2;
            this.lbActivityName.Text = "label1";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("华文琥珀", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb.ForeColor = System.Drawing.Color.Orange;
            this.lb.Location = new System.Drawing.Point(13, 252);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(88, 17);
            this.lb.TabIndex = 3;
            this.lb.Text = "活动时间：";
            // 
            // lbATime
            // 
            this.lbATime.AutoSize = true;
            this.lbATime.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbATime.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbATime.Location = new System.Drawing.Point(31, 275);
            this.lbATime.Name = "lbATime";
            this.lbATime.Size = new System.Drawing.Size(63, 19);
            this.lbATime.TabIndex = 4;
            this.lbATime.Text = "label1";
            // 
            // lbATimeEnd
            // 
            this.lbATimeEnd.AutoSize = true;
            this.lbATimeEnd.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbATimeEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbATimeEnd.Location = new System.Drawing.Point(31, 316);
            this.lbATimeEnd.Name = "lbATimeEnd";
            this.lbATimeEnd.Size = new System.Drawing.Size(63, 19);
            this.lbATimeEnd.TabIndex = 4;
            this.lbATimeEnd.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(92, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "至";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flpActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbATimeEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbATime);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.lbActivityName);
            this.Controls.Add(this.pbxFind);
            this.Controls.Add(this.pbxActivityImage);
            this.DoubleBuffered = true;
            this.Name = "flpActivity";
            this.Size = new System.Drawing.Size(274, 340);
            ((System.ComponentModel.ISupportInitialize)(this.pbxActivityImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbxFind;
        public System.Windows.Forms.Label lbActivityName;
        public System.Windows.Forms.PictureBox pbxActivityImage;
        public System.Windows.Forms.Label lb;
        public System.Windows.Forms.Label lbATime;
        public System.Windows.Forms.Label lbATimeEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
