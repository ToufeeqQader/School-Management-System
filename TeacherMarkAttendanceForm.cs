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
    public partial class TeacherMarkAttendanceForm: Form
    {
        public TeacherMarkAttendanceForm()
        {
            InitializeComponent();
        }

        private void LoadDummyStudents(string className)
        {
            dgvStudents.Rows.Clear();

            if (className == "10-A")
            {
                dgvStudents.Rows.Add("1", "Ali Ahmed", true);
                dgvStudents.Rows.Add("2", "Sana Tariq", false);
                dgvStudents.Rows.Add("3", "Zain Khan", true);
            }
            else if (className == "9-B")
            {
                dgvStudents.Rows.Add("1", "Imran Malik", true);
                dgvStudents.Rows.Add("2", "Ayesha Noor", false);
            }
            // Add more cases if needed
        }

        private void ComboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedClass = cmbClass.SelectedItem.ToString();
            LoadDummyStudents(selectedClass);
        }

        private void SetupGrid()
        {
            dgvStudents.Columns.Clear();

            dgvStudents.Columns.Add("RollNo", "Roll No");
            dgvStudents.Columns.Add("Name", "Name");

            DataGridViewCheckBoxColumn presentCheckbox = new DataGridViewCheckBoxColumn();
            presentCheckbox.HeaderText = "Present";
            presentCheckbox.Name = "Present";
            dgvStudents.Columns.Add(presentCheckbox);

            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.RowHeadersVisible = false;
        }

        private void TeacherMarkAttendanceForm_Load(object sender, EventArgs e)
        {
            cmbClass.Items.AddRange(new string[] { "10-A", "9-B", "11-C" });
            cmbClass.SelectedIndex = 0;

            SetupGrid();
            LoadDummyStudents("10-A");

            cmbClass.SelectedIndexChanged += ComboBoxClass_SelectedIndexChanged;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string classSelected = cmbClass.SelectedItem.ToString();
            string date = dtpDate.Value.ToShortDateString();

            string attendanceSummary = $"Attendance for {classSelected} on {date}:\n\n";

            foreach (DataGridViewRow row in dgvStudents.Rows)
            {
                string roll = row.Cells["RollNo"].Value.ToString();
                string name = row.Cells["Name"].Value.ToString();
                bool isPresent = Convert.ToBoolean(row.Cells["Present"].Value);

                attendanceSummary += $"{roll} - {name}: {(isPresent ? "Present" : "Absent")}\n";
            }

            MessageBox.Show(attendanceSummary, "Attendance Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
