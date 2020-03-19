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
    public partial class FrmOrder : Form
    {
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Transmit.FrmFoodMain.pbxOrder.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\查看订单.png");
        }

        public void FrmOrder_Load(object sender, EventArgs e)
        {
            decimal sumPay = 0;
            Transmit.FrmOrder = this;
            flpPayMain.Controls.Clear();
            string OrderId = Transmit.FrmFoodMain.lbOrderId.Text;
            List<Order> od = OrderManager.SelectOrderInfo(OrderId);
            if (Transmit.FrmFoodMain.llbVIP.Text=="未登录")
            {
                lbviphj.Visible = false;
                lbVIPSum.Visible = false;
                lbsumhj.Visible = true;
                lbSumRmb.Visible = true;
            }
            else
            {
                lbviphj.Visible = true;
                lbVIPSum.Visible = true;
                lbsumhj.Visible = false;
                lbSumRmb.Visible = false;
            }
            if (Transmit.FrmFoodMain.IsPays)
            {
                lbSumRmb.Text = "0";
                #region 加载订单
                for (int i = 0; i < od.Count; i++)
                {

                    FrmOrderInfo2 foi2 = new FrmOrderInfo2();
                    foi2.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Images\主界面\小已结账框.png");
                    foi2.pbxAdd.Enabled = false;
                    foi2.pbxMinus.Enabled = false;
                    foi2.pbxImage.Image = Image.FromFile(Application.StartupPath + @"\Images\食物\" + od[i].FName + ".jpg");
                    foi2.lbFName.Text = od[i].FName;
                    foi2.lbFNumber.Text = od[i].FNumber.ToString();
                    foi2.lbRMB.Text = od[i].FPrice.ToString().Substring(0, 5);
                    double vipsum = Convert.ToDouble(foi2.lbRMB.Text);
                    foi2.lbVIP.Text = (vipsum * 0.8).ToString();
                    flpPayMain.Controls.Add(foi2);
                }
                #endregion
            }
            else
            {
                #region 判断是否有订单
                if (od.Count == 0)
                {
                    lbSumRmb.Text = "0";
                    FrmImage fi = new FrmImage();
                    flpPayMain.Controls.Add(fi);
                }
                #endregion
                #region 加载订单
                for (int i = 0; i < od.Count; i++)
                {
                    sumPay += od[i].FPrice * od[i].FNumber;
                    lbSumRmb.Text = sumPay.ToString().Substring(0, 5);
                    double Vipsum = Convert.ToDouble(lbSumRmb.Text);
                    lbVIPSum.Text = (Vipsum * 0.8).ToString();
                    FrmOrderInfo2 foi2 = new FrmOrderInfo2();
                    foi2.pbxImage.Image = Image.FromFile(Application.StartupPath + @"\Images\食物\" + od[i].FName + ".jpg");
                    foi2.lbFName.Text = od[i].FName;
                    foi2.lbFNumber.Text = od[i].FNumber.ToString();
                    foi2.lbRMB.Text = od[i].FPrice.ToString().Substring(0, 5);
                    double vipsum = Convert.ToDouble(foi2.lbRMB.Text);
                    foi2.lbVIP.Text = (vipsum * 0.8).ToString();
                    flpPayMain.Controls.Add(foi2);
                }
                #endregion
            }
        }

        #region 去结账鼠标移动事件
        private void pbxPay_MouseMove(object sender, MouseEventArgs e)
        {
            pbxPay.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\去结账选中.png");
        }

        private void pbxPay_MouseLeave(object sender, EventArgs e)
        {
            pbxPay.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\去结账.png");
        }
        #endregion

        private void pbxPay_Click(object sender, EventArgs e)
        {
            this.Close();
            Transmit.FrmFoodMain.pbxPay_Click(sender, e);
        }
    }
}
