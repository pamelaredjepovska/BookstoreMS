using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace BooksDB
{
    public partial class Authors : Form
    {
        private SqlConnection conn = null;
        private SqlDataAdapter adapter = null;
        private DataSet dataset = null;
        string cs = @"Server=localhost;Database=BooksDB;Trusted_Connection=True;";
        public Authors()
        {
            InitializeComponent();
        }

        private void Authors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'booksDBDataSet.Authors' table. You can move, or remove it, as needed.
            this.authorsTableAdapter.Fill(this.booksDBDataSet.Authors);

            lblSearch.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Enabled = false;
        }

        public void ExecuteQuery(string query)
        {
            try
            {
                conn = new SqlConnection(cs);
                conn.Open();
                dataset = new DataSet();
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dataset, "Authors");
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Authors";
            ExecuteQuery(query);
        }

        private void btnExitA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var home_form = new Form1();
            home_form.Show();
            this.Close();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            var addAuthorForm = new AddAuthor();
            addAuthorForm.Show();
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (txtDeleteAuthor.Text.Length != 0)
            {
                string ida = txtDeleteAuthor.Text;
                if (ida[3] == '-' && ida[6] == '-' && ida.Length == 11)
                {
                    string[] id = ida.Split('-');
                    if (Regex.IsMatch(id[0], @"^[0-9]+$") && Regex.IsMatch(id[1], @"^[0-9]+$") && Regex.IsMatch(id[2], @"^[0-9]+$"))
                    {
                        // conn = new SqlConnection(cs);
                        SqlConnection conn1 = new SqlConnection(cs);
                        conn1.Open();
                        SqlCommand check_ID = new SqlCommand("SELECT COUNT(*) FROM Authors WHERE (au_id = @au_id)", conn1);
                        check_ID.Parameters.AddWithValue("@au_id", ida);
                        int IDExist = (int)check_ID.ExecuteScalar();

                        if (IDExist > 0)
                        {
                            conn1.Close();
                            try
                            {
                                conn = new SqlConnection(cs);
                                conn.Open();
                                string query = "DELETE FROM Authors WHERE au_id=@au_id";


                                SqlCommand command = new SqlCommand(query, conn);
                                command.Parameters.AddWithValue("@au_id", txtDeleteAuthor.Text);
                                command.ExecuteNonQuery();

                                MessageBox.Show("The author record has been deleted succesfully.");

                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            finally
                            {
                                if (conn != null)
                                    conn.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("That ID doesn't exists");
                            conn1.Close();
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Input numbers only.");
                    }
                }
                else
                {
                    MessageBox.Show("The ID needs to be a in a XXX-XX-XXXX format.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Enter the author's ID to delete the record.");
                return;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (rdoFirstName.Checked == false && rdoLName.Checked == false && rdoSalary.Checked == false)
            {
                MessageBox.Show("Select one of the options.");
                return;
            }
            else
            {
                string query = "SELECT * FROM Authors ORDER BY ";

                if (rdoLName.Checked == true)
                {
                    query += "au_lname";
                }
                else if (rdoFirstName.Checked == true)
                {
                    query += "au_fname";
                }
                else
                {
                    query += "au_salary";
                }

                ExecuteQuery(query);
            }
        }

        private void rdoShow_Click(object sender, EventArgs e)
        {
            if (rdoFemaleA.Checked == false && rdoMaleA.Checked == false && rdoUnknown.Checked == false)
            {
                MessageBox.Show("Select one of the options.");
                return;
            }
            else
            {
                string query = "SELECT * FROM Authors WHERE au_sex=";

                if (rdoFemaleA.Checked == true)
                {
                    query += "'F'";
                }
                else if (rdoMaleA.Checked == true)
                {
                    query += "'M'";
                }
                else
                {
                    query += "'U'";
                }

                query += " ORDER BY au_lname";
                ExecuteQuery(query);
            }
        }

        private void btnShowSalaryGenre_Click(object sender, EventArgs e)
        {
            string query = "SELECT DISTINCT au_subject, AVG(Authors.au_salary) AS [AVG of au_salary] FROM Authors GROUP BY au_subject";
            ExecuteQuery(query);
        }

        private void rdoName_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoName.Checked == false)
            {
                lblSearch.Visible = false;
                txtSearch.Visible = false;
                btnSearch.Enabled = false;
            }
            else
            {
                lblSearch.Visible = true;
                lblSearch.Text = "Enter name:";
                txtSearch.Visible = true;
                btnSearch.Enabled = true;
            }
        }

        private void rdoID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoID.Checked == false)
            {
                lblSearch.Visible = false;
                txtSearch.Visible = false;
                btnSearch.Enabled = false;
            }
            else
            {
                lblSearch.Visible = true;
                lblSearch.Text = "Enter ID:";
                txtSearch.Visible = true;
                btnSearch.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {
                string query = "SELECT * FROM Authors WHERE";

                if (rdoName.Checked == true)
                {
                    if (txtSearch.Text.Contains(' '))
                    {
                        string[] name = txtSearch.Text.Split(' ');
                        query += " au_fname LIKE '%" + name[0] + "%' OR au_lname LIKE '%" + name[0] + "%' OR au_lname LIKE '%" + name[1] + "%' OR au_fname LIKE '%" + name[1] + "%'";
                    }
                    else
                    {
                        string name = txtSearch.Text;
                        query += " au_fname LIKE '%" + name + "%' OR au_lname LIKE '%" + name + "%'";
                    }
                    ExecuteQuery(query);
                }
                else
                {
                    string id = txtSearch.Text;
                    if (id[3] == '-' && id[6] == '-' && id.Length == 11)
                    {
                        string[] id1 = id.Split('-');
                        if (Regex.IsMatch(id1[0], @"^[0-9]+$") && Regex.IsMatch(id1[1], @"^[0-9]+$") && Regex.IsMatch(id1[2], @"^[0-9]+$"))
                        {
                            query += " au_id LIKE '%" + txtSearch.Text + "%'";
                            ExecuteQuery(query);
                        }
                        else
                        {
                            MessageBox.Show("Input numbers only.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The ID needs to be a in a XXX-XX-XXXX format.");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a value in the text field to search.");
                return;
            }
        }

        private void btnAuthorsState_Click(object sender, EventArgs e)
        {
            string query = "SELECT [au_state] AS State, count([au_id]) AS [Number of authors], avg([au_salary]) AS [Average salary] FROM authors GROUP BY[au_state]";
            ExecuteQuery(query);
        }

        private void btnBookAuthor_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BookAuthor";
            ExecuteQuery(query);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Authors.au_lname, Authors.au_fname, BookAuthor.au_id, BookAuthor.title_id, Books.title FROM Authors INNER JOIN(Books INNER JOIN BookAuthor ON Books.title_id = BookAuthor.title_id) ON Authors.au_id = BookAuthor.au_id";
            ExecuteQuery(query);
        }

        private void btnUpdateA_Click(object sender, EventArgs e)
        {
            var updateform = new UpdateAuthor();
            updateform.Show();
        }
    }
}
