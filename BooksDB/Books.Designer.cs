namespace BooksDB
{
    partial class Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnPubData = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoID = new System.Windows.Forms.RadioButton();
            this.rdoTitleSearch = new System.Windows.Forms.RadioButton();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.rdoPrice = new System.Windows.Forms.RadioButton();
            this.rdoPubID = new System.Windows.Forms.RadioButton();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtDeleteBook = new System.Windows.Forms.TextBox();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.rdoPubDate = new System.Windows.Forms.RadioButton();
            this.rdoTitle = new System.Windows.Forms.RadioButton();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnExitA = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.authorsTableAdapter = new BooksDB.BooksDBDataSetTableAdapters.AuthorsTableAdapter();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDBDataSet = new BooksDB.BooksDBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBookAuthorNames = new System.Windows.Forms.Button();
            this.btnBookAuthor = new System.Windows.Forms.Button();
            this.btnYtdInCountry = new System.Windows.Forms.Button();
            this.groupBoxSearch.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.groupBoxSort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPubData
            // 
            this.btnPubData.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPubData.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPubData.Location = new System.Drawing.Point(907, 408);
            this.btnPubData.Name = "btnPubData";
            this.btnPubData.Size = new System.Drawing.Size(150, 70);
            this.btnPubData.TabIndex = 33;
            this.btnPubData.Text = "Show data for the publishers";
            this.btnPubData.UseVisualStyleBackColor = true;
            this.btnPubData.Click += new System.EventHandler(this.btnAuthorsState_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(115, 76);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(135, 25);
            this.txtSearch.TabIndex = 20;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 79);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(103, 19);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Enter name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Location = new System.Drawing.Point(77, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdoID
            // 
            this.rdoID.AutoSize = true;
            this.rdoID.Location = new System.Drawing.Point(6, 53);
            this.rdoID.Name = "rdoID";
            this.rdoID.Size = new System.Drawing.Size(47, 23);
            this.rdoID.TabIndex = 18;
            this.rdoID.TabStop = true;
            this.rdoID.Text = "ID";
            this.rdoID.UseVisualStyleBackColor = true;
            this.rdoID.CheckedChanged += new System.EventHandler(this.rdoID_CheckedChanged);
            // 
            // rdoTitleSearch
            // 
            this.rdoTitleSearch.AutoSize = true;
            this.rdoTitleSearch.Location = new System.Drawing.Point(6, 24);
            this.rdoTitleSearch.Name = "rdoTitleSearch";
            this.rdoTitleSearch.Size = new System.Drawing.Size(64, 23);
            this.rdoTitleSearch.TabIndex = 17;
            this.rdoTitleSearch.TabStop = true;
            this.rdoTitleSearch.Text = "Title";
            this.rdoTitleSearch.UseVisualStyleBackColor = true;
            this.rdoTitleSearch.CheckedChanged += new System.EventHandler(this.rdoTitleSearch_CheckedChanged);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Controls.Add(this.lblSearch);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.rdoID);
            this.groupBoxSearch.Controls.Add(this.rdoTitleSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 488);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(256, 153);
            this.groupBoxSearch.TabIndex = 31;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search by:";
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSort.Location = new System.Drawing.Point(57, 153);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(83, 33);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // rdoPrice
            // 
            this.rdoPrice.AutoSize = true;
            this.rdoPrice.Location = new System.Drawing.Point(6, 85);
            this.rdoPrice.Name = "rdoPrice";
            this.rdoPrice.Size = new System.Drawing.Size(68, 23);
            this.rdoPrice.TabIndex = 19;
            this.rdoPrice.TabStop = true;
            this.rdoPrice.Text = "Price";
            this.rdoPrice.UseVisualStyleBackColor = true;
            // 
            // rdoPubID
            // 
            this.rdoPubID.AutoSize = true;
            this.rdoPubID.Location = new System.Drawing.Point(6, 53);
            this.rdoPubID.Name = "rdoPubID";
            this.rdoPubID.Size = new System.Drawing.Size(134, 23);
            this.rdoPubID.TabIndex = 18;
            this.rdoPubID.TabStop = true;
            this.rdoPubID.Text = "Publisher\'s ID";
            this.rdoPubID.UseVisualStyleBackColor = true;
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.Transparent;
            this.panelDelete.Controls.Add(this.btnDeleteBook);
            this.panelDelete.Controls.Add(this.lblBookID);
            this.panelDelete.Controls.Add(this.txtDeleteBook);
            this.panelDelete.Location = new System.Drawing.Point(151, 371);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(218, 111);
            this.panelDelete.TabIndex = 32;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteBook.Location = new System.Drawing.Point(15, 18);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(118, 49);
            this.btnDeleteBook.TabIndex = 5;
            this.btnDeleteBook.Text = "Delete book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookID.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblBookID.Location = new System.Drawing.Point(11, 70);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(65, 19);
            this.lblBookID.TabIndex = 6;
            this.lblBookID.Text = "Title ID:";
            // 
            // txtDeleteBook
            // 
            this.txtDeleteBook.Location = new System.Drawing.Point(85, 68);
            this.txtDeleteBook.Name = "txtDeleteBook";
            this.txtDeleteBook.Size = new System.Drawing.Size(100, 22);
            this.txtDeleteBook.TabIndex = 7;
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSort.Controls.Add(this.rdoPubDate);
            this.groupBoxSort.Controls.Add(this.btnSort);
            this.groupBoxSort.Controls.Add(this.rdoPrice);
            this.groupBoxSort.Controls.Add(this.rdoPubID);
            this.groupBoxSort.Controls.Add(this.rdoTitle);
            this.groupBoxSort.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSort.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxSort.Location = new System.Drawing.Point(328, 488);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(200, 192);
            this.groupBoxSort.TabIndex = 28;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Sort by:";
            // 
            // rdoPubDate
            // 
            this.rdoPubDate.AutoSize = true;
            this.rdoPubDate.Location = new System.Drawing.Point(6, 114);
            this.rdoPubDate.Name = "rdoPubDate";
            this.rdoPubDate.Size = new System.Drawing.Size(143, 23);
            this.rdoPubDate.TabIndex = 20;
            this.rdoPubDate.TabStop = true;
            this.rdoPubDate.Text = "Date published";
            this.rdoPubDate.UseVisualStyleBackColor = true;
            // 
            // rdoTitle
            // 
            this.rdoTitle.AutoSize = true;
            this.rdoTitle.Location = new System.Drawing.Point(6, 24);
            this.rdoTitle.Name = "rdoTitle";
            this.rdoTitle.Size = new System.Drawing.Size(64, 23);
            this.rdoTitle.TabIndex = 17;
            this.rdoTitle.TabStop = true;
            this.rdoTitle.Text = "Title";
            this.rdoTitle.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddBook.Location = new System.Drawing.Point(12, 392);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(118, 49);
            this.btnAddBook.TabIndex = 27;
            this.btnAddBook.Text = "Add new book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnExitA
            // 
            this.btnExitA.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExitA.Location = new System.Drawing.Point(968, 647);
            this.btnExitA.Name = "btnExitA";
            this.btnExitA.Size = new System.Drawing.Size(118, 33);
            this.btnExitA.TabIndex = 26;
            this.btnExitA.Text = "Exit";
            this.btnExitA.UseVisualStyleBackColor = true;
            this.btnExitA.Click += new System.EventHandler(this.btnExitA_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.Location = new System.Drawing.Point(968, 584);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(118, 57);
            this.btnHome.TabIndex = 25;
            this.btnHome.Text = "Back to home page";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLoad.Location = new System.Drawing.Point(12, 321);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 33);
            this.btnLoad.TabIndex = 24;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.booksDBDataSet;
            // 
            // booksDBDataSet
            // 
            this.booksDBDataSet.DataSetName = "BooksDBDataSet";
            this.booksDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 295);
            this.dataGridView1.TabIndex = 23;
            // 
            // btnBookAuthorNames
            // 
            this.btnBookAuthorNames.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAuthorNames.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBookAuthorNames.Location = new System.Drawing.Point(751, 404);
            this.btnBookAuthorNames.Name = "btnBookAuthorNames";
            this.btnBookAuthorNames.Size = new System.Drawing.Size(150, 74);
            this.btnBookAuthorNames.TabIndex = 35;
            this.btnBookAuthorNames.Text = "Authors and books (with names)";
            this.btnBookAuthorNames.UseVisualStyleBackColor = true;
            this.btnBookAuthorNames.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBookAuthor
            // 
            this.btnBookAuthor.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAuthor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBookAuthor.Location = new System.Drawing.Point(751, 349);
            this.btnBookAuthor.Name = "btnBookAuthor";
            this.btnBookAuthor.Size = new System.Drawing.Size(150, 49);
            this.btnBookAuthor.TabIndex = 34;
            this.btnBookAuthor.Text = "Authors and books";
            this.btnBookAuthor.UseVisualStyleBackColor = true;
            this.btnBookAuthor.Click += new System.EventHandler(this.btnBookAuthor_Click);
            // 
            // btnYtdInCountry
            // 
            this.btnYtdInCountry.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYtdInCountry.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnYtdInCountry.Location = new System.Drawing.Point(907, 349);
            this.btnYtdInCountry.Name = "btnYtdInCountry";
            this.btnYtdInCountry.Size = new System.Drawing.Size(150, 49);
            this.btnYtdInCountry.TabIndex = 36;
            this.btnYtdInCountry.Text = "YTD Sales in each country";
            this.btnYtdInCountry.UseVisualStyleBackColor = true;
            this.btnYtdInCountry.Click += new System.EventHandler(this.btnYtdInCountry_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BooksDB.Properties.Resources.thought_catalog_o0Qqw21_0NI_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 701);
            this.Controls.Add(this.btnYtdInCountry);
            this.Controls.Add(this.btnBookAuthorNames);
            this.Controls.Add(this.btnBookAuthor);
            this.Controls.Add(this.btnPubData);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnExitA);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPubData;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoID;
        private System.Windows.Forms.RadioButton rdoTitleSearch;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.RadioButton rdoPrice;
        private System.Windows.Forms.RadioButton rdoPubID;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtDeleteBook;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.RadioButton rdoTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnExitA;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLoad;
        private BooksDBDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private BooksDBDataSet booksDBDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdoPubDate;
        private System.Windows.Forms.Button btnBookAuthorNames;
        private System.Windows.Forms.Button btnBookAuthor;
        private System.Windows.Forms.Button btnYtdInCountry;
    }
}