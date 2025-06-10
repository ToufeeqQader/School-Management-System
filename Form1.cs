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
    public partial class LoginForm: Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string selectedRole = cmbRole.SelectedItem?.ToString();

            // Dummy credentials
            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select a role (Admin or Student).", "Missing Role", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRole == "Admin")
            {
                // Dummy Admin Login
                if (username == "admin" && password == "admin123")
                {
                    MessageBox.Show("Login successful!", "Welcome Admin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdminDashboard dashboard = new AdminDashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid admin credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectedRole == "Student")
            {
                // Dummy Student Login
                if (username == "student1" && password == "1234")
                {
                    MessageBox.Show("Login successful!", "Welcome Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentDashboard studentDashboard = new StudentDashboard();
                    studentDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid student credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (selectedRole == "Teacher")
            {
                if (username == "teacher1" && password == "teach123")
                {
                    MessageBox.Show("Login successful!", "Welcome Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TeacherDashboardForm teacherDashboard = new TeacherDashboardForm();
                    teacherDashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid teacher credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Student");
            cmbRole.Items.Add("Teacher");
            cmbRole.SelectedIndex = 0;
        }
    }
    
}
