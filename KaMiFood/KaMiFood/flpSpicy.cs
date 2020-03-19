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
    public partial class flpSpicy : UserControl
    {
        public flpSpicy()
        {
            InitializeComponent();
        }

        #region 删减口味鼠标移动事件
        private void pbxSpicy_MouseMove(object sender, MouseEventArgs e)
        {
            pbxSpicyMinus.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\删减.png");
        }

        private void pbxSpicy_MouseLeave(object sender, EventArgs e)
        {
            pbxSpicyMinus.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\删减选中.png");
        }
        #endregion

        #region 口味删减事件
        private void pbxSpicyMinus_Click(object sender, EventArgs e)
        {
            string OrderId = Transmit.FrmFoodMain.lbOrderId.Text;
            object FNumber = OrderManager.SelectFNumBer(OrderId, lbFName.Text);
            if (Convert.ToInt32( FNumber)<= 1)
            {
                DialogResult ret = MessageBox.Show("你确定要删除此单吗？", "减单警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                    
                    int m = OrderManager.DeleteSpicy(OrderId, lbFName.Text, Convert.ToInt32(lbNunber.Text));
                    int n = OrderManager.DeleteOrder(OrderId, lbFName.Text);
                    List<Order> ods = OrderManager.SelectSpicy(OrderId, lbFName.Text);
                    for (int j = 0; j < ods.Count; j++)
                    {
                        OrderManager.UpdateSpicyFNumber((j + 1), OrderId, lbFName.Text, Convert.ToInt32(ods[j].FNumber));
                    }
                    if (n > 0)
                    {
                        Transmit.FrmPay.FrmPay_Load(sender, e);
                        MessageBox.Show("取消订单成功！");
                    }
                }
            }
            else
            {
                
                int m = OrderManager.DeleteSpicy(OrderId, lbFName.Text, Convert.ToInt32(lbNunber.Text));
                int n = OrderManager.UpdateMinusFNumber(lbFName.Text, OrderId);
                List<Order> ods = OrderManager.SelectSpicy(OrderId, lbFName.Text);
                for (int j = 0; j < ods.Count; j++)
                {
                    OrderManager.UpdateSpicyFNumber((j + 1), OrderId, lbFName.Text, Convert.ToInt32(ods[j].FNumber));
                }
                if (n > 0)
                {
                    Transmit.FrmPay.FrmPay_Load(sender, e);
                    MessageBox.Show("减单成功！");
                }
            }
        } 
        #endregion
    }
}
