using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace WinFormsApp1
{
    public partial class DBconnection : Form
    {
        //int id;

        public DBconnection()
        {
            InitializeComponent();
        }

        string id;
        private void btnTest_Click(object sender, EventArgs e)
        {
            string connetionString = null;


            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

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

        private void insertData_Click(object sender, EventArgs e)
        {
            /*
            string connetionString = null;
            string sql = null;

            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;

            sql = "INSERT INTO students (first_name, last_name, gender, grade, address) VALUES ('Mithursan', 'Kalanantharasan', 'Male', '10A', 'Jaffna')";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                command.ExecuteNonQuery();
                MessageBox.Show("Save Sucessfully");
                cnn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
            */

            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void viewData_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;

            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;

            sql = "SELECT * FROM students";

            try
            {
                cnn.Open();
                command = new SqlCommand(sql, cnn);
                SqlDataReader sqlReader = command.ExecuteReader();
                /*
                while (sqlReader.Read())
                {
                    MessageBox.Show(sqlReader.GetValue(0) + " - " + sqlReader.GetValue(1) + " - " + sqlReader.GetValue(2));
                }
                */

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

        /*

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void deleteData_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            string sql = null;

            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

            SqlConnection cnn;
            cnn = new SqlConnection(connetionString);

            SqlCommand command;

            try
            {

                if (id != 0)
                {
                    command = new SqlCommand("DELETE FROM students WHERE id=@id", cnn);
                    cnn.Open();
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Record Deleted Successfully!");

                }
                else
                {
                    MessageBox.Show("Please Select the Record to DELETE");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }

        */


        /*
        private void viewSelectID_Click(object sender, EventArgs e)
        {
            //string id = dataGridView1.SelectedRows[0].Cells["id"].Value.ToString();
            string id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();
            MessageBox.Show(id);
        }
        */

        private void deleteData_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.CurrentRow.Cells["id"].Value.ToString();

            DialogResult DG = MessageBox.Show("Do You Want to Delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (DG == DialogResult.No)
            {
                return;
            }
            string connetionString = null;

            connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

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


        private void dbSubmit_Click(object sender, EventArgs e)
        {
            if (dbSubmit.Text == "Create")
            {
                string connetionString = null;
                string gender = null;
                string sql = null;



                if (dbMale.Checked)
                {
                    gender = "Male";
                }
                if (dbFemale.Checked)
                {
                    gender = "Female";
                }

                connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";

                SqlConnection cnn;
                cnn = new SqlConnection(connetionString);

                SqlCommand command;

                sql = "INSERT INTO students (first_name, last_name, grade, address, gender) VALUES ('" + dbFname.Text + "', '" + dbLname.Text + "', '" + dbGrade.Text + "', '" + dbAddress.Text + "', '" + gender + "')";

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
            else
            {
                string connetionString = null;
                connetionString = "Server=MITHONK\\SQLEXPRESS;Database=CsarpDb;Trusted_Connection=True; TrustServerCertificate=True;";


                string gender = null;
                if (dbMale.Checked)
                {
                    gender = "Male";
                }
                else if (dbFemale.Checked)
                {
                    gender = "Female";
                }



                SqlConnection cnn;
                cnn = new SqlConnection(connetionString);
                SqlCommand command;
                string sql = "UPDATE [students] SET [first_name] = '" + dbFname.Text + "', [last_name] = '" + dbLname.Text + "', gender = '" + gender + "', [grade] = '" + dbGrade.Text + "', [address] = '" + dbAddress.Text + "' WHERE [id] = '" + this.id + "' ";

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

    }
}
