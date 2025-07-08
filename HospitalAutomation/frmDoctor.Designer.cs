namespace HospitalAutomation
{
    partial class frmDoctor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctor));
            pnlDoctorMain = new Panel();
            panel2 = new Panel();
            btnAccount = new Button();
            btnMail = new Button();
            btnLogOut = new Button();
            btnTestResult = new Button();
            btnPastVisit = new Button();
            btnAppoinment = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            tmrMail = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDoctorMain
            // 
            resources.ApplyResources(pnlDoctorMain, "pnlDoctorMain");
            pnlDoctorMain.Name = "pnlDoctorMain";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(29, 53, 135);
            panel2.Controls.Add(btnAccount);
            panel2.Controls.Add(btnMail);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnTestResult);
            panel2.Controls.Add(btnPastVisit);
            panel2.Controls.Add(btnAppoinment);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnAccount, "btnAccount");
            btnAccount.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 75, 194);
            btnAccount.ForeColor = Color.Transparent;
            btnAccount.Name = "btnAccount";
            btnAccount.TabStop = false;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnMail
            // 
            btnMail.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnMail, "btnMail");
            btnMail.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnMail.FlatAppearance.BorderSize = 0;
            btnMail.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 75, 194);
            btnMail.ForeColor = Color.Transparent;
            btnMail.Name = "btnMail";
            btnMail.TabStop = false;
            btnMail.UseVisualStyleBackColor = false;
            btnMail.Click += btnMail_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnLogOut, "btnLogOut");
            btnLogOut.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 75, 194);
            btnLogOut.ForeColor = Color.Transparent;
            btnLogOut.Name = "btnLogOut";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnTestResult
            // 
            btnTestResult.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnTestResult, "btnTestResult");
            btnTestResult.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnTestResult.FlatAppearance.BorderSize = 0;
            btnTestResult.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 75, 194);
            btnTestResult.ForeColor = Color.Transparent;
            btnTestResult.Name = "btnTestResult";
            btnTestResult.TabStop = false;
            btnTestResult.UseVisualStyleBackColor = false;
            btnTestResult.Click += btnTestResult_Click;
            // 
            // btnPastVisit
            // 
            btnPastVisit.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnPastVisit, "btnPastVisit");
            btnPastVisit.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnPastVisit.FlatAppearance.BorderSize = 0;
            btnPastVisit.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 75, 194);
            btnPastVisit.ForeColor = Color.Transparent;
            btnPastVisit.Name = "btnPastVisit";
            btnPastVisit.TabStop = false;
            btnPastVisit.UseVisualStyleBackColor = false;
            btnPastVisit.Click += btnMakeAnAppointment_Click;
            // 
            // btnAppoinment
            // 
            btnAppoinment.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(btnAppoinment, "btnAppoinment");
            btnAppoinment.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnAppoinment.FlatAppearance.BorderSize = 0;
            btnAppoinment.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 75, 194);
            btnAppoinment.ForeColor = Color.Transparent;
            btnAppoinment.Name = "btnAppoinment";
            btnAppoinment.TabStop = false;
            btnAppoinment.UseVisualStyleBackColor = false;
            btnAppoinment.Click += btnAppoinment_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(29, 53, 135);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 37, 27);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // tmrMail
            // 
            tmrMail.Interval = 1000;
            tmrMail.Tick += tmrMail_Tick;
            // 
            // frmDoctor
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pnlDoctorMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDoctor";
            Load += frmDoctor_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDoctorMain;
        private Panel panel2;
        public Button btnLogOut;
        public Button btnTestResult;
        public Button btnPastVisit;
        public Button btnAppoinment;
        private Panel panel1;
        private Panel panel3;
        public Button btnMail;
        public Button btnAccount;
        private System.Windows.Forms.Timer tmrMail;
    }
}