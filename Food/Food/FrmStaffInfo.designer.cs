namespace Food
{
    partial class FrmStaffInfo
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
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiFindStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddStaff = new System.Windows.Forms.ToolStripMenuItem();
            this.plStaffInfo = new System.Windows.Forms.Panel();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.clStaffId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStaffPasd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStaffSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStaffAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStaffBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStaffAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStaffTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStaffCardId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEontact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clclEontactTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStaffPot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.cmsMain.SuspendLayout();
            this.plStaffInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFindStaff,
            this.tsmiAddStaff});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(173, 48);
            // 
            // tsmiFindStaff
            // 
            this.tsmiFindStaff.Name = "tsmiFindStaff";
            this.tsmiFindStaff.Size = new System.Drawing.Size(172, 22);
            this.tsmiFindStaff.Text = "查看员工个人信息";
            this.tsmiFindStaff.Click += new System.EventHandler(this.tsmiFindStaff_Click);
            // 
            // tsmiAddStaff
            // 
            this.tsmiAddStaff.Name = "tsmiAddStaff";
            this.tsmiAddStaff.Size = new System.Drawing.Size(172, 22);
            this.tsmiAddStaff.Text = "添加员工";
            this.tsmiAddStaff.Click += new System.EventHandler(this.tsmiAddStaff_Click);
            // 
            // plStaffInfo
            // 
            this.plStaffInfo.Controls.Add(this.dgvMain);
            this.plStaffInfo.Controls.Add(this.shapeContainer1);
            this.plStaffInfo.Location = new System.Drawing.Point(3, 3);
            this.plStaffInfo.Name = "plStaffInfo";
            this.plStaffInfo.Size = new System.Drawing.Size(734, 577);
            this.plStaffInfo.TabIndex = 5;
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clStaffId,
            this.clStaffPasd,
            this.clStaffName,
            this.clStaffSex,
            this.clStaffAge,
            this.clStaffBirthday,
            this.clStaffAddress,
            this.clStaffTel,
            this.clStaffCardId,
            this.clEontact,
            this.clclEontactTel,
            this.clTypeId,
            this.clStaffPot});
            this.dgvMain.ContextMenuStrip = this.cmsMain;
            this.dgvMain.Location = new System.Drawing.Point(3, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(728, 574);
            this.dgvMain.TabIndex = 3;
            // 
            // clStaffId
            // 
            this.clStaffId.DataPropertyName = "StaffId";
            this.clStaffId.FillWeight = 105.1095F;
            this.clStaffId.HeaderText = "工号";
            this.clStaffId.Name = "clStaffId";
            this.clStaffId.ReadOnly = true;
            this.clStaffId.Width = 60;
            // 
            // clStaffPasd
            // 
            this.clStaffPasd.DataPropertyName = "StaffPasd";
            this.clStaffPasd.HeaderText = "密码";
            this.clStaffPasd.Name = "clStaffPasd";
            this.clStaffPasd.ReadOnly = true;
            this.clStaffPasd.Visible = false;
            // 
            // clStaffName
            // 
            this.clStaffName.DataPropertyName = "StaffName";
            this.clStaffName.FillWeight = 99.3306F;
            this.clStaffName.HeaderText = "姓名";
            this.clStaffName.Name = "clStaffName";
            this.clStaffName.ReadOnly = true;
            this.clStaffName.Width = 57;
            // 
            // clStaffSex
            // 
            this.clStaffSex.DataPropertyName = "StaffSex";
            this.clStaffSex.FillWeight = 97.42503F;
            this.clStaffSex.HeaderText = "性别";
            this.clStaffSex.Name = "clStaffSex";
            this.clStaffSex.ReadOnly = true;
            this.clStaffSex.Width = 56;
            // 
            // clStaffAge
            // 
            this.clStaffAge.DataPropertyName = "StaffAge";
            this.clStaffAge.FillWeight = 94.0028F;
            this.clStaffAge.HeaderText = "年龄";
            this.clStaffAge.Name = "clStaffAge";
            this.clStaffAge.ReadOnly = true;
            this.clStaffAge.Width = 54;
            // 
            // clStaffBirthday
            // 
            this.clStaffBirthday.DataPropertyName = "StaffBirthday";
            this.clStaffBirthday.FillWeight = 121.1738F;
            this.clStaffBirthday.HeaderText = "出生日期";
            this.clStaffBirthday.Name = "clStaffBirthday";
            this.clStaffBirthday.ReadOnly = true;
            this.clStaffBirthday.Width = 80;
            // 
            // clStaffAddress
            // 
            this.clStaffAddress.DataPropertyName = "StaffAddress";
            this.clStaffAddress.FillWeight = 85.37791F;
            this.clStaffAddress.HeaderText = "住址";
            this.clStaffAddress.Name = "clStaffAddress";
            this.clStaffAddress.ReadOnly = true;
            this.clStaffAddress.Width = 54;
            // 
            // clStaffTel
            // 
            this.clStaffTel.DataPropertyName = "StaffTel";
            this.clStaffTel.FillWeight = 117.5988F;
            this.clStaffTel.HeaderText = "联系电话";
            this.clStaffTel.Name = "clStaffTel";
            this.clStaffTel.ReadOnly = true;
            this.clStaffTel.Width = 90;
            // 
            // clStaffCardId
            // 
            this.clStaffCardId.DataPropertyName = "StaffCardId";
            this.clStaffCardId.FillWeight = 155.6433F;
            this.clStaffCardId.HeaderText = "身份证";
            this.clStaffCardId.Name = "clStaffCardId";
            this.clStaffCardId.ReadOnly = true;
            // 
            // clEontact
            // 
            this.clEontact.DataPropertyName = "EContact";
            this.clEontact.FillWeight = 103.95F;
            this.clEontact.HeaderText = "紧急联系人";
            this.clEontact.Name = "clEontact";
            this.clEontact.ReadOnly = true;
            this.clEontact.Width = 90;
            // 
            // clclEontactTel
            // 
            this.clclEontactTel.DataPropertyName = "EContactTel";
            this.clclEontactTel.FillWeight = 97.95934F;
            this.clclEontactTel.HeaderText = "联系人电话";
            this.clclEontactTel.Name = "clclEontactTel";
            this.clclEontactTel.ReadOnly = true;
            this.clclEontactTel.Width = 90;
            // 
            // clTypeId
            // 
            this.clTypeId.DataPropertyName = "TypeId";
            this.clTypeId.FillWeight = 60.80659F;
            this.clTypeId.HeaderText = "职位";
            this.clTypeId.Name = "clTypeId";
            this.clTypeId.ReadOnly = true;
            this.clTypeId.Width = 35;
            // 
            // clStaffPot
            // 
            this.clStaffPot.DataPropertyName = "StaffPot";
            this.clStaffPot.FillWeight = 61.62244F;
            this.clStaffPot.HeaderText = "照片";
            this.clStaffPot.Name = "clStaffPot";
            this.clStaffPot.ReadOnly = true;
            this.clStaffPot.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clStaffPot.Width = 35;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(734, 577);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 737;
            this.lineShape1.X2 = 738;
            this.lineShape1.Y1 = -128;
            this.lineShape1.Y2 = -4;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 249;
            this.lineShape2.X2 = 237;
            this.lineShape2.Y1 = -100;
            this.lineShape2.Y2 = -33;
            // 
            // FrmStaffInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.plStaffInfo);
            this.Name = "FrmStaffInfo";
            this.Size = new System.Drawing.Size(737, 583);
            this.Load += new System.EventHandler(this.FrmStaffInfo_Load);
            this.cmsMain.ResumeLayout(false);
            this.plStaffInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFindStaff;
        private System.Windows.Forms.Panel plStaffInfo;
        public System.Windows.Forms.DataGridView dgvMain;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStaffId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStaffPasd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStaffSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStaffAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStaffBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStaffAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStaffTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStaffCardId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEontact;
        private System.Windows.Forms.DataGridViewTextBoxColumn clclEontactTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStaffPot;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddStaff;
    }
}
