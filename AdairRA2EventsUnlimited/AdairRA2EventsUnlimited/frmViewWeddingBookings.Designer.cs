namespace AdairRA2EventsUnlimited
{
    partial class frmViewWeddingBookings
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.clbWeddings = new System.Windows.Forms.CheckedListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBookingConfirmed = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnViewWeddingDetails = new System.Windows.Forms.Button();
            this.cbViewPrevious = new System.Windows.Forms.CheckBox();
            this.btnBookingReport = new System.Windows.Forms.Button();
            this.msNavigation = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cbxConfirmed = new System.Windows.Forms.CheckBox();
            this.cbxUnconfirmed = new System.Windows.Forms.CheckBox();
            this.gbxShow = new System.Windows.Forms.GroupBox();
            this.btnAppointments = new System.Windows.Forms.Button();
            this.btnNewWedding = new System.Windows.Forms.Button();
            this.gbxSelections = new System.Windows.Forms.GroupBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msNavigation.SuspendLayout();
            this.gbxShow.SuspendLayout();
            this.gbxSelections.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(322, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 28);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Weddings";
            // 
            // clbWeddings
            // 
            this.clbWeddings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbWeddings.FormattingEnabled = true;
            this.clbWeddings.Location = new System.Drawing.Point(17, 135);
            this.clbWeddings.Name = "clbWeddings";
            this.clbWeddings.Size = new System.Drawing.Size(758, 340);
            this.clbWeddings.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCancel.Location = new System.Drawing.Point(28, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 69);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel selected wedding";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBookingConfirmed
            // 
            this.btnBookingConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingConfirmed.Location = new System.Drawing.Point(28, 144);
            this.btnBookingConfirmed.Name = "btnBookingConfirmed";
            this.btnBookingConfirmed.Size = new System.Drawing.Size(142, 69);
            this.btnBookingConfirmed.TabIndex = 17;
            this.btnBookingConfirmed.Text = "Confirm Wedding";
            this.btnBookingConfirmed.UseVisualStyleBackColor = true;
            this.btnBookingConfirmed.Click += new System.EventHandler(this.btnBookingConfirmed_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnReturn.Location = new System.Drawing.Point(17, 566);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(100, 23);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnViewWeddingDetails
            // 
            this.btnViewWeddingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnViewWeddingDetails.Location = new System.Drawing.Point(28, 69);
            this.btnViewWeddingDetails.Name = "btnViewWeddingDetails";
            this.btnViewWeddingDetails.Size = new System.Drawing.Size(142, 69);
            this.btnViewWeddingDetails.TabIndex = 21;
            this.btnViewWeddingDetails.Text = "View quote for selected wedding";
            this.btnViewWeddingDetails.UseVisualStyleBackColor = true;
            this.btnViewWeddingDetails.Click += new System.EventHandler(this.btnViewWeddingDetails_Click);
            // 
            // cbViewPrevious
            // 
            this.cbViewPrevious.AutoSize = true;
            this.cbViewPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cbViewPrevious.Location = new System.Drawing.Point(53, 25);
            this.cbViewPrevious.Name = "cbViewPrevious";
            this.cbViewPrevious.Size = new System.Drawing.Size(155, 28);
            this.cbViewPrevious.TabIndex = 22;
            this.cbViewPrevious.Text = "Past Weddings";
            this.cbViewPrevious.UseVisualStyleBackColor = true;
            this.cbViewPrevious.CheckedChanged += new System.EventHandler(this.cbViewAll_CheckedChanged);
            // 
            // btnBookingReport
            // 
            this.btnBookingReport.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBookingReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnBookingReport.Location = new System.Drawing.Point(17, 481);
            this.btnBookingReport.Name = "btnBookingReport";
            this.btnBookingReport.Size = new System.Drawing.Size(235, 68);
            this.btnBookingReport.TabIndex = 23;
            this.btnBookingReport.Text = "View Report";
            this.btnBookingReport.UseVisualStyleBackColor = false;
            this.btnBookingReport.Click += new System.EventHandler(this.btnReports_Click);
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
            this.msNavigation.Size = new System.Drawing.Size(998, 24);
            this.msNavigation.TabIndex = 47;
            this.msNavigation.Text = "menuStrip2";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // cbxConfirmed
            // 
            this.cbxConfirmed.AutoSize = true;
            this.cbxConfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxConfirmed.Location = new System.Drawing.Point(534, 25);
            this.cbxConfirmed.Name = "cbxConfirmed";
            this.cbxConfirmed.Size = new System.Drawing.Size(199, 28);
            this.cbxConfirmed.TabIndex = 48;
            this.cbxConfirmed.Text = "Confirmed Bookings";
            this.cbxConfirmed.UseVisualStyleBackColor = true;
            this.cbxConfirmed.CheckedChanged += new System.EventHandler(this.cbxConfirmed_CheckedChanged);
            // 
            // cbxUnconfirmed
            // 
            this.cbxUnconfirmed.AutoSize = true;
            this.cbxUnconfirmed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUnconfirmed.Location = new System.Drawing.Point(262, 25);
            this.cbxUnconfirmed.Name = "cbxUnconfirmed";
            this.cbxUnconfirmed.Size = new System.Drawing.Size(220, 28);
            this.cbxUnconfirmed.TabIndex = 49;
            this.cbxUnconfirmed.Text = "Unconfirmed Bookings";
            this.cbxUnconfirmed.UseVisualStyleBackColor = true;
            this.cbxUnconfirmed.CheckedChanged += new System.EventHandler(this.cbxUncomfirmed_CheckedChanged);
            // 
            // gbxShow
            // 
            this.gbxShow.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxShow.Controls.Add(this.cbxUnconfirmed);
            this.gbxShow.Controls.Add(this.cbxConfirmed);
            this.gbxShow.Controls.Add(this.cbViewPrevious);
            this.gbxShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxShow.Location = new System.Drawing.Point(17, 58);
            this.gbxShow.Name = "gbxShow";
            this.gbxShow.Size = new System.Drawing.Size(758, 71);
            this.gbxShow.TabIndex = 50;
            this.gbxShow.TabStop = false;
            this.gbxShow.Text = "Show";
            // 
            // btnAppointments
            // 
            this.btnAppointments.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAppointments.Location = new System.Drawing.Point(515, 481);
            this.btnAppointments.Name = "btnAppointments";
            this.btnAppointments.Size = new System.Drawing.Size(235, 68);
            this.btnAppointments.TabIndex = 51;
            this.btnAppointments.Text = "Initial Appointments";
            this.btnAppointments.UseVisualStyleBackColor = false;
            this.btnAppointments.Click += new System.EventHandler(this.btnAppointments_Click);
            // 
            // btnNewWedding
            // 
            this.btnNewWedding.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNewWedding.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewWedding.Location = new System.Drawing.Point(264, 481);
            this.btnNewWedding.Name = "btnNewWedding";
            this.btnNewWedding.Size = new System.Drawing.Size(235, 68);
            this.btnNewWedding.TabIndex = 50;
            this.btnNewWedding.Text = "Generate New Quote";
            this.btnNewWedding.UseVisualStyleBackColor = false;
            this.btnNewWedding.Click += new System.EventHandler(this.btnNewWedding_Click);
            // 
            // gbxSelections
            // 
            this.gbxSelections.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxSelections.Controls.Add(this.btnViewWeddingDetails);
            this.gbxSelections.Controls.Add(this.btnCancel);
            this.gbxSelections.Controls.Add(this.btnBookingConfirmed);
            this.gbxSelections.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSelections.Location = new System.Drawing.Point(781, 135);
            this.gbxSelections.Name = "gbxSelections";
            this.gbxSelections.Size = new System.Drawing.Size(205, 340);
            this.gbxSelections.TabIndex = 51;
            this.gbxSelections.TabStop = false;
            this.gbxSelections.Text = "Select Wedding and :";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // frmViewWeddingBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(998, 601);
            this.Controls.Add(this.btnBookingReport);
            this.Controls.Add(this.btnNewWedding);
            this.Controls.Add(this.btnAppointments);
            this.Controls.Add(this.gbxSelections);
            this.Controls.Add(this.gbxShow);
            this.Controls.Add(this.msNavigation);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.clbWeddings);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmViewWeddingBookings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weddings";
            this.msNavigation.ResumeLayout(false);
            this.msNavigation.PerformLayout();
            this.gbxShow.ResumeLayout(false);
            this.gbxShow.PerformLayout();
            this.gbxSelections.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckedListBox clbWeddings;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBookingConfirmed;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnViewWeddingDetails;
        private System.Windows.Forms.CheckBox cbViewPrevious;
        private System.Windows.Forms.Button btnBookingReport;
        private System.Windows.Forms.MenuStrip msNavigation;
        private System.Windows.Forms.ToolStripMenuItem weddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookWeddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWeddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCateringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themedPartiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onSiteCateringToolStripMenuItem;
        private System.Windows.Forms.CheckBox cbxConfirmed;
        private System.Windows.Forms.CheckBox cbxUnconfirmed;
        private System.Windows.Forms.GroupBox gbxShow;
        private System.Windows.Forms.Button btnNewWedding;
        private System.Windows.Forms.Button btnAppointments;
        private System.Windows.Forms.GroupBox gbxSelections;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}