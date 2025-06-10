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
    public partial class StudentInfoForm: Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        

        

        public class StudentProfile
        {
            public string RollNo { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public string DOB { get; set; }
            public string Contact { get; set; }
            public string Address { get; set; }
        }
        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            cmbClass.Items.AddRange(new string[] { "10-A", "9-B" });
            

            // Setup DataGridView columns
            dgvStudents.ColumnCount = 6;
            dgvStudents.Columns[0].Name = "Roll No";
            dgvStudents.Columns[1].Name = "Name";
            dgvStudents.Columns[2].Name = "Gender";
            dgvStudents.Columns[3].Name = "DOB";
            dgvStudents.Columns[4].Name = "Contact";
            dgvStudents.Columns[5].Name = "Address";

            dgvStudents.ReadOnly = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string selectedClass = cmbClass.Text;
            List<StudentProfile> students = new List<StudentProfile>();

            if (selectedClass == "10-A")
            {
                students.Add(new StudentProfile { RollNo = "1", Name = "Ali Khan", Gender = "Male", DOB = "12-Mar-2008", Contact = "03001234567", Address = "Street 1, Lahore" });
                students.Add(new StudentProfile { RollNo = "2", Name = "Sara Naveed", Gender = "Female", DOB = "15-Jun-2008", Contact = "03111234567", Address = "Model Town, Lahore" });
            }
            else if (selectedClass == "9-B")
            {
                students.Add(new StudentProfile { RollNo = "1", Name = "Ahmed Iqbal", Gender = "Male", DOB = "20-Jan-2009", Contact = "03011239876", Address = "Garden Town, Lahore" });
                students.Add(new StudentProfile { RollNo = "2", Name = "Mina Arif", Gender = "Female", DOB = "28-Oct-2009", Contact = "03334321098", Address = "Johar Town, Lahore" });
            }

            dgvStudents.Rows.Clear();
            foreach (var student in students)
            {
                dgvStudents.Rows.Add(student.RollNo, student.Name, student.Gender, student.DOB, student.Contact, student.Address);
            }
        }
    }
}
