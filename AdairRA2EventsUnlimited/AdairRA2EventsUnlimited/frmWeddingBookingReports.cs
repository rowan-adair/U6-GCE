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
    public partial class frmWeddingBookingReports : Form
    {
        public frmWeddingBookingReports()
        {
            InitializeComponent();
        }
        private void frmWeddingReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AdairRA2EventsUnlimitedDataSet.WeddingBooking' table. You can move, or remove it, as needed.
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void frmWeddingBookingReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AdairRA2EventsUnlimitedDataSet.WeddingBooking' table. You can move, or remove it, as needed.
            this.WeddingBookingTableAdapter.Fill(this.AdairRA2EventsUnlimitedDataSet.WeddingBooking);


            this.rptvWeddingReports.RefreshReport();
        }

        private void qryBookingConfirmedToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.WeddingBookingTableAdapter.qryBookingConfirmed(this.AdairRA2EventsUnlimitedDataSet.WeddingBooking, bookingConfirmedToolStripComboBox.Text);
                rptvWeddingReports.RefreshReport();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void qryBookingIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.WeddingBookingTableAdapter.qryBookingID(this.AdairRA2EventsUnlimitedDataSet.WeddingBooking, ((int)(System.Convert.ChangeType(bookingIDToolStripTextBox.Text, typeof(int)))));
                rptvWeddingReports.RefreshReport();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void qryStaffIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.WeddingBookingTableAdapter.qryStaffID(this.AdairRA2EventsUnlimitedDataSet.WeddingBooking, ((int)(System.Convert.ChangeType(staffIDToolStripTextBox.Text, typeof(int)))));
                rptvWeddingReports.RefreshReport();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void qryCostGreaterToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.WeddingBookingTableAdapter.qryCostGreater(this.AdairRA2EventsUnlimitedDataSet.WeddingBooking, ((decimal)(System.Convert.ChangeType(costGreaterToolStripTextBox.Text, typeof(decimal)))));
                rptvWeddingReports.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void qryCostLessToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.WeddingBookingTableAdapter.qryCostLess(this.AdairRA2EventsUnlimitedDataSet.WeddingBooking, ((decimal)(System.Convert.ChangeType(costLessToolStripTextBox.Text, typeof(decimal)))));
                rptvWeddingReports.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void qryCostBetweenToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.WeddingBookingTableAdapter.qryCostBetween(this.AdairRA2EventsUnlimitedDataSet.WeddingBooking, ((decimal)(System.Convert.ChangeType(upperCostToolStripTextBox.Text, typeof(decimal)))), ((decimal)(System.Convert.ChangeType(lowerCostToolStripTextBox.Text, typeof(decimal)))));
                rptvWeddingReports.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ToolStripTextBox[] arrayOfTST = new ToolStripTextBox[] { bookingIDToolStripTextBox, staffIDToolStripTextBox, costGreaterToolStripTextBox, costLessToolStripTextBox, lowerCostToolStripTextBox, upperCostToolStripTextBox };
            try
            {
                this.WeddingBookingTableAdapter.ViewAll(this.AdairRA2EventsUnlimitedDataSet.WeddingBooking);
                for (int i = 0; i < arrayOfTST.Length; i++)
                {
                    arrayOfTST[i].Text = null;
                }
                bookingConfirmedToolStripComboBox.Text = null;
                rptvWeddingReports.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void viewAllToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.WeddingBookingTableAdapter.ViewAll(this.AdairRA2EventsUnlimitedDataSet.WeddingBooking);
                rptvWeddingReports.RefreshReport();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            Hide();
        }

        private void qryWeddingIDToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.WeddingBookingTableAdapter.qryWeddingID(this.AdairRA2EventsUnlimitedDataSet.WeddingBooking, ((int)(System.Convert.ChangeType(weddingIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
