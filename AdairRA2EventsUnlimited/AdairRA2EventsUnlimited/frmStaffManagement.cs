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
    public partial class frmStaffManagement : Form
    {
        private List<int> listOfStaffID = new List<int>();
        private List<string> listOfStaffNames = new List<string>();
        private List<string> listOfPossibleSessions = new List<string>();
        private List<string> listOfSessions = new List<string>();
        private List<string> listOfVenueID = new List<string>();
        private int tabIndex;
        public frmStaffManagement(int tabIndex)
        {
            this.tabIndex = tabIndex;
            InitializeComponent();
            SetUp(tabIndex);
        }
        private void frmStaffManagement_Load(object sender, EventArgs e)
        {
            

        }
        private void SetUp(int tabIndex)
        {
            tabControlStaff.SelectedIndex = tabIndex;
            PopulateVenue();
            PopulateRoles();
            PopulateComboStaff();
            PopulateStaffDataGrid();

            btnAddSession.Enabled = false;
            chbxAvailability.Checked = false;
            chbxAvailability.Enabled = false;

            cbxRole.SelectedIndex = -1;
            cbxVenue.SelectedIndex = -1;
            cbxSession.SelectedIndex = -1;
            cbxDaySearch.SelectedIndex = -1;

            lblVenue.Text = string.Format("Venue : ");

            tbxForename.Text = "";
            tbxSurname.Text = "";

            lbxSessions.Items.Clear();

            lblShowVenue.Hide();
            HideErrors();
        }
        private void ResetAvailability()
        {
            cbxStaff.SelectedIndex = -1;
            cbxSession.SelectedIndex = -1;
            cbxSession.Items.Clear();
            cbxDaySearch.SelectedIndex = -1;
            cbxDays.SelectedIndex = -1;

            cbxDaySearch.Enabled = false;
            chbxAvailability.Checked = false;
            chbxAvailability.Enabled = false;
            gbxManageAv.Enabled = false;
            btnAddSession.Enabled = false;
        }
        private void HideErrors()
        {
            lblErrorDay.Hide();
            lblErrorSession.Hide();
            lblForenameError.Hide();
            lblRoleError.Hide();
            lblSurnameError.Hide();
            lblVenueError.Hide();
        }
        private void PopulateVenue()
        {
            cbxVenue.Items.Clear();
            List<string> ListOfVenues = AppointmentDAL.GetVenues();
            foreach (var venue in ListOfVenues)
            {
                cbxVenue.Items.Add(venue);
            }
        }
        private void PopulateRoles()
        {
            cbxRole.Items.Clear();
            foreach (var role in StaffDAL.GetRoles())
            {
                cbxRole.Items.Add(role);
            }
        }
        private void PopulateComboStaff()
        {
            try
            {
                DatabaseConnection.OpenConnection();
                cbxStaff.Items.Clear();
                cbxStaff.Items.Add("<None>");
                SqlCommand myCommand = new SqlCommand("SELECT * FROM [dbo].[Staff] WHERE staffRole = 1", DatabaseConnection.myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string StaffID = myReader["staffID"].ToString();
                    string StaffFirstname = myReader["StaffFirstName"].ToString();
                    string StaffSecondName = myReader["StaffSecondName"].ToString();
                    string venueID = myReader["VenueID"].ToString();
                    listOfVenueID.Add(venueID);
                    cbxStaff.Items.Add(StaffFirstname + " " + StaffSecondName);
                    listOfStaffNames.Add(StaffFirstname + " " + StaffSecondName);
                    listOfStaffID.Add(Convert.ToInt32(StaffID));

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

        private void GetTimeSlots()
        {
            cbxSession.Items.Clear();
            listOfSessions.Clear();
            listOfPossibleSessions.Clear();

            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("SELECT * FROM AppSlots", DatabaseConnection.myConnection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                listOfPossibleSessions.Add(String.Format("{0}.{1}", myReader["AppSlotID"].ToString(), myReader["TimeSlot"].ToString()));
            }
            myReader.Close();
            DatabaseConnection.CloseConnection();
        }

        private void PopulateComboSession(int staffID, int dayID)
        {
            GetTimeSlots();
            listOfSessions = AppointmentDAL.AvailableSession(staffID, dayID);
            foreach (var session in listOfSessions)
            {
                string[] sessionObject = session.Split('.');
                int i = 0;
                while(i<listOfPossibleSessions.Count)
                {
                    string[] appslotID = listOfPossibleSessions[i].Split('.');
                    if (sessionObject[1] == appslotID[0])
                    {
                        listOfPossibleSessions.RemoveAt(i);
                        i = 1;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            if (listOfPossibleSessions.Count >= 1)
            {
                foreach (var session in listOfPossibleSessions)
                {
                    string[] sessionObject = session.Split('.');
                    string populate = string.Format("{0}. Time {1}", sessionObject[0], sessionObject[1]);
                    cbxSession.Items.Add(populate);
                    btnAddSession.Enabled = true;
                }
            }
            else if(listOfPossibleSessions.Count < 1)
            {
                cbxSession.Items.Add(string.Format("No Sessions Available"));
                cbxSession.SelectedIndex = 0;
                btnAddSession.Enabled = false;
            }
        }
        private void PopulateStaffDataGrid()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = StaffDAL.FillStaffDataGridView();
            adapter.Fill(dt);
            dgvStaff.DataSource = dt;
            dgvStaff.DataMember = dt.TableName;
            dgvStaff.Columns[0].HeaderCell.Value = "Staff ID";
            dgvStaff.Columns[1].HeaderCell.Value = "Forename";
            dgvStaff.Columns[2].HeaderCell.Value = "Surname";
            dgvStaff.Columns[3].HeaderCell.Value = "Role";
            dgvStaff.Columns[4].HeaderCell.Value = "Venue Name";
            dgvStaff.Columns[5].HeaderCell.Value = "Venue Address";
            dgvStaff.Columns[6].HeaderCell.Value = "Venue Telephone";

        }
        private void PopulateSession(int StaffID)
        {
            lbxSessions.Items.Clear();
            List<string> ListOfSessions = StaffDAL.GetSession(StaffID);
            try
            {
                foreach (var session in ListOfSessions)
                {
                    string dayCombo = cbxDaySearch.Text.Split('.')[1];
                    string day = session.Split('|')[0];
                    if (dayCombo == day)
                    {
                        lbxSessions.Items.Add(session);
                    }
                }
                if (lbxSessions.Items.Count < 1)
                {
                    lbxSessions.Items.Add("No sessions today");
                }
            }
            catch (Exception)
            {
                lbxSessions.Text = ListOfSessions[0];
            }
        }
        private void cbxStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStaff.Text == "<None>" || cbxStaff.SelectedIndex == -1)
            {
                SetUp(2);
            }
            else
            {
                gbxManageAv.Enabled = true;
                cbxDaySearch.Enabled = true;
                chbxAvailability.Enabled = true;
                cbxDays.SelectedIndex = -1;
                cbxDaySearch.SelectedIndex = -1;
                lblShowVenue.Show();
                lblShowVenue.Text = string.Format("Venue : {0}", listOfVenueID[cbxStaff.SelectedIndex - 1]);
            }
        }

        private void cbxDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDays.SelectedIndex >= 0)
            {
                cbxSession.Enabled = true;
                PopulateComboSession(listOfStaffID[cbxStaff.SelectedIndex - 1], Convert.ToInt32(cbxDays.Text.Split('.')[0]));
            }
        }

        private void cbxDay2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxDaySearch.SelectedIndex == -1)
            {
                lbxSessions.Items.Clear();
            }
            else if (!listOfStaffNames.Contains(cbxStaff.Text))
            {
                lbxSessions.Items.Clear();
                MessageBox.Show("Please select a valid member of staff");
                cbxStaff.Text = "";
            }
            else
            {
                PopulateSession(listOfStaffID[cbxStaff.SelectedIndex - 1]);
            }
        }
        private void btnAddSession_Click(object sender, EventArgs e)
        {
            if (cbxDays.SelectedIndex == -1 || cbxSession.SelectedIndex == -1)
            {
                MessageBox.Show("You haven't selected a day or session", "Error"); lblErrorDay.Show(); lblErrorSession.Show();
            }
            else
            {
                lblErrorDay.Hide(); lblErrorSession.Hide();
                StaffDAL.NewAvailability(listOfStaffID[cbxStaff.SelectedIndex - 1], Convert.ToInt32(cbxSession.Text.Split('.')[0]), Convert.ToInt32(cbxDays.Text.Split('.')[0]));
                PopulateSession(listOfStaffID[cbxStaff.SelectedIndex-1]);
                cbxSession.SelectedIndex = -1;
                DialogResult userNewSession = MessageBox.Show("Would you like to add another session?", "New session?", MessageBoxButtons.YesNo);
                if (userNewSession == DialogResult.Yes)
                {
                    chbxAvailability.Checked = true;
                    PopulateComboSession(listOfStaffID[cbxStaff.SelectedIndex -1], Convert.ToInt32(cbxDays.Text.Split('.')[0]));
                }
                else if (userNewSession == DialogResult.No)
                {
                    ResetAvailability();
                    
                }

            }
        }
        
        private void chbxAvailability_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbxAvailability.Checked)
            {
                gbxManageAv.Enabled = false;
                cbxDays.SelectedIndex = -1;
                cbxStaff.SelectedIndex = -1;
                cbxSession.Items.Clear();
                
            }
            else if (chbxAvailability.Checked)
            {
                gbxManageAv.Enabled = true;
                cbxDays.Enabled = true;


            }
        }
        #region Add Staff
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            try
            {
                HideErrors();
                if (ValidatorClass.CustomerValidation.IsValidName(tbxForename.Text, tbxSurname.Text) == false)
                {
                    MessageBox.Show("Invalid name", "Error");
                    lblForenameError.Show(); lblSurnameError.Show();
                }
                else if (cbxRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a staff role", "Error");
                    lblRoleError.Show();

                }
                else if(cbxVenue.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a venue", "Error");
                    lblVenueError.Show();
                }
                else
                {
                    StaffDAL.AddStaff(tbxForename.Text, tbxSurname.Text, Convert.ToInt32(cbxRole.Text.Split(',')[0]), Convert.ToInt32(cbxVenue.Text.ToString().Split(',')[0]));
                    SetUp(0);
                    MessageBox.Show("Staff member added!");
                    tabstaff.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error while adding staff\nPLease try again!", "Error");
            }
        }
        #endregion
        //works
        #region Navigation
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }
        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmStaffManagement(0).Show();
        }
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
        #endregion
        //works
    }
}
