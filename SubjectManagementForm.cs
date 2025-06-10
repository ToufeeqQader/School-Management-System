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
    public partial class SubjectManagementForm: Form
    {
        public SubjectManagementForm()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txtSubject.Clear();
            cmbAssignClass.SelectedIndex = -1;
            cmbAssignTeacher.SelectedIndex = -1;

        }

        private void SubjectManagementForm_Load(object sender, EventArgs e)
        {
            cmbAssignClass.Items.AddRange(new string[]
          {
                "Grade 1", "Grade 2", "Grade 3", "Grade 10 Science"
          });

            cmbAssignTeacher.Items.AddRange(new string[]
            {
                "Mr. Ali", "Ms. Fatima", "Mr. Rehman", "Ms. Sara"
            });

            cmbAssignClass.SelectedIndex = -1;
            cmbAssignTeacher.SelectedIndex = -1;



            dgvSubjects.ColumnCount = 3;
            dgvSubjects.Columns[0].Name = "Subject Name";
            dgvSubjects.Columns[1].Name = "Class";
            dgvSubjects.Columns[2].Name = "Teacher";
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubject.Text) ||
               cmbAssignClass.SelectedIndex == -1 ||
               cmbAssignTeacher.SelectedIndex == -1)

            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            dgvSubjects.Rows.Add(
                txtSubject.Text,
                cmbAssignClass.Text,
                cmbAssignTeacher.Text

            );

            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSubjects.SelectedRows[0];
                row.Cells[0].Value = txtSubject.Text;
                row.Cells[1].Value = cmbAssignClass.Text;
                row.Cells[2].Value = cmbAssignTeacher.Text;


                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count > 0)
            {
                dgvSubjects.Rows.RemoveAt(dgvSubjects.SelectedRows[0].Index);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSubject.Text.ToLower();
            foreach (DataGridViewRow row in dgvSubjects.Rows)
            {
                row.Visible = row.Cells[0].Value != null &&
                              row.Cells[0].Value.ToString().ToLower().Contains(searchText);
            }
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSubjects.Rows[e.RowIndex];
                txtSubject.Text = row.Cells[0].Value.ToString();
                cmbAssignClass.Text = row.Cells[1].Value.ToString();
                cmbAssignTeacher.Text = row.Cells[2].Value.ToString();

            }
        }
    }
}
