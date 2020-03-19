namespace KaMiFood
{
    partial class flpSpicy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flpSpicy));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbFName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNunber = new System.Windows.Forms.Label();
            this.pbxSpicyMinus = new System.Windows.Forms.PictureBox();
            this.lbSpicy = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpicyMinus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbFName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbNunber);
            this.panel1.Controls.Add(this.pbxSpicyMinus);
            this.panel1.Controls.Add(this.lbSpicy);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 34);
            this.panel1.TabIndex = 0;
            // 
            // lbFName
            // 
            this.lbFName.AutoSize = true;
            this.lbFName.BackColor = System.Drawing.Color.Transparent;
            this.lbFName.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFName.ForeColor = System.Drawing.Color.IndianRed;
            this.lbFName.Location = new System.Drawing.Point(55, 1);
            this.lbFName.Name = "lbFName";
            this.lbFName.Size = new System.Drawing.Size(69, 30);
            this.lbFName.TabIndex = 5;
            this.lbFName.Text = "XXXX";
            this.lbFName.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(-2, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "第";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文琥珀", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(45, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "份";
            // 
            // lbNunber
            // 
            this.lbNunber.AutoSize = true;
            this.lbNunber.BackColor = System.Drawing.Color.Transparent;
            this.lbNunber.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNunber.ForeColor = System.Drawing.Color.IndianRed;
            this.lbNunber.Location = new System.Drawing.Point(22, 3);
            this.lbNunber.Name = "lbNunber";
            this.lbNunber.Size = new System.Drawing.Size(27, 30);
            this.lbNunber.TabIndex = 2;
            this.lbNunber.Text = "X";
            // 
            // pbxSpicyMinus
            // 
            this.pbxSpicyMinus.BackColor = System.Drawing.Color.Transparent;
            this.pbxSpicyMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxSpicyMinus.Image = ((System.Drawing.Image)(resources.GetObject("pbxSpicyMinus.Image")));
            this.pbxSpicyMinus.Location = new System.Drawing.Point(174, 2);
            this.pbxSpicyMinus.Name = "pbxSpicyMinus";
            this.pbxSpicyMinus.Size = new System.Drawing.Size(30, 30);
            this.pbxSpicyMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSpicyMinus.TabIndex = 1;
            this.pbxSpicyMinus.TabStop = false;
            this.pbxSpicyMinus.Click += new System.EventHandler(this.pbxSpicyMinus_Click);
            this.pbxSpicyMinus.MouseLeave += new System.EventHandler(this.pbxSpicy_MouseLeave);
            this.pbxSpicyMinus.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbxSpicy_MouseMove);
            // 
            // lbSpicy
            // 
            this.lbSpicy.AutoSize = true;
            this.lbSpicy.BackColor = System.Drawing.Color.Transparent;
            this.lbSpicy.Font = new System.Drawing.Font("华文琥珀", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSpicy.ForeColor = System.Drawing.Color.IndianRed;
            this.lbSpicy.Location = new System.Drawing.Point(78, 2);
            this.lbSpicy.Name = "lbSpicy";
            this.lbSpicy.Size = new System.Drawing.Size(69, 30);
            this.lbSpicy.TabIndex = 0;
            this.lbSpicy.Text = "XXXX";
            // 
            // flpSpicy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.panel1);
            this.Name = "flpSpicy";
            this.Size = new System.Drawing.Size(213, 40);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSpicyMinus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxSpicyMinus;
        public System.Windows.Forms.Label lbSpicy;
        public System.Windows.Forms.Label lbNunber;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbFName;
    }
}
