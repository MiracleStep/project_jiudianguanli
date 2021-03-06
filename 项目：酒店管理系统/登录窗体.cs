﻿using BLL;
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
    public partial class 登陆窗体 : Form
    {
        public 登陆窗体()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void i_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string strName = txtName.Text;
            string strPwd = txtPwd.Text;
            if (string.IsNullOrEmpty(strPwd))
            {
                MessageBox.Show("密码不能为空","提示", buttons: MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            User user = UserManager.GetUser(strName, strPwd);
            if (user == null)
            {
                MessageBox.Show("用户名或密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                RoleManager.curUser = user;
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
