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
    public partial class CreateStorage : Form
    {

        public CreateStorage()
        {
            InitializeComponent();
        }

        private void BTNcrear_Click(object sender, EventArgs e)
        {
            Storage storage = new Storage(TXTname.Text, (int)NUDlinealCapacity.Value);
            StorageManager m = new StorageManager();
            m.MdiParent = this.MdiParent;
            m.Show();
            this.Close();
        }
    }
}
