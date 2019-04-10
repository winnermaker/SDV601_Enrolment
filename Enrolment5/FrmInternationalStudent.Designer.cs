namespace Enrolment5
{
    partial class FrmInternationalStudent
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
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtIELTS = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblIELTS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(189, 297);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(338, 31);
            this.txtCountry.TabIndex = 13;
            // 
            // txtIELTS
            // 
            this.txtIELTS.Location = new System.Drawing.Point(189, 361);
            this.txtIELTS.Name = "txtIELTS";
            this.txtIELTS.Size = new System.Drawing.Size(338, 31);
            this.txtIELTS.TabIndex = 14;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(96, 297);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(87, 25);
            this.lblCountry.TabIndex = 15;
            this.lblCountry.Text = "Country";
            // 
            // lblIELTS
            // 
            this.lblIELTS.AutoSize = true;
            this.lblIELTS.Location = new System.Drawing.Point(113, 361);
            this.lblIELTS.Name = "lblIELTS";
            this.lblIELTS.Size = new System.Drawing.Size(70, 25);
            this.lblIELTS.TabIndex = 16;
            this.lblIELTS.Text = "IELTS";
            // 
            // FrmInternationalStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(1016, 427);
            this.Controls.Add(this.lblIELTS);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtIELTS);
            this.Controls.Add(this.txtCountry);
            this.Name = "FrmInternationalStudent";
            this.Text = "International Student";
            this.Controls.SetChildIndex(this.txtCountry, 0);
            this.Controls.SetChildIndex(this.txtIELTS, 0);
            this.Controls.SetChildIndex(this.lblCountry, 0);
            this.Controls.SetChildIndex(this.lblIELTS, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtIELTS;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblIELTS;
    }
}
