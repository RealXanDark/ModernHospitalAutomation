namespace HospitalAutomation
{
    partial class frmError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmError));
            pictureBox1 = new PictureBox();
            lblInformation = new Label();
            btnOk = new Button();
            pnlLayout = new Panel();
            btnExit = new Button();
            btnRetry = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlLayout.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // lblInformation
            // 
            resources.ApplyResources(lblInformation, "lblInformation");
            lblInformation.Name = "lblInformation";
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(225, 37, 27);
            btnOk.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnOk, "btnOk");
            btnOk.ForeColor = Color.White;
            btnOk.Name = "btnOk";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // pnlLayout
            // 
            pnlLayout.BackColor = Color.FromArgb(225, 37, 27);
            pnlLayout.Controls.Add(btnExit);
            resources.ApplyResources(pnlLayout, "pnlLayout");
            pnlLayout.Name = "pnlLayout";
            pnlLayout.MouseDown += pnlLayout_MouseDown;
            // 
            // btnExit
            // 
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(225, 37, 27);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRetry
            // 
            btnRetry.BackColor = Color.DarkGreen;
            btnRetry.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnRetry, "btnRetry");
            btnRetry.ForeColor = Color.White;
            btnRetry.Name = "btnRetry";
            btnRetry.UseVisualStyleBackColor = false;
            btnRetry.Click += btnRetry_Click;
            // 
            // frmError
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(btnRetry);
            Controls.Add(pnlLayout);
            Controls.Add(btnOk);
            Controls.Add(lblInformation);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmError";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblInformation;
        private Button btnOk;
        public Panel pnlLayout;
        private Button btnRetry;
        private Button btnExit;
    }
}