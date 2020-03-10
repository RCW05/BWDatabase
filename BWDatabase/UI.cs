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
        public int CustomerCount;
        public int CustomerNumber;
        public int i;
        public string FName;
        //
        public string gTitle;
        public string gFullName;
        public string gTelephone;
        public string gAddTelephone;
        public string gMobile;
        public string gEmail;
        public string gFullAddress;
        public string gPostCode;
        public string gArea;
        public string gFacebook;
        public string gLanguage;
        public string gNotes;

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
            if(lstCustomers.SelectedItem.ToString()=="<New Customer>")
            {

            }
            else
            {
            ClearCustomerValues();
            LoadCustomerValues();
            }

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
                    txtCustNumber.Text = Fields["CustomerNumber"].ToString();
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

        public void ClearCustomerValues()
        {
            txtCustNumber.Text = null;
            txtTitle.Text = null;
            txtFullName.Text = null;
            txtTelephone.Text = null;
            txtAddTelephone.Text = null;
            txtMobile.Text = null;
            txtEmail.Text = null;
            txtFullAddress.Text = null;
            txtPostcode.Text = null;
            txtArea.Text = null;
            txtFacebookName.Text = null;
            txtLanguage.Text = null;
            txtNotes.Text = null;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            switch(btnCreate.Text)
            {
                case "Create New":
                    {                       
                        btnCreate.Text = "Save";
                        AddDefaultClearValues();
                        ClearCustomerValues();

                        Database db = new BWDatabase.Database();
                        foreach (var Row in db.GetCustomerNumber())
                        {
                            ////////////////////////////////////////////////
                            var Fields = Row as IDictionary<string, object>;
                            string objNumber = Fields["CustomerNumber"].ToString();
                            CustomerNumber = Int32.Parse(objNumber);
                            Console.WriteLine(CustomerNumber);
                               
                            if(CustomerNumber > i)
                            {
                                i = CustomerNumber;
                                Console.WriteLine(i);
                            }
                        }
                        txtCustNumber.Text = CustomerNumber.ToString();

                        break;
                    }
                case "Save":
                    {

                        //Database db = new BWDatabase.Database();
                        //foreach (var Row in db.GetCount())
                        //{
                        //    var Fields = Row as IDictionary<string, object>;
                        //    string objCount = Fields["COUNT(*)"].ToString();
                        //    CustomerCount = Int32.Parse(objCount);
                        //    CustomerCount = CustomerCount + 1;
                        // }
                        //txtCustNumber.Text = CustomerCount.ToString();

                        SaveNewEntry(CustomerNumber);
                        ClearCustomerList();
                        LoadCustomerList();
                        lstCustomers.SelectedIndex = 0;
                        btnCreate.Text = "Create New";
                        break;
                    }
                default:
                    {

                    break;
                    }
            }
        }

        public void AddDefaultClearValues()
        {
            lstCustomers.Items.Add("<New Customer>");
            int Count = lstCustomers.Items.Count;
            lstCustomers.SelectedIndex = Count - 1;
        }

        public void SaveNewEntry(int Count)
        {
            gTitle = txtTitle.Text;
            gFullName = txtFullName.Text;
            gTelephone = txtTelephone.Text;
            gAddTelephone = txtAddTelephone.Text;
            gMobile = txtMobile.Text;
            gEmail = txtEmail.Text;
            gFullAddress = txtFullAddress.Text;
            gPostCode = txtPostcode.Text;
            gArea = txtArea.Text;
            gFacebook = txtFacebookName.Text;
            gLanguage = txtLanguage.Text;
            gNotes = txtNotes.Text;
            
            Database db = new BWDatabase.Database();
            db.SaveEntry(Count, gTitle, gFullName, gTelephone, gAddTelephone, gMobile, gEmail, 
                gFullAddress, gPostCode, gArea, gFacebook, gLanguage, gNotes);
        }

        public void ClearCustomerList()
        {
            lstCustomers.Items.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Database db = new BWDatabase.Database();
            CustNumber = Int32.Parse(txtCustNumber.Text);
            db.DeleteEntry(CustNumber, txtFullName.Text);
            ClearCustomerList();
            ClearCustomerValues();
            LoadCustomerList();
        }
    }
}
