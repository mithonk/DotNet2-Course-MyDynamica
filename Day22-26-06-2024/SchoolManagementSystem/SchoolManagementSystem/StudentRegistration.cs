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
    public partial class StudentRegistration : Form
    {
        public string id;
        public StudentRegistration()
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
            if (dataGridView.SelectedRows.Count > 0)
            {
                createUpdateBtn.Text = "Update";

                this.id = dataGridView.SelectedRows[0].Cells["id"].Value.ToString();
                string sadmissionNo = dataGridView.SelectedRows[0].Cells["admission_no"].Value.ToString();
                string sfirstName = dataGridView.SelectedRows[0].Cells["first_name"].Value.ToString();
                string slastName = dataGridView.SelectedRows[0].Cells["last_name"].Value.ToString();
                string sfullName = dataGridView.SelectedRows[0].Cells["full_name"].Value.ToString();
                string sgender = dataGridView.SelectedRows[0].Cells["gender"].Value.ToString();
                DateTime sdateOfBirth = Convert.ToDateTime(dataGridView.SelectedRows[0].Cells["date_of_birth"].Value.ToString());
                string snicNo = dataGridView.SelectedRows[0].Cells["stu_nic_no"].Value.ToString();
                string stelephoneNo = dataGridView.SelectedRows[0].Cells["tp_no"].Value.ToString();
                string sgrade = dataGridView.SelectedRows[0].Cells["grade_id"].Value.ToString();
                string smedium = dataGridView.SelectedRows[0].Cells["medium"].Value.ToString();
                DateTime sdateOfAdmission = Convert.ToDateTime(dataGridView.SelectedRows[0].Cells["date_of_admission"].Value.ToString());
                string saddress = dataGridView.SelectedRows[0].Cells["resident_address"].Value.ToString();


                admissionNo.Text = sadmissionNo;
                firstName.Text = sfirstName;
                lastName.Text = slastName;
                fullName.Text = sfullName;
                dateOfBirth.Value = sdateOfBirth;
                nicNo.Text = snicNo;
                telephoneNo.Text = stelephoneNo;
                grade.Text = sgrade;
                medium.Text = smedium;
                dateOfAdmission.Value = sdateOfAdmission;
                address.Text = saddress;

                if (sgender == "Male")
                {
                    male.Checked = true;
                }
                else if (sgender == "Female")
                {
                    female.Checked = true;
                }
                else
                {
                    others.Checked = true;
                }

            }
        }

        private void createUpdateBtn_Click(object sender, EventArgs e)
        {
            if(createUpdateBtn.Text == "Create")
            {
                string connectionString = null;
                string sql = null;
                
                connectionString = "Server=MITHONK\\SQLEXPRESS; Database = SchoolManagementSystem; Trusted_Connection = True; TrustServerCertificate = True;";

                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);

                string gender;
                if (male.Checked == true)
                {
                    gender = male.Text;
                }
                else if (female.Checked == true)
                {
                    gender = female.Text;
                }
                else 
                { 
                    gender = others.Text;
                }


                SqlCommand command;
                sql = "INSERT INTO students (admission_no, grade_id, medium, date_of_admission, first_name, last_name, full_name, gender, date_of_birth, stu_nic_no, tp_no, resident_address) VALUES ('"+admissionNo.Text+"', '"+grade.Text+"', '"+medium.Text+"', '"+dateOfAdmission.Value.ToString("yyyy-MM-dd")+"', '"+firstName.Text+"', '"+lastName.Text+"', '"+fullName.Text+"', '"+gender+"', '"+dateOfBirth.Value.ToString("yyyy-MM-dd")+"', '"+nicNo.Text+"', '"+telephoneNo.Text+"', '"+address.Text+"' )";


                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    cnn.Close();
                    MessageBox.Show("Created Successfully");
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show(ex.Message);
                }

                ClearData();
                FetchData();


            } else
            {

            }
        }
    }
}
