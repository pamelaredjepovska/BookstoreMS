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
    public partial class Publishers : Form
    {
        private SqlConnection conn = null;
        private SqlDataAdapter adapter = null;
        private DataSet dataset = null;
        string cs = @"Server=localhost;Database=BooksDB;Trusted_Connection=True;";
        public Publishers()
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
            string query = "SELECT * FROM Publishers";
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

        private void btnDeletePub_Click(object sender, EventArgs e)
        {
            if (txtDeletePub.Text.Length != 0)
            {
                if (txtDeletePub.Text.Length == 4)
                {
                    int pubid;
                    if (int.TryParse(txtDeletePub.Text, out pubid))
                    {

                        SqlConnection conn2 = new SqlConnection(cs);
                        conn2.Open();
                        SqlCommand check_PubID = new SqlCommand("SELECT COUNT(*) FROM Publishers WHERE (pub_id = @pub_id)", conn2);
                        check_PubID.Parameters.AddWithValue("@pub_id", txtDeletePub.Text);
                        int PubIDExist = (int)check_PubID.ExecuteScalar();

                        if (PubIDExist > 0)
                        {
                            conn2.Close();
                            try
                            {
                                conn = new SqlConnection(cs);
                                conn.Open();
                                string query = "DELETE FROM Publishers WHERE pub_id=@pub_id";


                                SqlCommand command = new SqlCommand(query, conn);
                                command.Parameters.AddWithValue("@pub_id", txtDeletePub.Text);
                                command.ExecuteNonQuery();

                                MessageBox.Show("The publisher record has been deleted succesfully.");
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
                        MessageBox.Show("The ID needs to be numbers only.");
                    }
                }
                else
                {
                    MessageBox.Show("The ID needs to be 4 characters.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Enter a publisher's ID.");
                return;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if(rdoPubName.Checked==false && rdoPubID.Checked==false && rdoState.Checked==false)
            {
                MessageBox.Show("Select one of the options to sort.");
                return; 
            }
            else
            {
                string query = "SELECT * FROM Publishers ORDER BY ";

                if (rdoPubName.Checked == true)
                {
                    query += "pub_name";
                }
                else if (rdoPubID.Checked == true)
                {
                    query += "pub_id";
                }
                else
                {
                    query += "pub_state";
                }

                ExecuteQuery(query);
            }
        }

        private void Publishers_Load(object sender, EventArgs e)
        {
            lblSearch.Visible = false;
            txtSearch.Visible = false;
            btnSearch.Enabled = false;
        }

        private void rdoNameSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNameSearch.Checked == false)
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

        private void rdoIDSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoIDSearch.Checked == false)
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

        private void rdoCountrySearch_CheckedChanged(object sender, EventArgs e)
        {
            //Preimenuvano vo city
            if (rdoCountrySearch.Checked == false)
            {
                lblSearch.Visible = false;
                txtSearch.Visible = false;
                btnSearch.Enabled = false;
            }
            else
            {
                lblSearch.Visible = true;
                lblSearch.Text = "Enter city:";
                txtSearch.Visible = true;
                btnSearch.Enabled = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length != 0)
            {
                string query = "SELECT * FROM Publishers WHERE";

                if (rdoNameSearch.Checked == true)
                {
                    query += " pub_name LIKE '%" + txtSearch.Text + "%'";
                    ExecuteQuery(query);
                }
                else if(rdoIDSearch.Checked==true)
                {
                    int pubid;
                    if (txtSearch.Text.Length == 4 && int.TryParse(txtSearch.Text, out pubid))
                    {
                        query += " pub_id LIKE '%" + txtSearch.Text + "%'";
                        ExecuteQuery(query);
                    }
                    else
                    {
                        MessageBox.Show("The ID needs to be 4 numbers.");
                    }
                }
                else
                {
                    query += " pub_city LIKE '%" + txtSearch.Text + "%'";
                    ExecuteQuery(query);
                }
            }
            else
            {
                MessageBox.Show("Enter a value in the text field to search.");
                return;
            }
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            var addpub = new AddPublisher();
            addpub.Show();
        }

        private void btnPubInCountry_Click(object sender, EventArgs e)
        {
            string query = "SELECT  Publishers.[pub_country] AS [Country], COUNT(pub_id) AS [Number of publishers] FROM Publishers GROUP BY pub_country";
            ExecuteQuery(query);
        }
    }
}
