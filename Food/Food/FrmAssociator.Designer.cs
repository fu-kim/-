namespace Food
{
    partial class FrmAssociator
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAssociator));
            this.SdgvMemberInfo = new CCWin.SkinControl.SkinDataGridView();
            this.clMemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMemTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMemPwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMemSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMemAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMemBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbtnAdd = new CCWin.SkinControl.SkinButton();
            this.sbtnUpdate = new CCWin.SkinControl.SkinButton();
            this.sbtnFind = new CCWin.SkinControl.SkinButton();
            this.sbtnDelete = new CCWin.SkinControl.SkinButton();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.sdtpOpenCard = new System.Windows.Forms.DateTimePicker();
            this.scboSex = new CCWin.SkinControl.SkinComboBox();
            this.stxtMemberAge = new CCWin.SkinControl.SkinTextBox();
            this.stxtMemberPwd = new CCWin.SkinControl.SkinTextBox();
            this.stxtMemberName = new CCWin.SkinControl.SkinTextBox();
            this.stxtMemberTel = new CCWin.SkinControl.SkinTextBox();
            this.stxtMemberId = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SdgvMemberInfo)).BeginInit();
            this.skinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SdgvMemberInfo
            // 
            this.SdgvMemberInfo.AlternatingCellBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.SdgvMemberInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SdgvMemberInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SdgvMemberInfo.BackgroundColor = System.Drawing.Color.White;
            this.SdgvMemberInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SdgvMemberInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.SdgvMemberInfo.ColumnFont = null;
            this.SdgvMemberInfo.ColumnForeColor = System.Drawing.Color.Black;
            this.SdgvMemberInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SdgvMemberInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SdgvMemberInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SdgvMemberInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMemberId,
            this.clMemName,
            this.clMemTel,
            this.clMemPwd,
            this.clMemSex,
            this.clMemAge,
            this.clMemBirthday});
            this.SdgvMemberInfo.ColumnSelectBackColor = System.Drawing.Color.Khaki;
            this.SdgvMemberInfo.ColumnSelectForeColor = System.Drawing.Color.Black;
            this.SdgvMemberInfo.DefaultCellBackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SdgvMemberInfo.DefaultCellStyle = dataGridViewCellStyle3;
            this.SdgvMemberInfo.EnableHeadersVisualStyles = false;
            this.SdgvMemberInfo.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.SdgvMemberInfo.HeadFont = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SdgvMemberInfo.HeadForeColor = System.Drawing.Color.Black;
            this.SdgvMemberInfo.HeadSelectBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SdgvMemberInfo.HeadSelectForeColor = System.Drawing.Color.Black;
            this.SdgvMemberInfo.LineNumberForeColor = System.Drawing.Color.LightSlateGray;
            this.SdgvMemberInfo.Location = new System.Drawing.Point(76, 52);
            this.SdgvMemberInfo.MouseCellBackColor = System.Drawing.Color.Khaki;
            this.SdgvMemberInfo.Name = "SdgvMemberInfo";
            this.SdgvMemberInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SdgvMemberInfo.RowHeadersVisible = false;
            this.SdgvMemberInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.SdgvMemberInfo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.SdgvMemberInfo.RowTemplate.Height = 23;
            this.SdgvMemberInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SdgvMemberInfo.Size = new System.Drawing.Size(840, 307);
            this.SdgvMemberInfo.SkinGridColor = System.Drawing.SystemColors.ButtonShadow;
            this.SdgvMemberInfo.TabIndex = 0;
            this.SdgvMemberInfo.TitleBack = null;
            this.SdgvMemberInfo.TitleBackColorBegin = System.Drawing.Color.NavajoWhite;
            this.SdgvMemberInfo.TitleBackColorEnd = System.Drawing.Color.Goldenrod;
            this.SdgvMemberInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SdgvMemberInfo_CellClick);
            // 
            // clMemberId
            // 
            this.clMemberId.DataPropertyName = "MemberId";
            this.clMemberId.HeaderText = "会员编号";
            this.clMemberId.Name = "clMemberId";
            // 
            // clMemName
            // 
            this.clMemName.DataPropertyName = "MemName";
            this.clMemName.HeaderText = "会员名称";
            this.clMemName.Name = "clMemName";
            // 
            // clMemTel
            // 
            this.clMemTel.DataPropertyName = "MemTel";
            this.clMemTel.HeaderText = "会员电话";
            this.clMemTel.Name = "clMemTel";
            // 
            // clMemPwd
            // 
            this.clMemPwd.DataPropertyName = "MemPwd";
            this.clMemPwd.HeaderText = "会员密码";
            this.clMemPwd.Name = "clMemPwd";
            // 
            // clMemSex
            // 
            this.clMemSex.DataPropertyName = "MemSex";
            this.clMemSex.HeaderText = "性别";
            this.clMemSex.Name = "clMemSex";
            // 
            // clMemAge
            // 
            this.clMemAge.DataPropertyName = "MemAge";
            this.clMemAge.HeaderText = "年龄";
            this.clMemAge.Name = "clMemAge";
            // 
            // clMemBirthday
            // 
            this.clMemBirthday.DataPropertyName = "MemBirthday";
            this.clMemBirthday.HeaderText = "办卡时间";
            this.clMemBirthday.Name = "clMemBirthday";
            // 
            // sbtnAdd
            // 
            this.sbtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.sbtnAdd.BaseColor = System.Drawing.Color.Black;
            this.sbtnAdd.BorderColor = System.Drawing.Color.Gray;
            this.sbtnAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sbtnAdd.DownBack = null;
            this.sbtnAdd.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sbtnAdd.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtnAdd.ForeColor = System.Drawing.Color.Khaki;
            this.sbtnAdd.Location = new System.Drawing.Point(780, 431);
            this.sbtnAdd.MouseBack = null;
            this.sbtnAdd.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sbtnAdd.Name = "sbtnAdd";
            this.sbtnAdd.NormlBack = null;
            this.sbtnAdd.Size = new System.Drawing.Size(136, 37);
            this.sbtnAdd.TabIndex = 1;
            this.sbtnAdd.Text = "添加会员";
            this.sbtnAdd.UseVisualStyleBackColor = false;
            this.sbtnAdd.Click += new System.EventHandler(this.sbtnAdd_Click);
            // 
            // sbtnUpdate
            // 
            this.sbtnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.sbtnUpdate.BaseColor = System.Drawing.Color.Black;
            this.sbtnUpdate.BorderColor = System.Drawing.Color.Gray;
            this.sbtnUpdate.ControlState = CCWin.SkinClass.ControlState.Hover;
            this.sbtnUpdate.DownBack = null;
            this.sbtnUpdate.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sbtnUpdate.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtnUpdate.ForeColor = System.Drawing.Color.Khaki;
            this.sbtnUpdate.Location = new System.Drawing.Point(780, 485);
            this.sbtnUpdate.MouseBack = null;
            this.sbtnUpdate.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sbtnUpdate.Name = "sbtnUpdate";
            this.sbtnUpdate.NormlBack = null;
            this.sbtnUpdate.Size = new System.Drawing.Size(136, 37);
            this.sbtnUpdate.TabIndex = 2;
            this.sbtnUpdate.Text = "修改会员";
            this.sbtnUpdate.UseVisualStyleBackColor = false;
            this.sbtnUpdate.Click += new System.EventHandler(this.sbtnUpdate_Click);
            // 
            // sbtnFind
            // 
            this.sbtnFind.BackColor = System.Drawing.Color.Transparent;
            this.sbtnFind.BaseColor = System.Drawing.Color.Black;
            this.sbtnFind.BorderColor = System.Drawing.Color.Gray;
            this.sbtnFind.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sbtnFind.DownBack = null;
            this.sbtnFind.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sbtnFind.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtnFind.ForeColor = System.Drawing.Color.Khaki;
            this.sbtnFind.Location = new System.Drawing.Point(780, 377);
            this.sbtnFind.MouseBack = null;
            this.sbtnFind.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sbtnFind.Name = "sbtnFind";
            this.sbtnFind.NormlBack = null;
            this.sbtnFind.Size = new System.Drawing.Size(136, 37);
            this.sbtnFind.TabIndex = 3;
            this.sbtnFind.Text = "查找会员";
            this.sbtnFind.UseVisualStyleBackColor = false;
            this.sbtnFind.Click += new System.EventHandler(this.sbtnFind_Click);
            // 
            // sbtnDelete
            // 
            this.sbtnDelete.BackColor = System.Drawing.Color.Transparent;
            this.sbtnDelete.BaseColor = System.Drawing.Color.Black;
            this.sbtnDelete.BorderColor = System.Drawing.Color.Gray;
            this.sbtnDelete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.sbtnDelete.DownBack = null;
            this.sbtnDelete.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sbtnDelete.Font = new System.Drawing.Font("华文行楷", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sbtnDelete.ForeColor = System.Drawing.Color.Khaki;
            this.sbtnDelete.Location = new System.Drawing.Point(780, 539);
            this.sbtnDelete.MouseBack = null;
            this.sbtnDelete.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sbtnDelete.Name = "sbtnDelete";
            this.sbtnDelete.NormlBack = null;
            this.sbtnDelete.Size = new System.Drawing.Size(136, 37);
            this.sbtnDelete.TabIndex = 4;
            this.sbtnDelete.Text = "删除会员";
            this.sbtnDelete.UseVisualStyleBackColor = false;
            this.sbtnDelete.Click += new System.EventHandler(this.sbtnDelete_Click);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.sdtpOpenCard);
            this.skinPanel1.Controls.Add(this.scboSex);
            this.skinPanel1.Controls.Add(this.stxtMemberAge);
            this.skinPanel1.Controls.Add(this.stxtMemberPwd);
            this.skinPanel1.Controls.Add(this.stxtMemberName);
            this.skinPanel1.Controls.Add(this.stxtMemberTel);
            this.skinPanel1.Controls.Add(this.stxtMemberId);
            this.skinPanel1.Controls.Add(this.skinLabel8);
            this.skinPanel1.Controls.Add(this.skinLabel7);
            this.skinPanel1.Controls.Add(this.skinLabel6);
            this.skinPanel1.Controls.Add(this.skinLabel5);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(76, 367);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(698, 211);
            this.skinPanel1.TabIndex = 5;
            // 
            // sdtpOpenCard
            // 
            this.sdtpOpenCard.CalendarFont = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sdtpOpenCard.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sdtpOpenCard.Location = new System.Drawing.Point(472, 113);
            this.sdtpOpenCard.Name = "sdtpOpenCard";
            this.sdtpOpenCard.Size = new System.Drawing.Size(185, 29);
            this.sdtpOpenCard.TabIndex = 10;
            // 
            // scboSex
            // 
            this.scboSex.BaseColor = System.Drawing.Color.DimGray;
            this.scboSex.BorderColor = System.Drawing.Color.Black;
            this.scboSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.scboSex.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.scboSex.FormattingEnabled = true;
            this.scboSex.ItemBorderColor = System.Drawing.Color.Gold;
            this.scboSex.ItemHeight = 22;
            this.scboSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.scboSex.Location = new System.Drawing.Point(472, 18);
            this.scboSex.Name = "scboSex";
            this.scboSex.Size = new System.Drawing.Size(185, 28);
            this.scboSex.TabIndex = 8;
            this.scboSex.WaterText = "";
            // 
            // stxtMemberAge
            // 
            this.stxtMemberAge.BackColor = System.Drawing.Color.Black;
            this.stxtMemberAge.DownBack = null;
            this.stxtMemberAge.Icon = null;
            this.stxtMemberAge.IconIsButton = false;
            this.stxtMemberAge.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.stxtMemberAge.IsPasswordChat = '\0';
            this.stxtMemberAge.IsSystemPasswordChar = false;
            this.stxtMemberAge.Lines = new string[0];
            this.stxtMemberAge.Location = new System.Drawing.Point(472, 69);
            this.stxtMemberAge.Margin = new System.Windows.Forms.Padding(0);
            this.stxtMemberAge.MaxLength = 32767;
            this.stxtMemberAge.MinimumSize = new System.Drawing.Size(28, 28);
            this.stxtMemberAge.MouseBack = null;
            this.stxtMemberAge.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.stxtMemberAge.Multiline = false;
            this.stxtMemberAge.Name = "stxtMemberAge";
            this.stxtMemberAge.NormlBack = null;
            this.stxtMemberAge.Padding = new System.Windows.Forms.Padding(5);
            this.stxtMemberAge.ReadOnly = false;
            this.stxtMemberAge.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stxtMemberAge.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.stxtMemberAge.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stxtMemberAge.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stxtMemberAge.SkinTxt.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stxtMemberAge.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.stxtMemberAge.SkinTxt.Name = "BaseText";
            this.stxtMemberAge.SkinTxt.Size = new System.Drawing.Size(175, 20);
            this.stxtMemberAge.SkinTxt.TabIndex = 0;
            this.stxtMemberAge.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stxtMemberAge.SkinTxt.WaterText = "";
            this.stxtMemberAge.TabIndex = 0;
            this.stxtMemberAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stxtMemberAge.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stxtMemberAge.WaterText = "";
            this.stxtMemberAge.WordWrap = true;
            // 
            // stxtMemberPwd
            // 
            this.stxtMemberPwd.BackColor = System.Drawing.Color.Black;
            this.stxtMemberPwd.DownBack = null;
            this.stxtMemberPwd.Icon = null;
            this.stxtMemberPwd.IconIsButton = false;
            this.stxtMemberPwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.stxtMemberPwd.IsPasswordChat = '\0';
            this.stxtMemberPwd.IsSystemPasswordChar = false;
            this.stxtMemberPwd.Lines = new string[0];
            this.stxtMemberPwd.Location = new System.Drawing.Point(134, 178);
            this.stxtMemberPwd.Margin = new System.Windows.Forms.Padding(0);
            this.stxtMemberPwd.MaxLength = 32767;
            this.stxtMemberPwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.stxtMemberPwd.MouseBack = null;
            this.stxtMemberPwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.stxtMemberPwd.Multiline = false;
            this.stxtMemberPwd.Name = "stxtMemberPwd";
            this.stxtMemberPwd.NormlBack = null;
            this.stxtMemberPwd.Padding = new System.Windows.Forms.Padding(5);
            this.stxtMemberPwd.ReadOnly = false;
            this.stxtMemberPwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stxtMemberPwd.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.stxtMemberPwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stxtMemberPwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stxtMemberPwd.SkinTxt.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stxtMemberPwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.stxtMemberPwd.SkinTxt.Name = "BaseText";
            this.stxtMemberPwd.SkinTxt.Size = new System.Drawing.Size(175, 20);
            this.stxtMemberPwd.SkinTxt.TabIndex = 0;
            this.stxtMemberPwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stxtMemberPwd.SkinTxt.WaterText = "";
            this.stxtMemberPwd.TabIndex = 0;
            this.stxtMemberPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stxtMemberPwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stxtMemberPwd.WaterText = "";
            this.stxtMemberPwd.WordWrap = true;
            // 
            // stxtMemberName
            // 
            this.stxtMemberName.BackColor = System.Drawing.Color.Black;
            this.stxtMemberName.DownBack = null;
            this.stxtMemberName.Icon = null;
            this.stxtMemberName.IconIsButton = false;
            this.stxtMemberName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.stxtMemberName.IsPasswordChat = '\0';
            this.stxtMemberName.IsSystemPasswordChar = false;
            this.stxtMemberName.Lines = new string[0];
            this.stxtMemberName.Location = new System.Drawing.Point(134, 73);
            this.stxtMemberName.Margin = new System.Windows.Forms.Padding(0);
            this.stxtMemberName.MaxLength = 32767;
            this.stxtMemberName.MinimumSize = new System.Drawing.Size(28, 28);
            this.stxtMemberName.MouseBack = null;
            this.stxtMemberName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.stxtMemberName.Multiline = false;
            this.stxtMemberName.Name = "stxtMemberName";
            this.stxtMemberName.NormlBack = null;
            this.stxtMemberName.Padding = new System.Windows.Forms.Padding(5);
            this.stxtMemberName.ReadOnly = false;
            this.stxtMemberName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stxtMemberName.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.stxtMemberName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stxtMemberName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stxtMemberName.SkinTxt.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stxtMemberName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.stxtMemberName.SkinTxt.Name = "BaseText";
            this.stxtMemberName.SkinTxt.Size = new System.Drawing.Size(175, 20);
            this.stxtMemberName.SkinTxt.TabIndex = 0;
            this.stxtMemberName.SkinTxt.WaterColor = System.Drawing.Color.Black;
            this.stxtMemberName.SkinTxt.WaterText = "";
            this.stxtMemberName.TabIndex = 0;
            this.stxtMemberName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stxtMemberName.WaterColor = System.Drawing.Color.Black;
            this.stxtMemberName.WaterText = "";
            this.stxtMemberName.WordWrap = true;
            // 
            // stxtMemberTel
            // 
            this.stxtMemberTel.BackColor = System.Drawing.Color.Black;
            this.stxtMemberTel.DownBack = null;
            this.stxtMemberTel.Icon = null;
            this.stxtMemberTel.IconIsButton = false;
            this.stxtMemberTel.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.stxtMemberTel.IsPasswordChat = '\0';
            this.stxtMemberTel.IsSystemPasswordChar = false;
            this.stxtMemberTel.Lines = new string[0];
            this.stxtMemberTel.Location = new System.Drawing.Point(134, 124);
            this.stxtMemberTel.Margin = new System.Windows.Forms.Padding(0);
            this.stxtMemberTel.MaxLength = 32767;
            this.stxtMemberTel.MinimumSize = new System.Drawing.Size(28, 28);
            this.stxtMemberTel.MouseBack = null;
            this.stxtMemberTel.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.stxtMemberTel.Multiline = false;
            this.stxtMemberTel.Name = "stxtMemberTel";
            this.stxtMemberTel.NormlBack = null;
            this.stxtMemberTel.Padding = new System.Windows.Forms.Padding(5);
            this.stxtMemberTel.ReadOnly = false;
            this.stxtMemberTel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stxtMemberTel.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.stxtMemberTel.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stxtMemberTel.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stxtMemberTel.SkinTxt.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stxtMemberTel.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.stxtMemberTel.SkinTxt.Name = "BaseText";
            this.stxtMemberTel.SkinTxt.Size = new System.Drawing.Size(175, 20);
            this.stxtMemberTel.SkinTxt.TabIndex = 0;
            this.stxtMemberTel.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stxtMemberTel.SkinTxt.WaterText = "";
            this.stxtMemberTel.TabIndex = 0;
            this.stxtMemberTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stxtMemberTel.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.stxtMemberTel.WaterText = "";
            this.stxtMemberTel.WordWrap = true;
            // 
            // stxtMemberId
            // 
            this.stxtMemberId.BackColor = System.Drawing.Color.Black;
            this.stxtMemberId.DownBack = null;
            this.stxtMemberId.Enabled = false;
            this.stxtMemberId.Icon = null;
            this.stxtMemberId.IconIsButton = false;
            this.stxtMemberId.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.stxtMemberId.IsPasswordChat = '\0';
            this.stxtMemberId.IsSystemPasswordChar = false;
            this.stxtMemberId.Lines = new string[0];
            this.stxtMemberId.Location = new System.Drawing.Point(134, 17);
            this.stxtMemberId.Margin = new System.Windows.Forms.Padding(0);
            this.stxtMemberId.MaxLength = 32767;
            this.stxtMemberId.MinimumSize = new System.Drawing.Size(28, 28);
            this.stxtMemberId.MouseBack = null;
            this.stxtMemberId.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.stxtMemberId.Multiline = false;
            this.stxtMemberId.Name = "stxtMemberId";
            this.stxtMemberId.NormlBack = null;
            this.stxtMemberId.Padding = new System.Windows.Forms.Padding(5);
            this.stxtMemberId.ReadOnly = false;
            this.stxtMemberId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.stxtMemberId.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.stxtMemberId.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stxtMemberId.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stxtMemberId.SkinTxt.Font = new System.Drawing.Font("华文新魏", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stxtMemberId.SkinTxt.ForeColor = System.Drawing.Color.Black;
            this.stxtMemberId.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.stxtMemberId.SkinTxt.Name = "BaseText";
            this.stxtMemberId.SkinTxt.Size = new System.Drawing.Size(175, 20);
            this.stxtMemberId.SkinTxt.TabIndex = 0;
            this.stxtMemberId.SkinTxt.WaterColor = System.Drawing.Color.Black;
            this.stxtMemberId.SkinTxt.WaterText = "";
            this.stxtMemberId.TabIndex = 0;
            this.stxtMemberId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.stxtMemberId.WaterColor = System.Drawing.Color.Black;
            this.stxtMemberId.WaterText = "";
            this.stxtMemberId.WordWrap = true;
            // 
            // skinLabel8
            // 
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel8.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.skinLabel8.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.ForeColor = System.Drawing.Color.Gold;
            this.skinLabel8.Location = new System.Drawing.Point(363, 119);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(109, 20);
            this.skinLabel8.TabIndex = 7;
            this.skinLabel8.Text = "办卡时间：";
            // 
            // skinLabel7
            // 
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.skinLabel7.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.ForeColor = System.Drawing.Color.Gold;
            this.skinLabel7.Location = new System.Drawing.Point(402, 70);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(69, 20);
            this.skinLabel7.TabIndex = 6;
            this.skinLabel7.Text = "年龄：";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.skinLabel6.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.ForeColor = System.Drawing.Color.Gold;
            this.skinLabel6.Location = new System.Drawing.Point(403, 19);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(69, 20);
            this.skinLabel6.TabIndex = 5;
            this.skinLabel6.Text = "性别：";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.skinLabel5.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.ForeColor = System.Drawing.Color.Gold;
            this.skinLabel5.Location = new System.Drawing.Point(31, 178);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(109, 20);
            this.skinLabel5.TabIndex = 4;
            this.skinLabel5.Text = "会员密码：";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.skinLabel4.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.Gold;
            this.skinLabel4.Location = new System.Drawing.Point(31, 124);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(109, 20);
            this.skinLabel4.TabIndex = 3;
            this.skinLabel4.Text = "会员电话：";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.skinLabel3.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.Gold;
            this.skinLabel3.Location = new System.Drawing.Point(31, 73);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(109, 20);
            this.skinLabel3.TabIndex = 2;
            this.skinLabel3.Text = "会员名称：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.DarkGoldenrod;
            this.skinLabel2.Font = new System.Drawing.Font("隶书", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.Gold;
            this.skinLabel2.Location = new System.Drawing.Point(31, 19);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(109, 20);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "会员编号：";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.Gold;
            this.skinLabel1.Font = new System.Drawing.Font("华文新魏", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.White;
            this.skinLabel1.Location = new System.Drawing.Point(446, 19);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(129, 30);
            this.skinLabel1.TabIndex = 6;
            this.skinLabel1.Text = "会员管理";
            // 
            // FrmAssociator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinPanel1);
            this.Controls.Add(this.sbtnDelete);
            this.Controls.Add(this.sbtnFind);
            this.Controls.Add(this.sbtnUpdate);
            this.Controls.Add(this.sbtnAdd);
            this.Controls.Add(this.SdgvMemberInfo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FrmAssociator";
            this.Size = new System.Drawing.Size(989, 622);
            this.Load += new System.EventHandler(this.FrmAssociator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SdgvMemberInfo)).EndInit();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinDataGridView SdgvMemberInfo;
        private CCWin.SkinControl.SkinButton sbtnAdd;
        private CCWin.SkinControl.SkinButton sbtnUpdate;
        private CCWin.SkinControl.SkinButton sbtnFind;
        private CCWin.SkinControl.SkinButton sbtnDelete;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMemberId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMemTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMemPwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMemSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMemAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMemBirthday;
        private CCWin.SkinControl.SkinComboBox scboSex;
        private CCWin.SkinControl.SkinTextBox stxtMemberAge;
        private CCWin.SkinControl.SkinTextBox stxtMemberPwd;
        private CCWin.SkinControl.SkinTextBox stxtMemberName;
        private CCWin.SkinControl.SkinTextBox stxtMemberTel;
        private CCWin.SkinControl.SkinTextBox stxtMemberId;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel6;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private System.Windows.Forms.DateTimePicker sdtpOpenCard;
    }
}
