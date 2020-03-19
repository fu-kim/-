using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderManager
    {
        #region 添加订单
        public static int InsertOrder(string OrderID, int Table)
        {
            return OrderServer.InsertOrder(OrderID, Table);
        }
        #endregion

        #region 添加订单信息
        public static int InsertOrderInfo(int TableId,string OrderId, string FName, decimal FPrice, int FNumber)
        {
            return OrderServer.InsertOrderInfo(TableId,OrderId, FName, FPrice, FNumber);
        }
        #endregion

        #region 查询菜品是否存在
        public static object selectFName(string OrderId,string FName)
        {
            return OrderServer.selectFName(OrderId, FName);
        }
        #endregion

        #region 增加菜品份数
        public static int UpdateAddFNumber(string FName, string OrderId)
        {
            return OrderServer.UpdateAddFNumber(FName,OrderId);
        }
        #endregion

        #region 减少菜品份数
        public static int UpdateMinusFNumber(string FName, string OrderId)
        {
            return OrderServer.UpdateMinusFNumber(FName, OrderId);
        }
        #endregion

        #region 查询订单号是否存在
        public static object selectOrderId(string OrderId)
        {
            return OrderServer.selectOrderId(OrderId);
        }
        #endregion

        #region 查询所有订单信息
        public static List<Order> SelectOrderInfo(string OrderId)
        {
            return OrderServer.SelectOrderInfo(OrderId);
        }
        #endregion

        #region 删除订单
        public static int DeleteOrder(string OrderId, string FName)
        {
            return OrderServer.DeleteOrder(OrderId, FName);
        }
        #endregion

        #region 删除所有订单
        public static int DeleteOrderAll()
        {
            return OrderServer.DeleteOrderAll();
        }
        #endregion

        #region 结账
        public static int InsertPayInfo(int TableId,string OrderId, decimal Price, DateTime PayTime, string Remarks, bool IsPay)
        {
            return OrderServer.InsertPayInfo(TableId,OrderId, Price, PayTime, Remarks, IsPay);
        }
        #endregion

        #region 结账（伪）
        public static int InsertPay(string OrderId, DateTime PayTime, bool IsPay)
        {
            return OrderServer.InsertPay(OrderId, PayTime, IsPay);
        }
        #endregion

        #region 删除结账（伪）
        public static int DeletePay()
        {
            return OrderServer.DeletePay();
        }
        #endregion

        #region 判断是否付款
        public static object SelectIsPay(string PayId)
        {
            return OrderServer.SelectIsPay(PayId);
        }
        #endregion

        #region 添加口味信息
        public static int InsertSpicyInfo(string OrderId, string FName, int FNumber, string Spicy)
        {
            return OrderServer.InsertSpicyInfo(OrderId, FName, FNumber, Spicy);
        }
        #endregion

        #region 查询菜品份数
        public static object SelectFNumBer(string OrderId, string FName)
        {
            return OrderServer.SelectFNumBer(OrderId, FName);
        }
        #endregion

        #region 查询所有口味信息
        public static List<Order> SelectSpicy(string OrderId, string FName)
        {
            return OrderServer.SelectSpicy(OrderId,FName);
        }
        #endregion

        #region 删除口味信息
        public static int DeleteSpicy(string OrderId, string FName, int FNumber)
        {
            return OrderServer.DeleteSpicy(OrderId,FName, FNumber);
        }
        #endregion

        #region 修改口味份数
        public static int UpdateSpicyFNumber(int FNumber, string OrderId, string FName,int oldFNumber)
        {
            return OrderServer.UpdateSpicyFNumber(FNumber, OrderId, FName, oldFNumber);
        }
        #endregion
    }
}
