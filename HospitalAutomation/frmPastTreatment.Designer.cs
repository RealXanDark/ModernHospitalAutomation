namespace HospitalAutomation
{
    partial class frmPastTreatment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPastTreatment));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtIdentityNumber = new TextBox();
            btnSearch = new Button();
            lblInfo = new Label();
            dgwAppointment = new DataGridView();
            ResultId = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            AppointmentId = new DataGridViewTextBoxColumn();
            TestId = new DataGridViewTextBoxColumn();
            TestName2 = new DataGridViewTextBoxColumn();
            DoctorId = new DataGridViewTextBoxColumn();
            PatientId = new DataGridViewTextBoxColumn();
            Notes = new DataGridViewTextBoxColumn();
            DoctorControl = new DataGridViewTextBoxColumn();
            c = new DataGridViewTextBoxColumn();
            Appointment = new DataGridViewTextBoxColumn();
            Doctor = new DataGridViewTextBoxColumn();
            Patient = new DataGridViewTextBoxColumn();
            Test = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgwAppointment).BeginInit();
            SuspendLayout();
            // 
            // txtIdentityNumber
            // 
            resources.ApplyResources(txtIdentityNumber, "txtIdentityNumber");
            txtIdentityNumber.Name = "txtIdentityNumber";
            txtIdentityNumber.TextChanged += textBox1_TextChanged;
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
            // lblInfo
            // 
            resources.ApplyResources(lblInfo, "lblInfo");
            lblInfo.ForeColor = Color.Brown;
            lblInfo.Name = "lblInfo";
            // 
            // dgwAppointment
            // 
            dgwAppointment.AllowUserToAddRows = false;
            dgwAppointment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgwAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwAppointment.BackgroundColor = Color.White;
            dgwAppointment.BorderStyle = BorderStyle.None;
            dgwAppointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwAppointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(109, 122, 224);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(109, 122, 224);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgwAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(dgwAppointment, "dgwAppointment");
            dgwAppointment.Columns.AddRange(new DataGridViewColumn[] { ResultId, Column1, AppointmentId, TestId, TestName2, DoctorId, PatientId, Notes, DoctorControl, c, Appointment, Doctor, Patient, Test });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(229, 226, 244);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgwAppointment.DefaultCellStyle = dataGridViewCellStyle3;
            dgwAppointment.EnableHeadersVisualStyles = false;
            dgwAppointment.GridColor = Color.WhiteSmoke;
            dgwAppointment.Name = "dgwAppointment";
            dgwAppointment.ReadOnly = true;
            dgwAppointment.RowHeadersVisible = false;
            dgwAppointment.RowTemplate.DividerHeight = 1;
            dgwAppointment.RowTemplate.Height = 35;
            dgwAppointment.RowTemplate.Resizable = DataGridViewTriState.False;
            dgwAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // ResultId
            // 
            ResultId.DataPropertyName = "ResultId";
            resources.ApplyResources(ResultId, "ResultId");
            ResultId.Name = "ResultId";
            ResultId.ReadOnly = true;
            // 
            // Column1
            // 
            resources.ApplyResources(Column1, "Column1");
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // AppointmentId
            // 
            AppointmentId.DataPropertyName = "AppointmentId";
            resources.ApplyResources(AppointmentId, "AppointmentId");
            AppointmentId.Name = "AppointmentId";
            AppointmentId.ReadOnly = true;
            // 
            // TestId
            // 
            TestId.DataPropertyName = "TestId";
            resources.ApplyResources(TestId, "TestId");
            TestId.Name = "TestId";
            TestId.ReadOnly = true;
            // 
            // TestName2
            // 
            resources.ApplyResources(TestName2, "TestName2");
            TestName2.Name = "TestName2";
            TestName2.ReadOnly = true;
            // 
            // DoctorId
            // 
            DoctorId.DataPropertyName = "DoctorId";
            resources.ApplyResources(DoctorId, "DoctorId");
            DoctorId.Name = "DoctorId";
            DoctorId.ReadOnly = true;
            // 
            // PatientId
            // 
            PatientId.DataPropertyName = "PatientId";
            resources.ApplyResources(PatientId, "PatientId");
            PatientId.Name = "PatientId";
            PatientId.ReadOnly = true;
            // 
            // Notes
            // 
            Notes.DataPropertyName = "Notes";
            resources.ApplyResources(Notes, "Notes");
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            // 
            // DoctorControl
            // 
            DoctorControl.DataPropertyName = "DoctorControl";
            resources.ApplyResources(DoctorControl, "DoctorControl");
            DoctorControl.Name = "DoctorControl";
            DoctorControl.ReadOnly = true;
            // 
            // c
            // 
            c.DataPropertyName = "Patient.PatientFirstName";
            resources.ApplyResources(c, "c");
            c.Name = "c";
            c.ReadOnly = true;
            // 
            // Appointment
            // 
            Appointment.DataPropertyName = "Appointment";
            resources.ApplyResources(Appointment, "Appointment");
            Appointment.Name = "Appointment";
            Appointment.ReadOnly = true;
            // 
            // Doctor
            // 
            Doctor.DataPropertyName = "Doctor";
            resources.ApplyResources(Doctor, "Doctor");
            Doctor.Name = "Doctor";
            Doctor.ReadOnly = true;
            // 
            // Patient
            // 
            Patient.DataPropertyName = "Patient";
            resources.ApplyResources(Patient, "Patient");
            Patient.Name = "Patient";
            Patient.ReadOnly = true;
            // 
            // Test
            // 
            Test.DataPropertyName = "Test";
            resources.ApplyResources(Test, "Test");
            Test.Name = "Test";
            Test.ReadOnly = true;
            // 
            // frmPastTreatment
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgwAppointment);
            Controls.Add(lblInfo);
            Controls.Add(btnSearch);
            Controls.Add(txtIdentityNumber);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPastTreatment";
            ((System.ComponentModel.ISupportInitialize)dgwAppointment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdentityNumber;
        private Button btnSearch;
        private Label lblInfo;
        private DataGridView dgwAppointment;
        private DataGridViewTextBoxColumn ResultId;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn AppointmentId;
        private DataGridViewTextBoxColumn TestId;
        private DataGridViewTextBoxColumn TestName2;
        private DataGridViewTextBoxColumn DoctorId;
        private DataGridViewTextBoxColumn PatientId;
        private DataGridViewTextBoxColumn Notes;
        private DataGridViewTextBoxColumn DoctorControl;
        private DataGridViewTextBoxColumn c;
        private DataGridViewTextBoxColumn Appointment;
        private DataGridViewTextBoxColumn Doctor;
        private DataGridViewTextBoxColumn Patient;
        private DataGridViewTextBoxColumn Test;
    }
}