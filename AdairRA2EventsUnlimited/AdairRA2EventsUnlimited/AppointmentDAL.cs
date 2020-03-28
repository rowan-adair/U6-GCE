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
    class AppointmentDAL
    {
        private readonly int staffID;
        private readonly int customerID;
        private readonly int venueID;
        private readonly int appID;
        private readonly string appDate;
       
        public AppointmentDAL(int customerID, int staffID, int venueID,int appID, string appDate)
        {
            this.customerID = customerID;
            this.staffID = staffID;
            this.venueID = venueID;
            this.appID = appID;
            this.appDate = appDate;
        }
        public static List<string> GetAppoitnments()
        {
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("GetAppointments", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader myReader = myCommand.ExecuteReader();
            List<string> appointmentPopulate = new List<string>();
            while (myReader.Read())
            {
                int AppointmentID = Convert.ToInt32(myReader["AppointmentID"]);
                string CustomerFirstname = myReader["CustomerFirstName"].ToString();
                string CustomerSecondName = myReader["CustomerSurname"].ToString();
                string StaffFirstname = myReader["StaffFirstName"].ToString();
                string StaffSecondName = myReader["StaffSecondName"].ToString();
                string VenueName = myReader["VenueName"].ToString();
                string AppDate = Convert.ToDateTime(myReader["AppointmentDate"]).ToShortDateString();
                string Session = myReader["AppSlotID"].ToString();
                string TimeFrame = myReader["TimeSlot"].ToString();
                string populate = string.Format("{0}| Staff: {1} {2} | Customer: {3} {4} | Venue: {5} | Date: {6} | Session : {7} , {8}hrs", AppointmentID, StaffFirstname, StaffSecondName, CustomerFirstname, CustomerSecondName, VenueName, AppDate, Session, TimeFrame);
                appointmentPopulate.Add(populate);
            }
            myReader.Close();
            DatabaseConnection.CloseConnection();
            return appointmentPopulate;
        }
        public static List<string> GetVenues()
        {
            List<string> venueInfo = new List<string>();
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("SELECT * FROM [dbo].[Venue]", DatabaseConnection.myConnection);
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                string VenueName = myReader["VenueName"].ToString();
                string VenueID = myReader["VenueID"].ToString();
                string populate = VenueID + "," + VenueName;
                venueInfo.Add(populate);
            }
            DatabaseConnection.CloseConnection();
            myReader.Close();
            return venueInfo;
        }
        public static List<int> SelectStaff(int venueID)
        {
            List<int> listOfStaff = new List<int>();
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("SelectStaff", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.Add(new SqlParameter("@VenueID", venueID));
            myCommand.Parameters.Add(new SqlParameter("@StaffRole", 1));
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                string venueStaff = myReader["StaffID"].ToString();
                listOfStaff.Add(Convert.ToInt32(venueStaff));
            }
            myReader.Close();
            return listOfStaff;
        }

        public static void BookAppointment(int customerID, int staffID, int venueID, int appID, string appDate)
        {
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("BookAppointment", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.Add(new SqlParameter("@CustomerID", customerID));
            myCommand.Parameters.Add(new SqlParameter("@StaffID", staffID));
            myCommand.Parameters.Add(new SqlParameter("@VenueID", venueID));
            myCommand.Parameters.Add(new SqlParameter("@AppSlotID", appID));
            myCommand.Parameters.Add(new SqlParameter("@AppointmentDate", Convert.ToDateTime(appDate)));
            myCommand.ExecuteNonQuery();
            DatabaseConnection.CloseConnection();
        }
        public static void UpdateAppointment(int appointmentID, int appID, string appDate)
        {
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("ChangeAppointmentDate", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.Add(new SqlParameter("@AppointmentID", appointmentID));
            myCommand.Parameters.Add(new SqlParameter("@AppSlotID", appID));
            myCommand.Parameters.Add(new SqlParameter("@AppointmentDate", Convert.ToDateTime(appDate)));
            myCommand.ExecuteNonQuery();
            DatabaseConnection.CloseConnection();
        }
        public static List<string> AvailableSession(int staffID, int dayID)
        {
            List<string> listOfSessions = new List<string>();
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("AvailableSession", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.Add(new SqlParameter("@StaffID", staffID));
            myCommand.Parameters.Add(new SqlParameter("@DayID", dayID));
            SqlDataReader myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                string timeSlot = myReader["TimeSlot"].ToString();
                string session = myReader["AppslotID"].ToString();
                string populate = string.Format("{0}.{1}.{2}", staffID, session, timeSlot);
                listOfSessions.Add(populate);
            }
            DatabaseConnection.CloseConnection();
            myReader.Close();
            return listOfSessions;
        }
    }
   
}
