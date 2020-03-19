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
        #region 查询所有食物信息
        //查询所有菜品信息
        public static List<Foods> SelectFoodAll()
        {
            return FoodService.SelectFoodAll();
        }
        #endregion
        #region 查询热菜信息
        public static List<Foods> SelectHotFoodAll()
        {
            return FoodService.SelectHotFoodAll();
        }
        #endregion
        #region 查询凉菜信息
        public static List<Foods> SelectColdFoodAll()
        {
            return FoodService.SelectColdFoodAll();
        }
        #endregion
        #region 查询汤信息
        public static List<Foods> SelectSoupFoodAll()
        {
            return FoodService.SelectSoupFoodAll();
        }
        #endregion
        #region 查询饮品信息
        public static List<Foods> SelectWineFoodAll()
        {
            return FoodService.SelectWineFoodAll();
        }
        #endregion
        #region 查询其他信息
        public static List<Foods> SelectElseFoodAll()
        {
            return FoodService.SelectElseFoodAll();
        }
        #endregion
        #region 添加菜品
        public static int InsertFood(Foods F)
        {
            return FoodService.InsertFood(F);
        }
        #endregion
        #region 删除菜品
        public static int DeleteFood(string FoodId)
        {
            return FoodService.DeleteFood(FoodId);
        }
        #endregion
        #region 修改菜品
        public static int UpdateFood(Foods CII)
        {
            return FoodService.UpdateFood(CII);
        }
        #endregion
    }
}
