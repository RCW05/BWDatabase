namespace BWDatabase
{
    partial class frmDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbControlMain = new System.Windows.Forms.TabControl();
            this.tbPgInfo = new System.Windows.Forms.TabPage();
            this.grpAddInfo = new System.Windows.Forms.GroupBox();
            this.btnEditSave = new System.Windows.Forms.Button();
            this.btnAllCancel = new System.Windows.Forms.Button();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.txtFacebookName = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblFacebookName = new System.Windows.Forms.Label();
            this.grpCustomerDetails = new System.Windows.Forms.GroupBox();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtFullAddress = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblFullAddress = new System.Windows.Forms.Label();
            this.grpContact = new System.Windows.Forms.GroupBox();
            this.txtAddTelephone = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMobile = new System.Windows.Forms.Label();
            this.lblAddTelephone = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.grpName = new System.Windows.Forms.GroupBox();
            this.txtCustNumber = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpSelect = new System.Windows.Forms.GroupBox();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.tbPgSched = new System.Windows.Forms.TabPage();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbControlMain.SuspendLayout();
            this.tbPgInfo.SuspendLayout();
            this.grpAddInfo.SuspendLayout();
            this.grpCustomerDetails.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.grpContact.SuspendLayout();
            this.grpName.SuspendLayout();
            this.grpSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlMain
            // 
            this.tbControlMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tbControlMain.Controls.Add(this.tbPgInfo);
            this.tbControlMain.Controls.Add(this.tbPgSched);
            this.tbControlMain.Location = new System.Drawing.Point(12, 12);
            this.tbControlMain.Name = "tbControlMain";
            this.tbControlMain.SelectedIndex = 0;
            this.tbControlMain.Size = new System.Drawing.Size(989, 537);
            this.tbControlMain.TabIndex = 0;
            // 
            // tbPgInfo
            // 
            this.tbPgInfo.BackColor = System.Drawing.SystemColors.Control;
            this.tbPgInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPgInfo.Controls.Add(this.grpAddInfo);
            this.tbPgInfo.Controls.Add(this.grpCustomerDetails);
            this.tbPgInfo.Controls.Add(this.grpSelect);
            this.tbPgInfo.Location = new System.Drawing.Point(4, 25);
            this.tbPgInfo.Name = "tbPgInfo";
            this.tbPgInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgInfo.Size = new System.Drawing.Size(981, 508);
            this.tbPgInfo.TabIndex = 0;
            this.tbPgInfo.Text = "Customer Information";
            // 
            // grpAddInfo
            // 
            this.grpAddInfo.Controls.Add(this.btnEditSave);
            this.grpAddInfo.Controls.Add(this.btnAllCancel);
            this.grpAddInfo.Controls.Add(this.txtNotes);
            this.grpAddInfo.Controls.Add(this.txtLanguage);
            this.grpAddInfo.Controls.Add(this.txtFacebookName);
            this.grpAddInfo.Controls.Add(this.lblNotes);
            this.grpAddInfo.Controls.Add(this.lblLanguage);
            this.grpAddInfo.Controls.Add(this.lblFacebookName);
            this.grpAddInfo.Location = new System.Drawing.Point(607, 23);
            this.grpAddInfo.Name = "grpAddInfo";
            this.grpAddInfo.Size = new System.Drawing.Size(357, 469);
            this.grpAddInfo.TabIndex = 3;
            this.grpAddInfo.TabStop = false;
            this.grpAddInfo.Text = "Additional Information:";
            // 
            // btnEditSave
            // 
            this.btnEditSave.Location = new System.Drawing.Point(167, 426);
            this.btnEditSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditSave.Name = "btnEditSave";
            this.btnEditSave.Size = new System.Drawing.Size(88, 32);
            this.btnEditSave.TabIndex = 3;
            this.btnEditSave.Text = "Save Changes";
            this.btnEditSave.UseVisualStyleBackColor = true;
            this.btnEditSave.Visible = false;
            this.btnEditSave.Click += new System.EventHandler(this.btnEditSave_Click);
            // 
            // btnAllCancel
            // 
            this.btnAllCancel.Location = new System.Drawing.Point(260, 426);
            this.btnAllCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnAllCancel.Name = "btnAllCancel";
            this.btnAllCancel.Size = new System.Drawing.Size(88, 32);
            this.btnAllCancel.TabIndex = 4;
            this.btnAllCancel.Text = "Cancel";
            this.btnAllCancel.UseVisualStyleBackColor = true;
            this.btnAllCancel.Visible = false;
            this.btnAllCancel.Click += new System.EventHandler(this.btnAllCancel_Click);
            // 
            // txtNotes
            // 
            this.txtNotes.AcceptsReturn = true;
            this.txtNotes.Location = new System.Drawing.Point(152, 93);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ReadOnly = true;
            this.txtNotes.Size = new System.Drawing.Size(196, 113);
            this.txtNotes.TabIndex = 2;
            // 
            // txtLanguage
            // 
            this.txtLanguage.Location = new System.Drawing.Point(152, 67);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.ReadOnly = true;
            this.txtLanguage.Size = new System.Drawing.Size(196, 20);
            this.txtLanguage.TabIndex = 1;
            // 
            // txtFacebookName
            // 
            this.txtFacebookName.Location = new System.Drawing.Point(152, 41);
            this.txtFacebookName.Name = "txtFacebookName";
            this.txtFacebookName.ReadOnly = true;
            this.txtFacebookName.Size = new System.Drawing.Size(196, 20);
            this.txtFacebookName.TabIndex = 0;
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(13, 97);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(38, 13);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes:";
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Location = new System.Drawing.Point(13, 71);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(58, 13);
            this.lblLanguage.TabIndex = 2;
            this.lblLanguage.Text = "Language:";
            // 
            // lblFacebookName
            // 
            this.lblFacebookName.AutoSize = true;
            this.lblFacebookName.Location = new System.Drawing.Point(13, 45);
            this.lblFacebookName.Name = "lblFacebookName";
            this.lblFacebookName.Size = new System.Drawing.Size(89, 13);
            this.lblFacebookName.TabIndex = 0;
            this.lblFacebookName.Text = "Facebook Name:";
            // 
            // grpCustomerDetails
            // 
            this.grpCustomerDetails.Controls.Add(this.grpAddress);
            this.grpCustomerDetails.Controls.Add(this.grpContact);
            this.grpCustomerDetails.Controls.Add(this.grpName);
            this.grpCustomerDetails.Location = new System.Drawing.Point(236, 23);
            this.grpCustomerDetails.Name = "grpCustomerDetails";
            this.grpCustomerDetails.Size = new System.Drawing.Size(365, 469);
            this.grpCustomerDetails.TabIndex = 1;
            this.grpCustomerDetails.TabStop = false;
            this.grpCustomerDetails.Text = "Customer Details:";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.txtArea);
            this.grpAddress.Controls.Add(this.lblArea);
            this.grpAddress.Controls.Add(this.txtPostcode);
            this.grpAddress.Controls.Add(this.txtFullAddress);
            this.grpAddress.Controls.Add(this.lblPostcode);
            this.grpAddress.Controls.Add(this.lblFullAddress);
            this.grpAddress.Location = new System.Drawing.Point(6, 311);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(353, 151);
            this.grpAddress.TabIndex = 2;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Addess";
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(151, 125);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(196, 20);
            this.txtArea.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(12, 128);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 20;
            this.lblArea.Text = "Area:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(151, 101);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.ReadOnly = true;
            this.txtPostcode.Size = new System.Drawing.Size(196, 20);
            this.txtPostcode.TabIndex = 1;
            // 
            // txtFullAddress
            // 
            this.txtFullAddress.AcceptsReturn = true;
            this.txtFullAddress.Location = new System.Drawing.Point(151, 23);
            this.txtFullAddress.Multiline = true;
            this.txtFullAddress.Name = "txtFullAddress";
            this.txtFullAddress.ReadOnly = true;
            this.txtFullAddress.Size = new System.Drawing.Size(196, 72);
            this.txtFullAddress.TabIndex = 0;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(12, 104);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(55, 13);
            this.lblPostcode.TabIndex = 18;
            this.lblPostcode.Text = "Postcode:";
            // 
            // lblFullAddress
            // 
            this.lblFullAddress.AutoSize = true;
            this.lblFullAddress.Location = new System.Drawing.Point(12, 26);
            this.lblFullAddress.Name = "lblFullAddress";
            this.lblFullAddress.Size = new System.Drawing.Size(67, 13);
            this.lblFullAddress.TabIndex = 16;
            this.lblFullAddress.Text = "Full Address:";
            // 
            // grpContact
            // 
            this.grpContact.Controls.Add(this.txtAddTelephone);
            this.grpContact.Controls.Add(this.txtTelephone);
            this.grpContact.Controls.Add(this.txtEmail);
            this.grpContact.Controls.Add(this.txtMobile);
            this.grpContact.Controls.Add(this.lblEmail);
            this.grpContact.Controls.Add(this.lblMobile);
            this.grpContact.Controls.Add(this.lblAddTelephone);
            this.grpContact.Controls.Add(this.lblTelephone);
            this.grpContact.Location = new System.Drawing.Point(6, 165);
            this.grpContact.Name = "grpContact";
            this.grpContact.Size = new System.Drawing.Size(353, 140);
            this.grpContact.TabIndex = 1;
            this.grpContact.TabStop = false;
            this.grpContact.Text = "Contact";
            // 
            // txtAddTelephone
            // 
            this.txtAddTelephone.Location = new System.Drawing.Point(151, 50);
            this.txtAddTelephone.Name = "txtAddTelephone";
            this.txtAddTelephone.ReadOnly = true;
            this.txtAddTelephone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddTelephone.Size = new System.Drawing.Size(196, 20);
            this.txtAddTelephone.TabIndex = 1;
            this.txtAddTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(151, 24);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.ReadOnly = true;
            this.txtTelephone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelephone.Size = new System.Drawing.Size(196, 20);
            this.txtTelephone.TabIndex = 0;
            this.txtTelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(151, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(196, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(151, 75);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.ReadOnly = true;
            this.txtMobile.Size = new System.Drawing.Size(196, 20);
            this.txtMobile.TabIndex = 2;
            this.txtMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 103);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 14;
            this.lblEmail.Text = "Email:";
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(12, 78);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(41, 13);
            this.lblMobile.TabIndex = 12;
            this.lblMobile.Text = "Mobile:";
            // 
            // lblAddTelephone
            // 
            this.lblAddTelephone.AutoSize = true;
            this.lblAddTelephone.Location = new System.Drawing.Point(12, 52);
            this.lblAddTelephone.Name = "lblAddTelephone";
            this.lblAddTelephone.Size = new System.Drawing.Size(88, 13);
            this.lblAddTelephone.TabIndex = 10;
            this.lblAddTelephone.Text = "Addl. Telephone:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(12, 26);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(61, 13);
            this.lblTelephone.TabIndex = 8;
            this.lblTelephone.Text = "Telephone:";
            // 
            // grpName
            // 
            this.grpName.Controls.Add(this.txtCustNumber);
            this.grpName.Controls.Add(this.txtFullName);
            this.grpName.Controls.Add(this.txtTitle);
            this.grpName.Controls.Add(this.label1);
            this.grpName.Controls.Add(this.lblFullName);
            this.grpName.Controls.Add(this.lblTitle);
            this.grpName.Location = new System.Drawing.Point(6, 19);
            this.grpName.Name = "grpName";
            this.grpName.Size = new System.Drawing.Size(353, 140);
            this.grpName.TabIndex = 0;
            this.grpName.TabStop = false;
            this.grpName.Text = "Name";
            // 
            // txtCustNumber
            // 
            this.txtCustNumber.Location = new System.Drawing.Point(151, 76);
            this.txtCustNumber.Name = "txtCustNumber";
            this.txtCustNumber.ReadOnly = true;
            this.txtCustNumber.Size = new System.Drawing.Size(196, 20);
            this.txtCustNumber.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(151, 50);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = true;
            this.txtFullName.Size = new System.Drawing.Size(196, 20);
            this.txtFullName.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(151, 24);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(196, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Customer Number:";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(12, 52);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(38, 13);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // grpSelect
            // 
            this.grpSelect.Controls.Add(this.lstCustomers);
            this.grpSelect.Location = new System.Drawing.Point(17, 23);
            this.grpSelect.Name = "grpSelect";
            this.grpSelect.Size = new System.Drawing.Size(213, 469);
            this.grpSelect.TabIndex = 0;
            this.grpSelect.TabStop = false;
            this.grpSelect.Text = "Select Customer:";
            // 
            // lstCustomers
            // 
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.Location = new System.Drawing.Point(17, 38);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(179, 420);
            this.lstCustomers.TabIndex = 0;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // tbPgSched
            // 
            this.tbPgSched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPgSched.Location = new System.Drawing.Point(4, 25);
            this.tbPgSched.Name = "tbPgSched";
            this.tbPgSched.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgSched.Size = new System.Drawing.Size(981, 508);
            this.tbPgSched.TabIndex = 1;
            this.tbPgSched.Text = "Schedule Collection";
            this.tbPgSched.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(632, 552);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(88, 32);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create New";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(725, 552);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(88, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(818, 552);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(911, 552);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1014, 589);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbControlMain);
            this.Name = "frmDatabase";
            this.Text = "Customer Database";
            this.Load += new System.EventHandler(this.frmDatabase_Load);
            this.tbControlMain.ResumeLayout(false);
            this.tbPgInfo.ResumeLayout(false);
            this.grpAddInfo.ResumeLayout(false);
            this.grpAddInfo.PerformLayout();
            this.grpCustomerDetails.ResumeLayout(false);
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.grpContact.ResumeLayout(false);
            this.grpContact.PerformLayout();
            this.grpName.ResumeLayout(false);
            this.grpName.PerformLayout();
            this.grpSelect.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlMain;
        private System.Windows.Forms.TabPage tbPgInfo;
        private System.Windows.Forms.TabPage tbPgSched;
        private System.Windows.Forms.GroupBox grpAddInfo;
        private System.Windows.Forms.GroupBox grpCustomerDetails;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.GroupBox grpName;
        private System.Windows.Forms.GroupBox grpSelect;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtFullAddress;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblFullAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.Label lblAddTelephone;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.TextBox txtFacebookName;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblFacebookName;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditSave;
        private System.Windows.Forms.Button btnAllCancel;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAddTelephone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtCustNumber;
        private System.Windows.Forms.TextBox txtFullName;
    }
}

