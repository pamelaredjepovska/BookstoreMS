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
    public partial class UpdateAuthor : Form
    {
        string cs = @"Server=localhost;Database=BooksDB;Trusted_Connection=True;";
        public UpdateAuthor()
        {
            InitializeComponent();
        }

        private void UpdateAuthor_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtNewData.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnBackA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtNewData.Enabled = true;
            btnUpdate.Enabled = true;

            lblNewData.Text = "Enter new " + cmbUpdate.Text+":";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection thisConn = null;
            SqlCommand thisCommand = null;

            if (txtID.Text.Length != 0 && txtNewData.Text.Length != 0)
            {
                string query = "";

                SqlConnection conn1 = new SqlConnection(cs);
                conn1.Open();
                SqlCommand check_ID = new SqlCommand("SELECT COUNT(*) FROM Authors WHERE (au_id = @id)", conn1);
                check_ID.Parameters.AddWithValue("@id", txtID.Text);
                int IDExist = (int)check_ID.ExecuteScalar();

                if (IDExist > 0)
                {
                    try
                    {
                        thisConn = new SqlConnection(cs);
                        thisConn.Open();

                        switch (cmbUpdate.Text)
                        {
                            case "first name":
                                query = "UPDATE Authors SET au_fname=@new WHERE au_id=@id";
                                break;

                            case "last name":
                                query = "UPDATE Authors SET au_lname=@new WHERE au_id=@id";
                                break;

                            case "city":
                                query = "UPDATE Authors SET au_city=@new WHERE au_id=@id";
                                break;

                            case "state":
                                query = "UPDATE Authors SET au_state=@new WHERE au_id=@id";
                                break;

                            case "zip":
                                query = "UPDATE Authors SET au_zip=@new WHERE au_id=@id";
                                break;

                            case "sex":
                                query = "UPDATE Authors SET au_sex=@new WHERE au_id=@id";
                                break;

                            case "salary":
                                query = "UPDATE Authors SET au_salary=@new WHERE au_id=@id";
                                break;

                            case "subject":
                                query = "UPDATE Authors SET au_subject=@new WHERE au_id=@id";
                                break;
                        }

                        thisCommand = new SqlCommand(query, thisConn);
                        thisCommand.Parameters.AddWithValue("new", txtNewData.Text);
                        thisCommand.Parameters.AddWithValue("id", txtID.Text);
                        thisCommand.ExecuteNonQuery();

                        MessageBox.Show("Update successfull.");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Update not completed!" + ex.ToString());
                    }
                    finally
                    {
                        if (thisConn != null)
                            thisConn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("A record with the entered ID doesn't exist in the database.");
                    conn1.Close();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Fill the textboxes to make changes.");
            }
        }
    }
}
