namespace Enrolment6
{
    partial class FrmStudentList
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
            this.cboStudentType = new System.Windows.Forms.ComboBox();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDltStudent = new System.Windows.Forms.Button();
            this.btnModifyStudent = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btnFindStudent = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboStudentType
            // 
            this.cboStudentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudentType.FormattingEnabled = true;
            this.cboStudentType.Location = new System.Drawing.Point(204, 557);
            this.cboStudentType.Name = "cboStudentType";
            this.cboStudentType.Size = new System.Drawing.Size(171, 33);
            this.cboStudentType.TabIndex = 13;
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(12, 557);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(171, 52);
            this.btnCreateStudent.TabIndex = 10;
            this.btnCreateStudent.Text = "Create Student";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(396, 632);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(171, 52);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "StudentID";
            // 
            // lstStudents
            // 
            this.lstStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 33;
            this.lstStudents.Location = new System.Drawing.Point(12, 58);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(555, 400);
            this.lstStudents.Sorted = true;
            this.lstStudents.TabIndex = 16;
            this.lstStudents.DoubleClick += new System.EventHandler(this.lstStudents_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 18;
            this.label3.Text = "Student";
            // 
            // btnDltStudent
            // 
            this.btnDltStudent.Location = new System.Drawing.Point(204, 632);
            this.btnDltStudent.Name = "btnDltStudent";
            this.btnDltStudent.Size = new System.Drawing.Size(171, 52);
            this.btnDltStudent.TabIndex = 20;
            this.btnDltStudent.Text = "Delete Student";
            this.btnDltStudent.UseVisualStyleBackColor = true;
            this.btnDltStudent.Click += new System.EventHandler(this.btnDltStudent_Click);
            // 
            // btnModifyStudent
            // 
            this.btnModifyStudent.Location = new System.Drawing.Point(12, 632);
            this.btnModifyStudent.Name = "btnModifyStudent";
            this.btnModifyStudent.Size = new System.Drawing.Size(171, 52);
            this.btnModifyStudent.TabIndex = 21;
            this.btnModifyStudent.Text = "Modify Student";
            this.btnModifyStudent.UseVisualStyleBackColor = true;
            this.btnModifyStudent.Click += new System.EventHandler(this.btnModifyStudent_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 705);
            this.splitter1.TabIndex = 22;
            this.splitter1.TabStop = false;
            // 
            // btnFindStudent
            // 
            this.btnFindStudent.Location = new System.Drawing.Point(9, 481);
            this.btnFindStudent.Name = "btnFindStudent";
            this.btnFindStudent.Size = new System.Drawing.Size(171, 52);
            this.btnFindStudent.TabIndex = 23;
            this.btnFindStudent.Text = "Find Student";
            this.btnFindStudent.UseVisualStyleBackColor = true;
            this.btnFindStudent.Click += new System.EventHandler(this.btnFindStudent_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(204, 481);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(171, 31);
            this.txtID.TabIndex = 24;
            // 
            // FrmStudentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 705);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnFindStudent);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.btnModifyStudent);
            this.Controls.Add(this.btnDltStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cboStudentType);
            this.Controls.Add(this.btnCreateStudent);
            this.Name = "FrmStudentList";
            this.Text = "FrmStudentList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboStudentType;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDltStudent;
        private System.Windows.Forms.Button btnModifyStudent;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button btnFindStudent;
        private System.Windows.Forms.TextBox txtID;
    }
}