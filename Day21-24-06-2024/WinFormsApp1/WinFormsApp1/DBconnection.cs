using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace WinFormsApp1
{
    public partial class DBconnection : Form
    {
        string conString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
        DataTable dt;
        DataView dv = new DataView();
        string id;
        public DBconnection()
        {
            InitializeComponent();
        }

        #region this is DB function
        private void TestDatabaseConnection()
        {
            string connetionString = null;


            connetionString = conString;

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }
        private void GetAllStudents()
        {
            dt = new DataTable();
            string connetionString = null;
            string sql = null;

            connetionString = conString;

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;

            sql = "SELECT * FROM students";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();

                dt.Load(sqlReader);
                dv = dt.DefaultView;
                dataGridView1.DataSource = dv;

                sqlReader.Close();
                command.Dispose();
                cnn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }
        private void InsertStudent(string fname, string lname, string grade, string address, string gender)
        {
            string connetionString = null;
            string sql = null;
            connetionString = conString;
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;

            sql = "INSERT INTO students (first_name, last_name, grade, address, gender) VALUES ('" + fname + "', '" + lname + "', '" + grade + "', '" + address + "', '" + gender + "')";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                command.Dispose();
                cnn.Close();
                MessageBox.Show("Save Sucessfully");
                dbFname.Text = "";
                dbLname.Text = "";
                dbGrade.Text = "";
                dbAddress.Text = "";
                if (dbMale.Checked)
                {
                    dbMale.Checked = false;
                }
                if (dbFemale.Checked)
                {
                    dbFemale.Checked = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }
        private void UpdateStudent(string gender, string fname, string lname, string grade, string address, string id)
        {
            string connetionString = null;
            connetionString = conString;
            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);
            SqlCommand command;
            string sql = "UPDATE [students] SET [first_name] = '" + fname + "', [last_name] = '" + lname + "', gender = '" + gender + "', [grade] = '" + grade + "', [address] = '" + address + "' WHERE [id] = '" + id + "' ";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully!");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }
        private void DeleteStudent(string id)
        {
            string connetionString = null;

            connetionString = conString;

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;
            string sql = "DELETE FROM students WHERE id = '" + id + "'";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Successfully");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }


        private void btnTest_Click(object sender, EventArgs e)
        {
            TestDatabaseConnection();
        }
        private void viewData_Click(object sender, EventArgs e)
        {
            GetAllStudents();

        }
        private void dbSubmit_Click(object sender, EventArgs e)
        {
            string fname = dbFname.Text;
            string lname = dbLname.Text;
            string grade = dbGrade.Text;
            string address = dbAddress.Text;
            string id = this.id;
            string gender = null;

            if (dbMale.Checked)
            {
                gender = "Male";
            }
            if (dbFemale.Checked)
            {
                gender = "Female";
            }

            if (dbSubmit.Text == "Create")
            {
                InsertStudent(fname, lname, grade, address, gender);
            }
            else
            {
                UpdateStudent(gender, fname, lname, grade, address, id);
            }
        }
        private void deleteData_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

            DialogResult DG = MessageBox.Show("Do You Want to Delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (DG == DialogResult.No)
            {
                return;
            }
            DeleteStudent(id);
        }

        #endregion

        private void insertData_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
        private void editData_Click(object sender, EventArgs e)
        {


            string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            string firstname = dataGridView1.SelectedRows[0].Cells["first_name"].Value.ToString();
            string lastname = dataGridView1.SelectedRows[0].Cells["last_name"].Value.ToString();
            string gender = dataGridView1.SelectedRows[0].Cells["gender"].Value.ToString();
            string grade = dataGridView1.SelectedRows[0].Cells["grade"].Value.ToString();
            string address = dataGridView1.SelectedRows[0].Cells["address"].Value.ToString();

            Form4 form4 = new Form4(id, firstname, lastname, gender, grade, address);
            form4.ShowDialog();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                dbSubmit.Text = "Update";
                this.id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
                string firstname = dataGridView1.SelectedRows[0].Cells["first_name"].Value.ToString();
                string lastname = dataGridView1.SelectedRows[0].Cells["last_name"].Value.ToString();
                string gender = dataGridView1.SelectedRows[0].Cells["gender"].Value.ToString();
                string grade = dataGridView1.SelectedRows[0].Cells["grade"].Value.ToString();
                string address = dataGridView1.SelectedRows[0].Cells["address"].Value.ToString();

                dbFname.Text = firstname;
                dbLname.Text = lastname;
                dbGrade.Text = grade;
                dbAddress.Text = address;

                if (gender == "Male")
                {
                    dbMale.Checked = true;
                }
                else
                {
                    dbFemale.Checked = true;
                }
            }
        }




        private void dbNew_Click(object sender, EventArgs e)
        {
            this.id = null;
            dbFname.Text = "";
            dbLname.Text = "";
            dbGrade.Text = "";
            dbAddress.Text = "";
            dbMale.Checked = false;
            dbFemale.Checked = false;

            dbSubmit.Text = "Create";

        }

        private void dbSearch_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;

            connetionString = conString;

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;

            sql = "SELECT * FROM students WHERE first_name LIKE '%" + txtSearch.Text + "%' OR last_name LIKE '%" + txtSearch.Text + "%' OR grade LIKE '%" + txtSearch.Text + "%' OR gender LIKE '%" + txtSearch.Text + "%' OR address LIKE '%" + txtSearch.Text + "%' ";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                dataGridView1.DataSource = dt;
                sqlReader.Close();
                command.Dispose();
                cnn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }

        private void btnSearchColumn_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;

            connetionString = conString;

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;

            sql = "SELECT * FROM students WHERE " + comboColumn.SelectedItem.ToString() + " LIKE '%" + txtSearchColumn.Text + "%' ";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(sqlReader);

                dataGridView1.DataSource = dt;
                sqlReader.Close();
                command.Dispose();
                cnn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Please Load the Data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                try
                {
                    dv = new DataView(dt, "first_name LIKE '%" + txtSearch.Text + "%' OR last_name LIKE '%" + txtSearch.Text + "%' OR grade LIKE '%" + txtSearch.Text + "%' OR gender LIKE '%" + txtSearch.Text + "%' OR address LIKE '%" + txtSearch.Text + "%'", "first_name asc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = dv;
                }
                catch (Exception)
                {
                    throw;
                }
            }


        }

        private void txtSearchColumn_TextChanged(object sender, EventArgs e)
        {
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Please Load the Data", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                try
                {
                    dv = new DataView(dt, " " + comboColumn.SelectedItem.ToString() + " LIKE '%" + txtSearchColumn.Text + "%'", "" + comboColumn.SelectedItem.ToString() + " asc", DataViewRowState.CurrentRows);
                    dataGridView1.DataSource = dv;
                }
                catch (Exception)
                {
                    throw;
                }
            }



        }




    }
}
