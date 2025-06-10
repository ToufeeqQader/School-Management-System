namespace schoolmanagementsystem
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabResultCard = new System.Windows.Forms.TabPage();
            this.rtbResultPreview = new System.Windows.Forms.RichTextBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnPrintReports = new System.Windows.Forms.Button();
            this.btnGenerateReports = new System.Windows.Forms.Button();
            this.cmbSearchClass = new System.Windows.Forms.ComboBox();
            this.txtSearchRollNo = new System.Windows.Forms.TextBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.tabFeeChallan = new System.Windows.Forms.TabPage();
            this.rtbFeeChallan = new System.Windows.Forms.RichTextBox();
            this.dataGraidViewFees = new System.Windows.Forms.DataGridView();
            this.btnPrintChallan = new System.Windows.Forms.Button();
            this.btnGenerateChallan = new System.Windows.Forms.Button();
            this.btnFeeSearch = new System.Windows.Forms.Button();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.cmbFeeClass = new System.Windows.Forms.ComboBox();
            this.txtFeeName = new System.Windows.Forms.TextBox();
            this.txtFeeRollNo = new System.Windows.Forms.TextBox();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblFeeClass = new System.Windows.Forms.Label();
            this.lblFeeName = new System.Windows.Forms.Label();
            this.lblFeeRollNo = new System.Windows.Forms.Label();
            this.tabAttendanceReport = new System.Windows.Forms.TabPage();
            this.rtbAttendanceReport = new System.Windows.Forms.RichTextBox();
            this.dgvAttendanceList = new System.Windows.Forms.DataGridView();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.cmbClassAttendance = new System.Windows.Forms.ComboBox();
            this.txtRollNoAttendance = new System.Windows.Forms.TextBox();
            this.txtNameAttendance = new System.Windows.Forms.TextBox();
            this.btnPrintAttendance = new System.Windows.Forms.Button();
            this.btnGenerateReportAttendance = new System.Windows.Forms.Button();
            this.btnSearchAttendance = new System.Windows.Forms.Button();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblClassAttendance = new System.Windows.Forms.Label();
            this.lblRollNoAttendance = new System.Windows.Forms.Label();
            this.lblNameAttendance = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabResultCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.tabFeeChallan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGraidViewFees)).BeginInit();
            this.tabAttendanceReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabResultCard);
            this.tabControl1.Controls.Add(this.tabFeeChallan);
            this.tabControl1.Controls.Add(this.tabAttendanceReport);
            this.tabControl1.Location = new System.Drawing.Point(44, 30);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1009, 561);
            this.tabControl1.TabIndex = 0;
            // 
            // tabResultCard
            // 
            this.tabResultCard.Controls.Add(this.rtbResultPreview);
            this.tabResultCard.Controls.Add(this.dgvResults);
            this.tabResultCard.Controls.Add(this.btnPrintReports);
            this.tabResultCard.Controls.Add(this.btnGenerateReports);
            this.tabResultCard.Controls.Add(this.cmbSearchClass);
            this.tabResultCard.Controls.Add(this.txtSearchRollNo);
            this.tabResultCard.Controls.Add(this.txtSearchName);
            this.tabResultCard.Controls.Add(this.lblClass);
            this.tabResultCard.Controls.Add(this.lblRollNo);
            this.tabResultCard.Controls.Add(this.btnSearch);
            this.tabResultCard.Controls.Add(this.lblSelectStudent);
            this.tabResultCard.Location = new System.Drawing.Point(4, 25);
            this.tabResultCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabResultCard.Name = "tabResultCard";
            this.tabResultCard.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabResultCard.Size = new System.Drawing.Size(1001, 532);
            this.tabResultCard.TabIndex = 0;
            this.tabResultCard.Text = "Result Cards";
            this.tabResultCard.UseVisualStyleBackColor = true;
            this.tabResultCard.Click += new System.EventHandler(this.tabResultCard_Click);
            // 
            // rtbResultPreview
            // 
            this.rtbResultPreview.Location = new System.Drawing.Point(143, 302);
            this.rtbResultPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbResultPreview.Name = "rtbResultPreview";
            this.rtbResultPreview.Size = new System.Drawing.Size(567, 226);
            this.rtbResultPreview.TabIndex = 13;
            this.rtbResultPreview.Text = "";
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(79, 102);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 51;
            this.dgvResults.RowTemplate.Height = 24;
            this.dgvResults.Size = new System.Drawing.Size(728, 135);
            this.dgvResults.TabIndex = 12;
            this.dgvResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellContentClick);
            // 
            // btnPrintReports
            // 
            this.btnPrintReports.BackColor = System.Drawing.Color.Maroon;
            this.btnPrintReports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintReports.Location = new System.Drawing.Point(131, 254);
            this.btnPrintReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintReports.Name = "btnPrintReports";
            this.btnPrintReports.Size = new System.Drawing.Size(143, 41);
            this.btnPrintReports.TabIndex = 11;
            this.btnPrintReports.Text = "Print Reports";
            this.btnPrintReports.UseVisualStyleBackColor = false;
            this.btnPrintReports.Click += new System.EventHandler(this.btnPrintReports_Click);
            // 
            // btnGenerateReports
            // 
            this.btnGenerateReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenerateReports.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateReports.Location = new System.Drawing.Point(552, 254);
            this.btnGenerateReports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReports.Name = "btnGenerateReports";
            this.btnGenerateReports.Size = new System.Drawing.Size(189, 41);
            this.btnGenerateReports.TabIndex = 10;
            this.btnGenerateReports.Text = "Generate Reports";
            this.btnGenerateReports.UseVisualStyleBackColor = false;
            this.btnGenerateReports.Click += new System.EventHandler(this.btnGenerateReports_Click);
            // 
            // cmbSearchClass
            // 
            this.cmbSearchClass.FormattingEnabled = true;
            this.cmbSearchClass.Location = new System.Drawing.Point(419, 60);
            this.cmbSearchClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbSearchClass.Name = "cmbSearchClass";
            this.cmbSearchClass.Size = new System.Drawing.Size(121, 24);
            this.cmbSearchClass.TabIndex = 9;
            // 
            // txtSearchRollNo
            // 
            this.txtSearchRollNo.Location = new System.Drawing.Point(269, 60);
            this.txtSearchRollNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchRollNo.Name = "txtSearchRollNo";
            this.txtSearchRollNo.Size = new System.Drawing.Size(100, 22);
            this.txtSearchRollNo.TabIndex = 8;
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(108, 62);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(100, 22);
            this.txtSearchName.TabIndex = 7;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(424, 21);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(52, 20);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "Class";
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollNo.Location = new System.Drawing.Point(275, 21);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(64, 20);
            this.lblRollNo.TabIndex = 5;
            this.lblRollNo.Text = "Roll No";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(676, 47);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(113, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.AutoSize = true;
            this.lblSelectStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectStudent.Location = new System.Drawing.Point(104, 25);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(66, 20);
            this.lblSelectStudent.TabIndex = 0;
            this.lblSelectStudent.Text = "Student";
            // 
            // tabFeeChallan
            // 
            this.tabFeeChallan.Controls.Add(this.rtbFeeChallan);
            this.tabFeeChallan.Controls.Add(this.dataGraidViewFees);
            this.tabFeeChallan.Controls.Add(this.btnPrintChallan);
            this.tabFeeChallan.Controls.Add(this.btnGenerateChallan);
            this.tabFeeChallan.Controls.Add(this.btnFeeSearch);
            this.tabFeeChallan.Controls.Add(this.dtpDueDate);
            this.tabFeeChallan.Controls.Add(this.dtpIssueDate);
            this.tabFeeChallan.Controls.Add(this.cmbFeeClass);
            this.tabFeeChallan.Controls.Add(this.txtFeeName);
            this.tabFeeChallan.Controls.Add(this.txtFeeRollNo);
            this.tabFeeChallan.Controls.Add(this.lblDueDate);
            this.tabFeeChallan.Controls.Add(this.lblIssueDate);
            this.tabFeeChallan.Controls.Add(this.lblFeeClass);
            this.tabFeeChallan.Controls.Add(this.lblFeeName);
            this.tabFeeChallan.Controls.Add(this.lblFeeRollNo);
            this.tabFeeChallan.Location = new System.Drawing.Point(4, 25);
            this.tabFeeChallan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFeeChallan.Name = "tabFeeChallan";
            this.tabFeeChallan.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabFeeChallan.Size = new System.Drawing.Size(1001, 532);
            this.tabFeeChallan.TabIndex = 1;
            this.tabFeeChallan.Text = "Fee Challan";
            this.tabFeeChallan.UseVisualStyleBackColor = true;
            // 
            // rtbFeeChallan
            // 
            this.rtbFeeChallan.Location = new System.Drawing.Point(628, 126);
            this.rtbFeeChallan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbFeeChallan.Name = "rtbFeeChallan";
            this.rtbFeeChallan.Size = new System.Drawing.Size(355, 389);
            this.rtbFeeChallan.TabIndex = 14;
            this.rtbFeeChallan.Text = "";
            this.rtbFeeChallan.TextChanged += new System.EventHandler(this.rtbFeeChallan_TextChanged);
            // 
            // dataGraidViewFees
            // 
            this.dataGraidViewFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGraidViewFees.Location = new System.Drawing.Point(184, 126);
            this.dataGraidViewFees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGraidViewFees.Name = "dataGraidViewFees";
            this.dataGraidViewFees.RowHeadersWidth = 51;
            this.dataGraidViewFees.RowTemplate.Height = 24;
            this.dataGraidViewFees.Size = new System.Drawing.Size(421, 389);
            this.dataGraidViewFees.TabIndex = 13;
            this.dataGraidViewFees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGraidViewFees_CellContentClick);
            // 
            // btnPrintChallan
            // 
            this.btnPrintChallan.BackColor = System.Drawing.Color.Maroon;
            this.btnPrintChallan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintChallan.Location = new System.Drawing.Point(24, 290);
            this.btnPrintChallan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintChallan.Name = "btnPrintChallan";
            this.btnPrintChallan.Size = new System.Drawing.Size(137, 47);
            this.btnPrintChallan.TabIndex = 12;
            this.btnPrintChallan.Text = "Print Challan";
            this.btnPrintChallan.UseVisualStyleBackColor = false;
            this.btnPrintChallan.Click += new System.EventHandler(this.btnPrintChallan_Click);
            // 
            // btnGenerateChallan
            // 
            this.btnGenerateChallan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenerateChallan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateChallan.Location = new System.Drawing.Point(24, 203);
            this.btnGenerateChallan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateChallan.Name = "btnGenerateChallan";
            this.btnGenerateChallan.Size = new System.Drawing.Size(137, 53);
            this.btnGenerateChallan.TabIndex = 11;
            this.btnGenerateChallan.Text = "Generate Challan";
            this.btnGenerateChallan.UseVisualStyleBackColor = false;
            this.btnGenerateChallan.Click += new System.EventHandler(this.btnGenerateChallan_Click);
            // 
            // btnFeeSearch
            // 
            this.btnFeeSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFeeSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFeeSearch.Location = new System.Drawing.Point(43, 144);
            this.btnFeeSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeeSearch.Name = "btnFeeSearch";
            this.btnFeeSearch.Size = new System.Drawing.Size(97, 34);
            this.btnFeeSearch.TabIndex = 10;
            this.btnFeeSearch.Text = "Search";
            this.btnFeeSearch.UseVisualStyleBackColor = false;
            this.btnFeeSearch.Click += new System.EventHandler(this.btnFeeSearch_Click);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Location = new System.Drawing.Point(731, 69);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(240, 22);
            this.dtpDueDate.TabIndex = 9;
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Location = new System.Drawing.Point(453, 69);
            this.dtpIssueDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(244, 22);
            this.dtpIssueDate.TabIndex = 8;
            this.dtpIssueDate.ValueChanged += new System.EventHandler(this.dtpIssueDate_ValueChanged);
            // 
            // cmbFeeClass
            // 
            this.cmbFeeClass.FormattingEnabled = true;
            this.cmbFeeClass.Location = new System.Drawing.Point(288, 66);
            this.cmbFeeClass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFeeClass.Name = "cmbFeeClass";
            this.cmbFeeClass.Size = new System.Drawing.Size(121, 24);
            this.cmbFeeClass.TabIndex = 7;
            // 
            // txtFeeName
            // 
            this.txtFeeName.Location = new System.Drawing.Point(157, 66);
            this.txtFeeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFeeName.Name = "txtFeeName";
            this.txtFeeName.Size = new System.Drawing.Size(100, 22);
            this.txtFeeName.TabIndex = 6;
            // 
            // txtFeeRollNo
            // 
            this.txtFeeRollNo.Location = new System.Drawing.Point(24, 66);
            this.txtFeeRollNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFeeRollNo.Name = "txtFeeRollNo";
            this.txtFeeRollNo.Size = new System.Drawing.Size(100, 22);
            this.txtFeeRollNo.TabIndex = 5;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(728, 33);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(64, 16);
            this.lblDueDate.TabIndex = 4;
            this.lblDueDate.Text = "Due Date";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(451, 33);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(68, 16);
            this.lblIssueDate.TabIndex = 3;
            this.lblIssueDate.Text = "IssueDate";
            // 
            // lblFeeClass
            // 
            this.lblFeeClass.AutoSize = true;
            this.lblFeeClass.Location = new System.Drawing.Point(285, 33);
            this.lblFeeClass.Name = "lblFeeClass";
            this.lblFeeClass.Size = new System.Drawing.Size(41, 16);
            this.lblFeeClass.TabIndex = 2;
            this.lblFeeClass.Text = "Class";
            // 
            // lblFeeName
            // 
            this.lblFeeName.AutoSize = true;
            this.lblFeeName.Location = new System.Drawing.Point(155, 33);
            this.lblFeeName.Name = "lblFeeName";
            this.lblFeeName.Size = new System.Drawing.Size(92, 16);
            this.lblFeeName.TabIndex = 1;
            this.lblFeeName.Text = "Student Name";
            // 
            // lblFeeRollNo
            // 
            this.lblFeeRollNo.AutoSize = true;
            this.lblFeeRollNo.Location = new System.Drawing.Point(21, 33);
            this.lblFeeRollNo.Name = "lblFeeRollNo";
            this.lblFeeRollNo.Size = new System.Drawing.Size(49, 16);
            this.lblFeeRollNo.TabIndex = 0;
            this.lblFeeRollNo.Text = "RollNo";
            // 
            // tabAttendanceReport
            // 
            this.tabAttendanceReport.Controls.Add(this.rtbAttendanceReport);
            this.tabAttendanceReport.Controls.Add(this.dgvAttendanceList);
            this.tabAttendanceReport.Controls.Add(this.dtpTo);
            this.tabAttendanceReport.Controls.Add(this.dtpFrom);
            this.tabAttendanceReport.Controls.Add(this.cmbClassAttendance);
            this.tabAttendanceReport.Controls.Add(this.txtRollNoAttendance);
            this.tabAttendanceReport.Controls.Add(this.txtNameAttendance);
            this.tabAttendanceReport.Controls.Add(this.btnPrintAttendance);
            this.tabAttendanceReport.Controls.Add(this.btnGenerateReportAttendance);
            this.tabAttendanceReport.Controls.Add(this.btnSearchAttendance);
            this.tabAttendanceReport.Controls.Add(this.lblToDate);
            this.tabAttendanceReport.Controls.Add(this.lblFromDate);
            this.tabAttendanceReport.Controls.Add(this.lblClassAttendance);
            this.tabAttendanceReport.Controls.Add(this.lblRollNoAttendance);
            this.tabAttendanceReport.Controls.Add(this.lblNameAttendance);
            this.tabAttendanceReport.Location = new System.Drawing.Point(4, 25);
            this.tabAttendanceReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAttendanceReport.Name = "tabAttendanceReport";
            this.tabAttendanceReport.Size = new System.Drawing.Size(1001, 532);
            this.tabAttendanceReport.TabIndex = 2;
            this.tabAttendanceReport.Text = "Attendance Report";
            this.tabAttendanceReport.UseVisualStyleBackColor = true;
            // 
            // rtbAttendanceReport
            // 
            this.rtbAttendanceReport.Location = new System.Drawing.Point(669, 197);
            this.rtbAttendanceReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbAttendanceReport.Name = "rtbAttendanceReport";
            this.rtbAttendanceReport.Size = new System.Drawing.Size(319, 306);
            this.rtbAttendanceReport.TabIndex = 14;
            this.rtbAttendanceReport.Text = "";
            // 
            // dgvAttendanceList
            // 
            this.dgvAttendanceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendanceList.Location = new System.Drawing.Point(211, 197);
            this.dgvAttendanceList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAttendanceList.Name = "dgvAttendanceList";
            this.dgvAttendanceList.RowHeadersWidth = 51;
            this.dgvAttendanceList.RowTemplate.Height = 24;
            this.dgvAttendanceList.Size = new System.Drawing.Size(429, 306);
            this.dgvAttendanceList.TabIndex = 13;
            this.dgvAttendanceList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendanceList_CellContentClick);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(727, 105);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(243, 22);
            this.dtpTo.TabIndex = 12;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(451, 107);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(241, 22);
            this.dtpFrom.TabIndex = 11;
            // 
            // cmbClassAttendance
            // 
            this.cmbClassAttendance.FormattingEnabled = true;
            this.cmbClassAttendance.Location = new System.Drawing.Point(293, 105);
            this.cmbClassAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbClassAttendance.Name = "cmbClassAttendance";
            this.cmbClassAttendance.Size = new System.Drawing.Size(121, 24);
            this.cmbClassAttendance.TabIndex = 10;
            // 
            // txtRollNoAttendance
            // 
            this.txtRollNoAttendance.Location = new System.Drawing.Point(160, 105);
            this.txtRollNoAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRollNoAttendance.Name = "txtRollNoAttendance";
            this.txtRollNoAttendance.Size = new System.Drawing.Size(100, 22);
            this.txtRollNoAttendance.TabIndex = 9;
            // 
            // txtNameAttendance
            // 
            this.txtNameAttendance.Location = new System.Drawing.Point(24, 105);
            this.txtNameAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNameAttendance.Name = "txtNameAttendance";
            this.txtNameAttendance.Size = new System.Drawing.Size(100, 22);
            this.txtNameAttendance.TabIndex = 8;
            // 
            // btnPrintAttendance
            // 
            this.btnPrintAttendance.BackColor = System.Drawing.Color.Maroon;
            this.btnPrintAttendance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintAttendance.Location = new System.Drawing.Point(24, 353);
            this.btnPrintAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrintAttendance.Name = "btnPrintAttendance";
            this.btnPrintAttendance.Size = new System.Drawing.Size(131, 54);
            this.btnPrintAttendance.TabIndex = 7;
            this.btnPrintAttendance.Text = "Print Report";
            this.btnPrintAttendance.UseVisualStyleBackColor = false;
            this.btnPrintAttendance.Click += new System.EventHandler(this.btnPrintAttendance_Click);
            // 
            // btnGenerateReportAttendance
            // 
            this.btnGenerateReportAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGenerateReportAttendance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateReportAttendance.Location = new System.Drawing.Point(24, 272);
            this.btnGenerateReportAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGenerateReportAttendance.Name = "btnGenerateReportAttendance";
            this.btnGenerateReportAttendance.Size = new System.Drawing.Size(131, 50);
            this.btnGenerateReportAttendance.TabIndex = 6;
            this.btnGenerateReportAttendance.Text = "Generate Report";
            this.btnGenerateReportAttendance.UseVisualStyleBackColor = false;
            this.btnGenerateReportAttendance.Click += new System.EventHandler(this.btnGenerateReportAttendance_Click);
            // 
            // btnSearchAttendance
            // 
            this.btnSearchAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchAttendance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchAttendance.Location = new System.Drawing.Point(37, 197);
            this.btnSearchAttendance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchAttendance.Name = "btnSearchAttendance";
            this.btnSearchAttendance.Size = new System.Drawing.Size(75, 34);
            this.btnSearchAttendance.TabIndex = 5;
            this.btnSearchAttendance.Text = "Search";
            this.btnSearchAttendance.UseVisualStyleBackColor = false;
            this.btnSearchAttendance.Click += new System.EventHandler(this.btnSearchAttendance_Click);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(733, 66);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(56, 16);
            this.lblToDate.TabIndex = 4;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(447, 66);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(70, 16);
            this.lblFromDate.TabIndex = 3;
            this.lblFromDate.Text = "From Date";
            // 
            // lblClassAttendance
            // 
            this.lblClassAttendance.AutoSize = true;
            this.lblClassAttendance.Location = new System.Drawing.Point(291, 66);
            this.lblClassAttendance.Name = "lblClassAttendance";
            this.lblClassAttendance.Size = new System.Drawing.Size(41, 16);
            this.lblClassAttendance.TabIndex = 2;
            this.lblClassAttendance.Text = "Class";
            // 
            // lblRollNoAttendance
            // 
            this.lblRollNoAttendance.AutoSize = true;
            this.lblRollNoAttendance.Location = new System.Drawing.Point(157, 66);
            this.lblRollNoAttendance.Name = "lblRollNoAttendance";
            this.lblRollNoAttendance.Size = new System.Drawing.Size(49, 16);
            this.lblRollNoAttendance.TabIndex = 1;
            this.lblRollNoAttendance.Text = "RollNo";
            // 
            // lblNameAttendance
            // 
            this.lblNameAttendance.AutoSize = true;
            this.lblNameAttendance.Location = new System.Drawing.Point(21, 66);
            this.lblNameAttendance.Name = "lblNameAttendance";
            this.lblNameAttendance.Size = new System.Drawing.Size(92, 16);
            this.lblNameAttendance.TabIndex = 0;
            this.lblNameAttendance.Text = "Student Name";
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 599);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabResultCard.ResumeLayout(false);
            this.tabResultCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.tabFeeChallan.ResumeLayout(false);
            this.tabFeeChallan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGraidViewFees)).EndInit();
            this.tabAttendanceReport.ResumeLayout(false);
            this.tabAttendanceReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendanceList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabResultCard;
        private System.Windows.Forms.TabPage tabFeeChallan;
        private System.Windows.Forms.TabPage tabAttendanceReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSelectStudent;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.Button btnPrintReports;
        private System.Windows.Forms.Button btnGenerateReports;
        private System.Windows.Forms.ComboBox cmbSearchClass;
        private System.Windows.Forms.TextBox txtSearchRollNo;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.RichTextBox rtbResultPreview;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblClassAttendance;
        private System.Windows.Forms.Label lblRollNoAttendance;
        private System.Windows.Forms.Label lblNameAttendance;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.ComboBox cmbClassAttendance;
        private System.Windows.Forms.TextBox txtRollNoAttendance;
        private System.Windows.Forms.TextBox txtNameAttendance;
        private System.Windows.Forms.Button btnPrintAttendance;
        private System.Windows.Forms.Button btnGenerateReportAttendance;
        private System.Windows.Forms.Button btnSearchAttendance;
        private System.Windows.Forms.RichTextBox rtbAttendanceReport;
        private System.Windows.Forms.DataGridView dgvAttendanceList;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblFeeClass;
        private System.Windows.Forms.Label lblFeeName;
        private System.Windows.Forms.Label lblFeeRollNo;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.ComboBox cmbFeeClass;
        private System.Windows.Forms.TextBox txtFeeName;
        private System.Windows.Forms.TextBox txtFeeRollNo;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DataGridView dataGraidViewFees;
        private System.Windows.Forms.Button btnPrintChallan;
        private System.Windows.Forms.Button btnGenerateChallan;
        private System.Windows.Forms.Button btnFeeSearch;
        private System.Windows.Forms.RichTextBox rtbFeeChallan;
    }
}