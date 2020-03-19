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
    public partial class FrmFoodMain : Form
    {
        List<Form> allforms = new List<Form>();
        public bool IsPays = false;
        public string sel = "";
        public FrmFoodMain()
        {
            InitializeComponent();
        }
        #region 提示框
        public bool Tipsk(string str)
        {
            FrmTips ft = new FrmTips();
            ft.lbTips.Text = str;
            ft.ShowDialog();
            return ft.Ok;
        }
        public bool Tipskc(string str)
        {
            FrmTipsOKCancel ftoc = new FrmTipsOKCancel();
            ftoc.lbTips.Text = str;
            ftoc.ShowDialog();
            return ftoc.Ok;
        } 
        #endregion

        #region 程序退出   
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("是否要退出?", "退出提示",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                TableManager.UpdateTypebyTableId(1, Transmit.FrmMenu.lbTableId.Text);
                Application.Exit();
            }
        }
        #endregion

        #region 返回菜单界面    
        private void btnUp_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            this.Hide();
            frm.Show();
        }
        #endregion

        #region 无边框鼠标移动  
        private Point mPoint;
        private void FrmFoodMain_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void FrmFoodMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        #region 判断界面是否选中
        public void select(string food)
        {
            if (food == "菜品")
            {
                pbxFood.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\菜品选中.png");
            }
            else
            {
                pbxFood.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\菜品.png");
            }

            if (food == "进度")
            {
                pbxSchedule.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\进度选中.png");
            }
            else
            {
                pbxSchedule.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\进度.png");
            }

            if (food == "结账")
            {
                pbxPay.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\结账选中.png");
            }
            else
            {
                pbxPay.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\结账.png");
            }

            if (food == "活动")
            {
                pbxActivity.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\活动选中.png");
            }
            else
            {
                pbxActivity.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\活动.png");
            }
        } 
        #endregion

        #region 窗体加载事件
        private void FrmFoodMain_Load(object sender, EventArgs e)
        {
            Transmit.FrmFoodMain = this;
            pbxFood.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\菜品选中.png");
            FrmFood ff = new FrmFood();
            ff.Show();
            plMain.Controls.Clear();
            plMain.Controls.Add(ff);                    
            sel = "菜品";
            pbxPay_Click(sender, e);
            pbxFood_Click(sender, e);
        }

        #endregion

        #region 鼠标移动效果
        #region 菜品鼠标移效果
        private void pbxFood_MouseMove(object sender, MouseEventArgs e)
        {
            pbxFood.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\菜品选中.png");
        }

        private void pbxFood_MouseLeave(object sender, EventArgs e)
        {
            select(sel);    
        }
        #endregion
        #region 进度鼠标移动效果
        private void pbxSchedule_MouseMove(object sender, MouseEventArgs e)
        {
            pbxSchedule.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\进度选中.png");
        }

        private void pbxSchedule_MouseLeave(object sender, EventArgs e)
        {
            select(sel);
        }
        #endregion
        #region 结账鼠标移动效果
        private void pbxPay_MouseMove(object sender, MouseEventArgs e)
        {
            pbxPay.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\结账选中.png");
        }

        private void pbxPay_MouseLeave(object sender, EventArgs e)
        {
            select(sel);
        }
        #endregion
        #region 活动鼠标移动效果
        private void pbxActivity_MouseMove(object sender, MouseEventArgs e)
        {
            pbxActivity.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\活动选中.png");
        }

        private void pbxActivity_MouseLeave(object sender, EventArgs e)
        {
            select(sel);
        }

        #endregion
        //#region 查看订单鼠标移动事件
        //private void pbxOrder_MouseMove(object sender, MouseEventArgs e)
        //{
        //    pbxOrder.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\查看订单选中.png");
        //}

        //private void pbxOrder_MouseLeave(object sender, EventArgs e)
        //{
        //    pbxOrder.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\查看订单.png");
        //}
        //#endregion
        //#region 服务按钮鼠标移动事件

        //private void pbxService_MouseMove(object sender, MouseEventArgs e)
        //{
        //    pbxService.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\服务按钮选中.png");
        //}

        //private void pbxService_MouseLeave(object sender, EventArgs e)
        //{
        //    pbxService.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\服务按钮.png");
        //}
        //#endregion

        #endregion

        #region 界面打开
        #region 打开菜品界面
        private void pbxFood_Click(object sender, EventArgs e)
        {
            FrmFood ff = new FrmFood();
            ff.Show();
            plMain.Controls.Clear();
            plMain.Controls.Add(ff);
            pbxFood.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\菜品选中.png");
            pbxSchedule.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\进度.png");
            pbxPay.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\结账.png");
            pbxActivity.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\活动.png");
            sel = "菜品";
        }

        #endregion
        #region 打开进度界面
        private void pbxSchedule_Click(object sender, EventArgs e)
        {
            FrmSchedule fs = new FrmSchedule();
            fs.Show();
            plMain.Controls.Clear();
            plMain.Controls.Add(fs);
            pbxFood.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\菜品.png");
            pbxPay.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\结账.png");
            pbxActivity.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\活动.png");
            sel = "进度";
        }

        #endregion
        #region 打开结账界面
        public void pbxPay_Click(object sender, EventArgs e)
        {
            FrmPay fp = new FrmPay();
            fp.Show();
            plMain.Controls.Clear();
            plMain.Controls.Add(fp);
            pbxFood.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\菜品.png");
            pbxSchedule.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\进度.png");
            pbxPay.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\结账选中.png");
            pbxActivity.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\活动.png");
            sel = "结账";
        }

        #endregion
        #region 打开活动界面
        public void pbxActivity_Click(object sender, EventArgs e)
        {
            FrmActivity fa = new FrmActivity();
            fa.Show();
            plMain.Controls.Clear();
            plMain.Controls.Add(fa);
            pbxFood.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\菜品.png");
            pbxSchedule.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\进度.png");
            pbxPay.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\结账.png");
            sel = "活动";
        }
        #endregion

        #endregion

        #region 选择菜的类型方法
        #region 选择菜类型
        public void selectFoodType(object sender, EventArgs e)
        {
            pbxFood.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\菜品选中.png");
            pbxSchedule.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\进度.png");
            pbxPay.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\结账.png");
            pbxActivity.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\活动.png");
            pbxFood_Click(sender, e);
        }
        #endregion
        #region 热菜界面
        private void pbxHotDishes_Click(object sender, EventArgs e)
        {
            selectFoodType(sender, e);
        }

        #endregion
        #region 凉菜界面
        private void pbxColdDishes_Click(object sender, EventArgs e)
        {
            selectFoodType(sender, e);
        }

        #endregion
        #region 汤类界面
        private void pbxSoup_Click(object sender, EventArgs e)
        {
            selectFoodType(sender, e);
        }

        #endregion
        #region 酒水界面
        private void pbxWine_Click(object sender, EventArgs e)
        {
            selectFoodType(sender, e);
        }

        #endregion
        #region 其他界面
        private void pbxOther_Click(object sender, EventArgs e)
        {
            selectFoodType(sender, e);
        }
        #endregion

        #endregion

        #region 打开订单事件
        private static FrmOrder fo;
        private void pbxOrder_Click(object sender, EventArgs e)
        {
            if (fo == null || fo.IsDisposed)
            {
                pbxOrder.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\查看订单选中.png");
                fo = new FrmOrder();
                fo.Show();
            }
            else
            {
                pbxOrder.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\查看订单.png");
                fo.Close();
            }
        }
        #endregion

        #region 轮播条
        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Order> od = OrderManager.SelectOrderInfo(lbOrderId.Text);
            lbCount.Text = od.Count.ToString();
            lbGundong.Left -= 5;
            if (lbGundong.Right < 0)
            {
                lbGundong.Left = plGun.Width;
            }
        }

        #endregion

        #region 关闭窗口时，删除进度信息
        private void FrmFoodMain_FormClosing(object sender, FormClosingEventArgs e)
        {
           ScheduleManager.DeleteSchedule();
            OrderManager.DeletePay();
            TableManager.UpdateTypebyTableId(1, Transmit.FrmMenu.lbTableId.Text);
        }
        #endregion

        #region 服务按钮
        private void pbxService_Click(object sender, EventArgs e)
        {
            if (Tipskc("是否要叫服务?"))
            {
                pbxService.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\服务按钮选中.png");
                TableManager.UpdateIsService(lbTable.Text,1);
                Console.WriteLine("呼叫成功！");
                timer2.Enabled = true;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            object n = TableManager.SelectTableIsService(lbTable.Text);
            if (Convert.ToInt32(n) == 0)
            {
                timer2.Enabled = false;
                pbxService.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\服务按钮.png");
            }
        }
        #endregion

        #region 打开VIP
        private void llbVIP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmVIPLogin fvl = new FrmVIPLogin();
            fvl.ShowDialog();
        }

        #endregion

    }
}
