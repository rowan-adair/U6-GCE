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
    public partial class frmChangeAppointmentDate : Form
    {
        public List<int> listOfVenues = new List<int>();
        public List<int> daysOfWeek = new List<int>();
        public List<int> listOfStaff = new List<int>();
        public List<string> listOfSessions = new List<string>();
        public List<string> AppointmentItems;
        private int dayID;
        private int venueID;
        private int appointmentID;

        public frmChangeAppointmentDate(string editAppointment)
        {
            InitializeComponent();
            SetUp(editAppointment);

        }
        private void SetUp(string editAppointment)
        {
            PopulateForm(editAppointment);
        }
        private void PopulateForm(string editAppointment)
        {
            AppointmentItems = editAppointment.Split(',').ToList();
            appointmentID = Convert.ToInt32(AppointmentItems[2]);
            Text = string.Format("Appointment : {0}", AppointmentItems[2]);
            lblInfo.Text = string.Format("Meeting at {0} with {1} {2}", AppointmentItems[4], AppointmentItems[0], AppointmentItems[1]);
            dtpDateOfAppointment.Text = AppointmentItems[7];
            cbxSession.Text = String.Format("Session {0} Time: {1}", AppointmentItems[5], AppointmentItems[6]);
            venueID = Convert.ToInt32(AppointmentItems[3]);
            PopulateSession(venueID);
        }
        private void PopulateSession(int VenueID)
        {
            cbxSession.Text = "";

            List<int> listOfBookedSessions = new List<int>();
            List<int> listOfBookedStaff = new List<int>();
            List<string> listOfAllSessions = new List<string>();

            cbxSession.Enabled = true;
            lblSession.Enabled = true;

            DateTime dateOfApp;

            dateOfApp = dtpDateOfAppointment.Value;

            dayID = (int)dateOfApp.DayOfWeek + 1;

            listOfStaff = AppointmentDAL.SelectStaff(VenueID);

            for (int i = 0; i < listOfStaff.Count - 1; i++)
            {
                listOfSessions = AppointmentDAL.AvailableSession(listOfStaff[i], dayID);
                foreach (var session in listOfSessions)
                {
                    listOfAllSessions.Add(session);
                }
            }
            for (int j = 0; j < listOfStaff.Count - 1; j++)
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
                for (int k = 0; k < listOfAllSessions.Count - 1; k++)
                {
                    string[] session = (listOfAllSessions[k].ToString().Split('.').ToArray());
                    for (int l = 0; l < listOfBookedSessions.Count; l++)
                    {
                        if (Convert.ToInt32(session[1]) == listOfBookedSessions[l])
                        {
                            for (int m = 0; m < listOfBookedStaff.Count; m++)
                            {
                                if (Convert.ToInt32(session[0]) == listOfBookedStaff[m])
                                {
                                    listOfAllSessions.RemoveAt(k);
                                }
                            }
                        }
                    }
                }
                listOfBookedStaff.Clear();
                listOfBookedSessions.Clear();
            }
            for (int i = 0; i < listOfAllSessions.Count - 1; i++)
            {
                string[] PopSession = listOfAllSessions[i].ToString().Split('.');
                string populate = string.Format("Session {0} Time: {1}", PopSession[1], PopSession[2]);
                if (!cbxSession.Items.Contains(populate))
                {
                    cbxSession.Items.Add(populate);
                }
            }
        }
        
    
        private void btnUpdateAppointment_Click(object sender, EventArgs e)
        {
            int appSlotId = Convert.ToInt32(cbxSession.Text.Substring(7, 3));
            AppointmentDAL.UpdateAppointment(appointmentID,appSlotId,dtpDateOfAppointment.Value.ToShortDateString());
            MessageBox.Show("Appointment Updated!", "Success");
            Hide();
        }

        private void cbxSession_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dtpDateOfAppointment_ValueChanged(object sender, EventArgs e)
        {
            PopulateSession(venueID);
            
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
