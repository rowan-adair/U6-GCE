namespace AdairRA2EventsUnlimited
{
    partial class frmHome
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
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
            this.btnAddCustomers = new System.Windows.Forms.Button();
            this.gbxCustomerManagement = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbxSpecialEvents = new System.Windows.Forms.GroupBox();
            this.gbxCateringServices = new System.Windows.Forms.GroupBox();
            this.ttWedding = new System.Windows.Forms.ToolTip(this.components);
            this.gbxStaff = new System.Windows.Forms.GroupBox();
            this.btnStaff = new System.Windows.Forms.Button();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msNavigation.SuspendLayout();
            this.gbxCustomerManagement.SuspendLayout();
            this.gbxSpecialEvents.SuspendLayout();
            this.gbxCateringServices.SuspendLayout();
            this.gbxStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Magneto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(128, 36);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(549, 41);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Events Unlimited Management";
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(119, 84);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(527, 32);
            this.btnCustomers.TabIndex = 8;
            this.btnCustomers.Text = "View Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
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
            this.msNavigation.Size = new System.Drawing.Size(784, 24);
            this.msNavigation.TabIndex = 10;
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
            // 
            // viewCustomerToolStripMenuItem
            // 
            this.viewCustomerToolStripMenuItem.Name = "viewCustomerToolStripMenuItem";
            this.viewCustomerToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.viewCustomerToolStripMenuItem.Text = "View Customer";
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.Location = new System.Drawing.Point(119, 36);
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Size = new System.Drawing.Size(527, 32);
            this.btnAddCustomers.TabIndex = 11;
            this.btnAddCustomers.Text = "Add Customers";
            this.btnAddCustomers.UseVisualStyleBackColor = true;
            this.btnAddCustomers.Click += new System.EventHandler(this.btnAddCustomers_Click);
            // 
            // gbxCustomerManagement
            // 
            this.gbxCustomerManagement.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbxCustomerManagement.Controls.Add(this.btnCustomers);
            this.gbxCustomerManagement.Controls.Add(this.btnAddCustomers);
            this.gbxCustomerManagement.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.gbxCustomerManagement.Location = new System.Drawing.Point(16, 90);
            this.gbxCustomerManagement.Name = "gbxCustomerManagement";
            this.gbxCustomerManagement.Size = new System.Drawing.Size(755, 140);
            this.gbxCustomerManagement.TabIndex = 17;
            this.gbxCustomerManagement.TabStop = false;
            this.gbxCustomerManagement.Text = "Customer Management";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(48, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(258, 88);
            this.button4.TabIndex = 19;
            this.button4.Text = "Basic Catering";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(38, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(259, 88);
            this.button5.TabIndex = 18;
            this.button5.Text = "Weddings";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(48, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 88);
            this.button1.TabIndex = 21;
            this.button1.Text = "On-Site Catering";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(39, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(258, 88);
            this.button2.TabIndex = 20;
            this.button2.Text = "Themed Parties";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gbxSpecialEvents
            // 
            this.gbxSpecialEvents.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbxSpecialEvents.Controls.Add(this.button5);
            this.gbxSpecialEvents.Controls.Add(this.button2);
            this.gbxSpecialEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSpecialEvents.Location = new System.Drawing.Point(16, 343);
            this.gbxSpecialEvents.Name = "gbxSpecialEvents";
            this.gbxSpecialEvents.Size = new System.Drawing.Size(343, 244);
            this.gbxSpecialEvents.TabIndex = 22;
            this.gbxSpecialEvents.TabStop = false;
            this.gbxSpecialEvents.Text = "Special Events";
            // 
            // gbxCateringServices
            // 
            this.gbxCateringServices.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbxCateringServices.Controls.Add(this.button1);
            this.gbxCateringServices.Controls.Add(this.button4);
            this.gbxCateringServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCateringServices.Location = new System.Drawing.Point(428, 343);
            this.gbxCateringServices.Name = "gbxCateringServices";
            this.gbxCateringServices.Size = new System.Drawing.Size(343, 244);
            this.gbxCateringServices.TabIndex = 23;
            this.gbxCateringServices.TabStop = false;
            this.gbxCateringServices.Text = "Catering Services";
            // 
            // ttWedding
            // 
            this.ttWedding.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttWedding.Popup += new System.Windows.Forms.PopupEventHandler(this.ttWedding_Popup);
            // 
            // gbxStaff
            // 
            this.gbxStaff.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbxStaff.Controls.Add(this.btnStaff);
            this.gbxStaff.Font = new System.Drawing.Font("Lucida Sans", 14.25F);
            this.gbxStaff.Location = new System.Drawing.Point(15, 236);
            this.gbxStaff.Name = "gbxStaff";
            this.gbxStaff.Size = new System.Drawing.Size(755, 93);
            this.gbxStaff.TabIndex = 24;
            this.gbxStaff.TabStop = false;
            this.gbxStaff.Text = "Staff Management";
            // 
            // btnStaff
            // 
            this.btnStaff.Location = new System.Drawing.Point(120, 34);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(527, 32);
            this.btnStaff.TabIndex = 8;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 630);
            this.Controls.Add(this.gbxStaff);
            this.Controls.Add(this.gbxCateringServices);
            this.Controls.Add(this.gbxSpecialEvents);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbxCustomerManagement);
            this.Controls.Add(this.msNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.msNavigation.ResumeLayout(false);
            this.msNavigation.PerformLayout();
            this.gbxCustomerManagement.ResumeLayout(false);
            this.gbxSpecialEvents.ResumeLayout(false);
            this.gbxCateringServices.ResumeLayout(false);
            this.gbxStaff.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.MenuStrip msNavigation;
        private System.Windows.Forms.ToolStripMenuItem weddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basicCateringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themedPartiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAppointmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookWeddingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewWeddingsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddCustomers;
        private System.Windows.Forms.ToolStripMenuItem onSiteCateringToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxCustomerManagement;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gbxSpecialEvents;
        private System.Windows.Forms.GroupBox gbxCateringServices;
        private System.Windows.Forms.ToolTip ttWedding;
        private System.Windows.Forms.ToolStripMenuItem staffToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbxStaff;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    }
}