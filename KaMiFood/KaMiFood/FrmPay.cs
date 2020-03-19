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
    public partial class FrmPay : UserControl
    {
        public FrmPay()
        {
            InitializeComponent();

        }
        #region 结账界面加载事件
        public void FrmPay_Load(object sender, EventArgs e)
        {
            decimal sumPay = 0;
            Transmit.FrmPay = this;
            flpPayMain.Controls.Clear();
            string OrderId = Transmit.FrmFoodMain.lbOrderId.Text;
            List<Order> od = OrderManager.SelectOrderInfo(OrderId);
            if (Transmit.FrmFoodMain.llbVIP.Text == "未登录")
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

                    FrmOrderInfo foi = new FrmOrderInfo();
                    foi.BackgroundImage = Image.FromFile(Application.StartupPath + @"\Images\主界面\已结账.png");
                    foi.pbxAdd.Enabled = false;
                    foi.pbxMinus.Enabled = false;
                    foi.flpSpicy.Enabled = false;
                    foi.pbxImage.Image = Image.FromFile(Application.StartupPath + @"\Images\食物\" + od[i].FName + ".jpg");
                    foi.lbFoodName.Text = od[i].FName;
                    List<Order> ods = OrderManager.SelectSpicy(OrderId, od[i].FName);
                    for (int j = 0; j < ods.Count; j++)
                    {
                        flpSpicy fs = new flpSpicy();
                        fs.lbSpicy.Text = ods[j].Spicy;
                        fs.lbNunber.Text = (j + 1).ToString();

                        foi.flpSpicy.Controls.Add(fs);
                    }
                    foi.lbFNumber.Text = od[i].FNumber.ToString();
                    foi.lbRMB.Text = od[i].FPrice.ToString().Substring(0, 5);
                    double vipsum = Convert.ToDouble(foi.lbRMB.Text);
                    foi.lbVIP.Text = (vipsum * 0.8).ToString();
                    flpPayMain.Controls.Add(foi);
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
                    FrmOrderInfo foi = new FrmOrderInfo();
                    foi.pbxImage.Image = Image.FromFile(Application.StartupPath + @"\Images\食物\" + od[i].FName + ".jpg");
                    foi.lbFoodName.Text = od[i].FName;
                    List<Order> ods = OrderManager.SelectSpicy(OrderId, od[i].FName);
                    for (int j = 0; j < ods.Count; j++)
                    {
                        flpSpicy fs = new flpSpicy();
                        fs.lbSpicy.Text = ods[j].Spicy;
                        fs.lbNunber.Text = (j + 1).ToString(); ;
                        fs.lbFName.Text = od[i].FName;

                        foi.flpSpicy.Controls.Add(fs);
                    }
                    foi.lbFNumber.Text = od[i].FNumber.ToString();
                    foi.lbRMB.Text = od[i].FPrice.ToString().Substring(0, 5);
                    double vipsum = Convert.ToDouble(foi.lbRMB.Text);
                    foi.lbVIP.Text = (vipsum*0.8).ToString();
                    flpPayMain.Controls.Add(foi);
                }
                #endregion
            }
        }
        #endregion

        #region 买单鼠标移动事件
        private void pbxPay_MouseMove(object sender, MouseEventArgs e)
        {
            pbxPay.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\买单选中.png");
        }

        private void pbxPay_MouseLeave(object sender, EventArgs e)
        {
            pbxPay.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\买单.png");
        }
        #endregion

        #region 结账
        private void pbxPay_Click(object sender, EventArgs e)
        {
            if (lbSumRmb.Text == "0")
            {
                MessageBox.Show("请去点菜！");
            }
            else
            {
                string OrderId = Transmit.FrmFoodMain.lbOrderId.Text;
                double SumPrice = Convert.ToDouble(lbSumRmb.Text);
                FrmPaying fpi = new FrmPaying();
                fpi.lbOrderId.Text = OrderId;
                fpi.lbSum.Text = SumPrice.ToString();
                fpi.lbMemberSum.Text = (SumPrice * 0.8).ToString();
                fpi.lbYouHui.Text = (SumPrice - (SumPrice * 0.8)).ToString();
                if (Transmit.FrmFoodMain.llbVIP.Text != "未登录")
                {
                    fpi.lbYinFu.Text = (SumPrice * 0.8).ToString();
                }
                else
                {
                    fpi.lbYinFu.Text = SumPrice.ToString();
                }
                fpi.ShowDialog();
            }
        }
        #endregion

    }
}
