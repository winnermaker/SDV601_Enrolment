namespace Enrolment6
{
    partial class FrmTOPStudent
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
            this.txtReferralAgency = new System.Windows.Forms.TextBox();
            this.lbltxtReferralAgency = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtReferralAgency
            // 
            this.txtReferralAgency.Location = new System.Drawing.Point(189, 300);
            this.txtReferralAgency.Name = "txtReferralAgency";
            this.txtReferralAgency.Size = new System.Drawing.Size(338, 31);
            this.txtReferralAgency.TabIndex = 12;
            // 
            // lbltxtReferralAgency
            // 
            this.lbltxtReferralAgency.AutoSize = true;
            this.lbltxtReferralAgency.Location = new System.Drawing.Point(17, 300);
            this.lbltxtReferralAgency.Name = "lbltxtReferralAgency";
            this.lbltxtReferralAgency.Size = new System.Drawing.Size(166, 25);
            this.lbltxtReferralAgency.TabIndex = 13;
            this.lbltxtReferralAgency.Text = "Referral Agency";
            // 
            // FrmTOPStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(1016, 427);
            this.Controls.Add(this.lbltxtReferralAgency);
            this.Controls.Add(this.txtReferralAgency);
            this.Name = "FrmTOPStudent";
            this.Text = "TOP Student";
            this.Controls.SetChildIndex(this.txtReferralAgency, 0);
            this.Controls.SetChildIndex(this.lbltxtReferralAgency, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReferralAgency;
        private System.Windows.Forms.Label lbltxtReferralAgency;
    }
}
