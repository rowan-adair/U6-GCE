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
    public partial class frmViewWeddingQuote : Form
    {
        private int bookingID;
        public frmViewWeddingQuote(int WeddingID)
        {
            InitializeComponent();
            GetWeddingDetails(WeddingID);
            
        }
        public void GetWeddingDetails(int WeddingID)
        {
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("GetWeddingDetails", DatabaseConnection.myConnection);
            myCommand.Parameters.Add(new SqlParameter("@WeddingID", WeddingID));
            myCommand.CommandType = CommandType.StoredProcedure;

            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                string customerID = myReader["CustomerID"].ToString();
                string customerFirstName = myReader["CustomerFirstName"].ToString();
                string customerSurname = myReader["CustomerSurname"].ToString();
                string entertainmentID = myReader["EntertainmentID"].ToString();
                string type = myReader["Type"].ToString();
                string menus = myReader["Menus"].ToString();
                string noOfCourses = myReader["NoOfCourses"].ToString();
                string provider = myReader["Provider"].ToString();
                string venueID = myReader["VenueID"].ToString();
                string venueName = myReader["VenueName"].ToString();
                string venueAddress = myReader["VenueAddress"].ToString();
                string venueTelepone = myReader["VenueTelephone"].ToString();
                string DateOfWedding = Convert.ToDateTime(myReader["DateOfWedding"]).ToString();
                string numberOfGuests = myReader["NumberOfGuests"].ToString();
                string OverallCost = myReader["OverallCost"].ToString();
                string DepositCost = myReader["DepositCost"].ToString();
                string BookingConfirmed = myReader["BookingConfirmed"].ToString();
                char flowers = Convert.ToChar(myReader["Flowers"]);
                char invitations = Convert.ToChar(myReader["Invitations"]);
                char suits = Convert.ToChar(myReader["Suits"]);
                char travelArrangements = Convert.ToChar(myReader["TravelArrangements"]);
                char dress = Convert.ToChar(myReader["Dress"]);
                bookingID = Convert.ToInt32(myReader["BookingID"]);
                lblWeddingID.Text = String.Format("Wedding : {0}", (Convert.ToInt32(WeddingID)));
                lblCustomer.Text = String.Format("Customer: {0} {1} ({2})",customerFirstName,customerSurname,customerID);
                gbxVenue.Text = String.Format("Venue: {0}", venueName);
                lblVenueNo.Text = String.Format("Venue phone: {0}", venueTelepone);
                lblVenueAddress.Text = String.Format("Venue Address: {0}", venueAddress);
                lblNumberOfGuests.Text = String.Format("Guests: {0}",numberOfGuests);
                lblDeposit.Text = String.Format(lblDeposit.Text + " " + DepositCost);
                lblOverallCost.Text = string.Format(lblOverallCost.Text + " " + OverallCost);
                lbxPlanning.Items.Add(String.Format("Entertainment: {0}", type));
                lbxPlanning.Items.Add(String.Format("Menu : {0} Courses from {1}", noOfCourses, provider));

                if (flowers == 'Y')
                    lbxPlanning.Items.Add("Flowers");
                if (invitations == 'Y')
                    lbxPlanning.Items.Add(String.Format("{0} Invitations",numberOfGuests));
                if (invitations == 'N')
                    lbxPlanning.Items.Add(String.Format("{0} Guests", numberOfGuests));
                if (suits == 'Y')
                    lbxPlanning.Items.Add("Suits");
                if (travelArrangements == 'Y')
                    lbxPlanning.Items.Add("Travel Arrangements");
                if (dress == 'Y')
                    lbxPlanning.Items.Add("Wedding Dress arrangements");
                if (BookingConfirmed == "Y")
                {
                    btnConfirm.Hide();
                    lblConfirmed.Show();
                }
                else if (BookingConfirmed == "N")
                {
                    btnConfirm.Show();
                    lblConfirmed.Hide();
                }
            }
            myReader.Close();
            DatabaseConnection.CloseConnection();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection.OpenConnection();
                SqlCommand myCommand = new SqlCommand("BookingConfirmed", DatabaseConnection.myConnection);
                myCommand.Parameters.Add(new SqlParameter("@BookingID", bookingID));
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.ExecuteNonQuery();
                DatabaseConnection.CloseConnection();
                Hide();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);           
            }
            
        }

        
    }
}
