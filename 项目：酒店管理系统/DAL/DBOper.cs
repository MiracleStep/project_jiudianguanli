using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DAL
{
    /// <summary>
    /// 数据库访问层设计
    /// </summary>
    class DBOper
    {
        static string Connstr = "server=localhost;user id= root;password=1584699582;database=Hotel;Charset=utf8;Allow User Variables=True;";
        private static MySqlConnection conn;
        public static MySqlConnection Connection()  //数据库连接函数
        {
            conn = new MySqlConnection(Connstr);
            conn.Open();
            return conn;
        }

        //运行命令静态方法
        public static int ExecuteCommand(string sql) 
        {
            MySqlCommand cmd = new MySqlCommand(sql,Connection());
            return cmd.ExecuteNonQuery();
        }
        //重载ExecuteCommand方法
        public static int ExecuteCommand(string sql, params MySqlParameter[] values) 
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection());
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteNonQuery();
        }

        public static MySqlDataReader GetReader(string sql)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection());
            return cmd.ExecuteReader();
        }
        public static MySqlDataReader GetReader(string sql, params MySqlParameter[] values)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection());
            cmd.Parameters.AddRange(values);
            return cmd.ExecuteReader();
        }

        public static DataTable GetDataTable(string sql)
        {
            MySqlDataAdapter da = new MySqlDataAdapter(sql, Connection());
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public static DataTable GetDataTable(string sql, params MySqlParameter[] values)
        {
            MySqlCommand cmd = new MySqlCommand(sql, Connection());
            cmd.Parameters.AddRange(values);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
