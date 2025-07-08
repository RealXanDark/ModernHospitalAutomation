namespace HospitalAutomation
{
    partial class frmVisit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisit));
            flpAppointment = new FlowLayoutPanel();
            btnLoadMore = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // flpAppointment
            // 
            resources.ApplyResources(flpAppointment, "flpAppointment");
            flpAppointment.Name = "flpAppointment";
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
            // lblInfo
            // 
            resources.ApplyResources(lblInfo, "lblInfo");
            lblInfo.ForeColor = Color.Red;
            lblInfo.Name = "lblInfo";
            // 
            // frmVisit
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lblInfo);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(btnLoadMore);
            Controls.Add(flpAppointment);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmVisit";
            Load += frmVisit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpAppointment;
        private Button btnLoadMore;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
        private Label lblInfo;
    }
}