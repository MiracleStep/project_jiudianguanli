namespace 项目_酒店管理系统
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.客房管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miUserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.miCheckIn = new System.Windows.Forms.ToolStripButton();
            this.miCheckOut = new System.Windows.Forms.ToolStripButton();
            this.miClientQuery = new System.Windows.Forms.ToolStripButton();
            this.miRoomQuery = new System.Windows.Forms.ToolStripButton();
            this.miNewUser = new System.Windows.Forms.ToolStripButton();
            this.miEditUser = new System.Windows.Forms.ToolStripButton();
            this.添加新用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改删除用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客房管理ToolStripMenuItem,
            this.查询管理ToolStripMenuItem,
            this.miUserManage,
            this.miAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1089, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 客房管理ToolStripMenuItem
            // 
            this.客房管理ToolStripMenuItem.Name = "客房管理ToolStripMenuItem";
            this.客房管理ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.客房管理ToolStripMenuItem.Text = "客房管理";
            // 
            // 查询管理ToolStripMenuItem
            // 
            this.查询管理ToolStripMenuItem.Name = "查询管理ToolStripMenuItem";
            this.查询管理ToolStripMenuItem.Size = new System.Drawing.Size(98, 28);
            this.查询管理ToolStripMenuItem.Text = "查询管理";
            // 
            // miUserManage
            // 
            this.miUserManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加新用户ToolStripMenuItem,
            this.修改删除用户ToolStripMenuItem});
            this.miUserManage.Name = "miUserManage";
            this.miUserManage.Size = new System.Drawing.Size(98, 28);
            this.miUserManage.Text = "用户管理";
            this.miUserManage.Click += new System.EventHandler(this.miUserManage_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(62, 28);
            this.miAbout.Text = "帮助";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCheckIn,
            this.miCheckOut,
            this.miClientQuery,
            this.miRoomQuery,
            this.miNewUser,
            this.miEditUser});
            this.toolStrip1.Location = new System.Drawing.Point(0, 32);
            this.toolStrip1.Margin = new System.Windows.Forms.Padding(0, 22, 0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1089, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // miCheckIn
            // 
            this.miCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("miCheckIn.Image")));
            this.miCheckIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miCheckIn.Name = "miCheckIn";
            this.miCheckIn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.miCheckIn.Size = new System.Drawing.Size(130, 28);
            this.miCheckIn.Text = "入住登记";
            this.miCheckIn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // miCheckOut
            // 
            this.miCheckOut.Image = ((System.Drawing.Image)(resources.GetObject("miCheckOut.Image")));
            this.miCheckOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miCheckOut.Name = "miCheckOut";
            this.miCheckOut.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.miCheckOut.Size = new System.Drawing.Size(130, 28);
            this.miCheckOut.Text = "退房登记";
            this.miCheckOut.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // miClientQuery
            // 
            this.miClientQuery.Image = ((System.Drawing.Image)(resources.GetObject("miClientQuery.Image")));
            this.miClientQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miClientQuery.Name = "miClientQuery";
            this.miClientQuery.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.miClientQuery.Size = new System.Drawing.Size(130, 28);
            this.miClientQuery.Text = "住客信息";
            this.miClientQuery.Click += new System.EventHandler(this.miRoom_Click);
            // 
            // miRoomQuery
            // 
            this.miRoomQuery.Image = ((System.Drawing.Image)(resources.GetObject("miRoomQuery.Image")));
            this.miRoomQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miRoomQuery.Name = "miRoomQuery";
            this.miRoomQuery.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.miRoomQuery.Size = new System.Drawing.Size(130, 28);
            this.miRoomQuery.Text = "客房信息";
            this.miRoomQuery.Click += new System.EventHandler(this.miClient_Click);
            // 
            // miNewUser
            // 
            this.miNewUser.Image = ((System.Drawing.Image)(resources.GetObject("miNewUser.Image")));
            this.miNewUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miNewUser.Name = "miNewUser";
            this.miNewUser.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.miNewUser.Size = new System.Drawing.Size(148, 28);
            this.miNewUser.Text = "添加新用户";
            this.miNewUser.Click += new System.EventHandler(this.miNewUser_Click);
            // 
            // miEditUser
            // 
            this.miEditUser.Image = ((System.Drawing.Image)(resources.GetObject("miEditUser.Image")));
            this.miEditUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.miEditUser.Name = "miEditUser";
            this.miEditUser.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.miEditUser.Size = new System.Drawing.Size(174, 28);
            this.miEditUser.Text = "修改/删除用户";
            this.miEditUser.Click += new System.EventHandler(this.miUpdateUser_Click);
            // 
            // 添加新用户ToolStripMenuItem
            // 
            this.添加新用户ToolStripMenuItem.Name = "添加新用户ToolStripMenuItem";
            this.添加新用户ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.添加新用户ToolStripMenuItem.Text = "添加新用户";
            // 
            // 修改删除用户ToolStripMenuItem
            // 
            this.修改删除用户ToolStripMenuItem.Name = "修改删除用户ToolStripMenuItem";
            this.修改删除用户ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.修改删除用户ToolStripMenuItem.Text = "修改/删除用户";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 634);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "酒店管理系统";
            this.Load += new System.EventHandler(this.主界面窗体_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 客房管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miUserManage;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton miCheckIn;
        private System.Windows.Forms.ToolStripButton miCheckOut;
        private System.Windows.Forms.ToolStripButton miClientQuery;
        private System.Windows.Forms.ToolStripButton miRoomQuery;
        private System.Windows.Forms.ToolStripButton miNewUser;
        private System.Windows.Forms.ToolStripButton miEditUser;
        private System.Windows.Forms.ToolStripMenuItem 添加新用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改删除用户ToolStripMenuItem;
    }
}