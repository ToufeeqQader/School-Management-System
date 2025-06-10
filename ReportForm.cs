using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static schoolmanagementsystem.ManageStudentForm;

namespace schoolmanagementsystem
{
    public partial class ReportForm: Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        public ReportForm()
        {
            InitializeComponent();
        }
        private void SetupDataGridViewColumns()
        {
            if (dgvResults.Columns.Count == 0)
            {
                dgvResults.Columns.Add("RollNo", "Roll No");
                dgvResults.Columns.Add("Name", "Name");
                dgvResults.Columns.Add("ClassName", "Class");
            }

            if (dataGraidViewFees.Columns.Count == 0)
            {
                dataGraidViewFees.Columns.Add("RollNo", "Roll No");
                dataGraidViewFees.Columns.Add("Name", "Name");
                dataGraidViewFees.Columns.Add("ClassName", "Class");
            }

            if (dgvAttendanceList.Columns.Count == 0)
            {
                dgvAttendanceList.Columns.Add("RollNo", "Roll No");
                dgvAttendanceList.Columns.Add("Name", "Name");
                dgvAttendanceList.Columns.Add("ClassName", "Class");
            }
        }
        private void InitializeStudentData()
        {
            allStudents = new List<Student>
    {
        new Student {
            RollNo = "1001",
            Name = "Ali Khan",
            ClassName = "Grade 1",
            Marks = new Dictionary<string, int> {
                { "Math", 90 }, { "Science", 85 }, { "English", 88 }
            },
            AttendanceRecords = new Dictionary<DateTime, string> {
                { new DateTime(2025, 6, 1), "Present" },
                { new DateTime(2025, 6, 2), "Absent" },
                { new DateTime(2025, 6, 3), "Present" }
            },
            MonthlyFee = 2000,
            TransportFee = 500,
            OtherCharges = 150
        },
        new Student {
            RollNo = "1002",
            Name = "Sara Ahmed",
            ClassName = "Grade 1",
            Marks = new Dictionary<string, int> {
                { "Math", 78 }, { "Science", 82 }, { "English", 80 }
            },
            AttendanceRecords = new Dictionary<DateTime, string> {
                { new DateTime(2025, 6, 1), "Absent" },
                { new DateTime(2025, 6, 2), "Absent" },
                { new DateTime(2025, 6, 3), "Present" }
            },
            MonthlyFee = 2000,
            TransportFee = 400,
            OtherCharges = 100
        }
    };
        }
        private void AddSelectCheckboxColumn(DataGridView dgv)
        {
            // Only add if not already present
            if (!dgv.Columns.Contains("Select"))
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.HeaderText = "Select";
                checkboxColumn.Name = "Select";
                checkboxColumn.Width = 50;
                checkboxColumn.FalseValue = false;
                checkboxColumn.TrueValue = true;
                checkboxColumn.IndeterminateValue = false;
                dgv.Columns.Insert(0, checkboxColumn); // Insert at the beginning
            }
        }
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (printIndex < reportsToPrint.Count)
            {
                string report = reportsToPrint[printIndex];
                Font font = new Font("Courier New", 10);
                RectangleF marginBounds = e.MarginBounds;

                e.Graphics.DrawString(report, font, Brushes.Black, marginBounds);

                printIndex++;
                e.HasMorePages = printIndex < reportsToPrint.Count; // Print next page if more
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private int printIndex = 0;
        private List<string> reportsToPrint = new List<string>();

        private bool suppressTextChanged = false;
        private void ReGenerateChallanIfNeeded()
        {
            if (dataGraidViewFees.SelectedRows.Count > 0)
            {
                string roll = dataGraidViewFees.SelectedRows[0].Cells["RollNo"].Value.ToString();
                Student s = allStudents.First(st => st.RollNo == roll);
                suppressTextChanged = true;
                rtbFeeChallan.Text = GenerateChallanText(s);
                suppressTextChanged = false;
            }
        }

        private void rtbFeeChallan_TextChanged(object sender, EventArgs e)
        {
            if (!suppressTextChanged)
            {
                ReGenerateChallanIfNeeded();
            }
        }
        private string GenerateChallanText(Student s)
        {
            decimal total = s.MonthlyFee + s.TransportFee + s.OtherCharges;

            return $"--- FEE CHALLAN ---\n" +
          $"Roll No: {s.RollNo}\n" +
          $"Name: {s.Name}\n" +
          $"Class: {s.ClassName}\n\n" +
          $"Issue Date: {dtpIssueDate.Value.ToShortDateString()}\n" +
          $"Due Date: {dtpDueDate.Value.ToShortDateString()}\n\n" +
          $"Monthly Fee: Rs. {s.MonthlyFee}\n" +
          $"Transport Fee: Rs. {s.TransportFee}\n" +
          $"Other Charges: Rs. {s.OtherCharges}\n\n" +
          $"TOTAL PAYABLE: Rs. {total}";


        }
        private string GenerateAttendanceReport(Student s)
        {
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

            var report = $"--- ATTENDANCE REPORT ---\nRoll No: {s.RollNo}\nName: {s.Name}\nClass: {s.ClassName}\nDate Range: {from.ToShortDateString()} - {to.ToShortDateString()}\n\n";

            foreach (var entry in s.AttendanceRecords.Where(a => a.Key >= from && a.Key <= to))
            {
                report += $"{entry.Key.ToShortDateString()}: {entry.Value}\n";
            }

            return report;
        }
        private string GenerateReports(Student student)
        {
            StringBuilder report = new StringBuilder();
            report.AppendLine($"Roll No: {student.RollNo}");
            report.AppendLine($"Name: {student.Name}");
            report.AppendLine($"Class: {student.ClassName}");
            report.AppendLine("Marks:");

            foreach (var subject in student.Marks)
            {
                report.AppendLine($"  {subject.Key}: {subject.Value}");
            }

            int total = student.Marks.Values.Sum();
            double average = student.Marks.Values.Average();
            report.AppendLine($"Total Marks: {total}");
            report.AppendLine($"Average: {average:F2}");

            return report.ToString();
        }
        class Student
        {
            public string RollNo { get; set; }
            public string Name { get; set; }
            public string ClassName { get; set; }

            public Dictionary<string, int> Marks { get; set; } // subject-wise marks

            public Dictionary<DateTime, string> AttendanceRecords { get; set; } // Date → Status

            public decimal MonthlyFee { get; set; }
            public decimal TransportFee { get; set; }
            public decimal OtherCharges { get; set; }
        }
        List<Student> allStudents = new List<Student>();

        private void tabResultCard_Click(object sender, EventArgs e)
        {

        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            SetupDataGridViewColumns();

            AddSelectCheckboxColumn(dgvResults);
            AddSelectCheckboxColumn(dgvAttendanceList);
            AddSelectCheckboxColumn(dataGraidViewFees);

            InitializeStudentData(); // ✅ now the student list has full data

            foreach (var s in allStudents)
            {
                dgvResults.Rows.Add(false, s.RollNo, s.Name, s.ClassName);
            }

            // Load all students into dgvAttendanceList
            foreach (var s in allStudents)
            {
                dgvAttendanceList.Rows.Add(false, s.RollNo, s.Name, s.ClassName);
            }

            // Load all students into dataGraidViewFees
            foreach (var s in allStudents)
            {
                dataGraidViewFees.Rows.Add(false, s.RollNo, s.Name, s.ClassName);
            }

            cmbSearchClass.Items.AddRange(new string[] { "Grade 1", "Grade 2" });
            cmbClassAttendance.Items.AddRange(new string[] { "Grade 1", "Grade 2" });
            cmbFeeClass.Items.AddRange(new string[] { "Grade 1", "Grade 2" });

            dtpIssueDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today.AddDays(10);

            dgvResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendanceList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGraidViewFees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            printDocument1.PrintPage += new PrintPageEventHandler(PrintDocument1_PrintPage);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string roll = txtSearchRollNo.Text.ToLower();
            string name = txtSearchName.Text.ToLower();
            string cls = cmbSearchClass.Text;

            var filtered = allStudents.Where(s =>
                (string.IsNullOrEmpty(roll) || s.RollNo.ToLower().Contains(roll)) &&
                (string.IsNullOrEmpty(name) || s.Name.ToLower().Contains(name)) &&
                (string.IsNullOrEmpty(cls) || s.ClassName == cls)).ToList();

            dgvResults.Rows.Clear();
            foreach (var s in filtered)
            {
                dgvResults.Rows.Add(false,s.RollNo, s.Name, s.ClassName);
            }
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            string roll = dgvResults.Rows[e.RowIndex].Cells["RollNo"].Value.ToString();
            Student selected = allStudents.First(s => s.RollNo == roll);
            rtbResultPreview.Text = GenerateReports(selected);
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            bool anySelected = false;
            StringBuilder combinedReports = new StringBuilder();

            foreach (DataGridViewRow row in dgvResults.Rows)
            {
                if (row.IsNewRow) continue;

                if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    anySelected = true;

                    string roll = row.Cells["RollNo"].Value.ToString();
                    Student selected = allStudents.FirstOrDefault(s => s.RollNo == roll);

                    if (selected != null)
                    {
                        combinedReports.AppendLine(GenerateReports(selected));
                        combinedReports.AppendLine("\n----------------------\n");
                    }
                }
            }

            if (anySelected)
            {
                rtbResultPreview.Text = combinedReports.ToString();
            }
            else
            {
                MessageBox.Show("Please select at least one student to generate result reports.");
            }
        }

        private void btnSearchAttendance_Click(object sender, EventArgs e)
        {
            string roll = txtRollNoAttendance.Text.ToLower();
            string name = txtNameAttendance.Text.ToLower();
            string cls = cmbClassAttendance.Text;

            var filtered = allStudents.Where(s =>
                (string.IsNullOrEmpty(roll) || s.RollNo.ToLower().Contains(roll)) &&
                (string.IsNullOrEmpty(name) || s.Name.ToLower().Contains(name)) &&
                (string.IsNullOrEmpty(cls) || s.ClassName == cls)).ToList();

            dgvAttendanceList.Rows.Clear();
            foreach (var s in filtered)
            {
                dgvAttendanceList.Rows.Add(false,s.RollNo, s.Name, s.ClassName);
            }
        }

        private void dgvAttendanceList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0) return;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvAttendanceList.Rows[e.RowIndex].Cells["RollNo"].Value == null) return;
            string roll = dgvAttendanceList.Rows[e.RowIndex].Cells[0].Value.ToString();
            Student selected = allStudents.First(s => s.RollNo == roll);

            rtbAttendanceReport.Text = GenerateAttendanceReport(selected);
        }

        private void btnGenerateReportAttendance_Click(object sender, EventArgs e)
        {
            bool anySelected = false;
            StringBuilder allReports = new StringBuilder();

            foreach (DataGridViewRow row in dgvAttendanceList.Rows)
            {
                if (row.IsNewRow) continue;

                if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    anySelected = true;

                    string roll = row.Cells["RollNo"].Value.ToString();
                    Student s = allStudents.First(st => st.RollNo == roll);
                    string report = GenerateAttendanceReport(s);

                    allReports.AppendLine(report);
                    allReports.AppendLine("\n------------------------\n");
                }
            }

            if (anySelected)
            {
                rtbAttendanceReport.Text = allReports.ToString(); // Show in UI
                MessageBox.Show("Attendance reports generated for selected students.");
            }
            else
            {
                MessageBox.Show("Please select at least one student to generate attendance report.");
            }
        }

        private void btnFeeSearch_Click(object sender, EventArgs e)
        {
            string roll = txtFeeRollNo.Text.Trim().ToLower();
            string name = txtFeeName.Text.Trim().ToLower();
            string selectedClass = cmbFeeClass.Text;

            var filtered = allStudents.Where(s =>
                (string.IsNullOrEmpty(roll) || s.RollNo.ToLower().Contains(roll)) &&
                (string.IsNullOrEmpty(name) || s.Name.ToLower().Contains(name)) &&
                (string.IsNullOrEmpty(selectedClass) || s.ClassName == selectedClass)
            ).ToList();

            dataGraidViewFees.Rows.Clear();
            foreach (var s in filtered)
            {
                dataGraidViewFees.Rows.Add(false,s.RollNo, s.Name, s.ClassName);
            }
        }

        private void dataGraidViewFees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dataGraidViewFees.Rows[e.RowIndex].Cells["RollNo"].Value == null) return;
            string rollNo = dataGraidViewFees.Rows[e.RowIndex].Cells["RollNo"].Value.ToString();
                Student selected = allStudents.First(s => s.RollNo == rollNo);
                rtbFeeChallan.Text = GenerateChallanText(selected);
            
        }

        private void btnGenerateChallan_Click(object sender, EventArgs e)
        {
            bool anySelected = false;
            StringBuilder combinedChallans = new StringBuilder();

            foreach (DataGridViewRow row in dataGraidViewFees.Rows)
            {
                if (row.IsNewRow) continue;

                if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    anySelected = true;

                    string roll = row.Cells["RollNo"].Value.ToString();
                    Student s = allStudents.First(st => st.RollNo == roll);
                    string challanText = GenerateChallanText(s);

                    combinedChallans.AppendLine(challanText);
                    combinedChallans.AppendLine("\n----------------------\n");
                }
            }

            if (anySelected)
            {
                rtbFeeChallan.Text = combinedChallans.ToString();
            }
            else
            {
                MessageBox.Show("Please select at least one student to generate challan.");
            }
        }

        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            ReGenerateChallanIfNeeded();
        }

        private void btnPrintReports_Click(object sender, EventArgs e)
        {
            reportsToPrint.Clear();
            printIndex = 0;

            if (tabControl1.SelectedTab == tabResultCard)
            {
                foreach (DataGridViewRow row in dgvResults.Rows)
                {
                    if (row.Cells["Select"].Value is bool isSelected && isSelected)
                    {
                        string roll = row.Cells["RollNo"].Value.ToString();
                        Student s = allStudents.FirstOrDefault(st => st.RollNo == roll);
                        if (s != null)
                            reportsToPrint.Add(GenerateReports(s));
                    }
                }
            }
            else if (tabControl1.SelectedTab == tabFeeChallan)
            {
                foreach (DataGridViewRow row in dataGraidViewFees.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                    {
                        string roll = row.Cells["RollNo"].Value.ToString();
                        Student s = allStudents.FirstOrDefault(st => st.RollNo == roll);
                        if (s != null)
                            reportsToPrint.Add(GenerateChallanText(s));
                    }
                }
            }
            else if (tabControl1.SelectedTab == tabAttendanceReport)
            {
                foreach (DataGridViewRow row in dgvAttendanceList.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                    {
                        string roll = row.Cells["RollNo"].Value.ToString();
                        Student s = allStudents.FirstOrDefault(st => st.RollNo == roll);
                        if (s != null)
                            reportsToPrint.Add(GenerateAttendanceReport(s));
                    }
                }
            }

            if (reportsToPrint.Count > 0)
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Please select at least one student to print report.");
            }
        }

        private void btnPrintChallan_Click(object sender, EventArgs e)
        {
            reportsToPrint.Clear();
            printIndex = 0;

            foreach (DataGridViewRow row in dataGraidViewFees.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    string roll = row.Cells["RollNo"].Value.ToString();
                    Student s = allStudents.FirstOrDefault(st => st.RollNo == roll);
                    if (s != null)
                        reportsToPrint.Add(GenerateChallanText(s));
                }
            }

            if (reportsToPrint.Count > 0)
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Please select at least one student to print fee challan.");
            }
        }

        private void btnPrintAttendance_Click(object sender, EventArgs e)
        {
            reportsToPrint.Clear();
            printIndex = 0;

            foreach (DataGridViewRow row in dgvAttendanceList.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    string roll = row.Cells["RollNo"].Value.ToString();
                    Student s = allStudents.FirstOrDefault(st => st.RollNo == roll);
                    if (s != null)
                        reportsToPrint.Add(GenerateAttendanceReport(s));
                }
            }

            if (reportsToPrint.Count > 0)
            {
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Please select at least one student to print attendance report.");
            }
        }
    }
}
