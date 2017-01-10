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
    public partial class StorageManager : Form
    {

        Storage storage;

        public StorageManager(Storage s)
        {
            InitializeComponent();

            storage = s;

        }

        private void StorageManager_Load(object sender, EventArgs e)
        {
            
        }
    }
}
