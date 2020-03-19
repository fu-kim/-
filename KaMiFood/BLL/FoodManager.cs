using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FoodManager
    {
        #region 查询所有菜品
        public static List<Food> SelectFoodAll()
        {
            return FoodServer.SelectFoodAll();
        }
        #endregion

        #region 菜品类型分类
        public static List<Food> SelectFoodbyType(string type)
        {
            return FoodServer.SelectFoodbyType(type);
        }
        #endregion

        #region 查询菜品的类型
        public static object SelectFoodType(string FoodName)
        {
            return FoodServer.SelectFoodType(FoodName);
        }
        #endregion

        #region 查询菜品名称
        public static List<string> SelectFoodName()
        {
            return FoodServer.SelectFoodName();
        }
        #endregion

        #region 根据菜品姓名查询菜品
        public static List<Food> SelectFoodbyFoodName(string FoodName)
        {
            return FoodServer.SelectFoodbyFoodName(FoodName);
        }
        #endregion
    }
}
