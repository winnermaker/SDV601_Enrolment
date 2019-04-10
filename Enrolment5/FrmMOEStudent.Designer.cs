namespace Enrolment5
{
    partial class FrmMOEStudent
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
            this.lblLoan = new System.Windows.Forms.Label();
            this.chkFullTime = new System.Windows.Forms.CheckBox();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(62, 294);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(121, 25);
            this.lblLoan.TabIndex = 12;
            this.lblLoan.Text = "Loan Amt $";
            // 
            // chkFullTime
            // 
            this.chkFullTime.AutoSize = true;
            this.chkFullTime.Location = new System.Drawing.Point(189, 349);
            this.chkFullTime.Name = "chkFullTime";
            this.chkFullTime.Size = new System.Drawing.Size(126, 29);
            this.chkFullTime.TabIndex = 13;
            this.chkFullTime.Text = "FullTime";
            this.chkFullTime.UseVisualStyleBackColor = true;
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(189, 294);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(338, 31);
            this.txtLoan.TabIndex = 14;
            // 
            // FrmMOEStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(1016, 427);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.chkFullTime);
            this.Controls.Add(this.lblLoan);
            this.Name = "FrmMOEStudent";
            this.Text = "MOE Student";
            this.Controls.SetChildIndex(this.lblLoan, 0);
            this.Controls.SetChildIndex(this.chkFullTime, 0);
            this.Controls.SetChildIndex(this.txtLoan, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.CheckBox chkFullTime;
        private System.Windows.Forms.TextBox txtLoan;
    }
}
