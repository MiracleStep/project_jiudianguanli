using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Models;

namespace BLL
{
    class ClientManager
    {
        public static DataTable GetClientInfo()
        {
            string sql = @"select roomId as 房间号,price as 价格,foregift as 押金,inTime as 入住时间,outTime as 退房时间,clientName as 住客姓名,
                            sex as 性别,phone as 电话号码,certType as 证件类型,certId as 证件号码,address as 地址,personNum as 入住人数,Oper as 等记者,
                            delMark as 是否退房,inId from checkin";
            DataTable dt = DBOper.GetDataTable(sql);
            return dt;
        }

        public static DataTable GetALLClient(string clientName)
        {
            string sql = @"select roomId as 房间号,price as 价格,foregift as 押金,inTime as 入住时间,outTime as 退房时间,clientName as 住客姓名,
                            sex as 性别,phone as 电话号码,certType as 证件类型,certId as 证件号码,address as 地址,personNum as 入住人数,Oper as 等记者,
                            delMark as 是否退房,inId from checkin where clientName like '%" + clientName + "%'";
            DataTable dt = DBOper.GetDataTable(sql);
            return dt;
        }

        public static bool UpdateRegister (CheckInRoom registerRoomInfo)
        {
            string sqlUpdateRegister = @"update checkin set clientName=@clientName,sex=@sex,phone=@phone,certType=@certType,certId=@certId,
                                        address=@address,personNum=@personNum where inId=@inId";
            MySqlParameter p1 = new MySqlParameter("@clientName", registerRoomInfo.ClientName);
            MySqlParameter p2 = new MySqlParameter("@clientName", registerRoomInfo.Sex);
            MySqlParameter p3 = new MySqlParameter("@clientName", registerRoomInfo.Phone);
            MySqlParameter p4 = new MySqlParameter("@clientName", registerRoomInfo.CertType);
            MySqlParameter p5 = new MySqlParameter("@clientName", registerRoomInfo.CertId);
            MySqlParameter p6 = new MySqlParameter("@clientName", registerRoomInfo.Address);
            MySqlParameter p7 = new MySqlParameter("@clientName", registerRoomInfo.PersonNum);
            MySqlParameter p8 = new MySqlParameter("@clientName", registerRoomInfo.InId);

            MySqlParameter[] paramArray = new MySqlParameter[] { p1, p2, p3, p4, p5, p6, p7, p8 };

            if (DBOper.ExecuteCommand(sqlUpdateRegister, paramArray) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable GetClient(string roomId)
        {
            string sql = @"select roomId as 房间号,price as 价格,foregift as 押金,inTime as 入住时间,outTime as 退房时间,
                            clientName as 住客姓名,sex as 性别,phone as 电话号码,certType as 证件类型,certId as 证件号码,
                            address as 地址,personNum as 入住人数,Oper as 登记者 from checkin where delMark=0 and roomId =" + roomId;
            DataTable dt = DBOper.GetDataTable(sql);
            return dt;
        }
    }
}
