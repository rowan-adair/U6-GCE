namespace AdairRA2EventsUnlimited
{
    partial class frmBookAppointment
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
            this.cbxCustomerSelect = new System.Windows.Forms.ComboBox();
            this.cbxSession = new System.Windows.Forms.ComboBox();
            this.cbxVenue = new System.Windows.Forms.ComboBox();
            this.dtpDateOfAppointment = new System.Windows.Forms.DateTimePicker();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.gbxEventDetails = new System.Windows.Forms.GroupBox();
            this.gbxEventDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 478);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 23);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cbxCustomerSelect
            // 
            this.cbxCustomerSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCustomerSelect.FormattingEnabled = true;
            this.cbxCustomerSelect.Location = new System.Drawing.Point(151, 150);
            this.cbxCustomerSelect.Name = "cbxCustomerSelect";
            this.cbxCustomerSelect.Size = new System.Drawing.Size(278, 32);
            this.cbxCustomerSelect.TabIndex = 14;
            this.cbxCustomerSelect.SelectedIndexChanged += new System.EventHandler(this.cbxCustomerSelect_SelectedIndexChanged);
            this.cbxCustomerSelect.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxCustomerSelect_KeyPress);
            // 
            // cbxSession
            // 
            this.cbxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSession.FormattingEnabled = true;
            this.cbxSession.Location = new System.Drawing.Point(125, 116);
            this.cbxSession.Name = "cbxSession";
            this.cbxSession.Size = new System.Drawing.Size(278, 32);
            this.cbxSession.TabIndex = 17;
            this.cbxSession.SelectedIndexChanged += new System.EventHandler(this.cbxSession_SelectedIndexChanged);
            // 
            // cbxVenue
            // 
            this.cbxVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVenue.FormattingEnabled = true;
            this.cbxVenue.Location = new System.Drawing.Point(126, 20);
            this.cbxVenue.Name = "cbxVenue";
            this.cbxVenue.Size = new System.Drawing.Size(278, 32);
            this.cbxVenue.TabIndex = 18;
            this.cbxVenue.SelectedIndexChanged += new System.EventHandler(this.cbxVenue_SelectedIndexChanged);
            // 
            // dtpDateOfAppointment
            // 
            this.dtpDateOfAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfAppointment.Location = new System.Drawing.Point(126, 70);
            this.dtpDateOfAppointment.Name = "dtpDateOfAppointment";
            this.dtpDateOfAppointment.Size = new System.Drawing.Size(277, 29);
            this.dtpDateOfAppointment.TabIndex = 16;
            this.dtpDateOfAppointment.ValueChanged += new System.EventHandler(this.dtpDateOfAppointment_ValueChanged);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(38, 153);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(91, 24);
            this.lblCustomer.TabIndex = 20;
            this.lblCustomer.Text = "Customer";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(5, 57);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(117, 48);
            this.lblAppDate.TabIndex = 22;
            this.lblAppDate.Text = "Appointment\r\nDate";
            this.lblAppDate.Click += new System.EventHandler(this.lblAppDate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Venue";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(5, 119);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(77, 24);
            this.lblSession.TabIndex = 24;
            this.lblSession.Text = "Session";
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeBooking.Location = new System.Drawing.Point(150, 451);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(277, 33);
            this.btnMakeBooking.TabIndex = 25;
            this.btnMakeBooking.Text = "Book Appointment";
            this.btnMakeBooking.UseVisualStyleBackColor = true;
            this.btnMakeBooking.Click += new System.EventHandler(this.btnMakeBooking_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Location = new System.Drawing.Point(151, 204);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(278, 34);
            this.btnCustomer.TabIndex = 27;
            this.btnCustomer.Text = "Add New Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Enter Customer ID of the Customer you wish to select";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(90, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(321, 28);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Book New Appointment";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(22, 61);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(441, 64);
            this.lblInfo.TabIndex = 30;
            this.lblInfo.Text = "Book a  new appointment for customer. \r\nSelect a wedding venue and date to determ" +
    "ine availability\r\n\r\nIf the customer does not already exist in our system, click " +
    "\"New Customer\"";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbxEventDetails
            // 
            this.gbxEventDetails.Controls.Add(this.label4);
            this.gbxEventDetails.Controls.Add(this.dtpDateOfAppointment);
            this.gbxEventDetails.Controls.Add(this.cbxSession);
            this.gbxEventDetails.Controls.Add(this.cbxVenue);
            this.gbxEventDetails.Controls.Add(this.lblAppDate);
            this.gbxEventDetails.Controls.Add(this.lblSession);
            this.gbxEventDetails.Location = new System.Drawing.Point(25, 265);
            this.gbxEventDetails.Name = "gbxEventDetails";
            this.gbxEventDetails.Size = new System.Drawing.Size(438, 165);
            this.gbxEventDetails.TabIndex = 31;
            this.gbxEventDetails.TabStop = false;
            this.gbxEventDetails.Text = "Appointmen Location, Date and Session";
            // 
            // frmBookAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(484, 513);
            this.Controls.Add(this.gbxEventDetails);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnMakeBooking);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.cbxCustomerSelect);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBookAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book An Appointment";
            this.gbxEventDetails.ResumeLayout(false);
            this.gbxEventDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cbxCustomerSelect;
        private System.Windows.Forms.ComboBox cbxSession;
        private System.Windows.Forms.ComboBox cbxVenue;
        private System.Windows.Forms.DateTimePicker dtpDateOfAppointment;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox gbxEventDetails;
    }
}