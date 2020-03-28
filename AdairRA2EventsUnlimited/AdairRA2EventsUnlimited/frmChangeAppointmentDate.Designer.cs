namespace AdairRA2EventsUnlimited
{
    partial class frmChangeAppointmentDate
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
            this.btnUpdateAppointment = new System.Windows.Forms.Button();
            this.lblSession = new System.Windows.Forms.Label();
            this.lblAppDate = new System.Windows.Forms.Label();
            this.cbxSession = new System.Windows.Forms.ComboBox();
            this.dtpDateOfAppointment = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbxInfo = new System.Windows.Forms.GroupBox();
            this.gbxInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateAppointment
            // 
            this.btnUpdateAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAppointment.Location = new System.Drawing.Point(87, 301);
            this.btnUpdateAppointment.Name = "btnUpdateAppointment";
            this.btnUpdateAppointment.Size = new System.Drawing.Size(403, 52);
            this.btnUpdateAppointment.TabIndex = 31;
            this.btnUpdateAppointment.Text = "Update Appointment Date and Session";
            this.btnUpdateAppointment.UseVisualStyleBackColor = true;
            this.btnUpdateAppointment.Click += new System.EventHandler(this.btnUpdateAppointment_Click);
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSession.Location = new System.Drawing.Point(97, 153);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(101, 25);
            this.lblSession.TabIndex = 30;
            this.lblSession.Text = "Session :";
            // 
            // lblAppDate
            // 
            this.lblAppDate.AutoSize = true;
            this.lblAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.Location = new System.Drawing.Point(3, 84);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(195, 25);
            this.lblAppDate.TabIndex = 29;
            this.lblAppDate.Text = "Appointment Date :";
            // 
            // cbxSession
            // 
            this.cbxSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSession.FormattingEnabled = true;
            this.cbxSession.Location = new System.Drawing.Point(194, 150);
            this.cbxSession.Name = "cbxSession";
            this.cbxSession.Size = new System.Drawing.Size(352, 33);
            this.cbxSession.TabIndex = 28;
            this.cbxSession.SelectedIndexChanged += new System.EventHandler(this.cbxSession_SelectedIndexChanged);
            // 
            // dtpDateOfAppointment
            // 
            this.dtpDateOfAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfAppointment.Location = new System.Drawing.Point(194, 84);
            this.dtpDateOfAppointment.Name = "dtpDateOfAppointment";
            this.dtpDateOfAppointment.Size = new System.Drawing.Size(352, 31);
            this.dtpDateOfAppointment.TabIndex = 27;
            this.dtpDateOfAppointment.ValueChanged += new System.EventHandler(this.dtpDateOfAppointment_ValueChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnReturn.Location = new System.Drawing.Point(12, 359);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 24);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(26, 38);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(377, 25);
            this.lblInfo.TabIndex = 32;
            this.lblInfo.Text = "Meeting at VENUE for CUSTOMER";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(38, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(506, 28);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "Change Appointment Date or Session";
            // 
            // gbxInfo
            // 
            this.gbxInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxInfo.Controls.Add(this.lblInfo);
            this.gbxInfo.Controls.Add(this.dtpDateOfAppointment);
            this.gbxInfo.Controls.Add(this.cbxSession);
            this.gbxInfo.Controls.Add(this.lblAppDate);
            this.gbxInfo.Controls.Add(this.lblSession);
            this.gbxInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxInfo.Location = new System.Drawing.Point(12, 70);
            this.gbxInfo.Name = "gbxInfo";
            this.gbxInfo.Size = new System.Drawing.Size(564, 210);
            this.gbxInfo.TabIndex = 37;
            this.gbxInfo.TabStop = false;
            this.gbxInfo.Text = "Appointment Information";
            // 
            // frmChangeAppointmentDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 395);
            this.Controls.Add(this.gbxInfo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnUpdateAppointment);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChangeAppointmentDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment : APPOINTMENT NUMBER";
            this.gbxInfo.ResumeLayout(false);
            this.gbxInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateAppointment;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.Label lblAppDate;
        private System.Windows.Forms.ComboBox cbxSession;
        private System.Windows.Forms.DateTimePicker dtpDateOfAppointment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxInfo;
    }
}