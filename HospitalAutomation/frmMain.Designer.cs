namespace HospitalAutomation
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            pnlLayout = new Panel();
            lblTitle = new Label();
            btnMinimized = new Button();
            btnExit = new Button();
            pnlMain = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            pnlLayout.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLayout
            // 
            pnlLayout.BackColor = Color.FromArgb(225, 37, 27);
            pnlLayout.Controls.Add(lblTitle);
            pnlLayout.Controls.Add(btnMinimized);
            pnlLayout.Controls.Add(btnExit);
            resources.ApplyResources(pnlLayout, "pnlLayout");
            pnlLayout.Name = "pnlLayout";
            pnlLayout.Tag = "1";
            pnlLayout.MouseDown += pnlLayout_MouseDown;
            // 
            // lblTitle
            // 
            resources.ApplyResources(lblTitle, "lblTitle");
            lblTitle.ForeColor = Color.White;
            lblTitle.Name = "lblTitle";
            lblTitle.Tag = "1";
            // 
            // btnMinimized
            // 
            resources.ApplyResources(btnMinimized, "btnMinimized");
            btnMinimized.FlatAppearance.BorderSize = 0;
            btnMinimized.Name = "btnMinimized";
            btnMinimized.UseVisualStyleBackColor = true;
            btnMinimized.Click += btnMinimized_Click;
            // 
            // btnExit
            // 
            btnExit.BackgroundImage = Properties.Resources.exitWhite;
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pnlMain
            // 
            resources.ApplyResources(pnlMain, "pnlMain");
            pnlMain.Name = "pnlMain";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 37, 27);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            panel3.Tag = "1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(225, 37, 27);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            panel2.Tag = "1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 37, 27);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            panel1.Tag = "1";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlMain);
            Controls.Add(pnlLayout);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "frmMain";
            FormClosing += frmMain_FormClosing;
            FormClosed += frmMain_FormClosed;
            Load += frmMain_Load;
            pnlLayout.ResumeLayout(false);
            pnlLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Panel pnlLayout;
        public Panel pnlMain;
        public Panel panel3;
        public Panel panel2;
        public Panel panel1;
        public Label lblTitle;
        public Button btnMinimized;
        public Button btnExit;
    }
}
