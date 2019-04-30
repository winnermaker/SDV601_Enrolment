namespace Enrolment7
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
            this.btnManageStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(12, 21);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(649, 136);
            this.lblStudent.TabIndex = 8;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(681, 107);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(228, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnManageStudent
            // 
            this.btnManageStudent.Location = new System.Drawing.Point(681, 21);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Size = new System.Drawing.Size(228, 50);
            this.btnManageStudent.TabIndex = 6;
            this.btnManageStudent.Text = "Manage Student";
            this.btnManageStudent.UseVisualStyleBackColor = true;
            this.btnManageStudent.Click += new System.EventHandler(this.btnManageStudent_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 185);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnManageStudent);
            this.Name = "FrmMain";
            this.Text = "NMIT Enrolment System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnManageStudent;
    }
}