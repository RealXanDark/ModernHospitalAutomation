namespace HospitalAutomation
{
    partial class frmQueryTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQueryTicket));
            lblRequest = new Label();
            lblStatus = new Label();
            lblLastUpdate = new Label();
            lblTicketNumber = new Label();
            pnlControls = new Panel();
            rtbTicket = new RichTextBox();
            txtTicketNumber = new TextBox();
            txtIdentityNumber = new TextBox();
            pBoxReturn = new PictureBox();
            lblInformation = new Label();
            btnQueryTicket = new Button();
            pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).BeginInit();
            SuspendLayout();
            // 
            // lblRequest
            // 
            resources.ApplyResources(lblRequest, "lblRequest");
            lblRequest.Name = "lblRequest";
            // 
            // lblStatus
            // 
            resources.ApplyResources(lblStatus, "lblStatus");
            lblStatus.Name = "lblStatus";
            // 
            // lblLastUpdate
            // 
            resources.ApplyResources(lblLastUpdate, "lblLastUpdate");
            lblLastUpdate.Name = "lblLastUpdate";
            // 
            // lblTicketNumber
            // 
            resources.ApplyResources(lblTicketNumber, "lblTicketNumber");
            lblTicketNumber.Name = "lblTicketNumber";
            // 
            // pnlControls
            // 
            pnlControls.BackColor = Color.FromArgb(249, 249, 249);
            pnlControls.Controls.Add(lblTicketNumber);
            pnlControls.Controls.Add(rtbTicket);
            pnlControls.Controls.Add(lblLastUpdate);
            pnlControls.Controls.Add(lblStatus);
            pnlControls.Controls.Add(lblRequest);
            resources.ApplyResources(pnlControls, "pnlControls");
            pnlControls.Name = "pnlControls";
            // 
            // rtbTicket
            // 
            rtbTicket.BackColor = Color.White;
            resources.ApplyResources(rtbTicket, "rtbTicket");
            rtbTicket.Name = "rtbTicket";
            rtbTicket.ReadOnly = true;
            rtbTicket.Click += rtbTicket_Click;
            // 
            // txtTicketNumber
            // 
            txtTicketNumber.BackColor = Color.White;
            resources.ApplyResources(txtTicketNumber, "txtTicketNumber");
            txtTicketNumber.Name = "txtTicketNumber";
            // 
            // txtIdentityNumber
            // 
            txtIdentityNumber.BackColor = Color.White;
            resources.ApplyResources(txtIdentityNumber, "txtIdentityNumber");
            txtIdentityNumber.Name = "txtIdentityNumber";
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
            // btnQueryTicket
            // 
            btnQueryTicket.BackColor = Color.DarkSlateGray;
            btnQueryTicket.FlatAppearance.BorderColor = Color.DarkSlateGray;
            btnQueryTicket.FlatAppearance.BorderSize = 0;
            btnQueryTicket.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            resources.ApplyResources(btnQueryTicket, "btnQueryTicket");
            btnQueryTicket.ForeColor = Color.White;
            btnQueryTicket.Name = "btnQueryTicket";
            btnQueryTicket.TabStop = false;
            btnQueryTicket.UseVisualStyleBackColor = false;
            btnQueryTicket.Click += btnQueryTicket_Click;
            // 
            // frmQueryTicket
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(txtTicketNumber);
            Controls.Add(txtIdentityNumber);
            Controls.Add(pBoxReturn);
            Controls.Add(lblInformation);
            Controls.Add(btnQueryTicket);
            Controls.Add(pnlControls);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmQueryTicket";
            TopMost = true;
            Load += frmQueryTicket_Load;
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblRequest;
        private Label lblStatus;
        private Label lblLastUpdate;
        private Label lblInfo;
        private TextBox txtIdentityNo;
        private Label lblTicketNumber;
        private Panel pnlControls;
        private TextBox txtTicketNumber;
        private TextBox txtIdentityNumber;
        public PictureBox pBoxReturn;
        private Label lblInformation;
        private Button btnQueryTicket;
        private RichTextBox rtbTicket;
    }
}