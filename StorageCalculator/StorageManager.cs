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
        DataTable dt;

        public StorageManager(Storage s)
        {
            InitializeComponent();

            storage = s;

        }

        private void StorageManager_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Capacidad ocupada");
            dt.Columns.Add("Capacidad total");

        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateBox cb = new CreateBox();
            cb.Show();
        }
    }
}
