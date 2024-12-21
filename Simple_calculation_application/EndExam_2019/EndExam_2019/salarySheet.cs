using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EndExam_2019
{
    public partial class salarySheet : Form
    {

        public int EmpNo { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }

        public string Department {  get; set; }

        public salarySheet()
        {
            InitializeComponent();
        }

        private void salarySheet_Load(object sender, EventArgs e)
        {
            labelEmpNo.Text = EmpNo.ToString();
            labelname.Text = EmpName;
            labelDesignation.Text = Designation;

            labelBS.Text = SalaryCalculator.basicSalary.ToString();
            labelTA.Text = SalaryCalculator.totalAllowence.ToString();
            labelGP.Text = SalaryCalculator.grossPay.ToString();
            labelTD.Text = SalaryCalculator.totalDeduction.ToString();
            labelNP.Text = SalaryCalculator.netPay.ToString();
        }
                
    }
}
