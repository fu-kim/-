namespace AddFood
{
    partial class FrmLogin
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.L2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.L1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnLogin = new CCWin.SkinControl.SkinButton();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.cboRememberPwd = new CCWin.SkinControl.SkinCheckBox();
            this.lblLostPwd = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(34, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(34, 219);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 36);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(4, 34);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.L2,
            this.L1});
            this.shapeContainer1.Size = new System.Drawing.Size(329, 343);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // L2
            // 
            this.L2.BorderColor = System.Drawing.Color.Black;
            this.L2.BorderWidth = 2;
            this.L2.Name = "L2";
            this.L2.X1 = 29;
            this.L2.X2 = 301;
            this.L2.Y1 = 224;
            this.L2.Y2 = 224;
            // 
            // L1
            // 
            this.L1.BorderColor = System.Drawing.Color.Black;
            this.L1.BorderWidth = 2;
            this.L1.Name = "L1";
            this.L1.X1 = 27;
            this.L1.X2 = 299;
            this.L1.Y1 = 148;
            this.L1.Y2 = 148;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BaseColor = System.Drawing.Color.Black;
            this.btnLogin.BorderColor = System.Drawing.Color.DimGray;
            this.btnLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnLogin.DownBack = null;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(60, 308);
            this.btnLogin.MouseBack = null;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.NormlBack = null;
            this.btnLogin.Size = new System.Drawing.Size(218, 36);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtLoginId
            // 
            this.txtLoginId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoginId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginId.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.txtLoginId.Location = new System.Drawing.Point(72, 143);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(233, 36);
            this.txtLoginId.TabIndex = 4;
            this.txtLoginId.Text = "Admin";
            this.txtLoginId.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtLoginId_MouseDown);
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPwd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.txtPwd.Location = new System.Drawing.Point(72, 219);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(233, 36);
            this.txtPwd.TabIndex = 5;
            this.txtPwd.Text = "12345";
            this.txtPwd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // cboRememberPwd
            // 
            this.cboRememberPwd.AutoSize = true;
            this.cboRememberPwd.BackColor = System.Drawing.Color.Transparent;
            this.cboRememberPwd.Checked = true;
            this.cboRememberPwd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboRememberPwd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.cboRememberPwd.DownBack = null;
            this.cboRememberPwd.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.cboRememberPwd.Location = new System.Drawing.Point(72, 279);
            this.cboRememberPwd.MouseBack = null;
            this.cboRememberPwd.Name = "cboRememberPwd";
            this.cboRememberPwd.NormlBack = null;
            this.cboRememberPwd.SelectedDownBack = null;
            this.cboRememberPwd.SelectedMouseBack = null;
            this.cboRememberPwd.SelectedNormlBack = null;
            this.cboRememberPwd.Size = new System.Drawing.Size(80, 23);
            this.cboRememberPwd.TabIndex = 7;
            this.cboRememberPwd.Text = "记住密码";
            this.cboRememberPwd.UseVisualStyleBackColor = false;
            // 
            // lblLostPwd
            // 
            this.lblLostPwd.AutoSize = true;
            this.lblLostPwd.BackColor = System.Drawing.Color.Transparent;
            this.lblLostPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.lblLostPwd.LinkColor = System.Drawing.Color.DeepSkyBlue;
            this.lblLostPwd.Location = new System.Drawing.Point(213, 279);
            this.lblLostPwd.Name = "lblLostPwd";
            this.lblLostPwd.Size = new System.Drawing.Size(65, 20);
            this.lblLostPwd.TabIndex = 8;
            this.lblLostPwd.TabStop = true;
            this.lblLostPwd.Text = "忘记密码";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(68, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 76);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(337, 381);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblLostPwd);
            this.Controls.Add(this.cboRememberPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaxDownBack = null;
            this.MaximizeBox = false;
            this.MaxMouseBack = null;
            this.MaxNormlBack = null;
            this.MiniDownBack = null;
            this.MinimizeBox = false;
            this.MiniMouseBack = null;
            this.MiniNormlBack = null;
            this.Name = "FrmLogin";
            this.RestoreDownBack = null;
            this.RestoreMouseBack = null;
            this.RestoreNormlBack = null;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Activated += new System.EventHandler(this.FrmLogin_Activated);
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape L2;
        private Microsoft.VisualBasic.PowerPacks.LineShape L1;
        private CCWin.SkinControl.SkinButton btnLogin;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.TextBox txtPwd;
        private CCWin.SkinControl.SkinCheckBox cboRememberPwd;
        private System.Windows.Forms.LinkLabel lblLostPwd;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

