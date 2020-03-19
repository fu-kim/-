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
    public partial class FrmActivityInfo : UserControl
    {
        public FrmActivityInfo()
        {
            InitializeComponent();
        }

        #region 窗体加载事件
        private void FrmActivityInfo_Load(object sender, EventArgs e)
        {
            decimal sum = 0;
            Transmit.FrmActivityInfo = this;
            flpActivityFoodInfo.Controls.Clear();
            List<Activity> ay = ActivityManager.SelectActivityFoodAll(lbActivityName.Text);
            for (int i = 0; i < ay.Count; i++)
            {
                FrmCActivityInfo fCai = new FrmCActivityInfo();
                fCai.lbFoodName.Text = ay[i].FName;
                fCai.pbxFoodImage.Image = Image.FromFile(Application.StartupPath + @"\Images\食物\" + ay[i].FName + ".jpg");
                fCai.lbFNumber.Text = ay[i].FNumber.ToString();
                fCai.lbRMB.Text = ay[i].Price.ToString().Substring(0, 5);
                sum += ay[i].Price;
                flpActivityFoodInfo.Controls.Add(fCai);
            }
            lbSumRMB.Text = sum.ToString().Substring(0, 5);
        } 
        #endregion

        #region 返回事件
        private void pbxReturn_Click(object sender, EventArgs e)
        {
            Transmit.FrmFoodMain.pbxActivity_Click(sender, e);
        } 
        #endregion

        #region 添加至订单鼠标移动事件
        private void pbxAddOrder_MouseMove(object sender, MouseEventArgs e)
        {
            pbxAddOrder.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\添加至订单选中.png");
        }

        private void pbxAddOrder_MouseLeave(object sender, EventArgs e)
        {
            pbxAddOrder.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\添加至订单.png");
        }
        #endregion

        #region 点击添加至订单事件
        private void pbxAddOrder_Click(object sender, EventArgs e)
        {
            int n = 0;
            string OrderId = Transmit.FrmFoodMain.lbOrderId.Text;
            string FName = lbActivityName.Text;
            decimal FPrice = Convert.ToDecimal(lbSumRMB.Text);
            int FNumber = 1;
            #region 判断是否加菜
            if (Transmit.FrmFoodMain.IsPays == true)
            {
                #region 加菜
                DialogResult ret = MessageBox.Show("你确定加菜吗？", "加菜提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (ret == DialogResult.Yes)
                {
                    Random rd = new Random();
                    string OrderIds = "";
                    OrderIds += DateTime.Now.Year.ToString();
                    OrderIds += DateTime.Now.Month.ToString();
                    OrderIds += DateTime.Now.Day.ToString();
                    for (int i = 0; i < 6; i++)
                    {
                        OrderIds += rd.Next(0, 10).ToString();
                    }
                    n = OrderManager.InsertOrder(OrderIds,Convert.ToInt32(Transmit.FrmMenu.lbTableId.Text));
                    Transmit.FrmFoodMain.IsPays = false;
                    Transmit.FrmFoodMain.lbOrderId.Text = OrderIds;
                }
                #endregion

            }
            else
            {
                #region 查询是否为热菜
                //object FType = FoodManager.SelectFoodType(FName);
                //if (FType.ToString() == "1")
                //{
                //    FrmFlavor ff = new FrmFlavor();
                //    ff.Text = "Food";
                //    ff.FName = FName;
                //    ff.FPrice = FPrice;
                //    ff.ShowDialog();
                //}
                //else
                //{
                    #region 添加到订单
                    object OrderIDs = OrderManager.selectOrderId(OrderId);
                    if (OrderIDs != null)
                    {
                        object Fname = OrderManager.selectFName(OrderId, FName);
                        if (Fname != null)
                        {
                            n = OrderManager.UpdateAddFNumber(FName, OrderId);
                            if (n > 0)
                            {
                                MessageBox.Show("添加成功");
                            }
                            else
                            {
                                MessageBox.Show("添加失败");
                            }
                        }
                        else
                        {
                            n = OrderManager.InsertOrderInfo(Convert.ToInt32(Transmit.FrmMenu.lbTableId.Text),OrderId, FName, FPrice, FNumber);
                            if (n > 0)
                            {
                                MessageBox.Show("添加成功");
                            }
                            else
                            {
                                MessageBox.Show("添加失败");
                            }
                        }

                    }
                    else
                    {
                        n = OrderManager.InsertOrderInfo(Convert.ToInt32(Transmit.FrmMenu.lbTableId.Text),OrderId, FName, FPrice, FNumber);
                        if (n > 0)
                        {
                            MessageBox.Show("添加成功");
                        }
                        else
                        {
                            MessageBox.Show("添加失败");
                        }
                    }
                    #endregion
                #endregion
            }
            #endregion

        }
        #endregion
    }
}
