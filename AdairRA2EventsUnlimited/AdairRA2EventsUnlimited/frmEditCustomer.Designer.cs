namespace AdairRA2EventsUnlimited
{
    partial class frmEditCustomer
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
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblErrorSurname = new System.Windows.Forms.Label();
            this.lblErrorFirstname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSecondName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.gbxContact = new System.Windows.Forms.GroupBox();
            this.lblErrorEmail = new System.Windows.Forms.Label();
            this.lblErrorPostcode = new System.Windows.Forms.Label();
            this.lblErrorHome = new System.Windows.Forms.Label();
            this.lblErrorPhone = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxPostCode = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblEdit = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxContact.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(12, 488);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(77, 20);
            this.btnReturn.TabIndex = 31;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(103, 436);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(162, 31);
            this.btnEditCustomer.TabIndex = 28;
            this.btnEditCustomer.Text = "Apply Edit";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblErrorSurname);
            this.groupBox1.Controls.Add(this.lblErrorFirstname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxSecondName);
            this.groupBox1.Controls.Add(this.tbxFirstName);
            this.groupBox1.Location = new System.Drawing.Point(66, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 110);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name (Requires legal name change)";
            // 
            // lblErrorSurname
            // 
            this.lblErrorSurname.AutoSize = true;
            this.lblErrorSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSurname.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSurname.Location = new System.Drawing.Point(233, 69);
            this.lblErrorSurname.Name = "lblErrorSurname";
            this.lblErrorSurname.Size = new System.Drawing.Size(17, 24);
            this.lblErrorSurname.TabIndex = 29;
            this.lblErrorSurname.Text = "*";
            // 
            // lblErrorFirstname
            // 
            this.lblErrorFirstname.AutoSize = true;
            this.lblErrorFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorFirstname.ForeColor = System.Drawing.Color.Red;
            this.lblErrorFirstname.Location = new System.Drawing.Point(233, 32);
            this.lblErrorFirstname.Name = "lblErrorFirstname";
            this.lblErrorFirstname.Size = new System.Drawing.Size(17, 24);
            this.lblErrorFirstname.TabIndex = 28;
            this.lblErrorFirstname.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Second Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "First Name";
            // 
            // tbxSecondName
            // 
            this.tbxSecondName.Location = new System.Drawing.Point(9, 69);
            this.tbxSecondName.Name = "tbxSecondName";
            this.tbxSecondName.Size = new System.Drawing.Size(223, 20);
            this.tbxSecondName.TabIndex = 25;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(9, 32);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(223, 20);
            this.tbxFirstName.TabIndex = 24;
            // 
            // gbxContact
            // 
            this.gbxContact.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxContact.Controls.Add(this.lblErrorEmail);
            this.gbxContact.Controls.Add(this.lblErrorPostcode);
            this.gbxContact.Controls.Add(this.lblErrorHome);
            this.gbxContact.Controls.Add(this.lblErrorPhone);
            this.gbxContact.Controls.Add(this.label7);
            this.gbxContact.Controls.Add(this.tbxPhoneNumber);
            this.gbxContact.Controls.Add(this.label6);
            this.gbxContact.Controls.Add(this.label4);
            this.gbxContact.Controls.Add(this.label5);
            this.gbxContact.Controls.Add(this.tbxAddress);
            this.gbxContact.Controls.Add(this.tbxPostCode);
            this.gbxContact.Controls.Add(this.tbxEmail);
            this.gbxContact.Location = new System.Drawing.Point(66, 206);
            this.gbxContact.Name = "gbxContact";
            this.gbxContact.Size = new System.Drawing.Size(256, 210);
            this.gbxContact.TabIndex = 34;
            this.gbxContact.TabStop = false;
            this.gbxContact.Text = "Contact Information";
            // 
            // lblErrorEmail
            // 
            this.lblErrorEmail.AutoSize = true;
            this.lblErrorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEmail.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmail.Location = new System.Drawing.Point(233, 163);
            this.lblErrorEmail.Name = "lblErrorEmail";
            this.lblErrorEmail.Size = new System.Drawing.Size(17, 24);
            this.lblErrorEmail.TabIndex = 45;
            this.lblErrorEmail.Text = "*";
            // 
            // lblErrorPostcode
            // 
            this.lblErrorPostcode.AutoSize = true;
            this.lblErrorPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPostcode.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPostcode.Location = new System.Drawing.Point(233, 124);
            this.lblErrorPostcode.Name = "lblErrorPostcode";
            this.lblErrorPostcode.Size = new System.Drawing.Size(17, 24);
            this.lblErrorPostcode.TabIndex = 44;
            this.lblErrorPostcode.Text = "*";
            // 
            // lblErrorHome
            // 
            this.lblErrorHome.AutoSize = true;
            this.lblErrorHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHome.ForeColor = System.Drawing.Color.Red;
            this.lblErrorHome.Location = new System.Drawing.Point(233, 87);
            this.lblErrorHome.Name = "lblErrorHome";
            this.lblErrorHome.Size = new System.Drawing.Size(17, 24);
            this.lblErrorHome.TabIndex = 43;
            this.lblErrorHome.Text = "*";
            // 
            // lblErrorPhone
            // 
            this.lblErrorPhone.AutoSize = true;
            this.lblErrorPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPhone.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhone.Location = new System.Drawing.Point(233, 48);
            this.lblErrorPhone.Name = "lblErrorPhone";
            this.lblErrorPhone.Size = new System.Drawing.Size(17, 24);
            this.lblErrorPhone.TabIndex = 42;
            this.lblErrorPhone.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Mobile Number";
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.Location = new System.Drawing.Point(9, 45);
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(223, 20);
            this.tbxPhoneNumber.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Postcode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Home Address";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(9, 87);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(223, 20);
            this.tbxAddress.TabIndex = 35;
            // 
            // tbxPostCode
            // 
            this.tbxPostCode.Location = new System.Drawing.Point(9, 124);
            this.tbxPostCode.Name = "tbxPostCode";
            this.tbxPostCode.Size = new System.Drawing.Size(223, 20);
            this.tbxPostCode.TabIndex = 34;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(9, 163);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(223, 20);
            this.tbxEmail.TabIndex = 33;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEdit.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold);
            this.lblEdit.Location = new System.Drawing.Point(59, 21);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(268, 41);
            this.lblEdit.TabIndex = 35;
            this.lblEdit.Text = "Edit Customer";
            // 
            // frmEditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(393, 522);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.gbxContact);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnEditCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Customer : ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxContact.ResumeLayout(false);
            this.gbxContact.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSecondName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.GroupBox gbxContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxPostCode;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblErrorSurname;
        private System.Windows.Forms.Label lblErrorFirstname;
        private System.Windows.Forms.Label lblErrorEmail;
        private System.Windows.Forms.Label lblErrorPostcode;
        private System.Windows.Forms.Label lblErrorHome;
        private System.Windows.Forms.Label lblErrorPhone;
    }
}