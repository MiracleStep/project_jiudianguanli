using BLL;
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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            DataTable dt = RoomManager.GetRoomUseInfo();
            dgvRoom.DataSource = dt;
        }

        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ss(object sender, QuestionEventArgs e)
        {

        }

        private void dgvRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count != 0)
            {
                string roomId = dgvRoom.SelectedRows[0].Cells[0].Value.ToString();

                DataTable dt = ClientManager.GetClient(roomId);
                dgvClient.DataSource = dt;
            }
        }

        private void dgvRoom_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
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
        }
    }
}
