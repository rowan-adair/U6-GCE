namespace AdairRA2EventsUnlimited
{
    partial class FrmAddCustomer
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
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lbxExistingCustomers = new System.Windows.Forms.ListBox();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.lblExisting = new System.Windows.Forms.Label();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.lblErrorDateOfBirth = new System.Windows.Forms.Label();
            this.lblErrorGender = new System.Windows.Forms.Label();
            this.lblErrorSecondname = new System.Windows.Forms.Label();
            this.lblErrorFirstname = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.dtpDateBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxSecondName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.gbxContact = new System.Windows.Forms.GroupBox();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorPostcode = new System.Windows.Forms.Label();
            this.lblErrorHome = new System.Windows.Forms.Label();
            this.lblErrorPhone = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblHomeAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxPostCode = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbxDetails.SuspendLayout();
            this.gbxContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(207, 490);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(287, 31);
            this.btnAddCustomer.TabIndex = 8;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnReturn.Location = new System.Drawing.Point(18, 523);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 26);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // lbxExistingCustomers
            // 
            this.lbxExistingCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxExistingCustomers.FormattingEnabled = true;
            this.lbxExistingCustomers.ItemHeight = 18;
            this.lbxExistingCustomers.Location = new System.Drawing.Point(18, 102);
            this.lbxExistingCustomers.Name = "lbxExistingCustomers";
            this.lbxExistingCustomers.Size = new System.Drawing.Size(183, 382);
            this.lbxExistingCustomers.TabIndex = 19;
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCustomer.Location = new System.Drawing.Point(74, 9);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(363, 41);
            this.lblAddCustomer.TabIndex = 20;
            this.lblAddCustomer.Text = "Add New Customer";
            // 
            // lblExisting
            // 
            this.lblExisting.AutoSize = true;
            this.lblExisting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExisting.Location = new System.Drawing.Point(11, 78);
            this.lblExisting.Name = "lblExisting";
            this.lblExisting.Size = new System.Drawing.Size(137, 18);
            this.lblExisting.TabIndex = 21;
            this.lblExisting.Text = "Existing Customers";
            // 
            // gbxDetails
            // 
            this.gbxDetails.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxDetails.Controls.Add(this.lblErrorDateOfBirth);
            this.gbxDetails.Controls.Add(this.lblErrorGender);
            this.gbxDetails.Controls.Add(this.lblErrorSecondname);
            this.gbxDetails.Controls.Add(this.lblErrorFirstname);
            this.gbxDetails.Controls.Add(this.lblGender);
            this.gbxDetails.Controls.Add(this.cbxGender);
            this.gbxDetails.Controls.Add(this.dtpDateBirth);
            this.gbxDetails.Controls.Add(this.lblDOB);
            this.gbxDetails.Controls.Add(this.lblSecondName);
            this.gbxDetails.Controls.Add(this.lblFirstName);
            this.gbxDetails.Controls.Add(this.tbxSecondName);
            this.gbxDetails.Controls.Add(this.tbxFirstName);
            this.gbxDetails.Location = new System.Drawing.Point(207, 78);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(287, 188);
            this.gbxDetails.TabIndex = 23;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Personal Details";
            // 
            // lblErrorDateOfBirth
            // 
            this.lblErrorDateOfBirth.AutoSize = true;
            this.lblErrorDateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDateOfBirth.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDateOfBirth.Location = new System.Drawing.Point(264, 148);
            this.lblErrorDateOfBirth.Name = "lblErrorDateOfBirth";
            this.lblErrorDateOfBirth.Size = new System.Drawing.Size(17, 24);
            this.lblErrorDateOfBirth.TabIndex = 49;
            this.lblErrorDateOfBirth.Text = "*";
            this.lblErrorDateOfBirth.Visible = false;
            // 
            // lblErrorGender
            // 
            this.lblErrorGender.AutoSize = true;
            this.lblErrorGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGender.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGender.Location = new System.Drawing.Point(264, 109);
            this.lblErrorGender.Name = "lblErrorGender";
            this.lblErrorGender.Size = new System.Drawing.Size(17, 24);
            this.lblErrorGender.TabIndex = 48;
            this.lblErrorGender.Text = "*";
            this.lblErrorGender.Visible = false;
            // 
            // lblErrorSecondname
            // 
            this.lblErrorSecondname.AutoSize = true;
            this.lblErrorSecondname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSecondname.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSecondname.Location = new System.Drawing.Point(264, 72);
            this.lblErrorSecondname.Name = "lblErrorSecondname";
            this.lblErrorSecondname.Size = new System.Drawing.Size(17, 24);
            this.lblErrorSecondname.TabIndex = 47;
            this.lblErrorSecondname.Text = "*";
            this.lblErrorSecondname.Visible = false;
            // 
            // lblErrorFirstname
            // 
            this.lblErrorFirstname.AutoSize = true;
            this.lblErrorFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFirstname.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFirstname.Location = new System.Drawing.Point(264, 33);
            this.lblErrorFirstname.Name = "lblErrorFirstname";
            this.lblErrorFirstname.Size = new System.Drawing.Size(17, 24);
            this.lblErrorFirstname.TabIndex = 46;
            this.lblErrorFirstname.Text = "*";
            this.lblErrorFirstname.Visible = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(21, 94);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 26;
            this.lblGender.Text = "Gender";
            // 
            // cbxGender
            // 
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxGender.Location = new System.Drawing.Point(24, 111);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(235, 21);
            this.cbxGender.TabIndex = 2;
            // 
            // dtpDateBirth
            // 
            this.dtpDateBirth.Location = new System.Drawing.Point(24, 152);
            this.dtpDateBirth.Name = "dtpDateBirth";
            this.dtpDateBirth.Size = new System.Drawing.Size(235, 20);
            this.dtpDateBirth.TabIndex = 3;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(21, 136);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(66, 13);
            this.lblDOB.TabIndex = 23;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Location = new System.Drawing.Point(21, 55);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(75, 13);
            this.lblSecondName.TabIndex = 22;
            this.lblSecondName.Text = "Second Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(21, 17);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 21;
            this.lblFirstName.Text = "First Name";
            // 
            // tbxSecondName
            // 
            this.tbxSecondName.Location = new System.Drawing.Point(24, 71);
            this.tbxSecondName.Name = "tbxSecondName";
            this.tbxSecondName.Size = new System.Drawing.Size(235, 20);
            this.tbxSecondName.TabIndex = 1;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(24, 33);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(235, 20);
            this.tbxFirstName.TabIndex = 0;
            // 
            // gbxContact
            // 
            this.gbxContact.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxContact.Controls.Add(this.lblErrorEmail);
            this.gbxContact.Controls.Add(this.lblErrorPostcode);
            this.gbxContact.Controls.Add(this.lblErrorHome);
            this.gbxContact.Controls.Add(this.lblErrorPhone);
            this.gbxContact.Controls.Add(this.lblMobile);
            this.gbxContact.Controls.Add(this.tbxPhoneNumber);
            this.gbxContact.Controls.Add(this.lblEmail);
            this.gbxContact.Controls.Add(this.lblPostCode);
            this.gbxContact.Controls.Add(this.lblHomeAddress);
            this.gbxContact.Controls.Add(this.tbxAddress);
            this.gbxContact.Controls.Add(this.tbxPostCode);
            this.gbxContact.Controls.Add(this.tbxEmail);
            this.gbxContact.Location = new System.Drawing.Point(207, 272);
            this.gbxContact.Name = "gbxContact";
            this.gbxContact.Size = new System.Drawing.Size(287, 212);
            this.gbxContact.TabIndex = 24;
            this.gbxContact.TabStop = false;
            this.gbxContact.Text = "Contact Information";
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(264, 160);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(17, 24);
            this.lblErrorEmail.TabIndex = 49;
            this.lblErrorEmail.Text = "*";
            this.lblErrorEmail.Visible = false;
            // 
            // lblErrorPostcode
            // 
            this.lblErrorPostcode.AutoSize = true;
            this.lblErrorPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPostcode.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPostcode.Location = new System.Drawing.Point(264, 79);
            this.lblErrorPostcode.Name = "lblErrorPostcode";
            this.lblErrorPostcode.Size = new System.Drawing.Size(17, 24);
            this.lblErrorPostcode.TabIndex = 48;
            this.lblErrorPostcode.Text = "*";
            this.lblErrorPostcode.Visible = false;
            // 
            // lblErrorHome
            // 
            this.lblErrorHome.AutoSize = true;
            this.lblErrorHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHome.ForeColor = System.Drawing.Color.Red;
            this.lblErrorHome.Location = new System.Drawing.Point(264, 41);
            this.lblErrorHome.Name = "lblErrorHome";
            this.lblErrorHome.Size = new System.Drawing.Size(17, 24);
            this.lblErrorHome.TabIndex = 47;
            this.lblErrorHome.Text = "*";
            this.lblErrorHome.Visible = false;
            // 
            // lblErrorPhone
            // 
            this.lblErrorPhone.AutoSize = true;
            this.lblErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhone.Location = new System.Drawing.Point(264, 120);
            this.lblErrorPhone.Name = "lblErrorPhone";
            this.lblErrorPhone.Size = new System.Drawing.Size(17, 24);
            this.lblErrorPhone.TabIndex = 46;
            this.lblErrorPhone.Text = "*";
            this.lblErrorPhone.Visible = false;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(15, 104);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(78, 13);
            this.lblMobile.TabIndex = 24;
            this.lblMobile.Text = "Mobile Number";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(18, 120);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(241, 20);
            this.tbxPhoneNumber.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(73, 13);
            this.lblEmail.TabIndex = 22;
            this.lblEmail.Text = "Email Address";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(15, 63);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(52, 13);
            this.lblPostCode.TabIndex = 21;
            this.lblPostCode.Text = "Postcode";
            // 
            // lblHomeAddress
            // 
            this.lblHomeAddress.AutoSize = true;
            this.lblHomeAddress.Location = new System.Drawing.Point(15, 24);
            this.lblHomeAddress.Name = "lblHomeAddress";
            this.lblHomeAddress.Size = new System.Drawing.Size(76, 13);
            this.lblHomeAddress.TabIndex = 20;
            this.lblHomeAddress.Text = "Home Address";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(18, 40);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(241, 20);
            this.tbxAddress.TabIndex = 4;
            // 
            // tbxPostCode
            // 
            this.tbxPostCode.Location = new System.Drawing.Point(18, 79);
            this.tbxPostCode.Name = "tbxPostCode";
            this.tbxPostCode.Size = new System.Drawing.Size(241, 20);
            this.tbxPostCode.TabIndex = 5;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(18, 160);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(241, 20);
            this.tbxEmail.TabIndex = 7;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(90, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(333, 16);
            this.lblInfo.TabIndex = 31;
            this.lblInfo.Text = "Fill out the new customers personal and contact details.";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(504, 561);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.gbxContact);
            this.Controls.Add(this.gbxDetails);
            this.Controls.Add(this.lblExisting);
            this.Controls.Add(this.lblAddCustomer);
            this.Controls.Add(this.lbxExistingCustomers);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            this.gbxContact.ResumeLayout(false);
            this.gbxContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ListBox lbxExistingCustomers;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.Label lblExisting;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.DateTimePicker dtpDateBirth;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxSecondName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.GroupBox gbxContact;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblHomeAddress;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxPostCode;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblErrorDateOfBirth;
        private System.Windows.Forms.Label lblErrorGender;
        private System.Windows.Forms.Label lblErrorSecondname;
        private System.Windows.Forms.Label lblErrorFirstname;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorPostcode;
        private System.Windows.Forms.Label lblErrorHome;
        private System.Windows.Forms.Label lblErrorPhone;
    }
}