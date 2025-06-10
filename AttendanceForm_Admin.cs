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
    public partial class AttendanceForm_Admin: Form
    {
        public AttendanceForm_Admin()
        {
            InitializeComponent();
        }

        private void AttendanceForm_Admin_Load(object sender, EventArgs e)
        {
            cmbClass.Items.AddRange(new string[]
   {
        "Grade 1", "Grade 2", "Grade 3", "Grade 10 Science"
   });
            cmbClass.SelectedIndex = -1;

            dtpDate.Value = DateTime.Today;

            // Setup DataGridView
            dataGridViewAttendance.ColumnCount = 3;
            dataGridViewAttendance.Columns[0].Name = "Roll No";
            dataGridViewAttendance.Columns[1].Name = "Student Name";

            // Add Present/Absent checkbox column
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            chk.HeaderText = "Present";
            chk.Name = "chkPresent";
            dataGridViewAttendance.Columns.Add(chk);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridViewAttendance.Rows.Clear();

            // Dummy students — In real DB, you'd fetch by class
            if (cmbClass.Text == "Grade 1")
            {
                dataGridViewAttendance.Rows.Add("101", "Ali Khan", true);
                dataGridViewAttendance.Rows.Add("102", "Sara Ahmed", false);
            }
            else if (cmbClass.Text == "Grade 10 Science")
            {
                dataGridViewAttendance.Rows.Add("201", "Ahmed Raza", true);
                dataGridViewAttendance.Rows.Add("202", "Fatima Noor", false);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectedClass = cmbClass.Text;
            DateTime date = dtpDate.Value;

            string summary = $"Attendance for {selectedClass} on {date.ToShortDateString()}:\n\n";

            foreach (DataGridViewRow row in dataGridViewAttendance.Rows)
            {
                if (row.IsNewRow) continue;

                string rollNo = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                bool isPresent = Convert.ToBoolean(row.Cells["chkPresent"].Value);

                summary += $"{rollNo} - {name}: {(isPresent ? "Present" : "Absent")}\n";
            }

            MessageBox.Show(summary, "Attendance Saved (Dummy)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
