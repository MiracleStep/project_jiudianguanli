using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace BLL
{
    class RoomManager
    {
        public static DataTable GetRoomInfo()
        {
            string sql = @"select roomId as 房间号,roomType as 房间类型,roomFloor as 层数,Price as 价格,personNum as 可入住人数,inPerson as 已入住人数,note as 备注 from room where inPerson=0";
            DataTable dt = DBOper.GetDataTable(sql);
            return dt;
        }

        public static bool InsertRoomInfo(CheckInRoom registerRoomInfo)
        {
            string sqlInsert = @"insert into checkin values(null,@roomId,@price,@foregift,@inTime,@outTime,@clientName,
                            @sex,@phone,@cerType,@certId,@address,@personNum,@Oper,@deMark)";
            MySqlParameter p1 = new MySqlParameter("@roomId", registerRoomInfo.RoomId);
            MySqlParameter p2 = new MySqlParameter("@price", registerRoomInfo.Price);
            MySqlParameter p3 = new MySqlParameter("@foregift", registerRoomInfo.Foregift);
            MySqlParameter p4 = new MySqlParameter("@inTime", registerRoomInfo.InTime);
            MySqlParameter p5 = new MySqlParameter("@outTime", registerRoomInfo.OutTime);
            MySqlParameter p6 = new MySqlParameter("@clientName", registerRoomInfo.ClientName);
            MySqlParameter p7 = new MySqlParameter("@sex", registerRoomInfo.Sex);
            MySqlParameter p8 = new MySqlParameter("@phone", registerRoomInfo.Phone);
            MySqlParameter p9 = new MySqlParameter("@certType", registerRoomInfo.CertType);
            MySqlParameter p10 = new MySqlParameter("@certId", registerRoomInfo.CertId);
            MySqlParameter p11 = new MySqlParameter("@address", registerRoomInfo.Address);
            MySqlParameter p12 = new MySqlParameter("@personNum", registerRoomInfo.PersonNum);
            MySqlParameter p13 = new MySqlParameter("@Oper", registerRoomInfo.Oper);
            MySqlParameter p14 = new MySqlParameter("@delMark", registerRoomInfo.DelMark);

            MySqlParameter[] paramArray = new MySqlParameter[] { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14 };
            string sqlUpdate = "update room set inPerson=@inPerson where roomId=@roomId";
            MySqlParameter n1 = new MySqlParameter("@roomId", registerRoomInfo.RoomId);
            MySqlParameter n2 = new MySqlParameter("@inPerson", registerRoomInfo.PersonNum);
            if(DBOper.ExecuteCommand(sqlInsert,paramArray) == 1 && DBOper.ExecuteCommand(sqlInsert, n1, n2) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable GetUseRoomInfo()
        {
            string sql = @"select roomId as 房间号,price as 价格,foregift as 押金,inTime as 入住时间,outTime as 退房时间,clientName as 住客姓名,
                          sex as 性别,phone as 电话号码,certType as 证件类型,certId as 证件号码,address as 地址,personNum as 入住人数, Oper as 登记者
                           from checkin where delMark=0";
            DataTable dt = DBOper.GetDataTable(sql);
            return dt;
        }

        public static DataTable GetInID(string roomId)
        {
            string sql = @"select inId from checkin where delMark=0 and roomId=" + roomId;
            DataTable dt = DBOper.GetDataTable(sql);
            return dt;
        }

        public static bool InsertCheckOutRoomInfo(CheckOutRoom checkOutRoomInfo)
        {
            string sqlInsert = @"insert into checkout values(@outId,@inId,@outTime,@roomId,@clientName,@inTime,@price,@foregift,@account,@note,@oper)";
            string sqlUpdateRegister = "update checkin set delMark=1 where inId=@inId";
            string sqlUpdateRoom = "update room set inPerson=0 where roomId=@roomId";

            MySqlParameter p1 = new MySqlParameter("@outId", checkOutRoomInfo.OutId);
            MySqlParameter p2 = new MySqlParameter("@inId", checkOutRoomInfo.InId);
            MySqlParameter p3 = new MySqlParameter("@roomId", checkOutRoomInfo.RoomId);
            MySqlParameter p4 = new MySqlParameter("@price", checkOutRoomInfo.Price.ToString());
            MySqlParameter p5 = new MySqlParameter("@foregift", checkOutRoomInfo.Foregift.ToString());
            MySqlParameter p6 = new MySqlParameter("@total", checkOutRoomInfo.Total.ToString());
            MySqlParameter p7 = new MySqlParameter("@account", checkOutRoomInfo.Account.ToString());
            MySqlParameter p8 = new MySqlParameter("@inTime", checkOutRoomInfo.InTime);
            MySqlParameter p9 = new MySqlParameter("@outTime", checkOutRoomInfo.OutTime);
            MySqlParameter p10 = new MySqlParameter("@clientName", checkOutRoomInfo.ClietnName);
            MySqlParameter p11 = new MySqlParameter("@oper", checkOutRoomInfo.Oper);
            MySqlParameter p12 = new MySqlParameter("@note", checkOutRoomInfo.Note);

            MySqlParameter[] paramArray = new MySqlParameter[] { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12 };

            MySqlParameter n1 = new MySqlParameter("@inId", checkOutRoomInfo.InId);
            MySqlParameter n2 = new MySqlParameter("@roomId", checkOutRoomInfo.RoomId);
            if(DBOper.ExecuteCommand(sqlInsert,paramArray)==1&&
                DBOper.ExecuteCommand(sqlUpdateRegister,n1)==1&&
                DBOper.ExecuteCommand(sqlUpdateRoom,n2)==1)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public static DataTable GetRoomInfo(string roomId)
        {
            string sql = @"select * from room where roomId=" + roomId;
            DataTable dt = DBOper.GetDataTable(sql);
            return dt;
        }

        public static DataTable GetRoomUseInfo()
        {
            string sql = @"select roomId as 房间号,roomType as 房间类型,roomFloor as 层数,
                            Price as 价格,personNum as 可入住人数,inPerson as 已入住人数,note as 备注 from room where inPerson!=0";
            DataTable dt = DBOper.GetDataTable(sql);
            return dt;
        }
    }
}
