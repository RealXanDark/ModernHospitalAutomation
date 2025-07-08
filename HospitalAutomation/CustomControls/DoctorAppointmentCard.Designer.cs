namespace HospitalAutomation.CustomControls
{
    partial class DoctorAppointmentCard
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
            lblAppointmentStatus = new Label();
            lblAppointmentOwner = new Label();
            lblAppointmentDate = new Label();
            lblTime = new Label();
            lblIdentityNumber = new Label();
            SuspendLayout();
            // 
            // lblAppointmentStatus
            // 
            lblAppointmentStatus.Anchor = AnchorStyles.Left;
            lblAppointmentStatus.AutoSize = true;
            lblAppointmentStatus.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblAppointmentStatus.ForeColor = Color.DarkGreen;
            lblAppointmentStatus.Location = new Point(1144, 60);
            lblAppointmentStatus.Name = "lblAppointmentStatus";
            lblAppointmentStatus.Size = new Size(84, 16);
            lblAppointmentStatus.TabIndex = 29;
            lblAppointmentStatus.Text = "Hastayı Çağır";
            lblAppointmentStatus.Click += lblAppointmentStatus_Click;
            // 
            // lblAppointmentOwner
            // 
            lblAppointmentOwner.Anchor = AnchorStyles.Left;
            lblAppointmentOwner.AutoSize = true;
            lblAppointmentOwner.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblAppointmentOwner.ForeColor = Color.DarkCyan;
            lblAppointmentOwner.Location = new Point(3, 74);
            lblAppointmentOwner.Name = "lblAppointmentOwner";
            lblAppointmentOwner.Size = new Size(109, 16);
            lblAppointmentOwner.TabIndex = 28;
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
            lblAppointmentDate.Size = new Size(69, 16);
            lblAppointmentDate.TabIndex = 24;
            lblAppointmentDate.Text = "04.07.2024";
            // 
            // lblTime
            // 
            lblTime.Anchor = AnchorStyles.Left;
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblTime.ForeColor = Color.DeepSkyBlue;
            lblTime.Location = new Point(3, 40);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(38, 16);
            lblTime.TabIndex = 25;
            lblTime.Text = "16:45";
            // 
            // lblIdentityNumber
            // 
            lblIdentityNumber.Anchor = AnchorStyles.Left;
            lblIdentityNumber.AutoSize = true;
            lblIdentityNumber.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblIdentityNumber.ForeColor = Color.Brown;
            lblIdentityNumber.Location = new Point(3, 108);
            lblIdentityNumber.Name = "lblIdentityNumber";
            lblIdentityNumber.Size = new Size(84, 16);
            lblIdentityNumber.TabIndex = 27;
            lblIdentityNumber.Text = "55612027648";
            // 
            // DoctorAppointmentCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(lblAppointmentStatus);
            Controls.Add(lblAppointmentOwner);
            Controls.Add(lblAppointmentDate);
            Controls.Add(lblTime);
            Controls.Add(lblIdentityNumber);
            Name = "DoctorAppointmentCard";
            Size = new Size(1235, 134);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppointmentStatus;
        private Label lblAppointmentOwner;
        private Label lblAppointmentDate;
        private Label lblTime;
        private Label lblIdentityNumber;
    }
}
