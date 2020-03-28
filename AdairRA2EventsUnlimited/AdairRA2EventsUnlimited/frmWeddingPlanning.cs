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
    public partial class frmWeddingPlanning : Form
    {
        #region Values
        private string discountString;
        private decimal invitations = 100;
        private decimal flowers = 150;
        private decimal dress = 400;
        private decimal suits = 200;
        private decimal travel = 300;
        private decimal cars = 450;
        private decimal venueCost = 500;
        private decimal deposit;
        private decimal overallCost;
        private decimal estimatedCost;
        private int noOfGuests;
        private int SelectStaffID;
        private char charBookingConfirmed;
        private char invitationsSelect = 'N';
        private char flowerSelect = 'N';
        private char dressSelect = 'N';
        private char suitsSelect = 'N';
        private char weddingCarsSelect = 'N';
        private char travelSelect = 'N';
        private DateTime dateOfWedding;
        private DateTime conflictingDate;
        private Random rnd = new Random();
        private Regex regex = new Regex(@"[0-9\b]+");
        private List<int> ListOfVenueID = new List<int>();
        private List<int> ListOfEntertainmentID = new List<int>();
        private List<int> ListOfMenuID = new List<int>();
        private List<int> ListOfCustomerID = new List<int>();
        private List<int> ListOfCustomerAppointmentsID = new List<int>();
        private List<int> ListOfStaff = new List<int>();
        private List<decimal> listOfMenuCosts = new List<decimal>();
        private List<decimal> listOfEntertainmentCosts = new List<decimal>();
        private List<string> listOfVenues = new List<string>();
        private List<string> listOfMenus = new List<string>();
        private List<string> listOfEntertainment = new List<string>();
        #endregion 
        //Works
        #region Setup
        public frmWeddingPlanning()
        {
            InitializeComponent();
            SetUp();
        }
        //Works
        private void SetUp()
        {
            overallCost = 0;

            GetCustomer();
            SetDateFormat();
            cbxVenue.Items.Clear();
            cbxMenu.Items.Clear();
            nudGuests.Value = nudGuests.Minimum;
            List<CheckBox> listOfCheckboxes = new List<CheckBox>{cbDress, cbFlowers, cbInvitations, cbSuits, cbTravelArrangement, cbWeddingCars};
            foreach (var checkbox in listOfCheckboxes)
            {
                checkbox.Checked = false;
                checkbox.Enabled = false;
            }
            cbxCustomerSelect.Text = null;
            cbxCustomerSelect.SelectedIndex = -1;
            cbxMenu.Text = null;
            cbxMenu.SelectedIndex = -1;
            cbxVenue.Text = null;
            cbxVenue.SelectedIndex = -1;
            cbxEntertainment.Text = null;
            lblEstimate.Visible = false;
            lblDiscount.Visible = false;
            cbxEntertainment.SelectedIndex = -1;
            btnEstimate.Enabled = false;
            btnConfirm.Enabled = false;
            cbxVenue.Enabled = false;
            cbxMenu.Enabled = false;
            cbxEntertainment.Enabled = false;
            nudGuests.Enabled = false;
            dtpWedding.Enabled = false;
        }
        //Works
        private bool CheckWeddingDate(DateTime DateOfWedding)
        {
            dateOfWedding = dtpWedding.Value;
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("CheckWeddings", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.Add(new SqlParameter("@dateOfWedding", DateOfWedding));
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                conflictingDate = Convert.ToDateTime(myReader["DateOfWedding"]);
            }
            myReader.Close();
            DatabaseConnection.CloseConnection();
            if (DateOfWedding == conflictingDate)
	        {
                return true;
	        }
            else
            {
                return false;
            }
        }
        //Works
        private void GetCustomer()
        {
            List<string> ListOfCustomers = new List<string>();
            List<int> ListOfUnavailableCustomerID = new List<int>();
            ListOfUnavailableCustomerID.Clear();
            ListOfCustomerID.Clear();
            ListOfCustomers.Clear();
            try
            {
                DatabaseConnection.OpenConnection();
                cbxCustomerSelect.Items.Clear();
                SqlCommand myCommand = new SqlCommand("GetPastAppointmentCustomer", DatabaseConnection.myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string CustomerID = myReader["CustomerID"].ToString();
                    string FirstName = myReader["CustomerFirstName"].ToString();
                    string Surname = myReader["CustomerSurname"].ToString();
                    string Customer = string.Format("{0}:{1} {2}", CustomerID, FirstName, Surname);
                    ListOfCustomers.Add(Customer);
                    ListOfCustomerID.Add(Convert.ToInt32(CustomerID));
                }
                DatabaseConnection.CloseConnection();
                myReader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
                throw;
            }
            for (int i = 0; i < ListOfCustomers.Count; i++)
            {
                DatabaseConnection.OpenConnection();
                SqlCommand checkCommand1 = new SqlCommand("CheckCustomerWedding", DatabaseConnection.myConnection);
                checkCommand1.CommandType = CommandType.StoredProcedure;
                checkCommand1.Parameters.Add(new SqlParameter("@CustomerID",ListOfCustomerID[i]));
                SqlDataReader checkReader1 = checkCommand1.ExecuteReader();
                while (checkReader1.Read())
                {
                    int unavCustomer = Convert.ToInt32(checkReader1["CustomerID"]);
                    ListOfUnavailableCustomerID.Add(unavCustomer);
                }
                DatabaseConnection.CloseConnection();
                checkReader1.Close();
            }
            List<string> distinctListOfCustomers = new List<string>();
            try
            {
                for (int j = 0; j <= ListOfCustomerID.Count - 1; j++)
                {
                    for (int k = 0; k <= ListOfUnavailableCustomerID.Count - 1; k++)
                    {
                        if (ListOfCustomerID[j] == ListOfUnavailableCustomerID[k])
                        {
                            ListOfCustomers.RemoveAt(j);
                            ListOfCustomerID.RemoveAt(j);
                        }
                    }
                }
            }
            catch (Exception)
            {
                distinctListOfCustomers = ListOfCustomers.Distinct().ToList();
            }
            distinctListOfCustomers = ListOfCustomers.Distinct().ToList();
            foreach (var customer in distinctListOfCustomers)
            {
                cbxCustomerSelect.Items.Add(customer);
            }

            
        }
        //Works
        private void GetVenues()
        {
            DatabaseConnection.OpenConnection();
            cbxVenue.Items.Clear();
            SqlCommand myCommand = new SqlCommand("SELECT * FROM [dbo].[Venue]",DatabaseConnection.myConnection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                int venueID = Convert.ToInt32(myReader["VenueID"]);
                string venueName = myReader["VenueName"].ToString();
                string populate = string.Format("{0}, cost estimate : £{1}", venueName, venueCost.ToString());
                listOfVenues.Add(populate);
                ListOfVenueID.Add(venueID);
                cbxVenue.Items.Add(populate);
                
            }
            myReader.Close();
            DatabaseConnection.CloseConnection();
        }
        //Works
        private void GetMenus()
        {
            DatabaseConnection.OpenConnection();
            cbxMenu.Items.Clear();
            SqlCommand myCommand = new SqlCommand("GetMenus", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                int menuID = Convert.ToInt32(myReader["MenuID"]);
                int noOfcourses = Convert.ToInt32(myReader["NoOfCourses"]);
                decimal menuPrice = Convert.ToDecimal(myReader["Price"]);
                string populate = string.Format("{0} courses, cost estimate : £{1}", (noOfcourses.ToString()), (menuPrice.ToString()));
                cbxMenu.Items.Add(populate);
                listOfMenus.Add(populate);
                listOfMenuCosts.Add(menuPrice);
                ListOfMenuID.Add(menuID);
            }
            myReader.Close();
            DatabaseConnection.CloseConnection();
        }
        //Works
        private void GetEntertaiment()
        {
            DatabaseConnection.OpenConnection();
            cbxEntertainment.Items.Clear();
            SqlCommand myCommand = new SqlCommand("SELECT * FROM [dbo].[WeddingEntertainment]",DatabaseConnection.myConnection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                int entertainmentID = Convert.ToInt32(myReader["WeddingEntertainmentID"]);
                string entertainmentType = myReader["Type"].ToString();
                decimal entertainmentPrice = Convert.ToDecimal(myReader["Price"]);
                listOfEntertainmentCosts.Add(entertainmentPrice);
                string populate = string.Format("{0} entertainer, cost estimate : £{1}", entertainmentType, entertainmentPrice.ToString());
                ListOfEntertainmentID.Add(entertainmentID);
                listOfEntertainment.Add(populate);
                cbxEntertainment.Items.Add(populate);
            }
            myReader.Close();
            DatabaseConnection.CloseConnection();
        }
        //Works
        private void GetStaff(int venueID)
        {
            try
            {
                ListOfStaff.Clear();
                DatabaseConnection.OpenConnection();
                SqlCommand myCommand = new SqlCommand("GetCoordinators", DatabaseConnection.myConnection);
                myCommand.Parameters.Add(new SqlParameter("@venueID", venueID));
                myCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    int staffID = Convert.ToInt32(myReader["staffID"]);
                    ListOfStaff.Add(staffID);
                }
                myReader.Close();
                DatabaseConnection.CloseConnection();
                int index = rnd.Next(ListOfStaff.Count);
                SelectStaffID = ListOfStaff[index];   
            }
            catch (ArgumentOutOfRangeException)
            {
                DialogResult d = MessageBox.Show("There are no co-ordinators assigned to this venue, new one?\nIf no, then this form will be refreshed.", "No Staff", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    new frmStaffManagement(1).Show();
                }
                else if (d == DialogResult.No)
                {
                    SetUp();
                }
                //change made - missing try catch and addition of y/n messagebox upon catch of system exception
            }
            
        }
        //Works
        private void SetDateFormat()
        {
            dtpWedding.Format = DateTimePickerFormat.Custom;
            dtpWedding.CustomFormat = "dd-MM-yyyy";
            dtpWedding.MinDate = DateTime.Today.AddMonths(1);
            dtpWedding.Value = dtpWedding.MinDate;
        }
        //Works
        #endregion
        //Works
        #region Navigation
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }
        #endregion
        //Works
        #region Estimate
        private void btnEstimate_Click(object sender, EventArgs e)
        {
            noOfGuests = Convert.ToInt32(nudGuests.Value);
            DateTime dateOfWedding = dtpWedding.Value;
            DateTime today = DateTime.Today;
            var dateSpan = ValidatorClass.DateTimeSpan.CompareDates(dateOfWedding, today);
            if (dateSpan.Years >= 1 && dateSpan.Years <= 2 && dateSpan.Months > 6)
            {
                estimatedCost = overallCost - ((overallCost/100) * 5);
                discountString = "Discount of 5% off";
            }
            else if (dateSpan.Years >= 1 && dateSpan.Months > 6 && dateSpan.Years < 2)
            {
                overallCost = overallCost - ((overallCost / 100) * 7);
                discountString = "Discount of 7% off";
            }
            else if (dateSpan.Years >= 2  && noOfGuests > 50)
            {
                estimatedCost = overallCost - ((overallCost / 100) * 8);
                discountString = "Discount of 8% off";
            }
            else if (dateSpan.Years >= 2 && noOfGuests < 50)
            {
                estimatedCost = overallCost - ((overallCost / 100) * 7);
                discountString = "Discount of 7% off";
            }
            else
            {
                estimatedCost = overallCost;
                //document change - missing else statement.
            }
            deposit = ((estimatedCost / 100) * 10);
            
            string cost = estimatedCost.ToString();
            string estString =  string.Format("Estimated Cost : £{0}",cost);
            btnConfirm.Enabled = true;
            lblEstimate.Visible = true;
            lblDiscount.Visible = true;
            lblEstimate.Text = estString;
            lblDiscount.Text = discountString;
        }
        #endregion
        //Works
        #region Confirm Booking
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            if (!listOfVenues.Contains(cbxVenue.Text))
            {
                MessageBox.Show("Invalid Venue","Error");
            }
            else if (!listOfMenus.Contains(cbxMenu.Text))
            {
                MessageBox.Show("Invalid Menu","Error");
            }
            else if (!listOfEntertainment.Contains(cbxEntertainment.Text))
            {
                MessageBox.Show("Invalid Entertainment","Error");
            }
            int customerID = ListOfCustomerID[cbxCustomerSelect.SelectedIndex];
            DialogResult bookingConfirmed = MessageBox.Show("Has the customer confirmed the booking","Deposit", MessageBoxButtons.YesNo);
            if (bookingConfirmed == DialogResult.Yes)
            {
                charBookingConfirmed = 'Y';
            }
            else if (bookingConfirmed == DialogResult.No)
            {
                charBookingConfirmed = 'N';
            }
            try
            {
                DatabaseConnection.OpenConnection();
                SqlCommand myCommand = new SqlCommand("MakeWeddingBooking", DatabaseConnection.myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(new SqlParameter("@CustomerID", customerID));
                myCommand.Parameters.Add(new SqlParameter("@VenueID", ListOfVenueID[cbxVenue.SelectedIndex]));
                myCommand.Parameters.Add(new SqlParameter("@EntertainmentID", ListOfEntertainmentID[cbxEntertainment.SelectedIndex]));
                myCommand.Parameters.Add(new SqlParameter("@MenuID", ListOfMenuID[cbxMenu.SelectedIndex]));
                myCommand.Parameters.Add(new SqlParameter("@Invitations", invitationsSelect));
                myCommand.Parameters.Add(new SqlParameter("@Flowers", flowerSelect));
                myCommand.Parameters.Add(new SqlParameter("@Dress", dressSelect));
                myCommand.Parameters.Add(new SqlParameter("@Suits", suitsSelect));
                myCommand.Parameters.Add(new SqlParameter("@WeddingCars", weddingCarsSelect));
                myCommand.Parameters.Add(new SqlParameter("@TravelArrangements", travelSelect));
                myCommand.Parameters.Add(new SqlParameter("@StaffID", SelectStaffID));
                myCommand.Parameters.Add(new SqlParameter("@DateOfWedding", dtpWedding.Value));
                myCommand.Parameters.Add(new SqlParameter("@NumGuests", noOfGuests));
                myCommand.Parameters.Add(new SqlParameter("@OverallCost", overallCost));
                myCommand.Parameters.Add(new SqlParameter("@DepositCost", deposit));
                myCommand.Parameters.Add(new SqlParameter("@BookingConfirmed", charBookingConfirmed));
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Wedding booked!", "Success");
                SetUp();

                DatabaseConnection.CloseConnection();
            }
            catch (Exception)
            {
                MessageBox.Show("Missing data, check form","Error");
            }
        }
        #endregion
        //Works
        #region Check changing events
        private void cbInvitations_CheckedChanged(object sender, EventArgs e)
        {
            if (cbInvitations.Checked)
            {
                overallCost += invitations;
                invitationsSelect = 'Y';
            }
            else if(!cbInvitations.Checked)
            {
                overallCost -= invitations;
                invitationsSelect = 'N';
            }
        }
        private void cbFlowers_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFlowers.Checked)
            {
                overallCost += flowers;
                flowerSelect = 'Y';
            }
            else if(!cbFlowers.Checked)
            {
                overallCost -= flowers;
                flowerSelect = 'N';
            }
        }
        private void cbSuits_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSuits.Checked)
            {
                overallCost += suits;
                suitsSelect = 'Y';
            }
            else if(!cbSuits.Checked)
            {
                overallCost -= suits;
                suitsSelect = 'N';
            }
        }
        private void cbDress_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDress.Checked)
            {
                overallCost += dress;
                dressSelect = 'Y';
            }
            else if(!cbDress.Checked)
            {
                overallCost -= dress;
                dressSelect = 'N';
            }
        }
        private void cbWeddingCars_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWeddingCars.Checked)
            {
                overallCost += cars;
                weddingCarsSelect = 'Y';
            }
            else if (!cbWeddingCars.Checked)
            {
                overallCost -= cars;
                weddingCarsSelect = 'N';
            }
        }
        private void cbTravelArrangement_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTravelArrangement.Checked)
            {
                overallCost += travel;
                travelSelect = 'Y';
            }
            else if(!cbTravelArrangement.Checked)
            {
                overallCost -= travel;
                travelSelect = 'N';
            }
        }
        #endregion
        //Works
        #region Date of Wedding
        private void dtpWedding_ValueChanged(object sender, EventArgs e)
        {
            if (cbxCustomerSelect.SelectedIndex == -1 && dtpWedding.Value != DateTime.Today.AddMonths(1))
            {
                MessageBox.Show("Please select a customer");
            }
            else if (CheckWeddingDate(dtpWedding.Value)== true)
	        {
                MessageBox.Show("There is a wedding booked on this date\nPlease select a different date");
	        }
            else if (cbxCustomerSelect.SelectedIndex > -1 && CheckWeddingDate(dtpWedding.Value) == false)
            {
                GetMenus();
                GetEntertaiment();
                GetVenues();
                cbxMenu.Enabled = true;
                cbxEntertainment.Enabled = true;
                cbxVenue.Enabled = true;
                nudGuests.Enabled = true;
            }
        }
        #endregion
        //Works
        #region Combobox Selection
        private void cbxVenue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVenue.SelectedIndex > -1)
            {
                overallCost += venueCost;
                GetStaff(ListOfVenueID[cbxVenue.SelectedIndex]);
            }
        }
        private void cbxEntertainment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEntertainment.SelectedIndex > -1)
            {
                overallCost += listOfEntertainmentCosts[cbxEntertainment.SelectedIndex];
            }
        }
        private void cbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMenu.SelectedIndex > -1)
            {
                overallCost += listOfMenuCosts[cbxMenu.SelectedIndex];
                List<CheckBox> listOfCheckboxes = new List<CheckBox> { cbDress, cbFlowers, cbInvitations, cbSuits, cbTravelArrangement, cbWeddingCars };
                foreach (var checkbox in listOfCheckboxes)
                {
                    checkbox.Enabled = true;
                }
                btnEstimate.Enabled = true;
            }
        }
        #endregion
        //Works
        #region Cancel
        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbWeddingCars.Checked = false;
            cbTravelArrangement.Checked = false;
            cbInvitations.Checked = false;
            cbDress.Checked = false;
            cbSuits.Checked = false;
            cbFlowers.Checked = false;
            overallCost = 0;
            cbxMenu.Items.Clear();
            cbxVenue.Items.Clear();
            cbxEntertainment.Items.Clear();
            cbxCustomerSelect.SelectedIndex = -1;
            SetUp();
        }
        #endregion
        //Works
        #region Guests
        private void nudGuests_ValueChanged(object sender, EventArgs e)
        {
            noOfGuests = Convert.ToInt32(nudGuests.Value);
        }
        #endregion
        //Works
        #region Customer Searching
        private void cbxCustomerSelect_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (regex.IsMatch(e.KeyChar.ToString()) == false)
            {
                e.Handled = true;
            }
        }
        #endregion
        //Works
        #region Customer selected index
        private void cbxCustomerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtpWedding.Enabled = true;
            //if (dtpWedding.Value != DateTime.Today.AddMonths(1) && cbxCustomerSelect.SelectedIndex > -1)
            //{
            //    GetMenus();
            //    GetEntertaiment();
            //    GetVenues();
            //    cbxMenu.Show();
            //    cbxEntertainment.Show();
            //    cbxVenue.Show();
            //    nudGuests.Show();
            //}
        }
        #endregion
        //works
    }
}
