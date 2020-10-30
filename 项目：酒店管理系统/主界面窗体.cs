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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            miCheckOutRoomForm frm = new miCheckOutRoomForm();
            frm.Mdiparent = this;
            frm.show();
        }

        private void 主界面窗体_Load(object sender, EventArgs e)
        {
            if(RoleManager.curUser.Role == 0)
            {
                miUserManage.Visible = false;
                miNewUser.Visible = false;
                miEditUser.Visible = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ChekInRoomForm frm = new ChekInRoomForm();
            frm.Mdiparent = this;
            frm.Show();
        }

        private void miUserManage_Click(object sender, EventArgs e)
        {

        }

        private void miRoom_Click(object sender, EventArgs e)
        {
            ClientForm frm = new ClientForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void miClient_Click(object sender, EventArgs e)
        {
            RoomForm frm = new RoomForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void miNewUser_Click(object sender, EventArgs e)
        {
            AddUserForm frm = new AddUserForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void miUpdateUser_Click(object sender, EventArgs e)
        {
            UserManagerForm frm = new UserManagerForm();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
