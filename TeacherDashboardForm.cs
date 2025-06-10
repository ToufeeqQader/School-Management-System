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
    public partial class TeacherDashboardForm: Form
    {
        public TeacherDashboardForm()
        {
            InitializeComponent();
        }

        private void TeacherDashboardForm_Load(object sender, EventArgs e)
        {
            // Dummy teacher data
            txtTeacherName.Text = "Mr. Ahmed Ali";
            txtEmail.Text = "ahmed.ali@school.edu.pk";
            txtAddress.Text = "123 Canal Road, Lahore";
            txtContact.Text = "03211234567";
            txtGender.Text = "Male";
            txtDOB.Text = "15-Aug-1985";
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

        private void btnMyclasses_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            TeacherClassForm form = new TeacherClassForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnMarkAttendance_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            TeacherMarkAttendanceForm form = new TeacherMarkAttendanceForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnMarkResults_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            TeacherMarkResultForm form = new TeacherMarkResultForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            StudentInfoForm form = new StudentInfoForm();
            form.ShowDialog();
            this.Show();
        }
    }
}
