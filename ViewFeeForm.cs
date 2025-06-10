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
    public partial class ViewFeeForm: Form
    {
        public ViewFeeForm()
        {
            InitializeComponent();
        }
        public class FeeRecord
        {
            public string Term { get; set; }
            public DateTime DueDate { get; set; }
            public decimal Amount { get; set; }
            public string PaymentStatus { get; set; }
        }

        private void ViewFeeForm_Load(object sender, EventArgs e)
        {
            // Dummy fee data for demonstration
            List<FeeRecord> feeList = new List<FeeRecord>
    {
        new FeeRecord { Term = "Term 1", DueDate = new DateTime(2025, 3, 15), Amount = 1500.00m, PaymentStatus = "Paid" },
        new FeeRecord { Term = "Term 2", DueDate = new DateTime(2025, 6, 15), Amount = 1500.00m, PaymentStatus = "Unpaid" },
        new FeeRecord { Term = "Term 3", DueDate = new DateTime(2025, 9, 15), Amount = 1500.00m, PaymentStatus = "Unpaid" },
    };

            // Bind list to DataGridView
            dgvFees.DataSource = feeList;

            // Make DataGridView read-only
            dgvFees.ReadOnly = true;
            dgvFees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
