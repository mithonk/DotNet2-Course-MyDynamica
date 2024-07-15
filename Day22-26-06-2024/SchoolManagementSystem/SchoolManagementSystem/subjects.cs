using Microsoft.Data.SqlClient;
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
    public partial class subjects : Form
    {
        public string id;
        public subjects()
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

            sql = "SELECT * FROM subjects";

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
            subjectName.Clear();
            subjectIndex.Clear();
            subjectNumber.Clear();
            subjectOrder.Clear();

            createUpdateBtn.Image = SchoolManagementSystem.Properties.Resources.save;
            createUpdateBtn.Text = "Create";
        }

        private void subjects_Load(object sender, EventArgs e)
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
                string getSubjectName = dataGridView.SelectedRows[0].Cells["subject_name"].Value.ToString();
                string getSubjectIndex = dataGridView.SelectedRows[0].Cells["subject_index"].Value.ToString();
                string getSubjectNumber = dataGridView.SelectedRows[0].Cells["subject_number"].Value.ToString();
                string getSubjectOrder = dataGridView.SelectedRows[0].Cells["subject_order"].Value.ToString();

                subjectName.Text = getSubjectName;
                subjectIndex.Text = getSubjectIndex;
                subjectNumber.Text = getSubjectNumber;
                subjectOrder.Text = getSubjectOrder;

            }
        }

        private void createUpdateBtn_Click(object sender, EventArgs e)
        {
            if (createUpdateBtn.Text == "Create")
            {
                string connectionString = null;
                string sql = null;

                connectionString = "Server=MITHONK\\SQLEXPRESS; Database = SchoolManagementSystem; Trusted_Connection = True; TrustServerCertificate = True;";

                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);


                SqlCommand command;
                sql = "INSERT INTO subjects (subject_name, subject_index,subject_number ,subject_order) VALUES ('" + subjectName.Text + "', '" + subjectIndex.Text + "', '" + subjectNumber.Text + "', '" + subjectOrder.Text + "' )";


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

            }
            else
            {
                string connectinString = null;
                string sql = null;

                connectinString = "Server = MITHONK\\SQLEXPRESS; Database = SchoolManagementSystem; Trusted_Connection = True; TrustServerCertificate = True;";
                SqlConnection cnn;
                cnn = new SqlConnection(connectinString);


                SqlCommand command;
                sql = "UPDATE [subjects] SET [subject_name] = '" + subjectName.Text + "', [subject_index] = '" + subjectIndex.Text + "', [subject_number] = '" + subjectNumber.Text + "', [subject_order] = '" + subjectOrder.Text + "' WHERE [id] = '" + this.id + "'  ";

                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Updated Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            ClearData();
            FetchData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string id = dataGridView.CurrentRow.Cells["id"].Value.ToString();

            DialogResult DG = MessageBox.Show("Do You Want to Delete?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (DG == DialogResult.Yes)
            {
                string connectionString = null;
                string sql = null;

                connectionString = "Server = MITHONK\\SQLEXPRESS; Database = SchoolManagementSystem; Trusted_Connection = True; TrustServerCertificate = True; ";
                SqlConnection cnn;
                cnn = new SqlConnection(connectionString);

                SqlCommand command;
                sql = "DELETE FROM subjects WHERE id = '" + id + "' ";


                try
                {
                    cnn.Open();
                    command = new SqlCommand(sql, cnn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Deleted Successfully");
                    cnn.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can not open connection! ");
                }

            }
            else
            {
                return;
            }

            ClearData();
            FetchData();
        }
    }
}
