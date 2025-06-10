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
    public partial class AdminDashboard: Form
    {
        public AdminDashboard()
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

        private void btnStudents_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            ManageStudentForm form = new ManageStudentForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            ManageTeachersForm form = new ManageTeachersForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnclasses_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            ManageClassesForm form = new ManageClassesForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            SubjectManagementForm form = new SubjectManagementForm();
            form.ShowDialog();
            this.Show();

        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            AttendanceForm_Admin form = new AttendanceForm_Admin();
            form.ShowDialog();
            this.Show();
        }

        private void btnResults_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

           ManageResultForm_Admin form = new ManageResultForm_Admin();
            form.ShowDialog();
            this.Show();
        }

        private void btnFees_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            ManageFeeForm form = new ManageFeeForm();
            form.ShowDialog();
            this.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            UserManagementForm form = new UserManagementForm();
            form.ShowDialog();
            this.Show();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            // Dummy counts
            int totalStudents = 8;
            int totalTeachers = 3;
            int totalClasses = 3;
            int totalSubjects = 5;
            decimal totalCollected = 5000;
            decimal totalPending = 3000;

            // Set labels
            lblStudents.Text = totalStudents.ToString();
            lblTeachers.Text = totalTeachers.ToString();
            lblClasses.Text = totalClasses.ToString();
            lblSubjects.Text = totalSubjects.ToString();
            lblFeesCollected.Text = $"PKR {totalCollected:N0}";
            lblFeesPending.Text = $"PKR {totalPending:N0}";
        }

        private void btnUpdateStats_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the dashboard form

            ReportForm form = new ReportForm();
            form.ShowDialog();
            this.Show();
        }
    }
}
