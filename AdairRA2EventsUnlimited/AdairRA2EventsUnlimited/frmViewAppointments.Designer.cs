namespace AdairRA2EventsUnlimited
{
    partial class frmViewAppointments
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
            this.lblError = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancelAppointment = new System.Windows.Forms.Button();
            this.clbAppointment = new System.Windows.Forms.CheckedListBox();
            this.dtpDateSelect = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAppointments = new System.Windows.Forms.Label();
            this.chbxAppDate = new System.Windows.Forms.CheckBox();
            this.chbxAppID = new System.Windows.Forms.CheckBox();
            this.tbxAppointmentNo = new System.Windows.Forms.TextBox();
            this.chbxStaff = new System.Windows.Forms.CheckBox();
            this.chbxVenue = new System.Windows.Forms.CheckBox();
            this.cbxVenue = new System.Windows.Forms.ComboBox();
            this.tbxFirstname = new System.Windows.Forms.TextBox();
            this.chbxName = new System.Windows.Forms.CheckBox();
            this.cbxStaff = new System.Windows.Forms.ComboBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.msNavigation = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weddingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookWeddingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewWeddingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basicCateringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themedPartiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onSiteCateringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAppointmentChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chbxPrevApp = new System.Windows.Forms.CheckBox();
            this.msNavigation.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(971, 255);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(112, 26);
            this.lblError.TabIndex = 17;
            this.lblError.Text = "Please select an \r\nappointment to cancel";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnReturn.Location = new System.Drawing.Point(12, 578);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(195, 37);
            this.btnReturn.TabIndex = 16;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnCancelAppointment
            // 
            this.btnCancelAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancelAppointment.Location = new System.Drawing.Point(971, 222);
            this.btnCancelAppointment.Name = "btnCancelAppointment";
            this.btnCancelAppointment.Size = new System.Drawing.Size(112, 30);
            this.btnCancelAppointment.TabIndex = 15;
            this.btnCancelAppointment.Text = "Cancel";
            this.btnCancelAppointment.UseVisualStyleBackColor = true;
            this.btnCancelAppointment.Click += new System.EventHandler(this.btnDelAppointment_Click);
            // 
            // clbAppointment
            // 
            this.clbAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAppointment.FormattingEnabled = true;
            this.clbAppointment.Location = new System.Drawing.Point(12, 132);
            this.clbAppointment.Name = "clbAppointment";
            this.clbAppointment.Size = new System.Drawing.Size(953, 194);
            this.clbAppointment.TabIndex = 13;
            // 
            // dtpDateSelect
            // 
            this.dtpDateSelect.Location = new System.Drawing.Point(187, 80);
            this.dtpDateSelect.Name = "dtpDateSelect";
            this.dtpDateSelect.Size = new System.Drawing.Size(300, 26);
            this.dtpDateSelect.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(187, 161);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(740, 27);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAppointments
            // 
            this.lblAppointments.AutoSize = true;
            this.lblAppointments.Font = new System.Drawing.Font("Magneto", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointments.Location = new System.Drawing.Point(371, 41);
            this.lblAppointments.Name = "lblAppointments";
            this.lblAppointments.Size = new System.Drawing.Size(307, 45);
            this.lblAppointments.TabIndex = 20;
            this.lblAppointments.Text = "Appointments";
            // 
            // chbxAppDate
            // 
            this.chbxAppDate.AutoSize = true;
            this.chbxAppDate.Location = new System.Drawing.Point(23, 82);
            this.chbxAppDate.Name = "chbxAppDate";
            this.chbxAppDate.Size = new System.Drawing.Size(158, 24);
            this.chbxAppDate.TabIndex = 21;
            this.chbxAppDate.Text = "Appointment Date";
            this.chbxAppDate.UseVisualStyleBackColor = true;
            this.chbxAppDate.CheckedChanged += new System.EventHandler(this.chbxAppDate_CheckedChanged);
            // 
            // chbxAppID
            // 
            this.chbxAppID.AutoSize = true;
            this.chbxAppID.Location = new System.Drawing.Point(23, 123);
            this.chbxAppID.Name = "chbxAppID";
            this.chbxAppID.Size = new System.Drawing.Size(147, 24);
            this.chbxAppID.TabIndex = 22;
            this.chbxAppID.Text = "Appointment No.";
            this.chbxAppID.UseVisualStyleBackColor = true;
            this.chbxAppID.CheckedChanged += new System.EventHandler(this.chbxAppID_CheckedChanged);
            // 
            // tbxAppointmentNo
            // 
            this.tbxAppointmentNo.Location = new System.Drawing.Point(187, 123);
            this.tbxAppointmentNo.Name = "tbxAppointmentNo";
            this.tbxAppointmentNo.Size = new System.Drawing.Size(300, 26);
            this.tbxAppointmentNo.TabIndex = 23;
            this.tbxAppointmentNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxAppointmentNo_KeyPress);
            // 
            // chbxStaff
            // 
            this.chbxStaff.AutoSize = true;
            this.chbxStaff.Location = new System.Drawing.Point(526, 123);
            this.chbxStaff.Name = "chbxStaff";
            this.chbxStaff.Size = new System.Drawing.Size(63, 24);
            this.chbxStaff.TabIndex = 24;
            this.chbxStaff.Text = "Staff";
            this.chbxStaff.UseVisualStyleBackColor = true;
            this.chbxStaff.CheckedChanged += new System.EventHandler(this.chbxStaff_CheckedChanged);
            // 
            // chbxVenue
            // 
            this.chbxVenue.AutoSize = true;
            this.chbxVenue.Location = new System.Drawing.Point(526, 82);
            this.chbxVenue.Name = "chbxVenue";
            this.chbxVenue.Size = new System.Drawing.Size(75, 24);
            this.chbxVenue.TabIndex = 25;
            this.chbxVenue.Text = "Venue";
            this.chbxVenue.UseVisualStyleBackColor = true;
            this.chbxVenue.CheckedChanged += new System.EventHandler(this.chbxVenue_CheckedChanged);
            // 
            // cbxVenue
            // 
            this.cbxVenue.FormattingEnabled = true;
            this.cbxVenue.Location = new System.Drawing.Point(627, 80);
            this.cbxVenue.Name = "cbxVenue";
            this.cbxVenue.Size = new System.Drawing.Size(300, 28);
            this.cbxVenue.TabIndex = 28;
            // 
            // tbxFirstname
            // 
            this.tbxFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFirstname.Location = new System.Drawing.Point(187, 41);
            this.tbxFirstname.Name = "tbxFirstname";
            this.tbxFirstname.Size = new System.Drawing.Size(740, 26);
            this.tbxFirstname.TabIndex = 29;
            // 
            // chbxName
            // 
            this.chbxName.AutoSize = true;
            this.chbxName.Location = new System.Drawing.Point(23, 43);
            this.chbxName.Name = "chbxName";
            this.chbxName.Size = new System.Drawing.Size(143, 24);
            this.chbxName.TabIndex = 31;
            this.chbxName.Text = "Customer Name";
            this.chbxName.UseVisualStyleBackColor = true;
            this.chbxName.CheckedChanged += new System.EventHandler(this.chbxName_CheckedChanged);
            // 
            // cbxStaff
            // 
            this.cbxStaff.FormattingEnabled = true;
            this.cbxStaff.Location = new System.Drawing.Point(627, 121);
            this.cbxStaff.Name = "cbxStaff";
            this.cbxStaff.Size = new System.Drawing.Size(300, 28);
            this.cbxStaff.TabIndex = 33;
            // 
            // btnBook
            // 
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBook.Location = new System.Drawing.Point(974, 132);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(109, 74);
            this.btnBook.TabIndex = 34;
            this.btnBook.Text = "Book \r\nNew \r\nAppointment";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // msNavigation
            // 
            this.msNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.weddingsToolStripMenuItem,
            this.basicCateringToolStripMenuItem,
            this.themedPartiesToolStripMenuItem,
            this.onSiteCateringToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.msNavigation.Location = new System.Drawing.Point(0, 0);
            this.msNavigation.Name = "msNavigation";
            this.msNavigation.Size = new System.Drawing.Size(1095, 24);
            this.msNavigation.TabIndex = 46;
            this.msNavigation.Text = "menuStrip2";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // weddingsToolStripMenuItem
            // 
            this.weddingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeAppointmentsToolStripMenuItem,
            this.viewAppointmentsToolStripMenuItem,
            this.bookWeddingsToolStripMenuItem,
            this.viewWeddingsToolStripMenuItem});
            this.weddingsToolStripMenuItem.Name = "weddingsToolStripMenuItem";
            this.weddingsToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.weddingsToolStripMenuItem.Text = "Weddings";
            // 
            // makeAppointmentsToolStripMenuItem
            // 
            this.makeAppointmentsToolStripMenuItem.Name = "makeAppointmentsToolStripMenuItem";
            this.makeAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.makeAppointmentsToolStripMenuItem.Text = "Make Appointments";
            this.makeAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.makeAppointmentsToolStripMenuItem_Click);
            // 
            // viewAppointmentsToolStripMenuItem
            // 
            this.viewAppointmentsToolStripMenuItem.Name = "viewAppointmentsToolStripMenuItem";
            this.viewAppointmentsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.viewAppointmentsToolStripMenuItem.Text = "View Appointments";
            this.viewAppointmentsToolStripMenuItem.Click += new System.EventHandler(this.viewAppointmentsToolStripMenuItem_Click);
            // 
            // bookWeddingsToolStripMenuItem
            // 
            this.bookWeddingsToolStripMenuItem.Name = "bookWeddingsToolStripMenuItem";
            this.bookWeddingsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.bookWeddingsToolStripMenuItem.Text = "Book Weddings";
            this.bookWeddingsToolStripMenuItem.Click += new System.EventHandler(this.bookWeddingsToolStripMenuItem_Click);
            // 
            // viewWeddingsToolStripMenuItem
            // 
            this.viewWeddingsToolStripMenuItem.Name = "viewWeddingsToolStripMenuItem";
            this.viewWeddingsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.viewWeddingsToolStripMenuItem.Text = "View Weddings";
            this.viewWeddingsToolStripMenuItem.Click += new System.EventHandler(this.viewWeddingsToolStripMenuItem_Click);
            // 
            // basicCateringToolStripMenuItem
            // 
            this.basicCateringToolStripMenuItem.Name = "basicCateringToolStripMenuItem";
            this.basicCateringToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.basicCateringToolStripMenuItem.Text = "Basic Catering";
            // 
            // themedPartiesToolStripMenuItem
            // 
            this.themedPartiesToolStripMenuItem.Name = "themedPartiesToolStripMenuItem";
            this.themedPartiesToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.themedPartiesToolStripMenuItem.Text = "Themed Parties";
            // 
            // onSiteCateringToolStripMenuItem
            // 
            this.onSiteCateringToolStripMenuItem.Name = "onSiteCateringToolStripMenuItem";
            this.onSiteCateringToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.onSiteCateringToolStripMenuItem.Text = "On-Site Catering";
            // 
            // staffToolStripMenuItem
            // 
            this.staffToolStripMenuItem.Name = "staffToolStripMenuItem";
            this.staffToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.staffToolStripMenuItem.Text = "Staff";
            this.staffToolStripMenuItem.Click += new System.EventHandler(this.staffToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem,
            this.viewCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // viewCustomerToolStripMenuItem
            // 
            this.viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            this.viewCustomerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.viewCustomerToolStripMenuItem.Text = "View Customer";
            this.viewCustomerToolStripMenuItem.Click += new System.EventHandler(this.viewCustomerToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox1.Controls.Add(this.chbxName);
            this.groupBox1.Controls.Add(this.dtpDateSelect);
            this.groupBox1.Controls.Add(this.chbxAppDate);
            this.groupBox1.Controls.Add(this.cbxStaff);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.chbxAppID);
            this.groupBox1.Controls.Add(this.tbxAppointmentNo);
            this.groupBox1.Controls.Add(this.tbxFirstname);
            this.groupBox1.Controls.Add(this.chbxStaff);
            this.groupBox1.Controls.Add(this.cbxVenue);
            this.groupBox1.Controls.Add(this.chbxVenue);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 194);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a search method to use and search appointments.";
            // 
            // btnAppointmentChange
            // 
            this.btnAppointmentChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAppointmentChange.Location = new System.Drawing.Point(971, 286);
            this.btnAppointmentChange.Name = "btnAppointmentChange";
            this.btnAppointmentChange.Size = new System.Drawing.Size(112, 30);
            this.btnAppointmentChange.TabIndex = 48;
            this.btnAppointmentChange.Text = "Change Date";
            this.btnAppointmentChange.UseVisualStyleBackColor = true;
            this.btnAppointmentChange.Click += new System.EventHandler(this.btnAppointmentChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(971, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 26);
            this.label2.TabIndex = 50;
            this.label2.Text = "Please select a\r\ndate to change";
            // 
            // chbxPrevApp
            // 
            this.chbxPrevApp.AutoSize = true;
            this.chbxPrevApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxPrevApp.Location = new System.Drawing.Point(747, 98);
            this.chbxPrevApp.Name = "chbxPrevApp";
            this.chbxPrevApp.Size = new System.Drawing.Size(218, 28);
            this.chbxPrevApp.TabIndex = 51;
            this.chbxPrevApp.Text = "View All Appointments";
            this.chbxPrevApp.UseVisualStyleBackColor = true;
            this.chbxPrevApp.CheckedChanged += new System.EventHandler(this.chbxPrevApp_CheckedChanged);
            // 
            // frmViewAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1095, 645);
            this.Controls.Add(this.chbxPrevApp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAppointmentChange);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msNavigation);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lblAppointments);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCancelAppointment);
            this.Controls.Add(this.clbAppointment);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments ";
            this.msNavigation.ResumeLayout(false);
            this.msNavigation.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.CheckedListBox clbAppointment;
        private System.Windows.Forms.DateTimePicker dtpDateSelect;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAppointments;
        private System.Windows.Forms.CheckBox chbxAppDate;
        private System.Windows.Forms.CheckBox chbxAppID;
        private System.Windows.Forms.TextBox tbxAppointmentNo;
        private System.Windows.Forms.CheckBox chbxStaff;
        private System.Windows.Forms.CheckBox chbxVenue;
        private System.Windows.Forms.ComboBox cbxVenue;
        private System.Windows.Forms.TextBox tbxFirstname;
        private System.Windows.Forms.CheckBox chbxName;
        private System.Windows.Forms.ComboBox cbxStaff;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.MenuStrip msNavigation;
        private System.Windows.Forms.ToolStripMenuItem weddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookWeddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWeddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCateringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themedPartiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onSiteCateringToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAppointmentChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbxPrevApp;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}