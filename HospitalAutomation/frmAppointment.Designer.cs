namespace HospitalAutomation
{
    partial class frmAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointment));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            dgwAppointment = new DataGridView();
            AppointmentId = new DataGridViewTextBoxColumn();
            PatientName = new DataGridViewTextBoxColumn();
            HospitalName = new DataGridViewTextBoxColumn();
            ClinicName = new DataGridViewTextBoxColumn();
            AppointmentDate = new DataGridViewTextBoxColumn();
            AppointmentTime = new DataGridViewTextBoxColumn();
            DoctorName = new DataGridViewTextBoxColumn();
            AppointmentIsActive = new DataGridViewTextBoxColumn();
            Delete = new DataGridViewImageColumn();
            btnActiveAppointment = new Button();
            btnPastAppointment = new Button();
            btnCanceledAppointment = new Button();
            flpAppointment = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgwAppointment).BeginInit();
            SuspendLayout();
            // 
            // dgwAppointment
            // 
            resources.ApplyResources(dgwAppointment, "dgwAppointment");
            dgwAppointment.AllowUserToAddRows = false;
            dgwAppointment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgwAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgwAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwAppointment.BackgroundColor = Color.White;
            dgwAppointment.BorderStyle = BorderStyle.None;
            dgwAppointment.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwAppointment.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(109, 122, 224);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(109, 122, 224);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgwAppointment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgwAppointment.Columns.AddRange(new DataGridViewColumn[] { AppointmentId, PatientName, HospitalName, ClinicName, AppointmentDate, AppointmentTime, DoctorName, AppointmentIsActive, Delete });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(229, 226, 244);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgwAppointment.DefaultCellStyle = dataGridViewCellStyle6;
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
            // AppointmentId
            // 
            AppointmentId.DataPropertyName = "AppointmentId";
            resources.ApplyResources(AppointmentId, "AppointmentId");
            AppointmentId.Name = "AppointmentId";
            AppointmentId.ReadOnly = true;
            // 
            // PatientName
            // 
            PatientName.DataPropertyName = "PatientName";
            resources.ApplyResources(PatientName, "PatientName");
            PatientName.Name = "PatientName";
            PatientName.ReadOnly = true;
            // 
            // HospitalName
            // 
            HospitalName.DataPropertyName = "HospitalName";
            resources.ApplyResources(HospitalName, "HospitalName");
            HospitalName.Name = "HospitalName";
            HospitalName.ReadOnly = true;
            // 
            // ClinicName
            // 
            ClinicName.DataPropertyName = "ClinicName";
            resources.ApplyResources(ClinicName, "ClinicName");
            ClinicName.Name = "ClinicName";
            ClinicName.ReadOnly = true;
            // 
            // AppointmentDate
            // 
            AppointmentDate.DataPropertyName = "AppointmentDate";
            resources.ApplyResources(AppointmentDate, "AppointmentDate");
            AppointmentDate.Name = "AppointmentDate";
            AppointmentDate.ReadOnly = true;
            // 
            // AppointmentTime
            // 
            AppointmentTime.DataPropertyName = "AppointmentTime";
            resources.ApplyResources(AppointmentTime, "AppointmentTime");
            AppointmentTime.Name = "AppointmentTime";
            AppointmentTime.ReadOnly = true;
            // 
            // DoctorName
            // 
            DoctorName.DataPropertyName = "DoctorName";
            resources.ApplyResources(DoctorName, "DoctorName");
            DoctorName.Name = "DoctorName";
            DoctorName.ReadOnly = true;
            // 
            // AppointmentIsActive
            // 
            AppointmentIsActive.DataPropertyName = "AppointmentIsActive";
            resources.ApplyResources(AppointmentIsActive, "AppointmentIsActive");
            AppointmentIsActive.Name = "AppointmentIsActive";
            AppointmentIsActive.ReadOnly = true;
            // 
            // Delete
            // 
            resources.ApplyResources(Delete, "Delete");
            Delete.Image = (Image)resources.GetObject("Delete.Image");
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Resizable = DataGridViewTriState.True;
            // 
            // btnActiveAppointment
            // 
            resources.ApplyResources(btnActiveAppointment, "btnActiveAppointment");
            btnActiveAppointment.BackColor = Color.FromArgb(109, 122, 224);
            btnActiveAppointment.FlatAppearance.BorderSize = 0;
            btnActiveAppointment.ForeColor = Color.White;
            btnActiveAppointment.Name = "btnActiveAppointment";
            btnActiveAppointment.UseVisualStyleBackColor = false;
            btnActiveAppointment.Click += btnActiveAppointment_Click;
            // 
            // btnPastAppointment
            // 
            resources.ApplyResources(btnPastAppointment, "btnPastAppointment");
            btnPastAppointment.BackColor = Color.FromArgb(109, 122, 224);
            btnPastAppointment.FlatAppearance.BorderSize = 0;
            btnPastAppointment.ForeColor = Color.White;
            btnPastAppointment.Name = "btnPastAppointment";
            btnPastAppointment.UseVisualStyleBackColor = false;
            btnPastAppointment.Click += btnPastAppointment_Click;
            // 
            // btnCanceledAppointment
            // 
            resources.ApplyResources(btnCanceledAppointment, "btnCanceledAppointment");
            btnCanceledAppointment.BackColor = Color.FromArgb(109, 122, 224);
            btnCanceledAppointment.FlatAppearance.BorderSize = 0;
            btnCanceledAppointment.ForeColor = Color.White;
            btnCanceledAppointment.Name = "btnCanceledAppointment";
            btnCanceledAppointment.UseVisualStyleBackColor = false;
            btnCanceledAppointment.Click += btnCanceledAppointment_Click;
            // 
            // flpAppointment
            // 
            resources.ApplyResources(flpAppointment, "flpAppointment");
            flpAppointment.Name = "flpAppointment";
            // 
            // frmAppointment
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(flpAppointment);
            Controls.Add(btnCanceledAppointment);
            Controls.Add(btnPastAppointment);
            Controls.Add(btnActiveAppointment);
            Controls.Add(dgwAppointment);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAppointment";
            Load += frmAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)dgwAppointment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwAppointment;
        private Button btnPastAppointment;
        private Button btnCanceledAppointment;
        private DataGridViewTextBoxColumn AppointmentId;
        private DataGridViewTextBoxColumn PatientName;
        private DataGridViewTextBoxColumn HospitalName;
        private DataGridViewTextBoxColumn ClinicName;
        private DataGridViewTextBoxColumn AppointmentDate;
        private DataGridViewTextBoxColumn AppointmentTime;
        private DataGridViewTextBoxColumn DoctorName;
        private DataGridViewTextBoxColumn AppointmentIsActive;
        private DataGridViewImageColumn Delete;
        private FlowLayoutPanel flpAppointment;
        public Button btnActiveAppointment;
    }
}