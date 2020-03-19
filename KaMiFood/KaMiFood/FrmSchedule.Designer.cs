namespace KaMiFood
{
    partial class FrmSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSchedule));
            this.flpSchedule = new System.Windows.Forms.FlowLayoutPanel();
            this.lbFTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFName = new System.Windows.Forms.Label();
            this.lbFNumber = new System.Windows.Forms.Label();
            this.plGun = new System.Windows.Forms.Panel();
            this.lbGundong = new System.Windows.Forms.Label();
            this.lbOrderId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbxFImage = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxReminder = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plSchedule = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.plGun.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReminder)).BeginInit();
            this.plSchedule.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSchedule
            // 
            this.flpSchedule.AutoScroll = true;
            this.flpSchedule.BackColor = System.Drawing.Color.Transparent;
            this.flpSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpSchedule.ForeColor = System.Drawing.Color.Transparent;
            this.flpSchedule.Location = new System.Drawing.Point(4, 4);
            this.flpSchedule.Name = "flpSchedule";
            this.flpSchedule.Size = new System.Drawing.Size(753, 104);
            this.flpSchedule.TabIndex = 0;
            // 
            // lbFTime
            // 
            this.lbFTime.AutoSize = true;
            this.lbFTime.BackColor = System.Drawing.Color.Transparent;
            this.lbFTime.Font = new System.Drawing.Font("华文新魏", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFTime.ForeColor = System.Drawing.Color.Gold;
            this.lbFTime.Location = new System.Drawing.Point(289, 347);
            this.lbFTime.Name = "lbFTime";
            this.lbFTime.Size = new System.Drawing.Size(272, 81);
            this.lbFTime.TabIndex = 1;
            this.lbFTime.Text = "XX:XX";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbFName);
            this.panel1.Controls.Add(this.lbFNumber);
            this.panel1.Controls.Add(this.plGun);
            this.panel1.Controls.Add(this.lbOrderId);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pbxFImage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbFTime);
            this.panel1.Controls.Add(this.pbxReminder);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 488);
            this.panel1.TabIndex = 2;
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.BackColor = System.Drawing.Color.Transparent;
            this.lbFName.Font = new System.Drawing.Font("华文行楷", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFName.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbFName.Location = new System.Drawing.Point(24, 313);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(122, 37);
            this.lbFName.TabIndex = 5;
            this.lbFName.Text = "XXXXX";
            // 
            // lbFNumber
            // 
            this.lbFNumber.AutoSize = true;
            this.lbFNumber.Font = new System.Drawing.Font("华文新魏", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFNumber.ForeColor = System.Drawing.Color.Yellow;
            this.lbFNumber.Location = new System.Drawing.Point(480, 448);
            this.lbFNumber.Name = "lbFNumber";
            this.lbFNumber.Size = new System.Drawing.Size(36, 25);
            this.lbFNumber.TabIndex = 3;
            this.lbFNumber.Text = "xx";
            // 
            // plGun
            // 
            this.plGun.Controls.Add(this.lbGundong);
            this.plGun.Location = new System.Drawing.Point(15, 9);
            this.plGun.Name = "plGun";
            this.plGun.Size = new System.Drawing.Size(712, 24);
            this.plGun.TabIndex = 4;
            // 
            // lbGundong
            // 
            this.lbGundong.AutoSize = true;
            this.lbGundong.BackColor = System.Drawing.Color.Transparent;
            this.lbGundong.Font = new System.Drawing.Font("方正姚体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbGundong.ForeColor = System.Drawing.Color.Orange;
            this.lbGundong.Location = new System.Drawing.Point(298, -3);
            this.lbGundong.Name = "lbGundong";
            this.lbGundong.Size = new System.Drawing.Size(132, 27);
            this.lbGundong.TabIndex = 2;
            this.lbGundong.Text = "请耐心等待";
            // 
            // lbOrderId
            // 
            this.lbOrderId.AutoSize = true;
            this.lbOrderId.Font = new System.Drawing.Font("华文新魏", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbOrderId.ForeColor = System.Drawing.Color.Orange;
            this.lbOrderId.Location = new System.Drawing.Point(125, 445);
            this.lbOrderId.Name = "lbOrderId";
            this.lbOrderId.Size = new System.Drawing.Size(60, 25);
            this.lbOrderId.TabIndex = 2;
            this.lbOrderId.Text = "xxxx";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("方正姚体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Snow;
            this.label4.Location = new System.Drawing.Point(390, 443);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "份数：";
            // 
            // pbxFImage
            // 
            this.pbxFImage.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pbxFImage.Location = new System.Drawing.Point(89, 39);
            this.pbxFImage.Name = "pbxFImage";
            this.pbxFImage.Size = new System.Drawing.Size(616, 271);
            this.pbxFImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFImage.TabIndex = 2;
            this.pbxFImage.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("方正姚体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(26, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "订单号：";
            // 
            // pbxReminder
            // 
            this.pbxReminder.BackColor = System.Drawing.Color.Transparent;
            this.pbxReminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxReminder.Image = ((System.Drawing.Image)(resources.GetObject("pbxReminder.Image")));
            this.pbxReminder.Location = new System.Drawing.Point(648, 323);
            this.pbxReminder.Name = "pbxReminder";
            this.pbxReminder.Size = new System.Drawing.Size(109, 162);
            this.pbxReminder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxReminder.TabIndex = 0;
            this.pbxReminder.TabStop = false;
            this.pbxReminder.Click += new System.EventHandler(this.pbxReminder_Click);
            this.pbxReminder.MouseLeave += new System.EventHandler(this.pbxReminder_MouseLeave);
            this.pbxReminder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxReminder_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("方正姚体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(113, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "预计上菜时间：";
            // 
            // plSchedule
            // 
            this.plSchedule.BackColor = System.Drawing.Color.Transparent;
            this.plSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.plSchedule.Controls.Add(this.panel3);
            this.plSchedule.Controls.Add(this.panel1);
            this.plSchedule.Controls.Add(this.shapeContainer1);
            this.plSchedule.Location = new System.Drawing.Point(3, 3);
            this.plSchedule.Name = "plSchedule";
            this.plSchedule.Size = new System.Drawing.Size(766, 630);
            this.plSchedule.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.flpSchedule);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 115);
            this.panel3.TabIndex = 4;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(766, 630);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.White;
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 23;
            this.lineShape3.X2 = 746;
            this.lineShape3.Y1 = 128;
            this.lineShape3.Y2 = 127;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.plSchedule);
            this.Name = "FrmSchedule";
            this.Size = new System.Drawing.Size(772, 636);
            this.Load += new System.EventHandler(this.FrmSchedule_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.plGun.ResumeLayout(false);
            this.plGun.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxReminder)).EndInit();
            this.plSchedule.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSchedule;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGundong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxReminder;
        private System.Windows.Forms.Panel plSchedule;
        public System.Windows.Forms.Label lbFNumber;
        public System.Windows.Forms.Label lbOrderId;
        public System.Windows.Forms.Label lbFTime;
        public System.Windows.Forms.PictureBox pbxFImage;
        private System.Windows.Forms.Panel plGun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lbFName;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
    }
}
