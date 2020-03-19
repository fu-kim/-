using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaMiFood
{
    public partial class FrmMenu : Form
    {

        private Point mPoint;
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Transmit.FrmMenu = this;
            #region 针对窗体、控件双缓冲
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
            #endregion
            lblTime.Text = DateTime.Now.ToShortTimeString();
            lblTime2.Text = DateTime.Now.ToShortDateString();
            //FoodPlayer.URL = Application.StartupPath + @"\Player\视频1.mp4";
            //FoodPlayer.Ctlcontrols.play();
        }
       // Color[] colors = new Color[] { Color.Red, Color.SpringGreen,Color.Blue,Color.Yellow };//颜色数组（其中的颜色自己替换成需要的颜色）
        private void Time_Tick(object sender, EventArgs e)
        {
            #region 轮播图
            //i++;
            //string filePath = Application.StartupPath + "\\tp\\" + i.ToString() + ".jpg";
            //this.PB.Image = Image.FromFile(filePath);
            //if (i == 5)
            //{
            //    i = 0;
            //}
            //if (n >= colors.Length) n = 0;
            //label2.ForeColor = colors[n++]; 
            #endregion
            lblTime.Text = DateTime.Now.ToShortTimeString();
            lblTime2.Text = DateTime.Now.ToShortDateString();

        }
        private void btnDC_Click(object sender, EventArgs e)
        {
            
            int n = 0;
            Random rd = new Random();
            string OrderId = "";
            OrderId += DateTime.Now.Year.ToString();
            OrderId += DateTime.Now.Month.ToString();
            OrderId += DateTime.Now.Day.ToString();
            for (int i = 0; i < 6; i++)
            {
                OrderId += rd.Next(0, 10).ToString();
            }
            n = OrderManager.InsertOrder(OrderId, Convert.ToInt32(lbTableId.Text));
            ScheduleManager.DeleteSchedule();
            TableManager.UpdateTypebyTableId(5,lbTableId.Text);
            TableManager.UpdateTableNowInfo(lbTableId.Text, OrderId, DateTime.Now, 0, null, false);
            if (n>0)
            {
                    // FoodPlayer.Ctlcontrols.stop();
                    FrmFoodMain drm = new FrmFoodMain();
                    FrmFoodInfo ffi = new FrmFoodInfo();

                    drm.lbTable.Text = lbTableId.Text;
                    drm.lbOrderId.Text = OrderId;

                    this.Hide();
                    drm.Show();
               
            }
            else
            {
                Transmit.FrmFoodMain.Tipsk("打开失败请重试！");
            }

        }

        private void FrmMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }
        private void FrmMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
           {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
           }
        }

        private void pbxLogin_MouseMove(object sender, MouseEventArgs e)
        {
            pbxLogin.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\开始点菜2选中.png");
        }

        private void pbxLogin_MouseLeave(object sender, EventArgs e)
        {
            pbxLogin.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\开始点菜2.png");
        }
    }
}
