using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndExam_2019
{
    public partial class SalaryCalculator : Form
    {
        public static DataTable dt = new DataTable();

        public static double basicSalary;
        public static double totalAllowence;
        public static double grossPay;
        public static double totalDeduction;
        public static double netPay; 

        public void EmployeeDetails() { 
            dt.Columns.Add("Emp_No",typeof(int));
            dt.Columns.Add("Name");
            dt.Columns.Add("Designation");
            dt.Columns.Add("Department");
            dt.Columns.Add("Basic Salary",typeof(double));

            dt.Rows.Add(748, "Tom laara", "Temp.Lecture", "ICT", 49860.00);
            dt.Rows.Add(749, "Ben Stacy", "Temp.Lecture", "Bio-science", 49860.00);
            dt.Rows.Add(635, "Sam Steve", "Temp.Lecture", "ICT", 40960.00);
            dt.Rows.Add(852, "John Mark", "Lecture(Prob)", "ICT", 85950.00);
            dt.Rows.Add(925, "Cooper Jake", "Senior Lecture", "HR", 100000.00);
            dt.Rows.Add(853, "Adams Jane", "Lecture(Prob),", "Marketing", 85950.00);
        }
        public SalaryCalculator()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SalaryCalculator_Load(object sender, EventArgs e)
        {
            //call the method for employeedetails data table
            EmployeeDetails();
            
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "Name";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            labelBS.Text = dt.Rows[comboBox1.SelectedIndex]["Basic Salary"].ToString();
            basicSalary = Convert.ToDouble(labelBS.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double livingAllowence = 7800.00;
            double monthlyAllowence = 5000.00;

            totalAllowence = livingAllowence+ monthlyAllowence;
            labelTA.Text = totalAllowence.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grossPay = basicSalary + totalAllowence;
            labelGP.Text = grossPay.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double stamp_duty = 25.00;
            double UPF = 5766.00;

            totalDeduction = stamp_duty + UPF;
            labelTD.Text = totalDeduction.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            netPay =  grossPay - totalDeduction;
            labelNP.Text = netPay.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            salarySheet salarySheet = new salarySheet();

            salarySheet.EmpNo = Convert.ToInt32(dt.Rows[comboBox1.SelectedIndex]["Emp_No"]);
            salarySheet.EmpName = dt.Rows[comboBox1.SelectedIndex]["Name"].ToString();
            salarySheet.Designation = dt.Rows[comboBox1.SelectedIndex]["Designation"].ToString();
            salarySheet.Department = dt.Rows[comboBox1.SelectedIndex]["Department"].ToString();

            salarySheet.Show();
            this.Hide();
        }
    }
}
