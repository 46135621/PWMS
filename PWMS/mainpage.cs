using PWMS.DataClass;
using PWMS.ModuleClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWMS
{
    public partial class mainpage : Form
    {
        ModuleClass.MyModule mainpageModule = new PWMS.ModuleClass.MyModule();
        public mainpage()
        {
            InitializeComponent();
        }

        private void employebirthday_Click(object sender, EventArgs e)
        {

        }

        private void Mainpage_load(object sender, EventArgs e)
        {
            MyModule.User_ID = MyMeans.Login_ID;
            MyModule.User_Name = MyMeans.Login_Name;
            mainpageModule.GetMenu(treeView1, menuStrip1);
            mainpageModule.MainPope(menuStrip1,MyMeans.Login_Name);
        }

        private void 基本资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 人事管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
     
        }

        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            //mainpageModule.TreeMenuF(menuStrip1, e);
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            mainpageModule.TreeMenuF(menuStrip1, e);
        }

        private void 数据库维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 人事档案浏览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainpageModule.Show_Form("人事档案管理",1);

        }

        private void 备份还原数据库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
