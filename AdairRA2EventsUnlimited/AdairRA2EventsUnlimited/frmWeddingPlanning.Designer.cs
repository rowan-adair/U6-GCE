namespace AdairRA2EventsUnlimited
{
    partial class frmWeddingPlanning
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.cbxVenue = new System.Windows.Forms.ComboBox();
            this.cbInvitations = new System.Windows.Forms.CheckBox();
            this.cbFlowers = new System.Windows.Forms.CheckBox();
            this.cbDress = new System.Windows.Forms.CheckBox();
            this.cbSuits = new System.Windows.Forms.CheckBox();
            this.cbWeddingCars = new System.Windows.Forms.CheckBox();
            this.cbTravelArrangement = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblEntertainment = new System.Windows.Forms.Label();
            this.cbxEntertainment = new System.Windows.Forms.ComboBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.cbxMenu = new System.Windows.Forms.ComboBox();
            this.btnEstimate = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblEstimate = new System.Windows.Forms.Label();
            this.cbxCustomerSelect = new System.Windows.Forms.ComboBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.dtpWedding = new System.Windows.Forms.DateTimePicker();
            this.lblDateWedding = new System.Windows.Forms.Label();
            this.nudGuests = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.gbxOtherSelection = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuests)).BeginInit();
            this.gbxDetails.SuspendLayout();
            this.gbxOtherSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(15, 492);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(153, 44);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cbxVenue
            // 
            this.cbxVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVenue.FormattingEnabled = true;
            this.cbxVenue.Location = new System.Drawing.Point(164, 121);
            this.cbxVenue.Name = "cbxVenue";
            this.cbxVenue.Size = new System.Drawing.Size(343, 32);
            this.cbxVenue.TabIndex = 12;
            this.cbxVenue.SelectedIndexChanged += new System.EventHandler(this.cbxVenue_SelectedIndexChanged);
            // 
            // cbInvitations
            // 
            this.cbInvitations.AutoSize = true;
            this.cbInvitations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInvitations.Location = new System.Drawing.Point(27, 38);
            this.cbInvitations.Name = "cbInvitations";
            this.cbInvitations.Size = new System.Drawing.Size(110, 28);
            this.cbInvitations.TabIndex = 13;
            this.cbInvitations.Text = "Invitations";
            this.cbInvitations.UseVisualStyleBackColor = true;
            this.cbInvitations.CheckedChanged += new System.EventHandler(this.cbInvitations_CheckedChanged);
            // 
            // cbFlowers
            // 
            this.cbFlowers.AutoSize = true;
            this.cbFlowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFlowers.Location = new System.Drawing.Point(27, 80);
            this.cbFlowers.Name = "cbFlowers";
            this.cbFlowers.Size = new System.Drawing.Size(96, 28);
            this.cbFlowers.TabIndex = 15;
            this.cbFlowers.Text = "Flowers";
            this.cbFlowers.UseVisualStyleBackColor = true;
            this.cbFlowers.CheckedChanged += new System.EventHandler(this.cbFlowers_CheckedChanged);
            // 
            // cbDress
            // 
            this.cbDress.AutoSize = true;
            this.cbDress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDress.Location = new System.Drawing.Point(27, 214);
            this.cbDress.Name = "cbDress";
            this.cbDress.Size = new System.Drawing.Size(77, 28);
            this.cbDress.TabIndex = 19;
            this.cbDress.Text = "Dress";
            this.cbDress.UseVisualStyleBackColor = true;
            this.cbDress.CheckedChanged += new System.EventHandler(this.cbDress_CheckedChanged);
            // 
            // cbSuits
            // 
            this.cbSuits.AutoSize = true;
            this.cbSuits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSuits.Location = new System.Drawing.Point(27, 258);
            this.cbSuits.Name = "cbSuits";
            this.cbSuits.Size = new System.Drawing.Size(69, 28);
            this.cbSuits.TabIndex = 21;
            this.cbSuits.Text = "Suits";
            this.cbSuits.UseVisualStyleBackColor = true;
            this.cbSuits.CheckedChanged += new System.EventHandler(this.cbSuits_CheckedChanged);
            // 
            // cbWeddingCars
            // 
            this.cbWeddingCars.AutoSize = true;
            this.cbWeddingCars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbWeddingCars.Location = new System.Drawing.Point(27, 121);
            this.cbWeddingCars.Name = "cbWeddingCars";
            this.cbWeddingCars.Size = new System.Drawing.Size(149, 28);
            this.cbWeddingCars.TabIndex = 23;
            this.cbWeddingCars.Text = "Wedding Cars";
            this.cbWeddingCars.UseVisualStyleBackColor = true;
            this.cbWeddingCars.CheckedChanged += new System.EventHandler(this.cbWeddingCars_CheckedChanged);
            // 
            // cbTravelArrangement
            // 
            this.cbTravelArrangement.AutoSize = true;
            this.cbTravelArrangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTravelArrangement.Location = new System.Drawing.Point(27, 166);
            this.cbTravelArrangement.Name = "cbTravelArrangement";
            this.cbTravelArrangement.Size = new System.Drawing.Size(205, 28);
            this.cbTravelArrangement.TabIndex = 25;
            this.cbTravelArrangement.Text = "Travel Arrangements";
            this.cbTravelArrangement.UseVisualStyleBackColor = true;
            this.cbTravelArrangement.CheckedChanged += new System.EventHandler(this.cbTravelArrangement_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(309, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(247, 28);
            this.lblTitle.TabIndex = 31;
            this.lblTitle.Text = "Wedding Planning";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(30, 124);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(67, 24);
            this.lblVenue.TabIndex = 32;
            this.lblVenue.Text = "Venue";
            // 
            // lblEntertainment
            // 
            this.lblEntertainment.AutoSize = true;
            this.lblEntertainment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntertainment.Location = new System.Drawing.Point(30, 169);
            this.lblEntertainment.Name = "lblEntertainment";
            this.lblEntertainment.Size = new System.Drawing.Size(126, 24);
            this.lblEntertainment.TabIndex = 34;
            this.lblEntertainment.Text = "Entertainment";
            // 
            // cbxEntertainment
            // 
            this.cbxEntertainment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEntertainment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxEntertainment.FormattingEnabled = true;
            this.cbxEntertainment.Location = new System.Drawing.Point(164, 166);
            this.cbxEntertainment.Name = "cbxEntertainment";
            this.cbxEntertainment.Size = new System.Drawing.Size(343, 32);
            this.cbxEntertainment.TabIndex = 33;
            this.cbxEntertainment.SelectedIndexChanged += new System.EventHandler(this.cbxEntertainment_SelectedIndexChanged);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(30, 217);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(59, 24);
            this.lblMenu.TabIndex = 36;
            this.lblMenu.Text = "Menu";
            // 
            // cbxMenu
            // 
            this.cbxMenu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMenu.FormattingEnabled = true;
            this.cbxMenu.Location = new System.Drawing.Point(164, 214);
            this.cbxMenu.Name = "cbxMenu";
            this.cbxMenu.Size = new System.Drawing.Size(343, 32);
            this.cbxMenu.TabIndex = 35;
            this.cbxMenu.SelectedIndexChanged += new System.EventHandler(this.cbxMenu_SelectedIndexChanged);
            // 
            // btnEstimate
            // 
            this.btnEstimate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstimate.Location = new System.Drawing.Point(15, 420);
            this.btnEstimate.Name = "btnEstimate";
            this.btnEstimate.Size = new System.Drawing.Size(153, 56);
            this.btnEstimate.TabIndex = 37;
            this.btnEstimate.Text = "Estimate Cost";
            this.btnEstimate.UseVisualStyleBackColor = false;
            this.btnEstimate.Click += new System.EventHandler(this.btnEstimate_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(318, 492);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(238, 44);
            this.btnConfirm.TabIndex = 40;
            this.btnConfirm.Text = "Save Booking";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblEstimate
            // 
            this.lblEstimate.AutoSize = true;
            this.lblEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimate.Location = new System.Drawing.Point(209, 420);
            this.lblEstimate.Name = "lblEstimate";
            this.lblEstimate.Size = new System.Drawing.Size(117, 25);
            this.lblEstimate.TabIndex = 41;
            this.lblEstimate.Text = "lblEstimate";
            // 
            // cbxCustomerSelect
            // 
            this.cbxCustomerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCustomerSelect.FormattingEnabled = true;
            this.cbxCustomerSelect.Location = new System.Drawing.Point(163, 38);
            this.cbxCustomerSelect.Name = "cbxCustomerSelect";
            this.cbxCustomerSelect.Size = new System.Drawing.Size(343, 32);
            this.cbxCustomerSelect.TabIndex = 42;
            this.cbxCustomerSelect.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerSelect_SelectedIndexChanged);
            this.cbxCustomerSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCustomerSelect_KeyPress);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(30, 41);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(91, 24);
            this.lblCustomer.TabIndex = 43;
            this.lblCustomer.Text = "Customer";
            // 
            // dtpWedding
            // 
            this.dtpWedding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWedding.Location = new System.Drawing.Point(164, 80);
            this.dtpWedding.Name = "dtpWedding";
            this.dtpWedding.Size = new System.Drawing.Size(343, 29);
            this.dtpWedding.TabIndex = 44;
            this.dtpWedding.ValueChanged += new System.EventHandler(this.dtpWedding_ValueChanged);
            // 
            // lblDateWedding
            // 
            this.lblDateWedding.AutoSize = true;
            this.lblDateWedding.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateWedding.Location = new System.Drawing.Point(30, 84);
            this.lblDateWedding.Name = "lblDateWedding";
            this.lblDateWedding.Size = new System.Drawing.Size(48, 24);
            this.lblDateWedding.TabIndex = 45;
            this.lblDateWedding.Text = "Date";
            // 
            // nudGuests
            // 
            this.nudGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGuests.Location = new System.Drawing.Point(164, 258);
            this.nudGuests.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudGuests.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudGuests.Name = "nudGuests";
            this.nudGuests.Size = new System.Drawing.Size(343, 29);
            this.nudGuests.TabIndex = 47;
            this.nudGuests.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudGuests.ValueChanged += new System.EventHandler(this.nudGuests_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Guests";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(562, 492);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(238, 44);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Cancel Booking";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(210, 452);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(102, 24);
            this.lblDiscount.TabIndex = 50;
            this.lblDiscount.Text = "lblDiscount";
            // 
            // gbxDetails
            // 
            this.gbxDetails.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxDetails.Controls.Add(this.lblCustomer);
            this.gbxDetails.Controls.Add(this.cbxVenue);
            this.gbxDetails.Controls.Add(this.lblVenue);
            this.gbxDetails.Controls.Add(this.label1);
            this.gbxDetails.Controls.Add(this.cbxEntertainment);
            this.gbxDetails.Controls.Add(this.nudGuests);
            this.gbxDetails.Controls.Add(this.lblEntertainment);
            this.gbxDetails.Controls.Add(this.lblDateWedding);
            this.gbxDetails.Controls.Add(this.cbxMenu);
            this.gbxDetails.Controls.Add(this.dtpWedding);
            this.gbxDetails.Controls.Add(this.lblMenu);
            this.gbxDetails.Controls.Add(this.cbxCustomerSelect);
            this.gbxDetails.Location = new System.Drawing.Point(12, 80);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(544, 323);
            this.gbxDetails.TabIndex = 51;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Main Details";
            // 
            // gbxOtherSelection
            // 
            this.gbxOtherSelection.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxOtherSelection.Controls.Add(this.cbInvitations);
            this.gbxOtherSelection.Controls.Add(this.cbWeddingCars);
            this.gbxOtherSelection.Controls.Add(this.cbFlowers);
            this.gbxOtherSelection.Controls.Add(this.cbTravelArrangement);
            this.gbxOtherSelection.Controls.Add(this.cbDress);
            this.gbxOtherSelection.Controls.Add(this.cbSuits);
            this.gbxOtherSelection.Location = new System.Drawing.Point(562, 80);
            this.gbxOtherSelection.Name = "gbxOtherSelection";
            this.gbxOtherSelection.Size = new System.Drawing.Size(238, 323);
            this.gbxOtherSelection.TabIndex = 52;
            this.gbxOtherSelection.TabStop = false;
            this.gbxOtherSelection.Text = "What else does the customer want?";
            // 
            // frmWeddingPlanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 549);
            this.Controls.Add(this.gbxOtherSelection);
            this.Controls.Add(this.gbxDetails);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblEstimate);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnEstimate);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmWeddingPlanning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.nudGuests)).EndInit();
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            this.gbxOtherSelection.ResumeLayout(false);
            this.gbxOtherSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cbxVenue;
        private System.Windows.Forms.CheckBox cbInvitations;
        private System.Windows.Forms.CheckBox cbFlowers;
        private System.Windows.Forms.CheckBox cbDress;
        private System.Windows.Forms.CheckBox cbSuits;
        private System.Windows.Forms.CheckBox cbWeddingCars;
        private System.Windows.Forms.CheckBox cbTravelArrangement;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblEntertainment;
        private System.Windows.Forms.ComboBox cbxEntertainment;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ComboBox cbxMenu;
        private System.Windows.Forms.Button btnEstimate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblEstimate;
        private System.Windows.Forms.ComboBox cbxCustomerSelect;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.DateTimePicker dtpWedding;
        private System.Windows.Forms.Label lblDateWedding;
        private System.Windows.Forms.NumericUpDown nudGuests;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.GroupBox gbxOtherSelection;
    }
}