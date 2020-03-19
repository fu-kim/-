namespace AddFood
{
    partial class FrmFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFood));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAllFood = new CCWin.SkinControl.SkinButton();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOther = new CCWin.SkinControl.SkinButton();
            this.btnWine = new CCWin.SkinControl.SkinButton();
            this.btnSoups = new CCWin.SkinControl.SkinButton();
            this.btnColdFood = new CCWin.SkinControl.SkinButton();
            this.btnHotFood = new CCWin.SkinControl.SkinButton();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dgvFoodInfo = new CCWin.SkinControl.SkinDataGridView();
            this.clFoodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFoodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnR = new CCWin.SkinControl.SkinButton();
            this.btnDelete = new CCWin.SkinControl.SkinButton();
            this.btnAdd = new CCWin.SkinControl.SkinButton();
            this.btnUpdate = new CCWin.SkinControl.SkinButton();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboFoodType = new CCWin.SkinControl.SkinComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.菜品Id = new System.Windows.Forms.Label();
            this.txtFoodId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodInfo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAllFood);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnOther);
            this.panel1.Controls.Add(this.btnWine);
            this.panel1.Controls.Add(this.btnSoups);
            this.panel1.Controls.Add(this.btnColdFood);
            this.panel1.Controls.Add(this.btnHotFood);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Font = new System.Drawing.Font("宋体", 13F);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 332);
            this.panel1.TabIndex = 1;
            // 
            // btnAllFood
            // 
            this.btnAllFood.BackColor = System.Drawing.Color.Transparent;
            this.btnAllFood.BaseColor = System.Drawing.Color.Silver;
            this.btnAllFood.BorderColor = System.Drawing.Color.Silver;
            this.btnAllFood.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAllFood.DownBack = null;
            this.btnAllFood.Font = new System.Drawing.Font("宋体", 13F);
            this.btnAllFood.ForeColor = System.Drawing.Color.Black;
            this.btnAllFood.Image = ((System.Drawing.Image)(resources.GetObject("btnAllFood.Image")));
            this.btnAllFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllFood.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAllFood.Location = new System.Drawing.Point(8, 56);
            this.btnAllFood.MouseBack = null;
            this.btnAllFood.Name = "btnAllFood";
            this.btnAllFood.NormlBack = null;
            this.btnAllFood.Size = new System.Drawing.Size(126, 39);
            this.btnAllFood.TabIndex = 4;
            this.btnAllFood.Text = "全部";
            this.btnAllFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAllFood.UseVisualStyleBackColor = false;
            this.btnAllFood.Click += new System.EventHandler(this.btnAllFood_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 20F);
            this.label7.Location = new System.Drawing.Point(6, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = "菜品列表";
            // 
            // btnOther
            // 
            this.btnOther.BackColor = System.Drawing.Color.Transparent;
            this.btnOther.BaseColor = System.Drawing.Color.Silver;
            this.btnOther.BorderColor = System.Drawing.Color.Silver;
            this.btnOther.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOther.DownBack = null;
            this.btnOther.Font = new System.Drawing.Font("宋体", 13F);
            this.btnOther.ForeColor = System.Drawing.Color.Black;
            this.btnOther.Image = ((System.Drawing.Image)(resources.GetObject("btnOther.Image")));
            this.btnOther.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOther.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOther.Location = new System.Drawing.Point(8, 279);
            this.btnOther.MouseBack = null;
            this.btnOther.Name = "btnOther";
            this.btnOther.NormlBack = null;
            this.btnOther.Size = new System.Drawing.Size(126, 41);
            this.btnOther.TabIndex = 4;
            this.btnOther.Text = "其他";
            this.btnOther.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOther.UseVisualStyleBackColor = false;
            this.btnOther.Click += new System.EventHandler(this.btnOther_Click);
            // 
            // btnWine
            // 
            this.btnWine.BackColor = System.Drawing.Color.Transparent;
            this.btnWine.BaseColor = System.Drawing.Color.Silver;
            this.btnWine.BorderColor = System.Drawing.Color.Silver;
            this.btnWine.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnWine.DownBack = null;
            this.btnWine.Font = new System.Drawing.Font("宋体", 13F);
            this.btnWine.ForeColor = System.Drawing.Color.Black;
            this.btnWine.Image = ((System.Drawing.Image)(resources.GetObject("btnWine.Image")));
            this.btnWine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWine.ImageSize = new System.Drawing.Size(25, 25);
            this.btnWine.Location = new System.Drawing.Point(8, 236);
            this.btnWine.MouseBack = null;
            this.btnWine.Name = "btnWine";
            this.btnWine.NormlBack = null;
            this.btnWine.Size = new System.Drawing.Size(126, 37);
            this.btnWine.TabIndex = 3;
            this.btnWine.Text = "饮品";
            this.btnWine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWine.UseVisualStyleBackColor = false;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnSoups
            // 
            this.btnSoups.BackColor = System.Drawing.Color.Transparent;
            this.btnSoups.BaseColor = System.Drawing.Color.Silver;
            this.btnSoups.BorderColor = System.Drawing.Color.Silver;
            this.btnSoups.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnSoups.DownBack = null;
            this.btnSoups.Font = new System.Drawing.Font("宋体", 13F);
            this.btnSoups.ForeColor = System.Drawing.Color.Black;
            this.btnSoups.Image = ((System.Drawing.Image)(resources.GetObject("btnSoups.Image")));
            this.btnSoups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoups.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSoups.Location = new System.Drawing.Point(8, 190);
            this.btnSoups.MouseBack = null;
            this.btnSoups.Name = "btnSoups";
            this.btnSoups.NormlBack = null;
            this.btnSoups.Size = new System.Drawing.Size(126, 40);
            this.btnSoups.TabIndex = 2;
            this.btnSoups.Text = "汤类";
            this.btnSoups.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSoups.UseVisualStyleBackColor = false;
            this.btnSoups.Click += new System.EventHandler(this.btnSoups_Click);
            // 
            // btnColdFood
            // 
            this.btnColdFood.BackColor = System.Drawing.Color.Transparent;
            this.btnColdFood.BaseColor = System.Drawing.Color.Silver;
            this.btnColdFood.BorderColor = System.Drawing.Color.Silver;
            this.btnColdFood.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnColdFood.DownBack = null;
            this.btnColdFood.Font = new System.Drawing.Font("宋体", 13F);
            this.btnColdFood.ForeColor = System.Drawing.Color.Black;
            this.btnColdFood.Image = ((System.Drawing.Image)(resources.GetObject("btnColdFood.Image")));
            this.btnColdFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnColdFood.ImageSize = new System.Drawing.Size(25, 25);
            this.btnColdFood.Location = new System.Drawing.Point(8, 146);
            this.btnColdFood.MouseBack = null;
            this.btnColdFood.Name = "btnColdFood";
            this.btnColdFood.NormlBack = null;
            this.btnColdFood.Size = new System.Drawing.Size(126, 38);
            this.btnColdFood.TabIndex = 1;
            this.btnColdFood.Text = "凉菜";
            this.btnColdFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnColdFood.UseVisualStyleBackColor = false;
            this.btnColdFood.Click += new System.EventHandler(this.btnColdFood_Click);
            // 
            // btnHotFood
            // 
            this.btnHotFood.BackColor = System.Drawing.Color.Transparent;
            this.btnHotFood.BaseColor = System.Drawing.Color.Silver;
            this.btnHotFood.BorderColor = System.Drawing.Color.Silver;
            this.btnHotFood.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnHotFood.DownBack = null;
            this.btnHotFood.Font = new System.Drawing.Font("宋体", 13F);
            this.btnHotFood.ForeColor = System.Drawing.Color.Black;
            this.btnHotFood.Image = ((System.Drawing.Image)(resources.GetObject("btnHotFood.Image")));
            this.btnHotFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHotFood.ImageSize = new System.Drawing.Size(25, 25);
            this.btnHotFood.Location = new System.Drawing.Point(8, 101);
            this.btnHotFood.MouseBack = null;
            this.btnHotFood.Name = "btnHotFood";
            this.btnHotFood.NormlBack = null;
            this.btnHotFood.Size = new System.Drawing.Size(126, 39);
            this.btnHotFood.TabIndex = 0;
            this.btnHotFood.Text = "热菜";
            this.btnHotFood.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHotFood.UseVisualStyleBackColor = false;
            this.btnHotFood.Click += new System.EventHandler(this.btnHotFood_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(144, 330);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 9;
            this.lineShape1.X2 = 127;
            this.lineShape1.Y1 = 44;
            this.lineShape1.Y2 = 44;
            // 
            // dgvFoodInfo
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dgvFoodInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFoodInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFoodInfo.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvFoodInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFoodInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvFoodInfo.ColumnFont = null;
            this.dgvFoodInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFoodInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFoodInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clFoodId,
            this.clFoodType,
            this.clFoodName,
            this.clPrice,
            this.clTime});
            this.dgvFoodInfo.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvFoodInfo.DefaultCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFoodInfo.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFoodInfo.EnableHeadersVisualStyles = false;
            this.dgvFoodInfo.Font = new System.Drawing.Font("宋体", 10F);
            this.dgvFoodInfo.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvFoodInfo.HeadFont = new System.Drawing.Font("宋体", 13F);
            this.dgvFoodInfo.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvFoodInfo.LineNumber = false;
            this.dgvFoodInfo.Location = new System.Drawing.Point(168, 6);
            this.dgvFoodInfo.MultiSelect = false;
            this.dgvFoodInfo.Name = "dgvFoodInfo";
            this.dgvFoodInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFoodInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvFoodInfo.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFoodInfo.RowTemplate.Height = 23;
            this.dgvFoodInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodInfo.Size = new System.Drawing.Size(814, 326);
            this.dgvFoodInfo.TabIndex = 4;
            this.dgvFoodInfo.TitleBack = null;
            this.dgvFoodInfo.TitleBackColorBegin = System.Drawing.Color.White;
            this.dgvFoodInfo.TitleBackColorEnd = System.Drawing.Color.DarkGray;
            this.dgvFoodInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodInfo_CellClick);
            // 
            // clFoodId
            // 
            this.clFoodId.DataPropertyName = "FoodId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clFoodId.DefaultCellStyle = dataGridViewCellStyle3;
            this.clFoodId.HeaderText = "菜品Id";
            this.clFoodId.Name = "clFoodId";
            // 
            // clFoodType
            // 
            this.clFoodType.DataPropertyName = "FoodType";
            this.clFoodType.HeaderText = "菜品类型";
            this.clFoodType.Name = "clFoodType";
            // 
            // clFoodName
            // 
            this.clFoodName.DataPropertyName = "FoodName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clFoodName.DefaultCellStyle = dataGridViewCellStyle4;
            this.clFoodName.HeaderText = "菜品名称";
            this.clFoodName.Name = "clFoodName";
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "FoodPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.clPrice.HeaderText = "菜品价格";
            this.clPrice.Name = "clPrice";
            // 
            // clTime
            // 
            this.clTime.DataPropertyName = "FoodTime";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.clTime.HeaderText = "预计完成时间";
            this.clTime.Name = "clTime";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnR);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtTime);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cboFoodType);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtPrice);
            this.panel2.Controls.Add(this.菜品Id);
            this.panel2.Controls.Add(this.txtFoodId);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtFoodName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.shapeContainer2);
            this.panel2.Location = new System.Drawing.Point(3, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(980, 278);
            this.panel2.TabIndex = 5;
            // 
            // btnR
            // 
            this.btnR.BackColor = System.Drawing.Color.Black;
            this.btnR.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnR.BorderColor = System.Drawing.Color.LightGray;
            this.btnR.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnR.DownBack = null;
            this.btnR.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnR.ForeColor = System.Drawing.Color.Black;
            this.btnR.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnR.Location = new System.Drawing.Point(406, 202);
            this.btnR.MouseBack = null;
            this.btnR.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btnR.Name = "btnR";
            this.btnR.NormlBack = null;
            this.btnR.Size = new System.Drawing.Size(109, 40);
            this.btnR.TabIndex = 16;
            this.btnR.Text = "刷新";
            this.btnR.UseVisualStyleBackColor = false;
            this.btnR.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Black;
            this.btnDelete.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.BorderColor = System.Drawing.Color.LightGray;
            this.btnDelete.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnDelete.DownBack = null;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(281, 202);
            this.btnDelete.MouseBack = null;
            this.btnDelete.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.NormlBack = null;
            this.btnDelete.Size = new System.Drawing.Size(109, 40);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Black;
            this.btnAdd.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdd.BorderColor = System.Drawing.Color.LightGray;
            this.btnAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdd.DownBack = null;
            this.btnAdd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(31, 202);
            this.btnAdd.MouseBack = null;
            this.btnAdd.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormlBack = null;
            this.btnAdd.Size = new System.Drawing.Size(109, 40);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Black;
            this.btnUpdate.BaseColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.BorderColor = System.Drawing.Color.LightGray;
            this.btnUpdate.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnUpdate.DownBack = null;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.InnerBorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(156, 202);
            this.btnUpdate.MouseBack = null;
            this.btnUpdate.MouseBaseColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.NormlBack = null;
            this.btnUpdate.Size = new System.Drawing.Size(109, 40);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("宋体", 12F);
            this.txtTime.Location = new System.Drawing.Point(114, 140);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(121, 26);
            this.txtTime.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("隶书", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(28, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "预计时间";
            // 
            // cboFoodType
            // 
            this.cboFoodType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFoodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodType.Font = new System.Drawing.Font("宋体", 12F);
            this.cboFoodType.FormattingEnabled = true;
            this.cboFoodType.Items.AddRange(new object[] {
            "热菜",
            "凉菜",
            "汤",
            "饮品",
            "其他",
            "热销",
            "新品"});
            this.cboFoodType.Location = new System.Drawing.Point(114, 80);
            this.cboFoodType.Name = "cboFoodType";
            this.cboFoodType.Size = new System.Drawing.Size(121, 27);
            this.cboFoodType.TabIndex = 9;
            this.cboFoodType.WaterText = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("隶书", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(290, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "菜品价格";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPrice.Location = new System.Drawing.Point(376, 81);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(108, 26);
            this.txtPrice.TabIndex = 7;
            // 
            // 菜品Id
            // 
            this.菜品Id.AutoSize = true;
            this.菜品Id.Font = new System.Drawing.Font("隶书", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.菜品Id.ForeColor = System.Drawing.Color.Gold;
            this.菜品Id.Location = new System.Drawing.Point(28, 85);
            this.菜品Id.Name = "菜品Id";
            this.菜品Id.Size = new System.Drawing.Size(80, 17);
            this.菜品Id.TabIndex = 6;
            this.菜品Id.Text = "菜品类型";
            // 
            // txtFoodId
            // 
            this.txtFoodId.Enabled = false;
            this.txtFoodId.Font = new System.Drawing.Font("宋体", 12F);
            this.txtFoodId.Location = new System.Drawing.Point(376, 19);
            this.txtFoodId.Name = "txtFoodId";
            this.txtFoodId.Size = new System.Drawing.Size(108, 26);
            this.txtFoodId.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("隶书", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(290, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "菜品  Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("隶书", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(28, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "菜品名称";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtFoodName.Location = new System.Drawing.Point(114, 19);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(121, 26);
            this.txtFoodName.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(542, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(978, 276);
            this.shapeContainer2.TabIndex = 10;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 514;
            this.lineShape3.X2 = 40;
            this.lineShape3.Y1 = 181;
            this.lineShape3.Y2 = 181;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 522;
            this.lineShape2.X2 = 522;
            this.lineShape2.Y1 = 20;
            this.lineShape2.Y2 = 110;
            // 
            // FrmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvFoodInfo);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FrmFood";
            this.Size = new System.Drawing.Size(989, 622);
            this.Load += new System.EventHandler(this.FrmFood_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinButton btnAllFood;
        private System.Windows.Forms.Label label7;
        private CCWin.SkinControl.SkinButton btnOther;
        private CCWin.SkinControl.SkinButton btnWine;
        private CCWin.SkinControl.SkinButton btnSoups;
        private CCWin.SkinControl.SkinButton btnColdFood;
        private CCWin.SkinControl.SkinButton btnHotFood;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFoodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTime;
        private System.Windows.Forms.Panel panel2;
        private CCWin.SkinControl.SkinButton btnR;
        private CCWin.SkinControl.SkinButton btnDelete;
        private CCWin.SkinControl.SkinButton btnAdd;
        private CCWin.SkinControl.SkinButton btnUpdate;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label5;
        private CCWin.SkinControl.SkinComboBox cboFoodType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label 菜品Id;
        private System.Windows.Forms.TextBox txtFoodId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        public CCWin.SkinControl.SkinDataGridView dgvFoodInfo;
    }
}
