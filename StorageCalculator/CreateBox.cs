using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageCalculator
{
    public partial class CreateBox : Form
    {

        private string DBconnection;

        public CreateBox()
        {
            InitializeComponent();

            DBconnection = System.Configuration.ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
        }

        private void BTNcrear_Click(object sender, EventArgs e)
        {
            
            //Box b = new Box((int)NUDmetrosLineales.Value,s);
            
        }
    }
}
