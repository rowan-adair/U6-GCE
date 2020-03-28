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
using System.Windows.Forms.ComponentModel;


namespace AdairRA2EventsUnlimited
{
    public partial class frmBookAppointment : Form
    {
        public List<int> listOfVenues = new List<int>();
        public List<int> daysOfWeek = new List<int>();
        public List<int> listOfStaff = new List<int>();
        public List<string> listOfSessions = new List<string>();
        public Regex regex = new Regex(@"[0-9]+");
        public Regex backSpace = new Regex(@"[\b]");
        public int selectedVenue;
        public int dayID;
        private int StaffID;
        public frmBookAppointment()
        {
            InitializeComponent();
            SetUp();
        }
        private void SetUp()
        {
            SetDateFormat();
            dtpDateOfAppointment.Value = dtpDateOfAppointment.MinDate;
            ClearFields();
            PopulateCustomer();
            PopulateVenue();
            cbxSession.Enabled = false;
            dtpDateOfAppointment.Enabled = false;
            btnMakeBooking.Enabled = false;
            cbxCustomerSelect.DropDownStyle = ComboBoxStyle.DropDown;
            cbxCustomerSelect.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbxCustomerSelect.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void ClearFields()
        {
            cbxCustomerSelect.SelectedIndex = -1;
            cbxVenue.SelectedIndex = -1;
            cbxSession.Text = null;
            cbxSession.Enabled = false;
            dtpDateOfAppointment.Value = DateTime.Today.AddDays(1);
        }
        private void SetDateFormat()
        {
            dtpDateOfAppointment.Format = DateTimePickerFormat.Custom;
            dtpDateOfAppointment.CustomFormat = "dd-MM-yyyy";
            dtpDateOfAppointment.MinDate = DateTime.Today.AddDays(1);
        }
        //Works
        private void PopulateCustomer()
        {
            cbxCustomerSelect.Items.Clear();
            List<string> ListOfCustomers = CustomerDAL.GetCustomer();
            List<int> ListOfCustomerID = new List<int>();
            List<int> ListOfUnavailableCustomers = new List<int>();
            foreach (var customer in ListOfCustomers)
            {
                ListOfCustomerID.Add(Convert.ToInt32(customer.Split(',')[0]));
            }
            for (int i = 0; i < ListOfCustomers.Count - 1; i++)
            {
                string[] selectedCustomer = ListOfCustomers[i].ToString().Split(',');
                DatabaseConnection.OpenConnection();
                SqlCommand checkCommand = new SqlCommand("CheckCustomerAppointment", DatabaseConnection.myConnection);
                checkCommand.CommandType = CommandType.StoredProcedure;
                checkCommand.Parameters.Add(new SqlParameter("@CustomerID", selectedCustomer[0]));
                SqlDataReader checkReader = checkCommand.ExecuteReader();
                while (checkReader.Read())
                {
                    int unavCustomer = Convert.ToInt32(checkReader["CustomerID"]);
                    ListOfUnavailableCustomers.Add(unavCustomer);
                }
                DatabaseConnection.CloseConnection();
                checkReader.Close();
            }
            try
            {
                foreach (var item in ListOfUnavailableCustomers)
                {
                    ListOfCustomerID.Remove(item);
                }
                ListOfCustomerID.RemoveAll(i => ListOfUnavailableCustomers.Contains(i));
            }
            catch (Exception)
            {
                cbxCustomerSelect.Text = "No customers";
            }
            for (int i = 0; i < ListOfCustomerID.Count; i++)
            {
                foreach (var customer in ListOfCustomers)
                {
                    string[] customerData = customer.Split(',');
                    if (Convert.ToInt32(customerData[0]) == ListOfCustomerID[i])
                    {
                        string populate = string.Format("{0}.{1} {2}", customerData[0], customerData[1], customerData[2]);
                        cbxCustomerSelect.Items.Add(populate);
                    }
                }
            }
            
        }
        //Works
        private void PopulateSession()
        {
            List<int> listOfBookedSessions = new List<int>();
            List<int> listOfBookedStaff = new List<int>();
            cbxSession.Enabled = true;
            lblSession.Enabled = true;
            DateTime dateOfApp;
            dateOfApp = dtpDateOfAppointment.Value;
            dayID = (int)dateOfApp.DayOfWeek + 1;
            listOfStaff = AppointmentDAL.SelectStaff(selectedVenue);
            for (int i = 0; i <= listOfStaff.Count - 1; i++)
            {
                foreach (var session in AppointmentDAL.AvailableSession(listOfStaff[i], dayID))
                {
                     listOfSessions.Add(session);
                }
                
                
            }
            for (int j = 0; j <= listOfStaff.Count - 1; j++)
            {
                DatabaseConnection.OpenConnection();
                SqlCommand myCommand = new SqlCommand("AvailableStaff", DatabaseConnection.myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("@StaffID", listOfStaff[j]));
                myCommand.Parameters.Add(new SqlParameter("@AppDate", dateOfApp));
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    int bookedSession = Convert.ToInt32(myReader["AppSlotID"]);
                    listOfBookedSessions.Add(bookedSession);
                    int bookedStaff = listOfStaff[j];
                    listOfBookedStaff.Add(bookedStaff);
                }
                DatabaseConnection.CloseConnection();
                myReader.Close();
                for (int k = 0; k <= listOfSessions.Count - 1; k++)
                {
                    string[] session = (listOfSessions[k].ToString().Split('.').ToArray());
                    for (int l = 0; l <= listOfBookedSessions.Count - 1; l++)
                    {
                        if (Convert.ToInt32(session[1]) == listOfBookedSessions[l])
                        {
                            for (int m = 0; m <= listOfBookedStaff.Count -1; m++)
                            {
                                if (Convert.ToInt32(session[0]) == listOfBookedStaff[m])
                                {
                                    listOfSessions.RemoveAt(k);
                                }
                            }
                        }
                    }
                }
                listOfBookedStaff.Clear();
                listOfBookedSessions.Clear();
            }
            for (int i = 0; i <= listOfSessions.Count - 1; i++)
            {
                string[] PopSession = listOfSessions[i].ToString().Split('.');
                string populate = string.Format("Session {0} Time: {1}", PopSession[1], PopSession[2]);
                if (!cbxSession.Items.Contains(populate))
                {
                    cbxSession.Items.Add(populate);
                }
            }
            if (listOfSessions.Count < 1)
            {
                cbxSession.Items.Add(string.Format("No sessions available"));
                cbxSession.SelectedIndex = 0;
            }
        }
        private void PopulateVenue()
        {
            cbxVenue.Items.Clear();
            try
            {
                foreach (var venue in AppointmentDAL.GetVenues())
                {
                    string[] venueInfoArray = venue.Split(',');
                    listOfVenues.Add(Convert.ToInt32(venueInfoArray[0]));
                    cbxVenue.Items.Add(venueInfoArray[1]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        #region Navigation
        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            new FrmCustomers().ShowDialog();
        }
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            new FrmAddCustomer().ShowDialog();
            Refresh();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        #endregion
        //Works
        #region Search for Customer
        private void cbxCustomerSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (regex.IsMatch(e.KeyChar.ToString()) == false)
            {
                e.Handled = true;
            }
            if(backSpace.IsMatch(e.KeyChar.ToString()) ==  true)
            {
                cbxCustomerSelect.Text = "";
            }
        }
        #endregion
        //Works
        #region Venue Selected Validation
        private void cbxVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxSession.Items.Clear();
            listOfStaff.Clear();
            listOfSessions.Clear();
            if(cbxVenue.SelectedIndex > -1 && cbxCustomerSelect.SelectedIndex > -1)
            {
                string venueSelect = cbxVenue.SelectedItem.ToString();
                selectedVenue = listOfVenues[cbxVenue.SelectedIndex];
                dtpDateOfAppointment.Enabled = true;
            }
            if (dtpDateOfAppointment.Enabled)
            {
                PopulateSession();
            }
        }
        #endregion
        //Works
        #region Make Booking
        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            try
            {
                int appId = Convert.ToInt32(cbxSession.Text.Substring(7, 3));
                for (int i = 0; i < listOfSessions.Count; i++)
                {
                    string[] PopSession = listOfSessions[i].ToString().Split('.');
                    if (Convert.ToInt32(PopSession[1]) == appId)
                    {
                        StaffID = Convert.ToInt32(PopSession[0]);
                        break;
                    }
                }
                string[] selectedCustomerArray = cbxCustomerSelect.Text.Split('.');
                int customerID = Convert.ToInt32(selectedCustomerArray[0]);
                AppointmentDAL.BookAppointment(customerID, StaffID, selectedVenue, appId, dtpDateOfAppointment.Text);

                MessageBox.Show("Appointment booked!", "Success");
                DialogResult userNewBooking = MessageBox.Show
                    (
                    "Would you like to book another appointment?", 
                    "New appointment?", 
                    MessageBoxButtons.YesNo
                    );
                if (userNewBooking == DialogResult.Yes)
                {
                    SetUp();
                }
                else if (userNewBooking == DialogResult.No)
                {
                    Hide();
                }
            }
            catch (Exception)
            {
                if (cbxSession.SelectedIndex == -1)
                {
                    MessageBox.Show("No session selected");
                }
                else
                {
                    MessageBox.Show("No session available");
                }
            }
        }
        #endregion
        //Works
        #region Date of Appointment Selected
        private void dtpDateOfAppointment_ValueChanged(object sender, EventArgs e)
        {
            cbxSession.Items.Clear();
            listOfStaff.Clear();
            listOfSessions.Clear();
            if (dtpDateOfAppointment.Enabled)
            {
                PopulateSession();
            }
        }
        private void cbxSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnMakeBooking.Enabled = true;
        }
        #endregion
        private void cbxCustomerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCustomerSelect.SelectedIndex == -1 && dtpDateOfAppointment.Enabled == false)
            {
                MessageBox.Show("Please select a customer");
            }
            if (cbxVenue.SelectedIndex > -1 && cbxCustomerSelect.SelectedIndex > -1)
            {
                string venueSelect = cbxVenue.SelectedItem.ToString();
                selectedVenue = listOfVenues[cbxVenue.SelectedIndex];
                dtpDateOfAppointment.Enabled = true;
            }
        }

        private void lblAppDate_Click(object sender, EventArgs e)
        {

        }
        //Works
    }
}