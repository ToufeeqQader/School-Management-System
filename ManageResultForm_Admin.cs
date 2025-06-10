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
    public partial class ManageResultForm_Admin: Form
    {
        public ManageResultForm_Admin()
        {
            InitializeComponent();
        }

        private void SetupResultGrid()
        {
            dataGridViewResults.Columns.Clear();

            dataGridViewResults.Columns.Add("StudentName", "Student Name");
            dataGridViewResults.Columns.Add("Math", "Math");
            dataGridViewResults.Columns.Add("Science", "Science");
            dataGridViewResults.Columns.Add("English", "English");
            dataGridViewResults.Columns.Add("Physics", "Physics");

            dataGridViewResults.Columns.Add("Obtained", "Obtained Marks");
            dataGridViewResults.Columns["Obtained"].ReadOnly = true;

            dataGridViewResults.Columns.Add("Total", "Total Marks");
            dataGridViewResults.Columns["Total"].ReadOnly = true;

            dataGridViewResults.Columns.Add("Percentage", "Percentage");
            dataGridViewResults.Columns["Percentage"].ReadOnly = true;
        }

        private void ManageResultForm_Admin_Load(object sender, EventArgs e)
        {
            cmbClass.Items.AddRange(new string[] {
        "Grade 1", "Grade 2", "Grade 10 Science"
    });

            cmbExamType.Items.AddRange(new string[] {
        "Midterm", "Final", "Quiz", "Class Test"
    });

            cmbClass.SelectedIndex = -1;
            cmbExamType.SelectedIndex = -1;

            SetupResultGrid();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridViewResults.Rows.Clear();

            if (cmbClass.Text == "Grade 1")
            {
                dataGridViewResults.Rows.Add("Ali Khan", "", "", "", "", "", "", "");
                dataGridViewResults.Rows.Add("Sara Ahmed", "", "", "", "", "", "", "");
            }
            else if (cmbClass.Text == "Grade 10 Science")
            {
                dataGridViewResults.Rows.Add("Ahmed Raza", "", "", "", "", "", "", "");
                dataGridViewResults.Rows.Add("Fatima Noor", "", "", "", "", "", "", "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex == -1 || cmbExamType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Class and Exam Type.");
                return;
            }

            string summary = $"Results for {cmbClass.Text} ({cmbExamType.Text}):\n\n";

            foreach (DataGridViewRow row in dataGridViewResults.Rows)
            {
                if (row.IsNewRow) continue;

                string name = row.Cells["StudentName"].Value?.ToString() ?? "";
                int total = 0;
                int obtained = 0;
                int maxPerSubject = 100;

                string[] subjects = { "Math", "Science", "English", "Physics" };

                foreach (string subject in subjects)
                {
                    string val = row.Cells[subject].Value?.ToString() ?? "";
                    if (int.TryParse(val, out int marks))
                    {
                        obtained += marks;
                    }
                    total += maxPerSubject;
                }

                double percentage = (double)obtained / total * 100;
                row.Cells["Obtained"].Value = obtained;
                row.Cells["Total"].Value = total;
                row.Cells["Percentage"].Value = $"{percentage:F2}%";

                summary += $"{name}: {obtained}/{total} - {percentage:F2}%\n";
            }

            MessageBox.Show(summary, "Results Saved (Dummy)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
