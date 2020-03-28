using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace AdairRA2EventsUnlimited
{  
    public partial class FrmAddCustomer : Form
    {
        private string phoneNumber;
        #region Lists
        private List<Label> listOfErrorLabels = new List<Label>();
        
        #endregion
        //works
        #region Setup form
        public FrmAddCustomer()
        {
            InitializeComponent();
            SetUp();
        }
        private void SetUp()
        {
            ClearFields();
            SetDateFormat();
            ShowExistingCustomers();
            listOfErrorLabels.Add(lblErrorDateOfBirth);
            listOfErrorLabels.Add(lblErrorEmail);
            listOfErrorLabels.Add(lblErrorFirstname);
            listOfErrorLabels.Add(lblErrorSecondname);
            listOfErrorLabels.Add(lblErrorGender);
            listOfErrorLabels.Add(lblErrorHome);
            listOfErrorLabels.Add(lblErrorPhone);
            listOfErrorLabels.Add(lblErrorPostcode);

        }
        private void resetErrors()
        {
            foreach (var label in listOfErrorLabels)
            {
                label.Visible = false;
            }
        }
        private void ShowExistingCustomers()
        {
            foreach (var customer in CustomerDAL.GetCustomer())
            {
                string[] customerData = customer.Split(',');
                string populate = string.Format("{0}.{1} {2}", customerData[0], customerData[1], customerData[2]);
                lbxExistingCustomers.Items.Add(populate);
            }
        }
        private void ClearFields()
        {
            tbxFirstName.Text = "";
            tbxSecondName.Text = "";
            tbxPhoneNumber.Text = "";
            tbxAddress.Text = "";
            tbxEmail.Text = "";
            tbxPostCode.Text = "";
            dtpDateBirth.Value = DateTime.Today;
        }
        private void SetDateFormat()
        {
            dtpDateBirth.Format = DateTimePickerFormat.Custom;
            dtpDateBirth.CustomFormat = "dd-MM-yyyy";
        }
        #endregion
        //works
        #region Validation Methods
       
        
        #endregion
        //works
        #region Add Customer
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            #region Variables
            if (string.IsNullOrWhiteSpace(tbxPhoneNumber.Text))
            {
                MessageBox.Show("Missing data, try again!");
                foreach (var label in listOfErrorLabels)
                {
                    label.Visible = true;
                }
            }
            else
            {
                if (tbxPhoneNumber.Text.Substring(0, 1) == "0")
                {
                    phoneNumber = "+44" + tbxPhoneNumber.Text.TrimStart('0');
                }
                else
                {
                    phoneNumber = tbxPhoneNumber.Text;
                }
            }
            #endregion
            //Usable
            #region Not empty validation
            if (
                string.IsNullOrWhiteSpace(tbxFirstName.Text) 
                || string.IsNullOrWhiteSpace(tbxSecondName.Text) 
                || string.IsNullOrWhiteSpace(tbxPostCode.Text) 
                || string.IsNullOrWhiteSpace(tbxEmail.Text) 
                || string.IsNullOrWhiteSpace(tbxAddress.Text) 
                || string.IsNullOrEmpty(cbxGender.Text)
                )
            {
                MessageBox.Show("Missing data, try again!");
                foreach (var label in listOfErrorLabels)
                {
                    label.Visible = true;
                }
            }
            #endregion
            //works
            #region Name validation
            else if (ValidatorClass.CustomerValidation.IsValidName(tbxFirstName.Text, tbxSecondName.Text) == false)
            {
                MessageBox.Show("Invalid name","Error");
                lblFirstName.Visible = true; lblSecondName.Visible = true;
            }
            #endregion
            //works
            #region Age validation
            else if (ValidatorClass.DateTimeSpan.CompareDates(dtpDateBirth.Value,DateTime.Today).Years < 18)
            {
                resetErrors();
                MessageBox.Show("Customer must be 18 years of age or over.");
                lblErrorDateOfBirth.Visible = true;
            }
            #endregion
            //works
            #region Phone validation
            else if (ValidatorClass.CustomerValidation.IsValidPhoneNumber(phoneNumber) == false)
            {
                resetErrors();
                MessageBox.Show("Invalid UK phone number, please try again");
                lblErrorPhone.Visible = true;
            }
            #endregion
            //works
            #region Postcode validation
            else if (ValidatorClass.CustomerValidation.IsValidPostCode(tbxPostCode.Text) == false)
            {
                resetErrors();
                MessageBox.Show("Invalid Post Code., Try again!");
                lblErrorPostcode.Visible = true;
            }
            #endregion
            //works
            #region Email validation
            else if(ValidatorClass.CustomerValidation.IsValidEmail(tbxEmail.Text) == false)
            {
                resetErrors();
                MessageBox.Show("Invalid email format, please try again");
                lblErrorEmail.Visible = true;
            }
            #endregion
            //works
            #region Home address
            else if (ValidatorClass.CustomerValidation.IsValidHomeAddress(tbxAddress.Text) == false)
            {
                resetErrors();
                MessageBox.Show("Inavlid Address");
                lblErrorHome.Visible = true;
            }
            #endregion
            //Works
            #region Add customer
            else
            {
                resetErrors();
                CustomerDAL.AddCustomer
                    (
                    tbxFirstName.Text,
                    tbxSecondName.Text,
                    cbxGender.Text,
                    tbxAddress.Text,
                    tbxPostCode.Text,
                    tbxEmail.Text,
                    phoneNumber,
                    dtpDateBirth.Text
                    );
                    MessageBox.Show("New customer added!");
                    ClearFields();
                    Hide();
            }
            #endregion
            //works
        }
        #endregion
        //works
        #region Navigation
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void makeAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmBookAppointment().Show();
        }
        private void viewAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmViewAppointments().Show();
        }
        private void bookWeddingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmWeddingPlanning().Show();
        }
        private void viewWeddingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmViewWeddingBookings().Show();
        }
        #endregion
        //works

    }
}
