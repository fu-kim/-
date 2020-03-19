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
    public partial class FrmSchedule : UserControl
    {
        public FrmSchedule()
        {
            InitializeComponent();
        }

        #region 进度加载事件
        private void FrmSchedule_Load(object sender, EventArgs e)
        {
            Transmit.FrmSchedule = this;
            flpSchedule.Controls.Clear();
            List<Schedule> sds = ScheduleManager.selectSchedule();
            #region 加载订单
            if (sds.Count == 0)
            {
                FrmImage2 fi2 = new FrmImage2();
                plSchedule.Controls.Clear();
                plSchedule.Controls.Add(fi2);
            }
            else
            {
                lbFTime.Text = sds[0].FTime.Substring(0, 5);
                lbFNumber.Text = sds[0].FNumber.ToString();
                lbOrderId.Text = sds[0].OrderId;
                lbFName.Text = sds[0].FName;
                pbxFImage.Image = Image.FromFile(Application.StartupPath + @"\Images\食物\" + sds[0].FName + ".jpg");
                for (int i = 0; i < sds.Count; i++)
                {
                    flpSchedules fs = new flpSchedules();
                    fs.lbFName.Text = sds[i].FName;
                    fs.lbOrderId.Text = sds[i].OrderId;
                    flpSchedule.Controls.Add(fs);
                }
            }

            #endregion

        }
        #endregion

        #region 催单鼠标移动事件
        private void pbxReminder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxReminder.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\催单选中.png");
        }

        private void pbxReminder_MouseLeave(object sender, EventArgs e)
        {
            pbxReminder.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\催单.png");
        }

        #endregion
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbGundong.Left -= 5;
            if (lbGundong.Right < 0)
            {
                lbGundong.Left = plGun.Width;
            }
            string NowTime= DateTime.Now.Date.ToLongTimeString();
            string FoodTime = lbFTime.Text;
            if (NowTime == FoodTime)
            {

            }
        }

        private void pbxReminder_Click(object sender, EventArgs e)
        {
            if (Transmit.FrmFoodMain.Tipskc("是否要叫催单?"))
            {
                TableManager.UpdateIsService(Transmit.FrmFoodMain.lbTable.Text, 2);
            }
        }
    }
}
