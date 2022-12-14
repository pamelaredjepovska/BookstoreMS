namespace BooksDB
{
    partial class UpdateAuthor
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
            this.lblNewData = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNewData = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBackA = new System.Windows.Forms.Button();
            this.cmbUpdate = new System.Windows.Forms.ComboBox();
            this.lblUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNewData
            // 
            this.lblNewData.AutoSize = true;
            this.lblNewData.BackColor = System.Drawing.SystemColors.Control;
            this.lblNewData.Enabled = false;
            this.lblNewData.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewData.ForeColor = System.Drawing.Color.Black;
            this.lblNewData.Location = new System.Drawing.Point(243, 177);
            this.lblNewData.Name = "lblNewData";
            this.lblNewData.Size = new System.Drawing.Size(0, 19);
            this.lblNewData.TabIndex = 31;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.SystemColors.Control;
            this.lblID.Enabled = false;
            this.lblID.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(312, 147);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(91, 19);
            this.lblID.TabIndex = 29;
            this.lblID.Text = "Author\'s ID:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(297, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 51);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNewData
            // 
            this.txtNewData.Enabled = false;
            this.txtNewData.Location = new System.Drawing.Point(417, 172);
            this.txtNewData.Name = "txtNewData";
            this.txtNewData.Size = new System.Drawing.Size(121, 22);
            this.txtNewData.TabIndex = 30;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(417, 144);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 22);
            this.txtID.TabIndex = 28;
            // 
            // btnBackA
            // 
            this.btnBackA.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackA.Location = new System.Drawing.Point(430, 242);
            this.btnBackA.Name = "btnBackA";
            this.btnBackA.Size = new System.Drawing.Size(106, 51);
            this.btnBackA.TabIndex = 32;
            this.btnBackA.Text = "Back to Authors";
            this.btnBackA.UseVisualStyleBackColor = true;
            this.btnBackA.Click += new System.EventHandler(this.btnBackA_Click);
            // 
            // cmbUpdate
            // 
            this.cmbUpdate.FormattingEnabled = true;
            this.cmbUpdate.Items.AddRange(new object[] {
            "first name",
            "last name",
            "state",
            "city",
            "zip",
            "sex",
            "salary",
            "subject"});
            this.cmbUpdate.Location = new System.Drawing.Point(394, 86);
            this.cmbUpdate.Name = "cmbUpdate";
            this.cmbUpdate.Size = new System.Drawing.Size(121, 24);
            this.cmbUpdate.TabIndex = 33;
            this.cmbUpdate.SelectedIndexChanged += new System.EventHandler(this.cmbUpdate_SelectedIndexChanged);
            // 
            // lblUpdate
            // 
            this.lblUpdate.AutoSize = true;
            this.lblUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.lblUpdate.Enabled = false;
            this.lblUpdate.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdate.ForeColor = System.Drawing.Color.Black;
            this.lblUpdate.Location = new System.Drawing.Point(314, 88);
            this.lblUpdate.Name = "lblUpdate";
            this.lblUpdate.Size = new System.Drawing.Size(61, 19);
            this.lblUpdate.TabIndex = 34;
            this.lblUpdate.Text = "Update:";
            // 
            // UpdateAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BooksDB.Properties.Resources.james_pond_Z0uzZSM5i4M_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(576, 336);
            this.Controls.Add(this.lblUpdate);
            this.Controls.Add(this.cmbUpdate);
            this.Controls.Add(this.btnBackA);
            this.Controls.Add(this.lblNewData);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewData);
            this.Controls.Add(this.txtID);
            this.Name = "UpdateAuthor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAuthor";
            this.Load += new System.EventHandler(this.UpdateAuthor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNewData;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNewData;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBackA;
        private System.Windows.Forms.ComboBox cmbUpdate;
        private System.Windows.Forms.Label lblUpdate;
    }
}