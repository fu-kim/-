namespace KaMiFood
{
    partial class FrmPay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPay));
            this.flpPayMain = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbVIPSum = new System.Windows.Forms.Label();
            this.lbviphj = new System.Windows.Forms.Label();
            this.pbxPay = new System.Windows.Forms.PictureBox();
            this.lbSumRmb = new System.Windows.Forms.Label();
            this.lbsumhj = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPay)).BeginInit();
            this.SuspendLayout();
            // 
            // flpPayMain
            // 
            this.flpPayMain.AutoScroll = true;
            this.flpPayMain.BackColor = System.Drawing.Color.Transparent;
            this.flpPayMain.Location = new System.Drawing.Point(1, 3);
            this.flpPayMain.Name = "flpPayMain";
            this.flpPayMain.Size = new System.Drawing.Size(765, 529);
            this.flpPayMain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.lbVIPSum);
            this.panel1.Controls.Add(this.lbviphj);
            this.panel1.Controls.Add(this.pbxPay);
            this.panel1.Controls.Add(this.lbSumRmb);
            this.panel1.Controls.Add(this.lbsumhj);
            this.panel1.Location = new System.Drawing.Point(2, 538);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 95);
            this.panel1.TabIndex = 1;
            // 
            // lbVIPSum
            // 
            this.lbVIPSum.AutoSize = true;
            this.lbVIPSum.Font = new System.Drawing.Font("华文琥珀", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVIPSum.ForeColor = System.Drawing.Color.Red;
            this.lbVIPSum.Location = new System.Drawing.Point(78, 10);
            this.lbVIPSum.Name = "lbVIPSum";
            this.lbVIPSum.Size = new System.Drawing.Size(35, 36);
            this.lbVIPSum.TabIndex = 2;
            this.lbVIPSum.Text = "0";
            // 
            // lbviphj
            // 
            this.lbviphj.AutoSize = true;
            this.lbviphj.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbviphj.ForeColor = System.Drawing.Color.Red;
            this.lbviphj.Location = new System.Drawing.Point(3, 15);
            this.lbviphj.Name = "lbviphj";
            this.lbviphj.Size = new System.Drawing.Size(84, 25);
            this.lbviphj.TabIndex = 3;
            this.lbviphj.Text = "合计：";
            // 
            // pbxPay
            // 
            this.pbxPay.BackColor = System.Drawing.Color.Transparent;
            this.pbxPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPay.Image = ((System.Drawing.Image)(resources.GetObject("pbxPay.Image")));
            this.pbxPay.Location = new System.Drawing.Point(613, 12);
            this.pbxPay.Name = "pbxPay";
            this.pbxPay.Size = new System.Drawing.Size(151, 71);
            this.pbxPay.TabIndex = 1;
            this.pbxPay.TabStop = false;
            this.pbxPay.Click += new System.EventHandler(this.pbxPay_Click);
            this.pbxPay.MouseLeave += new System.EventHandler(this.pbxPay_MouseLeave);
            this.pbxPay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxPay_MouseMove);
            // 
            // lbSumRmb
            // 
            this.lbSumRmb.AutoSize = true;
            this.lbSumRmb.Font = new System.Drawing.Font("华文琥珀", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSumRmb.ForeColor = System.Drawing.Color.Orange;
            this.lbSumRmb.Location = new System.Drawing.Point(77, 51);
            this.lbSumRmb.Name = "lbSumRmb";
            this.lbSumRmb.Size = new System.Drawing.Size(35, 36);
            this.lbSumRmb.TabIndex = 0;
            this.lbSumRmb.Text = "0";
            // 
            // lbsumhj
            // 
            this.lbsumhj.AutoSize = true;
            this.lbsumhj.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbsumhj.ForeColor = System.Drawing.Color.Orange;
            this.lbsumhj.Location = new System.Drawing.Point(3, 58);
            this.lbsumhj.Name = "lbsumhj";
            this.lbsumhj.Size = new System.Drawing.Size(84, 25);
            this.lbsumhj.TabIndex = 0;
            this.lbsumhj.Text = "合计：";
            // 
            // FrmPay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpPayMain);
            this.Name = "FrmPay";
            this.Size = new System.Drawing.Size(772, 636);
            this.Load += new System.EventHandler(this.FrmPay_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.FlowLayoutPanel flpPayMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxPay;
        private System.Windows.Forms.Label lbsumhj;
        public System.Windows.Forms.Label lbSumRmb;
        public System.Windows.Forms.Label lbVIPSum;
        private System.Windows.Forms.Label lbviphj;
    }
}
