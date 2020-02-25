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
            Database db = new BWDatabase.Database();

            long x = 0;

            foreach (var Row in db.Test(x))
            {
                var fields = Row as IDictionary<string, object>;
                var test = fields["idTestOne"];
                var testTwo = fields["idTestTwo"];
                thisisanothervalue = Convert.ToString(testTwo);
                thisisavalue = Convert.ToString(test);                
            }
        }
    }
}
