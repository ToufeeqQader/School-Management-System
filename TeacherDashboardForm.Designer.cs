namespace schoolmanagementsystem
{
    partial class TeacherDashboardForm
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnMyclasses = new System.Windows.Forms.Button();
            this.btnStudentInfo = new System.Windows.Forms.Button();
            this.btnMarkResults = new System.Windows.Forms.Button();
            this.btnMarkAttendance = new System.Windows.Forms.Button();
            this.grpTeacherInfo = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTeacherName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.grpTeacherInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.Black;
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnMyclasses);
            this.panelSidebar.Controls.Add(this.btnStudentInfo);
            this.panelSidebar.Controls.Add(this.btnMarkResults);
            this.panelSidebar.Controls.Add(this.btnMarkAttendance);
            this.panelSidebar.Location = new System.Drawing.Point(1, 1);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(200, 553);
            this.panelSidebar.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(28, 369);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(130, 30);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnMyclasses
            // 
            this.btnMyclasses.Location = new System.Drawing.Point(28, 131);
            this.btnMyclasses.Name = "btnMyclasses";
            this.btnMyclasses.Size = new System.Drawing.Size(130, 29);
            this.btnMyclasses.TabIndex = 4;
            this.btnMyclasses.Text = "My Classes";
            this.btnMyclasses.UseVisualStyleBackColor = true;
            this.btnMyclasses.Click += new System.EventHandler(this.btnMyclasses_Click);
            // 
            // btnStudentInfo
            // 
            this.btnStudentInfo.Location = new System.Drawing.Point(28, 305);
            this.btnStudentInfo.Name = "btnStudentInfo";
            this.btnStudentInfo.Size = new System.Drawing.Size(130, 28);
            this.btnStudentInfo.TabIndex = 3;
            this.btnStudentInfo.Text = "Student Info";
            this.btnStudentInfo.UseVisualStyleBackColor = true;
            this.btnStudentInfo.Click += new System.EventHandler(this.btnStudentInfo_Click);
            // 
            // btnMarkResults
            // 
            this.btnMarkResults.Location = new System.Drawing.Point(28, 253);
            this.btnMarkResults.Name = "btnMarkResults";
            this.btnMarkResults.Size = new System.Drawing.Size(130, 26);
            this.btnMarkResults.TabIndex = 1;
            this.btnMarkResults.Text = "Mark Results";
            this.btnMarkResults.UseVisualStyleBackColor = true;
            this.btnMarkResults.Click += new System.EventHandler(this.btnMarkResults_Click);
            // 
            // btnMarkAttendance
            // 
            this.btnMarkAttendance.Location = new System.Drawing.Point(28, 193);
            this.btnMarkAttendance.Name = "btnMarkAttendance";
            this.btnMarkAttendance.Size = new System.Drawing.Size(130, 29);
            this.btnMarkAttendance.TabIndex = 0;
            this.btnMarkAttendance.Text = "MarkAttendance";
            this.btnMarkAttendance.UseVisualStyleBackColor = true;
            this.btnMarkAttendance.Click += new System.EventHandler(this.btnMarkAttendance_Click);
            // 
            // grpTeacherInfo
            // 
            this.grpTeacherInfo.Controls.Add(this.txtAddress);
            this.grpTeacherInfo.Controls.Add(this.txtContact);
            this.grpTeacherInfo.Controls.Add(this.txtDOB);
            this.grpTeacherInfo.Controls.Add(this.txtGender);
            this.grpTeacherInfo.Controls.Add(this.txtEmail);
            this.grpTeacherInfo.Controls.Add(this.txtTeacherName);
            this.grpTeacherInfo.Controls.Add(this.lblAddress);
            this.grpTeacherInfo.Controls.Add(this.lblContact);
            this.grpTeacherInfo.Controls.Add(this.lblDOB);
            this.grpTeacherInfo.Controls.Add(this.lblGender);
            this.grpTeacherInfo.Controls.Add(this.lblEmail);
            this.grpTeacherInfo.Controls.Add(this.lblTeacherName);
            this.grpTeacherInfo.Location = new System.Drawing.Point(220, 75);
            this.grpTeacherInfo.Name = "grpTeacherInfo";
            this.grpTeacherInfo.Size = new System.Drawing.Size(662, 430);
            this.grpTeacherInfo.TabIndex = 1;
            this.grpTeacherInfo.TabStop = false;
            this.grpTeacherInfo.Text = "Teacher Info";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(482, 220);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(100, 22);
            this.txtAddress.TabIndex = 11;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(246, 220);
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(100, 22);
            this.txtContact.TabIndex = 10;
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(36, 220);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(100, 22);
            this.txtDOB.TabIndex = 9;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(482, 92);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(100, 22);
            this.txtGender.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(246, 93);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(100, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(36, 93);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.ReadOnly = true;
            this.txtTeacherName.Size = new System.Drawing.Size(100, 22);
            this.txtTeacherName.TabIndex = 6;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(478, 177);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 20);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(257, 177);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(67, 20);
            this.lblContact.TabIndex = 4;
            this.lblContact.Text = "Contact";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(32, 177);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(105, 20);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(478, 57);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(64, 20);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(257, 57);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(51, 20);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // lblTeacherName
            // 
            this.lblTeacherName.AutoSize = true;
            this.lblTeacherName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherName.Location = new System.Drawing.Point(32, 53);
            this.lblTeacherName.Name = "lblTeacherName";
            this.lblTeacherName.Size = new System.Drawing.Size(53, 20);
            this.lblTeacherName.TabIndex = 0;
            this.lblTeacherName.Text = "Name";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(314, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(309, 40);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Teacher Dashboard";
            // 
            // TeacherDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 555);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpTeacherInfo);
            this.Controls.Add(this.panelSidebar);
            this.Name = "TeacherDashboardForm";
            this.Text = "TeacherDashboardForm";
            this.Load += new System.EventHandler(this.TeacherDashboardForm_Load);
            this.panelSidebar.ResumeLayout(false);
            this.grpTeacherInfo.ResumeLayout(false);
            this.grpTeacherInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnMarkAttendance;
        private System.Windows.Forms.Button btnStudentInfo;
        private System.Windows.Forms.Button btnMarkResults;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnMyclasses;
        private System.Windows.Forms.GroupBox grpTeacherInfo;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTeacherName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblDOB;
    }
}