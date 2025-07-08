namespace HospitalAutomation.CustomControls
{
    partial class DoctorPastVisitCard
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
            btnPrescription = new Button();
            label5 = new Label();
            label4 = new Label();
            txtNotes = new TextBox();
            txtDiagnosis = new TextBox();
            lblDoctorName = new Label();
            lblClinicName = new Label();
            label11 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblHospitalName = new Label();
            lblDate = new Label();
            lblPatientName = new Label();
            button1 = new Button();
            lbAlergieDisease = new ListBox();
            label7 = new Label();
            lblPatientIdentityNumber = new Label();
            label10 = new Label();
            label3 = new Label();
            lbDisease = new ListBox();
            SuspendLayout();
            // 
            // btnPrescription
            // 
            btnPrescription.BackColor = Color.SandyBrown;
            btnPrescription.FlatAppearance.BorderSize = 0;
            btnPrescription.FlatStyle = FlatStyle.Flat;
            btnPrescription.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnPrescription.ForeColor = Color.White;
            btnPrescription.Location = new Point(341, 133);
            btnPrescription.Margin = new Padding(3, 2, 3, 2);
            btnPrescription.Name = "btnPrescription";
            btnPrescription.Size = new Size(285, 31);
            btnPrescription.TabIndex = 1;
            btnPrescription.Text = "Reçete";
            btnPrescription.UseVisualStyleBackColor = false;
            btnPrescription.Click += btnPrescription_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(632, 10);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 264;
            label5.Text = "Notlar :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 9);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 263;
            label4.Text = "Tanı :";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.GhostWhite;
            txtNotes.Location = new Point(341, 25);
            txtNotes.Margin = new Padding(3, 2, 3, 2);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ReadOnly = true;
            txtNotes.Size = new Size(285, 104);
            txtNotes.TabIndex = 3;
            txtNotes.TabStop = false;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.BackColor = Color.GhostWhite;
            txtDiagnosis.Location = new Point(632, 25);
            txtDiagnosis.Margin = new Padding(3, 2, 3, 2);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.ReadOnly = true;
            txtDiagnosis.Size = new Size(321, 104);
            txtDiagnosis.TabIndex = 4;
            txtDiagnosis.TabStop = false;
            // 
            // lblDoctorName
            // 
            lblDoctorName.AutoSize = true;
            lblDoctorName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDoctorName.Location = new Point(101, 76);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(52, 21);
            lblDoctorName.TabIndex = 253;
            lblDoctorName.Text = "label5";
            // 
            // lblClinicName
            // 
            lblClinicName.AutoSize = true;
            lblClinicName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblClinicName.Location = new Point(64, 55);
            lblClinicName.Name = "lblClinicName";
            lblClinicName.Size = new Size(52, 21);
            lblClinicName.TabIndex = 252;
            lblClinicName.Text = "label4";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(3, 138);
            label11.Name = "label11";
            label11.Size = new Size(73, 21);
            label11.TabIndex = 251;
            label11.Text = "Hasta Tc :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(3, 76);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 250;
            label2.Text = "Doktor Adı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(3, 55);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 249;
            label1.Text = "Klinik :";
            // 
            // lblHospitalName
            // 
            lblHospitalName.AutoSize = true;
            lblHospitalName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblHospitalName.Location = new Point(3, 25);
            lblHospitalName.Name = "lblHospitalName";
            lblHospitalName.Size = new Size(126, 30);
            lblHospitalName.TabIndex = 248;
            lblHospitalName.Text = "Hastane Adı";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F);
            lblDate.ForeColor = Color.Gray;
            lblDate.Location = new Point(3, 4);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(43, 21);
            lblDate.TabIndex = 247;
            lblDate.Text = "Tarih";
            // 
            // lblPatientName
            // 
            lblPatientName.AutoSize = true;
            lblPatientName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPatientName.Location = new Point(101, 117);
            lblPatientName.Name = "lblPatientName";
            lblPatientName.Size = new Size(52, 21);
            lblPatientName.TabIndex = 267;
            lblPatientName.Text = "label4";
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(632, 133);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(321, 31);
            button1.TabIndex = 2;
            button1.Text = "Tahlil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lbAlergieDisease
            // 
            lbAlergieDisease.FormattingEnabled = true;
            lbAlergieDisease.ItemHeight = 15;
            lbAlergieDisease.Location = new Point(958, 25);
            lbAlergieDisease.Name = "lbAlergieDisease";
            lbAlergieDisease.Size = new Size(256, 49);
            lbAlergieDisease.TabIndex = 5;
            lbAlergieDisease.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(958, 7);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 270;
            label7.Text = "Eklenen Alerjiler :";
            // 
            // lblPatientIdentityNumber
            // 
            lblPatientIdentityNumber.AutoSize = true;
            lblPatientIdentityNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPatientIdentityNumber.Location = new Point(101, 138);
            lblPatientIdentityNumber.Name = "lblPatientIdentityNumber";
            lblPatientIdentityNumber.Size = new Size(52, 21);
            lblPatientIdentityNumber.TabIndex = 272;
            lblPatientIdentityNumber.Text = "label4";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(3, 117);
            label10.Name = "label10";
            label10.Size = new Size(83, 21);
            label10.TabIndex = 271;
            label10.Text = "Hasta Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(959, 77);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 274;
            label3.Text = "Eklenen Hastalıklar :";
            // 
            // lbDisease
            // 
            lbDisease.FormattingEnabled = true;
            lbDisease.ItemHeight = 15;
            lbDisease.Location = new Point(959, 95);
            lbDisease.Name = "lbDisease";
            lbDisease.Size = new Size(255, 64);
            lbDisease.TabIndex = 6;
            lbDisease.TabStop = false;
            // 
            // DoctorPastVisitCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(txtDiagnosis);
            Controls.Add(txtNotes);
            Controls.Add(label3);
            Controls.Add(lbDisease);
            Controls.Add(lblPatientIdentityNumber);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(lbAlergieDisease);
            Controls.Add(button1);
            Controls.Add(lblPatientName);
            Controls.Add(btnPrescription);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblDoctorName);
            Controls.Add(lblClinicName);
            Controls.Add(label11);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHospitalName);
            Controls.Add(lblDate);
            Name = "DoctorPastVisitCard";
            Size = new Size(1228, 171);
            Load += DoctorPastVisitCard_Load;
            Click += DoctorPastVisitCard_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPrescription;
        private Label label5;
        private Label label4;
        private TextBox txtNotes;
        private TextBox txtDiagnosis;
        private Label lblDoctorName;
        private Label lblClinicName;
        private Label label11;
        private Label label2;
        private Label label1;
        private Label lblHospitalName;
        private Label lblDate;
        private Label lblPatientName;
        private Button button1;
        private ListBox lbAlergieDisease;
        private Label label7;
        private Label lblPatientIdentityNumber;
        private Label label10;
        private Label label3;
        private ListBox lbDisease;
    }
}
