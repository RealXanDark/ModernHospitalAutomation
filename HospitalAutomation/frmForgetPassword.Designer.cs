namespace HospitalAutomation
{
    partial class frmForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgetPassword));
            txtPhoneNumber = new TextBox();
            btnNext = new Button();
            txtIdentityNo = new TextBox();
            lblInformation = new Label();
            pBoxReturn = new PictureBox();
            btnShowIdentityNumber = new Button();
            btnShowPhoneNumber = new Button();
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).BeginInit();
            SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.White;
            resources.ApplyResources(txtPhoneNumber, "txtPhoneNumber");
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.UseSystemPasswordChar = true;
            txtPhoneNumber.KeyPress += txt_KeyPress;
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
            // txtIdentityNo
            // 
            txtIdentityNo.BackColor = Color.White;
            resources.ApplyResources(txtIdentityNo, "txtIdentityNo");
            txtIdentityNo.Name = "txtIdentityNo";
            txtIdentityNo.UseSystemPasswordChar = true;
            txtIdentityNo.KeyPress += txt_KeyPress;
            // 
            // lblInformation
            // 
            resources.ApplyResources(lblInformation, "lblInformation");
            lblInformation.ForeColor = Color.Brown;
            lblInformation.Name = "lblInformation";
            // 
            // pBoxReturn
            // 
            resources.ApplyResources(pBoxReturn, "pBoxReturn");
            pBoxReturn.Name = "pBoxReturn";
            pBoxReturn.TabStop = false;
            pBoxReturn.Click += pBoxReturn_Click;
            // 
            // btnShowIdentityNumber
            // 
            btnShowIdentityNumber.BackColor = Color.Transparent;
            btnShowIdentityNumber.BackgroundImage = Properties.Resources.hide;
            resources.ApplyResources(btnShowIdentityNumber, "btnShowIdentityNumber");
            btnShowIdentityNumber.FlatAppearance.BorderColor = Color.FromArgb(225, 37, 27);
            btnShowIdentityNumber.FlatAppearance.BorderSize = 0;
            btnShowIdentityNumber.Name = "btnShowIdentityNumber";
            btnShowIdentityNumber.Tag = "hide";
            btnShowIdentityNumber.UseVisualStyleBackColor = false;
            btnShowIdentityNumber.Click += btnShow_Click;
            // 
            // btnShowPhoneNumber
            // 
            btnShowPhoneNumber.BackColor = Color.Transparent;
            btnShowPhoneNumber.BackgroundImage = Properties.Resources.hide;
            resources.ApplyResources(btnShowPhoneNumber, "btnShowPhoneNumber");
            btnShowPhoneNumber.FlatAppearance.BorderColor = Color.FromArgb(225, 37, 27);
            btnShowPhoneNumber.FlatAppearance.BorderSize = 0;
            btnShowPhoneNumber.Name = "btnShowPhoneNumber";
            btnShowPhoneNumber.Tag = "hide";
            btnShowPhoneNumber.UseVisualStyleBackColor = false;
            btnShowPhoneNumber.Click += btnShow_Click;
            // 
            // frmForgetPassword
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnShowPhoneNumber);
            Controls.Add(btnShowIdentityNumber);
            Controls.Add(pBoxReturn);
            Controls.Add(lblInformation);
            Controls.Add(txtIdentityNo);
            Controls.Add(btnNext);
            Controls.Add(txtPhoneNumber);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmForgetPassword";
            ((System.ComponentModel.ISupportInitialize)pBoxReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPhoneNumber;
        private Button btnNext;
        private TextBox txtIdentityNo;
        private Label lblInformation;
        public PictureBox pBoxReturn;
        private Button btnShowIdentityNumber;
        private Button btnShowPhoneNumber;
    }
}