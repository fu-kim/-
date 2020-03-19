using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderManagers
    {
        //支付订单信息

        public static List<OrderInfo> SelectOrderAll()
        {
            return OrderService.SelectOrderAll();
        }

        //所有订单详细信息
        public static List<OrderInfos> SelectOrdersAll()
        {
            return OrderService.SelectOrdersAll();
        }

        //选中的订单号的订单信息
        public static List<OrderInfos> SelectOrderInfo(string orderId)
        {
            return OrderService.SelectOrderInfo(orderId);
        }

        //桌号订单号模糊查询
        public static List<OrderInfo> SelectOrderBycon(OrderInfo o)
        {
            return OrderService.SelectOrderBycon(o);
        }

        //日期查询
        public static List<OrderInfo> SelectOrderByDate(string time, string time2)
        {
            return OrderService.SelectOrderByDate(time, time2);
        }

        //单个日期查询
        public static List<OrderInfo> SelectOrderByDateOne(OrderInfo time)
        {
            return OrderService.SelectOrderByDateOne(time);
        }

        //删除订单
        public static int DeleteOrderByDate(string time, string time2)
        {
            return OrderService.DeleteOrderByDate(time, time2);
        }
    }
}
