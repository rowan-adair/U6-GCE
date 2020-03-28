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

namespace AdairRA2EventsUnlimited
{
    public class CustomerDAL
    {
        private readonly SqlDataReader myReader;
        private readonly int customerID;
        private readonly string email;
        private readonly string phonenumber;
        private readonly string postcode;
        private readonly string homeAddress;
        private readonly string firstName;
        private readonly string secondName;
        private readonly string dateOfBirth;
        private readonly string gender;

        public CustomerDAL(SqlDataReader myReader, int customerID, string firstName, string secondName, string gender, string homeAddress, string postcode, string email, string phonenumber, string dateOfBirth)
        {
            this.myReader = myReader;
            this.customerID = customerID;
            this.email = email;
            this.phonenumber = phonenumber;
            this.postcode = postcode;
            this.homeAddress = homeAddress;
            this.firstName = firstName;
            this.secondName = secondName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
        }

        public SqlDataReader MyReader { get { return myReader; } }
        public int CustomerID { get { return customerID; } }
        public string Email { get { return email; } }
        public string Phonenumber { get { return phonenumber; } }
        public string PostCode { get { return postcode; } }
        public string HomeAddress { get { return homeAddress; } }
        public string FirstName { get { return firstName; } }
        public string SecondName { get { return secondName; } }
        public string DateOfBirth { get { return dateOfBirth; } }
        public string Gender { get { return gender; } }

        private static List<String> ReadCustomer(SqlDataReader myReader)
        {
            List<String> CustomerRead = new List<string>();
            while (myReader.Read())
            {
                string CustomerID = myReader["CustomerID"].ToString();
                string firstname = myReader["CustomerFirstName"].ToString();
                string secondname = myReader["CustomerSurname"].ToString();
                string gender = myReader["Gender"].ToString();
                string datebirth = Convert.ToDateTime(myReader["CustomerDateOfBirth"]).ToShortDateString();
                string address = myReader["CustomerAddress"].ToString();
                string postCode = myReader["CustomerPostCode"].ToString();
                string telephone = myReader["CustomerTelephone"].ToString();
                string email = myReader["CustomerEmail"].ToString();
                String populate = String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8}", CustomerID, firstname, secondname, gender, address, postCode, email, telephone, datebirth);
                CustomerRead.Add(populate);
            }
            return CustomerRead;
        }

        public static List<String> GetCustomer()
        {
            List<String> CustomerInfo = new List<string>();
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("GetCustomer", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlDataReader myReader = myCommand.ExecuteReader();
            CustomerInfo = ReadCustomer(myReader);
            myReader.Close();
            DatabaseConnection.CloseConnection();
            return CustomerInfo;
        }
        public static SqlDataAdapter FillCustomerDataGridView()
        {
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("GetCustomer", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
            return adapter;

        }


        public static void AddCustomer(string firstName, string secondName, string gender, string address, string postcode, string email, string phonenumber, string dateOfBirth)
        {
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("AddCustomer", DatabaseConnection.myConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            myCommand.Parameters.Add(new SqlParameter("@CustomerFirstName", ValidatorClass.CustomerValidation.NameToCapital(firstName)));
            myCommand.Parameters.Add(new SqlParameter("@CustomerSurname", ValidatorClass.CustomerValidation.NameToCapital(secondName)));
            myCommand.Parameters.Add(new SqlParameter("@Gender", gender));
            myCommand.Parameters.Add(new SqlParameter("@CustomerAddress", address));
            myCommand.Parameters.Add(new SqlParameter("@CustomerPostCode", postcode.ToUpper()));
            myCommand.Parameters.Add(new SqlParameter("@CustomerEmail", email));
            myCommand.Parameters.Add(new SqlParameter("@CustomerTelephone", phonenumber));
            myCommand.Parameters.Add(new SqlParameter("@CustomerDateOfBirth", Convert.ToDateTime(dateOfBirth)));
            myCommand.ExecuteNonQuery();
            DatabaseConnection.CloseConnection();
        }
        public static void UpdateCustomer(string customerID, string firstName, string secondName, string address, string postcode, string email, string phonenumber, string dateOfBirth)
        {
            DatabaseConnection.OpenConnection();
            SqlCommand myCommand = new SqlCommand("UpdateCustomer", DatabaseConnection.myConnection);
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.Add(new SqlParameter("@CustomerID", Convert.ToInt32(customerID)));
            myCommand.Parameters.Add(new SqlParameter("@CustomerFirstName", ValidatorClass.CustomerValidation.NameToCapital(firstName)));
            myCommand.Parameters.Add(new SqlParameter("@CustomerSurname", ValidatorClass.CustomerValidation.NameToCapital(secondName)));
            myCommand.Parameters.Add(new SqlParameter("@CustomerAddress", address));
            myCommand.Parameters.Add(new SqlParameter("@CustomerPostCode", postcode.ToUpper()));
            myCommand.Parameters.Add(new SqlParameter("@CustomerEmail", email));
            myCommand.Parameters.Add(new SqlParameter("@CustomerTelephone", phonenumber));
            myCommand.Parameters.Add(new SqlParameter("@CustomerDateOfBirth", Convert.ToDateTime(dateOfBirth)));
            myCommand.ExecuteNonQuery();
            DatabaseConnection.CloseConnection();
        }
        
    }
}