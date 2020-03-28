namespace AdairRA2EventsUnlimited
{
    partial class FrmCustomers
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbCustIDSearch = new System.Windows.Forms.CheckBox();
            this.cbNameSearch = new System.Windows.Forms.CheckBox();
            this.lblSearch = new System.Windows.Forms.Label();
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
            this.lblNoResults = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.gbxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddCustomer.Location = new System.Drawing.Point(17, 443);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(450, 61);
            this.btnAddCustomer.TabIndex = 1;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnReturn.Location = new System.Drawing.Point(17, 522);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(91, 27);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.BtnReturn_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Location = new System.Drawing.Point(512, 443);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(450, 61);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit Customer";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(576, 522);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(318, 25);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "Please select a customer to edit";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Magneto", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(370, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 44);
            this.lblTitle.TabIndex = 32;
            this.lblTitle.Text = "Customers";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(114, 82);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(695, 29);
            this.tbxSearch.TabIndex = 35;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            this.tbxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(820, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 29);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // cbCustIDSearch
            // 
            this.cbCustIDSearch.AutoSize = true;
            this.cbCustIDSearch.Location = new System.Drawing.Point(6, 16);
            this.cbCustIDSearch.Name = "cbCustIDSearch";
            this.cbCustIDSearch.Size = new System.Drawing.Size(74, 17);
            this.cbCustIDSearch.TabIndex = 39;
            this.cbCustIDSearch.Text = "ID Search";
            this.cbCustIDSearch.UseVisualStyleBackColor = true;
            this.cbCustIDSearch.CheckedChanged += new System.EventHandler(this.CbCustIDSearch_CheckedChanged);
            // 
            // cbNameSearch
            // 
            this.cbNameSearch.AutoSize = true;
            this.cbNameSearch.Location = new System.Drawing.Point(86, 18);
            this.cbNameSearch.Name = "cbNameSearch";
            this.cbNameSearch.Size = new System.Drawing.Size(91, 17);
            this.cbNameSearch.TabIndex = 40;
            this.cbNameSearch.Text = "Name Search";
            this.cbNameSearch.UseVisualStyleBackColor = true;
            this.cbNameSearch.CheckedChanged += new System.EventHandler(this.CbNameSearch_CheckedChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(16, 81);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(92, 25);
            this.lblSearch.TabIndex = 43;
            this.lblSearch.Text = "Search :";
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
            this.msNavigation.Size = new System.Drawing.Size(985, 24);
            this.msNavigation.TabIndex = 45;
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
            // lblNoResults
            // 
            this.lblNoResults.AutoSize = true;
            this.lblNoResults.BackColor = System.Drawing.Color.DarkGray;
            this.lblNoResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoResults.Location = new System.Drawing.Point(347, 259);
            this.lblNoResults.Name = "lblNoResults";
            this.lblNoResults.Size = new System.Drawing.Size(290, 37);
            this.lblNoResults.TabIndex = 46;
            this.lblNoResults.Text = "No Results Found";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeColumns = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(20, 145);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(945, 292);
            this.dgvCustomer.TabIndex = 47;
            // 
            // gbxSearch
            // 
            this.gbxSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxSearch.Controls.Add(this.cbCustIDSearch);
            this.gbxSearch.Controls.Add(this.cbNameSearch);
            this.gbxSearch.Location = new System.Drawing.Point(784, 35);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(181, 41);
            this.gbxSearch.TabIndex = 48;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Search Methods";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(18, 129);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(398, 13);
            this.lblSelect.TabIndex = 49;
            this.lblSelect.Text = "To select a customer, select the full record by clicking to the left of the Custo" +
    "mer ID";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 560);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.lblNoResults);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.msNavigation);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomers_FormClosing);
            this.msNavigation.ResumeLayout(false);
            this.msNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox cbCustIDSearch;
        private System.Windows.Forms.CheckBox cbNameSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.MenuStrip msNavigation;
        private System.Windows.Forms.ToolStripMenuItem weddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookWeddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWeddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCateringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themedPartiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onSiteCateringToolStripMenuItem;
        private System.Windows.Forms.Label lblNoResults;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}