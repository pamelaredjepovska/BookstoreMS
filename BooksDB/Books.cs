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

namespace BooksDB
{
    public partial class Books : Form
    {
        private SqlConnection conn = null;
        private SqlDataAdapter adapter = null;
        private DataSet dataset = null;
        string cs = @"Server=localhost;Database=BooksDB;Trusted_Connection=True;";
        public Books()
        {
            InitializeComponent();
        }

        public void ExecuteQuery(string query)
        {
            try
            {
                conn = new SqlConnection(cs);
                conn.Open();
                dataset = new DataSet();
                adapter = new SqlDataAdapter(query, conn);
                adapter.Fill(dataset, "Books");
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
            string query = "SELECT * FROM Books";
            ExecuteQuery(query);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var home_form = new Form1();
            home_form.Show();
            this.Close();
        }

        private void btnExitA_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var addbook = new AddBook();
            addbook.Show();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if(txtDeleteBook.Text.Length!=0)
            {
                if (txtDeleteBook.Text.Length == 6)
                {
                    SqlConnection conn2 = new SqlConnection(cs);
                    conn2.Open();
                    SqlCommand check_TitleID = new SqlCommand("SELECT COUNT(*) FROM Books WHERE (title_id = @title_id)", conn2);
                    check_TitleID.Parameters.AddWithValue("@title_id", txtDeleteBook.Text);
                    int TitleIDExist = (int)check_TitleID.ExecuteScalar();

                    if (TitleIDExist > 0)
                    {
                        conn2.Close();
                        try
                        {
                            conn = new SqlConnection(cs);
                            conn.Open();
                            string query = "DELETE FROM Books WHERE title_id=@title_id";


                            SqlCommand command = new SqlCommand(query, conn);
                            command.Parameters.AddWithValue("@title_id", txtDeleteBook.Text);
                            command.ExecuteNonQuery();

                            MessageBox.Show("The book record has been deleted succesfully.");
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
                        MessageBox.Show("That ID doesn't exist.");
                        conn2.Close();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("The ID needs to be 6 characters.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Enter a title's ID.");
                return;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (rdoTitle.Checked == false && rdoPubID.Checked == false && rdoPrice.Checked == false && rdoPubDate.Checked==false)
            {
                MessageBox.Show("Select one of the options to sort.");
                return;
            }
            else
            {
                string query = "SELECT * FROM Books ORDER BY ";

                if (rdoTitle.Checked == true)
                {
                    query += "title";
                }
                else if (rdoPubID.Checked == true)
                {
                    query += "pub_id";
                }
                else if(rdoPrice.Checked==true)
                {
                    query += "price";
                }
                else
                {
                    query += "pubdate";
                }

                ExecuteQuery(query);
            }
        }

        private void Books_Load(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Enabled = false;
        }

        private void rdoTitleSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTitleSearch.Checked == false)
            {
                lblSearch.Visible = false;
                txtSearch.Visible = false;
                btnSearch.Enabled = false;
            }
            else
            {
                lblSearch.Visible = true;
                lblSearch.Text = "Enter title:";
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
            if(txtSearch.Text.Length!=0)
            {
                string query = "SELECT * FROM Books WHERE";

                if(rdoTitleSearch.Checked==true)
                {
                    query += " title LIKE '%" + txtSearch.Text + "%'";
                    ExecuteQuery(query);
                }
                else
                {
                    if(txtSearch.Text.Length==6)
                    {
                        query += " title_id LIKE '%" + txtSearch.Text + "%'";
                        ExecuteQuery(query);
                    }
                    else
                    {
                        MessageBox.Show("The ID needs to be 6 characters.");
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
            string query = "SELECT DISTINCT Books.pub_id, Avg(Books.price) AS [Avg Of price], Count(*) AS [Count Of Books], Avg(Books.ytd_sales) AS [Avg od ytd_sales] FROM Books GROUP BY Books.pub_id";
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

        private void btnYtdInCountry_Click(object sender, EventArgs e)
        {
            string query = "SELECT Authors.au_state, Sum(Books.ytd_sales) AS SumOfytd_sales FROM Books INNER JOIN(Authors INNER JOIN BookAuthor ON Authors.au_id = BookAuthor.au_id) ON Books.title_id = BookAuthor.title_id GROUP BY Authors.au_state";
            ExecuteQuery(query);
        }
    }
}
