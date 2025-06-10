using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace schoolmanagementsystem
{
    public partial class ManageFeeForm: Form
    {
        public ManageFeeForm()
        {
            InitializeComponent();
        }
        
        private void ClearFields()
        {
            txtRollNo.Clear();
            txtStudentName.Clear();
            txtAmount.Clear();
            chkPaid.Checked = false;
            dtpPaidDate.Value = DateTime.Today;
            dtpDueDate.Value = DateTime.Today;
            cmbTerm.SelectedIndex = -1;

        }
        private void UpdateFeeSummary()
        {
            decimal collected = 0;
            decimal pending = 0;

            foreach (DataGridViewRow row in dataGridViewFees.Rows)
            {
                if (row.IsNewRow) continue;

                string amountText = row.Cells[2].Value?.ToString();
                string status = row.Cells[4].Value?.ToString();

                if (decimal.TryParse(amountText, out decimal amount))
                {
                    if (status == "Paid")
                        collected += amount;
                    else
                        pending += amount;
                }
            }
            

            lblCollected.Text = $"Total Collected: PKR {collected:N0}";
            lblPending.Text = $"Total Pending: PKR {pending:N0}";
        }

        private void ManageFeeForm_Load(object sender, EventArgs e)
        {
            // Populate class ComboBox
            cmbClass.Items.AddRange(new string[] { "Grade 1", "Grade 2", "Grade 10 Science" });
            cmbClass.SelectedIndex = -1;

            // ✅ Populate term ComboBox
            cmbTerm.Items.AddRange(new string[] { "Term 1", "Term 2", "Term 3" });
            cmbTerm.SelectedIndex = -1;

            // Set up DataGridView columns
            dataGridViewFees.ColumnCount = 6;
            dataGridViewFees.Columns[0].Name = "Roll No";
            dataGridViewFees.Columns[1].Name = "Student Name";
            dataGridViewFees.Columns[2].Name = "Amount";
            dataGridViewFees.Columns[3].Name = "Due Date";
            dataGridViewFees.Columns[4].Name = "Paid Status";
            dataGridViewFees.Columns[5].Name = "Paid Date";
            dataGridViewFees.Columns.Add("Term", "Term"); // 7th column for Term
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataGridViewFees.Rows.Clear();

            string selectedClass = cmbClass.Text;
            string selectedTerm = cmbTerm.Text;

            if (string.IsNullOrWhiteSpace(selectedClass) || string.IsNullOrWhiteSpace(selectedTerm))
            {
                MessageBox.Show("Please select both class and term.");
                return;
            }

            if (selectedClass == "Grade 1")
            {
                if (selectedTerm == "Term 1")
                {
                    dataGridViewFees.Rows.Add("G1-001", "Ali Khan", "1000", "6/10/2025", "Paid", "6/05/2025", "Term 1");
                    dataGridViewFees.Rows.Add("G1-002", "Sara Ahmed", "1000", "6/10/2025", "Pending", "", "Term 1");
                }
                else if (selectedTerm == "Term 2")
                {
                    dataGridViewFees.Rows.Add("G1-001", "Ali Khan", "1200", "9/10/2025", "Pending", "", "Term 2");
                }
            }
            else if (selectedClass == "Grade 10 Science")
            {
                if (selectedTerm == "Term 1")
                {
                    dataGridViewFees.Rows.Add("G10S-001", "Ahmed Raza", "1500", "6/10/2025", "Paid", "6/06/2025", "Term 1");
                    dataGridViewFees.Rows.Add("G10S-002", "Fatima Noor", "1500", "6/10/2025", "Pending", "", "Term 1");
                }
            }

            UpdateFeeSummary();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRollNo.Text) || string.IsNullOrWhiteSpace(txtStudentName.Text) || string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Please enter Roll No, Student Name, and Amount.");
                return;
            }

            if (cmbTerm.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a term.");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid numeric amount.");
                return;
            }

            string rollNo = txtRollNo.Text.Trim();
            string name = txtStudentName.Text.Trim();
            string dueDate = dtpDueDate.Value.ToShortDateString();
            string paidStatus = chkPaid.Checked ? "Paid" : "Pending";
            string paidDate = chkPaid.Checked ? dtpPaidDate.Value.ToShortDateString() : "";
            string term = cmbTerm.Text;

            bool updated = false;

            foreach (DataGridViewRow row in dataGridViewFees.Rows)
            {
                if (row.IsNewRow) continue;

                string existingRollNo = row.Cells[0].Value?.ToString();
                string existingTerm = row.Cells[6].Value?.ToString();

                if (existingRollNo == rollNo && existingTerm == term)
                {
                    row.Cells[1].Value = name;
                    row.Cells[2].Value = amount.ToString("F0");
                    row.Cells[3].Value = dueDate;
                    row.Cells[4].Value = paidStatus;
                    row.Cells[5].Value = paidDate;
                    updated = true;
                    break;
                }
            }

            if (!updated)
            {
                dataGridViewFees.Rows.Add(rollNo, name, amount.ToString("F0"), dueDate, paidStatus, paidDate, term);
            }

            UpdateFeeSummary();
            ClearFields();
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewFees.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewFees.SelectedRows[0];
                if (selectedRow.IsNewRow)
                {
                    MessageBox.Show("Cannot delete a new/empty row.");
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dataGridViewFees.Rows.RemoveAt(selectedRow.Index);
                    ClearFields();
                    UpdateFeeSummary();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void chkPaid_CheckedChanged(object sender, EventArgs e)
        {
            dtpPaidDate.Enabled = chkPaid.Checked;
        }

        private void dataGridViewFees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewFees.Rows[e.RowIndex];
                txtRollNo.Text = row.Cells[0].Value?.ToString();
                txtStudentName.Text = row.Cells[1].Value?.ToString();
                txtAmount.Text = row.Cells[2].Value?.ToString();
                dtpDueDate.Value = DateTime.Parse(row.Cells[3].Value?.ToString() ?? DateTime.Today.ToShortDateString());
                chkPaid.Checked = row.Cells[4].Value?.ToString() == "Paid";
                dtpPaidDate.Value = string.IsNullOrWhiteSpace(row.Cells[5].Value?.ToString())
                    ? DateTime.Today
                    : DateTime.Parse(row.Cells[5].Value.ToString());
                cmbTerm.Text = row.Cells[6].Value?.ToString();
            }
        }
    }
}
