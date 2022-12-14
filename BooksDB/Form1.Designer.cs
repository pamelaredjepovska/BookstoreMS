namespace BooksDB
{
    partial class Form1
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAuthors = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.btnPublishers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Brush Script MT", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblWelcome.Location = new System.Drawing.Point(320, 75);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(428, 164);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAuthors
            // 
            this.btnAuthors.BackColor = System.Drawing.SystemColors.Control;
            this.btnAuthors.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthors.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAuthors.Location = new System.Drawing.Point(185, 518);
            this.btnAuthors.Name = "btnAuthors";
            this.btnAuthors.Size = new System.Drawing.Size(143, 49);
            this.btnAuthors.TabIndex = 1;
            this.btnAuthors.Text = "Authors";
            this.btnAuthors.UseVisualStyleBackColor = false;
            this.btnAuthors.Click += new System.EventHandler(this.btnAuthors_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackColor = System.Drawing.SystemColors.Control;
            this.btnBooks.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooks.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBooks.Location = new System.Drawing.Point(470, 518);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(143, 49);
            this.btnBooks.TabIndex = 2;
            this.btnBooks.Text = "Books";
            this.btnBooks.UseVisualStyleBackColor = false;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // btnPublishers
            // 
            this.btnPublishers.BackColor = System.Drawing.SystemColors.Menu;
            this.btnPublishers.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublishers.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPublishers.Location = new System.Drawing.Point(737, 518);
            this.btnPublishers.Name = "btnPublishers";
            this.btnPublishers.Size = new System.Drawing.Size(143, 49);
            this.btnPublishers.TabIndex = 3;
            this.btnPublishers.Text = "Publishers";
            this.btnPublishers.UseVisualStyleBackColor = false;
            this.btnPublishers.Click += new System.EventHandler(this.btnPublishers_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Menu;
            this.btnExit.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnExit.Location = new System.Drawing.Point(923, 622);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 49);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.BackColor = System.Drawing.Color.Transparent;
            this.lblCreatedBy.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblCreatedBy.Location = new System.Drawing.Point(12, 663);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(369, 29);
            this.lblCreatedBy.TabIndex = 5;
            this.lblCreatedBy.Text = "Created by: Pamela Redjepovska, 102283";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BooksDB.Properties.Resources.thought_catalog_o0Qqw21_0NI_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1098, 701);
            this.Controls.Add(this.lblCreatedBy);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPublishers);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.btnAuthors);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooksDB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAuthors;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Button btnPublishers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCreatedBy;
    }
}

