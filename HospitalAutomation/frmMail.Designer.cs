namespace HospitalAutomation
{
    partial class frmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMail));
            flpMail = new FlowLayoutPanel();
            rtbMail = new RichTextBox();
            lblSender = new Label();
            lblReceiver = new Label();
            lblSubject = new Label();
            lblDate = new Label();
            btnLoadMore = new Button();
            pboxRefreshMail = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pboxRefreshMail).BeginInit();
            SuspendLayout();
            // 
            // flpMail
            // 
            resources.ApplyResources(flpMail, "flpMail");
            flpMail.Name = "flpMail";
            // 
            // rtbMail
            // 
            resources.ApplyResources(rtbMail, "rtbMail");
            rtbMail.Name = "rtbMail";
            rtbMail.ReadOnly = true;
            rtbMail.SelectionChanged += rtbMail_SelectionChanged;
            rtbMail.Click += rtbMail_Click;
            rtbMail.Enter += rtbMail_Enter;
            rtbMail.KeyDown += rtbMail_KeyDown;
            // 
            // lblSender
            // 
            resources.ApplyResources(lblSender, "lblSender");
            lblSender.Name = "lblSender";
            // 
            // lblReceiver
            // 
            resources.ApplyResources(lblReceiver, "lblReceiver");
            lblReceiver.Name = "lblReceiver";
            // 
            // lblSubject
            // 
            resources.ApplyResources(lblSubject, "lblSubject");
            lblSubject.Name = "lblSubject";
            // 
            // lblDate
            // 
            resources.ApplyResources(lblDate, "lblDate");
            lblDate.Name = "lblDate";
            // 
            // btnLoadMore
            // 
            btnLoadMore.BackColor = Color.FromArgb(225, 37, 27);
            btnLoadMore.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnLoadMore, "btnLoadMore");
            btnLoadMore.ForeColor = Color.White;
            btnLoadMore.Name = "btnLoadMore";
            btnLoadMore.UseVisualStyleBackColor = false;
            btnLoadMore.Click += btnLoadMore_Click;
            // 
            // pboxRefreshMail
            // 
            pboxRefreshMail.Image = Properties.Resources.refreshBlack;
            resources.ApplyResources(pboxRefreshMail, "pboxRefreshMail");
            pboxRefreshMail.Name = "pboxRefreshMail";
            pboxRefreshMail.TabStop = false;
            pboxRefreshMail.Click += pboxRefreshMail_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(225, 37, 27);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(225, 37, 27);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(225, 37, 27);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // frmMail
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(pboxRefreshMail);
            Controls.Add(btnLoadMore);
            Controls.Add(lblDate);
            Controls.Add(lblSender);
            Controls.Add(lblReceiver);
            Controls.Add(lblSubject);
            Controls.Add(rtbMail);
            Controls.Add(flpMail);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMail";
            Load += frmMail_Load;
            ((System.ComponentModel.ISupportInitialize)pboxRefreshMail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpMail;
        private RichTextBox rtbMail;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblSender;
        private Label lblReceiver;
        private Label lblSubject;
        private Label lblDate;
        private Button btnLoadMore;
        private PictureBox pboxRefreshMail;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
    }
}