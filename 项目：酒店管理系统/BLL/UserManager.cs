using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DAL;

namespace BLL
{
/// <summary>
///添加用户，查询用户 
/// </summary>
    class UserManager
    {
        public static User GetUser(string name,string pwd)
        {
            User user = null;
            string sql = "select * from user where userName=\'" + name + "\' and userpwd=\'" + pwd + "\'";
            MySqlDataReader reader = DBOper.GetReader(sql);
            if (reader.Read())
            {
                user = new User();
                user.Name = Convert.ToString(reader["userName"]);
                user.Pwd = Convert.ToString(reader["userPwd"]);
                user.Role = Convert.ToInt32(reader["role"]);
            }
            reader.Close();
            return user;
        }

        public static bool AddUser(User user)
        {
            string sql = "insert into user values(@name,@pwd,@role)";
            MySqlParameter p1 = new MySqlParameter("@name", user.Name);
            MySqlParameter p2 = new MySqlParameter("@pwd", user.Pwd);
            MySqlParameter p3 = new MySqlParameter("@role", user.Role);
            if (DBOper.ExecuteCommand(sql, p1, p2, p3) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
