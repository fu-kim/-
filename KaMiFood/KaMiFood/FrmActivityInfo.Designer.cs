namespace KaMiFood
{
    partial class FrmActivityInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActivityInfo));
            this.lbActivityName = new System.Windows.Forms.Label();
            this.flpActivityFoodInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSumRMB = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxAddOrder = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // lbActivityName
            // 
            this.lbActivityName.AutoSize = true;
            this.lbActivityName.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbActivityName.ForeColor = System.Drawing.Color.Orange;
            this.lbActivityName.Location = new System.Drawing.Point(399, 12);
            this.lbActivityName.Name = "lbActivityName";
            this.lbActivityName.Size = new System.Drawing.Size(69, 30);
            this.lbActivityName.TabIndex = 0;
            this.lbActivityName.Text = "XXXX";
            // 
            // flpActivityFoodInfo
            // 
            this.flpActivityFoodInfo.AutoScroll = true;
            this.flpActivityFoodInfo.Location = new System.Drawing.Point(3, 55);
            this.flpActivityFoodInfo.Name = "flpActivityFoodInfo";
            this.flpActivityFoodInfo.Size = new System.Drawing.Size(753, 485);
            this.flpActivityFoodInfo.TabIndex = 1;
            // 
            // lbSumRMB
            // 
            this.lbSumRMB.AutoSize = true;
            this.lbSumRMB.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSumRMB.ForeColor = System.Drawing.Color.Orange;
            this.lbSumRMB.Location = new System.Drawing.Point(265, 572);
            this.lbSumRMB.Name = "lbSumRMB";
            this.lbSumRMB.Size = new System.Drawing.Size(95, 30);
            this.lbSumRMB.TabIndex = 2;
            this.lbSumRMB.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(109, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "套餐价格：";
            // 
            // pbxAddOrder
            // 
            this.pbxAddOrder.BackColor = System.Drawing.Color.Transparent;
            this.pbxAddOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxAddOrder.Image = ((System.Drawing.Image)(resources.GetObject("pbxAddOrder.Image")));
            this.pbxAddOrder.Location = new System.Drawing.Point(524, 544);
            this.pbxAddOrder.Name = "pbxAddOrder";
            this.pbxAddOrder.Size = new System.Drawing.Size(232, 78);
            this.pbxAddOrder.TabIndex = 3;
            this.pbxAddOrder.TabStop = false;
            this.pbxAddOrder.Click += new System.EventHandler(this.pbxAddOrder_Click);
            this.pbxAddOrder.MouseLeave += new System.EventHandler(this.pbxAddOrder_MouseLeave);
            this.pbxAddOrder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxAddOrder_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(235, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "活动名称：";
            // 
            // pbxReturn
            // 
            this.pbxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pbxReturn.Image")));
            this.pbxReturn.Location = new System.Drawing.Point(706, 4);
            this.pbxReturn.Name = "pbxReturn";
            this.pbxReturn.Size = new System.Drawing.Size(50, 45);
            this.pbxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxReturn.TabIndex = 5;
            this.pbxReturn.TabStop = false;
            this.pbxReturn.Click += new System.EventHandler(this.pbxReturn_Click);
            // 
            // FrmActivityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbSumRMB);
            this.Controls.Add(this.pbxReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbxAddOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flpActivityFoodInfo);
            this.Controls.Add(this.lbActivityName);
            this.Name = "FrmActivityInfo";
            this.Size = new System.Drawing.Size(760, 624);
            this.Load += new System.EventHandler(this.FrmActivityInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAddOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpActivityFoodInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxAddOrder;
        public System.Windows.Forms.Label lbActivityName;
        public System.Windows.Forms.Label lbSumRMB;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxReturn;
    }
}
