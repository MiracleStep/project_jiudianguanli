using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 项目_酒店管理系统
{
    public partial class CheckInRoomForm : Form
    {
        public CheckInRoomForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CheckInRoomForm_Load(object sender, EventArgs e)
        {
            txtOper.Text = RoleManager.curUser.Name;
            DataTable dt = RoomManager.GetRoomInfo();
            if (dt.Rows.Count!=0)
            {
                dgvRoomList.DataSource = dt;
            }
            else
            {
                MessageBox.Show("已没有空房间！");
                return;
            }
        }

        private void dgvRoomList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvRoomList.SelectedRows.Count == 1)
            {
                this.txtRoomId.Text = Convert.ToString(dgvRoomList.SelectedRows[0].Cells["房间号"].Value.ToString());
                this.txtPrice.Text = Convert.ToString(dgvRoomList.SelectedRows[0].Cells["价格"].Value.ToString());
            }
        }

        private bool CheckData()
        {
            if (txtRoomId.Text == "")
            {
                MessageBox.Show("房间号不能为空");
                txtRoomId.Focus();
                return false;
            }
            if (txtForegift.Text == "")
            {
                MessageBox.Show("押金不能为空");
                txtForegift.Focus();
                return false;
            }
            if (txtClientName.Text == "")
            {
                MessageBox.Show("住客姓名不能为空");
                txtClientName.Focus();
                return false;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("电话不能为空");
                txtPhone.Focus();
                return false;
            }
            if (txtCertId.Text == "")
            {
                MessageBox.Show("证件号不能为空");
                txtCertId.Focus();
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("地址不能为空");
                txtAddress.Focus();
                return false;
            }
            if (txtPersonNum.Text == "")
            {
                MessageBox.Show("住宿人数不能为空");
                txtPersonNum.Focus();
                return false;
            }
            else if (Convert.ToInt32(txtPersonNum.Text) > Convert.ToInt32(dgvRoomList.SelectedRows[0].Cells["可入住人数"].Value.ToString()))
            {
                MessageBox.Show("入住人数超过可容纳人数，请更换房间");
                txtRoomId.Text = "";
                txtPrice.Text = "";
                txtPersonNum.Text = "";
                txtPersonNum.Text = "";
                txtRoomId.Focus();
                return false;
            }
            DateTime inTime = DateTime.Parse(dtpInTime.Text.ToString());
            DateTime outTime = DateTime.Parse(dtpOutTime.Text.ToString());
            if (inTime.CompareTo(DateTime.Today) < 0)
            {
                MessageBox.Show("入住时间不能小于当前时间");
                dtpInTime.Focus();
                return false;
            }
            else if (outTime.CompareTo(DateTime.Today) < 0)
            {
                MessageBox.Show("离开时间不能小于当前时间");
                dtpOutTime.Focus();
                return false;
            }
            else if (outTime < inTime)
            {
                MessageBox.Show("离开时间不能小于入住时间");
                dtpOutTime.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strTimeNow = string.Format("{0:T}", DateTime.Now);
            string inTime = dtpInTime.Text.ToString() + strTimeNow;
            string outTime = dtpOutTime.Text.ToString() + strTimeNow;
            bool sex = true;
            if (rbMale.Checked)
            {
                sex = false;
            }
            CheckInRoom registerInfo = new CheckInRoom();
            registerInfo.RoomId = txtRoomId.Text;
            registerInfo.Price = Convert.ToDouble(txtPrice.Text);
            registerInfo.Foregift = Convert.ToDouble(txtForegift.Text);
            registerInfo.InTime = Convert.ToDateTime(inTime);
            registerInfo.OutTime = Convert.ToDateTime(outTime);
            registerInfo.ClientName = txtClientName.Text;
            registerInfo.Sex = sex;
            registerInfo.Phone = txtPhone.Text;
            registerInfo.CertId = txtCertId.Text;
            registerInfo.CertType = cmbCertType.SelectedItem.ToString();
            registerInfo.PersonNum = Convert.ToInt32(txtPersonNum.Text);
            registerInfo.Oper = txtOper.Text;
            registerInfo.Address = txtAddress.Text;
            registerInfo.DelMark = 0;
            if (CheckData())
            {
                if (RoomManager.InsertRoomInfo(registerInfo))
                {
                    MessageBox.Show("入住登记成功！");
                }
                else
                {
                    MessageBox.Show("入住登记失败!");
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtRoomId.Text = "";
            txtPrice.Text = "";
            txtForegift.Text = "";
            dtpInTime.Text = "";
            dtpOutTime.Text = "";
            rbMale.Checked = true;
            txtClientName.Text = "";
            txtPhone.Text = "";
            cmbCertType.SelectedIndex = 0;
            txtCertId.Text = "";
            txtAddress.Text = "";
            txtPersonNum.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOper_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
