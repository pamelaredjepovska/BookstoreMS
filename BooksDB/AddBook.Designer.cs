namespace BooksDB
{
    partial class AddBook
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
            this.btnBackBooks = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblPubDate = new System.Windows.Forms.Label();
            this.trackBarAdvance = new System.Windows.Forms.TrackBar();
            this.lblAdvance = new System.Windows.Forms.Label();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblYtdSales = new System.Windows.Forms.Label();
            this.txtYtdSales = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPubID = new System.Windows.Forms.Label();
            this.txtPubID = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblIDB = new System.Windows.Forms.Label();
            this.txtIDB = new System.Windows.Forms.TextBox();
            this.trackBarRoyalty = new System.Windows.Forms.TrackBar();
            this.lblRoyalty = new System.Windows.Forms.Label();
            this.lblAdvanceAmount = new System.Windows.Forms.Label();
            this.lblRoyaltyAmount = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAdvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoyalty)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBackBooks
            // 
            this.btnBackBooks.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackBooks.Location = new System.Drawing.Point(413, 593);
            this.btnBackBooks.Name = "btnBackBooks";
            this.btnBackBooks.Size = new System.Drawing.Size(95, 59);
            this.btnBackBooks.TabIndex = 51;
            this.btnBackBooks.Text = "Back to books";
            this.btnBackBooks.UseVisualStyleBackColor = true;
            this.btnBackBooks.Click += new System.EventHandler(this.btnBackBooks_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(298, 593);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(98, 59);
            this.btnAddBook.TabIndex = 50;
            this.btnAddBook.Text = "Add new book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "psychology",
            "business",
            "popular_comp",
            "trad_cook",
            "mod_cook",
            "romance",
            "mystery",
            "adventure",
            "UNDECIDED"});
            this.cmbType.Location = new System.Drawing.Point(402, 111);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 49;
            // 
            // lblPubDate
            // 
            this.lblPubDate.AutoSize = true;
            this.lblPubDate.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubDate.Location = new System.Drawing.Point(185, 549);
            this.lblPubDate.Name = "lblPubDate";
            this.lblPubDate.Size = new System.Drawing.Size(107, 19);
            this.lblPubDate.TabIndex = 48;
            this.lblPubDate.Text = "Publish date:";
            // 
            // trackBarAdvance
            // 
            this.trackBarAdvance.LargeChange = 1000;
            this.trackBarAdvance.Location = new System.Drawing.Point(275, 263);
            this.trackBarAdvance.Maximum = 50000;
            this.trackBarAdvance.Minimum = 1000;
            this.trackBarAdvance.Name = "trackBarAdvance";
            this.trackBarAdvance.Size = new System.Drawing.Size(255, 56);
            this.trackBarAdvance.SmallChange = 1000;
            this.trackBarAdvance.TabIndex = 46;
            this.trackBarAdvance.TickFrequency = 1000;
            this.trackBarAdvance.Value = 1000;
            this.trackBarAdvance.Scroll += new System.EventHandler(this.trackBarSalary_Scroll);
            // 
            // lblAdvance
            // 
            this.lblAdvance.AutoSize = true;
            this.lblAdvance.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvance.Location = new System.Drawing.Point(193, 275);
            this.lblAdvance.Name = "lblAdvance";
            this.lblAdvance.Size = new System.Drawing.Size(76, 19);
            this.lblAdvance.TabIndex = 45;
            this.lblAdvance.Text = "Advance:";
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.Location = new System.Drawing.Point(330, 509);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(56, 19);
            this.lblNotes.TabIndex = 41;
            this.lblNotes.Text = "Notes:";
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(402, 506);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(128, 22);
            this.txtNotes.TabIndex = 40;
            // 
            // lblYtdSales
            // 
            this.lblYtdSales.AutoSize = true;
            this.lblYtdSales.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYtdSales.Location = new System.Drawing.Point(236, 465);
            this.lblYtdSales.Name = "lblYtdSales";
            this.lblYtdSales.Size = new System.Drawing.Size(152, 19);
            this.lblYtdSales.TabIndex = 39;
            this.lblYtdSales.Text = "Year-to-date sales:";
            // 
            // txtYtdSales
            // 
            this.txtYtdSales.Location = new System.Drawing.Point(402, 464);
            this.txtYtdSales.Name = "txtYtdSales";
            this.txtYtdSales.Size = new System.Drawing.Size(128, 22);
            this.txtYtdSales.TabIndex = 38;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(334, 218);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 19);
            this.lblPrice.TabIndex = 37;
            this.lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(402, 217);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(128, 22);
            this.txtPrice.TabIndex = 36;
            // 
            // lblPubID
            // 
            this.lblPubID.AutoSize = true;
            this.lblPubID.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPubID.Location = new System.Drawing.Point(206, 165);
            this.lblPubID.Name = "lblPubID";
            this.lblPubID.Size = new System.Drawing.Size(171, 19);
            this.lblPubID.TabIndex = 35;
            this.lblPubID.Text = "Publisher ID (XXXX): ";
            // 
            // txtPubID
            // 
            this.txtPubID.Location = new System.Drawing.Point(402, 165);
            this.txtPubID.Name = "txtPubID";
            this.txtPubID.Size = new System.Drawing.Size(128, 22);
            this.txtPubID.TabIndex = 34;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(338, 114);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(48, 19);
            this.lblType.TabIndex = 33;
            this.lblType.Text = "Type:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(338, 62);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(48, 19);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(402, 61);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(128, 22);
            this.txtTitle.TabIndex = 30;
            // 
            // lblIDB
            // 
            this.lblIDB.AutoSize = true;
            this.lblIDB.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDB.Location = new System.Drawing.Point(262, 13);
            this.lblIDB.Name = "lblIDB";
            this.lblIDB.Size = new System.Drawing.Size(124, 19);
            this.lblIDB.TabIndex = 29;
            this.lblIDB.Text = "ID (ex.TC2345):";
            // 
            // txtIDB
            // 
            this.txtIDB.Location = new System.Drawing.Point(402, 12);
            this.txtIDB.Name = "txtIDB";
            this.txtIDB.Size = new System.Drawing.Size(128, 22);
            this.txtIDB.TabIndex = 28;
            // 
            // trackBarRoyalty
            // 
            this.trackBarRoyalty.LargeChange = 1;
            this.trackBarRoyalty.Location = new System.Drawing.Point(275, 364);
            this.trackBarRoyalty.Maximum = 100;
            this.trackBarRoyalty.Minimum = 10;
            this.trackBarRoyalty.Name = "trackBarRoyalty";
            this.trackBarRoyalty.Size = new System.Drawing.Size(255, 56);
            this.trackBarRoyalty.TabIndex = 53;
            this.trackBarRoyalty.Value = 10;
            this.trackBarRoyalty.Scroll += new System.EventHandler(this.trackBarRoyalty_Scroll);
            // 
            // lblRoyalty
            // 
            this.lblRoyalty.AutoSize = true;
            this.lblRoyalty.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoyalty.Location = new System.Drawing.Point(193, 376);
            this.lblRoyalty.Name = "lblRoyalty";
            this.lblRoyalty.Size = new System.Drawing.Size(69, 19);
            this.lblRoyalty.TabIndex = 52;
            this.lblRoyalty.Text = "Royalty:";
            // 
            // lblAdvanceAmount
            // 
            this.lblAdvanceAmount.AutoSize = true;
            this.lblAdvanceAmount.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvanceAmount.Location = new System.Drawing.Point(472, 322);
            this.lblAdvanceAmount.Name = "lblAdvanceAmount";
            this.lblAdvanceAmount.Size = new System.Drawing.Size(0, 19);
            this.lblAdvanceAmount.TabIndex = 54;
            // 
            // lblRoyaltyAmount
            // 
            this.lblRoyaltyAmount.AutoSize = true;
            this.lblRoyaltyAmount.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoyaltyAmount.Location = new System.Drawing.Point(472, 423);
            this.lblRoyaltyAmount.Name = "lblRoyaltyAmount";
            this.lblRoyaltyAmount.Size = new System.Drawing.Size(0, 19);
            this.lblRoyaltyAmount.TabIndex = 55;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(298, 549);
            this.dateTimePicker1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 22);
            this.dateTimePicker1.TabIndex = 56;
            this.dateTimePicker1.Value = new System.DateTime(2020, 6, 24, 0, 0, 0, 0);
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BooksDB.Properties.Resources._8a4e1e8d6b340da246f22c5fac5b655e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 673);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblRoyaltyAmount);
            this.Controls.Add(this.lblAdvanceAmount);
            this.Controls.Add(this.trackBarRoyalty);
            this.Controls.Add(this.lblRoyalty);
            this.Controls.Add(this.btnBackBooks);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblPubDate);
            this.Controls.Add(this.trackBarAdvance);
            this.Controls.Add(this.lblAdvance);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblYtdSales);
            this.Controls.Add(this.txtYtdSales);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPubID);
            this.Controls.Add(this.txtPubID);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblIDB);
            this.Controls.Add(this.txtIDB);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAdvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRoyalty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackBooks;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblPubDate;
        private System.Windows.Forms.TrackBar trackBarAdvance;
        private System.Windows.Forms.Label lblAdvance;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblYtdSales;
        private System.Windows.Forms.TextBox txtYtdSales;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPubID;
        private System.Windows.Forms.TextBox txtPubID;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblIDB;
        private System.Windows.Forms.TextBox txtIDB;
        private System.Windows.Forms.TrackBar trackBarRoyalty;
        private System.Windows.Forms.Label lblRoyalty;
        private System.Windows.Forms.Label lblAdvanceAmount;
        private System.Windows.Forms.Label lblRoyaltyAmount;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}