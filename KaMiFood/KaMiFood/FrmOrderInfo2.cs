using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace KaMiFood
{
    public partial class FrmOrderInfo2 : UserControl
    {
        public FrmOrderInfo2()
        {
            InitializeComponent();
        }

        #region 加减鼠标移动事件
        private void pbxAdd_MouseMove(object sender, MouseEventArgs e)
        {
            pbxAdd.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\添加选中.png");
        }

        private void pbxAdd_MouseLeave(object sender, EventArgs e)
        {
            pbxAdd.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\添加.png");
        }

        private void pbxMinus_MouseMove(object sender, MouseEventArgs e)
        {
            pbxMinus.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\删减选中.png");
        }

        private void pbxMinus_MouseLeave(object sender, EventArgs e)
        {
            pbxMinus.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\删减.png");
        }
        #endregion
        public decimal sumPay = 0;
        private void pbxAdd_Click(object sender, EventArgs e)
        {
            sumPay = Convert.ToDecimal(Transmit.FrmOrder.lbSumRmb.Text);
            string OrderId = Transmit.FrmFoodMain.lbOrderId.Text;
            List<Activity> ay = ActivityManager.SelectActivityFoodAll(lbFName.Text);
            if (ay == null)
            {  
                int n = OrderManager.UpdateAddFNumber(lbFName.Text, OrderId);
                if (n > 0)
                {
                    lbFNumber.Text = (Convert.ToInt32(lbFNumber.Text) + 1).ToString();
                    sumPay += Convert.ToDecimal(lbRMB.Text);
                    Transmit.FrmPay.lbSumRmb.Text = sumPay.ToString();
                    Transmit.FrmOrder.lbSumRmb.Text = sumPay.ToString();
                    Transmit.FrmFoodMain.Tipsk("加菜成功");
                }
            }
            else
            {
                object FType = FoodManager.SelectFoodType(lbFName.Text);
                if (FType.ToString() == "1")
                {
                    FrmFlavor ff = new FrmFlavor();
                    ff.Text = "Order";
                    ff.FName = lbFName.Text;
                    ff.FPrice = Convert.ToDecimal(lbRMB.Text);
                    ff.ShowDialog();
                }
                else
                {
                    int n = OrderManager.UpdateAddFNumber(lbFName.Text, OrderId);
                    if (n > 0)
                    {
                        lbFNumber.Text = (Convert.ToInt32(lbFNumber.Text) + 1).ToString();
                        sumPay += Convert.ToDecimal(lbRMB.Text);
                        Transmit.FrmPay.lbSumRmb.Text = sumPay.ToString();
                        double vipsum = Convert.ToDouble(sumPay);
                        Transmit.FrmPay.lbVIPSum.Text = (vipsum * 0.8).ToString();
                        Transmit.FrmOrder.lbSumRmb.Text = sumPay.ToString();
                        Transmit.FrmOrder.lbVIPSum.Text = (vipsum * 0.8).ToString();
                        Transmit.FrmFoodMain.Tipsk("加菜成功");
                    }
                }
            }
        }

        private void pbxMinus_Click(object sender, EventArgs e)
        {
            sumPay = Convert.ToDecimal(Transmit.FrmPay.lbSumRmb.Text);
            string OrderId = Transmit.FrmFoodMain.lbOrderId.Text;
            if (Convert.ToInt32(lbFNumber.Text) <= 1)
            {
                if (Transmit.FrmFoodMain.Tipskc("要删除此单吗?"))
                {
                    List<Order> ods = OrderManager.SelectSpicy(OrderId, lbFName.Text);
                    for (int j = 0; j < ods.Count; j++)
                    {
                        OrderManager.UpdateSpicyFNumber((j + 1), OrderId, lbFName.Text, Convert.ToInt32(ods[j].FNumber));
                    }
                    int m = OrderManager.DeleteSpicy(OrderId, lbFName.Text, Convert.ToInt32(lbFNumber.Text));
                    int n = OrderManager.DeleteOrder(OrderId, lbFName.Text);
                    if (n > 0)
                    {
                        Transmit.FrmPay.FrmPay_Load(sender, e);
                        Transmit.FrmOrder.FrmOrder_Load(sender, e);
                        Transmit.FrmFoodMain.Tipsk("取消订单成功！");
                    }
                }
            }
            else
            {
                List<Order> ods = OrderManager.SelectSpicy(OrderId, lbFName.Text);
                for (int j = 0; j < ods.Count; j++)
                {
                    OrderManager.UpdateSpicyFNumber((j + 1), OrderId, lbFName.Text, Convert.ToInt32(ods[j].FNumber));
                }
                int m = OrderManager.DeleteSpicy(OrderId, lbFName.Text, Convert.ToInt32(lbFNumber.Text));
                int n = OrderManager.UpdateMinusFNumber(lbFName.Text, OrderId);
                if (n > 0)
                {
                    lbFNumber.Text = (Convert.ToInt32(lbFNumber.Text) - 1).ToString();
                    sumPay -= Convert.ToDecimal(lbRMB.Text);
                    Transmit.FrmPay.lbSumRmb.Text = sumPay.ToString();
                    Transmit.FrmOrder.lbSumRmb.Text = sumPay.ToString();
                    double vipsum = Convert.ToDouble(sumPay);
                    Transmit.FrmPay.lbVIPSum.Text = (vipsum * 0.8).ToString();
                    Transmit.FrmOrder.lbVIPSum.Text = (vipsum * 0.8).ToString();
                    Transmit.FrmPay.FrmPay_Load(sender, e);
                    Transmit.FrmOrder.FrmOrder_Load(sender, e);
                    Transmit.FrmFoodMain.Tipsk("减单成功！");
                }
            }
        }
    }
}
