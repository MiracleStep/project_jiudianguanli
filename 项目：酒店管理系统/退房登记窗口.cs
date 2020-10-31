using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 项目_酒店管理系统
{
    public partial class CheckOutRoomForm : Form
    {
        private DataTable dt;
        public CheckOutRoomForm()
        {
            dt = RoomManager.GetUseRoomInfo();
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i <= dt.Rows.Count; i++)
            {
                if (cmbRoomId.SelectedIndex.ToString() == dt.Rows[i]["房间号"].ToString())
                {
                    txtPrice.Text = dt.Rows[i]["价格"].ToString();
                    txtForegift.Text = dt.Rows[i]["押金"].ToString();
                    txtInTime.Text = dt.Rows[i]["入住时间"].ToString();
                    txtClientName.Text = dt.Rows[i]["住客姓名"].ToString();
                    string outTime = dtpOutTime.Text + string.Format("{0:T}", DateTime.Now);
                    TimeSpan ts1 = new TimeSpan(DateTime.Parse(outTime).Ticks);
                    TimeSpan ts2 = new TimeSpan(DateTime.Parse(txtInTime.Text).Ticks);
                    TimeSpan ts = ts1.Subtract(ts2);
                    int dayCount = ts.Days;
                    int hourCount = ts.Hours;
                    if (dayCount == 0 & hourCount < 24)
                    {
                        dayCount = 1;
                    }
                    double consumTotal = double.Parse(txtPrice.Text.ToString()) * dayCount;
                    txtTotal.Text = consumTotal.ToString();
                    txtAccount.Text = Convert.ToString(consumTotal - double.Parse(txtForegift.Text));
                    return;
                }
            }
        }

        private bool checkdata()
        {
            DateTime inTime = Convert.ToDateTime(DateTime.Parse(txtInTime.Text.ToString()).ToString("yyyy-MM-dd"));
            DateTime outTime = DateTime.Parse(dtpOutTime.Text.ToString());
            if (outTime < inTime)
            {
                MessageBox.Show("结账日期不能小于入住日期");
                dtpOutTime.Focus();
                return false;
            }
            return true;
        }
        private void CheckOutRoomForm_Load(object sender, EventArgs e)
        {
            if (dt.Rows.Count > 0)
            {
                for(int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    cmbRoomId.Items.Add(dt.Rows[i]["房间号"].ToString());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkdata() == false)
            {
                return;
            }
            string inTime = txtInTime.Text.ToString();
            string strTimeNow = string.Format("{0:T}", DateTime.Now);
            string outTime = dtpOutTime.Text.ToString() + strTimeNow;
            int inId = int.Parse(RoomManager.GetInID(cmbRoomId.SelectedItem.ToString()).Rows[0][0].ToString());
            CheckOutRoom checkOutRoom = new CheckOutRoom();
            checkOutRoom.OutId = DateTime.Now.ToString("yyyyMMddHHmmss");
            checkOutRoom.InId = inId;
            checkOutRoom.RoomId = cmbRoomId.SelectedItem.ToString();
            checkOutRoom.Price = double.Parse(txtPrice.Text.ToString());
            checkOutRoom.Foregift = double.Parse(txtForegift.Text.ToString());
            checkOutRoom.Total = double.Parse(txtTotal.Text.ToString());
            checkOutRoom.Account = double.Parse(txtAccount.Text.ToString());
            checkOutRoom.InTime = DateTime.Parse(inTime);
            checkOutRoom.OutTime = DateTime.Parse(outTime);
            checkOutRoom.ClietnName = txtClientName.Text.ToString();
            checkOutRoom.Oper = RoleManager.curUser.Name;
            checkOutRoom.Note = txtNote.Text.ToString();
            if (RoomManager.InsertCheckOutRoomInfo(checkOutRoom))
            {
                MessageBox.Show("退房信息保存成功");
                return;
            }
            else
            {
                MessageBox.Show("退房信息保存失败");
                return;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string path = "D:\\发票单\\" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";
            StreamWriter w = new StreamWriter(path);
            w.WriteLine("--专家公寓--");
            w.WriteLine("住客姓名:" + txtClientName.Text);
            w.WriteLine("住宿费:" + txtTotal.Text);
            w.WriteLine("开票日期:" + DateTime.Now.ToString("yyyy-MM-dd"));
            w.Close();
            MessageBox.Show("导出成功");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbRoomId.Text = "";
            txtClientName.Text = "";
            txtPrice.Text = "";
            txtForegift.Text = "";
            txtTotal.Text = "";
            txtAccount.Text = "";
            txtNote.Text = "";
        }
    }
}
