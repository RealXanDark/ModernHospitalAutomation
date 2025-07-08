namespace HospitalAutomation
{
    partial class frmForgetPasswordVerification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgetPasswordVerification));
            tmrVerification = new System.Windows.Forms.Timer(components);
            pBoxReturn = new PictureBox();
            lblInformation = new Label();
            txtIdentityNo = new TextBox();
            btnNext = new Button();
            lblResendVerificationCode = new Label();
            lblRemainingTime = new Label();
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).BeginInit();
            SuspendLayout();
            // 
            // tmrVerification
            // 
            tmrVerification.Interval = 1000;
            // 
            // pBoxReturn
            // 
            resources.ApplyResources(pBoxReturn, "pBoxReturn");
            pBoxReturn.Name = "pBoxReturn";
            pBoxReturn.TabStop = false;
            // 
            // lblInformation
            // 
            resources.ApplyResources(lblInformation, "lblInformation");
            lblInformation.ForeColor = Color.Brown;
            lblInformation.Name = "lblInformation";
            // 
            // txtIdentityNo
            // 
            txtIdentityNo.BackColor = Color.White;
            resources.ApplyResources(txtIdentityNo, "txtIdentityNo");
            txtIdentityNo.Name = "txtIdentityNo";
            txtIdentityNo.UseSystemPasswordChar = true;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(29, 53, 135);
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            btnNext.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.ForeColor = Color.White;
            btnNext.Name = "btnNext";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // lblResendVerificationCode
            // 
            resources.ApplyResources(lblResendVerificationCode, "lblResendVerificationCode");
            lblResendVerificationCode.BackColor = Color.Transparent;
            lblResendVerificationCode.ForeColor = Color.FromArgb(88, 169, 255);
            lblResendVerificationCode.Name = "lblResendVerificationCode";
            // 
            // lblRemainingTime
            // 
            resources.ApplyResources(lblRemainingTime, "lblRemainingTime");
            lblRemainingTime.Name = "lblRemainingTime";
            // 
            // frmForgetPasswordVerification
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblResendVerificationCode);
            Controls.Add(lblRemainingTime);
            Controls.Add(pBoxReturn);
            Controls.Add(lblInformation);
            Controls.Add(txtIdentityNo);
            Controls.Add(btnNext);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmForgetPasswordVerification";
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer tmrVerification;
        public PictureBox pBoxReturn;
        private Label lblInformation;
        private TextBox txtIdentityNo;
        private Button btnNext;
        private Label lblResendVerificationCode;
        private Label lblRemainingTime;
    }
}