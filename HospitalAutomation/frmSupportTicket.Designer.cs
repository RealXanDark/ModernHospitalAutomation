namespace HospitalAutomation
{
    partial class frmSupportTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupportTicket));
            txtIssueDescription = new TextBox();
            pBoxReturn = new PictureBox();
            lblInformation = new Label();
            txtIdentityNumber = new TextBox();
            btnSendTicket = new Button();
            cbRequestTypes = new ComboBox();
            btnQueryTicket = new Button();
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).BeginInit();
            SuspendLayout();
            // 
            // txtIssueDescription
            // 
            resources.ApplyResources(txtIssueDescription, "txtIssueDescription");
            txtIssueDescription.Name = "txtIssueDescription";
            // 
            // pBoxReturn
            // 
            resources.ApplyResources(pBoxReturn, "pBoxReturn");
            pBoxReturn.Name = "pBoxReturn";
            pBoxReturn.TabStop = false;
            pBoxReturn.Click += pBoxReturn_Click;
            // 
            // lblInformation
            // 
            resources.ApplyResources(lblInformation, "lblInformation");
            lblInformation.ForeColor = Color.Brown;
            lblInformation.Name = "lblInformation";
            // 
            // txtIdentityNumber
            // 
            txtIdentityNumber.BackColor = Color.White;
            resources.ApplyResources(txtIdentityNumber, "txtIdentityNumber");
            txtIdentityNumber.Name = "txtIdentityNumber";
            txtIdentityNumber.UseSystemPasswordChar = true;
            // 
            // btnSendTicket
            // 
            btnSendTicket.BackColor = Color.FromArgb(29, 53, 135);
            btnSendTicket.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnSendTicket.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnSendTicket, "btnSendTicket");
            btnSendTicket.ForeColor = Color.White;
            btnSendTicket.Name = "btnSendTicket";
            btnSendTicket.UseVisualStyleBackColor = false;
            btnSendTicket.Click += btnSendTicket_Click;
            // 
            // cbRequestTypes
            // 
            cbRequestTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cbRequestTypes, "cbRequestTypes");
            cbRequestTypes.FormattingEnabled = true;
            cbRequestTypes.Name = "cbRequestTypes";
            // 
            // btnQueryTicket
            // 
            btnQueryTicket.BackColor = Color.DarkSlateGray;
            btnQueryTicket.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnQueryTicket.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnQueryTicket, "btnQueryTicket");
            btnQueryTicket.ForeColor = Color.White;
            btnQueryTicket.Name = "btnQueryTicket";
            btnQueryTicket.UseVisualStyleBackColor = false;
            btnQueryTicket.Click += btnQueryTicket_Click;
            // 
            // frmSupportTicket
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnQueryTicket);
            Controls.Add(pBoxReturn);
            Controls.Add(lblInformation);
            Controls.Add(txtIdentityNumber);
            Controls.Add(btnSendTicket);
            Controls.Add(txtIssueDescription);
            Controls.Add(cbRequestTypes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSupportTicket";
            TopMost = true;
            Load += frmSupportTicket_Load;
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel pnlLayout;
        private Label label1;
        private Button btnExit;
        private TextBox txtIssueDescription;
        private Label label2;
        private Button btnSendTicket;
        private ComboBox cbRequestTypes;
        private Button btnQueryTicket;
        private TextBox txtIdentityNumber;
        private Panel panel2;
        private Panel panel1;
        private Button btnShowPhoneNumber;
        private Button btnShowIdentityNumber;
        public PictureBox pBoxReturn;
        private Label lblInformation;
        private TextBox txtPhoneNumber;
    }
}