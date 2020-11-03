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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            DataTable dt = ClientManager.GetClientInfo();
            dgvClient.DataSource = dt;
        }

        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rows = dgvClient.SelectedRows;
            if (rows.Count == 0)
            {
                txtClientName.Text = "";
                rbMale.Checked = false;
                rbFemale.Checked = false;
                txtPhone.Text = "";
                cmbCertType.SelectedItem = "";
                txtCertId.Text = "";
                txtAddress.Text = "";
                txtPersonNum.Text = "";
                btnSave.Enabled = false;
                return;
            }
            btnSave.Enabled = true;
            var row = rows[0];
            txtClientName.Text = row.Cells[5].Value.ToString();
            if (row.Cells[6].Value.ToString() == "0")
            {
                rbMale.Checked = true;
            }
            else
            {
                rbFemale.Checked = true;
            }
            txtPhone.Text = row.Cells[7].Value.ToString();
            cmbCertType.SelectedItem = row.Cells[8].Value;
            txtCertId.Text = row.Cells[9].Value.ToString();
            txtAddress.Text = row.Cells[10].Value.ToString();

        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string clientName = txtQueryName.Text;
            DataTable dt = ClientManager.GetALLClient(clientName);
            dgvClient.DataSource = dt;
        }
        private bool checkdata()
        {
            if (txtClientName.Text == "")
            {
                MessageBox.Show("住客姓名不能为空");
                txtClientName.Focus();
                return false;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("电话号码不能为空");
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
            DataTable dt = RoomManager.GetRoomInfo(dgvClient.SelectedRows[0].Cells[0].Value.ToString());
            string personNum = dt.Rows[0][4].ToString();
            if (txtPersonNum.Text == "")
            {
                MessageBox.Show("住宿人数不能为空");
                txtPersonNum.Focus();
                return false;
            }
            else if (int.Parse(txtPersonNum.Text) > int.Parse(personNum))
            {
                MessageBox.Show("入住人数大于可容纳人数");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool sex = default(bool);
            if (rbMale.Checked)
            {
                sex = false;
            }
            else
            {
                sex = true;
            }
            CheckInRoom registerInfo = new CheckInRoom();
            registerInfo.RoomId = dgvClient.SelectedRows[0].Cells[0].Value.ToString();
            registerInfo.Price = double.Parse(dgvClient.SelectedRows[0].Cells[1].Value.ToString());
            registerInfo.Foregift = double.Parse(dgvClient.SelectedRows[0].Cells[2].Value.ToString());
            registerInfo.InTime = DateTime.Parse(dgvClient.SelectedRows[0].Cells[3].Value.ToString());
            registerInfo.OutTime = DateTime.Parse(dgvClient.SelectedRows[0].Cells[4].Value.ToString());
            registerInfo.ClientName = txtClientName.Text.ToString();
            registerInfo.Sex = sex;
            registerInfo.Phone = txtPhone.Text.ToString();
            registerInfo.CertType = cmbCertType.SelectedItem.ToString();
            registerInfo.CertId = txtCertId.Text.ToString();
            registerInfo.PersonNum = int.Parse(txtPersonNum.Text.ToString());
            registerInfo.Address = txtAddress.Text.ToString();
            registerInfo.Oper = dgvClient.SelectedRows[0].Cells[12].Value.ToString();
            registerInfo.DelMark = int.Parse(dgvClient.SelectedRows[0].Cells[13].Value.ToString());
            registerInfo.InId = int.Parse(dgvClient.SelectedRows[0].Cells[14].Value.ToString());
            if (checkdata())
            {
                if (ClientManager.UpdateRegister(registerInfo))
                {
                    MessageBox.Show("住客信息修改");
                    DataTable dt = ClientManager.GetClientInfo();
                    dgvClient.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("住客信息修改失败");
                }
            }
        }

        private void dgvClient_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 6) 
            {
                if (e.Value.ToString() == "1")
                {
                    e.Value = "女";
                }
                else
                {
                    e.Value = "男";
                }
            }
            if(e.Value.ToString() == "0")
            {
                e.Value = "否";
            }
            else
            {
                e.Value = "是";
            }
            
        }

    }
}
