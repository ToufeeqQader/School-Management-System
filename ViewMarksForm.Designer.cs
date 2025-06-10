namespace schoolmanagementsystem
{
    partial class ViewMarksForm
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblSelectExamType = new System.Windows.Forms.Label();
            this.cmbExamType = new System.Windows.Forms.ComboBox();
            this.btnLoadMarks = new System.Windows.Forms.Button();
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            this.lblObtainedMarks = new System.Windows.Forms.Label();
            this.lblTotalMarks = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.txtObtainedMarks = new System.Windows.Forms.TextBox();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.txtPercentage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(260, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(175, 32);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "View Result";
            // 
            // lblSelectExamType
            // 
            this.lblSelectExamType.AutoSize = true;
            this.lblSelectExamType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectExamType.Location = new System.Drawing.Point(36, 105);
            this.lblSelectExamType.Name = "lblSelectExamType";
            this.lblSelectExamType.Size = new System.Drawing.Size(92, 20);
            this.lblSelectExamType.TabIndex = 1;
            this.lblSelectExamType.Text = "Exam Type";
            // 
            // cmbExamType
            // 
            this.cmbExamType.FormattingEnabled = true;
            this.cmbExamType.Location = new System.Drawing.Point(31, 142);
            this.cmbExamType.Name = "cmbExamType";
            this.cmbExamType.Size = new System.Drawing.Size(121, 24);
            this.cmbExamType.TabIndex = 2;
            this.cmbExamType.SelectedIndexChanged += new System.EventHandler(this.cmbSelectExamType_SelectedIndexChanged);
            // 
            // btnLoadMarks
            // 
            this.btnLoadMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadMarks.Location = new System.Drawing.Point(31, 230);
            this.btnLoadMarks.Name = "btnLoadMarks";
            this.btnLoadMarks.Size = new System.Drawing.Size(111, 38);
            this.btnLoadMarks.TabIndex = 3;
            this.btnLoadMarks.Text = "Load Marks";
            this.btnLoadMarks.UseVisualStyleBackColor = true;
            this.btnLoadMarks.Click += new System.EventHandler(this.btnLoadMarks_Click);
            // 
            // dgvMarks
            // 
            this.dgvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarks.Location = new System.Drawing.Point(266, 105);
            this.dgvMarks.Name = "dgvMarks";
            this.dgvMarks.ReadOnly = true;
            this.dgvMarks.RowHeadersWidth = 51;
            this.dgvMarks.RowTemplate.Height = 24;
            this.dgvMarks.Size = new System.Drawing.Size(458, 204);
            this.dgvMarks.TabIndex = 4;
            this.dgvMarks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarks_CellContentClick);
            // 
            // lblObtainedMarks
            // 
            this.lblObtainedMarks.AutoSize = true;
            this.lblObtainedMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObtainedMarks.Location = new System.Drawing.Point(40, 351);
            this.lblObtainedMarks.Name = "lblObtainedMarks";
            this.lblObtainedMarks.Size = new System.Drawing.Size(127, 20);
            this.lblObtainedMarks.TabIndex = 5;
            this.lblObtainedMarks.Text = "Obtained Marks";
            // 
            // lblTotalMarks
            // 
            this.lblTotalMarks.AutoSize = true;
            this.lblTotalMarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMarks.Location = new System.Drawing.Point(247, 351);
            this.lblTotalMarks.Name = "lblTotalMarks";
            this.lblTotalMarks.Size = new System.Drawing.Size(97, 20);
            this.lblTotalMarks.TabIndex = 6;
            this.lblTotalMarks.Text = "Total Marks";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentage.Location = new System.Drawing.Point(457, 351);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(94, 20);
            this.lblPercentage.TabIndex = 7;
            this.lblPercentage.Text = "Percentage";
            // 
            // txtObtainedMarks
            // 
            this.txtObtainedMarks.Location = new System.Drawing.Point(44, 384);
            this.txtObtainedMarks.Name = "txtObtainedMarks";
            this.txtObtainedMarks.ReadOnly = true;
            this.txtObtainedMarks.Size = new System.Drawing.Size(108, 22);
            this.txtObtainedMarks.TabIndex = 8;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(251, 384);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.ReadOnly = true;
            this.txtTotalMarks.Size = new System.Drawing.Size(100, 22);
            this.txtTotalMarks.TabIndex = 9;
            // 
            // txtPercentage
            // 
            this.txtPercentage.Location = new System.Drawing.Point(461, 384);
            this.txtPercentage.Name = "txtPercentage";
            this.txtPercentage.ReadOnly = true;
            this.txtPercentage.Size = new System.Drawing.Size(100, 22);
            this.txtPercentage.TabIndex = 10;
            // 
            // ViewMarksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPercentage);
            this.Controls.Add(this.txtTotalMarks);
            this.Controls.Add(this.txtObtainedMarks);
            this.Controls.Add(this.lblPercentage);
            this.Controls.Add(this.lblTotalMarks);
            this.Controls.Add(this.lblObtainedMarks);
            this.Controls.Add(this.dgvMarks);
            this.Controls.Add(this.btnLoadMarks);
            this.Controls.Add(this.cmbExamType);
            this.Controls.Add(this.lblSelectExamType);
            this.Controls.Add(this.lblResult);
            this.Name = "ViewMarksForm";
            this.Text = "ViewMarksForm";
            this.Load += new System.EventHandler(this.ViewMarksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblSelectExamType;
        private System.Windows.Forms.ComboBox cmbExamType;
        private System.Windows.Forms.Button btnLoadMarks;
        private System.Windows.Forms.DataGridView dgvMarks;
        private System.Windows.Forms.Label lblObtainedMarks;
        private System.Windows.Forms.Label lblTotalMarks;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.TextBox txtObtainedMarks;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.TextBox txtPercentage;
    }
}