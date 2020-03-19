using BLL;
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
    public partial class FrmFlavor : Form
    {
        public FrmFlavor()
        {
            InitializeComponent();
        }
        public string FName = "";
        public decimal FPrice = 0;
        private void pbxOK_Click(object sender, EventArgs e)
        {
            int m = 0;
            int n = 0;
            string OrderId = Transmit.FrmFoodMain.lbOrderId.Text;
            int FNumber = 1;
            string Spicy = cboSpicy.Text;
            #region 添加到订单
            object OrderIDs = OrderManager.selectOrderId(OrderId);
            if (OrderIDs != null)
            {
                object Fname = OrderManager.selectFName(OrderId, FName);
                if (Fname != null)
                {
                    n = OrderManager.UpdateAddFNumber(FName, OrderId);
                    object FNumbers = OrderManager.SelectFNumBer(OrderId, FName);
                    m = OrderManager.InsertSpicyInfo(OrderId, FName, Convert.ToInt32(FNumbers), Spicy);
                    if (n > 0)
                    {
                        this.Close();
                        if (this.Text=="Order")
                        {
                            Transmit.FrmPay.FrmPay_Load(sender, e);
                            Transmit.FrmOrder.FrmOrder_Load(sender, e);
                        }
                        Transmit.FrmFoodMain.Tipsk("添加成功");
                    }
                    else
                    {
                        Transmit.FrmFoodMain.Tipsk("添加失败");
                    }
                }
                else
                {
                    m = OrderManager.InsertSpicyInfo(OrderId, FName, FNumber, Spicy);
                    n = OrderManager.InsertOrderInfo(Convert.ToInt32(Transmit.FrmMenu.lbTableId.Text),OrderId, FName, FPrice, FNumber);
                    if (n > 0)
                    {
                        this.Close();
                        Transmit.FrmFoodMain.Tipsk("添加成功");
                    }
                    else
                    {
                        Transmit.FrmFoodMain.Tipsk("添加失败");
                    }
                }

            }
            else
            {
                m = OrderManager.InsertSpicyInfo(OrderId, FName, FNumber, Spicy);
                n = OrderManager.InsertOrderInfo(Convert.ToInt32(Transmit.FrmMenu.lbTableId.Text),OrderId, FName, FPrice, FNumber);
                if (n*m > 0)
                {
                    this.Close();
                    Transmit.FrmFoodMain.Tipsk("添加成功");
                }
                else
                {
                    Transmit.FrmFoodMain.Tipsk("添加失败");
                }
            }
            #endregion
        }

        public void FrmFlavor_Load(object sender, EventArgs e)
        {
            cboSpicy.SelectedIndex = 0;
        }

        private void pbxCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
