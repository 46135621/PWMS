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
    public partial class F_Basics : Form
    {
        public F_Basics()
        {
            InitializeComponent();
        }
        DataClass.MyMeans basicData = new DataClass.MyMeans();
        ModuleClass.MyModule basicModule = new PWMS.ModuleClass.MyModule();

        private void F_Basics_Load(object sender, EventArgs e)
        {
            DataSet DSet = basicData.getDataSet("select * from tb_Stuffbasic where ID = '" + MyMeans.Login_ID + "'", "tb_Stuffbasic");
            ID.Text = DSet.Tables[0].Rows[0][0].ToString();
            Basci_Name.Text = DSet.Tables[0].Rows[0][2].ToString();
            Sex.Text = DSet.Tables[0].Rows[0][3].ToString();
            BranchName.Text = DSet.Tables[0].Rows[0][4].ToString();
            BusinessName.Text = DSet.Tables[0].Rows[0][5].ToString();
            LaborageName.Text = DSet.Tables[0].Rows[0][6].ToString();
            MonthlySalary.Text = DSet.Tables[0].Rows[0][7].ToString();
            BankAccount.Text = DSet.Tables[0].Rows[0][8].ToString();
            Birthday.Text = basicModule.Date_Format(DSet.Tables[0].Rows[0][9].ToString());
            Pact_E.Text = basicModule.Date_Format(DSet.Tables[0].Rows[0][10].ToString());
        }

    }
}
