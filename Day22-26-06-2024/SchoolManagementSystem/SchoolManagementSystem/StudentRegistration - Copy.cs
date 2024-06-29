using Microsoft.Data.SqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class StudentRegistration1 : Form
    {
        public StudentRegistration1()
        {
            InitializeComponent();
        }


        private void FetchData()
        {
            string connectionString = null;
            string sql = null;

            connectionString = "Server=MITHONK\\SQLEXPRESS; Database=SchoolManagementSystem; Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connectionString);
            SqlCommand command;

            sql = "SELECT * FROM students";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlDataReader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(sqlDataReader);

                dataGridView.DataSource = dt;
                sqlDataReader.Close();
                command.Dispose();
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection");
            }
        }

        private void ClearData()
        {
            admissionNo.Clear();
            grade.Text = "";
            medium.Clear();
            dateOfAdmission.Text = "";

            firstName.Clear();
            lastName.Clear();
            fullName.Clear();
            male.Checked = false;
            female.Checked = false;
            others.Checked = false;
            dateOfBirth.Text = "";
            nicNo.Clear();
            telephoneNo.Clear();
            address.Clear();

            createUpdateBtn.Image = SchoolManagementSystem.Properties.Resources.save;
            createUpdateBtn.Text = "Create";


        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {
            FetchData();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count > 0)
            {
                createUpdateBtn.Text = "Update";
            }
        }
    }
}
