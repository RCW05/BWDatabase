using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BWDatabase
{
    public partial class frmDatabase : Form
    {

        public int CustNumber;
        public string FName;
        
        public frmDatabase()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
            lstCustomers.SelectedIndex = 0;
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCustomerValues();
        }
        public void LoadCustomerList()
        {
            Database db = new BWDatabase.Database();

            {
                foreach (var Row in db.GetCustomerList())
                {
                    var Fields = Row as IDictionary<string, object>;
                    FName = Fields["FullName"].ToString();
                    this.lstCustomers.Items.Add(FName);
                }
            }
        }

        public void LoadCustomerValues()
        {
            Database db = new BWDatabase.Database();
            {
                string getValue = lstCustomers.SelectedItem.ToString(); 
                foreach (var Row in db.GetCustomerDetails(getValue))
                {
                    var Fields = Row as IDictionary<string, object>;                 
                    txtCustNumber.Text=Fields["CustomerNumber"].ToString();
                    txtTitle.Text = Fields["Title"].ToString();
                    txtFullName.Text = Fields["FullName"].ToString();
                    txtTelephone.Text = Fields["Telephone"].ToString();
                    txtAddTelephone.Text = Fields["AddTelephone"].ToString();
                    txtMobile.Text = Fields["Mobile"].ToString();
                    txtEmail.Text = Fields["Email"].ToString();
                    txtFullAddress.Text = Fields["FullAddress"].ToString();
                    txtPostcode.Text = Fields["Postcode"].ToString();
                    txtArea.Text = Fields["Area"].ToString();
                    txtFacebookName.Text = Fields["Facebook"].ToString();
                    txtLanguage.Text = Fields["Language"].ToString();
                    txtNotes.Text = Fields["Notes"].ToString();
                }
            }
        }
    }
}
