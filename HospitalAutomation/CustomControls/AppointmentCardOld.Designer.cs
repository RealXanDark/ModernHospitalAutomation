namespace HospitalAutomation.CustomControls
{
    partial class AppointmentCardOld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentCardOld));
            tableLayoutPanel1 = new TableLayoutPanel();
            label8 = new Label();
            lblAppointmentStatus = new Label();
            label12 = new Label();
            lblAppointmentOwner = new Label();
            label7 = new Label();
            lblAppointmenDate = new Label();
            label9 = new Label();
            lblHospital = new Label();
            label11 = new Label();
            label10 = new Label();
            lblDoctor = new Label();
            lblClinic = new Label();
            btnCancelAppointment = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.5960264F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.40398F));
            tableLayoutPanel1.Controls.Add(label8, 0, 5);
            tableLayoutPanel1.Controls.Add(lblAppointmentStatus, 1, 5);
            tableLayoutPanel1.Controls.Add(label12, 0, 4);
            tableLayoutPanel1.Controls.Add(lblAppointmentOwner, 1, 4);
            tableLayoutPanel1.Controls.Add(label7, 0, 0);
            tableLayoutPanel1.Controls.Add(lblAppointmenDate, 1, 0);
            tableLayoutPanel1.Controls.Add(label9, 0, 1);
            tableLayoutPanel1.Controls.Add(lblHospital, 1, 1);
            tableLayoutPanel1.Controls.Add(label11, 0, 3);
            tableLayoutPanel1.Controls.Add(label10, 0, 2);
            tableLayoutPanel1.Controls.Add(lblDoctor, 1, 3);
            tableLayoutPanel1.Controls.Add(lblClinic, 1, 2);
            tableLayoutPanel1.ForeColor = SystemColors.ControlText;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(1138, 154);
            tableLayoutPanel1.TabIndex = 51;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label8.Location = new Point(5, 131);
            label8.Name = "label8";
            label8.Size = new Size(44, 16);
            label8.TabIndex = 6;
            label8.Text = "Durum";
            // 
            // lblAppointmentStatus
            // 
            lblAppointmentStatus.Anchor = AnchorStyles.Left;
            lblAppointmentStatus.AutoSize = true;
            lblAppointmentStatus.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblAppointmentStatus.ForeColor = Color.DarkGreen;
            lblAppointmentStatus.Location = new Point(126, 131);
            lblAppointmentStatus.Name = "lblAppointmentStatus";
            lblAppointmentStatus.Size = new Size(32, 16);
            lblAppointmentStatus.TabIndex = 17;
            lblAppointmentStatus.Text = "Aktif";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label12.Location = new Point(5, 105);
            label12.Name = "label12";
            label12.Size = new Size(97, 16);
            label12.TabIndex = 10;
            label12.Text = "Randevu Sahibi";
            // 
            // lblAppointmentOwner
            // 
            lblAppointmentOwner.Anchor = AnchorStyles.Left;
            lblAppointmentOwner.AutoSize = true;
            lblAppointmentOwner.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblAppointmentOwner.ForeColor = Color.DarkCyan;
            lblAppointmentOwner.Location = new Point(126, 105);
            lblAppointmentOwner.Name = "lblAppointmentOwner";
            lblAppointmentOwner.Size = new Size(109, 16);
            lblAppointmentOwner.TabIndex = 15;
            lblAppointmentOwner.Text = "Fahri Cihan Demir";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label7.Location = new Point(5, 5);
            label7.Name = "label7";
            label7.Size = new Size(93, 16);
            label7.TabIndex = 16;
            label7.Text = "Randevu Tarihi";
            // 
            // lblAppointmenDate
            // 
            lblAppointmenDate.Anchor = AnchorStyles.Left;
            lblAppointmenDate.AutoSize = true;
            lblAppointmenDate.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblAppointmenDate.ForeColor = Color.DeepSkyBlue;
            lblAppointmenDate.Location = new Point(126, 5);
            lblAppointmenDate.Name = "lblAppointmenDate";
            lblAppointmenDate.Size = new Size(103, 16);
            lblAppointmenDate.TabIndex = 11;
            lblAppointmenDate.Text = "04.07.2024 16:45";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label9.Location = new Point(5, 30);
            label9.Name = "label9";
            label9.Size = new Size(54, 16);
            label9.TabIndex = 7;
            label9.Text = "Hastane";
            // 
            // lblHospital
            // 
            lblHospital.Anchor = AnchorStyles.Left;
            lblHospital.AutoSize = true;
            lblHospital.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblHospital.ForeColor = Color.Black;
            lblHospital.Location = new Point(126, 30);
            lblHospital.Name = "lblHospital";
            lblHospital.Size = new Size(228, 16);
            lblHospital.TabIndex = 12;
            lblHospital.Text = "Bağcılar Eğitim Ve Araştırma Hastanesi";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label11.Location = new Point(5, 80);
            label11.Name = "label11";
            label11.Size = new Size(45, 16);
            label11.TabIndex = 9;
            label11.Text = "Doktor";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            label10.Location = new Point(5, 55);
            label10.Name = "label10";
            label10.Size = new Size(37, 16);
            label10.TabIndex = 8;
            label10.Text = "Klinik";
            // 
            // lblDoctor
            // 
            lblDoctor.Anchor = AnchorStyles.Left;
            lblDoctor.AutoSize = true;
            lblDoctor.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblDoctor.ForeColor = Color.Black;
            lblDoctor.Location = new Point(126, 80);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(124, 16);
            lblDoctor.TabIndex = 14;
            lblDoctor.Text = "Prof. Dr. Cihan Demir";
            // 
            // lblClinic
            // 
            lblClinic.Anchor = AnchorStyles.Left;
            lblClinic.AutoSize = true;
            lblClinic.Font = new Font("Century Gothic", 9F, FontStyle.Bold);
            lblClinic.ForeColor = Color.Black;
            lblClinic.Location = new Point(126, 55);
            lblClinic.Name = "lblClinic";
            lblClinic.Size = new Size(100, 16);
            lblClinic.TabIndex = 13;
            lblClinic.Text = "Çocuk Cerrahisi";
            // 
            // btnCancelAppointment
            // 
            btnCancelAppointment.BackColor = Color.Transparent;
            btnCancelAppointment.BackgroundImage = (Image)resources.GetObject("btnCancelAppointment.BackgroundImage");
            btnCancelAppointment.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelAppointment.FlatAppearance.BorderColor = Color.White;
            btnCancelAppointment.FlatAppearance.BorderSize = 0;
            btnCancelAppointment.FlatStyle = FlatStyle.Flat;
            btnCancelAppointment.Location = new Point(1144, 46);
            btnCancelAppointment.Margin = new Padding(3, 2, 3, 2);
            btnCancelAppointment.Name = "btnCancelAppointment";
            btnCancelAppointment.Size = new Size(63, 60);
            btnCancelAppointment.TabIndex = 52;
            btnCancelAppointment.Tag = "hide";
            btnCancelAppointment.UseVisualStyleBackColor = false;
            btnCancelAppointment.Click += btnCancelAppointment_Click;
            // 
            // AppointmentCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnCancelAppointment);
            Controls.Add(tableLayoutPanel1);
            ForeColor = SystemColors.ControlText;
            Name = "AppointmentCard";
            Size = new Size(1212, 154);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label lblAppointmentStatus;
        private Label label12;
        private Label lblAppointmentOwner;
        private Label label7;
        private Label lblAppointmenDate;
        private Label label9;
        private Label lblHospital;
        private Label label11;
        private Label label10;
        private Label lblDoctor;
        private Label lblClinic;
        private Button btnCancelAppointment;
    }
}
