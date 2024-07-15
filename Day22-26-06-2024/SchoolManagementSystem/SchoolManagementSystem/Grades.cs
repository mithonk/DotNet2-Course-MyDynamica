using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class Grades : Form
    {
        public string id;
        public Grades()
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

            sql = "SELECT * FROM grades";

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
            gradeName.Clear();
            gradeGroup.Clear();
            gradeOrder.Clear();
            createUpdateBtn.Image = SchoolManagementSystem.Properties.Resources.save;
            createUpdateBtn.Text = "Create";
        }

        private void Grades_Load(object sender, EventArgs e)
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
                string getGradeName = dataGridView.SelectedRows[0].Cells["grade_name"].Value.ToString();
                string getGradeGroup = dataGridView.SelectedRows[0].Cells["grade_group"].Value.ToString();
                string getGradeOrder = dataGridView.SelectedRows[0].Cells["grade_order"].Value.ToString();

                gradeName.Text = getGradeName;
                gradeGroup.Text = getGradeGroup;
                gradeOrder.Text = getGradeOrder;

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
                sql = "INSERT INTO grades (grade_name, grade_group, grade_order) VALUES ('" + gradeName.Text + "', '" + gradeGroup.Text + "', '" + gradeOrder.Text + "' )";


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
                sql = "UPDATE [grades] SET [grade_name] = '" + gradeName.Text + "', [grade_group] = '" + gradeGroup.Text + "', [grade_order] = '" + gradeOrder.Text + "' WHERE [id] = '" + this.id + "'  ";

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
                sql = "DELETE FROM grades WHERE id = '" + id + "' ";


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
