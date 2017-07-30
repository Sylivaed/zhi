using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nike
{
    class DBHellper
    {
        public static string salesmanname;
        public static string name;
        public static string mainname;
        public static string pfs;
        public static string fg;
        public static string nams;
        //连接数据库字符串
        public static string Connstring = "server=.;database=nike;uid=sa;pwd=123;";
        //数据库连接对象
        private static SqlConnection con = null;
       
        //初始化连接数据库连接
        private static void InitConnection() {
            //判断数据库连接上没有    没有测创建连接
            if (con == null) {
                con = new SqlConnection(Connstring);
            }
            //判断数据库是否打开   没有测  打开数据库
            if (con.State == ConnectionState.Closed) {
                con.Open();
            }
            if(con.State==ConnectionState.Broken){
                con.Close();
                con.Open();
            }
        }
        //查询   获取内容
        public static SqlDataReader GetdataReader(string sql) {
            //调用方法   判断连接
            InitConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
        //查询   datatable
        public static DataTable GetdataTable(string sql) {
            InitConnection();
            DataTable table = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(sql, con);
            dap.Fill(table);
            con.Close();
            return table;
        }
        //增删改
        public static int ExecuteNonQuery(string sql) {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sql,con);
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result ;
        } 
        //执行集合函数
        public static object ExecuteScalar(string sql) {
            InitConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            object result = cmd.ExecuteScalar();
            return result;
        }


    }
}
