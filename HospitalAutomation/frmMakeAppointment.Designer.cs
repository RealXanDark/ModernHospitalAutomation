namespace HospitalAutomation
{
    partial class frmMakeAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMakeAppointment));
            btnReviewAppointment = new Button();
            label7 = new Label();
            cbTime = new ComboBox();
            label6 = new Label();
            dtpDate = new DateTimePicker();
            label5 = new Label();
            cbDoctor = new ComboBox();
            label4 = new Label();
            cbClinic = new ComboBox();
            label3 = new Label();
            cbHospital = new ComboBox();
            label2 = new Label();
            cbDistrict = new ComboBox();
            label1 = new Label();
            cbProvince = new ComboBox();
            panel2 = new Panel();
            panel1 = new Panel();
            panel3 = new Panel();
            SuspendLayout();
            // 
            // btnReviewAppointment
            // 
            btnReviewAppointment.BackColor = Color.FromArgb(225, 37, 27);
            resources.ApplyResources(btnReviewAppointment, "btnReviewAppointment");
            btnReviewAppointment.FlatAppearance.BorderSize = 0;
            btnReviewAppointment.ForeColor = Color.White;
            btnReviewAppointment.Name = "btnReviewAppointment";
            btnReviewAppointment.UseVisualStyleBackColor = false;
            btnReviewAppointment.Click += btnReviewAppointment_Click;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.ForeColor = Color.Gray;
            label7.Name = "label7";
            label7.Tag = "1";
            // 
            // cbTime
            // 
            cbTime.DropDownHeight = 200;
            cbTime.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cbTime, "cbTime");
            cbTime.FormattingEnabled = true;
            cbTime.Name = "cbTime";
            cbTime.Tag = "7";
            cbTime.SelectedIndexChanged += cbTime_SelectedIndexChanged;
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.Gray;
            label6.Name = "label6";
            label6.Tag = "1";
            // 
            // dtpDate
            // 
            resources.ApplyResources(dtpDate, "dtpDate");
            dtpDate.MinDate = new DateTime(2024, 7, 9, 0, 0, 0, 0);
            dtpDate.Name = "dtpDate";
            dtpDate.Tag = "6";
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.Gray;
            label5.Name = "label5";
            label5.Tag = "1";
            // 
            // cbDoctor
            // 
            cbDoctor.DropDownHeight = 200;
            cbDoctor.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cbDoctor, "cbDoctor");
            cbDoctor.FormattingEnabled = true;
            cbDoctor.Name = "cbDoctor";
            cbDoctor.Tag = "5";
            cbDoctor.SelectedIndexChanged += cbDoctor_SelectedIndexChanged;
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.Gray;
            label4.Name = "label4";
            label4.Tag = "1";
            // 
            // cbClinic
            // 
            cbClinic.DropDownHeight = 200;
            cbClinic.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cbClinic, "cbClinic");
            cbClinic.FormattingEnabled = true;
            cbClinic.Name = "cbClinic";
            cbClinic.Tag = "4";
            cbClinic.SelectedIndexChanged += cbClinic_SelectedIndexChanged;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.Gray;
            label3.Name = "label3";
            label3.Tag = "1";
            // 
            // cbHospital
            // 
            cbHospital.DropDownHeight = 200;
            cbHospital.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cbHospital, "cbHospital");
            cbHospital.FormattingEnabled = true;
            cbHospital.Name = "cbHospital";
            cbHospital.Tag = "3";
            cbHospital.SelectedIndexChanged += cbHospital_SelectedIndexChanged;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Gray;
            label2.Name = "label2";
            label2.Tag = "1";
            // 
            // cbDistrict
            // 
            cbDistrict.DropDownHeight = 200;
            cbDistrict.DropDownStyle = ComboBoxStyle.DropDownList;
            resources.ApplyResources(cbDistrict, "cbDistrict");
            cbDistrict.FormattingEnabled = true;
            cbDistrict.Name = "cbDistrict";
            cbDistrict.Tag = "2";
            cbDistrict.SelectedIndexChanged += cbDistrict_SelectedIndexChanged;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Gray;
            label1.Name = "label1";
            label1.Tag = "1";
            // 
            // cbProvince
            // 
            cbProvince.BackColor = SystemColors.Window;
            cbProvince.DropDownHeight = 200;
            cbProvince.DropDownStyle = ComboBoxStyle.DropDownList;
            cbProvince.ForeColor = SystemColors.WindowText;
            cbProvince.FormattingEnabled = true;
            resources.ApplyResources(cbProvince, "cbProvince");
            cbProvince.Name = "cbProvince";
            cbProvince.Tag = "1";
            cbProvince.SelectedIndexChanged += cbProvince_SelectedIndexChanged;
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
            // frmMakeAppointment
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(btnReviewAppointment);
            Controls.Add(label7);
            Controls.Add(cbTime);
            Controls.Add(label6);
            Controls.Add(dtpDate);
            Controls.Add(label5);
            Controls.Add(cbDoctor);
            Controls.Add(label4);
            Controls.Add(cbClinic);
            Controls.Add(label3);
            Controls.Add(cbHospital);
            Controls.Add(label2);
            Controls.Add(cbDistrict);
            Controls.Add(label1);
            Controls.Add(cbProvince);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMakeAppointment";
            Load += frmMakeAppointment_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReviewAppointment;
        private Label label7;
        private ComboBox cbTime;
        private Label label6;
        private DateTimePicker dtpDate;
        private Label label5;
        public ComboBox cbDoctor;
        private Label label4;
        public ComboBox cbClinic;
        private Label label3;
        public ComboBox cbHospital;
        private Label label2;
        public ComboBox cbDistrict;
        private Label label1;
        public ComboBox cbProvince;
        private Panel panel2;
        private Panel panel1;
        private Panel panel3;
    }
}