using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace BWDatabase
{
    public partial class frmDatabase : Form
    {

        int CustNumber;
        int CustomerNumber;
        string FName;
        //
        string gTitle;
        string gFullName;
        string gTelephone;
        string gAddTelephone;
        string gMobile;
        string gEmail;
        string gFullAddress;
        string gPostCode;
        string gArea;
        string gFacebook;
        string gLanguage;
        string gNotes;
        //
        const string CreateNew = "Create New";
        const string Save = "Save";
        const string NewCust = "<New Customer>";
        const string CustNumText = "txtCustNumber";
        const string CustEmailText = "txtEmail";

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
            btnEdit.Enabled = false;
            btnEditSave.Visible = true;
            btnAllCancel.Visible = true;
            lstCustomers.Enabled = false;
            //Save Information currently held in textboxes.
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
            //
            LockOrUnlockFields(true);

        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
            lstCustomers.SelectedIndex = 0;
        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstCustomers.SelectedItem.ToString()== NewCust)
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
            if(txtTelephone.Text == "0")
            {
                txtTelephone.Text = "";
            }
            if (txtAddTelephone.Text == "0")
            {
                txtAddTelephone.Text = "";
            }
            if (txtMobile.Text == "0")
            {
                txtMobile.Text = "";
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
                case CreateNew:
                    {
                        btnCreate.Text = Save;
                        btnEdit.Enabled = false;
                        btnDelete.Enabled = false;
                        btnAllCancel.Visible = true;
                        lstCustomers.Enabled = false;
                        AddDefaultClearValues();
                        ClearCustomerValues();

                        Database db = new BWDatabase.Database();
                        int x = 1;
                        foreach (var Row in db.GetCustomerNumber())
                        {                         
                            var Fields = Row as IDictionary<string, object>;
                            string objNumber = Fields["CustomerNumber"].ToString();
                            CustomerNumber = Int32.Parse(objNumber);

                            if (x != CustomerNumber)
                            {
                                CustomerNumber = x;
                                break;
                            }
                            else 
                            {
                                x = x + 1;
                                CustomerNumber = x;
                            }
                        }
                        txtCustNumber.Text = CustomerNumber.ToString();
                        LockOrUnlockFields(true);
                        break;
                    }
                case Save:
                    {
                        if (ValidateNameFields())
                        {                     
                            if (ValidateContactFields())
                            {
                                SaveNewEntry(CustomerNumber);
                                ClearCustomerList();
                                LoadCustomerList();
                                lstCustomers.SelectedIndex = 0;
                                lstCustomers.Enabled = true;
                                btnCreate.Text = CreateNew;
                                btnEdit.Enabled = true;
                                btnDelete.Enabled = true;
                                btnAllCancel.Visible = false;
                                LockOrUnlockFields(false);
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Unable to save, requires validation");
                                break;
                                //Do Nothing
                            }
                        }
                        else
                        {
                            MessageBox.Show("Unable to save, requires validation");
                            break;
                            //Do Nothing
                        }
                    }
                default:
                    {

                    break;
                    }                    
            }
        }

        public void AddDefaultClearValues()
        {
            lstCustomers.Items.Add(NewCust);
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

        private void btnAllCancel_Click(object sender, EventArgs e)
        {
        if(btnCreate.Text == Save)
            {
                ClearCustomerList();
                LoadCustomerList();
                btnCreate.Text = CreateNew;
                lstCustomers.Enabled = true;
                lstCustomers.SelectedIndex = 0;
                btnAllCancel.Visible = false;
                btnEdit.Enabled = true;
                LockOrUnlockFields(false);
            }
            else
            {
                btnEdit.Enabled = true;
                btnEditSave.Visible = false;
                btnAllCancel.Visible = false;
                lstCustomers.Enabled = true;
                txtTitle.Text = gTitle;
                txtFullName.Text = gFullName;
                txtTelephone.Text = gTelephone;
                txtAddTelephone.Text = gAddTelephone;
                txtMobile.Text = gMobile;
                txtEmail.Text = gEmail;
                txtFullAddress.Text = gFullAddress;
                txtPostcode.Text = gPostCode;
                txtPostcode.Text = gPostCode;
                txtArea.Text = gArea;
                txtFacebookName.Text = gFacebook;
                txtLanguage.Text = gLanguage;
                txtNotes.Text = gNotes;
                LockOrUnlockFields(false);
            }
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {

        }

        private void LockOrUnlockFields(Boolean LockorUnlock)
        {
            switch(LockorUnlock)
            {
                case true:
                    {
                        txtTitle.ReadOnly = false;
                        txtFullName.ReadOnly = false;
                        txtTelephone.ReadOnly = false;
                        txtAddTelephone.ReadOnly = false;
                        txtMobile.ReadOnly = false;
                        txtEmail.ReadOnly = false;
                        txtFullAddress.ReadOnly = false;
                        txtPostcode.ReadOnly = false;
                        txtArea.ReadOnly = false;
                        txtFacebookName.ReadOnly = false;
                        txtLanguage.ReadOnly = false;
                        txtNotes.ReadOnly = false;
                        break;
                    }
                case false:
                    {
                        txtTitle.ReadOnly = true;
                        txtFullName.ReadOnly = true;
                        txtTelephone.ReadOnly = true;
                        txtAddTelephone.ReadOnly = true;
                        txtMobile.ReadOnly = true;
                        txtEmail.ReadOnly = true;
                        txtFullAddress.ReadOnly = true;
                        txtPostcode.ReadOnly = true;
                        txtArea.ReadOnly = true;
                        txtFacebookName.ReadOnly = true;
                        txtLanguage.ReadOnly = true;
                        txtNotes.ReadOnly = true;
                        break;
                    }
            }
        }
        public bool ValidateContactFields()
        {
            foreach (Control control in grpContact.Controls)
            {
                if (control.Text.ToString().Length > 0)
                { 
                    if (control.GetType() == typeof(TextBox))
                    {
                        if (control.Name == CustEmailText)
                        {
                            //Do Nothing, Expected.
                        }
                        else
                        {
                            long num;
                            bool isNum = Int64.TryParse(control.Text.Trim(), out num);
                            Console.WriteLine(control.Name);
                            if (!isNum)
                            {
                                return false;
                            }
                        }
                    }
                }
                else
                {
                    control.Text = "0";
                    Console.WriteLine(control.Name);
                }
            }
            return true;
        }

        public bool ValidateNameFields()
        {
            foreach (Control control in grpName.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    if (control.Name == CustNumText)
                    {
                        //Do Nothing, Expected.
                    }
                    else
                    {
                        if (txtFullName.TextLength == 0 || txtFullName.TextLength == 1)
                        {
                            //Empty or insufficient Name field length.
                            return false;
                        }
                    }
                }
            }
            return true;
        }
    }
}
