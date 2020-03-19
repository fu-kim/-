using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;

namespace KaMiFood
{
    public partial class FrmActivity : UserControl
    {
        public FrmActivity()
        {
            InitializeComponent();
        }

        #region 活动加载事件
        private void FrmActivity_Load(object sender, EventArgs e)
        {
            Transmit.FrmActivity = this;
            flpActivity.Controls.Clear();
            flpTextActivity.Controls.Clear();
            List<Activity> ay = ActivityManager.SelectActivityAll();
            List<TextActivityInfo> tay = TextActivityInfoManager.SelectTextActivityAll();
            for (int i = 0; i < ay.Count; i++)
            {
                flpActivity fa = new flpActivity();
                fa.lbActivityName.Text = ay[i].AName;
                fa.pbxActivityImage.Image = Image.FromFile(Application.StartupPath + @"\Images\活动动态图\" + ay[i].AName + ".gif");
                fa.lbATime.Text = ay[i].ATime.ToLongDateString();
                fa.lbATimeEnd.Text = ay[i].ATimeEnd.ToLongDateString();
                flpActivity.Controls.Add(fa);
            }
            for (int i = 0; i < tay.Count; i++)
            {
                FrmTextActivityInfo tfa = new FrmTextActivityInfo();
                tfa.lbTextActivity.Text = tay[i].AName;
                tfa.lbATime.Text = tay[i].ATime.ToLongDateString();
                tfa.lbATimeEnd.Text = tay[i].ATimeEnd.ToLongDateString();
                flpTextActivity.Controls.Add(tfa);
            }
        }

        #endregion
        string[] color = new string[] { "red", "blue", "Purple"};
        int i = 0;
        #region 轮播条
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGundong.Left -= 5;
            if (lbGundong.Right < 0)
            {
                lbGundong.Left = plGun.Width;
            }
        } 
        #endregion
    }
}
