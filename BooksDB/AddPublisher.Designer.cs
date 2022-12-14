namespace BooksDB
{
    partial class AddPublisher
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
            this.btnBackPublishers = new System.Windows.Forms.Button();
            this.btnAddPublisher = new System.Windows.Forms.Button();
            this.txtPubCity = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtPubCountry = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtPubState = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblNameP = new System.Windows.Forms.Label();
            this.txtPubName = new System.Windows.Forms.TextBox();
            this.lblIDP = new System.Windows.Forms.Label();
            this.txtIDP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBackPublishers
            // 
            this.btnBackPublishers.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackPublishers.Location = new System.Drawing.Point(412, 592);
            this.btnBackPublishers.Name = "btnBackPublishers";
            this.btnBackPublishers.Size = new System.Drawing.Size(118, 59);
            this.btnBackPublishers.TabIndex = 75;
            this.btnBackPublishers.Text = "Back to publishers";
            this.btnBackPublishers.UseVisualStyleBackColor = true;
            this.btnBackPublishers.Click += new System.EventHandler(this.btnBackPublishers_Click);
            // 
            // btnAddPublisher
            // 
            this.btnAddPublisher.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPublisher.Location = new System.Drawing.Point(297, 592);
            this.btnAddPublisher.Name = "btnAddPublisher";
            this.btnAddPublisher.Size = new System.Drawing.Size(98, 59);
            this.btnAddPublisher.TabIndex = 74;
            this.btnAddPublisher.Text = "Add new publisher";
            this.btnAddPublisher.UseVisualStyleBackColor = true;
            this.btnAddPublisher.Click += new System.EventHandler(this.btnAddPublisher_Click);
            // 
            // txtPubCity
            // 
            this.txtPubCity.Location = new System.Drawing.Point(402, 228);
            this.txtPubCity.Name = "txtPubCity";
            this.txtPubCity.Size = new System.Drawing.Size(128, 22);
            this.txtPubCity.TabIndex = 66;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(312, 334);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(74, 19);
            this.lblCountry.TabIndex = 65;
            this.lblCountry.Text = "Country:";
            // 
            // txtPubCountry
            // 
            this.txtPubCountry.Location = new System.Drawing.Point(402, 331);
            this.txtPubCountry.Name = "txtPubCountry";
            this.txtPubCountry.Size = new System.Drawing.Size(128, 22);
            this.txtPubCountry.TabIndex = 64;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(274, 279);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(112, 19);
            this.lblState.TabIndex = 63;
            this.lblState.Text = "State (ex.CA):";
            // 
            // txtPubState
            // 
            this.txtPubState.Location = new System.Drawing.Point(402, 279);
            this.txtPubState.Name = "txtPubState";
            this.txtPubState.Size = new System.Drawing.Size(128, 22);
            this.txtPubState.TabIndex = 62;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(338, 228);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(44, 19);
            this.lblCity.TabIndex = 61;
            this.lblCity.Text = "City:";
            // 
            // lblNameP
            // 
            this.lblNameP.AutoSize = true;
            this.lblNameP.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameP.Location = new System.Drawing.Point(254, 178);
            this.lblNameP.Name = "lblNameP";
            this.lblNameP.Size = new System.Drawing.Size(132, 19);
            this.lblNameP.TabIndex = 60;
            this.lblNameP.Text = "Publisher name:";
            // 
            // txtPubName
            // 
            this.txtPubName.Location = new System.Drawing.Point(402, 175);
            this.txtPubName.Name = "txtPubName";
            this.txtPubName.Size = new System.Drawing.Size(128, 22);
            this.txtPubName.TabIndex = 59;
            // 
            // lblIDP
            // 
            this.lblIDP.AutoSize = true;
            this.lblIDP.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDP.Location = new System.Drawing.Point(283, 127);
            this.lblIDP.Name = "lblIDP";
            this.lblIDP.Size = new System.Drawing.Size(104, 19);
            this.lblIDP.TabIndex = 58;
            this.lblIDP.Text = "ID (ex.1111):";
            // 
            // txtIDP
            // 
            this.txtIDP.Location = new System.Drawing.Point(402, 126);
            this.txtIDP.Name = "txtIDP";
            this.txtIDP.Size = new System.Drawing.Size(128, 22);
            this.txtIDP.TabIndex = 57;
            // 
            // AddPublisher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BooksDB.Properties.Resources._8a4e1e8d6b340da246f22c5fac5b655e;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 673);
            this.Controls.Add(this.btnBackPublishers);
            this.Controls.Add(this.btnAddPublisher);
            this.Controls.Add(this.txtPubCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.txtPubCountry);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtPubState);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblNameP);
            this.Controls.Add(this.txtPubName);
            this.Controls.Add(this.lblIDP);
            this.Controls.Add(this.txtIDP);
            this.Name = "AddPublisher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPublisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBackPublishers;
        private System.Windows.Forms.Button btnAddPublisher;
        private System.Windows.Forms.TextBox txtPubCity;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtPubCountry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtPubState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblNameP;
        private System.Windows.Forms.TextBox txtPubName;
        private System.Windows.Forms.Label lblIDP;
        private System.Windows.Forms.TextBox txtIDP;
    }
}