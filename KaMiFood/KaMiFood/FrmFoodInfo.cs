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
    public partial class FrmFoodInfo : UserControl
    {
        public FrmFoodInfo()
        {
            InitializeComponent();
        }
        #region 添加食物到订单
        
        private void pbxAdd_Click(object sender, EventArgs e)
        {
            int n = 0;
            string OrderId = Transmit.FrmFoodMain.lbOrderId.Text;
            string FName = lbFoodName.Text;
            decimal FPrice = Convert.ToDecimal(lbRMB.Text);
            int TableId =Convert.ToInt32(Transmit.FrmMenu.lbTableId.Text);
            int FNumber = 1;
            #region 判断是否加菜
            if (Transmit.FrmFoodMain.IsPays==true)
            {
                #region 加菜
                if (Transmit.FrmFoodMain.Tipskc("你确定加菜吗?"))
                {
                    Transmit.FrmFoodMain.Tipsk("取消订单成功");
                    Random rd = new Random();
                    string OrderIds = "";
                    OrderIds += DateTime.Now.Year.ToString();
                    OrderIds += DateTime.Now.Month.ToString();
                    OrderIds += DateTime.Now.Day.ToString();
                    for (int i = 0; i < 6; i++)
                    {
                        OrderIds += rd.Next(0, 10).ToString();
                    }
                    n = OrderManager.InsertOrder(OrderIds, TableId);
                    TableManager.UpdateTypebyTableId(5, Transmit.FrmMenu.lbTableId.Text);
                    TableManager.UpdateTableNowInfo(Transmit.FrmMenu.lbTableId.Text, OrderIds, DateTime.Now, 0, null, false);
                    Transmit.FrmFoodMain.IsPays = false;
                    Transmit.FrmFoodMain.lbOrderId.Text = OrderIds;
                }   
                #endregion

            }
            else
            {
                #region 查询是否为热菜
                object FType = FoodManager.SelectFoodType(FName);
                if (FType.ToString() == "1")
                {
                    FrmFlavor ff = new FrmFlavor();
                    ff.Text = "Food";
                    ff.FName = FName;
                    ff.FPrice = FPrice;
                    ff.ShowDialog();
                }
                else
                {
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
                                Transmit.FrmFoodMain.Tipsk("添加成功");
                            }
                            else
                            {
                                Transmit.FrmFoodMain.Tipsk("添加失败");
                            }
                        }
                        else
                        {
                            n = OrderManager.InsertOrderInfo(TableId, OrderId, FName, FPrice, FNumber);
                            if (n > 0)
                            {
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
                        n = OrderManager.InsertOrderInfo(TableId, OrderId, FName, FPrice, FNumber);
                        if (n > 0)
                        {
                            Transmit.FrmFoodMain.Tipsk("添加成功");
                        }
                        else
                        {
                            Transmit.FrmFoodMain.Tipsk("添加失败");
                        }
                    }
                    #endregion
                } 
                #endregion
            }
            #endregion

        }
        #endregion


        #region 添加鼠标移动界面
        private void pbxAdd_MouseMove(object sender, MouseEventArgs e)
        {
            pbxAdd.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\添加选中.png");
        }

        private void pbxAdd_MouseLeave(object sender, EventArgs e)
        {
            pbxAdd.Image = Image.FromFile(Application.StartupPath + @"\Images\主界面\添加.png");
        }
        #endregion

        #region 窗体加载事件
        private void FrmFoodInfo_Load(object sender, EventArgs e)
        {
            Transmit.FrmFoodInfo = this;
        } 
        #endregion
    }
}
