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
    public partial class signUp : Form
    {
        public static string fName;
        public static string lName;
        public static string sName;
        public static string nicNumber;
        public static string dob;
        public static string staffid;
        public static string gender;
        public static string civilStatus;
        public signUp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtnic.Text = "";
            txtStaffid.Text = "";
            radioMale.Checked = false;
            radioFemale.Checked = false;
            radioOther.Checked = false;
            radioMarried.Checked = false;
            radioUnmarried.Checked = false;

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            fName = txtFname.Text;
            lName = txtLname.Text;
            nicNumber = txtnic.Text;
            staffid = txtStaffid.Text;

            //for date input
            dob = dateDOB.Value.ToString();



            Confirmation confirmation = new Confirmation();
            confirmation.Show();
            this.Hide();
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMale.Checked)
            {
                gender = radioMale.Text;
            }
        }

        private void radioFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radioFemale.Checked)
            {
                gender = radioFemale.Text;
            }
        }

        private void radioOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOther.Checked)
            {
                gender = radioOther.Text;
            }
        }

        private void radioMarried_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMarried.Checked)
            {
                civilStatus = radioMarried.Text;
            }
        }

        private void radioUnmarried_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUnmarried.Checked)
            {
                civilStatus = radioUnmarried.Text;
            }
        }

        private void signUp_Load(object sender, EventArgs e)
        {

        }
    }
}
