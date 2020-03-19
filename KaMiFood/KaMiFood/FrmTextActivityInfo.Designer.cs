namespace KaMiFood
{
    partial class FrmTextActivityInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTextActivityInfo));
            this.lbTextActivity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbATime = new System.Windows.Forms.Label();
            this.lbATimeEnd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTextActivity
            // 
            this.lbTextActivity.AutoSize = true;
            this.lbTextActivity.BackColor = System.Drawing.Color.Transparent;
            this.lbTextActivity.Font = new System.Drawing.Font("华文隶书", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTextActivity.ForeColor = System.Drawing.Color.Gold;
            this.lbTextActivity.Location = new System.Drawing.Point(64, 16);
            this.lbTextActivity.Name = "lbTextActivity";
            this.lbTextActivity.Size = new System.Drawing.Size(95, 35);
            this.lbTextActivity.TabIndex = 0;
            this.lbTextActivity.Text = "XXXX";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文隶书", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(325, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "活动时间：";
            // 
            // lbATime
            // 
            this.lbATime.AutoSize = true;
            this.lbATime.BackColor = System.Drawing.Color.Transparent;
            this.lbATime.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbATime.ForeColor = System.Drawing.Color.White;
            this.lbATime.Location = new System.Drawing.Point(436, 25);
            this.lbATime.Name = "lbATime";
            this.lbATime.Size = new System.Drawing.Size(44, 16);
            this.lbATime.TabIndex = 0;
            this.lbATime.Text = "XXXX";
            // 
            // lbATimeEnd
            // 
            this.lbATimeEnd.AutoSize = true;
            this.lbATimeEnd.BackColor = System.Drawing.Color.Transparent;
            this.lbATimeEnd.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbATimeEnd.ForeColor = System.Drawing.Color.White;
            this.lbATimeEnd.Location = new System.Drawing.Point(581, 25);
            this.lbATimeEnd.Name = "lbATimeEnd";
            this.lbATimeEnd.Size = new System.Drawing.Size(44, 16);
            this.lbATimeEnd.TabIndex = 0;
            this.lbATimeEnd.Text = "XXXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文隶书", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.Coral;
            this.label4.Location = new System.Drawing.Point(547, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "至";
            // 
            // FrmTextActivityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbATimeEnd);
            this.Controls.Add(this.lbATime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTextActivity);
            this.Name = "FrmTextActivityInfo";
            this.Size = new System.Drawing.Size(725, 63);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lbATime;
        public System.Windows.Forms.Label lbATimeEnd;
        public System.Windows.Forms.Label lbTextActivity;
        private System.Windows.Forms.Timer timer1;
    }
}
