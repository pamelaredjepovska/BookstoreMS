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
    public partial class AddPublisher : Form
    {
        string cs = @"Server=localhost;Database=BooksDB;Trusted_Connection=True;";
        public AddPublisher()
        {
            InitializeComponent();
        }

        private void btnBackPublishers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            SqlCommand thisCommand = null;
            SqlConnection thisConn = null;

            if (txtIDP.Text.Length != 0 && txtPubName.Text.Length != 0 && txtPubCity.Text.Length!=0)
            {
                int pubid;
                if(int.TryParse(txtIDP.Text, out pubid) && txtIDP.Text.Length==4)
                {
                        SqlConnection conn2 = new SqlConnection(cs);
                        conn2.Open();
                        SqlCommand check_PubID = new SqlCommand("SELECT COUNT(*) FROM Publishers WHERE (pub_id = @pub_id)", conn2);
                        check_PubID.Parameters.AddWithValue("@pub_id", txtIDP.Text);
                        int PubIDExist = (int)check_PubID.ExecuteScalar();

                        if (PubIDExist > 0)
                        {
                            MessageBox.Show("That ID already exists");
                            conn2.Close();
                            return;
                        }
                        else
                        {
                            conn2.Close();
                            try
                            {
                                thisConn = new SqlConnection(cs);
                                thisConn.Open();
                                string query = "INSERT INTO Publishers (pub_id, pub_name, pub_city, pub_state, pub_country)";
                                query += " VALUES (@pub_id, @pub_name, @pub_city, @pub_state, @pub_country)";
                                thisCommand = new SqlCommand(query, thisConn);
                                thisCommand.Parameters.AddWithValue("@pub_id", txtIDP.Text);
                                thisCommand.Parameters.AddWithValue("@pub_name", txtPubName.Text);
                                thisCommand.Parameters.AddWithValue("@pub_city", txtPubCity.Text);
                                thisCommand.Parameters.AddWithValue("@pub_state", txtPubState.Text);
                                thisCommand.Parameters.AddWithValue("@pub_country", txtPubCountry.Text);
                                thisCommand.ExecuteNonQuery();

                                MessageBox.Show("The new publisher has been added succesfully.");
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }
                            finally
                            {
                                if (thisConn != null)
                                    thisConn.Close();
                            }
                        }
                }
                else
                {
                    MessageBox.Show("The ID needs to be 4 numbers.");
                }

            }
            else
            {
                MessageBox.Show("The first three fields are required.");
                return;
            }
        }
    }
}
