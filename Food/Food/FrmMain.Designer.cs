namespace AddFood
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.plMain = new CCWin.SkinControl.SkinPanel();
            this.btnTableManager = new CCWin.SkinControl.SkinButton();
            this.btnFoodManager = new CCWin.SkinControl.SkinButton();
            this.btnOrderManager = new CCWin.SkinControl.SkinButton();
            this.btnStaffManager = new CCWin.SkinControl.SkinButton();
            this.btnActivityManager = new CCWin.SkinControl.SkinButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ttInfo = new CCWin.SkinToolTip(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.btnAssociatorManager = new CCWin.SkinControl.SkinButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DarkGray;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 989;
            this.lineShape1.X2 = 0;
            this.lineShape1.Y1 = 642;
            this.lineShape1.Y2 = 642;
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.Transparent;
            this.plMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.plMain.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.plMain.DownBack = null;
            this.plMain.ForeColor = System.Drawing.Color.Black;
            this.plMain.Location = new System.Drawing.Point(4, 55);
            this.plMain.MouseBack = null;
            this.plMain.Name = "plMain";
            this.plMain.NormlBack = null;
            this.plMain.Size = new System.Drawing.Size(989, 622);
            this.plMain.TabIndex = 3;
            // 
            // btnTableManager
            // 
            this.btnTableManager.BackColor = System.Drawing.Color.Transparent;
            this.btnTableManager.BaseColor = System.Drawing.Color.Brown;
            this.btnTableManager.BorderColor = System.Drawing.Color.DimGray;
            this.btnTableManager.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnTableManager.DownBack = null;
            this.btnTableManager.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTableManager.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTableManager.ForeColor = System.Drawing.Color.White;
            this.btnTableManager.GlowColor = System.Drawing.Color.Gold;
            this.btnTableManager.Image = ((System.Drawing.Image)(resources.GetObject("btnTableManager.Image")));
            this.btnTableManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTableManager.ImageSize = new System.Drawing.Size(25, 25);
            this.btnTableManager.Location = new System.Drawing.Point(152, 3);
            this.btnTableManager.MouseBack = null;
            this.btnTableManager.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTableManager.Name = "btnTableManager";
            this.btnTableManager.NormlBack = null;
            this.btnTableManager.Size = new System.Drawing.Size(108, 50);
            this.btnTableManager.TabIndex = 5;
            this.btnTableManager.Text = "餐桌管理";
            this.btnTableManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTableManager.UseVisualStyleBackColor = false;
            this.btnTableManager.Click += new System.EventHandler(this.btnTableManager_Click);
            // 
            // btnFoodManager
            // 
            this.btnFoodManager.BackColor = System.Drawing.Color.Transparent;
            this.btnFoodManager.BaseColor = System.Drawing.Color.Black;
            this.btnFoodManager.BorderColor = System.Drawing.Color.DimGray;
            this.btnFoodManager.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnFoodManager.DownBack = null;
            this.btnFoodManager.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFoodManager.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFoodManager.ForeColor = System.Drawing.Color.White;
            this.btnFoodManager.GlowColor = System.Drawing.Color.Gold;
            this.btnFoodManager.Image = ((System.Drawing.Image)(resources.GetObject("btnFoodManager.Image")));
            this.btnFoodManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFoodManager.ImageSize = new System.Drawing.Size(25, 25);
            this.btnFoodManager.Location = new System.Drawing.Point(264, 3);
            this.btnFoodManager.MouseBack = null;
            this.btnFoodManager.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnFoodManager.Name = "btnFoodManager";
            this.btnFoodManager.NormlBack = null;
            this.btnFoodManager.Size = new System.Drawing.Size(108, 50);
            this.btnFoodManager.TabIndex = 6;
            this.btnFoodManager.Text = "菜品管理";
            this.btnFoodManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFoodManager.UseVisualStyleBackColor = false;
            this.btnFoodManager.Click += new System.EventHandler(this.btnFoodManager_Click);
            // 
            // btnOrderManager
            // 
            this.btnOrderManager.BackColor = System.Drawing.Color.Transparent;
            this.btnOrderManager.BaseColor = System.Drawing.Color.Black;
            this.btnOrderManager.BorderColor = System.Drawing.Color.DimGray;
            this.btnOrderManager.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOrderManager.DownBack = null;
            this.btnOrderManager.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOrderManager.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOrderManager.ForeColor = System.Drawing.Color.White;
            this.btnOrderManager.GlowColor = System.Drawing.Color.Gold;
            this.btnOrderManager.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderManager.Image")));
            this.btnOrderManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderManager.ImageSize = new System.Drawing.Size(25, 25);
            this.btnOrderManager.Location = new System.Drawing.Point(376, 3);
            this.btnOrderManager.MouseBack = null;
            this.btnOrderManager.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOrderManager.Name = "btnOrderManager";
            this.btnOrderManager.NormlBack = null;
            this.btnOrderManager.Size = new System.Drawing.Size(108, 50);
            this.btnOrderManager.TabIndex = 7;
            this.btnOrderManager.Text = "订单管理";
            this.btnOrderManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrderManager.UseVisualStyleBackColor = false;
            this.btnOrderManager.Click += new System.EventHandler(this.btnOrderManaher_Click);
            // 
            // btnStaffManager
            // 
            this.btnStaffManager.BackColor = System.Drawing.Color.Transparent;
            this.btnStaffManager.BaseColor = System.Drawing.Color.Black;
            this.btnStaffManager.BorderColor = System.Drawing.Color.DimGray;
            this.btnStaffManager.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnStaffManager.DownBack = null;
            this.btnStaffManager.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStaffManager.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStaffManager.ForeColor = System.Drawing.Color.White;
            this.btnStaffManager.GlowColor = System.Drawing.Color.Gold;
            this.btnStaffManager.Image = ((System.Drawing.Image)(resources.GetObject("btnStaffManager.Image")));
            this.btnStaffManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaffManager.ImageSize = new System.Drawing.Size(25, 25);
            this.btnStaffManager.Location = new System.Drawing.Point(600, 3);
            this.btnStaffManager.MouseBack = null;
            this.btnStaffManager.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStaffManager.Name = "btnStaffManager";
            this.btnStaffManager.NormlBack = null;
            this.btnStaffManager.Size = new System.Drawing.Size(108, 50);
            this.btnStaffManager.TabIndex = 7;
            this.btnStaffManager.Text = "员工管理";
            this.btnStaffManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStaffManager.UseVisualStyleBackColor = false;
            this.btnStaffManager.Click += new System.EventHandler(this.btnStaffManager_Click_1);
            // 
            // btnActivityManager
            // 
            this.btnActivityManager.BackColor = System.Drawing.Color.Transparent;
            this.btnActivityManager.BaseColor = System.Drawing.Color.Black;
            this.btnActivityManager.BorderColor = System.Drawing.Color.DimGray;
            this.btnActivityManager.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnActivityManager.DownBack = null;
            this.btnActivityManager.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnActivityManager.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnActivityManager.ForeColor = System.Drawing.Color.White;
            this.btnActivityManager.GlowColor = System.Drawing.Color.Gold;
            this.btnActivityManager.Image = ((System.Drawing.Image)(resources.GetObject("btnActivityManager.Image")));
            this.btnActivityManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivityManager.ImageSize = new System.Drawing.Size(25, 25);
            this.btnActivityManager.Location = new System.Drawing.Point(488, 3);
            this.btnActivityManager.MouseBack = null;
            this.btnActivityManager.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnActivityManager.Name = "btnActivityManager";
            this.btnActivityManager.NormlBack = null;
            this.btnActivityManager.Size = new System.Drawing.Size(108, 50);
            this.btnActivityManager.TabIndex = 7;
            this.btnActivityManager.Text = "活动管理";
            this.btnActivityManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivityManager.UseVisualStyleBackColor = false;
            this.btnActivityManager.Click += new System.EventHandler(this.btnActivityManager_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(870, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 34);
            this.label3.TabIndex = 11;
            this.label3.Text = "|";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(834, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.ttInfo.SetToolTip(this.pictureBox1, "设置");
            // 
            // ttInfo
            // 
            this.ttInfo.AutoPopDelay = 5000;
            this.ttInfo.InitialDelay = 500;
            this.ttInfo.OwnerDraw = true;
            this.ttInfo.ReshowDelay = 800;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("宋体", 10F);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(2, 682);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 14);
            this.lblTime.TabIndex = 14;
            this.lblTime.Text = "个人中心";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(860, 682);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 14);
            this.label5.TabIndex = 15;
            this.label5.Text = "当前权限:   管理员";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(4, 34);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(992, 662);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // btnAssociatorManager
            // 
            this.btnAssociatorManager.BackColor = System.Drawing.Color.Transparent;
            this.btnAssociatorManager.BaseColor = System.Drawing.Color.Black;
            this.btnAssociatorManager.BorderColor = System.Drawing.Color.DimGray;
            this.btnAssociatorManager.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAssociatorManager.DownBack = null;
            this.btnAssociatorManager.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAssociatorManager.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAssociatorManager.ForeColor = System.Drawing.Color.White;
            this.btnAssociatorManager.GlowColor = System.Drawing.Color.Gold;
            this.btnAssociatorManager.Image = ((System.Drawing.Image)(resources.GetObject("btnAssociatorManager.Image")));
            this.btnAssociatorManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssociatorManager.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAssociatorManager.Location = new System.Drawing.Point(712, 3);
            this.btnAssociatorManager.MouseBack = null;
            this.btnAssociatorManager.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAssociatorManager.Name = "btnAssociatorManager";
            this.btnAssociatorManager.NormlBack = null;
            this.btnAssociatorManager.Size = new System.Drawing.Size(108, 50);
            this.btnAssociatorManager.TabIndex = 17;
            this.btnAssociatorManager.Text = "会员管理";
            this.btnAssociatorManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAssociatorManager.UseVisualStyleBackColor = false;
            this.btnAssociatorManager.Click += new System.EventHandler(this.btnAssociatorManager_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.CloseBoxSize = new System.Drawing.Size(45, 30);
            this.Controls.Add(this.btnAssociatorManager);
            this.Controls.Add(this.btnTableManager);
            this.Controls.Add(this.btnActivityManager);
            this.Controls.Add(this.btnStaffManager);
            this.Controls.Add(this.btnOrderManager);
            this.Controls.Add(this.btnFoodManager);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shapeContainer1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ICoOffset = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MiniSize = new System.Drawing.Size(45, 30);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CCWin.SkinControl.SkinPanel plMain;
        private CCWin.SkinControl.SkinButton btnTableManager;
        private CCWin.SkinControl.SkinButton btnFoodManager;
        private CCWin.SkinControl.SkinButton btnOrderManager;
        private CCWin.SkinControl.SkinButton btnStaffManager;
        private CCWin.SkinControl.SkinButton btnActivityManager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CCWin.SkinToolTip ttInfo;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label5;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private CCWin.SkinControl.SkinButton btnAssociatorManager;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Timer timer1;
    }
}