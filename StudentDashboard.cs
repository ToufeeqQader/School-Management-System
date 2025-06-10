using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace schoolmanagementsystem
{
    public partial class StudentDashboard: Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close(); // or Hide();
            }
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            txtName.Text = "John Cena";
            txtClass.Text = "Grade 10";
            txtRollNo.Text = "23";
            txtParentName.Text = "John Doe";
            txtGender.Text = "Male";
            txtDOB.Text = "2009-04-15";
            txtContact.Text = "9876543210";
            txtAddress.Text = "123 Street, City";
        }

        private void btnViewAttendance_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            StudentAttendanceForm form = new StudentAttendanceForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnViewMarks_Click(object sender, EventArgs e)
        {

            this.Hide(); // Hide the dashboard form

            ViewMarksForm form = new ViewMarksForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnViewFee_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            ViewFeeForm form = new ViewFeeForm();
            form.ShowDialog();
            this.Show();
        }
    }
}
