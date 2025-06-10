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
    public partial class TeacherMarkResultForm: Form
    {
        public TeacherMarkResultForm()
        {
            InitializeComponent();
        }

        private void LoadStudentData()
        {
            string key = cmbClass.Text + "-" + cmbSubject.Text + "-" + cmbExam.Text;
            dgvMarkResult.Rows.Clear();

            List<StudentMark> studentList;

            if (resultsDatabase.ContainsKey(key))
            {
                // Load previously saved data
                studentList = resultsDatabase[key];
            }
            else
            {
                // Dummy students
                studentList = new List<StudentMark>();

                if (cmbClass.Text == "10-A")
                {
                    studentList.Add(new StudentMark { RollNo = "1", Name = "Ali Ahmed", Marks = "" });
                    studentList.Add(new StudentMark { RollNo = "2", Name = "Sana Tariq", Marks = "" });
                }
                else if (cmbClass.Text == "9-B")
                {
                    studentList.Add(new StudentMark { RollNo = "1", Name = "Imran Malik", Marks = "" });
                    studentList.Add(new StudentMark { RollNo = "2", Name = "Ayesha Noor", Marks = "" });
                }
            }

            // Fill grid
            foreach (var s in studentList)
            {
                dgvMarkResult.Rows.Add(s.RollNo, s.Name, s.Marks);
            }
        }

        private void SetupGrid()
        {
            dgvMarkResult.Columns.Clear();

            dgvMarkResult.Columns.Add("RollNo", "Roll No");
            dgvMarkResult.Columns.Add("Name", "Name");

            DataGridViewTextBoxColumn marksCol = new DataGridViewTextBoxColumn();
            marksCol.Name = "Marks";
            marksCol.HeaderText = "Marks";
            dgvMarkResult.Columns.Add(marksCol);

            dgvMarkResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMarkResult.AllowUserToAddRows = false;
            dgvMarkResult.RowHeadersVisible = false;
        }

        private Dictionary<string, List<StudentMark>> resultsDatabase = new Dictionary<string, List<StudentMark>>();

        private class StudentMark
        {
            public string RollNo { get; set; }
            public string Name { get; set; }
            public string Marks { get; set; }
        }
        private void TeacherMarkResultForm_Load(object sender, EventArgs e)
        {
            cmbClass.Items.AddRange(new string[] { "10-A", "9-B" });
            cmbClass.SelectedIndex = 0;

            cmbSubject.Items.AddRange(new string[] { "Math", "English" });
            cmbSubject.SelectedIndex = 0;

            SetupGrid();
            LoadStudentData();

            cmbClass.SelectedIndexChanged += (_, __) => LoadStudentData();
            cmbSubject.SelectedIndexChanged += (_, __) => LoadStudentData();
            cmbExam.SelectedIndexChanged += (_, __) => LoadStudentData();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string key = cmbClass.Text + "-" + cmbSubject.Text + "-" + cmbExam.Text;

            List<StudentMark> newList = new List<StudentMark>();

            foreach (DataGridViewRow row in dgvMarkResult.Rows)
            {
                if (row.IsNewRow) continue;

                string roll = row.Cells["RollNo"].Value.ToString();
                string name = row.Cells["Name"].Value.ToString();
                string marks = row.Cells["Marks"].Value?.ToString() ?? "";

                newList.Add(new StudentMark { RollNo = roll, Name = name, Marks = marks });
            }

            resultsDatabase[key] = newList;

            MessageBox.Show($"Results for {cmbExam.Text} saved/updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
