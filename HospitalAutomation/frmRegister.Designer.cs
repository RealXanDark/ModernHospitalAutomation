namespace HospitalAutomation
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            pBoxReturn = new PictureBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label1 = new Label();
            rbGenderMale = new RadioButton();
            rbGenderFemale = new RadioButton();
            btnRegister = new Button();
            cbBloodGroup = new ComboBox();
            txtPhoneNumber = new TextBox();
            txtEMail = new TextBox();
            txtIdentityNo = new TextBox();
            txtSurname = new TextBox();
            txtName = new TextBox();
            cbDay = new ComboBox();
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            lblInformation = new Label();
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).BeginInit();
            SuspendLayout();
            // 
            // pBoxReturn
            // 
            resources.ApplyResources(pBoxReturn, "pBoxReturn");
            pBoxReturn.Name = "pBoxReturn";
            pBoxReturn.TabStop = false;
            pBoxReturn.Click += pBoxReturn_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Gray;
            label2.Name = "label2";
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Gray;
            label1.Name = "label1";
            // 
            // rbGenderMale
            // 
            resources.ApplyResources(rbGenderMale, "rbGenderMale");
            rbGenderMale.Name = "rbGenderMale";
            rbGenderMale.TabStop = true;
            rbGenderMale.UseVisualStyleBackColor = true;
            // 
            // rbGenderFemale
            // 
            resources.ApplyResources(rbGenderFemale, "rbGenderFemale");
            rbGenderFemale.Name = "rbGenderFemale";
            rbGenderFemale.TabStop = true;
            rbGenderFemale.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnRegister, "btnRegister");
            btnRegister.ForeColor = Color.White;
            btnRegister.Name = "btnRegister";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cbBloodGroup
            // 
            cbBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cbBloodGroup, "cbBloodGroup");
            cbBloodGroup.ForeColor = Color.Black;
            cbBloodGroup.FormattingEnabled = true;
            cbBloodGroup.Items.AddRange(new object[] { resources.GetString("cbBloodGroup.Items"), resources.GetString("cbBloodGroup.Items1"), resources.GetString("cbBloodGroup.Items2"), resources.GetString("cbBloodGroup.Items3"), resources.GetString("cbBloodGroup.Items4"), resources.GetString("cbBloodGroup.Items5"), resources.GetString("cbBloodGroup.Items6"), resources.GetString("cbBloodGroup.Items7") });
            cbBloodGroup.Name = "cbBloodGroup";
            // 
            // txtPhoneNumber
            // 
            resources.ApplyResources(txtPhoneNumber, "txtPhoneNumber");
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Tag = "number";
            // 
            // txtEMail
            // 
            resources.ApplyResources(txtEMail, "txtEMail");
            txtEMail.Name = "txtEMail";
            // 
            // txtIdentityNo
            // 
            resources.ApplyResources(txtIdentityNo, "txtIdentityNo");
            txtIdentityNo.Name = "txtIdentityNo";
            txtIdentityNo.Tag = "number";
            txtIdentityNo.UseSystemPasswordChar = true;
            // 
            // txtSurname
            // 
            resources.ApplyResources(txtSurname, "txtSurname");
            txtSurname.Name = "txtSurname";
            txtSurname.Tag = "letter";
            // 
            // txtName
            // 
            resources.ApplyResources(txtName, "txtName");
            txtName.Name = "txtName";
            txtName.Tag = "letter";
            // 
            // cbDay
            // 
            cbDay.DropDownHeight = 200;
            cbDay.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cbDay, "cbDay");
            cbDay.ForeColor = Color.Black;
            cbDay.FormattingEnabled = true;
            cbDay.Items.AddRange(new object[] { resources.GetString("cbDay.Items"), resources.GetString("cbDay.Items1"), resources.GetString("cbDay.Items2"), resources.GetString("cbDay.Items3"), resources.GetString("cbDay.Items4"), resources.GetString("cbDay.Items5"), resources.GetString("cbDay.Items6"), resources.GetString("cbDay.Items7"), resources.GetString("cbDay.Items8"), resources.GetString("cbDay.Items9"), resources.GetString("cbDay.Items10"), resources.GetString("cbDay.Items11"), resources.GetString("cbDay.Items12"), resources.GetString("cbDay.Items13"), resources.GetString("cbDay.Items14"), resources.GetString("cbDay.Items15"), resources.GetString("cbDay.Items16"), resources.GetString("cbDay.Items17"), resources.GetString("cbDay.Items18"), resources.GetString("cbDay.Items19"), resources.GetString("cbDay.Items20"), resources.GetString("cbDay.Items21"), resources.GetString("cbDay.Items22"), resources.GetString("cbDay.Items23"), resources.GetString("cbDay.Items24"), resources.GetString("cbDay.Items25"), resources.GetString("cbDay.Items26"), resources.GetString("cbDay.Items27"), resources.GetString("cbDay.Items28"), resources.GetString("cbDay.Items29"), resources.GetString("cbDay.Items30") });
            cbDay.Name = "cbDay";
            cbDay.DropDown += cbDay_DropDown;
            // 
            // cbMonth
            // 
            cbMonth.DropDownHeight = 200;
            cbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cbMonth, "cbMonth");
            cbMonth.ForeColor = Color.Black;
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { resources.GetString("cbMonth.Items"), resources.GetString("cbMonth.Items1"), resources.GetString("cbMonth.Items2"), resources.GetString("cbMonth.Items3"), resources.GetString("cbMonth.Items4"), resources.GetString("cbMonth.Items5"), resources.GetString("cbMonth.Items6"), resources.GetString("cbMonth.Items7"), resources.GetString("cbMonth.Items8"), resources.GetString("cbMonth.Items9"), resources.GetString("cbMonth.Items10"), resources.GetString("cbMonth.Items11") });
            cbMonth.Name = "cbMonth";
            // 
            // cbYear
            // 
            cbYear.DropDownHeight = 200;
            cbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cbYear, "cbYear");
            cbYear.ForeColor = Color.Black;
            cbYear.FormattingEnabled = true;
            cbYear.Name = "cbYear";
            // 
            // lblInformation
            // 
            resources.ApplyResources(lblInformation, "lblInformation");
            lblInformation.ForeColor = Color.Brown;
            lblInformation.Name = "lblInformation";
            // 
            // frmRegister
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblInformation);
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Controls.Add(cbDay);
            Controls.Add(pBoxReturn);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(rbGenderMale);
            Controls.Add(rbGenderFemale);
            Controls.Add(btnRegister);
            Controls.Add(cbBloodGroup);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEMail);
            Controls.Add(txtIdentityNo);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRegister";
            Load += frmRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public PictureBox pBoxReturn;
        private Label label2;
        private TextBox txtPassword;
        private Label label1;
        private RadioButton rbGenderMale;
        private RadioButton rbGenderFemale;
        private Button btnRegister;
        private ComboBox cbBloodGroup;
        private TextBox txtPhoneNumber;
        private TextBox txtEMail;
        private TextBox txtIdentityNo;
        private TextBox txtSurname;
        private TextBox txtName;
        private ComboBox cbDay;
        private ComboBox cbMonth;
        private ComboBox cbYear;
        private Label lblInformation;
    }
}