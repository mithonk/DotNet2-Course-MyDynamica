using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            StudentRegistration studentRegistration = new StudentRegistration();
            studentRegistration.Show();
        }

        private void subjectBtn_Click(object sender, EventArgs e)
        {
            subjects subjects = new subjects();
            subjects.Show();
        }

        private void gradeBtn_Click(object sender, EventArgs e)
        {
            Grades grades = new Grades();
            grades.Show();
        }
    }
}
