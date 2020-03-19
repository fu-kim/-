namespace AddFood
{
    partial class FrmTableInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTableInfo));
            this.pbxTableType = new System.Windows.Forms.PictureBox();
            this.cmMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改餐桌状态ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKongZhuo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDaSao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWeiXiu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiZanYong = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDianCai = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYesService = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPay = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReminder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTableId = new System.Windows.Forms.Label();
            this.plBgColor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTableType)).BeginInit();
            this.cmMain.SuspendLayout();
            this.plBgColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxTableType
            // 
            this.pbxTableType.BackColor = System.Drawing.Color.Silver;
            this.pbxTableType.ContextMenuStrip = this.cmMain;
            this.pbxTableType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxTableType.Location = new System.Drawing.Point(3, 37);
            this.pbxTableType.Name = "pbxTableType";
            this.pbxTableType.Size = new System.Drawing.Size(173, 115);
            this.pbxTableType.TabIndex = 0;
            this.pbxTableType.TabStop = false;
            this.pbxTableType.Click += new System.EventHandler(this.pbxTableType_Click);
            this.pbxTableType.MouseLeave += new System.EventHandler(this.plBgColor_MouseLeave);
            this.pbxTableType.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plBgColor_MouseMove);
            // 
            // cmMain
            // 
            this.cmMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改餐桌状态ToolStripMenuItem,
            this.tsmiYesService,
            this.tsmiPay,
            this.tsmiReminder,
            this.tsmiRefresh});
            this.cmMain.Name = "cmMain";
            this.cmMain.Size = new System.Drawing.Size(149, 114);
            // 
            // 修改餐桌状态ToolStripMenuItem
            // 
            this.修改餐桌状态ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKongZhuo,
            this.tsmiDaSao,
            this.tsmiWeiXiu,
            this.tsmiZanYong,
            this.tsmiDianCai});
            this.修改餐桌状态ToolStripMenuItem.Name = "修改餐桌状态ToolStripMenuItem";
            this.修改餐桌状态ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.修改餐桌状态ToolStripMenuItem.Text = "修改餐桌状态";
            // 
            // tsmiKongZhuo
            // 
            this.tsmiKongZhuo.Name = "tsmiKongZhuo";
            this.tsmiKongZhuo.Size = new System.Drawing.Size(112, 22);
            this.tsmiKongZhuo.Text = "空桌";
            this.tsmiKongZhuo.Click += new System.EventHandler(this.tsmiKongZhuo_Click);
            // 
            // tsmiDaSao
            // 
            this.tsmiDaSao.Name = "tsmiDaSao";
            this.tsmiDaSao.Size = new System.Drawing.Size(112, 22);
            this.tsmiDaSao.Text = "打扫中";
            this.tsmiDaSao.Click += new System.EventHandler(this.tsmiDaSao_Click);
            // 
            // tsmiWeiXiu
            // 
            this.tsmiWeiXiu.Name = "tsmiWeiXiu";
            this.tsmiWeiXiu.Size = new System.Drawing.Size(112, 22);
            this.tsmiWeiXiu.Text = "维修中";
            this.tsmiWeiXiu.Click += new System.EventHandler(this.tsmiWeiXiu_Click);
            // 
            // tsmiZanYong
            // 
            this.tsmiZanYong.Name = "tsmiZanYong";
            this.tsmiZanYong.Size = new System.Drawing.Size(112, 22);
            this.tsmiZanYong.Text = "占用中";
            this.tsmiZanYong.Click += new System.EventHandler(this.tsmiZanYong_Click);
            // 
            // tsmiDianCai
            // 
            this.tsmiDianCai.Name = "tsmiDianCai";
            this.tsmiDianCai.Size = new System.Drawing.Size(112, 22);
            this.tsmiDianCai.Text = "点菜中";
            this.tsmiDianCai.Click += new System.EventHandler(this.tsmiDianCai_Click);
            // 
            // tsmiYesService
            // 
            this.tsmiYesService.Name = "tsmiYesService";
            this.tsmiYesService.Size = new System.Drawing.Size(148, 22);
            this.tsmiYesService.Text = "已服务";
            this.tsmiYesService.Click += new System.EventHandler(this.tsmiYesService_Click);
            // 
            // tsmiPay
            // 
            this.tsmiPay.Name = "tsmiPay";
            this.tsmiPay.Size = new System.Drawing.Size(148, 22);
            this.tsmiPay.Text = "已结账";
            this.tsmiPay.Click += new System.EventHandler(this.tsmiPay_Click);
            // 
            // tsmiReminder
            // 
            this.tsmiReminder.Name = "tsmiReminder";
            this.tsmiReminder.Size = new System.Drawing.Size(148, 22);
            this.tsmiReminder.Text = "已催单";
            this.tsmiReminder.Click += new System.EventHandler(this.tsmiYesService_Click);
            // 
            // tsmiRefresh
            // 
            this.tsmiRefresh.Name = "tsmiRefresh";
            this.tsmiRefresh.Size = new System.Drawing.Size(148, 22);
            this.tsmiRefresh.Text = "刷新数据";
            this.tsmiRefresh.Click += new System.EventHandler(this.tsmiRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文行楷", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "号桌";
            this.label1.MouseLeave += new System.EventHandler(this.plBgColor_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plBgColor_MouseMove);
            // 
            // lbTableId
            // 
            this.lbTableId.AutoSize = true;
            this.lbTableId.Font = new System.Drawing.Font("华文行楷", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTableId.ForeColor = System.Drawing.Color.White;
            this.lbTableId.Location = new System.Drawing.Point(10, 4);
            this.lbTableId.Name = "lbTableId";
            this.lbTableId.Size = new System.Drawing.Size(24, 33);
            this.lbTableId.TabIndex = 2;
            this.lbTableId.Text = "1";
            this.lbTableId.MouseLeave += new System.EventHandler(this.plBgColor_MouseLeave);
            this.lbTableId.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plBgColor_MouseMove);
            // 
            // plBgColor
            // 
            this.plBgColor.BackColor = System.Drawing.Color.Transparent;
            this.plBgColor.Controls.Add(this.lbTableId);
            this.plBgColor.Controls.Add(this.pbxTableType);
            this.plBgColor.Controls.Add(this.label1);
            this.plBgColor.Location = new System.Drawing.Point(0, 0);
            this.plBgColor.Name = "plBgColor";
            this.plBgColor.Size = new System.Drawing.Size(180, 156);
            this.plBgColor.TabIndex = 3;
            this.plBgColor.Paint += new System.Windows.Forms.PaintEventHandler(this.plBgColor_Paint);
            this.plBgColor.MouseLeave += new System.EventHandler(this.plBgColor_MouseLeave);
            this.plBgColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.plBgColor_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmTableInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.plBgColor);
            this.Name = "FrmTableInfo";
            this.Size = new System.Drawing.Size(180, 156);
            this.Load += new System.EventHandler(this.FrmTableInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTableType)).EndInit();
            this.cmMain.ResumeLayout(false);
            this.plBgColor.ResumeLayout(false);
            this.plBgColor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbTableId;
        public System.Windows.Forms.PictureBox pbxTableType;
        private System.Windows.Forms.Panel plBgColor;
        private System.Windows.Forms.ContextMenuStrip cmMain;
        private System.Windows.Forms.ToolStripMenuItem 修改餐桌状态ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiYesService;
        private System.Windows.Forms.ToolStripMenuItem tsmiRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem tsmiKongZhuo;
        private System.Windows.Forms.ToolStripMenuItem tsmiDaSao;
        private System.Windows.Forms.ToolStripMenuItem tsmiWeiXiu;
        private System.Windows.Forms.ToolStripMenuItem tsmiZanYong;
        private System.Windows.Forms.ToolStripMenuItem tsmiDianCai;
        private System.Windows.Forms.ToolStripMenuItem tsmiPay;
        private System.Windows.Forms.ToolStripMenuItem tsmiReminder;
    }
}
