namespace Enrolment3
{
    partial class FrmMain
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnModStudent = new System.Windows.Forms.Button();
            this.btnCreateStudent = new System.Windows.Forms.Button();
            this.cboStudentType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(34, 229);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(431, 419);
            this.lblStudent.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(541, 577);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(288, 71);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnModStudent
            // 
            this.btnModStudent.Location = new System.Drawing.Point(34, 121);
            this.btnModStudent.Name = "btnModStudent";
            this.btnModStudent.Size = new System.Drawing.Size(431, 71);
            this.btnModStudent.TabIndex = 6;
            this.btnModStudent.Text = "Modify Student";
            this.btnModStudent.UseVisualStyleBackColor = true;
            this.btnModStudent.Click += new System.EventHandler(this.btnModStudent_Click);
            // 
            // btnCreateStudent
            // 
            this.btnCreateStudent.Location = new System.Drawing.Point(34, 25);
            this.btnCreateStudent.Name = "btnCreateStudent";
            this.btnCreateStudent.Size = new System.Drawing.Size(431, 71);
            this.btnCreateStudent.TabIndex = 5;
            this.btnCreateStudent.Text = "Create Student";
            this.btnCreateStudent.UseVisualStyleBackColor = true;
            this.btnCreateStudent.Click += new System.EventHandler(this.btnCreateStudent_Click);
            // 
            // cboStudentType
            // 
            this.cboStudentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudentType.FormattingEnabled = true;
            this.cboStudentType.Location = new System.Drawing.Point(541, 25);
            this.cboStudentType.Name = "cboStudentType";
            this.cboStudentType.Size = new System.Drawing.Size(288, 33);
            this.cboStudentType.TabIndex = 9;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 684);
            this.Controls.Add(this.cboStudentType);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnModStudent);
            this.Controls.Add(this.btnCreateStudent);
            this.Name = "FrmMain";
            this.Text = "NMIT Enrolment System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnModStudent;
        private System.Windows.Forms.Button btnCreateStudent;
        private System.Windows.Forms.ComboBox cboStudentType;
    }
}