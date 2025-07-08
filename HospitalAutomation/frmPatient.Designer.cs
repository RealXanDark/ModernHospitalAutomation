namespace HospitalAutomation
{
    partial class frmPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatient));
            pnlPatient = new Panel();
            btnSettings = new Button();
            btnNotices = new Button();
            btnAccount = new Button();
            btnLogOut = new Button();
            btnTestResult = new Button();
            btnVisit = new Button();
            btnMakeAnAppointment = new Button();
            btnAppoinment = new Button();
            pnlPatientMain = new Panel();
            pnlPatient.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPatient
            // 
            pnlPatient.BackColor = Color.FromArgb(29, 53, 135);
            pnlPatient.Controls.Add(btnSettings);
            pnlPatient.Controls.Add(btnNotices);
            pnlPatient.Controls.Add(btnAccount);
            pnlPatient.Controls.Add(btnLogOut);
            pnlPatient.Controls.Add(btnTestResult);
            pnlPatient.Controls.Add(btnVisit);
            pnlPatient.Controls.Add(btnMakeAnAppointment);
            pnlPatient.Controls.Add(btnAppoinment);
            resources.ApplyResources(pnlPatient, "pnlPatient");
            pnlPatient.Name = "pnlPatient";
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnSettings, "btnSettings");
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.ForeColor = Color.Transparent;
            btnSettings.Image = Properties.Resources.settingsWhite50x50;
            btnSettings.Name = "btnSettings";
            btnSettings.TabStop = false;
            btnSettings.Tag = "1";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnNotices
            // 
            btnNotices.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnNotices, "btnNotices");
            btnNotices.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnNotices.FlatAppearance.BorderSize = 0;
            btnNotices.ForeColor = Color.Transparent;
            btnNotices.Image = Properties.Resources.notificationWhite50x50;
            btnNotices.Name = "btnNotices";
            btnNotices.TabStop = false;
            btnNotices.Tag = "1";
            btnNotices.UseVisualStyleBackColor = false;
            btnNotices.Click += btnNotices_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnAccount, "btnAccount");
            btnAccount.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.ForeColor = Color.Transparent;
            btnAccount.Image = Properties.Resources.userWhite50x50;
            btnAccount.Name = "btnAccount";
            btnAccount.TabStop = false;
            btnAccount.Tag = "1";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnLogOut, "btnLogOut");
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.ForeColor = Color.Transparent;
            btnLogOut.Image = Properties.Resources.logOutWhite50x50;
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Tag = "1";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnTestResult
            // 
            btnTestResult.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnTestResult, "btnTestResult");
            btnTestResult.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnTestResult.FlatAppearance.BorderSize = 0;
            btnTestResult.ForeColor = Color.Transparent;
            btnTestResult.Image = Properties.Resources.testResultWhite50x50;
            btnTestResult.Name = "btnTestResult";
            btnTestResult.TabStop = false;
            btnTestResult.Tag = "1";
            btnTestResult.UseVisualStyleBackColor = false;
            btnTestResult.Click += btnTestResult_Click;
            // 
            // btnVisit
            // 
            btnVisit.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnVisit, "btnVisit");
            btnVisit.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnVisit.FlatAppearance.BorderSize = 0;
            btnVisit.ForeColor = Color.Transparent;
            btnVisit.Image = Properties.Resources.hospitalWhite50x50;
            btnVisit.Name = "btnVisit";
            btnVisit.TabStop = false;
            btnVisit.Tag = "1";
            btnVisit.UseVisualStyleBackColor = false;
            btnVisit.Click += btnVisit_Click;
            // 
            // btnMakeAnAppointment
            // 
            btnMakeAnAppointment.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnMakeAnAppointment, "btnMakeAnAppointment");
            btnMakeAnAppointment.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnMakeAnAppointment.FlatAppearance.BorderSize = 0;
            btnMakeAnAppointment.ForeColor = Color.Transparent;
            btnMakeAnAppointment.Image = Properties.Resources.makeAppointmentWhite50x50;
            btnMakeAnAppointment.Name = "btnMakeAnAppointment";
            btnMakeAnAppointment.TabStop = false;
            btnMakeAnAppointment.Tag = "1";
            btnMakeAnAppointment.UseVisualStyleBackColor = false;
            btnMakeAnAppointment.Click += btnMakeAnAppointment_Click;
            // 
            // btnAppoinment
            // 
            btnAppoinment.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnAppoinment, "btnAppoinment");
            btnAppoinment.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnAppoinment.FlatAppearance.BorderSize = 0;
            btnAppoinment.ForeColor = Color.Transparent;
            btnAppoinment.Image = Properties.Resources.appointmentWhite50x50;
            btnAppoinment.Name = "btnAppoinment";
            btnAppoinment.TabStop = false;
            btnAppoinment.Tag = "1";
            btnAppoinment.UseVisualStyleBackColor = false;
            btnAppoinment.Click += btnAppoinment_Click;
            // 
            // pnlPatientMain
            // 
            pnlPatientMain.BackColor = Color.White;
            resources.ApplyResources(pnlPatientMain, "pnlPatientMain");
            pnlPatientMain.Name = "pnlPatientMain";
            // 
            // frmPatient
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlPatientMain);
            Controls.Add(pnlPatient);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPatient";
            Load += frmPatient_Load;
            pnlPatient.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        public Button btnVisit;
        public Button btnLogOut;
        public Button btnAppoinment;
        public Button btnTestResult;
        public Button btnAccount;
        public Button btnMakeAnAppointment;
        public Button btnNotices;
        private Panel pnlPatientMain;
        public Button btnSettings;
        public Panel pnlPatient;
    }
}