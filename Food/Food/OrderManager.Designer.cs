namespace AddFood
{
    partial class OrderManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManager));
            this.sDgvMain = new CCWin.SkinControl.SkinDataGridView();
            this.clOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIsPays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCMSmain = new CCWin.SkinControl.SkinContextMenuStrip();
            this.tsmiFindOrderInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDaoChu = new System.Windows.Forms.ToolStripMenuItem();
            this.savaExcel = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnFindTT = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.sdtpDateOne = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.sDgvMain)).BeginInit();
            this.sCMSmain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // sDgvMain
            // 
            this.sDgvMain.AllowUserToResizeColumns = false;
            this.sDgvMain.AllowUserToResizeRows = false;
            this.sDgvMain.AlternatingCellBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.sDgvMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.sDgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sDgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sDgvMain.BackgroundColor = System.Drawing.Color.White;
            this.sDgvMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sDgvMain.ColumnFont = null;
            this.sDgvMain.ColumnForeColor = System.Drawing.Color.Black;
            this.sDgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sDgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.sDgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sDgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clOrderId,
            this.clMoney,
            this.clTime,
            this.clIsPays,
            this.clRemark,
            this.Column1});
            this.sDgvMain.ColumnSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sDgvMain.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.sDgvMain.ContextMenuStrip = this.sCMSmain;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sDgvMain.DefaultCellStyle = dataGridViewCellStyle4;
            this.sDgvMain.EnableHeadersVisualStyles = false;
            this.sDgvMain.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sDgvMain.GridColor = System.Drawing.Color.CadetBlue;
            this.sDgvMain.HeadFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sDgvMain.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.sDgvMain.LineNumberForeColor = System.Drawing.Color.Black;
            this.sDgvMain.Location = new System.Drawing.Point(3, 3);
            this.sDgvMain.MouseCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.sDgvMain.Name = "sDgvMain";
            this.sDgvMain.ReadOnly = true;
            this.sDgvMain.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sDgvMain.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.sDgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.sDgvMain.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.sDgvMain.RowTemplate.Height = 23;
            this.sDgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sDgvMain.Size = new System.Drawing.Size(983, 347);
            this.sDgvMain.SkinGridColor = System.Drawing.Color.CadetBlue;
            this.sDgvMain.TabIndex = 6;
            this.sDgvMain.TitleBack = null;
            this.sDgvMain.TitleBackColorBegin = System.Drawing.Color.DarkGray;
            this.sDgvMain.TitleBackColorEnd = System.Drawing.Color.White;
            // 
            // clOrderId
            // 
            this.clOrderId.DataPropertyName = "OrderId";
            this.clOrderId.HeaderText = "订单号";
            this.clOrderId.Name = "clOrderId";
            this.clOrderId.ReadOnly = true;
            // 
            // clMoney
            // 
            this.clMoney.DataPropertyName = "Price";
            this.clMoney.HeaderText = "订单总价";
            this.clMoney.Name = "clMoney";
            this.clMoney.ReadOnly = true;
            // 
            // clTime
            // 
            this.clTime.DataPropertyName = "PayTime";
            this.clTime.HeaderText = "下单时间";
            this.clTime.Name = "clTime";
            this.clTime.ReadOnly = true;
            // 
            // clIsPays
            // 
            this.clIsPays.DataPropertyName = "IsPay";
            this.clIsPays.HeaderText = "是否支付";
            this.clIsPays.Name = "clIsPays";
            this.clIsPays.ReadOnly = true;
            // 
            // clRemark
            // 
            this.clRemark.DataPropertyName = "Remarks";
            this.clRemark.HeaderText = "备注";
            this.clRemark.Name = "clRemark";
            this.clRemark.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TableId";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "桌号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // sCMSmain
            // 
            this.sCMSmain.Arrow = System.Drawing.Color.Black;
            this.sCMSmain.Back = System.Drawing.Color.White;
            this.sCMSmain.BackRadius = 4;
            this.sCMSmain.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.sCMSmain.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.sCMSmain.Fore = System.Drawing.Color.Black;
            this.sCMSmain.HoverFore = System.Drawing.Color.White;
            this.sCMSmain.ItemAnamorphosis = true;
            this.sCMSmain.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.sCMSmain.ItemBorderShow = true;
            this.sCMSmain.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.sCMSmain.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.sCMSmain.ItemRadius = 4;
            this.sCMSmain.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.sCMSmain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFindOrderInfo,
            this.tsmiDaoChu});
            this.sCMSmain.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.sCMSmain.Name = "sCMSmain";
            this.sCMSmain.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.sCMSmain.Size = new System.Drawing.Size(149, 48);
            this.sCMSmain.SkinAllColor = true;
            this.sCMSmain.TitleAnamorphosis = true;
            this.sCMSmain.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.sCMSmain.TitleRadius = 4;
            this.sCMSmain.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // tsmiFindOrderInfo
            // 
            this.tsmiFindOrderInfo.Name = "tsmiFindOrderInfo";
            this.tsmiFindOrderInfo.Size = new System.Drawing.Size(148, 22);
            this.tsmiFindOrderInfo.Text = "查看订单信息";
            this.tsmiFindOrderInfo.Click += new System.EventHandler(this.tsmiFindOrderInfo_Click);
            // 
            // tsmiDaoChu
            // 
            this.tsmiDaoChu.Name = "tsmiDaoChu";
            this.tsmiDaoChu.Size = new System.Drawing.Size(148, 22);
            this.tsmiDaoChu.Text = "导出订单表";
            this.tsmiDaoChu.Click += new System.EventHandler(this.tsmiDaoChu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.txtTable);
            this.groupBox1.Controls.Add(this.txtOrderId);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(271, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(328, 184);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // btnFind
            // 
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFind.Location = new System.Drawing.Point(250, 150);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 31);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "查找";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtTable
            // 
            this.txtTable.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTable.ForeColor = System.Drawing.Color.Gray;
            this.txtTable.Location = new System.Drawing.Point(6, 45);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(90, 29);
            this.txtTable.TabIndex = 2;
            this.txtTable.Text = "桌号";
            this.txtTable.Click += new System.EventHandler(this.txtTable_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOrderId.ForeColor = System.Drawing.Color.Gray;
            this.txtOrderId.Location = new System.Drawing.Point(6, 103);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.Size = new System.Drawing.Size(167, 29);
            this.txtOrderId.TabIndex = 3;
            this.txtOrderId.Text = "订单号";
            this.txtOrderId.Click += new System.EventHandler(this.txtOrderId_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.sdtpDateOne);
            this.groupBox3.Controls.Add(this.btnFindTT);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(168, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(544, 184);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询";
            // 
            // btnFindTT
            // 
            this.btnFindTT.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFindTT.Location = new System.Drawing.Point(111, 127);
            this.btnFindTT.Name = "btnFindTT";
            this.btnFindTT.Size = new System.Drawing.Size(75, 31);
            this.btnFindTT.TabIndex = 1;
            this.btnFindTT.Text = "查找";
            this.btnFindTT.UseVisualStyleBackColor = true;
            this.btnFindTT.Click += new System.EventHandler(this.btnFindTT_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.Location = new System.Drawing.Point(58, 365);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(870, 240);
            this.tabControl1.TabIndex = 14;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.pictureBox6);
            this.tabPage1.Controls.Add(this.pictureBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(862, 210);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "单个日期";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(718, 70);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(138, 137);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 67);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(138, 137);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.pictureBox5);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(862, 210);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "桌号订单";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(723, 72);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(138, 137);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1, 72);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(138, 137);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // sdtpDateOne
            // 
            this.sdtpDateOne.Location = new System.Drawing.Point(111, 65);
            this.sdtpDateOne.Name = "sdtpDateOne";
            this.sdtpDateOne.Size = new System.Drawing.Size(261, 29);
            this.sdtpDateOne.TabIndex = 12;
            // 
            // OrderManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.sDgvMain);
            this.Name = "OrderManager";
            this.Size = new System.Drawing.Size(989, 622);
            this.Load += new System.EventHandler(this.OrderManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sDgvMain)).EndInit();
            this.sCMSmain.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinDataGridView sDgvMain;
        private CCWin.SkinControl.SkinContextMenuStrip sCMSmain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFindOrderInfo;
        private System.Windows.Forms.SaveFileDialog savaExcel;
        private System.Windows.Forms.ToolStripMenuItem tsmiDaoChu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnFindTT;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIsPays;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRemark;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DateTimePicker sdtpDateOne;
    }
}
