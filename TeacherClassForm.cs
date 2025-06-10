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
    public partial class TeacherClassForm: Form
    {
        public TeacherClassForm()
        {
            InitializeComponent();
        }

        private void TeacherClassForm_Load(object sender, EventArgs e)
        {
            dgvMyClasses.Columns.Clear();

            // Define columns
            dgvMyClasses.Columns.Add("Class", "Class");
            dgvMyClasses.Columns.Add("Subject", "Subject");
            dgvMyClasses.Columns.Add("Section", "Section");
            dgvMyClasses.Columns.Add("TotalStudents", "Total Students");

            // Add View button
            

            // Add dummy data
            dgvMyClasses.Rows.Add("10", "Math", "A", "24");
            dgvMyClasses.Rows.Add("9", "Physics", "B", "28");
            dgvMyClasses.Rows.Add("11", "Biology", "C", "22");

            dgvMyClasses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMyClasses.AllowUserToAddRows = false;
        }

        private void dgvMyClasses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
