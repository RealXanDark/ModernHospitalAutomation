namespace HospitalAutomation.CustomControls
{
    partial class VisitCard
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
            lblDate = new Label();
            lblHospitalName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblClinicName = new Label();
            lblDoctorName = new Label();
            pbStar1 = new PictureBox();
            pbStar2 = new PictureBox();
            pbStar3 = new PictureBox();
            pbStar4 = new PictureBox();
            pbStar5 = new PictureBox();
            btnRegister = new Button();
            txtEvaluate = new TextBox();
            txtDiagnosis = new TextBox();
            txtNotes = new TextBox();
            label4 = new Label();
            label5 = new Label();
            lblEvaluate = new Label();
            btnPrescription = new Button();
            ((System.ComponentModel.ISupportInitialize)pbStar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbStar5).BeginInit();
            SuspendLayout();
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F);
            lblDate.ForeColor = Color.Gray;
            lblDate.Location = new Point(3, 3);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(43, 21);
            lblDate.TabIndex = 0;
            lblDate.Text = "Tarih";
            // 
            // lblHospitalName
            // 
            lblHospitalName.AutoSize = true;
            lblHospitalName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblHospitalName.Location = new Point(3, 24);
            lblHospitalName.Name = "lblHospitalName";
            lblHospitalName.Size = new Size(126, 30);
            lblHospitalName.TabIndex = 1;
            lblHospitalName.Text = "Hastane Adı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(3, 60);
            label1.Name = "label1";
            label1.Size = new Size(55, 21);
            label1.TabIndex = 2;
            label1.Text = "Klinik :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(3, 91);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 3;
            label2.Text = "Doktor Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(3, 134);
            label3.Name = "label3";
            label3.Size = new Size(121, 21);
            label3.TabIndex = 4;
            label3.Text = "Değerlendirme :";
            // 
            // lblClinicName
            // 
            lblClinicName.AutoSize = true;
            lblClinicName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblClinicName.Location = new Point(64, 60);
            lblClinicName.Name = "lblClinicName";
            lblClinicName.Size = new Size(52, 21);
            lblClinicName.TabIndex = 5;
            lblClinicName.Text = "label4";
            // 
            // lblDoctorName
            // 
            lblDoctorName.AutoSize = true;
            lblDoctorName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblDoctorName.Location = new Point(101, 91);
            lblDoctorName.Name = "lblDoctorName";
            lblDoctorName.Size = new Size(52, 21);
            lblDoctorName.TabIndex = 6;
            lblDoctorName.Text = "label5";
            // 
            // pbStar1
            // 
            pbStar1.Image = Properties.Resources.starGray;
            pbStar1.Location = new Point(130, 115);
            pbStar1.Name = "pbStar1";
            pbStar1.Size = new Size(50, 50);
            pbStar1.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar1.TabIndex = 7;
            pbStar1.TabStop = false;
            pbStar1.Tag = "1";
            pbStar1.Click += pbStar_Click;
            pbStar1.MouseLeave += pbStar5_MouseLeave;
            pbStar1.MouseHover += pbStar5_MouseHover;
            // 
            // pbStar2
            // 
            pbStar2.Image = Properties.Resources.starGray;
            pbStar2.Location = new Point(186, 115);
            pbStar2.Name = "pbStar2";
            pbStar2.Size = new Size(50, 50);
            pbStar2.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar2.TabIndex = 8;
            pbStar2.TabStop = false;
            pbStar2.Tag = "2";
            pbStar2.Click += pbStar_Click;
            pbStar2.MouseLeave += pbStar5_MouseLeave;
            pbStar2.MouseHover += pbStar5_MouseHover;
            // 
            // pbStar3
            // 
            pbStar3.Image = Properties.Resources.starGray;
            pbStar3.Location = new Point(242, 115);
            pbStar3.Name = "pbStar3";
            pbStar3.Size = new Size(50, 50);
            pbStar3.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar3.TabIndex = 9;
            pbStar3.TabStop = false;
            pbStar3.Tag = "3";
            pbStar3.Click += pbStar_Click;
            pbStar3.MouseLeave += pbStar5_MouseLeave;
            pbStar3.MouseHover += pbStar5_MouseHover;
            // 
            // pbStar4
            // 
            pbStar4.Image = Properties.Resources.starGray;
            pbStar4.Location = new Point(298, 115);
            pbStar4.Name = "pbStar4";
            pbStar4.Size = new Size(50, 50);
            pbStar4.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar4.TabIndex = 10;
            pbStar4.TabStop = false;
            pbStar4.Tag = "4";
            pbStar4.Click += pbStar_Click;
            pbStar4.MouseLeave += pbStar5_MouseLeave;
            pbStar4.MouseHover += pbStar5_MouseHover;
            // 
            // pbStar5
            // 
            pbStar5.Image = Properties.Resources.starGray;
            pbStar5.Location = new Point(354, 115);
            pbStar5.Name = "pbStar5";
            pbStar5.Size = new Size(50, 50);
            pbStar5.SizeMode = PictureBoxSizeMode.Zoom;
            pbStar5.TabIndex = 11;
            pbStar5.TabStop = false;
            pbStar5.Tag = "5";
            pbStar5.Click += pbStar_Click;
            pbStar5.MouseLeave += pbStar5_MouseLeave;
            pbStar5.MouseHover += pbStar5_MouseHover;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SandyBrown;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(1248, 134);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(119, 31);
            btnRegister.TabIndex = 38;
            btnRegister.Text = "Değerlendir";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Visible = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtEvaluate
            // 
            txtEvaluate.BackColor = Color.GhostWhite;
            txtEvaluate.Location = new Point(1009, 24);
            txtEvaluate.Margin = new Padding(3, 2, 3, 2);
            txtEvaluate.Multiline = true;
            txtEvaluate.Name = "txtEvaluate";
            txtEvaluate.PlaceholderText = "Neyi Geliştirmeliyiz?";
            txtEvaluate.Size = new Size(358, 106);
            txtEvaluate.TabIndex = 240;
            txtEvaluate.Visible = false;
            // 
            // txtDiagnosis
            // 
            txtDiagnosis.BackColor = Color.GhostWhite;
            txtDiagnosis.Location = new Point(412, 24);
            txtDiagnosis.Margin = new Padding(3, 2, 3, 2);
            txtDiagnosis.Multiline = true;
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.PlaceholderText = "Neyi Geliştirmeliyiz?";
            txtDiagnosis.ReadOnly = true;
            txtDiagnosis.Size = new Size(231, 141);
            txtDiagnosis.TabIndex = 241;
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.GhostWhite;
            txtNotes.Location = new Point(649, 24);
            txtNotes.Margin = new Padding(3, 2, 3, 2);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "Neyi Geliştirmeliyiz?";
            txtNotes.ReadOnly = true;
            txtNotes.Size = new Size(221, 141);
            txtNotes.TabIndex = 242;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 7);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 243;
            label4.Text = "Tanı :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(649, 7);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 244;
            label5.Text = "Notlar :";
            // 
            // lblEvaluate
            // 
            lblEvaluate.AutoSize = true;
            lblEvaluate.Location = new Point(1009, 7);
            lblEvaluate.Name = "lblEvaluate";
            lblEvaluate.Size = new Size(102, 15);
            lblEvaluate.TabIndex = 245;
            lblEvaluate.Text = "Değerlendirmem :";
            // 
            // btnPrescription
            // 
            btnPrescription.BackColor = Color.SandyBrown;
            btnPrescription.FlatStyle = FlatStyle.Flat;
            btnPrescription.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnPrescription.ForeColor = Color.White;
            btnPrescription.Location = new Point(876, 134);
            btnPrescription.Margin = new Padding(3, 2, 3, 2);
            btnPrescription.Name = "btnPrescription";
            btnPrescription.Size = new Size(119, 31);
            btnPrescription.TabIndex = 246;
            btnPrescription.Text = "Reçete";
            btnPrescription.UseVisualStyleBackColor = false;
            btnPrescription.Click += btnPrescription_Click;
            // 
            // VisitCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            Controls.Add(btnPrescription);
            Controls.Add(lblEvaluate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNotes);
            Controls.Add(txtDiagnosis);
            Controls.Add(txtEvaluate);
            Controls.Add(btnRegister);
            Controls.Add(pbStar5);
            Controls.Add(pbStar4);
            Controls.Add(pbStar3);
            Controls.Add(pbStar2);
            Controls.Add(pbStar1);
            Controls.Add(lblDoctorName);
            Controls.Add(lblClinicName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblHospitalName);
            Controls.Add(lblDate);
            Name = "VisitCard";
            Size = new Size(1370, 171);
            Load += VisitCard_Load;
            Click += VisitCard_Click;
            ((System.ComponentModel.ISupportInitialize)pbStar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbStar5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDate;
        private Label lblHospitalName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblClinicName;
        private Label lblDoctorName;
        private PictureBox pbStar1;
        private PictureBox pbStar2;
        private PictureBox pbStar3;
        private PictureBox pbStar4;
        private PictureBox pbStar5;
        private Button btnRegister;
        private TextBox txtEvaluate;
        private TextBox txtDiagnosis;
        private TextBox txtNotes;
        private Label label4;
        private Label label5;
        private Label lblEvaluate;
        private Button btnPrescription;
    }
}
