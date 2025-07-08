namespace HospitalAutomation
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblRegister = new Label();
            lblInformation = new Label();
            txtIdentityNo = new TextBox();
            lblForgetPassword = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            chkRememberMe = new CheckBox();
            btnShowIdentityNumber = new Button();
            btnShowPassword = new Button();
            lblSendTicket = new Label();
            pbCaptcha = new PictureBox();
            txtCaptcha = new TextBox();
            pboxRefreshCaptcha = new PictureBox();
            tmrLblInfo = new System.Windows.Forms.Timer(components);
            tmrCheckTempBan = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbCaptcha).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxRefreshCaptcha).BeginInit();
            SuspendLayout();
            // 
            // lblRegister
            // 
            resources.ApplyResources(lblRegister, "lblRegister");
            lblRegister.BackColor = Color.Transparent;
            lblRegister.ForeColor = Color.FromArgb(88, 169, 255);
            lblRegister.Name = "lblRegister";
            lblRegister.Tag = "1";
            lblRegister.Click += lblRegister_Click;
            // 
            // lblInformation
            // 
            resources.ApplyResources(lblInformation, "lblInformation");
            lblInformation.ForeColor = Color.Brown;
            lblInformation.Name = "lblInformation";
            // 
            // txtIdentityNo
            // 
            resources.ApplyResources(txtIdentityNo, "txtIdentityNo");
            txtIdentityNo.BackColor = Color.White;
            txtIdentityNo.Name = "txtIdentityNo";
            txtIdentityNo.Tag = "";
            txtIdentityNo.UseSystemPasswordChar = true;
            txtIdentityNo.KeyPress += txt_KeyPress;
            // 
            // lblForgetPassword
            // 
            resources.ApplyResources(lblForgetPassword, "lblForgetPassword");
            lblForgetPassword.BackColor = Color.Transparent;
            lblForgetPassword.ForeColor = Color.FromArgb(88, 169, 255);
            lblForgetPassword.Name = "lblForgetPassword";
            lblForgetPassword.Tag = "1";
            lblForgetPassword.Click += lblForgetPassword_Click;
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.BackColor = Color.FromArgb(29, 53, 135);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.ForeColor = Color.White;
            btnLogin.Name = "btnLogin";
            btnLogin.Tag = "1";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.BackColor = Color.White;
            txtPassword.Name = "txtPassword";
            txtPassword.Tag = "";
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyPress += txt_KeyPress;
            // 
            // chkRememberMe
            // 
            resources.ApplyResources(chkRememberMe, "chkRememberMe");
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Tag = "";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // btnShowIdentityNumber
            // 
            resources.ApplyResources(btnShowIdentityNumber, "btnShowIdentityNumber");
            btnShowIdentityNumber.BackColor = Color.Transparent;
            btnShowIdentityNumber.BackgroundImage = Properties.Resources.hide;
            btnShowIdentityNumber.FlatAppearance.BorderColor = Color.FromArgb(225, 37, 27);
            btnShowIdentityNumber.FlatAppearance.BorderSize = 0;
            btnShowIdentityNumber.Name = "btnShowIdentityNumber";
            btnShowIdentityNumber.Tag = "hide";
            btnShowIdentityNumber.UseVisualStyleBackColor = false;
            btnShowIdentityNumber.Click += btnShow_Click;
            // 
            // btnShowPassword
            // 
            resources.ApplyResources(btnShowPassword, "btnShowPassword");
            btnShowPassword.BackColor = Color.Transparent;
            btnShowPassword.BackgroundImage = Properties.Resources.hide;
            btnShowPassword.FlatAppearance.BorderColor = Color.FromArgb(225, 37, 27);
            btnShowPassword.FlatAppearance.BorderSize = 0;
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Tag = "hide";
            btnShowPassword.UseVisualStyleBackColor = false;
            btnShowPassword.Click += btnShow_Click;
            // 
            // lblSendTicket
            // 
            resources.ApplyResources(lblSendTicket, "lblSendTicket");
            lblSendTicket.BackColor = Color.Transparent;
            lblSendTicket.ForeColor = Color.FromArgb(88, 169, 255);
            lblSendTicket.Name = "lblSendTicket";
            lblSendTicket.Tag = "1";
            lblSendTicket.Click += lblSendTicket_Click;
            // 
            // pbCaptcha
            // 
            resources.ApplyResources(pbCaptcha, "pbCaptcha");
            pbCaptcha.BorderStyle = BorderStyle.Fixed3D;
            pbCaptcha.Name = "pbCaptcha";
            pbCaptcha.TabStop = false;
            // 
            // txtCaptcha
            // 
            resources.ApplyResources(txtCaptcha, "txtCaptcha");
            txtCaptcha.BackColor = Color.White;
            txtCaptcha.Name = "txtCaptcha";
            // 
            // pboxRefreshCaptcha
            // 
            resources.ApplyResources(pboxRefreshCaptcha, "pboxRefreshCaptcha");
            pboxRefreshCaptcha.Name = "pboxRefreshCaptcha";
            pboxRefreshCaptcha.TabStop = false;
            pboxRefreshCaptcha.Click += pboxRefreshCaptcha_Click;
            // 
            // tmrLblInfo
            // 
            tmrLblInfo.Tick += tmrLblInfo_Tick;
            // 
            // tmrCheckTempBan
            // 
            tmrCheckTempBan.Interval = 1000;
            tmrCheckTempBan.Tick += tmrCheckTempBan_Tick;
            // 
            // frmLogin
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pboxRefreshCaptcha);
            Controls.Add(pbCaptcha);
            Controls.Add(txtCaptcha);
            Controls.Add(lblSendTicket);
            Controls.Add(btnShowPassword);
            Controls.Add(btnShowIdentityNumber);
            Controls.Add(lblRegister);
            Controls.Add(lblInformation);
            Controls.Add(txtIdentityNo);
            Controls.Add(lblForgetPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(chkRememberMe);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Load += frmLogin_Load;
            Click += frmLogin_Click;
            ((System.ComponentModel.ISupportInitialize)pbCaptcha).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxRefreshCaptcha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRegister;
        private Label lblInformation;
        private TextBox txtIdentityNo;
        private Label lblForgetPassword;
        private Button btnLogin;
        private TextBox txtPassword;
        private CheckBox chkRememberMe;
        private Button btnShowIdentityNumber;
        private Button btnShowPassword;
        private Label lblSendTicket;
        private PictureBox pbCaptcha;
        private TextBox txtCaptcha;
        private PictureBox pboxRefreshCaptcha;
        private System.Windows.Forms.Timer tmrLblInfo;
        private System.Windows.Forms.Timer tmrCheckTempBan;
    }
}