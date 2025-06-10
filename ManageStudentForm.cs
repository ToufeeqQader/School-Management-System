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
    
    public partial class ManageStudentForm: Form
    {
        List<Student> students = new List<Student>();
        public ManageStudentForm()
        {
            InitializeComponent();
            LoadDummyData();
            BindGrid();
            PopulateGender();
            PopulateClass();

        }
        private void LoadDummyData()
        {
            students.Add(new Student { RollNo = "R001", Name = "Ayesha", DOB = new DateTime(2010, 5, 1), Gender = "Female", Class = "Grade 1", Contact = "1234567890", Address = "Lahore" });
            students.Add(new Student { RollNo = "R002", Name = "Ali", DOB = new DateTime(2009, 9, 20), Gender = "Male", Class = "Grade 2", Contact = "9876543210", Address = "Karachi" });
        }

        private void BindGrid()
        {
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = students;
        }

        private void PopulateGender()
        {
            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");
            cmbGender.Items.Add("Other");
        }

        private void PopulateClass()
        {
            cmbClass.Items.Add("Grade 1");
            cmbClass.Items.Add("Grade 2");
            cmbClass.Items.Add("Grade 3");
            cmbClass.Items.Add("Grade 4");
            cmbClass.Items.Add("Grade 5");
            cmbClass.Items.Add("Grade 6");
            cmbClass.Items.Add("Grade 7");
            cmbClass.Items.Add("Grade 8");
            cmbClass.Items.Add("Grade 9");
            cmbClass.Items.Add("Grade 10");
            cmbSearchClass.Items.Add("Grade 1");
            cmbSearchClass.Items.Add("Grade 2");
            cmbSearchClass.Items.Add("Grade 3");
            cmbSearchClass.Items.Add("Grade 4");
            cmbSearchClass.Items.Add("Grade 5");
            cmbSearchClass.Items.Add("Grade 6");
            cmbSearchClass.Items.Add("Grade 7");
            cmbSearchClass.Items.Add("Grade 8");
            cmbSearchClass.Items.Add("Grade 9");
            cmbSearchClass.Items.Add("Grade 10");
        }
        private void ClearFields()
        {
            txtStudentName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
            cmbGender.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Today;
        }
        public class Student
        {
            public string RollNo { get; set; }
            public string Name { get; set; }
            public DateTime DOB { get; set; }
            public string Gender { get; set; }
            public string Class { get; set; }
            public string Contact { get; set; }
            public string Address { get; set; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student s = new Student
            {
                RollNo = txtRollnumber.Text.Trim(),
                Name = txtStudentName.Text,
                DOB = dtpDOB.Value,
                Gender = cmbGender.Text,
                Class = cmbClass.Text,
                Contact = txtContact.Text,
                Address = txtAddress.Text
            };
            students.Add(s);
            BindGrid();
            ClearFields();
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtRollnumber.Text = row.Cells["RollNumber"].Value.ToString();
                txtStudentName.Text = row.Cells["Name"].Value.ToString();
                dtpDOB.Value = Convert.ToDateTime(row.Cells["DOB"].Value);
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                cmbClass.Text = row.Cells["Class"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int index = dgvStudents.SelectedRows[0].Index;
                students.RemoveAt(index);
                BindGrid();
                ClearFields();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.SelectedRows.Count > 0)
            {
                int index = dgvStudents.SelectedRows[0].Index;
                
                students[index].Name = txtStudentName.Text;
                students[index].RollNo = txtRollnumber.Text;
                students[index].DOB = dtpDOB.Value;
                students[index].Gender = cmbGender.Text;
                students[index].Class = cmbClass.Text;
                students[index].Contact = txtContact.Text;
                students[index].Address = txtAddress.Text;

                BindGrid();
                ClearFields();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            PopulateClass();
            string nameTerm = txtSearchName.Text.Trim().ToLower();
            string rollTerm = txtSearchRollNo.Text.Trim().ToLower();
            string selectedClass = cmbSearchClass.Text.Trim().ToLower();

            var filtered = students.Where(s =>
                (string.IsNullOrEmpty(nameTerm) || s.Name.ToLower().Contains(nameTerm)) &&
                (string.IsNullOrEmpty(rollTerm) || s.RollNo.ToLower().Contains(rollTerm)) &&
                (string.IsNullOrEmpty(selectedClass) || s.Class.ToLower() == selectedClass)
            ).ToList();

            dgvStudents.DataSource = null;
            dgvStudents.DataSource = filtered;
        }
    }
}
