using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksDB
{
    public partial class AddAuthor : Form
    {
        string cs = @"Server=localhost;Database=BooksDB;Trusted_Connection=True;";
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void trackBarSalary_Scroll(object sender, EventArgs e)
        {
            lblSalaryAmount.Text = trackBarSalary.Value.ToString();
        }

        private void btnBackAuthors_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            SqlCommand thisCommand = null;
            SqlConnection thisConn = null;

            if (txtIDA.Text.Length != 0 && txtFirstName.Text.Length != 0 && txtLName.Text.Length != 0 && txtPhone.Text.Length!=0)
            {
                string ida = txtIDA.Text;
                string phone = txtPhone.Text;
                char gender;
                int zip;
                if(ida[3]=='-' && ida[6]=='-' && ida.Length==11)
                {
                    
                    if (phone[3]==' ' && phone[7]=='-' && phone.Length==12)
                    {
                        if (rdoMale.Checked)
                            gender = 'M';
                        else if (rdoFemale.Checked)
                            gender = 'F';
                        else
                            gender = 'U';

                        if(txtState.Text.Length==2)
                        {
                            if(int.TryParse(txtZip.Text, out zip) && txtZip.Text.Length == 5)
                            { 
                                SqlConnection conn1 = new SqlConnection(cs);
                                conn1.Open();
                                SqlCommand check_ID = new SqlCommand("SELECT COUNT(*) FROM Authors WHERE (au_id = @au_id)", conn1);
                                check_ID.Parameters.AddWithValue("@au_id", txtIDA.Text);
                                int IDExist = (int)check_ID.ExecuteScalar();

                                if (IDExist > 0)
                                {
                                     MessageBox.Show("That ID already exists");
                                    conn1.Close();
                                     return;
                                }
                                else
                                {
                                    conn1.Close();
                                    try
                                    {
                                        thisConn = new SqlConnection(cs);
                                        thisConn.Open();
                                        string query = "INSERT INTO Authors (au_id, au_lname, au_fname, au_phone, au_city, au_state, au_zip, au_sex, au_salary, au_subject)";
                                        query += " VALUES (@au_id, @au_lname, @au_fname, @au_phone, @au_city, @au_state, @au_zip, @au_sex, @au_salary, @au_subject)";
                                        thisCommand = new SqlCommand(query, thisConn);
                                        thisCommand.Parameters.AddWithValue("@au_id", ida);
                                        thisCommand.Parameters.AddWithValue("@au_lname", txtLName.Text);
                                        thisCommand.Parameters.AddWithValue("@au_fname", txtFirstName.Text);
                                        thisCommand.Parameters.AddWithValue("@au_phone", phone);
                                        thisCommand.Parameters.AddWithValue("@au_city", txtCity.Text);
                                        thisCommand.Parameters.AddWithValue("@au_state", txtState.Text);
                                        thisCommand.Parameters.AddWithValue("@au_zip", zip.ToString());
                                        thisCommand.Parameters.AddWithValue("@au_sex", gender);
                                        thisCommand.Parameters.AddWithValue("@au_salary", trackBarSalary.Value.ToString());
                                        thisCommand.Parameters.AddWithValue("@au_subject", cmbSubject.Text);
                                        thisCommand.ExecuteNonQuery();

                                        MessageBox.Show("The new author has been added succesfully.");

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
                                MessageBox.Show("The zip number needs to be a in a XXXXX format, where X is a number.");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("The state needs to be in a XX format.");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("The phone number needs to be in a XXX XXX-XXXX format.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("The ID needs to be in a XXX-XX-XXXX format.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("The first 4 fields are required.");
                return;
            }
        }
    }
}
