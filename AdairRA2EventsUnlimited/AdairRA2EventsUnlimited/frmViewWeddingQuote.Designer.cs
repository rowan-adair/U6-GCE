namespace AdairRA2EventsUnlimited
{
    partial class frmViewWeddingQuote
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
            this.lblWeddingID = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblNumberOfGuests = new System.Windows.Forms.Label();
            this.lbxPlanning = new System.Windows.Forms.ListBox();
            this.lblVenueNo = new System.Windows.Forms.Label();
            this.lblVenueAddress = new System.Windows.Forms.Label();
            this.gbxVenue = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblOverallCost = new System.Windows.Forms.Label();
            this.lblConfirmed = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbxVenue.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWeddingID
            // 
            this.lblWeddingID.AutoSize = true;
            this.lblWeddingID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeddingID.Location = new System.Drawing.Point(12, 9);
            this.lblWeddingID.Name = "lblWeddingID";
            this.lblWeddingID.Size = new System.Drawing.Size(172, 31);
            this.lblWeddingID.TabIndex = 0;
            this.lblWeddingID.Text = "Wedding : 00";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(41, 57);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(379, 25);
            this.lblCustomer.TabIndex = 1;
            this.lblCustomer.Text = "Customer : Forename Surname (0000)";
            // 
            // lblNumberOfGuests
            // 
            this.lblNumberOfGuests.AutoSize = true;
            this.lblNumberOfGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfGuests.Location = new System.Drawing.Point(34, 133);
            this.lblNumberOfGuests.Name = "lblNumberOfGuests";
            this.lblNumberOfGuests.Size = new System.Drawing.Size(123, 24);
            this.lblNumberOfGuests.TabIndex = 4;
            this.lblNumberOfGuests.Text = "Guests : 0000";
            // 
            // lbxPlanning
            // 
            this.lbxPlanning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxPlanning.FormattingEnabled = true;
            this.lbxPlanning.ItemHeight = 20;
            this.lbxPlanning.Location = new System.Drawing.Point(10, 41);
            this.lbxPlanning.Name = "lbxPlanning";
            this.lbxPlanning.Size = new System.Drawing.Size(313, 84);
            this.lbxPlanning.TabIndex = 7;
            // 
            // lblVenueNo
            // 
            this.lblVenueNo.AutoSize = true;
            this.lblVenueNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueNo.Location = new System.Drawing.Point(35, 30);
            this.lblVenueNo.Name = "lblVenueNo";
            this.lblVenueNo.Size = new System.Drawing.Size(251, 20);
            this.lblVenueNo.TabIndex = 8;
            this.lblVenueNo.Text = "Venue Phone: +44XXXXXXXXXX";
            // 
            // lblVenueAddress
            // 
            this.lblVenueAddress.AutoSize = true;
            this.lblVenueAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueAddress.Location = new System.Drawing.Point(35, 53);
            this.lblVenueAddress.Name = "lblVenueAddress";
            this.lblVenueAddress.Size = new System.Drawing.Size(131, 20);
            this.lblVenueAddress.TabIndex = 9;
            this.lblVenueAddress.Text = "Venue Address : ";
            // 
            // gbxVenue
            // 
            this.gbxVenue.Controls.Add(this.lblVenueNo);
            this.gbxVenue.Controls.Add(this.lblVenueAddress);
            this.gbxVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVenue.Location = new System.Drawing.Point(36, 85);
            this.gbxVenue.Name = "gbxVenue";
            this.gbxVenue.Size = new System.Drawing.Size(349, 81);
            this.gbxVenue.TabIndex = 10;
            this.gbxVenue.TabStop = false;
            this.gbxVenue.Text = "Venue : Venue Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbxPlanning);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 149);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other information";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(34, 449);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(349, 66);
            this.btnConfirm.TabIndex = 12;
            this.btnConfirm.Text = "Do you want to confirm this booking?";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblOverallCost
            // 
            this.lblOverallCost.AutoSize = true;
            this.lblOverallCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverallCost.Location = new System.Drawing.Point(35, 40);
            this.lblOverallCost.Name = "lblOverallCost";
            this.lblOverallCost.Size = new System.Drawing.Size(106, 20);
            this.lblOverallCost.TabIndex = 13;
            this.lblOverallCost.Text = "Overall Cost : ";
            // 
            // lblConfirmed
            // 
            this.lblConfirmed.AutoSize = true;
            this.lblConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmed.Location = new System.Drawing.Point(-4, 470);
            this.lblConfirmed.Name = "lblConfirmed";
            this.lblConfirmed.Size = new System.Drawing.Size(417, 25);
            this.lblConfirmed.TabIndex = 14;
            this.lblConfirmed.Text = "This wedding has already been confirmed.";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeposit.Location = new System.Drawing.Point(65, 61);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(76, 20);
            this.lblDeposit.TabIndex = 15;
            this.lblDeposit.Text = "Deposit : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDeposit);
            this.groupBox2.Controls.Add(this.lblOverallCost);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(36, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 97);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Costing";
            // 
            // frmViewWeddingQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(425, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxVenue);
            this.Controls.Add(this.lblNumberOfGuests);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblWeddingID);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblConfirmed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewWeddingQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wedding Details";
            this.gbxVenue.ResumeLayout(false);
            this.gbxVenue.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeddingID;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblNumberOfGuests;
        private System.Windows.Forms.ListBox lbxPlanning;
        private System.Windows.Forms.Label lblVenueNo;
        private System.Windows.Forms.Label lblVenueAddress;
        private System.Windows.Forms.GroupBox gbxVenue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblOverallCost;
        private System.Windows.Forms.Label lblConfirmed;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}