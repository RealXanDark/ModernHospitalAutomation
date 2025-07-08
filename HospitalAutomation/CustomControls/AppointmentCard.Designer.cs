namespace HospitalAutomation.CustomControls
{
    partial class AppointmentCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentCard));
            lblAppointmentStatus = new Label();
            lblAppointmentOwner = new Label();
            lblAppointmentDate = new Label();
            lblHospital = new Label();
            lblDoctor = new Label();
            lblClinic = new Label();
            btnCancelAppointment = new Button();
            lblCancelAppointment = new Label();
            SuspendLayout();
            // 
            // lblAppointmentStatus
            // 
            lblAppointmentStatus.Anchor = AnchorStyles.Left;
            lblAppointmentStatus.AutoSize = true;
            lblAppointmentStatus.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblAppointmentStatus.ForeColor = Color.DarkGreen;
            lblAppointmentStatus.Location = new Point(3, 132);
            lblAppointmentStatus.Name = "lblAppointmentStatus";
            lblAppointmentStatus.Size = new Size(32, 16);
            lblAppointmentStatus.TabIndex = 23;
            lblAppointmentStatus.Text = "Aktif";
            // 
            // lblAppointmentOwner
            // 
            lblAppointmentOwner.Anchor = AnchorStyles.Left;
            lblAppointmentOwner.AutoSize = true;
            lblAppointmentOwner.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblAppointmentOwner.ForeColor = Color.DarkCyan;
            lblAppointmentOwner.Location = new Point(3, 106);
            lblAppointmentOwner.Name = "lblAppointmentOwner";
            lblAppointmentOwner.Size = new Size(109, 16);
            lblAppointmentOwner.TabIndex = 22;
            lblAppointmentOwner.Text = "Fahri Cihan Demir";
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.Anchor = AnchorStyles.Left;
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblAppointmentDate.ForeColor = Color.DeepSkyBlue;
            lblAppointmentDate.Location = new Point(3, 6);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(103, 16);
            lblAppointmentDate.TabIndex = 18;
            lblAppointmentDate.Text = "04.07.2024 16:45";
            // 
            // lblHospital
            // 
            lblHospital.Anchor = AnchorStyles.Left;
            lblHospital.AutoSize = true;
            lblHospital.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblHospital.ForeColor = Color.Black;
            lblHospital.Location = new Point(3, 31);
            lblHospital.Name = "lblHospital";
            lblHospital.Size = new Size(228, 16);
            lblHospital.TabIndex = 19;
            lblHospital.Text = "Bağcılar Eğitim Ve Araştırma Hastanesi";
            // 
            // lblDoctor
            // 
            lblDoctor.Anchor = AnchorStyles.Left;
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblDoctor.ForeColor = Color.Black;
            lblDoctor.Location = new Point(3, 81);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(124, 16);
            lblDoctor.TabIndex = 21;
            lblDoctor.Text = "Prof. Dr. Cihan Demir";
            // 
            // lblClinic
            // 
            lblClinic.Anchor = AnchorStyles.Left;
            lblClinic.AutoSize = true;
            lblClinic.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblClinic.ForeColor = Color.Black;
            lblClinic.Location = new Point(3, 56);
            lblClinic.Name = "lblClinic";
            lblClinic.Size = new Size(100, 16);
            lblClinic.TabIndex = 20;
            lblClinic.Text = "Çocuk Cerrahisi";
            // 
            // btnCancelAppointment
            // 
            btnCancelAppointment.BackColor = Color.Transparent;
            btnCancelAppointment.BackgroundImage = (Image)resources.GetObject("btnCancelAppointment.BackgroundImage");
            btnCancelAppointment.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelAppointment.FlatAppearance.BorderColor = Color.White;
            btnCancelAppointment.FlatAppearance.BorderSize = 0;
            btnCancelAppointment.FlatAppearance.MouseDownBackColor = Color.GhostWhite;
            btnCancelAppointment.FlatAppearance.MouseOverBackColor = Color.GhostWhite;
            btnCancelAppointment.FlatStyle = FlatStyle.Flat;
            btnCancelAppointment.Location = new Point(1178, 46);
            btnCancelAppointment.Margin = new Padding(3, 2, 3, 2);
            btnCancelAppointment.Name = "btnCancelAppointment";
            btnCancelAppointment.Size = new Size(63, 60);
            btnCancelAppointment.TabIndex = 53;
            btnCancelAppointment.Tag = "hide";
            btnCancelAppointment.UseVisualStyleBackColor = false;
            btnCancelAppointment.Visible = false;
            btnCancelAppointment.Click += btnCancelAppointment_Click;
            // 
            // lblCancelAppointment
            // 
            lblCancelAppointment.Anchor = AnchorStyles.Left;
            lblCancelAppointment.AutoSize = true;
            lblCancelAppointment.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblCancelAppointment.ForeColor = Color.Brown;
            lblCancelAppointment.Location = new Point(1298, 68);
            lblCancelAppointment.Name = "lblCancelAppointment";
            lblCancelAppointment.Size = new Size(45, 16);
            lblCancelAppointment.TabIndex = 54;
            lblCancelAppointment.Text = "İptal Et";
            lblCancelAppointment.Click += lblCancelAppointment_Click;
            // 
            // AppointmentCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(lblCancelAppointment);
            Controls.Add(btnCancelAppointment);
            Controls.Add(lblAppointmentStatus);
            Controls.Add(lblAppointmentOwner);
            Controls.Add(lblAppointmentDate);
            Controls.Add(lblHospital);
            Controls.Add(lblDoctor);
            Controls.Add(lblClinic);
            Name = "AppointmentCard";
            Size = new Size(1370, 154);
            Load += AppointmentCard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppointmentStatus;
        private Label lblAppointmentOwner;
        private Label lblAppointmentDate;
        private Label lblHospital;
        private Label lblDoctor;
        private Label lblClinic;
        private Button btnCancelAppointment;
        private Label lblCancelAppointment;
    }
}
