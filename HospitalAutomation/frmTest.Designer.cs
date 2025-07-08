namespace HospitalAutomation
{
    partial class frmTest
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgwAppointment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dgwAppointment
            // 
            dgwAppointment.AllowUserToAddRows = false;
            dgwAppointment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dgwAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwAppointment.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgwAppointment.BorderStyle = BorderStyle.Fixed3D;
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
            dgwAppointment.ColumnHeadersHeight = 35;
            dgwAppointment.Columns.AddRange(new DataGridViewColumn[] { ResultId, Column1, AppointmentId, TestId, TestName2, DoctorId, PatientId, Notes, DoctorControl, c, Appointment, Doctor, Patient, Test });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(30, 30, 30);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(229, 226, 244);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgwAppointment.DefaultCellStyle = dataGridViewCellStyle3;
            dgwAppointment.EnableHeadersVisualStyles = false;
            dgwAppointment.GridColor = Color.WhiteSmoke;
            dgwAppointment.Location = new Point(1109, 12);
            dgwAppointment.Name = "dgwAppointment";
            dgwAppointment.ReadOnly = true;
            dgwAppointment.RowHeadersVisible = false;
            dgwAppointment.RowTemplate.DividerHeight = 1;
            dgwAppointment.RowTemplate.Height = 35;
            dgwAppointment.RowTemplate.Resizable = DataGridViewTriState.False;
            dgwAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwAppointment.Size = new Size(279, 544);
            dgwAppointment.TabIndex = 252;
            dgwAppointment.CellContentClick += dgwAppointment_CellContentClick;
            dgwAppointment.CellFormatting += dgwAppointment_CellFormatting;
            // 
            // ResultId
            // 
            ResultId.DataPropertyName = "ResultId";
            ResultId.HeaderText = "ResultId";
            ResultId.Name = "ResultId";
            ResultId.ReadOnly = true;
            ResultId.Visible = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            // 
            // AppointmentId
            // 
            AppointmentId.DataPropertyName = "AppointmentId";
            AppointmentId.HeaderText = "AppointmentId";
            AppointmentId.Name = "AppointmentId";
            AppointmentId.ReadOnly = true;
            AppointmentId.Visible = false;
            // 
            // TestId
            // 
            TestId.DataPropertyName = "TestId";
            TestId.HeaderText = "TestId";
            TestId.Name = "TestId";
            TestId.ReadOnly = true;
            TestId.Visible = false;
            // 
            // TestName2
            // 
            TestName2.HeaderText = "Test Adı";
            TestName2.Name = "TestName2";
            TestName2.ReadOnly = true;
            TestName2.Visible = false;
            // 
            // DoctorId
            // 
            DoctorId.DataPropertyName = "DoctorId";
            DoctorId.HeaderText = "DoctorId";
            DoctorId.Name = "DoctorId";
            DoctorId.ReadOnly = true;
            DoctorId.Visible = false;
            // 
            // PatientId
            // 
            PatientId.DataPropertyName = "PatientId";
            PatientId.HeaderText = "PatientId";
            PatientId.Name = "PatientId";
            PatientId.ReadOnly = true;
            PatientId.Visible = false;
            // 
            // Notes
            // 
            Notes.DataPropertyName = "Notes";
            Notes.HeaderText = "Notlar";
            Notes.Name = "Notes";
            Notes.ReadOnly = true;
            Notes.Visible = false;
            // 
            // DoctorControl
            // 
            DoctorControl.DataPropertyName = "DoctorControl";
            DoctorControl.HeaderText = "Durum";
            DoctorControl.Name = "DoctorControl";
            DoctorControl.ReadOnly = true;
            DoctorControl.Visible = false;
            // 
            // c
            // 
            c.DataPropertyName = "Patient.PatientFirstName";
            c.HeaderText = "Tarih";
            c.Name = "c";
            c.ReadOnly = true;
            c.Visible = false;
            // 
            // Appointment
            // 
            Appointment.DataPropertyName = "Appointment";
            Appointment.HeaderText = "Appointment";
            Appointment.Name = "Appointment";
            Appointment.ReadOnly = true;
            Appointment.Visible = false;
            // 
            // Doctor
            // 
            Doctor.DataPropertyName = "Doctor";
            Doctor.HeaderText = "Doctor";
            Doctor.Name = "Doctor";
            Doctor.ReadOnly = true;
            Doctor.Visible = false;
            // 
            // Patient
            // 
            Patient.DataPropertyName = "Patient";
            Patient.HeaderText = "Patient";
            Patient.Name = "Patient";
            Patient.ReadOnly = true;
            Patient.Visible = false;
            // 
            // Test
            // 
            Test.DataPropertyName = "Test";
            Test.HeaderText = "Test";
            Test.Name = "Test";
            Test.ReadOnly = true;
            Test.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(931, 528);
            button1.Name = "button1";
            button1.Size = new Size(172, 42);
            button1.TabIndex = 253;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(1109, 528);
            button2.Name = "button2";
            button2.Size = new Size(172, 42);
            button2.TabIndex = 254;
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(727, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(242, 23);
            textBox1.TabIndex = 255;
            // 
            // button3
            // 
            button3.Location = new Point(1016, 46);
            button3.Name = "button3";
            button3.Size = new Size(176, 37);
            button3.TabIndex = 256;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(823, 614);
            dataGridView1.TabIndex = 257;
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // frmTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1398, 638);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dgwAppointment);
            Name = "frmTest";
            Text = "frmTest";
            Load += frmTest_Load;
            ((System.ComponentModel.ISupportInitialize)dgwAppointment).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
    }
}