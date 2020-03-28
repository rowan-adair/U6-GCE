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
    class StaffDAL
    {
        public static SqlDataAdapter FillStaffDataGridView()
        {
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("GetStaff", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            return adapter;
        }
        public static List<string> GetSession(int StaffID)
        {
            
            List<string> sessionListing = new List<string>();
            try
            {
                DatabaseConnection.OpenConnection();
                SqlCommand command = new SqlCommand("GetStaffSessions",DatabaseConnection.myConnection);
                command.Parameters.Add(new SqlParameter("@StaffID", StaffID));
                command.CommandType = CommandType.StoredProcedure;
                SqlDataReader myReader = command.ExecuteReader();
                while (myReader.Read())
                {
                    string SessionID = myReader["AppID"].ToString();
                    string TimeSlot = myReader["TimeSlot"].ToString();
                    string Day = myReader["Day"].ToString();
                    string sessionInfo = string.Format("{0}| Session: {1} | Time : {2}", Day,SessionID,TimeSlot);
                    sessionListing.Add(sessionInfo);
                }
                myReader.Close();
                return sessionListing;
            }
            catch (Exception)
            {
                sessionListing.Add("No Sessions");
                return sessionListing;
            }
        }
        public static List<string> GetRoles()
        {
            List<string> RoleInfo = new List<string>();
            DatabaseConnection.OpenConnection();
            SqlCommand command = new SqlCommand("SELECT * FROM StaffRole", DatabaseConnection.myConnection);
            SqlDataReader myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                string RoleID = myReader["RoleID"].ToString();
                string Role = myReader["Role"].ToString();
                string roleInfo = string.Format("{0},{1}", RoleID, Role);
                RoleInfo.Add(roleInfo);
            }
            myReader.Close();
            return RoleInfo;
        }
        public static void AddStaff(string forename, string surname, int roleID, int venueID)
        {
            try
            {
                DatabaseConnection.OpenConnection();
                SqlCommand command = new SqlCommand("AddStaff", DatabaseConnection.myConnection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@forename",ValidatorClass.CustomerValidation.NameToCapital(forename)));
                command.Parameters.Add(new SqlParameter("@surname", ValidatorClass.CustomerValidation.NameToCapital(surname)));
                command.Parameters.Add(new SqlParameter("@roleID", roleID));
                command.Parameters.Add(new SqlParameter("@venueID", venueID));
                command.ExecuteNonQuery();
                DatabaseConnection.CloseConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void NewAvailability(int StaffID,int AppSlot, int DayID)
        {
            try
            {
                DatabaseConnection.OpenConnection();
                SqlCommand command = new SqlCommand("NewAvailability", DatabaseConnection.myConnection);
                command.Parameters.Add(new SqlParameter("@StaffID", StaffID));
                command.Parameters.Add(new SqlParameter("@AppSlot", AppSlot));
                command.Parameters.Add(new SqlParameter("@DayId", DayID));
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                DatabaseConnection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
