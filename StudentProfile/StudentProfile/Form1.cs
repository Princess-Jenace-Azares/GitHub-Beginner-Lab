
using System;
using System.Windows.Forms;

namespace StudentProfile
{
    public partial class StudentProfile : Form
    {
        public StudentProfile()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Student Profile: " + txtStudentProfile.Text +
                "\nContact Number: " + txtContactNumber.Text,
                "Student Profile"
            );
        }
    }
}

