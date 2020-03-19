using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DBHelper
    {
        //创建连接
        private static string conStr = ConfigurationManager.AppSettings["conStr"];

        //创建一个连接对象：空的连接对象
        private static SqlConnection con = null;

        //连接数据库
        public static SqlConnection GetConnection()
        {
            if (con == null || con.ConnectionString == "")
            {
                con = new SqlConnection(conStr);
            }
            return con;
        }

        //打开数据库
        public static void Opencon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        //关闭连接
        public static void Closecon()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

        //执行一般查询：返回第一行第一列
        public static object ExecuteScalar(string sql)
        {
            object obj = null;
            SqlConnection con = GetConnection();
            Opencon();
            SqlCommand com = new SqlCommand(sql, con);
            obj = com.ExecuteScalar();
            Closecon();
            return obj;
        }

        //执行动作查询：添加、修改、删除
        public static int ExecuteNonQuery(string sql)
        {
            int n = 0;
            SqlConnection con = GetConnection();
            Opencon();
            SqlCommand com = new SqlCommand(sql, con);
            n = com.ExecuteNonQuery();
            Closecon();
            return n;
        }
        #region 执行动作查询：添加、修改、删除
        public static int ExecutNonQuery(string sql,  //SQL语句
            CommandType type = CommandType.Text,         //命令类型:SQL文本,存储过程,表           
            params SqlParameter[] para)                //SQL参数列表
        {
            int n = 0;
            SqlConnection con = GetConnection();
            Opencon();
            SqlCommand com = new SqlCommand(sql, con);
            com.CommandType = type;
            com.Parameters.AddRange(para);
            n = com.ExecuteNonQuery();
            Closecon();
            return n;
        }
        #endregion
        //执行一般查询：返回多行多列
        public static SqlDataReader ExecuteReader(string sql)
        {
            SqlConnection con = GetConnection();
            Opencon();
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader dr = com.ExecuteReader();

            return dr;
        }
    }
}
