
namespace StudentProfile
{
    partial class StudentProfile
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStudentProfile;
        private System.Windows.Forms.TextBox txtStudentProfile;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.Button btnEnter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblStudentProfile = new System.Windows.Forms.Label();
            this.txtStudentProfile = new System.Windows.Forms.TextBox();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblStudentProfile
            // 
            this.lblStudentProfile.AutoSize = true;
            this.lblStudentProfile.Location = new System.Drawing.Point(20, 20);
            this.lblStudentProfile.Name = "lblStudentProfile";
            this.lblStudentProfile.Size = new System.Drawing.Size(79, 13);
            this.lblStudentProfile.TabIndex = 0;
            this.lblStudentProfile.Text = "Student Profile:";

            // 
            // txtStudentProfile
            // 
            this.txtStudentProfile.Location = new System.Drawing.Point(20, 40);
            this.txtStudentProfile.Name = "txtStudentProfile";
            this.txtStudentProfile.Size = new System.Drawing.Size(180, 20);
            this.txtStudentProfile.TabIndex = 1;

            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Location = new System.Drawing.Point(20, 70);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(87, 13);
            this.lblContactNumber.TabIndex = 2;
            this.lblContactNumber.Text = "Contact Number:";

            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(20, 90);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(180, 20);
            this.txtContactNumber.TabIndex = 3;

            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(20, 125);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(180, 30);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);

            // 
            // StudentProfile
            // 
            this.ClientSize = new System.Drawing.Size(225, 180);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtContactNumber);
            this.Controls.Add(this.lblContactNumber);
            this.Controls.Add(this.txtStudentProfile);
            this.Controls.Add(this.lblStudentProfile);
            this.Name = "StudentProfile";
            this.Text = "Student Profile";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}

