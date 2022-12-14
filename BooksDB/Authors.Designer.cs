namespace BooksDB
{
    partial class Authors
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.booksDBDataSet = new BooksDB.BooksDBDataSet();
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorsTableAdapter = new BooksDB.BooksDBDataSetTableAdapters.AuthorsTableAdapter();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExitA = new System.Windows.Forms.Button();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.lblAuthorID = new System.Windows.Forms.Label();
            this.txtDeleteAuthor = new System.Windows.Forms.TextBox();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.rdoSalary = new System.Windows.Forms.RadioButton();
            this.rdoFirstName = new System.Windows.Forms.RadioButton();
            this.rdoLName = new System.Windows.Forms.RadioButton();
            this.groupBoxShow = new System.Windows.Forms.GroupBox();
            this.rdoShow = new System.Windows.Forms.Button();
            this.rdoUnknown = new System.Windows.Forms.RadioButton();
            this.rdoMaleA = new System.Windows.Forms.RadioButton();
            this.rdoFemaleA = new System.Windows.Forms.RadioButton();
            this.btnShowSalaryGenre = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoID = new System.Windows.Forms.RadioButton();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.btnAuthorsState = new System.Windows.Forms.Button();
            this.btnBookAuthor = new System.Windows.Forms.Button();
            this.btnBookAuthorNames = new System.Windows.Forms.Button();
            this.txtOldID = new System.Windows.Forms.TextBox();
            this.txtNewID = new System.Windows.Forms.TextBox();
            this.btnUpdateA = new System.Windows.Forms.Button();
            this.lblOldID = new System.Windows.Forms.Label();
            this.lblNewID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            this.groupBoxSort.SuspendLayout();
            this.groupBoxShow.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // booksDBDataSet
            // 
            this.booksDBDataSet.DataSetName = "BooksDBDataSet";
            this.booksDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorsBindingSource
            // 
            this.authorsBindingSource.DataMember = "Authors";
            this.authorsBindingSource.DataSource = this.booksDBDataSet;
            // 
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLoad.Location = new System.Drawing.Point(12, 330);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(118, 33);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnHome.Location = new System.Drawing.Point(968, 593);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(118, 57);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Back to home page";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExitA
            // 
            this.btnExitA.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExitA.Location = new System.Drawing.Point(968, 656);
            this.btnExitA.Name = "btnExitA";
            this.btnExitA.Size = new System.Drawing.Size(118, 33);
            this.btnExitA.TabIndex = 3;
            this.btnExitA.Text = "Exit";
            this.btnExitA.UseVisualStyleBackColor = true;
            this.btnExitA.Click += new System.EventHandler(this.btnExitA_Click);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAuthor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddAuthor.Location = new System.Drawing.Point(12, 401);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(118, 49);
            this.btnAddAuthor.TabIndex = 4;
            this.btnAddAuthor.Text = "Add new author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAuthor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(15, 18);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(118, 49);
            this.btnDeleteAuthor.TabIndex = 5;
            this.btnDeleteAuthor.Text = "Delete author";
            this.btnDeleteAuthor.UseVisualStyleBackColor = true;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // lblAuthorID
            // 
            this.lblAuthorID.AutoSize = true;
            this.lblAuthorID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAuthorID.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthorID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAuthorID.Location = new System.Drawing.Point(11, 76);
            this.lblAuthorID.Name = "lblAuthorID";
            this.lblAuthorID.Size = new System.Drawing.Size(81, 19);
            this.lblAuthorID.TabIndex = 6;
            this.lblAuthorID.Text = "Author ID:";
            // 
            // txtDeleteAuthor
            // 
            this.txtDeleteAuthor.Location = new System.Drawing.Point(98, 73);
            this.txtDeleteAuthor.Name = "txtDeleteAuthor";
            this.txtDeleteAuthor.Size = new System.Drawing.Size(100, 22);
            this.txtDeleteAuthor.TabIndex = 7;
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSort.Controls.Add(this.btnSort);
            this.groupBoxSort.Controls.Add(this.rdoSalary);
            this.groupBoxSort.Controls.Add(this.rdoFirstName);
            this.groupBoxSort.Controls.Add(this.rdoLName);
            this.groupBoxSort.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSort.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxSort.Location = new System.Drawing.Point(328, 497);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(200, 153);
            this.groupBoxSort.TabIndex = 8;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Sort by:";
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSort.Location = new System.Drawing.Point(53, 114);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(83, 33);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // rdoSalary
            // 
            this.rdoSalary.AutoSize = true;
            this.rdoSalary.Location = new System.Drawing.Point(6, 85);
            this.rdoSalary.Name = "rdoSalary";
            this.rdoSalary.Size = new System.Drawing.Size(78, 23);
            this.rdoSalary.TabIndex = 19;
            this.rdoSalary.TabStop = true;
            this.rdoSalary.Text = "Salary";
            this.rdoSalary.UseVisualStyleBackColor = true;
            // 
            // rdoFirstName
            // 
            this.rdoFirstName.AutoSize = true;
            this.rdoFirstName.Location = new System.Drawing.Point(6, 53);
            this.rdoFirstName.Name = "rdoFirstName";
            this.rdoFirstName.Size = new System.Drawing.Size(113, 23);
            this.rdoFirstName.TabIndex = 18;
            this.rdoFirstName.TabStop = true;
            this.rdoFirstName.Text = "First name";
            this.rdoFirstName.UseVisualStyleBackColor = true;
            // 
            // rdoLName
            // 
            this.rdoLName.AutoSize = true;
            this.rdoLName.Location = new System.Drawing.Point(6, 24);
            this.rdoLName.Name = "rdoLName";
            this.rdoLName.Size = new System.Drawing.Size(109, 23);
            this.rdoLName.TabIndex = 17;
            this.rdoLName.TabStop = true;
            this.rdoLName.Text = "Last name";
            this.rdoLName.UseVisualStyleBackColor = true;
            // 
            // groupBoxShow
            // 
            this.groupBoxShow.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxShow.Controls.Add(this.rdoShow);
            this.groupBoxShow.Controls.Add(this.rdoUnknown);
            this.groupBoxShow.Controls.Add(this.rdoMaleA);
            this.groupBoxShow.Controls.Add(this.rdoFemaleA);
            this.groupBoxShow.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxShow.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxShow.Location = new System.Drawing.Point(743, 497);
            this.groupBoxShow.Name = "groupBoxShow";
            this.groupBoxShow.Size = new System.Drawing.Size(200, 153);
            this.groupBoxShow.TabIndex = 9;
            this.groupBoxShow.TabStop = false;
            this.groupBoxShow.Text = "Show only:";
            // 
            // rdoShow
            // 
            this.rdoShow.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoShow.ForeColor = System.Drawing.Color.MidnightBlue;
            this.rdoShow.Location = new System.Drawing.Point(53, 114);
            this.rdoShow.Name = "rdoShow";
            this.rdoShow.Size = new System.Drawing.Size(83, 33);
            this.rdoShow.TabIndex = 9;
            this.rdoShow.Text = "Show";
            this.rdoShow.UseVisualStyleBackColor = true;
            this.rdoShow.Click += new System.EventHandler(this.rdoShow_Click);
            // 
            // rdoUnknown
            // 
            this.rdoUnknown.AutoSize = true;
            this.rdoUnknown.Location = new System.Drawing.Point(6, 85);
            this.rdoUnknown.Name = "rdoUnknown";
            this.rdoUnknown.Size = new System.Drawing.Size(101, 23);
            this.rdoUnknown.TabIndex = 19;
            this.rdoUnknown.TabStop = true;
            this.rdoUnknown.Text = "Unknown";
            this.rdoUnknown.UseVisualStyleBackColor = true;
            // 
            // rdoMaleA
            // 
            this.rdoMaleA.AutoSize = true;
            this.rdoMaleA.Location = new System.Drawing.Point(6, 53);
            this.rdoMaleA.Name = "rdoMaleA";
            this.rdoMaleA.Size = new System.Drawing.Size(129, 23);
            this.rdoMaleA.TabIndex = 18;
            this.rdoMaleA.TabStop = true;
            this.rdoMaleA.Text = "Male authors";
            this.rdoMaleA.UseVisualStyleBackColor = true;
            // 
            // rdoFemaleA
            // 
            this.rdoFemaleA.AutoSize = true;
            this.rdoFemaleA.Location = new System.Drawing.Point(6, 24);
            this.rdoFemaleA.Name = "rdoFemaleA";
            this.rdoFemaleA.Size = new System.Drawing.Size(149, 23);
            this.rdoFemaleA.TabIndex = 17;
            this.rdoFemaleA.TabStop = true;
            this.rdoFemaleA.Text = "Female authors";
            this.rdoFemaleA.UseVisualStyleBackColor = true;
            // 
            // btnShowSalaryGenre
            // 
            this.btnShowSalaryGenre.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSalaryGenre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnShowSalaryGenre.Location = new System.Drawing.Point(762, 346);
            this.btnShowSalaryGenre.Name = "btnShowSalaryGenre";
            this.btnShowSalaryGenre.Size = new System.Drawing.Size(150, 49);
            this.btnShowSalaryGenre.TabIndex = 10;
            this.btnShowSalaryGenre.Text = "Show average salary by genre";
            this.btnShowSalaryGenre.UseVisualStyleBackColor = true;
            this.btnShowSalaryGenre.Click += new System.EventHandler(this.btnShowSalaryGenre_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Controls.Add(this.lblSearch);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.rdoID);
            this.groupBoxSearch.Controls.Add(this.rdoName);
            this.groupBoxSearch.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 497);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(256, 153);
            this.groupBoxSearch.TabIndex = 20;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search by:";
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
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Location = new System.Drawing.Point(6, 24);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(73, 23);
            this.rdoName.TabIndex = 17;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "Name";
            this.rdoName.UseVisualStyleBackColor = true;
            this.rdoName.CheckedChanged += new System.EventHandler(this.rdoName_CheckedChanged);
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.Transparent;
            this.panelDelete.Controls.Add(this.btnDeleteAuthor);
            this.panelDelete.Controls.Add(this.lblAuthorID);
            this.panelDelete.Controls.Add(this.txtDeleteAuthor);
            this.panelDelete.Location = new System.Drawing.Point(151, 380);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(218, 111);
            this.panelDelete.TabIndex = 21;
            // 
            // btnAuthorsState
            // 
            this.btnAuthorsState.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthorsState.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAuthorsState.Location = new System.Drawing.Point(762, 401);
            this.btnAuthorsState.Name = "btnAuthorsState";
            this.btnAuthorsState.Size = new System.Drawing.Size(150, 75);
            this.btnAuthorsState.TabIndex = 22;
            this.btnAuthorsState.Text = "Show number of authors in each state";
            this.btnAuthorsState.UseVisualStyleBackColor = true;
            this.btnAuthorsState.Click += new System.EventHandler(this.btnAuthorsState_Click);
            // 
            // btnBookAuthor
            // 
            this.btnBookAuthor.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAuthor.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBookAuthor.Location = new System.Drawing.Point(918, 346);
            this.btnBookAuthor.Name = "btnBookAuthor";
            this.btnBookAuthor.Size = new System.Drawing.Size(150, 49);
            this.btnBookAuthor.TabIndex = 23;
            this.btnBookAuthor.Text = "Authors and books";
            this.btnBookAuthor.UseVisualStyleBackColor = true;
            this.btnBookAuthor.Click += new System.EventHandler(this.btnBookAuthor_Click);
            // 
            // btnBookAuthorNames
            // 
            this.btnBookAuthorNames.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookAuthorNames.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnBookAuthorNames.Location = new System.Drawing.Point(918, 401);
            this.btnBookAuthorNames.Name = "btnBookAuthorNames";
            this.btnBookAuthorNames.Size = new System.Drawing.Size(150, 74);
            this.btnBookAuthorNames.TabIndex = 24;
            this.btnBookAuthorNames.Text = "Authors and books (with names)";
            this.btnBookAuthorNames.UseVisualStyleBackColor = true;
            this.btnBookAuthorNames.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOldID
            // 
            this.txtOldID.Enabled = false;
            this.txtOldID.Location = new System.Drawing.Point(483, 436);
            this.txtOldID.Name = "txtOldID";
            this.txtOldID.Size = new System.Drawing.Size(115, 22);
            this.txtOldID.TabIndex = 8;
            // 
            // txtNewID
            // 
            this.txtNewID.Enabled = false;
            this.txtNewID.Location = new System.Drawing.Point(483, 464);
            this.txtNewID.Name = "txtNewID";
            this.txtNewID.Size = new System.Drawing.Size(115, 22);
            this.txtNewID.TabIndex = 25;
            // 
            // btnUpdateA
            // 
            this.btnUpdateA.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnUpdateA.Location = new System.Drawing.Point(470, 380);
            this.btnUpdateA.Name = "btnUpdateA";
            this.btnUpdateA.Size = new System.Drawing.Size(128, 49);
            this.btnUpdateA.TabIndex = 8;
            this.btnUpdateA.Text = "Update author";
            this.btnUpdateA.UseVisualStyleBackColor = true;
            this.btnUpdateA.Click += new System.EventHandler(this.btnUpdateA_Click);
            // 
            // lblOldID
            // 
            this.lblOldID.AutoSize = true;
            this.lblOldID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOldID.Enabled = false;
            this.lblOldID.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblOldID.Location = new System.Drawing.Point(402, 439);
            this.lblOldID.Name = "lblOldID";
            this.lblOldID.Size = new System.Drawing.Size(58, 19);
            this.lblOldID.TabIndex = 21;
            this.lblOldID.Text = "Old ID:";
            // 
            // lblNewID
            // 
            this.lblNewID.AutoSize = true;
            this.lblNewID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNewID.Enabled = false;
            this.lblNewID.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNewID.Location = new System.Drawing.Point(402, 467);
            this.lblNewID.Name = "lblNewID";
            this.lblNewID.Size = new System.Drawing.Size(62, 19);
            this.lblNewID.TabIndex = 26;
            this.lblNewID.Text = "New ID:";
            // 
            // Authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BooksDB.Properties.Resources.thought_catalog_o0Qqw21_0NI_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 701);
            this.Controls.Add(this.lblNewID);
            this.Controls.Add(this.lblOldID);
            this.Controls.Add(this.btnUpdateA);
            this.Controls.Add(this.txtNewID);
            this.Controls.Add(this.txtOldID);
            this.Controls.Add(this.btnBookAuthorNames);
            this.Controls.Add(this.btnBookAuthor);
            this.Controls.Add(this.btnAuthorsState);
            this.Controls.Add(this.panelDelete);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.btnShowSalaryGenre);
            this.Controls.Add(this.groupBoxShow);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.btnExitA);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Authors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authors";
            this.Load += new System.EventHandler(this.Authors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            this.groupBoxShow.ResumeLayout(false);
            this.groupBoxShow.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BooksDBDataSet booksDBDataSet;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private BooksDBDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnExitA;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Label lblAuthorID;
        private System.Windows.Forms.TextBox txtDeleteAuthor;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.RadioButton rdoSalary;
        private System.Windows.Forms.RadioButton rdoFirstName;
        private System.Windows.Forms.RadioButton rdoLName;
        private System.Windows.Forms.GroupBox groupBoxShow;
        private System.Windows.Forms.Button rdoShow;
        private System.Windows.Forms.RadioButton rdoUnknown;
        private System.Windows.Forms.RadioButton rdoMaleA;
        private System.Windows.Forms.RadioButton rdoFemaleA;
        private System.Windows.Forms.Button btnShowSalaryGenre;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoID;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.Button btnAuthorsState;
        private System.Windows.Forms.Button btnBookAuthor;
        private System.Windows.Forms.Button btnBookAuthorNames;
        private System.Windows.Forms.TextBox txtOldID;
        private System.Windows.Forms.TextBox txtNewID;
        private System.Windows.Forms.Button btnUpdateA;
        private System.Windows.Forms.Label lblOldID;
        private System.Windows.Forms.Label lblNewID;
    }
}