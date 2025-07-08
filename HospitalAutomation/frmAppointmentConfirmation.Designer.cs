namespace HospitalAutomation
{
    partial class frmAppointmentConfirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppointmentConfirmation));
            btnConfirm = new Button();
            btnReturn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label3 = new Label();
            label12 = new Label();
            lblAppointmentOwner = new Label();
            label11 = new Label();
            lblDoctor = new Label();
            label10 = new Label();
            lblClinic = new Label();
            label9 = new Label();
            lblHospital = new Label();
            label8 = new Label();
            lblAppointmentTime = new Label();
            lblAppointmenDate = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.MediumSeaGreen;
            btnConfirm.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnConfirm, "btnConfirm");
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Name = "btnConfirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(225, 37, 27);
            btnReturn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnReturn, "btnReturn");
            btnReturn.ForeColor = Color.White;
            btnReturn.Name = "btnReturn";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label12, 0, 0);
            tableLayoutPanel1.Controls.Add(lblAppointmentOwner, 1, 0);
            tableLayoutPanel1.Controls.Add(label11, 0, 5);
            tableLayoutPanel1.Controls.Add(lblDoctor, 1, 5);
            tableLayoutPanel1.Controls.Add(label10, 0, 4);
            tableLayoutPanel1.Controls.Add(lblClinic, 1, 4);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(lblHospital, 1, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(lblAppointmentTime, 1, 2);
            tableLayoutPanel1.Controls.Add(lblAppointmenDate, 1, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // lblAppointmentOwner
            // 
            resources.ApplyResources(lblAppointmentOwner, "lblAppointmentOwner");
            lblAppointmentOwner.ForeColor = Color.Gray;
            lblAppointmentOwner.Name = "lblAppointmentOwner";
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // lblDoctor
            // 
            resources.ApplyResources(lblDoctor, "lblDoctor");
            lblDoctor.ForeColor = Color.Gray;
            lblDoctor.Name = "lblDoctor";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // lblClinic
            // 
            resources.ApplyResources(lblClinic, "lblClinic");
            lblClinic.ForeColor = Color.Gray;
            lblClinic.Name = "lblClinic";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // lblHospital
            // 
            resources.ApplyResources(lblHospital, "lblHospital");
            lblHospital.ForeColor = Color.Gray;
            lblHospital.Name = "lblHospital";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // lblAppointmentTime
            // 
            resources.ApplyResources(lblAppointmentTime, "lblAppointmentTime");
            lblAppointmentTime.ForeColor = Color.Gray;
            lblAppointmentTime.Name = "lblAppointmentTime";
            // 
            // lblAppointmenDate
            // 
            resources.ApplyResources(lblAppointmenDate, "lblAppointmenDate");
            lblAppointmenDate.ForeColor = Color.Gray;
            lblAppointmenDate.Name = "lblAppointmenDate";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.FromArgb(224, 224, 224);
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // frmAppointmentConfirmation
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnConfirm);
            Controls.Add(btnReturn);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmAppointmentConfirmation";
            Load += frmAppointmentConfirmation_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnConfirm;
        private Button btnReturn;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label lblAppointmenDate;
        private Label lblClinic;
        private Label lblHospital;
        private Label lblAppointmentOwner;
        private Label lblDoctor;
        private Label lblAppointmentTime;
        private Label label3;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
    }
}