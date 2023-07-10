using PWMS.DataClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWMS.PerForm
{
    public partial class F_ManFile : Form
    {
        public F_ManFile()
        {
            InitializeComponent();
        }
        DataClass.MyMeans basicData = new DataClass.MyMeans();
        ModuleClass.MyModule basicModule = new PWMS.ModuleClass.MyModule();

        private void F_Basics_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
