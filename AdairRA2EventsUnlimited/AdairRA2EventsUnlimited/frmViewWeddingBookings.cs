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
    public partial class frmViewWeddingBookings : Form
    {
        #region SetUp
        private List<int> listOfWeddingID = new List<int>();
        private List<string> listOfWeddingInfo = new List<string>();
        public frmViewWeddingBookings()
        {
            InitializeComponent();
            GetWeddingBookings();
        }
        private void CancelWedding(int WeddingID)
        {
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("DeleteWedding", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.Add(new SqlParameter("@WeddingID", WeddingID));
            myCommand.ExecuteNonQuery();
            DatabaseConnection.OpenConnection();
        }
        private void RefreshCheckedListBox()
        {
            foreach (int checkedItemIndex in clbWeddings.CheckedIndices)
            {
                clbWeddings.SetItemChecked(checkedItemIndex, false);
            }
            GetWeddingBookings();
        }
        private void ReadBookings(SqlDataReader myReader)
        {
            while (myReader.Read())
            {
                string BookingID = myReader["BookingID"].ToString();
                string WeddingID = myReader["WeddingID"].ToString();
                string StaffID = myReader["StaffID"].ToString();
                string StaffFirstName = myReader["StaffFirstName"].ToString();
                string StaffSecondName = myReader["StaffSecondName"].ToString();
                string DateOfBooking = Convert.ToDateTime(myReader["DateOfBooking"]).ToShortDateString();
                string DateOfWedding = Convert.ToDateTime(myReader["DateOfWedding"]).ToShortDateString();
                string OverallCost = myReader["OverallCost"].ToString();
                string DepositCost = myReader["DepositCost"].ToString();
                string BookingConfirmed = myReader["BookingConfirmed"].ToString();
                string populate = string.Format("{0}.Wedding {1} | Staff {2}: {3} {4} | Booked {5} | Wedding Date {6} | Cost: £{7} | Booking confirmed?: {8}", BookingID, WeddingID, StaffID, StaffFirstName, StaffSecondName, DateOfBooking, DateOfWedding, OverallCost, BookingConfirmed);
                if (Convert.ToDateTime(DateOfWedding) > DateTime.Now)
                {
                    clbWeddings.Items.Add(populate);
                    listOfWeddingInfo.Add(populate);
                    listOfWeddingID.Add(Convert.ToInt32(WeddingID));
                }
            }
        }
        private void GetWeddingBookings()
        {    
            DatabaseConnection.OpenConnection();   
            clbWeddings.Items.Clear();   
            SqlCommand myCommand = new SqlCommand("GetWeddingBookings", DatabaseConnection.myConnection);   
            SqlDataReader myReader = myCommand.ExecuteReader();
            ReadBookings(myReader);   
            myReader.Close();  
            DatabaseConnection.CloseConnection();
        }
        #endregion
        //Works
        #region Events
        private void btnBookingConfirmed_Click(object sender, EventArgs e)
        {
            try
            {
                string[] weddingArray = clbWeddings.SelectedItem.ToString().Split('.');
                DatabaseConnection.OpenConnection();
                SqlCommand myCommand = new SqlCommand("BookingConfirmed", DatabaseConnection.myConnection);
                myCommand.Parameters.Add(new SqlParameter("@BookingID", Convert.ToInt32(weddingArray[0])));
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.ExecuteNonQuery();
                DatabaseConnection.CloseConnection();
                GetWeddingBookings();
            }
            catch (Exception)
            {
                MessageBox.Show("There are no weddings selected!");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(clbWeddings.CheckedItems.Count < 1)
            {
                MessageBox.Show("You haven't selected any weddings to cancel", "Error"); RefreshCheckedListBox();
            }
            else if(clbWeddings.CheckedItems.Count > 1)
            {
                MessageBox.Show("You can only cancel one wedding at a time", "Error"); RefreshCheckedListBox();

            }
            else
            {
                try
                {
                    List<int> listOfWeddingBookings = new List<int>();
                    foreach (var weddings in clbWeddings.CheckedItems)
                    {
                        string[] weddingObject = weddings.ToString().Split(':');
                        if (weddingObject[3] == " N")
                        {
                            string[] arrayOfWeddings = weddings.ToString().Split('.');
                            string weddingBookingID = arrayOfWeddings[0].Replace(".", "");
                            listOfWeddingBookings.Add(Convert.ToInt32(weddingBookingID));
                        }
                        else if (weddingObject[3] == " Y")
                        {

                            DialogResult confirmCancel = MessageBox.Show("Are you sure you want to cancel this wedding?\n\nThe deposit is non-refundable", "New appointment?", MessageBoxButtons.YesNo);
                            if (confirmCancel == DialogResult.Yes)
                            {
                                string[] arrayOfWeddings = weddings.ToString().Split('.');
                                string weddingBookingID = arrayOfWeddings[0].Replace(".", "");
                                listOfWeddingBookings.Add(Convert.ToInt32(weddingBookingID));
                            }
                            else if (confirmCancel == DialogResult.No)
                            {
                                RefreshCheckedListBox();
                            }
                            
                        }

                    }
                    foreach (var item in listOfWeddingBookings)
                    {
                        CancelWedding(item);
                        MessageBox.Show("Wedding cancelled"); RefreshCheckedListBox();
                    }
                    GetWeddingBookings();
                }
                catch (Exception)
                {
                    GetWeddingBookings();

                }

            }
        }
        private void btnViewWeddingDetails_Click(object sender, EventArgs e)
        {
            if (clbWeddings.CheckedItems.Count < 1)
            {
                MessageBox.Show("You must select a wedding","Error"); RefreshCheckedListBox();
            }
            else if (clbWeddings.CheckedItems.Count > 1)
            {
                MessageBox.Show("You cannot select more than one wedding", "Error"); RefreshCheckedListBox();
            }
            else
            {
                new frmViewWeddingQuote(listOfWeddingID[clbWeddings.SelectedIndex]).ShowDialog();
                GetWeddingBookings();
            }
        }
        private void cbViewAll_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbViewPrevious.Checked)
            {
                clbWeddings.Items.Clear();
                listOfWeddingInfo.Clear();
                GetWeddingBookings();
                btnCancel.Enabled = true;
            }
            else if (cbViewPrevious.Checked)
            {
                cbxUnconfirmed.Checked = false;
                cbxConfirmed.Checked = false;
                btnCancel.Enabled = false;
                listOfWeddingInfo.Clear();
                DatabaseConnection.OpenConnection();
                clbWeddings.Items.Clear();
                SqlCommand myCommand = new SqlCommand("GetWeddingBookings", DatabaseConnection.myConnection);
                SqlDataReader myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    string BookingID = myReader["BookingID"].ToString();
                    string WeddingID = myReader["WeddingID"].ToString();
                    string StaffID = myReader["StaffID"].ToString();
                    string StaffFirstName = myReader["StaffFirstName"].ToString();
                    string StaffSecondName = myReader["StaffSecondName"].ToString();
                    string DateOfBooking = Convert.ToDateTime(myReader["DateOfBooking"]).ToShortDateString();
                    string DateOfWedding = Convert.ToDateTime(myReader["DateOfWedding"]).ToShortDateString();
                    string OverallCost = myReader["OverallCost"].ToString();
                    string DepositCost = myReader["DepositCost"].ToString();
                    string BookingConfirmed = myReader["BookingConfirmed"].ToString();
                    string populate = string.Format("{0}.Wedding {1} | Staff {2}: {3} {4} | Booked {5} | Wedding Date {6} | Cost: £{7} | Booking confirmed?: {8}", BookingID, WeddingID, StaffID, StaffFirstName, StaffSecondName, DateOfBooking, DateOfWedding, OverallCost, BookingConfirmed);
                    if (cbxConfirmed.Checked == true)
                    {
                        if (Convert.ToDateTime(DateOfWedding) < DateTime.Today && BookingConfirmed == "Y")
                        {
                            clbWeddings.Items.Add(populate);
                            listOfWeddingInfo.Add(populate);
                            listOfWeddingID.Add(Convert.ToInt32(WeddingID));
                        }
                    }
                    else if (cbxUnconfirmed.Checked == true)
                    {
                        if (Convert.ToDateTime(DateOfWedding) < DateTime.Today && BookingConfirmed == "N")
                        {
                            clbWeddings.Items.Add(populate);
                            listOfWeddingInfo.Add(populate);
                            listOfWeddingID.Add(Convert.ToInt32(WeddingID));
                        }
                    }
                    else
                    {
                        if (Convert.ToDateTime(DateOfWedding) < DateTime.Today)
                        {
                            clbWeddings.Items.Add(populate);
                            listOfWeddingInfo.Add(populate);
                            listOfWeddingID.Add(Convert.ToInt32(WeddingID));
                        }
                    }
                }
                myReader.Close();
                DatabaseConnection.CloseConnection();
            }
        }
        #endregion
        //Works
        #region Navigation
        private void btnReports_Click(object sender, EventArgs e)
        {
            new frmWeddingBookingReports().ShowDialog();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
            new frmHome().Show();
        }
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
        #endregion

        private void cbxConfirmed_CheckedChanged(object sender, EventArgs e)
        {
            clbWeddings.Items.Clear();
            if (cbxConfirmed.Checked == true)
            {
                cbxUnconfirmed.Checked = false;
                foreach (var wedding in listOfWeddingInfo)
                {
                    string[] weddingObject = wedding.Split(':');
                    if (weddingObject[3] == " Y")
                    {
                        clbWeddings.Items.Add(wedding);
                    }
                }
            }
            else if (cbxConfirmed.Checked == false && cbxUnconfirmed.Checked == false)
            {
                listOfWeddingInfo.Clear();
                clbWeddings.Items.Clear();
                GetWeddingBookings();
            }
        }
        #endregion
        private void cbxUncomfirmed_CheckedChanged(object sender, EventArgs e)
        {
            clbWeddings.Items.Clear();
            if (cbxUnconfirmed.Checked == true)
            {
                cbxConfirmed.Checked = false;

                foreach (var wedding in listOfWeddingInfo)
                {
                    string[] weddingObject = wedding.Split(':');
                    if (weddingObject[3] == " N")
                    {
                        clbWeddings.Items.Add(wedding);
                    }
                }
            }
            else if (cbxConfirmed.Checked == false && cbxUnconfirmed.Checked == false)
            {
                listOfWeddingInfo.Clear();
                clbWeddings.Items.Clear();
                GetWeddingBookings();
            }
        }
        private void btnNewWedding_Click(object sender, EventArgs e)
        {
            new frmWeddingPlanning().ShowDialog();
            GetWeddingBookings();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            Hide();
            new frmViewAppointments().Show();
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
        //Works
    }
}
