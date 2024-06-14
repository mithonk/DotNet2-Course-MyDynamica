using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public String fname;
        Form1 form1 = null;
        public Form2(Form1 f)
        {
            InitializeComponent();
            this.form1 = f;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //this.fname = form2Fname.Text;
            this.Close();
        }

        private void form2Fname_TextChanged(object sender, EventArgs e)
        {
            form1.form1Fname.Text = form2Fname.Text;
        }
    }
}
