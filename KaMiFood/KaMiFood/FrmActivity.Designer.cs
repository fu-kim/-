namespace KaMiFood
{
    partial class FrmActivity
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
            this.flpActivity = new System.Windows.Forms.FlowLayoutPanel();
            this.plGun = new System.Windows.Forms.Panel();
            this.lbGundong = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flpTextActivity = new System.Windows.Forms.FlowLayoutPanel();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.plGun.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpActivity
            // 
            this.flpActivity.AutoScroll = true;
            this.flpActivity.BackColor = System.Drawing.Color.Transparent;
            this.flpActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpActivity.Location = new System.Drawing.Point(3, 285);
            this.flpActivity.Name = "flpActivity";
            this.flpActivity.Size = new System.Drawing.Size(766, 348);
            this.flpActivity.TabIndex = 0;
            // 
            // plGun
            // 
            this.plGun.Controls.Add(this.lbGundong);
            this.plGun.Location = new System.Drawing.Point(3, 3);
            this.plGun.Name = "plGun";
            this.plGun.Size = new System.Drawing.Size(766, 28);
            this.plGun.TabIndex = 1;
            // 
            // lbGundong
            // 
            this.lbGundong.AutoSize = true;
            this.lbGundong.Font = new System.Drawing.Font("华文琥珀", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbGundong.ForeColor = System.Drawing.Color.White;
            this.lbGundong.Location = new System.Drawing.Point(301, 2);
            this.lbGundong.Name = "lbGundong";
            this.lbGundong.Size = new System.Drawing.Size(388, 22);
            this.lbGundong.TabIndex = 0;
            this.lbGundong.Text = "本店开业大酬宾！！！推出以下活动！！";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // flpTextActivity
            // 
            this.flpTextActivity.AutoScroll = true;
            this.flpTextActivity.BackColor = System.Drawing.Color.Transparent;
            this.flpTextActivity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flpTextActivity.Location = new System.Drawing.Point(3, 37);
            this.flpTextActivity.Name = "flpTextActivity";
            this.flpTextActivity.Size = new System.Drawing.Size(766, 220);
            this.flpTextActivity.TabIndex = 2;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.White;
            this.lineShape3.BorderWidth = 2;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 17;
            this.lineShape3.X2 = 752;
            this.lineShape3.Y1 = 264;
            this.lineShape3.Y2 = 264;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3});
            this.shapeContainer1.Size = new System.Drawing.Size(772, 636);
            this.shapeContainer1.TabIndex = 3;
            this.shapeContainer1.TabStop = false;
            // 
            // FrmActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flpTextActivity);
            this.Controls.Add(this.plGun);
            this.Controls.Add(this.flpActivity);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "FrmActivity";
            this.Size = new System.Drawing.Size(772, 636);
            this.Load += new System.EventHandler(this.FrmActivity_Load);
            this.plGun.ResumeLayout(false);
            this.plGun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpActivity;
        private System.Windows.Forms.Panel plGun;
        private System.Windows.Forms.Label lbGundong;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flpTextActivity;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
    }
}
