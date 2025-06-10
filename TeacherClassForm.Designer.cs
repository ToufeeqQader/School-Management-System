namespace schoolmanagementsystem
{
    partial class TeacherClassForm
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
            this.dgvMyClasses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(335, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(182, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Classes";
            // 
            // dgvMyClasses
            // 
            this.dgvMyClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyClasses.Location = new System.Drawing.Point(56, 128);
            this.dgvMyClasses.Name = "dgvMyClasses";
            this.dgvMyClasses.ReadOnly = true;
            this.dgvMyClasses.RowHeadersWidth = 51;
            this.dgvMyClasses.RowTemplate.Height = 24;
            this.dgvMyClasses.Size = new System.Drawing.Size(831, 366);
            this.dgvMyClasses.TabIndex = 1;
            this.dgvMyClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMyClasses_CellContentClick);
            // 
            // TeacherClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 581);
            this.Controls.Add(this.dgvMyClasses);
            this.Controls.Add(this.lblTitle);
            this.Name = "TeacherClassForm";
            this.Text = "TeacherClassForm";
            this.Load += new System.EventHandler(this.TeacherClassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvMyClasses;
    }
}