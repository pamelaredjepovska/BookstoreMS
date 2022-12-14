using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAuthors_Click(object sender, EventArgs e)
        {
            var authors_form = new Authors();
            authors_form.Show();
            this.Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            var booksform = new Books();
            booksform.Show();
            this.Hide();
        }

        private void btnPublishers_Click(object sender, EventArgs e)
        {
            var pubform = new Publishers();
            pubform.Show();
            this.Hide();
        }

    }
}
