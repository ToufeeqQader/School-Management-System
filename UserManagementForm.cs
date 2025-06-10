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
    public partial class UserManagementForm: Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
            
        }
        private void ClearFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = -1;
        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            // Setup columns first
            dataGridViewUsers.ColumnCount = 3;
            dataGridViewUsers.Columns[0].Name = "Username";
            dataGridViewUsers.Columns[1].Name = "Role";
            dataGridViewUsers.Columns[2].Name = "Password";

            dataGridViewUsers.Columns[2].Visible = false; // Hide password column

            // Add sample data
            dataGridViewUsers.Rows.Add("admin", "Admin", "admin123");
            dataGridViewUsers.Rows.Add("teacher1", "Teacher", "teach456");
            dataGridViewUsers.Rows.Add("student1", "Student", "stud789");

            // Fill combo box
            cmbRole.Items.AddRange(new string[] { "Admin", "Teacher", "Student" });
            cmbRole.SelectedIndex = -1;
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
               string.IsNullOrWhiteSpace(txtPassword.Text) ||
               cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            string username = txtUsername.Text.Trim();
            string role = cmbRole.Text;
            string password = txtPassword.Text;

            bool userExists = false;

            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                if (row.Cells[0].Value?.ToString() == username)
                {
                    row.Cells[1].Value = role;
                    row.Cells[2].Value = password;
                    userExists = true;
                    MessageBox.Show("User updated successfully.");
                    break;
                }
            }

            if (!userExists)
            {
                dataGridViewUsers.Rows.Add(username, role, password);
                MessageBox.Show("User added successfully.");
            }

            ClearFields();

        }

        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to reset the password.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a new password.");
                return;
            }

            var row = dataGridViewUsers.SelectedRows[0];
            row.Cells[2].Value = txtPassword.Text;

            MessageBox.Show("Password reset successfully.");
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                var row = dataGridViewUsers.SelectedRows[0];
                DialogResult result = MessageBox.Show("Delete selected user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dataGridViewUsers.Rows.RemoveAt(row.Index);
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchUsername = txtUsername.Text.Trim();
            bool userFound = false;

            foreach (DataGridViewRow row in dataGridViewUsers.Rows)
            {
                if (row.Cells[0].Value?.ToString().Equals(searchUsername, StringComparison.OrdinalIgnoreCase) == true)
                {
                    row.Selected = true;
                    dataGridViewUsers.FirstDisplayedScrollingRowIndex = row.Index;

                    txtUsername.Text = row.Cells[0].Value?.ToString();
                    cmbRole.Text = row.Cells[1].Value?.ToString();
                    txtPassword.Text = row.Cells[2].Value?.ToString();

                    userFound = true;
                    break;
                }
            }

            if (!userFound)
            {
                MessageBox.Show("User not found.");
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewUsers.Rows[e.RowIndex];
                txtUsername.Text = row.Cells[0].Value?.ToString();
                cmbRole.Text = row.Cells[1].Value?.ToString();
                txtPassword.Text = row.Cells[2].Value?.ToString();
            }
        }
    }
}
