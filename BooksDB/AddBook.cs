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
    public partial class AddBook : Form
    {
        string cs = @"Server=localhost;Database=BooksDB;Trusted_Connection=True;";
        public AddBook()
        {
            InitializeComponent();
        }

        private void btnBackBooks_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void trackBarSalary_Scroll(object sender, EventArgs e)
        {
            lblAdvanceAmount.Text = trackBarAdvance.Value.ToString();
        }

        private void trackBarRoyalty_Scroll(object sender, EventArgs e)
        {
            lblRoyaltyAmount.Text = trackBarRoyalty.Value.ToString();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            SqlCommand thisCommand = null;
            SqlConnection thisConn = null;

            if(txtIDB.Text.Length!=0 && txtTitle.Text.Length!=0 && cmbType.Text!=" ")
            {
                if(txtIDB.Text.Length==6)
                {
                    SqlConnection conn1 = new SqlConnection(cs);
                    conn1.Open();
                    SqlCommand check_PubID = new SqlCommand("SELECT COUNT(*) FROM Publishers WHERE (pub_id = @pub_id)", conn1);
                    check_PubID.Parameters.AddWithValue("@pub_id", txtPubID.Text);
                    int PubIDExist = (int)check_PubID.ExecuteScalar();

                    if (PubIDExist > 0)
                    {
                        int pubid;
                        if (int.TryParse(txtPubID.Text, out pubid))
                        {
                            conn1.Close();
                            SqlConnection conn2 = new SqlConnection(cs);
                            conn2.Open();
                            SqlCommand check_TitleID = new SqlCommand("SELECT COUNT(*) FROM Books WHERE (title_id = @title_id)", conn2);
                            check_TitleID.Parameters.AddWithValue("@title_id", txtIDB.Text);
                            int TitleIDExist = (int)check_TitleID.ExecuteScalar();

                            if (TitleIDExist > 0)
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
                                    string query = "INSERT INTO Books (title_id, title, type, pub_id, price, advance, royalty, ytd_sales, notes, pubdate)";
                                    query += " VALUES (@title_id, @title, @type, @pub_id, @price, @advance, @royalty, @ytd_sales, @notes, @pubdate)";
                                    thisCommand = new SqlCommand(query, thisConn);
                                    thisCommand.Parameters.AddWithValue("@title_id", txtIDB.Text);
                                    thisCommand.Parameters.AddWithValue("@title", txtTitle.Text);
                                    thisCommand.Parameters.AddWithValue("@type", cmbType.Text);
                                    thisCommand.Parameters.AddWithValue("@pub_id", txtPubID.Text);
                                    thisCommand.Parameters.AddWithValue("@price", txtPrice.Text);
                                    thisCommand.Parameters.AddWithValue("@advance", trackBarAdvance.Value.ToString());
                                    thisCommand.Parameters.AddWithValue("@royalty", trackBarRoyalty.Value.ToString());
                                    thisCommand.Parameters.AddWithValue("@ytd_sales", txtYtdSales.Text);
                                    thisCommand.Parameters.AddWithValue("@notes", txtNotes.Text);
                                    thisCommand.Parameters.AddWithValue("@pubdate", dateTimePicker1.Value);
                                    thisCommand.ExecuteNonQuery();

                                    MessageBox.Show("The new book has been added succesfully.");
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
                            MessageBox.Show("The publisher's ID has to be a number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The publisher's ID doesn't exist.");
                        conn1.Close();
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
                MessageBox.Show("The first three fields are required.");
                return;
            }
        }
    }
}
