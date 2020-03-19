namespace AddFood
{
    partial class FrmAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdd));
            this.btnAdd = new CCWin.SkinControl.SkinButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.opdMain = new System.Windows.Forms.OpenFileDialog();
            this.pbxFoodImage = new System.Windows.Forms.PictureBox();
            this.nudtxtFoodTime = new System.Windows.Forms.NumericUpDown();
            this.cboFoodPrice = new System.Windows.Forms.ComboBox();
            this.cboFoodType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoodImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtxtFoodTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.Black;
            this.btnAdd.BorderColor = System.Drawing.Color.Gray;
            this.btnAdd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnAdd.DownBack = null;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(113, 369);
            this.btnAdd.MouseBack = null;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.NormlBack = null;
            this.btnAdd.Size = new System.Drawing.Size(99, 34);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "确定添加";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("方正舒体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(16, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "添加图片";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("方正舒体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(16, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "预计时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("方正舒体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(16, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "菜品价格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("方正舒体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(16, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "菜品类型";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtFoodName.Location = new System.Drawing.Point(113, 91);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(170, 26);
            this.txtFoodName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("方正舒体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(16, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "菜品名称";
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 30;
            this.lineShape1.X2 = 296;
            this.lineShape1.Y1 = 43;
            this.lineShape1.Y2 = 43;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(4, 28);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(326, 392);
            this.shapeContainer1.TabIndex = 28;
            this.shapeContainer1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文行楷", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(94, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 37);
            this.label2.TabIndex = 29;
            this.label2.Text = "添加菜品";
            // 
            // opdMain
            // 
            this.opdMain.FileName = "openFileDialog1";
            // 
            // pbxFoodImage
            // 
            this.pbxFoodImage.BackColor = System.Drawing.Color.White;
            this.pbxFoodImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxFoodImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoodImage.Image")));
            this.pbxFoodImage.Location = new System.Drawing.Point(113, 267);
            this.pbxFoodImage.Name = "pbxFoodImage";
            this.pbxFoodImage.Size = new System.Drawing.Size(171, 97);
            this.pbxFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoodImage.TabIndex = 30;
            this.pbxFoodImage.TabStop = false;
            this.pbxFoodImage.Click += new System.EventHandler(this.pbxFoodImage_Click);
            // 
            // nudtxtFoodTime
            // 
            this.nudtxtFoodTime.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nudtxtFoodTime.Location = new System.Drawing.Point(114, 228);
            this.nudtxtFoodTime.Name = "nudtxtFoodTime";
            this.nudtxtFoodTime.Size = new System.Drawing.Size(168, 29);
            this.nudtxtFoodTime.TabIndex = 32;
            this.nudtxtFoodTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudtxtFoodTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // cboFoodPrice
            // 
            this.cboFoodPrice.Font = new System.Drawing.Font("宋体", 12F);
            this.cboFoodPrice.FormattingEnabled = true;
            this.cboFoodPrice.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "30",
            "60"});
            this.cboFoodPrice.Location = new System.Drawing.Point(114, 182);
            this.cboFoodPrice.Name = "cboFoodPrice";
            this.cboFoodPrice.Size = new System.Drawing.Size(168, 24);
            this.cboFoodPrice.TabIndex = 33;
            // 
            // cboFoodType
            // 
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
            this.cboFoodType.Location = new System.Drawing.Point(113, 138);
            this.cboFoodType.Name = "cboFoodType";
            this.cboFoodType.Size = new System.Drawing.Size(168, 24);
            this.cboFoodType.TabIndex = 34;
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(334, 424);
            this.ControlBoxOffset = new System.Drawing.Point(5, 0);
            this.Controls.Add(this.cboFoodType);
            this.Controls.Add(this.cboFoodPrice);
            this.Controls.Add(this.nudtxtFoodTime);
            this.Controls.Add(this.pbxFoodImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoodImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudtxtFoodTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinButton btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog opdMain;
        private System.Windows.Forms.PictureBox pbxFoodImage;
        private System.Windows.Forms.NumericUpDown nudtxtFoodTime;
        private System.Windows.Forms.ComboBox cboFoodPrice;
        private System.Windows.Forms.ComboBox cboFoodType;
    }
}