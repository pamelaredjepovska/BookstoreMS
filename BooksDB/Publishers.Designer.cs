namespace BooksDB
{
    partial class Publishers
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
            this.authorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDBDataSet = new BooksDB.BooksDBDataSet();
            this.authorsTableAdapter = new BooksDB.BooksDBDataSetTableAdapters.AuthorsTableAdapter();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.btnExitA = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.rdoPubName = new System.Windows.Forms.RadioButton();
            this.groupBoxSort = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.rdoState = new System.Windows.Forms.RadioButton();
            this.rdoPubID = new System.Windows.Forms.RadioButton();
            this.btnDeletePub = new System.Windows.Forms.Button();
            this.lblPubID = new System.Windows.Forms.Label();
            this.txtDeletePub = new System.Windows.Forms.TextBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.rdoCountrySearch = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.rdoIDSearch = new System.Windows.Forms.RadioButton();
            this.rdoNameSearch = new System.Windows.Forms.RadioButton();
            this.panelDelete = new System.Windows.Forms.Panel();
            this.btnPubInCountry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).BeginInit();
            this.groupBoxSort.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.panelDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 295);
            this.dataGridView1.TabIndex = 34;
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
            // authorsTableAdapter
            // 
            this.authorsTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPublisher.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAddPublisher.Location = new System.Drawing.Point(12, 392);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(118, 49);
            this.btnAddPublisher.TabIndex = 38;
            this.btnAddPublisher.Text = "Add new publisher";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // btnExitA
            // 
            this.btnExitA.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitA.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExitA.Location = new System.Drawing.Point(968, 647);
            this.btnExitA.Name = "btnExitA";
            this.btnExitA.Size = new System.Drawing.Size(118, 33);
            this.btnExitA.TabIndex = 37;
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
            this.btnHome.TabIndex = 36;
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
            this.btnLoad.TabIndex = 35;
            this.btnLoad.Text = "Load data";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // rdoPubName
            // 
            this.rdoPubName.AutoSize = true;
            this.rdoPubName.Location = new System.Drawing.Point(6, 56);
            this.rdoPubName.Name = "rdoPubName";
            this.rdoPubName.Size = new System.Drawing.Size(73, 23);
            this.rdoPubName.TabIndex = 17;
            this.rdoPubName.TabStop = true;
            this.rdoPubName.Text = "Name";
            this.rdoPubName.UseVisualStyleBackColor = true;
            // 
            // groupBoxSort
            // 
            this.groupBoxSort.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSort.Controls.Add(this.btnSort);
            this.groupBoxSort.Controls.Add(this.rdoState);
            this.groupBoxSort.Controls.Add(this.rdoPubID);
            this.groupBoxSort.Controls.Add(this.rdoPubName);
            this.groupBoxSort.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSort.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxSort.Location = new System.Drawing.Point(328, 488);
            this.groupBoxSort.Name = "groupBoxSort";
            this.groupBoxSort.Size = new System.Drawing.Size(200, 153);
            this.groupBoxSort.TabIndex = 39;
            this.groupBoxSort.TabStop = false;
            this.groupBoxSort.Text = "Sort by:";
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSort.Location = new System.Drawing.Point(57, 120);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(83, 33);
            this.btnSort.TabIndex = 9;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // rdoState
            // 
            this.rdoState.AutoSize = true;
            this.rdoState.Location = new System.Drawing.Point(6, 85);
            this.rdoState.Name = "rdoState";
            this.rdoState.Size = new System.Drawing.Size(70, 23);
            this.rdoState.TabIndex = 19;
            this.rdoState.TabStop = true;
            this.rdoState.Text = "State";
            this.rdoState.UseVisualStyleBackColor = true;
            // 
            // rdoPubID
            // 
            this.rdoPubID.AutoSize = true;
            this.rdoPubID.Location = new System.Drawing.Point(6, 24);
            this.rdoPubID.Name = "rdoPubID";
            this.rdoPubID.Size = new System.Drawing.Size(47, 23);
            this.rdoPubID.TabIndex = 18;
            this.rdoPubID.TabStop = true;
            this.rdoPubID.Text = "ID";
            this.rdoPubID.UseVisualStyleBackColor = true;
            // 
            // btnDeletePub
            // 
            this.btnDeletePub.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePub.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnDeletePub.Location = new System.Drawing.Point(15, 18);
            this.btnDeletePub.Name = "btnDeletePub";
            this.btnDeletePub.Size = new System.Drawing.Size(118, 49);
            this.btnDeletePub.TabIndex = 5;
            this.btnDeletePub.Text = "Delete publisher";
            this.btnDeletePub.UseVisualStyleBackColor = true;
            this.btnDeletePub.Click += new System.EventHandler(this.btnDeletePub_Click);
            // 
            // lblPubID
            // 
            this.lblPubID.AutoSize = true;
            this.lblPubID.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPubID.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPubID.Location = new System.Drawing.Point(17, 69);
            this.lblPubID.Name = "lblPubID";
            this.lblPubID.Size = new System.Drawing.Size(100, 19);
            this.lblPubID.TabIndex = 6;
            this.lblPubID.Text = "Publisher ID:";
            // 
            // txtDeletePub
            // 
            this.txtDeletePub.Location = new System.Drawing.Point(127, 67);
            this.txtDeletePub.Name = "txtDeletePub";
            this.txtDeletePub.Size = new System.Drawing.Size(69, 22);
            this.txtDeletePub.TabIndex = 7;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSearch.Controls.Add(this.rdoCountrySearch);
            this.groupBoxSearch.Controls.Add(this.txtSearch);
            this.groupBoxSearch.Controls.Add(this.lblSearch);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.rdoIDSearch);
            this.groupBoxSearch.Controls.Add(this.rdoNameSearch);
            this.groupBoxSearch.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 488);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(284, 192);
            this.groupBoxSearch.TabIndex = 40;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search by:";
            // 
            // rdoCountrySearch
            // 
            this.rdoCountrySearch.AutoSize = true;
            this.rdoCountrySearch.Location = new System.Drawing.Point(6, 82);
            this.rdoCountrySearch.Name = "rdoCountrySearch";
            this.rdoCountrySearch.Size = new System.Drawing.Size(60, 23);
            this.rdoCountrySearch.TabIndex = 21;
            this.rdoCountrySearch.TabStop = true;
            this.rdoCountrySearch.Text = "City";
            this.rdoCountrySearch.UseVisualStyleBackColor = true;
            this.rdoCountrySearch.CheckedChanged += new System.EventHandler(this.rdoCountrySearch_CheckedChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(121, 112);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(151, 25);
            this.txtSearch.TabIndex = 20;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(6, 115);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(103, 19);
            this.lblSearch.TabIndex = 19;
            this.lblSearch.Text = "Enter name:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnSearch.Location = new System.Drawing.Point(83, 146);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // rdoIDSearch
            // 
            this.rdoIDSearch.AutoSize = true;
            this.rdoIDSearch.Location = new System.Drawing.Point(6, 53);
            this.rdoIDSearch.Name = "rdoIDSearch";
            this.rdoIDSearch.Size = new System.Drawing.Size(47, 23);
            this.rdoIDSearch.TabIndex = 18;
            this.rdoIDSearch.TabStop = true;
            this.rdoIDSearch.Text = "ID";
            this.rdoIDSearch.UseVisualStyleBackColor = true;
            this.rdoIDSearch.CheckedChanged += new System.EventHandler(this.rdoIDSearch_CheckedChanged);
            // 
            // rdoNameSearch
            // 
            this.rdoNameSearch.AutoSize = true;
            this.rdoNameSearch.Location = new System.Drawing.Point(6, 24);
            this.rdoNameSearch.Name = "rdoNameSearch";
            this.rdoNameSearch.Size = new System.Drawing.Size(73, 23);
            this.rdoNameSearch.TabIndex = 17;
            this.rdoNameSearch.TabStop = true;
            this.rdoNameSearch.Text = "Name";
            this.rdoNameSearch.UseVisualStyleBackColor = true;
            this.rdoNameSearch.CheckedChanged += new System.EventHandler(this.rdoNameSearch_CheckedChanged);
            // 
            // panelDelete
            // 
            this.panelDelete.BackColor = System.Drawing.Color.Transparent;
            this.panelDelete.Controls.Add(this.btnDeletePub);
            this.panelDelete.Controls.Add(this.lblPubID);
            this.panelDelete.Controls.Add(this.txtDeletePub);
            this.panelDelete.Location = new System.Drawing.Point(151, 371);
            this.panelDelete.Name = "panelDelete";
            this.panelDelete.Size = new System.Drawing.Size(218, 111);
            this.panelDelete.TabIndex = 41;
            // 
            // btnPubInCountry
            // 
            this.btnPubInCountry.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPubInCountry.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnPubInCountry.Location = new System.Drawing.Point(779, 389);
            this.btnPubInCountry.Name = "btnPubInCountry";
            this.btnPubInCountry.Size = new System.Drawing.Size(179, 71);
            this.btnPubInCountry.TabIndex = 42;
            this.btnPubInCountry.Text = "Number of publishers in each country";
            this.btnPubInCountry.UseVisualStyleBackColor = true;
            this.btnPubInCountry.Click += new System.EventHandler(this.btnPubInCountry_Click);
            // 
            // Publishers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BooksDB.Properties.Resources.thought_catalog_o0Qqw21_0NI_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 701);
            this.Controls.Add(this.btnPubInCountry);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddPublisher);
            this.Controls.Add(this.btnExitA);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.groupBoxSort);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.panelDelete);
            this.Name = "Publishers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publishers";
            this.Load += new System.EventHandler(this.Publishers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDBDataSet)).EndInit();
            this.groupBoxSort.ResumeLayout(false);
            this.groupBoxSort.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.panelDelete.ResumeLayout(false);
            this.panelDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource authorsBindingSource;
        private BooksDBDataSet booksDBDataSet;
        private BooksDBDataSetTableAdapters.AuthorsTableAdapter authorsTableAdapter;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.Button btnExitA;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.RadioButton rdoPubName;
        private System.Windows.Forms.GroupBox groupBoxSort;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.RadioButton rdoState;
        private System.Windows.Forms.RadioButton rdoPubID;
        private System.Windows.Forms.Button btnDeletePub;
        private System.Windows.Forms.Label lblPubID;
        private System.Windows.Forms.TextBox txtDeletePub;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdoIDSearch;
        private System.Windows.Forms.RadioButton rdoNameSearch;
        private System.Windows.Forms.Panel panelDelete;
        private System.Windows.Forms.RadioButton rdoCountrySearch;
        private System.Windows.Forms.Button btnPubInCountry;
    }
}