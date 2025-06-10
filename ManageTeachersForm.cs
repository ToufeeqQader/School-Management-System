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
    public partial class ManageTeachersForm: Form
    {
        public ManageTeachersForm()
        {
            InitializeComponent();
        }
        private void ClearFields()
        {
            txtTeacherName.Text = "";
            cmbGender.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
            txtContact.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
            
        }

        private void ManageTeachersForm_Load(object sender, EventArgs e)
        {
            
            cmbGender.Items.AddRange(new string[] { "Male", "Female" });

            dgvTeacher.ColumnCount = 8;
            dgvTeacher.Columns[0].Name = "Name";
            dgvTeacher.Columns[1].Name = "Gender";
            dgvTeacher.Columns[2].Name = "DOB";
            dgvTeacher.Columns[3].Name = "Contact";
            dgvTeacher.Columns[4].Name = "Email";
            dgvTeacher.Columns[5].Name = "Address";
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] row = new string[]
   {
        txtTeacherName.Text,
        cmbGender.Text,
        dtpDOB.Value.ToShortDateString(),
        txtContact.Text,
        txtEmail.Text,
        txtAddress.Text,
        
   };
            dgvTeacher.Rows.Add(row);
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count > 0)
            {
                dgvTeacher.Rows.RemoveAt(dgvTeacher.SelectedRows[0].Index);
                
                ClearFields();
            }
            else
            {
                MessageBox.Show("Select a row to delete.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTeacher.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvTeacher.SelectedRows[0];
                row.Cells[0].Value = txtTeacherName.Text;
                row.Cells[1].Value = cmbGender.Text;
                row.Cells[2].Value = dtpDOB.Value.ToShortDateString();
                row.Cells[3].Value = txtContact.Text;
                row.Cells[4].Value = txtEmail.Text;
                row.Cells[5].Value = txtAddress.Text;
                

                ClearFields();
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchTeacher.Text.ToLower();
            foreach (DataGridViewRow row in dgvTeacher.Rows)
            {
                row.Visible = row.Cells[0].Value != null &&
                              row.Cells[0].Value.ToString().ToLower().Contains(searchName);
            }
        }

        private void dgvTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTeacher.Rows[e.RowIndex];
                txtTeacherName.Text = row.Cells[0].Value?.ToString();
                cmbGender.Text = row.Cells[1].Value?.ToString();
                dtpDOB.Value = DateTime.Parse(row.Cells[2].Value?.ToString() ?? DateTime.Now.ToShortDateString());
                txtContact.Text = row.Cells[3].Value?.ToString();
                txtEmail.Text = row.Cells[4].Value?.ToString();
                txtAddress.Text = row.Cells[5].Value?.ToString();
                
            }
        }
    }
}
