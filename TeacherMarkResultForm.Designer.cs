namespace schoolmanagementsystem
{
    partial class TeacherMarkResultForm
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
            this.lblClass = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.dgvMarkResult = new System.Windows.Forms.DataGridView();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbExam = new System.Windows.Forms.ComboBox();
            this.lblExam = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkResult)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(330, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Mark Result";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.Location = new System.Drawing.Point(21, 124);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(119, 20);
            this.lblClass.TabIndex = 1;
            this.lblClass.Text = "Select Class : ";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(322, 129);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(132, 20);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Select Subject : ";
            // 
            // dgvMarkResult
            // 
            this.dgvMarkResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkResult.Location = new System.Drawing.Point(106, 200);
            this.dgvMarkResult.Name = "dgvMarkResult";
            this.dgvMarkResult.RowHeadersWidth = 51;
            this.dgvMarkResult.RowTemplate.Height = 24;
            this.dgvMarkResult.Size = new System.Drawing.Size(569, 266);
            this.dgvMarkResult.TabIndex = 3;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(146, 124);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 24);
            this.cmbClass.TabIndex = 4;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(460, 124);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(121, 24);
            this.cmbSubject.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(106, 499);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 43);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbExam
            // 
            this.cmbExam.FormattingEnabled = true;
            this.cmbExam.Location = new System.Drawing.Point(728, 125);
            this.cmbExam.Name = "cmbExam";
            this.cmbExam.Size = new System.Drawing.Size(121, 24);
            this.cmbExam.TabIndex = 7;
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExam.Location = new System.Drawing.Point(615, 129);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(107, 20);
            this.lblExam.TabIndex = 8;
            this.lblExam.Text = "Exam Type : ";
            this.lblExam.Click += new System.EventHandler(this.label1_Click);
            // 
            // TeacherMarkResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 576);
            this.Controls.Add(this.lblExam);
            this.Controls.Add(this.cmbExam);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.dgvMarkResult);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblTitle);
            this.Name = "TeacherMarkResultForm";
            this.Text = "TeacherMarkResultForm";
            this.Load += new System.EventHandler(this.TeacherMarkResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.DataGridView dgvMarkResult;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbExam;
        private System.Windows.Forms.Label lblExam;
    }
}