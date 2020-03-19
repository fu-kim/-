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
    public partial class flpSchedules : UserControl
    {
        public flpSchedules()
        {
            InitializeComponent();
        }

        #region 查看鼠标移动事件
        private void pbxSee_MouseMove(object sender, MouseEventArgs e)
        {
            pbxSee.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\查看选中.png");
        }

        private void pbxSee_MouseLeave(object sender, EventArgs e)
        {
            pbxSee.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\查看.png");
        }
        #endregion

        private void pbxSee_Click(object sender, EventArgs e)
        {
            List<Schedule> sds = ScheduleManager.selectScheduleByOrderIdFName(lbOrderId.Text,lbFName.Text);
            for (int i = 0; i < sds.Count; i++)
            {
   
                Transmit.FrmSchedule.lbFTime.Text = sds[i].FTime.Substring(0, 5);
                Transmit.FrmSchedule.lbFNumber.Text = sds[i].FNumber.ToString() ;
                Transmit.FrmSchedule.lbOrderId.Text = sds[i].OrderId;
                Transmit.FrmSchedule.lbFName.Text = sds[i].FName; ;
                Transmit.FrmSchedule.pbxFImage.Image = Image.FromFile(Application.StartupPath + @"\Images\食物\"+ sds[i].FName + ".jpg") ;
            }
            
        }
    }
}
