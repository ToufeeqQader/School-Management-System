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
    public partial class StudentAttendanceForm: Form
    {
        public StudentAttendanceForm()
        {
            InitializeComponent();
        }

        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StudentAttendanceForm_Load(object sender, EventArgs e)
        {
            // Dummy summary
            int present = 120;
            int absent = 15;
            int total = present + absent;

            double percentage = total > 0 ? ((double)present / total) * 100 : 0;

            txtPresent.Text = present.ToString();
            txtAbsent.Text = absent.ToString();
            txtPercentage.Text = percentage.ToString("0.00") + " %";

            txtPresent.Text = "120";
            txtAbsent.Text = "15";

            // Optional - date-wise data
            dgvAttendance.ColumnCount = 2;
            dgvAttendance.Columns[0].Name = "Date";
            dgvAttendance.Columns[1].Name = "Status";

            dgvAttendance.Rows.Add("2025-05-01", "Present");
            dgvAttendance.Rows.Add("2025-05-02", "Absent");
            dgvAttendance.Rows.Add("2025-05-03", "Present");
        }
    }
}
