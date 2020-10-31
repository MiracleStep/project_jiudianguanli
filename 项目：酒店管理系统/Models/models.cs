using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*模型类,定义字段*/
namespace Models
{
    public class User
    {
        private string name;
        private string pwd;
        private int role;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Pwd
        {
            get { return pwd; }
            set { pwd = value; }
        }
        public int Role
        {
            get { return role; }
            set { role = value; }
        }
        public User()
        {
            name = "";
            pwd = "";
            role = 0;
        }

        public User(string _name, string _pwd, int _role)
        {
            name = _name;
            pwd = _pwd;
            role = _role;
        }

    }

    class RoomInfo
    {
        private string roomId;
        private string roomType;
        private string roomFloor;
        private double price;
        private int personNum;
        private int inPerson;
        private string note;
        public string RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }
        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        public string RoomFloor
        {
            get { return roomFloor; }
            set { roomFloor = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public int PersonNum
        {
            get { return personNum; }
            set { personNum = value; }
        }
        public int InPerson
        {
            get { return inPerson; }
            set { inPerson = value; }
        }
        public string Note
        {
            get { return note; }
            set { note = value; }
        }
    }


    public class CheckInRoom
    {
        private int inId;
        private string roomId;
        private double price;
        private double foregift;
        private DateTime inTime;
        private DateTime outTime;
        private string clientName;
        private bool sex;
        private string phone;
        private string certType;
        private string certId;
        private string address;
        private int personNum;
        private string oper;
        private int delMark;

        public int InId
        {
            get { return inId; }
            set { inId = value; }
        }
        public string RoomId
        {
            get { return roomId; }
            set { roomId = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Foregift { get => foregift; set => foregift = value; }
        public DateTime InTime { get => inTime; set => inTime = value; }
        public DateTime OutTime { get => outTime; set => outTime = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public bool Sex { get => sex; set => sex = value; }
        public string Phone { get => phone; set => phone = value; }
        public string CertType { get => certType; set => certType = value; }
        public string CertId { get => certId; set => certId = value; }
        public string Address { get => address; set => address = value; }
        public int PersonNum { get => personNum; set => personNum = value; }
        public string Oper { get => oper; set => oper = value; }
        public int DelMark { get => delMark; set => delMark = value; }
    }

    public class CheckOutRoom
    {
        private string outId;
        private int inId;
        private DateTime outTime;
        private string roomId;
        private string clientName;
        private DateTime inTime;
        private double price;
        private double foregift;
        private double total;
        private double account;
        private string note;
        private string oper;

        public string OutId { get => outId; set => outId = value; }
        public int InId { get => inId; set => inId = value; }
        public DateTime OutTime { get => outTime; set => outTime = value; }
        public string RoomId { get => roomId; set => roomId = value; }
        public string ClietnName { get => clientName; set => clientName = value; }
        public DateTime InTime { get => inTime; set => inTime = value; }
        public double Price { get => price; set => price = value; }
        public double Foregift { get => foregift; set => foregift = value; }
        public double Total { get => total; set => total = value; }
        public double Account { get => account; set => account = value; }
        public string Note { get => note; set => note = value; }
        public string Oper { get => oper; set => oper = value; }
    }
}
