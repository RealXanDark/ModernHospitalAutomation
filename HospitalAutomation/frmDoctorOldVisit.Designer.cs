namespace HospitalAutomation
{
    partial class frmDoctorOldVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctorOldVisit));
            lblInfo = new Label();
            btnSearch = new Button();
            txtIdentityNumber = new TextBox();
            flpDoctorOldVisit = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblInfo
            // 
            resources.ApplyResources(lblInfo, "lblInfo");
            lblInfo.ForeColor = Color.Brown;
            lblInfo.Name = "lblInfo";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(225, 37, 27);
            resources.ApplyResources(btnSearch, "btnSearch");
            btnSearch.ForeColor = Color.White;
            btnSearch.Name = "btnSearch";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtIdentityNumber
            // 
            resources.ApplyResources(txtIdentityNumber, "txtIdentityNumber");
            txtIdentityNumber.Name = "txtIdentityNumber";
            // 
            // flpDoctorOldVisit
            // 
            resources.ApplyResources(flpDoctorOldVisit, "flpDoctorOldVisit");
            flpDoctorOldVisit.Name = "flpDoctorOldVisit";
            // 
            // frmDoctorOldVisit
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flpDoctorOldVisit);
            Controls.Add(lblInfo);
            Controls.Add(btnSearch);
            Controls.Add(txtIdentityNumber);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDoctorOldVisit";
            FormClosing += frmDoctorOldVisit_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfo;
        private Button btnSearch;
        private TextBox txtIdentityNumber;
        private FlowLayoutPanel flpDoctorOldVisit;
    }
}