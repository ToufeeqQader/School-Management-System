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
    public partial class ManageClassesForm: Form
    {
        public ManageClassesForm()
        {
            InitializeComponent();
        }

        private void ManageClassesForm_Load(object sender, EventArgs e)
        {
            cmbSearchClass.Items.AddRange(new string[] {
        "Grade 1", "Grade 2", "Grade 3", "Grade 10 Science"
    });
            cmbSearchClass.SelectedIndex = -1;
            dgvClass.ColumnCount = 1;
            dgvClass.Columns[0].Name = "Class";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClass.Text))
            {
                MessageBox.Show("Please enter a class name.");
                return;
            }

            dgvClass.Rows.Add(txtClass.Text);
            txtClass.Clear();
        }

        private void btnSearchClass_Click(object sender, EventArgs e)
        {
            string selectedClass = cmbSearchClass.Text.ToLower();

            if (string.IsNullOrEmpty(selectedClass))
            {
                MessageBox.Show("Please select a class to search.");
                return;
            }

            foreach (DataGridViewRow row in dgvClass.Rows)
            {
                if (row.IsNewRow) continue; // Skip the new row line if present

                string classValue = row.Cells[5].Value?.ToString().ToLower(); // Assuming Class is in column 5

                row.Visible = classValue != null && classValue.Contains(selectedClass);
            }
        }
    }
}
