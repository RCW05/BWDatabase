using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BWDatabase
{
    public partial class frmDatabase : Form
    {

        public string thisisavalue;
        public string thisisanothervalue;
        
        public frmDatabase()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
