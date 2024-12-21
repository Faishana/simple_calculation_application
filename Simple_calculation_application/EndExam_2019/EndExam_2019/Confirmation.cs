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
    public partial class Confirmation : Form
    {
        

        public Confirmation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            //If a message want to show anywhere
            MessageBox.Show("You have registre successfully!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Hand);
           
            //If you need to go another form we need to create a object like this
            SalaryCalculator salaryCalculator = new SalaryCalculator();
            salaryCalculator.Show();
            this.Hide();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            signUp signUp = new signUp();
            signUp.Show();
            this.Hide();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            labelFname.Text = signUp.fName;
            labelLname.Text = signUp.lName;
            labelNic.Text = signUp.nicNumber;
            labelStaffid.Text = signUp.staffid;
            labelDOB.Text = signUp.dob;
            labelGender.Text = signUp.gender;
            labelCivilStatus.Text = signUp.civilStatus;

        }
    }
}
