using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaMiFood
{
    public partial class flpActivity : UserControl
    {
        public flpActivity()
        {
            InitializeComponent();
        }

        #region 查看详情鼠标移动事件
        private void pbxFind_MouseMove(object sender, MouseEventArgs e)
        {
            pbxFind.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\查看详情选中.png");
        }

        private void pbxFind_MouseLeave(object sender, EventArgs e)
        {
            pbxFind.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\查看详情.png");
        }
        #endregion

        #region 查看详情事件
        private void pbxFind_Click(object sender, EventArgs e)
        {
            Transmit.FrmFoodMain.plMain.Controls.Clear();
            FrmActivityInfo fai = new FrmActivityInfo();
            fai.lbActivityName.Text = lbActivityName.Text;
            Transmit.FrmFoodMain.plMain.Controls.Add(fai);
        }
        #endregion

        string[] color = new string[] { "red", "blue", "Purple", "green", "Orange" };
        int i=0;

        #region 变色
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == color.Length - 1)
            {
                i = 0;
            }
            else
            {
                i++;
            }
            lbActivityName.ForeColor = Color.FromName(color[i]);
        } 
        #endregion
    }
}
