namespace PWMS
{
    partial class mainpage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.基本信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人事管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人事档案浏览ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人事资料查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人事资料统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.备份还原数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基本资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.资料管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门类别设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工资类别设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.职务类别设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.职称类别设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.奖惩类别设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本信息管理ToolStripMenuItem,
            this.人事管理ToolStripMenuItem,
            this.数据库维护ToolStripMenuItem,
            this.系统管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 基本信息管理ToolStripMenuItem
            // 
            this.基本信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基本资料ToolStripMenuItem,
            this.资料管理ToolStripMenuItem});
            this.基本信息管理ToolStripMenuItem.Name = "基本信息管理ToolStripMenuItem";
            this.基本信息管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.基本信息管理ToolStripMenuItem.Text = "基本资料";
            this.基本信息管理ToolStripMenuItem.Click += new System.EventHandler(this.基本资料ToolStripMenuItem_Click);
            // 
            // 人事管理ToolStripMenuItem
            // 
            this.人事管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.人事档案浏览ToolStripMenuItem,
            this.人事资料查询ToolStripMenuItem,
            this.人事资料统计ToolStripMenuItem});
            this.人事管理ToolStripMenuItem.Name = "人事管理ToolStripMenuItem";
            this.人事管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.人事管理ToolStripMenuItem.Text = "人事管理";
            this.人事管理ToolStripMenuItem.Click += new System.EventHandler(this.人事管理ToolStripMenuItem_Click);
            // 
            // 人事档案浏览ToolStripMenuItem
            // 
            this.人事档案浏览ToolStripMenuItem.Name = "人事档案浏览ToolStripMenuItem";
            this.人事档案浏览ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.人事档案浏览ToolStripMenuItem.Text = "人事档案浏览";
            this.人事档案浏览ToolStripMenuItem.Click += new System.EventHandler(this.人事档案浏览ToolStripMenuItem_Click);
            // 
            // 人事资料查询ToolStripMenuItem
            // 
            this.人事资料查询ToolStripMenuItem.Name = "人事资料查询ToolStripMenuItem";
            this.人事资料查询ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.人事资料查询ToolStripMenuItem.Text = "人事资料查询";
            // 
            // 人事资料统计ToolStripMenuItem
            // 
            this.人事资料统计ToolStripMenuItem.Name = "人事资料统计ToolStripMenuItem";
            this.人事资料统计ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.人事资料统计ToolStripMenuItem.Text = "人事资料统计";
            // 
            // 数据库维护ToolStripMenuItem
            // 
            this.数据库维护ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.备份还原数据库ToolStripMenuItem,
            this.清空数据库ToolStripMenuItem});
            this.数据库维护ToolStripMenuItem.Name = "数据库维护ToolStripMenuItem";
            this.数据库维护ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.数据库维护ToolStripMenuItem.Text = "数据库维护";
            this.数据库维护ToolStripMenuItem.Click += new System.EventHandler(this.数据库维护ToolStripMenuItem_Click);
            // 
            // 备份还原数据库ToolStripMenuItem
            // 
            this.备份还原数据库ToolStripMenuItem.Enabled = false;
            this.备份还原数据库ToolStripMenuItem.Name = "备份还原数据库ToolStripMenuItem";
            this.备份还原数据库ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.备份还原数据库ToolStripMenuItem.Text = "备份/还原数据库";
            this.备份还原数据库ToolStripMenuItem.Click += new System.EventHandler(this.备份还原数据库ToolStripMenuItem_Click);
            // 
            // 清空数据库ToolStripMenuItem
            // 
            this.清空数据库ToolStripMenuItem.Enabled = false;
            this.清空数据库ToolStripMenuItem.Name = "清空数据库ToolStripMenuItem";
            this.清空数据库ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.清空数据库ToolStripMenuItem.Text = "清空数据库";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新登陆ToolStripMenuItem,
            this.用户设置ToolStripMenuItem,
            this.系统退出ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 重新登陆ToolStripMenuItem
            // 
            this.重新登陆ToolStripMenuItem.Enabled = false;
            this.重新登陆ToolStripMenuItem.Name = "重新登陆ToolStripMenuItem";
            this.重新登陆ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.重新登陆ToolStripMenuItem.Text = "重新登陆";
            // 
            // 用户设置ToolStripMenuItem
            // 
            this.用户设置ToolStripMenuItem.Name = "用户设置ToolStripMenuItem";
            this.用户设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.用户设置ToolStripMenuItem.Text = "用户设置";
            // 
            // 系统退出ToolStripMenuItem
            // 
            this.系统退出ToolStripMenuItem.Name = "系统退出ToolStripMenuItem";
            this.系统退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.系统退出ToolStripMenuItem.Text = "系统退出";
            // 
            // 基本资料ToolStripMenuItem
            // 
            this.基本资料ToolStripMenuItem.Name = "基本资料ToolStripMenuItem";
            this.基本资料ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.基本资料ToolStripMenuItem.Text = "基本资料";
            // 
            // 资料管理ToolStripMenuItem
            // 
            this.资料管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.部门类别设置ToolStripMenuItem,
            this.工资类别设置ToolStripMenuItem,
            this.职务类别设置ToolStripMenuItem,
            this.职称类别设置ToolStripMenuItem,
            this.奖惩类别设置ToolStripMenuItem});
            this.资料管理ToolStripMenuItem.Name = "资料管理ToolStripMenuItem";
            this.资料管理ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.资料管理ToolStripMenuItem.Text = "资料管理";
            // 
            // 部门类别设置ToolStripMenuItem
            // 
            this.部门类别设置ToolStripMenuItem.Name = "部门类别设置ToolStripMenuItem";
            this.部门类别设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.部门类别设置ToolStripMenuItem.Text = "部门类别设置";
            // 
            // 工资类别设置ToolStripMenuItem
            // 
            this.工资类别设置ToolStripMenuItem.Name = "工资类别设置ToolStripMenuItem";
            this.工资类别设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.工资类别设置ToolStripMenuItem.Text = "工资类别设置";
            // 
            // 职务类别设置ToolStripMenuItem
            // 
            this.职务类别设置ToolStripMenuItem.Name = "职务类别设置ToolStripMenuItem";
            this.职务类别设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.职务类别设置ToolStripMenuItem.Text = "职务类别设置";
            // 
            // 职称类别设置ToolStripMenuItem
            // 
            this.职称类别设置ToolStripMenuItem.Name = "职称类别设置ToolStripMenuItem";
            this.职称类别设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.职称类别设置ToolStripMenuItem.Text = "职称类别设置";
            // 
            // 奖惩类别设置ToolStripMenuItem
            // 
            this.奖惩类别设置ToolStripMenuItem.Name = "奖惩类别设置ToolStripMenuItem";
            this.奖惩类别设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.奖惩类别设置ToolStripMenuItem.Text = "奖惩类别设置";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 61);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(303, 356);
            this.treeView1.TabIndex = 4;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            // 
            // mainpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainpage";
            this.Text = "主页面";
            this.Load += new System.EventHandler(this.Mainpage_load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 基本信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人事管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人事档案浏览ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人事资料查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人事资料统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 备份还原数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空数据库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登陆ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基本资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 资料管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门类别设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工资类别设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 职务类别设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 职称类别设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 奖惩类别设置ToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        public System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
    }
}