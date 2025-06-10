namespace schoolmanagementsystem
{
    partial class StudentDashboard
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlStudent = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewMarks = new System.Windows.Forms.Button();
            this.btnViewFee = new System.Windows.Forms.Button();
            this.btnViewAttendance = new System.Windows.Forms.Button();
            this.grpStudentDetails = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.txtRollNo = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblParentName = new System.Windows.Forms.Label();
            this.lblRollNo = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlStudent.SuspendLayout();
            this.grpStudentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(301, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome";
            // 
            // pnlStudent
            // 
            this.pnlStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlStudent.Controls.Add(this.btnLogout);
            this.pnlStudent.Controls.Add(this.btnViewMarks);
            this.pnlStudent.Controls.Add(this.btnViewFee);
            this.pnlStudent.Controls.Add(this.btnViewAttendance);
            this.pnlStudent.Location = new System.Drawing.Point(-3, 0);
            this.pnlStudent.Name = "pnlStudent";
            this.pnlStudent.Size = new System.Drawing.Size(208, 568);
            this.pnlStudent.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(31, 438);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(132, 33);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewMarks
            // 
            this.btnViewMarks.Location = new System.Drawing.Point(31, 337);
            this.btnViewMarks.Name = "btnViewMarks";
            this.btnViewMarks.Size = new System.Drawing.Size(132, 36);
            this.btnViewMarks.TabIndex = 2;
            this.btnViewMarks.Text = "View Marks";
            this.btnViewMarks.UseVisualStyleBackColor = true;
            this.btnViewMarks.Click += new System.EventHandler(this.btnViewMarks_Click);
            // 
            // btnViewFee
            // 
            this.btnViewFee.Location = new System.Drawing.Point(31, 225);
            this.btnViewFee.Name = "btnViewFee";
            this.btnViewFee.Size = new System.Drawing.Size(132, 37);
            this.btnViewFee.TabIndex = 1;
            this.btnViewFee.Text = "View Fee";
            this.btnViewFee.UseVisualStyleBackColor = true;
            this.btnViewFee.Click += new System.EventHandler(this.btnViewFee_Click);
            // 
            // btnViewAttendance
            // 
            this.btnViewAttendance.Location = new System.Drawing.Point(31, 118);
            this.btnViewAttendance.Name = "btnViewAttendance";
            this.btnViewAttendance.Size = new System.Drawing.Size(132, 37);
            this.btnViewAttendance.TabIndex = 0;
            this.btnViewAttendance.Text = "View Attendance";
            this.btnViewAttendance.UseVisualStyleBackColor = true;
            this.btnViewAttendance.Click += new System.EventHandler(this.btnViewAttendance_Click);
            // 
            // grpStudentDetails
            // 
            this.grpStudentDetails.Controls.Add(this.txtAddress);
            this.grpStudentDetails.Controls.Add(this.txtContact);
            this.grpStudentDetails.Controls.Add(this.txtDOB);
            this.grpStudentDetails.Controls.Add(this.txtGender);
            this.grpStudentDetails.Controls.Add(this.txtParentName);
            this.grpStudentDetails.Controls.Add(this.txtRollNo);
            this.grpStudentDetails.Controls.Add(this.txtClass);
            this.grpStudentDetails.Controls.Add(this.txtName);
            this.grpStudentDetails.Controls.Add(this.lblAddress);
            this.grpStudentDetails.Controls.Add(this.lblContact);
            this.grpStudentDetails.Controls.Add(this.lblDOB);
            this.grpStudentDetails.Controls.Add(this.lblGender);
            this.grpStudentDetails.Controls.Add(this.lblParentName);
            this.grpStudentDetails.Controls.Add(this.lblRollNo);
            this.grpStudentDetails.Controls.Add(this.lblClass);
            this.grpStudentDetails.Controls.Add(this.lblName);
            this.grpStudentDetails.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudentDetails.Location = new System.Drawing.Point(211, 106);
            this.grpStudentDetails.Name = "grpStudentDetails";
            this.grpStudentDetails.Size = new System.Drawing.Size(645, 410);
            this.grpStudentDetails.TabIndex = 2;
            this.grpStudentDetails.TabStop = false;
            this.grpStudentDetails.Text = "Student Details";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(276, 342);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(304, 47);
            this.txtAddress.TabIndex = 15;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(34, 342);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(177, 30);
            this.txtContact.TabIndex = 14;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(484, 222);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(131, 30);
            this.txtDOB.TabIndex = 13;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(261, 222);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(121, 30);
            this.txtGender.TabIndex = 12;
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(38, 222);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(173, 30);
            this.txtParentName.TabIndex = 11;
            // 
            // txtRollNo
            // 
            this.txtRollNo.Location = new System.Drawing.Point(480, 114);
            this.txtRollNo.Name = "txtRollNo";
            this.txtRollNo.Size = new System.Drawing.Size(135, 30);
            this.txtRollNo.TabIndex = 10;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(261, 114);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(121, 30);
            this.txtClass.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(34, 107);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 30);
            this.txtName.TabIndex = 8;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(272, 302);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 23);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Address";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(38, 302);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(105, 23);
            this.lblContact.TabIndex = 6;
            this.lblContact.Text = "Contact Info";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(480, 179);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(110, 23);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(272, 173);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(66, 23);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender";
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParentName.Location = new System.Drawing.Point(34, 167);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(110, 23);
            this.lblParentName.TabIndex = 3;
            this.lblParentName.Text = "Parent Name";
            // 
            // lblRollNo
            // 
            this.lblRollNo.AutoSize = true;
            this.lblRollNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRollNo.Location = new System.Drawing.Point(476, 59);
            this.lblRollNo.Name = "lblRollNo";
            this.lblRollNo.Size = new System.Drawing.Size(66, 23);
            this.lblRollNo.TabIndex = 2;
            this.lblRollNo.Text = "Roll No";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(268, 53);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(48, 23);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Class";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(30, 53);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(56, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 568);
            this.Controls.Add(this.grpStudentDetails);
            this.Controls.Add(this.pnlStudent);
            this.Controls.Add(this.lblTitle);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            this.pnlStudent.ResumeLayout(false);
            this.grpStudentDetails.ResumeLayout(false);
            this.grpStudentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlStudent;
        private System.Windows.Forms.Button btnViewFee;
        private System.Windows.Forms.Button btnViewAttendance;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewMarks;
        private System.Windows.Forms.GroupBox grpStudentDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.Label lblRollNo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.TextBox txtRollNo;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
    }
}