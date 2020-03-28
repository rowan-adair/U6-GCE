namespace AdairRA2EventsUnlimited
{
    partial class frmStaffManagement
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
            this.tabControlStaff = new System.Windows.Forms.TabControl();
            this.tabstaff = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.tabadd = new System.Windows.Forms.TabPage();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.lblVenueError = new System.Windows.Forms.Label();
            this.lblRoleError = new System.Windows.Forms.Label();
            this.lblSurnameError = new System.Windows.Forms.Label();
            this.lblForenameError = new System.Windows.Forms.Label();
            this.lblVenue = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.cbxVenue = new System.Windows.Forms.ComboBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxForename = new System.Windows.Forms.TextBox();
            this.tabavailability = new System.Windows.Forms.TabPage();
            this.lblShowVenue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxDaySearch = new System.Windows.Forms.ComboBox();
            this.gbxManageAv = new System.Windows.Forms.GroupBox();
            this.chbxAvailability = new System.Windows.Forms.CheckBox();
            this.lblErrorSession = new System.Windows.Forms.Label();
            this.lblErrorDay = new System.Windows.Forms.Label();
            this.btnAddSession = new System.Windows.Forms.Button();
            this.lblChooseSession = new System.Windows.Forms.Label();
            this.cbxSession = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.cbxDays = new System.Windows.Forms.ComboBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lbxSessions = new System.Windows.Forms.ListBox();
            this.cbxStaff = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.msNavigation = new System.Windows.Forms.MenuStrip();
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlStaff.SuspendLayout();
            this.tabstaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.tabadd.SuspendLayout();
            this.tabavailability.SuspendLayout();
            this.gbxManageAv.SuspendLayout();
            this.msNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlStaff
            // 
            this.tabControlStaff.Controls.Add(this.tabstaff);
            this.tabControlStaff.Controls.Add(this.tabadd);
            this.tabControlStaff.Controls.Add(this.tabavailability);
            this.tabControlStaff.Location = new System.Drawing.Point(12, 66);
            this.tabControlStaff.Name = "tabControlStaff";
            this.tabControlStaff.SelectedIndex = 0;
            this.tabControlStaff.Size = new System.Drawing.Size(774, 445);
            this.tabControlStaff.TabIndex = 0;
            // 
            // tabstaff
            // 
            this.tabstaff.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabstaff.Controls.Add(this.label3);
            this.tabstaff.Controls.Add(this.dgvStaff);
            this.tabstaff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabstaff.Location = new System.Drawing.Point(4, 22);
            this.tabstaff.Name = "tabstaff";
            this.tabstaff.Padding = new System.Windows.Forms.Padding(3);
            this.tabstaff.Size = new System.Drawing.Size(766, 419);
            this.tabstaff.TabIndex = 0;
            this.tabstaff.Text = "View Staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Employed Staff";
            // 
            // dgvStaff
            // 
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.AllowUserToResizeColumns = false;
            this.dgvStaff.AllowUserToResizeRows = false;
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(3, 54);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(763, 362);
            this.dgvStaff.TabIndex = 0;
            // 
            // tabadd
            // 
            this.tabadd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabadd.Controls.Add(this.btnAddStaff);
            this.tabadd.Controls.Add(this.lblVenueError);
            this.tabadd.Controls.Add(this.lblRoleError);
            this.tabadd.Controls.Add(this.lblSurnameError);
            this.tabadd.Controls.Add(this.lblForenameError);
            this.tabadd.Controls.Add(this.lblVenue);
            this.tabadd.Controls.Add(this.lblRole);
            this.tabadd.Controls.Add(this.lblSurname);
            this.tabadd.Controls.Add(this.cbxVenue);
            this.tabadd.Controls.Add(this.lblForename);
            this.tabadd.Controls.Add(this.cbxRole);
            this.tabadd.Controls.Add(this.tbxSurname);
            this.tabadd.Controls.Add(this.tbxForename);
            this.tabadd.Location = new System.Drawing.Point(4, 22);
            this.tabadd.Name = "tabadd";
            this.tabadd.Padding = new System.Windows.Forms.Padding(3);
            this.tabadd.Size = new System.Drawing.Size(766, 419);
            this.tabadd.TabIndex = 1;
            this.tabadd.Text = "Add New Staff";
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStaff.Location = new System.Drawing.Point(170, 291);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(534, 60);
            this.btnAddStaff.TabIndex = 25;
            this.btnAddStaff.Text = "Add New Staff Member";
            this.btnAddStaff.UseVisualStyleBackColor = true;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            // 
            // lblVenueError
            // 
            this.lblVenueError.AutoSize = true;
            this.lblVenueError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueError.ForeColor = System.Drawing.Color.Red;
            this.lblVenueError.Location = new System.Drawing.Point(710, 229);
            this.lblVenueError.Name = "lblVenueError";
            this.lblVenueError.Size = new System.Drawing.Size(17, 24);
            this.lblVenueError.TabIndex = 24;
            this.lblVenueError.Text = "*";
            // 
            // lblRoleError
            // 
            this.lblRoleError.AutoSize = true;
            this.lblRoleError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleError.ForeColor = System.Drawing.Color.Red;
            this.lblRoleError.Location = new System.Drawing.Point(710, 171);
            this.lblRoleError.Name = "lblRoleError";
            this.lblRoleError.Size = new System.Drawing.Size(17, 24);
            this.lblRoleError.TabIndex = 23;
            this.lblRoleError.Text = "*";
            // 
            // lblSurnameError
            // 
            this.lblSurnameError.AutoSize = true;
            this.lblSurnameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnameError.ForeColor = System.Drawing.Color.Red;
            this.lblSurnameError.Location = new System.Drawing.Point(710, 112);
            this.lblSurnameError.Name = "lblSurnameError";
            this.lblSurnameError.Size = new System.Drawing.Size(17, 24);
            this.lblSurnameError.TabIndex = 22;
            this.lblSurnameError.Text = "*";
            // 
            // lblForenameError
            // 
            this.lblForenameError.AutoSize = true;
            this.lblForenameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForenameError.ForeColor = System.Drawing.Color.Red;
            this.lblForenameError.Location = new System.Drawing.Point(710, 55);
            this.lblForenameError.Name = "lblForenameError";
            this.lblForenameError.Size = new System.Drawing.Size(17, 24);
            this.lblForenameError.TabIndex = 21;
            this.lblForenameError.Text = "*";
            // 
            // lblVenue
            // 
            this.lblVenue.AutoSize = true;
            this.lblVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenue.Location = new System.Drawing.Point(58, 222);
            this.lblVenue.Name = "lblVenue";
            this.lblVenue.Size = new System.Drawing.Size(92, 31);
            this.lblVenue.TabIndex = 20;
            this.lblVenue.Text = "Venue";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(80, 164);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(70, 31);
            this.lblRole.TabIndex = 19;
            this.lblRole.Text = "Role";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(27, 108);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(123, 31);
            this.lblSurname.TabIndex = 18;
            this.lblSurname.Text = "Surname";
            // 
            // cbxVenue
            // 
            this.cbxVenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVenue.FormattingEnabled = true;
            this.cbxVenue.Location = new System.Drawing.Point(170, 219);
            this.cbxVenue.Name = "cbxVenue";
            this.cbxVenue.Size = new System.Drawing.Size(534, 39);
            this.cbxVenue.TabIndex = 17;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.Location = new System.Drawing.Point(27, 48);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(137, 31);
            this.lblForename.TabIndex = 16;
            this.lblForename.Text = "Forename";
            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(170, 161);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(534, 39);
            this.cbxRole.TabIndex = 15;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSurname.Location = new System.Drawing.Point(170, 105);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(534, 38);
            this.tbxSurname.TabIndex = 14;
            // 
            // tbxForename
            // 
            this.tbxForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxForename.Location = new System.Drawing.Point(170, 45);
            this.tbxForename.Name = "tbxForename";
            this.tbxForename.Size = new System.Drawing.Size(534, 38);
            this.tbxForename.TabIndex = 13;
            // 
            // tabavailability
            // 
            this.tabavailability.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabavailability.Controls.Add(this.lblShowVenue);
            this.tabavailability.Controls.Add(this.label2);
            this.tabavailability.Controls.Add(this.cbxDaySearch);
            this.tabavailability.Controls.Add(this.gbxManageAv);
            this.tabavailability.Controls.Add(this.lblStaff);
            this.tabavailability.Controls.Add(this.lbxSessions);
            this.tabavailability.Controls.Add(this.cbxStaff);
            this.tabavailability.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabavailability.Location = new System.Drawing.Point(4, 22);
            this.tabavailability.Name = "tabavailability";
            this.tabavailability.Padding = new System.Windows.Forms.Padding(3);
            this.tabavailability.Size = new System.Drawing.Size(766, 419);
            this.tabavailability.TabIndex = 2;
            this.tabavailability.Text = "Manage Staff Availability";
            // 
            // lblShowVenue
            // 
            this.lblShowVenue.AutoSize = true;
            this.lblShowVenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowVenue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblShowVenue.Location = new System.Drawing.Point(23, 106);
            this.lblShowVenue.Name = "lblShowVenue";
            this.lblShowVenue.Size = new System.Drawing.Size(127, 31);
            this.lblShowVenue.TabIndex = 36;
            this.lblShowVenue.Text = "Venue : x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(23, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 31);
            this.label2.TabIndex = 35;
            this.label2.Text = "Day : ";
            // 
            // cbxDaySearch
            // 
            this.cbxDaySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDaySearch.Enabled = false;
            this.cbxDaySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDaySearch.FormattingEnabled = true;
            this.cbxDaySearch.Items.AddRange(new object[] {
            "1.Sunday",
            "2.Monday",
            "3.Tuesday",
            "4.Wednesday",
            "5.Thursday",
            "6.Friday",
            "7.Saturday"});
            this.cbxDaySearch.Location = new System.Drawing.Point(114, 147);
            this.cbxDaySearch.Name = "cbxDaySearch";
            this.cbxDaySearch.Size = new System.Drawing.Size(207, 33);
            this.cbxDaySearch.TabIndex = 34;
            this.cbxDaySearch.SelectedIndexChanged += new System.EventHandler(this.cbxDay2_SelectedIndexChanged);
            // 
            // gbxManageAv
            // 
            this.gbxManageAv.Controls.Add(this.chbxAvailability);
            this.gbxManageAv.Controls.Add(this.lblErrorSession);
            this.gbxManageAv.Controls.Add(this.lblErrorDay);
            this.gbxManageAv.Controls.Add(this.btnAddSession);
            this.gbxManageAv.Controls.Add(this.lblChooseSession);
            this.gbxManageAv.Controls.Add(this.cbxSession);
            this.gbxManageAv.Controls.Add(this.lblDay);
            this.gbxManageAv.Controls.Add(this.cbxDays);
            this.gbxManageAv.Enabled = false;
            this.gbxManageAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxManageAv.Location = new System.Drawing.Point(345, 110);
            this.gbxManageAv.Name = "gbxManageAv";
            this.gbxManageAv.Size = new System.Drawing.Size(414, 274);
            this.gbxManageAv.TabIndex = 33;
            this.gbxManageAv.TabStop = false;
            // 
            // chbxAvailability
            // 
            this.chbxAvailability.AutoSize = true;
            this.chbxAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxAvailability.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chbxAvailability.Location = new System.Drawing.Point(0, -4);
            this.chbxAvailability.Name = "chbxAvailability";
            this.chbxAvailability.Size = new System.Drawing.Size(247, 35);
            this.chbxAvailability.TabIndex = 36;
            this.chbxAvailability.Text = "Add New Session";
            this.chbxAvailability.UseVisualStyleBackColor = true;
            this.chbxAvailability.CheckedChanged += new System.EventHandler(this.chbxAvailability_CheckedChanged);
            // 
            // lblErrorSession
            // 
            this.lblErrorSession.AutoSize = true;
            this.lblErrorSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSession.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSession.Location = new System.Drawing.Point(395, 94);
            this.lblErrorSession.Name = "lblErrorSession";
            this.lblErrorSession.Size = new System.Drawing.Size(17, 24);
            this.lblErrorSession.TabIndex = 26;
            this.lblErrorSession.Text = "*";
            // 
            // lblErrorDay
            // 
            this.lblErrorDay.AutoSize = true;
            this.lblErrorDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDay.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDay.Location = new System.Drawing.Point(395, 44);
            this.lblErrorDay.Name = "lblErrorDay";
            this.lblErrorDay.Size = new System.Drawing.Size(17, 24);
            this.lblErrorDay.TabIndex = 25;
            this.lblErrorDay.Text = "*";
            // 
            // btnAddSession
            // 
            this.btnAddSession.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddSession.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddSession.Location = new System.Drawing.Point(21, 162);
            this.btnAddSession.Name = "btnAddSession";
            this.btnAddSession.Size = new System.Drawing.Size(376, 65);
            this.btnAddSession.TabIndex = 7;
            this.btnAddSession.Text = "Add Session";
            this.btnAddSession.UseVisualStyleBackColor = false;
            this.btnAddSession.Click += new System.EventHandler(this.btnAddSession_Click);
            // 
            // lblChooseSession
            // 
            this.lblChooseSession.AutoSize = true;
            this.lblChooseSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseSession.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblChooseSession.Location = new System.Drawing.Point(12, 87);
            this.lblChooseSession.Name = "lblChooseSession";
            this.lblChooseSession.Size = new System.Drawing.Size(126, 31);
            this.lblChooseSession.TabIndex = 6;
            this.lblChooseSession.Text = "Session :";
            // 
            // cbxSession
            // 
            this.cbxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSession.Enabled = false;
            this.cbxSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSession.FormattingEnabled = true;
            this.cbxSession.Location = new System.Drawing.Point(140, 90);
            this.cbxSession.Name = "cbxSession";
            this.cbxSession.Size = new System.Drawing.Size(249, 33);
            this.cbxSession.TabIndex = 5;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDay.Location = new System.Drawing.Point(58, 37);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(85, 31);
            this.lblDay.TabIndex = 4;
            this.lblDay.Text = "Day : ";
            // 
            // cbxDays
            // 
            this.cbxDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDays.Enabled = false;
            this.cbxDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDays.FormattingEnabled = true;
            this.cbxDays.Items.AddRange(new object[] {
            "1.Sunday",
            "2.Monday",
            "3.Tuesday",
            "4.Wednesday",
            "5.Thursday",
            "6.Friday",
            "7.Saturday"});
            this.cbxDays.Location = new System.Drawing.Point(140, 37);
            this.cbxDays.Name = "cbxDays";
            this.cbxDays.Size = new System.Drawing.Size(249, 33);
            this.cbxDays.TabIndex = 0;
            this.cbxDays.SelectedIndexChanged += new System.EventHandler(this.cbxDays_SelectedIndexChanged);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStaff.Location = new System.Drawing.Point(13, 24);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(281, 31);
            this.lblStaff.TabIndex = 3;
            this.lblStaff.Text = "Select a Staff Member";
            // 
            // lbxSessions
            // 
            this.lbxSessions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxSessions.FormattingEnabled = true;
            this.lbxSessions.ItemHeight = 18;
            this.lbxSessions.Location = new System.Drawing.Point(23, 186);
            this.lbxSessions.Name = "lbxSessions";
            this.lbxSessions.Size = new System.Drawing.Size(298, 112);
            this.lbxSessions.TabIndex = 2;
            // 
            // cbxStaff
            // 
            this.cbxStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxStaff.FormattingEnabled = true;
            this.cbxStaff.Location = new System.Drawing.Point(300, 24);
            this.cbxStaff.Name = "cbxStaff";
            this.cbxStaff.Size = new System.Drawing.Size(460, 39);
            this.cbxStaff.TabIndex = 1;
            this.cbxStaff.SelectedIndexChanged += new System.EventHandler(this.cbxStaff_SelectedIndexChanged);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(12, 517);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 23);
            this.btnReturn.TabIndex = 12;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(239, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(350, 41);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Staff Management";
            // 
            // msNavigation
            // 
            this.msNavigation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.weddingsToolStripMenuItem,
            this.basicCateringToolStripMenuItem,
            this.themedPartiesToolStripMenuItem,
            this.onSiteCateringToolStripMenuItem,
            this.staffToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.msNavigation.Location = new System.Drawing.Point(0, 0);
            this.msNavigation.Name = "msNavigation";
            this.msNavigation.Size = new System.Drawing.Size(801, 24);
            this.msNavigation.TabIndex = 33;
            this.msNavigation.Text = "menuStrip2";
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
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmStaffManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 545);
            this.Controls.Add(this.msNavigation);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.tabControlStaff);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmStaffManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Management";
            this.Load += new System.EventHandler(this.frmStaffManagement_Load);
            this.tabControlStaff.ResumeLayout(false);
            this.tabstaff.ResumeLayout(false);
            this.tabstaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.tabadd.ResumeLayout(false);
            this.tabadd.PerformLayout();
            this.tabavailability.ResumeLayout(false);
            this.tabavailability.PerformLayout();
            this.gbxManageAv.ResumeLayout(false);
            this.gbxManageAv.PerformLayout();
            this.msNavigation.ResumeLayout(false);
            this.msNavigation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlStaff;
        private System.Windows.Forms.TabPage tabstaff;
        private System.Windows.Forms.TabPage tabadd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TabPage tabavailability;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Label lblVenueError;
        private System.Windows.Forms.Label lblRoleError;
        private System.Windows.Forms.Label lblSurnameError;
        private System.Windows.Forms.Label lblForenameError;
        private System.Windows.Forms.Label lblVenue;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.ComboBox cbxVenue;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxForename;
        private System.Windows.Forms.ComboBox cbxStaff;
        private System.Windows.Forms.ComboBox cbxDays;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbxManageAv;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.ListBox lbxSessions;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblErrorSession;
        private System.Windows.Forms.Label lblErrorDay;
        private System.Windows.Forms.Button btnAddSession;
        private System.Windows.Forms.Label lblChooseSession;
        private System.Windows.Forms.ComboBox cbxSession;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxDaySearch;
        private System.Windows.Forms.CheckBox chbxAvailability;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip msNavigation;
        private System.Windows.Forms.ToolStripMenuItem weddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookWeddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWeddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCateringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themedPartiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onSiteCateringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.Label lblShowVenue;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}