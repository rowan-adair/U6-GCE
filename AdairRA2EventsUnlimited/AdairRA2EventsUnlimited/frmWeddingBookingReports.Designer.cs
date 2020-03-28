namespace AdairRA2EventsUnlimited
{
    partial class frmWeddingBookingReports
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.WeddingBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdairRA2EventsUnlimitedDataSet = new AdairRA2EventsUnlimited.AdairRA2EventsUnlimitedDataSet();
            this.rptvWeddingReports = new Microsoft.Reporting.WinForms.ReportViewer();
            this.qryBookingConfirmedToolStrip = new System.Windows.Forms.ToolStrip();
            this.bookingConfirmedToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.bookingConfirmedToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.qryBookingConfirmedToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.qryIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.tslIDQueries = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bookingIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.bookingIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.qryBookingIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.staffIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.staffIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.qryStaffIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.weddingIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.weddingIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.qryWeddingIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.qryCostToolStrip = new System.Windows.Forms.ToolStrip();
            this.tslCostQueries = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.costGreaterToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.costGreaterToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.qryCostGreaterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.costLessToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.costLessToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.qryCostLessToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lowerCostToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.lowerCostToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.upperCostToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.upperCostToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.qryCostBetweenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.WeddingBookingTableAdapter = new AdairRA2EventsUnlimited.AdairRA2EventsUnlimitedDataSetTableAdapters.WeddingBookingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.WeddingBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdairRA2EventsUnlimitedDataSet)).BeginInit();
            this.qryBookingConfirmedToolStrip.SuspendLayout();
            this.qryIDToolStrip.SuspendLayout();
            this.qryCostToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeddingBookingBindingSource
            // 
            this.WeddingBookingBindingSource.DataMember = "WeddingBooking";
            this.WeddingBookingBindingSource.DataSource = this.AdairRA2EventsUnlimitedDataSet;
            // 
            // AdairRA2EventsUnlimitedDataSet
            // 
            this.AdairRA2EventsUnlimitedDataSet.DataSetName = "AdairRA2EventsUnlimitedDataSet";
            this.AdairRA2EventsUnlimitedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptvWeddingReports
            // 
            reportDataSource1.Name = "WeddingBooking";
            reportDataSource1.Value = this.WeddingBookingBindingSource;
            this.rptvWeddingReports.LocalReport.DataSources.Add(reportDataSource1);
            this.rptvWeddingReports.LocalReport.ReportEmbeddedResource = "AdairRA2EventsUnlimited.WeddingReport.rdlc";
            this.rptvWeddingReports.Location = new System.Drawing.Point(31, 111);
            this.rptvWeddingReports.Name = "rptvWeddingReports";
            this.rptvWeddingReports.ServerReport.BearerToken = null;
            this.rptvWeddingReports.Size = new System.Drawing.Size(893, 390);
            this.rptvWeddingReports.TabIndex = 0;
            // 
            // qryBookingConfirmedToolStrip
            // 
            this.qryBookingConfirmedToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookingConfirmedToolStripLabel,
            this.bookingConfirmedToolStripComboBox,
            this.qryBookingConfirmedToolStripButton});
            this.qryBookingConfirmedToolStrip.Location = new System.Drawing.Point(0, 0);
            this.qryBookingConfirmedToolStrip.Name = "qryBookingConfirmedToolStrip";
            this.qryBookingConfirmedToolStrip.Size = new System.Drawing.Size(962, 25);
            this.qryBookingConfirmedToolStrip.TabIndex = 1;
            this.qryBookingConfirmedToolStrip.Text = "qryBookingConfirmedToolStrip";
            // 
            // bookingConfirmedToolStripLabel
            // 
            this.bookingConfirmedToolStripLabel.Name = "bookingConfirmedToolStripLabel";
            this.bookingConfirmedToolStripLabel.Size = new System.Drawing.Size(148, 22);
            this.bookingConfirmedToolStripLabel.Text = "Show Confirmed Bookings";
            // 
            // bookingConfirmedToolStripComboBox
            // 
            this.bookingConfirmedToolStripComboBox.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.bookingConfirmedToolStripComboBox.Name = "bookingConfirmedToolStripComboBox";
            this.bookingConfirmedToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            // 
            // qryBookingConfirmedToolStripButton
            // 
            this.qryBookingConfirmedToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.qryBookingConfirmedToolStripButton.Name = "qryBookingConfirmedToolStripButton";
            this.qryBookingConfirmedToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.qryBookingConfirmedToolStripButton.Text = "Search";
            this.qryBookingConfirmedToolStripButton.Click += new System.EventHandler(this.qryBookingConfirmedToolStripButton_Click);
            // 
            // qryIDToolStrip
            // 
            this.qryIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslIDQueries,
            this.toolStripSeparator4,
            this.bookingIDToolStripLabel,
            this.bookingIDToolStripTextBox,
            this.qryBookingIDToolStripButton,
            this.toolStripSeparator3,
            this.staffIDToolStripLabel,
            this.staffIDToolStripTextBox,
            this.qryStaffIDToolStripButton,
            this.toolStripSeparator6,
            this.weddingIDToolStripLabel,
            this.weddingIDToolStripTextBox,
            this.qryWeddingIDToolStripButton});
            this.qryIDToolStrip.Location = new System.Drawing.Point(0, 25);
            this.qryIDToolStrip.Name = "qryIDToolStrip";
            this.qryIDToolStrip.Size = new System.Drawing.Size(962, 25);
            this.qryIDToolStrip.TabIndex = 2;
            this.qryIDToolStrip.Text = "qryBookingIDToolStrip";
            // 
            // tslIDQueries
            // 
            this.tslIDQueries.Name = "tslIDQueries";
            this.tslIDQueries.Size = new System.Drawing.Size(61, 22);
            this.tslIDQueries.Text = "ID Queries";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bookingIDToolStripLabel
            // 
            this.bookingIDToolStripLabel.Name = "bookingIDToolStripLabel";
            this.bookingIDToolStripLabel.Size = new System.Drawing.Size(65, 22);
            this.bookingIDToolStripLabel.Text = "BookingID:";
            // 
            // bookingIDToolStripTextBox
            // 
            this.bookingIDToolStripTextBox.Name = "bookingIDToolStripTextBox";
            this.bookingIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // qryBookingIDToolStripButton
            // 
            this.qryBookingIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.qryBookingIDToolStripButton.Name = "qryBookingIDToolStripButton";
            this.qryBookingIDToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.qryBookingIDToolStripButton.Text = "Search";
            this.qryBookingIDToolStripButton.Click += new System.EventHandler(this.qryBookingIDToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // staffIDToolStripLabel
            // 
            this.staffIDToolStripLabel.Name = "staffIDToolStripLabel";
            this.staffIDToolStripLabel.Size = new System.Drawing.Size(45, 22);
            this.staffIDToolStripLabel.Text = "StaffID:";
            // 
            // staffIDToolStripTextBox
            // 
            this.staffIDToolStripTextBox.Name = "staffIDToolStripTextBox";
            this.staffIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // qryStaffIDToolStripButton
            // 
            this.qryStaffIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.qryStaffIDToolStripButton.Name = "qryStaffIDToolStripButton";
            this.qryStaffIDToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.qryStaffIDToolStripButton.Text = "Search";
            this.qryStaffIDToolStripButton.Click += new System.EventHandler(this.qryStaffIDToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // weddingIDToolStripLabel
            // 
            this.weddingIDToolStripLabel.Name = "weddingIDToolStripLabel";
            this.weddingIDToolStripLabel.Size = new System.Drawing.Size(72, 22);
            this.weddingIDToolStripLabel.Text = "Wedding ID:";
            // 
            // weddingIDToolStripTextBox
            // 
            this.weddingIDToolStripTextBox.Name = "weddingIDToolStripTextBox";
            this.weddingIDToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // qryWeddingIDToolStripButton
            // 
            this.qryWeddingIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.qryWeddingIDToolStripButton.Name = "qryWeddingIDToolStripButton";
            this.qryWeddingIDToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.qryWeddingIDToolStripButton.Text = "Search";
            this.qryWeddingIDToolStripButton.Click += new System.EventHandler(this.qryWeddingIDToolStripButton_Click);
            // 
            // qryCostToolStrip
            // 
            this.qryCostToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslCostQueries,
            this.toolStripSeparator2,
            this.costGreaterToolStripLabel,
            this.costGreaterToolStripTextBox,
            this.qryCostGreaterToolStripButton,
            this.toolStripSeparator1,
            this.costLessToolStripLabel,
            this.costLessToolStripTextBox,
            this.qryCostLessToolStripButton,
            this.toolStripSeparator5,
            this.lowerCostToolStripLabel,
            this.lowerCostToolStripTextBox,
            this.upperCostToolStripLabel,
            this.upperCostToolStripTextBox,
            this.qryCostBetweenToolStripButton});
            this.qryCostToolStrip.Location = new System.Drawing.Point(0, 50);
            this.qryCostToolStrip.Name = "qryCostToolStrip";
            this.qryCostToolStrip.Size = new System.Drawing.Size(962, 25);
            this.qryCostToolStrip.TabIndex = 4;
            this.qryCostToolStrip.Text = "qryCostGreaterToolStrip";
            // 
            // tslCostQueries
            // 
            this.tslCostQueries.Name = "tslCostQueries";
            this.tslCostQueries.Size = new System.Drawing.Size(74, 22);
            this.tslCostQueries.Text = "Cost Queries";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // costGreaterToolStripLabel
            // 
            this.costGreaterToolStripLabel.Name = "costGreaterToolStripLabel";
            this.costGreaterToolStripLabel.Size = new System.Drawing.Size(75, 22);
            this.costGreaterToolStripLabel.Text = "Cost Greater:";
            // 
            // costGreaterToolStripTextBox
            // 
            this.costGreaterToolStripTextBox.Name = "costGreaterToolStripTextBox";
            this.costGreaterToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // qryCostGreaterToolStripButton
            // 
            this.qryCostGreaterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.qryCostGreaterToolStripButton.Name = "qryCostGreaterToolStripButton";
            this.qryCostGreaterToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.qryCostGreaterToolStripButton.Text = "Search";
            this.qryCostGreaterToolStripButton.Click += new System.EventHandler(this.qryCostGreaterToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // costLessToolStripLabel
            // 
            this.costLessToolStripLabel.Name = "costLessToolStripLabel";
            this.costLessToolStripLabel.Size = new System.Drawing.Size(59, 22);
            this.costLessToolStripLabel.Text = "Cost Less:";
            // 
            // costLessToolStripTextBox
            // 
            this.costLessToolStripTextBox.Name = "costLessToolStripTextBox";
            this.costLessToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // qryCostLessToolStripButton
            // 
            this.qryCostLessToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.qryCostLessToolStripButton.Name = "qryCostLessToolStripButton";
            this.qryCostLessToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.qryCostLessToolStripButton.Text = "Search";
            this.qryCostLessToolStripButton.Click += new System.EventHandler(this.qryCostLessToolStripButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // lowerCostToolStripLabel
            // 
            this.lowerCostToolStripLabel.Name = "lowerCostToolStripLabel";
            this.lowerCostToolStripLabel.Size = new System.Drawing.Size(65, 22);
            this.lowerCostToolStripLabel.Text = "More than:";
            // 
            // lowerCostToolStripTextBox
            // 
            this.lowerCostToolStripTextBox.Name = "lowerCostToolStripTextBox";
            this.lowerCostToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // upperCostToolStripLabel
            // 
            this.upperCostToolStripLabel.Name = "upperCostToolStripLabel";
            this.upperCostToolStripLabel.Size = new System.Drawing.Size(76, 22);
            this.upperCostToolStripLabel.Text = "and less than";
            // 
            // upperCostToolStripTextBox
            // 
            this.upperCostToolStripTextBox.Name = "upperCostToolStripTextBox";
            this.upperCostToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // qryCostBetweenToolStripButton
            // 
            this.qryCostBetweenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.qryCostBetweenToolStripButton.Name = "qryCostBetweenToolStripButton";
            this.qryCostBetweenToolStripButton.Size = new System.Drawing.Size(46, 22);
            this.qryCostBetweenToolStripButton.Text = "Search";
            this.qryCostBetweenToolStripButton.Click += new System.EventHandler(this.qryCostBetweenToolStripButton_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 529);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(207, 35);
            this.btnReturn.TabIndex = 32;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(225, 529);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(207, 35);
            this.btnRefresh.TabIndex = 33;
            this.btnRefresh.Text = "Refresh Form";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // WeddingBookingTableAdapter
            // 
            this.WeddingBookingTableAdapter.ClearBeforeFill = true;
            // 
            // frmWeddingBookingReports
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(962, 596);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.qryCostToolStrip);
            this.Controls.Add(this.qryIDToolStrip);
            this.Controls.Add(this.qryBookingConfirmedToolStrip);
            this.Controls.Add(this.rptvWeddingReports);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmWeddingBookingReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmWeddingBookingReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeddingBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdairRA2EventsUnlimitedDataSet)).EndInit();
            this.qryBookingConfirmedToolStrip.ResumeLayout(false);
            this.qryBookingConfirmedToolStrip.PerformLayout();
            this.qryIDToolStrip.ResumeLayout(false);
            this.qryIDToolStrip.PerformLayout();
            this.qryCostToolStrip.ResumeLayout(false);
            this.qryCostToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptvWeddingReports;
        private System.Windows.Forms.BindingSource WeddingBookingBindingSource;
        private AdairRA2EventsUnlimitedDataSet AdairRA2EventsUnlimitedDataSet;
        private AdairRA2EventsUnlimitedDataSetTableAdapters.WeddingBookingTableAdapter WeddingBookingTableAdapter;
        private System.Windows.Forms.ToolStrip qryBookingConfirmedToolStrip;
        private System.Windows.Forms.ToolStripLabel bookingConfirmedToolStripLabel;
        private System.Windows.Forms.ToolStripButton qryBookingConfirmedToolStripButton;
        private System.Windows.Forms.ToolStrip qryIDToolStrip;
        private System.Windows.Forms.ToolStripLabel bookingIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox bookingIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton qryBookingIDToolStripButton;
        private System.Windows.Forms.ToolStrip qryCostToolStrip;
        private System.Windows.Forms.ToolStripLabel costGreaterToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox costGreaterToolStripTextBox;
        private System.Windows.Forms.ToolStripButton qryCostGreaterToolStripButton;
        private System.Windows.Forms.ToolStripLabel tslIDQueries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel staffIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox staffIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton qryStaffIDToolStripButton;
        private System.Windows.Forms.ToolStripLabel tslCostQueries;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel costLessToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox costLessToolStripTextBox;
        private System.Windows.Forms.ToolStripButton qryCostLessToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripLabel lowerCostToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox lowerCostToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel upperCostToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox upperCostToolStripTextBox;
        private System.Windows.Forms.ToolStripButton qryCostBetweenToolStripButton;
        private System.Windows.Forms.ToolStripComboBox bookingConfirmedToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripLabel weddingIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox weddingIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton qryWeddingIDToolStripButton;
       
    }
}