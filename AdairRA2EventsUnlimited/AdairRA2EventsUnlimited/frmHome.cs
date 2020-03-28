using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdairRA2EventsUnlimited
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            new frmHome().Show();
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            new FrmCustomers().ShowDialog();
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
        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            new FrmAddCustomer().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            new frmViewWeddingBookings().Show();
        }

        private void ttWedding_Popup(object sender, PopupEventArgs e)
        {

        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            new frmStaffManagement(0).Show();
        }
        private void btnStaff_Click(object sender, EventArgs e)
        {
            Hide();
            new frmStaffManagement(0).Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDAL.GetHelp();
        }
    }
}
