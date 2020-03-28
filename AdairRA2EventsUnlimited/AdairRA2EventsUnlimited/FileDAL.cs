using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdairRA2EventsUnlimited
{
    class FileDAL
    {
        public static void GetHelp()
        {
            try
            {
                System.Diagnostics.Process.Start(@"Resources\UserGuide.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
