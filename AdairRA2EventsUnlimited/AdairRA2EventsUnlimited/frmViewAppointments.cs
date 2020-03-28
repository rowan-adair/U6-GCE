using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace AdairRA2EventsUnlimited
{
    public partial class frmViewAppointments : Form
    {
        #region Setup
        public int AppointmentID;
        private string appointmentItems;
        public List<int> listOfVenues = new List<int>();
        public List<int> listOfStaff = new List<int>();
        public List<string> listOfStaffNames = new List<string>();
        public List<string> listOfVenueNames = new List<string>();
        public List<CheckBox> listOfCheckBoxes = new List<CheckBox>();
        public Regex regex = new Regex(@"[0-9\b]+");
        public frmViewAppointments()
        {
            InitializeComponent();
            SetUp();
        }
        private void SetUp()
        {
            listOfCheckBoxes.Clear();
            ClearFields();
            GetFutureAppointments();
            tbxAppointmentNo.Enabled = false;
            tbxFirstname.Enabled = false;
            dtpDateSelect.Enabled = false;
            cbxStaff.Enabled = false;
            cbxVenue.Enabled = false;
            chbxPrevApp.Checked = false;
            btnSearch.Hide();
            listOfCheckBoxes.Add(chbxAppDate);
            listOfCheckBoxes.Add(chbxAppID);
            listOfCheckBoxes.Add(chbxName);
            listOfCheckBoxes.Add(chbxVenue);
            listOfCheckBoxes.Add(chbxStaff);
            listOfCheckBoxes.Add(chbxName);
        }
        private void ClearFields()
        {
            dtpDateSelect.Value = DateTime.Today;
            clbAppointment.SelectedIndex = -1;
        }
        private void CheckAllUncheck()
        {
            int noUnchecked = 0;
            foreach (CheckBox c in listOfCheckBoxes)
            {
                if (!c.Checked)
                {
                    noUnchecked += 1;
                }
                if (noUnchecked == listOfCheckBoxes.Count)
                {
                    btnSearch.Hide();
                }
            }
        }
        private void readAppointments(SqlDataReader myReader)
        {
            clbAppointment.Items.Clear();
            if (!chbxPrevApp.Checked)
            {
                while (myReader.Read())
                {

                    AppointmentID = Convert.ToInt32(myReader["AppointmentID"]);
                    string CustomerFirstname = myReader["CustomerFirstName"].ToString();
                    string CustomerSecondName = myReader["CustomerSurname"].ToString();
                    string StaffFirstname = myReader["StaffFirstName"].ToString();
                    string StaffSecondName = myReader["StaffSecondName"].ToString();
                    string VenueName = myReader["VenueName"].ToString();
                    string AppDate = Convert.ToDateTime(myReader["AppointmentDate"]).ToShortDateString();
                    string Session = myReader["AppSlotID"].ToString();
                    string TimeFrame = myReader["TimeSlot"].ToString();
                    string populate = string.Format("{0}| Staff: {1} {2} | Customer: {3} {4} | Venue: {5} | Date: {6} | Session : {7} , {8}hrs", AppointmentID, StaffFirstname, StaffSecondName, CustomerFirstname, CustomerSecondName, VenueName, AppDate, Session, TimeFrame);
                    if (Convert.ToDateTime(AppDate) > DateTime.Now)
                    {
                        clbAppointment.Items.Add(populate);
                    }
                }
            }
            else if (chbxPrevApp.Checked)
            {
                while (myReader.Read())
                {

                    AppointmentID = Convert.ToInt32(myReader["AppointmentID"]);
                    string CustomerFirstname = myReader["CustomerFirstName"].ToString();
                    string CustomerSecondName = myReader["CustomerSurname"].ToString();
                    string StaffFirstname = myReader["StaffFirstName"].ToString();
                    string StaffSecondName = myReader["StaffSecondName"].ToString();
                    string VenueName = myReader["VenueName"].ToString();
                    string AppDate = Convert.ToDateTime(myReader["AppointmentDate"]).ToShortDateString();
                    string Session = myReader["AppSlotID"].ToString();
                    string TimeFrame = myReader["TimeSlot"].ToString();
                    string populate = string.Format("{0}| Staff: {1} {2} | Customer: {3} {4} | Venue: {5} | Date: {6} | Session : {7} , {8}hrs", AppointmentID, StaffFirstname, StaffSecondName, CustomerFirstname, CustomerSecondName, VenueName, AppDate, Session, TimeFrame);
                    clbAppointment.Items.Add(populate);
                }
            }
            
        }
        private void PopulateVenue()
        {
            try
            {
                foreach (var venue in AppointmentDAL.GetVenues())
                {
                    string[] venueInfoArray = venue.Split(',');
                    listOfVenues.Add(Convert.ToInt32(venueInfoArray[0]));
                    listOfVenueNames.Add(venueInfoArray[1]);
                    cbxVenue.Items.Add(venueInfoArray[1]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
        private void PopulateStaff()
        {
            try
            {

                DatabaseConnection.OpenConnection();
                cbxStaff.Items.Clear();
                SqlCommand myCommand = new SqlCommand("SELECT * FROM [dbo].[Staff] WHERE staffRole = 1",DatabaseConnection.myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string StaffID = myReader["staffID"].ToString();
                    string StaffFirstname = myReader["StaffFirstName"].ToString();
                    string StaffSecondName = myReader["StaffSecondName"].ToString();
                    cbxStaff.Items.Add(StaffFirstname + " " + StaffSecondName);
                    listOfStaffNames.Add(StaffFirstname + " " + StaffSecondName);
                    listOfStaff.Add(Convert.ToInt32(StaffID));
                    
                }
                DatabaseConnection.CloseConnection();
                myReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                throw;
            }
        }
        #endregion
        //Works
        #region Navigation
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }
        #endregion
        //Works
        #region Get Appointments
        
        private void GetAllAppointments()
        {
            clbAppointment.Items.Clear();
            try
            {
                foreach (var appointment in AppointmentDAL.GetAppoitnments())
                {
                    clbAppointment.Items.Add(appointment);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing Present");
            }
        }
        private void GetFutureAppointments()
        {
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("GetAppointments", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader myReader = myCommand.ExecuteReader();
            readAppointments(myReader);
            DatabaseConnection.CloseConnection();
            myReader.Close();
        }
        private void GetAppointments()
        {
            if (chbxPrevApp.Checked)
            {
                btnCancelAppointment.Enabled = false;
                btnAppointmentChange.Enabled = false;
                GetAllAppointments();
            }
            else if (!chbxPrevApp.Checked)
            {
                btnCancelAppointment.Enabled = true;
                btnAppointmentChange.Enabled = true;
                GetFutureAppointments();
            }
        }
        #endregion
        //Works
        #region Delete Appointments
        private void deleteAppointment(int AppointmentID)
        {
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("DeleteAppointment", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.Add(new SqlParameter("@AppointmentID", AppointmentID));
            myCommand.ExecuteNonQuery();
            DatabaseConnection.CloseConnection();
            GetAppointments();
        }
        private void btnDelAppointment_Click(object sender, EventArgs e)
        {
            if (clbAppointment.CheckedItems.Count < 1)
            {
                MessageBox.Show("Error");
            }
            else
            {
                List<int> listOfAppointments = new List<int>();
                foreach (var appointment in clbAppointment.CheckedItems)
                {
                    string[] arrayOfAppointments = appointment.ToString().Split('|');
                    string appointmentID = arrayOfAppointments[0].Replace("|", "");
                    listOfAppointments.Add(Convert.ToInt32(appointmentID));
                }
                foreach (var item in listOfAppointments)
                {
                    deleteAppointment(item);
                }
                MessageBox.Show("Appointment deleted.");
            }
        }
        #endregion
        //Works
        #region Change Appointment Info
        private void btnAppointmentChange_Click(object sender, EventArgs e)
        {
            foreach (var appointment in clbAppointment.CheckedItems)
            {
                string[] arrayOfAppointments = appointment.ToString().Split('|');
                AppointmentID = Convert.ToInt32(arrayOfAppointments[0].Replace("|", ""));
            }
            DatabaseConnection.OpenConnection();
            clbAppointment.Items.Clear();
            SqlCommand myCommand = new SqlCommand("GetAppAppID", DatabaseConnection.myConnection);
            myCommand.Parameters.Add(new SqlParameter("@AppointmentID", AppointmentID));
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader myReader = myCommand.ExecuteReader();

            while (myReader.Read())
            {
                string CustomerFirstName = myReader["CustomerFirstName"].ToString();
                string CustomerSurname = myReader["CustomerSurname"].ToString();
                AppointmentID = Convert.ToInt32(myReader["AppointmentID"]);
                int VenueID = Convert.ToInt32(myReader["VenueID"]);
                string VenueName = myReader["VenueName"].ToString();
                string AppDate = Convert.ToDateTime(myReader["AppointmentDate"]).ToShortDateString();
                int Session = Convert.ToInt32(myReader["AppSlotID"]);
                string TimeFrame = myReader["TimeSlot"].ToString();
                appointmentItems = string.Format("{0},{1},{2},{3},{4},{5},{6},{7}", CustomerFirstName, CustomerSurname, AppointmentID, VenueID, VenueName,Session, TimeFrame, AppDate);
            }
            myReader.Close();
            DatabaseConnection.CloseConnection();
            new frmChangeAppointmentDate(appointmentItems).ShowDialog();
            GetAppointments();
        }
        #endregion
        //Testing Needed
        #region Check Changes
        private void chbxName_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxName.Checked)
            {
                btnSearch.Show();
                btnSearch.Text = "Search by Name";
                tbxFirstname.Enabled = true;
                foreach (var checkBox in listOfCheckBoxes)
                {
                    if (checkBox == chbxName)
                    {
                        btnSearch.Show();
                    }
                    else if (checkBox != chbxName)
                    {
                        btnSearch.Hide();
                        checkBox.Checked = false;
                    }
                }
            }
            else if (!chbxName.Checked)
            {
                tbxFirstname.Enabled = false;
                tbxFirstname.Text = "";
                GetAppointments();
            }
            CheckAllUncheck();



        }
        private void chbxAppDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAppDate.Checked)
            {
                btnSearch.Show();
                btnSearch.Text = "Search by Date of Appointment";

                dtpDateSelect.Enabled = true;
                foreach (var checkBox in listOfCheckBoxes)
                {
                    if (checkBox != chbxAppDate)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
            else if(!chbxAppDate.Checked)
            {
                dtpDateSelect.Enabled = false;
                dtpDateSelect.Value = DateTime.Today;
                GetAppointments();
            }
            CheckAllUncheck();


        }
        private void chbxVenue_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxVenue.Checked)
            {
                btnSearch.Show();
                btnSearch.Text = "Search by Venue";

                cbxVenue.Enabled = true;
                foreach (var checkBox in listOfCheckBoxes)
                {
                    if (checkBox != chbxVenue)
                    {
                        checkBox.Checked = false;
                    }
                }
                PopulateVenue();
            }
            else if (!chbxVenue.Checked)
            {
                cbxVenue.SelectedIndex = -1;
                cbxVenue.Items.Clear();
                cbxVenue.Enabled = false;
                GetAppointments();
            }
            CheckAllUncheck();
        }
        private void chbxStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxStaff.Checked)
            {
                btnSearch.Show();
                btnSearch.Text = "Search by Staff Member";
                cbxStaff.Enabled = true;
                foreach (var checkBox in listOfCheckBoxes)
                {
                    if (checkBox != chbxStaff)
                    {
                        checkBox.Checked = false;
                    }
                }
                PopulateStaff();
            }
            else if (!chbxStaff.Checked)
            {
                cbxStaff.SelectedIndex = -1;
                cbxStaff.Items.Clear();
                cbxStaff.Enabled = false;
                GetAppointments();
                

            }
            CheckAllUncheck();

        }
        private void chbxAppID_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAppID.Checked)
            {
                btnSearch.Show();
                btnSearch.Text = "Search by Appointment ID";

                tbxAppointmentNo.Enabled = true;
                foreach (var checkBox in listOfCheckBoxes)
                {
                    if (checkBox != chbxAppID)
                    {
                        checkBox.Checked = false;
                    }
                }
            }
            else if(!chbxAppID.Checked)
            {
                tbxAppointmentNo.Enabled = false;
                tbxAppointmentNo.Text = "";
                GetAppointments();
                

            }
            CheckAllUncheck();


        }
        #endregion
        //Works
        #region Searches
        private void Search()
        {
            #region Name Searching
            if (chbxName.Checked == true)
            {
                if (!string.IsNullOrWhiteSpace(tbxFirstname.Text))
                {
                    string customerName = ValidatorClass.CustomerValidation.NameToCapital(tbxFirstname.Text);
                    customerName = customerName.Replace(" ", "");
                    if (customerName.Any(char.IsDigit) == false)
                    {
                        try
                        {
                            DatabaseConnection.OpenConnection();
                            clbAppointment.Items.Clear();
                            SqlCommand myCommand = new SqlCommand("GetAppName", DatabaseConnection.myConnection);
                            myCommand.Parameters.Add(new SqlParameter("@name", customerName));
                            myCommand.CommandType = CommandType.StoredProcedure;
                            SqlDataReader myReader = myCommand.ExecuteReader();
                            readAppointments(myReader);
                            myReader.Close();
                            DatabaseConnection.CloseConnection();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid search\nSearch cannot be empty or contain numbers");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid search\nSearch cannot be empty or contain numbers");
                }
            }
            #endregion
            //Works
            #region Venue Searching
            if (chbxVenue.Checked)
            {
                if (!listOfVenueNames.Contains(cbxVenue.Text))
                {
                    MessageBox.Show("You must select a valid venue", "Error");
                    cbxVenue.Text = "";
                }
                else
                {
                    DatabaseConnection.OpenConnection();
                    clbAppointment.Items.Clear();
                    SqlCommand myComamnd = new SqlCommand("GetAppVenue", DatabaseConnection.myConnection);
                    myComamnd.Parameters.Add(new SqlParameter("@VenueID", listOfVenues[cbxVenue.SelectedIndex]));
                    myComamnd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader myReader = myComamnd.ExecuteReader();
                    readAppointments(myReader);
                    myReader.Close();
                    DatabaseConnection.CloseConnection();
                }
            }
            #endregion
            //Works
            #region Staff Search
            if (chbxStaff.Checked)
            {
                if (!listOfStaffNames.Contains(cbxStaff.Text))
                {
                    MessageBox.Show("You must select a valid staff member", "Error");
                    cbxStaff.Text = "";
                }
                else
                {
                    DatabaseConnection.OpenConnection();
                    clbAppointment.Items.Clear();
                    SqlCommand myCommand = new SqlCommand("GetAppStaff", DatabaseConnection.myConnection);
                    myCommand.Parameters.Add(new SqlParameter("@StaffID", listOfStaff[cbxStaff.SelectedIndex]));
                    myCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    readAppointments(myReader);
                    myReader.Close();
                    DatabaseConnection.CloseConnection();
                }
            }
            #endregion
            //Works
            #region Appointment ID Searching
            if (chbxAppID.Checked)
            {
                int search;
                if (int.TryParse(tbxAppointmentNo.Text, out search))
                {
                    DatabaseConnection.OpenConnection();
                    clbAppointment.Items.Clear();
                    SqlCommand myCommand = new SqlCommand("GetAppAppID", DatabaseConnection.myConnection);
                    myCommand.Parameters.Add(new SqlParameter("@AppointmentID", Convert.ToInt32(tbxAppointmentNo.Text)));
                    myCommand.CommandType = CommandType.StoredProcedure;
                    SqlDataReader myReader = myCommand.ExecuteReader();
                    readAppointments(myReader);
                    myReader.Close();
                    DatabaseConnection.CloseConnection();
                }
                else
                {
                    MessageBox.Show("Invalid search\n1.Search cannot contain characters");
                }
            }
            #endregion
            //Works
            #region Appointment date searching
            if (chbxAppDate.Checked)
            {
                DatabaseConnection.OpenConnection();
                clbAppointment.Items.Clear();
                SqlCommand myCommand = new SqlCommand("GetAppDate", DatabaseConnection.myConnection);
                myCommand.Parameters.Add(new SqlParameter("@AppointmentDate", Convert.ToDateTime(dtpDateSelect.Value)/*.ToShortDateString()*/));
                myCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader myReader = myCommand.ExecuteReader();
                readAppointments(myReader);
                myReader.Close();
                DatabaseConnection.CloseConnection();
            }
            #endregion
            //Works
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        #endregion
        //Works
        #region Key press
        private void tbxAppointmentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (regex.IsMatch(e.KeyChar.ToString()) == false)
            {
                e.Handled = true;
            }
        }
        #endregion
        //Works
        #region Make Booking
        private void btnBook_Click(object sender, EventArgs e)
        {
            new frmBookAppointment().ShowDialog();
            GetFutureAppointments();
        }
        #endregion
        //Works
        #region MenuStrip
        private void makeAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBookAppointment().ShowDialog();
        }
        private void viewAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmViewAppointments().Show();
        }
        private void bookWeddingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmWeddingPlanning().ShowDialog();
        }
        private void viewWeddingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmViewWeddingBookings().Show();
        }
        private void chbxPrevApp_CheckedChanged(object sender, EventArgs e)
        {
            GetAppointments();
        }
        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmStaffManagement(0).Show();
        }
        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmAddCustomer().ShowDialog();
        }
        private void viewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmCustomers().Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDAL.GetHelp();
        }
        #endregion
        //Works
    }
}
