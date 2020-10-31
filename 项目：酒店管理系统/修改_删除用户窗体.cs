using DAL;
using MySql.Data.MySqlClient;
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
    public partial class UserManagerForm : Form
    {
        public UserManagerForm()
        {
            InitializeComponent();
        }
        string Connstr = "server=localhost;user id= root;password=1584699582;database=Hotel;Charset=utf8;";
        MySqlConnection con = null;
        MySqlDataAdapter da = null;
        DataSet ds = null;
        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUserName.Text = dgvUsers.CurrentRow.Cells["userName"].Value.ToString();
            txtPwd.Text = dgvUsers.CurrentRow.Cells["userPwd"].Value.ToString();
            txtRole.Text = dgvUsers.CurrentRow.Cells["role"].Value.ToString();
        }

        private void UserManagerForm_Load(object sender, EventArgs e)
        {
            /*
          * con = new MySqlConnection(Connstr);
         da = new MySqlDataAdapter("select * from user", con);
         ds = new DataSet();
         da.Fill(ds, "user");
         dgvUsers.DataSource = ds.Tables["user"];
         */
            string sql = "select * from user";
            dgvUsers.DataSource = DBOper.GetDataTable(sql);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            da = new MySqlDataAdapter("select * from user", con);
            ds = new DataSet();
            da.Fill(ds, "user");
            MySqlCommandBuilder bulider = new MySqlCommandBuilder(da);
            DataRowCollection rows = ds.Tables["user"].Rows;
            DataRow row;
            for (int i = 0; i < rows.Count; i++)
            {
                row = rows[i];
                if (row["userName"].ToString() == txtUserName.Text)
                {
                    row["userPwd"] = txtPwd.Text;
                }
            }
            dgvUsers.DataSource = ds.Tables["user"];
            da.Update(ds, "user");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MySqlCommandBuilder builder = new MySqlCommandBuilder(da);
            DataRowCollection rows = ds.Tables["user"].Rows;
            DataRow row;
            for (int i = 0; i < rows.Count; i++)
            {
                row = rows[i];
                if (row["userName"].ToString() == txtUserName.Text)
                {
                    row.Delete();
                }
            }
            da.Update(ds, "user");
            dgvUsers.DataSource = ds.Tables["user"];
        }
    }
}
