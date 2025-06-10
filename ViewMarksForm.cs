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
    public partial class ViewMarksForm: Form
    {
        public ViewMarksForm()
        {
            InitializeComponent();
        }

        private void ViewMarksForm_Load(object sender, EventArgs e)
        {
            cmbExamType.Items.Add("Midterm");
            cmbExamType.Items.Add("Final");
            cmbExamType.SelectedIndex = 0; // default selection

            // Configure DataGridView columns (if not set in designer)
            dgvMarks.ColumnCount = 3;
            dgvMarks.Columns[0].Name = "Subject";
            dgvMarks.Columns[1].Name = "Obtained Marks";
            dgvMarks.Columns[2].Name = "Total Marks";

            dgvMarks.Rows.Clear();

        }

        private void CalculateResults()
        {
            int totalGained = 0;
            int totalMarks = 0;

            foreach (DataGridViewRow row in dgvMarks.Rows)
            {
                if (row.Cells["Gained"].Value != null && row.Cells["Total"].Value != null)
                {
                    int gained = int.Parse(row.Cells["Gained"].Value.ToString());
                    int total = int.Parse(row.Cells["Total"].Value.ToString());
                    totalGained += gained;
                    totalMarks += total;
                }
            }

            txtObtainedMarks.Text = totalGained.ToString();
            txtTotalMarks.Text = totalMarks.ToString();

            double percentage = totalMarks > 0 ? (double)totalGained / totalMarks * 100 : 0;
            txtPercentage.Text = percentage.ToString("0.00") + " %";
        }

        private void dgvMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadMarks_Click(object sender, EventArgs e)
        {
            if (cmbExamType.SelectedItem == null)
            {
                MessageBox.Show("Please select an exam type.");
                return;
            }

            string selectedExam = cmbExamType.SelectedItem.ToString();

            // Example data (replace with database fetch in real-world)
            List<(string Subject, int Obtained, int Total)> marksData = new List<(string, int, int)>();

            if (selectedExam == "Midterm")
            {
                marksData = new List<(string, int, int)>
        {
            ("Math", 18, 25),
            ("Science", 20, 25),
            ("English", 22, 25)
        };
            }
            else if (selectedExam == "Final")
            {
                marksData = new List<(string, int, int)>
        {
            ("Math", 45, 50),
            ("Science", 48, 50),
            ("English", 44, 50)
        };
            }

            // Clear existing data
            dgvMarks.Rows.Clear();

            int totalObtained = 0;
            int totalMarks = 0;

            foreach (var mark in marksData)
            {
                dgvMarks.Rows.Add(mark.Subject, mark.Obtained, mark.Total);
                totalObtained += mark.Obtained;
                totalMarks += mark.Total;
            }

            // Set result in text boxes
            txtObtainedMarks.Text = totalObtained.ToString();
            txtTotalMarks.Text = totalMarks.ToString();
            txtPercentage.Text = ((double)totalObtained / totalMarks * 100).ToString("F2") + " %";
        }

        private void cmbSelectExamType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
