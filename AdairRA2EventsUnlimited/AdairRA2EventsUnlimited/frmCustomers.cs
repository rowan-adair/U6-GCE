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
    public partial class FrmCustomers : Form
    {
        #region Setup form
        private string editCustomer;
        public Regex regex = new Regex(@"[0-9\b]+");
        public List<string> listOfCustomers = new List<string>();
        SqlDataAdapter adapter;
        public FrmCustomers()
        {
            InitializeComponent();
            SetUp();
        }
        private void SetUp()
        {
            DisabledAndInvisibleObjects();
            GetCustomers();
            lblNoResults.Hide();
            FillDataGrid();
            

        }
        private void DisabledAndInvisibleObjects()
        {
            tbxSearch.Enabled = false;
            btnSearch.Enabled = false;
            lblError.Visible = false;
            lblNoResults.Visible = false;
            cbCustIDSearch.Checked = false;
            cbNameSearch.Checked = false;
        }
        private void GetCustomers()
        {
            try
            {
                listOfCustomers.Clear();
                foreach (var customer in CustomerDAL.GetCustomer())
                {
                    listOfCustomers.Add(customer);
                }
            }
            catch (Exception)
            {
                lblNoResults.Show();
            }
        }
        private void FillDataGrid()
        {
            DataTable dt = new DataTable();
            adapter = CustomerDAL.FillCustomerDataGridView();
            adapter.Fill(dt);
            dgvCustomer.DataSource = dt;
            dgvCustomer.DataMember = dt.TableName;
            dgvCustomer.Columns[0].HeaderCell.Value = "Customer ID";
            dgvCustomer.Columns[1].HeaderCell.Value = "Firstname";
            dgvCustomer.Columns[2].HeaderCell.Value = "Surname";
            dgvCustomer.Columns[3].HeaderCell.Value = "Gender";
            dgvCustomer.Columns[4].HeaderCell.Value = "Address";
            dgvCustomer.Columns[5].HeaderCell.Value = "Post Code";
            dgvCustomer.Columns[6].HeaderCell.Value = "E-Mail";
            dgvCustomer.Columns[7].HeaderCell.Value = "Mobile Number";
            dgvCustomer.Columns[8].HeaderCell.Value = "Date of Birth";
        }
        #endregion 
        //works
        #region Add Customer
        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            new FrmAddCustomer().ShowDialog();
            SetUp();
        }
        #endregion
        //works
        #region Edit customer
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            
            if (dgvCustomer.SelectedRows.Count > 1 || dgvCustomer.SelectedRows.Count < 1)
            {
                MessageBox.Show("Invalid selection.\nOnly select one customer at a time.","Error");
                DisabledAndInvisibleObjects();
                lblError.Visible = true;

            }
            else
            {
                lblError.Visible = false;
                editCustomer = listOfCustomers[dgvCustomer.CurrentCell.RowIndex].ToString();
                new frmEditCustomer(editCustomer).ShowDialog();
                SetUp();
            }
        }
        #endregion
        //works
        #region Search Changing
        private void CbCustIDSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCustIDSearch.Checked)
            {
                cbNameSearch.Checked = false;
                btnSearch.Enabled = true;
                tbxSearch.Enabled = true;
            }
            if (!cbCustIDSearch.Checked)
            {
                tbxSearch.Text = "";

            }
            if (cbCustIDSearch.Checked == false && cbNameSearch.Checked == false)
            {
                btnSearch.Enabled = false;
                tbxSearch.Enabled = false;
                tbxSearch.Text = "";
                lblNoResults.Hide();
                FillDataGrid();
            }
        }
        private void CbNameSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNameSearch.Checked)
            {
                cbCustIDSearch.Checked = false;
                btnSearch.Enabled = true;
                tbxSearch.Enabled = true;
            }
            if (!cbNameSearch.Checked)
            {
                tbxSearch.Text = "";
            }
            if (cbNameSearch.Checked == false && cbCustIDSearch.Checked == false)
            {
                btnSearch.Enabled = false;
                tbxSearch.Enabled = false;
                tbxSearch.Text = "";
                lblNoResults.Hide();
                FillDataGrid();
            }
        }
        #endregion
        //works
        #region Searching
        private void Search()
        {
            lblNoResults.Hide();
            if (cbCustIDSearch.Checked == true)
            {
                lblNoResults.Hide();
                int search;
                if (int.TryParse(Regex.Replace(tbxSearch.Text, @"\s+", ""), out search))
                {
                    try
                    {
                        listOfCustomers.Clear();

                        foreach (var customer in CustomerDAL.GetCustomer())
                        {
                            string[] customerObjectArray = customer.Split(',');
                            if (customerObjectArray[0] == search.ToString())
                            {
                                listOfCustomers.Add(customer);
                            }
                        }
                        DatabaseConnection.OpenConnection();
                        adapter = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerID like " + search, DatabaseConnection.myConnection);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dgvCustomer.DataSource = dt;
                        DatabaseConnection.CloseConnection();
                        lblNoResults.Hide();
                    }
                    catch (Exception)
                    {
                        lblNoResults.Show();
                    }
                }
                else
                {
                    lblNoResults.Show();
                }
                if (dgvCustomer.Rows.Count <= 0)
                {
                    lblNoResults.Show();
                }
            }
            else if (cbNameSearch.Checked == true)
            {
                lblNoResults.Hide();
                try
                {
                    listOfCustomers.Clear();

                    string customerName = ValidatorClass.CustomerValidation.NameToCapital(tbxSearch.Text);
                    customerName = customerName.Replace(" ", "");
                    if (tbxSearch.Text.Any(char.IsDigit) == false)
                    {
                        try
                        {
                            listOfCustomers.Clear();
                            foreach (var customer in CustomerDAL.GetCustomer())
                            {
                                string[] customerObjectArray = customer.Split(',');

                                if (customerObjectArray[1] + customerObjectArray[2] == customerName || customerObjectArray[2] + customerObjectArray[1] == customerName || customerObjectArray[1] == customerName || customerObjectArray[2] == customerName)
                                {
                                    listOfCustomers.Add(customer);
                                }
                                
                            }
                            DatabaseConnection.OpenConnection();
                            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer WHERE CustomerFirstName like '" + customerName + "' OR CustomerSurname like '" + customerName + "' OR CustomerFirstName + CustomerSurname like '"+customerName+ "'OR CustomerSurname + CustomerFirstName like '"+customerName+"'", DatabaseConnection.myConnection);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dgvCustomer.DataSource = dt;
                            DatabaseConnection.CloseConnection();
                            lblNoResults.Hide();
                        }
                        catch (Exception)
                        {
                            lblNoResults.Show();
                        }
                    }
                    else
                    {
                        lblNoResults.Show();
                    }
                }
                catch (Exception)
                {
                    lblNoResults.Show();
                }
                if (dgvCustomer.Rows.Count <= 0)
                {
                    lblNoResults.Show();
                }
            }
        }
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        #endregion
        //works
        #region Navigation
        private void BtnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void FrmCustomers_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
        }
        #endregion
        //
        #region Textbox emptied
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text == "")
            {
                lblNoResults.Hide();
                FillDataGrid();
            }
        }
        #endregion
        //works
        #region Customer Search Key Check
        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbCustIDSearch.Checked == true)
            {
                if (regex.IsMatch(e.KeyChar.ToString()) == false)
                {
                    e.Handled = true;
                }
            }
            else if (cbNameSearch.Checked == true)
            {
                e.Handled = false;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                Search();
            }
        }
        #endregion
        //works
        #region Deselection

        #endregion
        //works
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

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmStaffManagement(0).Show();
        }


        #endregion

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
        //works
    }
}