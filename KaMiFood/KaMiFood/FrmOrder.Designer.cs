namespace KaMiFood
{
    partial class FrmOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            this.flpPayMain = new System.Windows.Forms.FlowLayoutPanel();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.pbxPay = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSumRmb = new System.Windows.Forms.Label();
            this.lbsumhj = new System.Windows.Forms.Label();
            this.lbVIPSum = new System.Windows.Forms.Label();
            this.lbviphj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPay)).BeginInit();
            this.SuspendLayout();
            // 
            // flpPayMain
            // 
            this.flpPayMain.AutoScroll = true;
            this.flpPayMain.BackColor = System.Drawing.Color.Linen;
            this.flpPayMain.Location = new System.Drawing.Point(4, 46);
            this.flpPayMain.Name = "flpPayMain";
            this.flpPayMain.Size = new System.Drawing.Size(494, 439);
            this.flpPayMain.TabIndex = 0;
            // 
            // pbxClose
            // 
            this.pbxClose.BackColor = System.Drawing.Color.Transparent;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(456, 5);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(35, 35);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxClose.TabIndex = 1;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // pbxPay
            // 
            this.pbxPay.BackColor = System.Drawing.Color.Transparent;
            this.pbxPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxPay.Image = ((System.Drawing.Image)(resources.GetObject("pbxPay.Image")));
            this.pbxPay.Location = new System.Drawing.Point(345, 512);
            this.pbxPay.Name = "pbxPay";
            this.pbxPay.Size = new System.Drawing.Size(153, 56);
            this.pbxPay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPay.TabIndex = 2;
            this.pbxPay.TabStop = false;
            this.pbxPay.Click += new System.EventHandler(this.pbxPay_Click);
            this.pbxPay.MouseLeave += new System.EventHandler(this.pbxPay_MouseLeave);
            this.pbxPay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxPay_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "订单";
            // 
            // lbSumRmb
            // 
            this.lbSumRmb.AutoSize = true;
            this.lbSumRmb.Font = new System.Drawing.Font("华文琥珀", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSumRmb.ForeColor = System.Drawing.Color.Orange;
            this.lbSumRmb.Location = new System.Drawing.Point(92, 537);
            this.lbSumRmb.Name = "lbSumRmb";
            this.lbSumRmb.Size = new System.Drawing.Size(35, 36);
            this.lbSumRmb.TabIndex = 5;
            this.lbSumRmb.Text = "0";
            // 
            // lbsumhj
            // 
            this.lbsumhj.AutoSize = true;
            this.lbsumhj.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbsumhj.ForeColor = System.Drawing.Color.Orange;
            this.lbsumhj.Location = new System.Drawing.Point(19, 543);
            this.lbsumhj.Name = "lbsumhj";
            this.lbsumhj.Size = new System.Drawing.Size(84, 25);
            this.lbsumhj.TabIndex = 6;
            this.lbsumhj.Text = "合计：";
            // 
            // lbVIPSum
            // 
            this.lbVIPSum.AutoSize = true;
            this.lbVIPSum.BackColor = System.Drawing.Color.Transparent;
            this.lbVIPSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbVIPSum.Font = new System.Drawing.Font("华文琥珀", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbVIPSum.ForeColor = System.Drawing.Color.Gold;
            this.lbVIPSum.Location = new System.Drawing.Point(92, 497);
            this.lbVIPSum.Name = "lbVIPSum";
            this.lbVIPSum.Size = new System.Drawing.Size(35, 36);
            this.lbVIPSum.TabIndex = 7;
            this.lbVIPSum.Text = "0";
            // 
            // lbviphj
            // 
            this.lbviphj.AutoSize = true;
            this.lbviphj.BackColor = System.Drawing.Color.Transparent;
            this.lbviphj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbviphj.Font = new System.Drawing.Font("华文琥珀", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbviphj.ForeColor = System.Drawing.Color.Gold;
            this.lbviphj.Location = new System.Drawing.Point(19, 503);
            this.lbviphj.Name = "lbviphj";
            this.lbviphj.Size = new System.Drawing.Size(84, 25);
            this.lbviphj.TabIndex = 8;
            this.lbviphj.Text = "合计：";
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(503, 582);
            this.Controls.Add(this.lbVIPSum);
            this.Controls.Add(this.lbviphj);
            this.Controls.Add(this.lbSumRmb);
            this.Controls.Add(this.lbsumhj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxPay);
            this.Controls.Add(this.pbxClose);
            this.Controls.Add(this.flpPayMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrder";
            this.Load += new System.EventHandler(this.FrmOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpPayMain;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.PictureBox pbxPay;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbSumRmb;
        private System.Windows.Forms.Label lbsumhj;
        public System.Windows.Forms.Label lbVIPSum;
        private System.Windows.Forms.Label lbviphj;
    }
}