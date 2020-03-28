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
using System.Globalization;
using System.Text.RegularExpressions;

namespace AdairRA2EventsUnlimited
{
    public partial class frmEditCustomer : Form
    {
        public List<string> CustomerItems;
        private List<Label> listOfErrorLabels = new List<Label>();
        private string phoneNumber;
        public frmEditCustomer(string EditCustomer)
        {
            InitializeComponent();
            SetUp(EditCustomer);
        }
        private void SetUp(string EditCustomer)
        {
            ClearFields();
            populateForm(EditCustomer);
            listOfErrorLabels.Add(lblErrorEmail);
            listOfErrorLabels.Add(lblErrorFirstname);
            listOfErrorLabels.Add(lblErrorSurname);
            listOfErrorLabels.Add(lblErrorHome);
            listOfErrorLabels.Add(lblErrorPhone);
            listOfErrorLabels.Add(lblErrorPostcode);
            resetErrors();
        }
        public void populateForm(string EditCustomer)
        {
            CustomerItems = EditCustomer.Split(',').ToList();
            tbxFirstName.Text = CustomerItems[1];
            tbxSecondName.Text = CustomerItems[2];
            tbxAddress.Text = CustomerItems[4];
            tbxPostCode.Text = CustomerItems[5];
            tbxEmail.Text = CustomerItems[6];
            tbxPhoneNumber.Text = CustomerItems[7];//.Trim(new char[] { '+', '4' });
            Text = String.Format("Edit Customer : " + CustomerItems[1] + " " + CustomerItems[2]);
        }
        private void ClearFields()
        {
            tbxFirstName.Text = " ";
            tbxSecondName.Text = " ";
            tbxPhoneNumber.Text = " ";
            tbxAddress.Text = " ";
            tbxEmail.Text = " ";
            tbxPostCode.Text = " ";
        }
        private void resetErrors()
        {
            foreach (var label in listOfErrorLabels)
            {
                label.Visible = false;
            }
        }
        private void btnEditCustomer_Click(object sender, EventArgs e)
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
            resetErrors();
            #region Not empty validation
            if (
                string.IsNullOrWhiteSpace(tbxFirstName.Text) 
                || string.IsNullOrWhiteSpace(tbxSecondName.Text) 
                || string.IsNullOrWhiteSpace(tbxPostCode.Text)
                || string.IsNullOrWhiteSpace(tbxEmail.Text) 
                || string.IsNullOrWhiteSpace(tbxAddress.Text)
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
                MessageBox.Show("Invalid name", "Error");
                lblErrorFirstname.Visible = true; lblErrorSurname.Visible = true;
            }
            #endregion
            //works
            #region Phone validation
            else if (ValidatorClass.CustomerValidation.IsValidPhoneNumber(phoneNumber) == false)
            {
                MessageBox.Show("Invalid UK phone number, please try again");
                lblErrorPhone.Visible = true;
            }
            #endregion
            //works
            #region Postcode validation
            else if (ValidatorClass.CustomerValidation.IsValidPostCode(tbxPostCode.Text) == false)
            {
                MessageBox.Show("Invalid Post Code., Try again!");
                lblErrorPostcode.Visible = true;
            }
            #endregion
            //works
            #region Email validation
            else if (ValidatorClass.CustomerValidation.IsValidEmail(tbxEmail.Text) == false)
            {
                MessageBox.Show("Invalid email format, please try again");
                lblErrorEmail.Visible = true;
            }
            #endregion
            //works
            #region Home address
            else if (ValidatorClass.CustomerValidation.IsValidHomeAddress(tbxAddress.Text) == false)
            {
                MessageBox.Show("Inavlid Address");
                lblErrorHome.Visible = true;
            }
            #endregion
            //Works
            else
            {
                CustomerDAL.UpdateCustomer
                    (
                    CustomerItems[0],
                    tbxFirstName.Text,
                    tbxSecondName.Text,
                    tbxAddress.Text,
                    tbxPostCode.Text,
                    tbxEmail.Text,
                    phoneNumber,
                    CustomerItems[8]
                    );

                MessageBox.Show("Update Accepted");
                Hide();
                ClearFields();
            } 
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            ClearFields(); 
        }
    }
}
