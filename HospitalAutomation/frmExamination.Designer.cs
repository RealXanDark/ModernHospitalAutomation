namespace HospitalAutomation
{
    partial class frmExamination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExamination));
            pnlLayout = new Panel();
            label1 = new Label();
            btnExit = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label16 = new Label();
            btnAddMedicine = new Button();
            label14 = new Label();
            cbMedicine = new ComboBox();
            label12 = new Label();
            lbPrescription = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            chbHasAttented = new CheckBox();
            txtNotes = new TextBox();
            label13 = new Label();
            cbAlergies = new ComboBox();
            label15 = new Label();
            lbAlergies = new ListBox();
            label11 = new Label();
            cbChronicDisease = new ComboBox();
            label9 = new Label();
            lbChronicDisease = new ListBox();
            btnEndExamination = new Button();
            txtDiagnosis = new TextBox();
            label7 = new Label();
            lbTest = new ListBox();
            cbTests = new ComboBox();
            label6 = new Label();
            btnViewResults = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label17 = new Label();
            label18 = new Label();
            lblBloodGroup = new Label();
            lblDateOfBirth = new Label();
            lblIdentityNumber = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label10 = new Label();
            lblGender = new Label();
            nupMedicationQuantity = new NumericUpDown();
            pboxRefreshChronicDisease = new PictureBox();
            pboxRefreshAlergies = new PictureBox();
            btnAddDisease = new Button();
            btnAddAllergy = new Button();
            lbAlert = new ListBox();
            btnAddTest = new Button();
            pnlLayout.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupMedicationQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxRefreshChronicDisease).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pboxRefreshAlergies).BeginInit();
            SuspendLayout();
            // 
            // pnlLayout
            // 
            pnlLayout.BackColor = Color.FromArgb(43, 43, 43);
            pnlLayout.Controls.Add(label1);
            pnlLayout.Controls.Add(btnExit);
            resources.ApplyResources(pnlLayout, "pnlLayout");
            pnlLayout.Name = "pnlLayout";
            pnlLayout.MouseDown += pnlLayout_MouseDown;
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.White;
            label1.Name = "label1";
            // 
            // btnExit
            // 
            resources.ApplyResources(btnExit, "btnExit");
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(225, 37, 27);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Name = "btnExit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(43, 43, 43);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            panel1.MouseDown += pnlLayout_MouseDown;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(43, 43, 43);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            panel2.MouseDown += pnlLayout_MouseDown;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(43, 43, 43);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // label16
            // 
            resources.ApplyResources(label16, "label16");
            label16.Name = "label16";
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.BackColor = Color.Brown;
            btnAddMedicine.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnAddMedicine, "btnAddMedicine");
            btnAddMedicine.ForeColor = Color.White;
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.UseVisualStyleBackColor = false;
            btnAddMedicine.Click += btnAddMedicine_Click;
            // 
            // label14
            // 
            resources.ApplyResources(label14, "label14");
            label14.Name = "label14";
            // 
            // cbMedicine
            // 
            cbMedicine.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMedicine.FormattingEnabled = true;
            resources.ApplyResources(cbMedicine, "cbMedicine");
            cbMedicine.Name = "cbMedicine";
            // 
            // label12
            // 
            resources.ApplyResources(label12, "label12");
            label12.Name = "label12";
            // 
            // lbPrescription
            // 
            lbPrescription.ContextMenuStrip = contextMenuStrip1;
            lbPrescription.FormattingEnabled = true;
            resources.ApplyResources(lbPrescription, "lbPrescription");
            lbPrescription.Name = "lbPrescription";
            lbPrescription.MouseDoubleClick += lbPrescription_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(contextMenuStrip1, "contextMenuStrip1");
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            resources.ApplyResources(silToolStripMenuItem, "silToolStripMenuItem");
            // 
            // chbHasAttented
            // 
            resources.ApplyResources(chbHasAttented, "chbHasAttented");
            chbHasAttented.ForeColor = Color.Brown;
            chbHasAttented.Name = "chbHasAttented";
            chbHasAttented.UseVisualStyleBackColor = true;
            chbHasAttented.CheckedChanged += chbHasAttented_CheckedChanged;
            // 
            // txtNotes
            // 
            resources.ApplyResources(txtNotes, "txtNotes");
            txtNotes.Name = "txtNotes";
            txtNotes.Enter += txtNotes_Enter;
            txtNotes.Leave += txtNotes_Leave;
            // 
            // label13
            // 
            resources.ApplyResources(label13, "label13");
            label13.Name = "label13";
            // 
            // cbAlergies
            // 
            cbAlergies.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAlergies.FormattingEnabled = true;
            cbAlergies.Items.AddRange(new object[] { resources.GetString("cbAlergies.Items"), resources.GetString("cbAlergies.Items1"), resources.GetString("cbAlergies.Items2"), resources.GetString("cbAlergies.Items3"), resources.GetString("cbAlergies.Items4"), resources.GetString("cbAlergies.Items5"), resources.GetString("cbAlergies.Items6"), resources.GetString("cbAlergies.Items7"), resources.GetString("cbAlergies.Items8"), resources.GetString("cbAlergies.Items9"), resources.GetString("cbAlergies.Items10"), resources.GetString("cbAlergies.Items11"), resources.GetString("cbAlergies.Items12"), resources.GetString("cbAlergies.Items13"), resources.GetString("cbAlergies.Items14"), resources.GetString("cbAlergies.Items15"), resources.GetString("cbAlergies.Items16"), resources.GetString("cbAlergies.Items17"), resources.GetString("cbAlergies.Items18"), resources.GetString("cbAlergies.Items19"), resources.GetString("cbAlergies.Items20"), resources.GetString("cbAlergies.Items21"), resources.GetString("cbAlergies.Items22"), resources.GetString("cbAlergies.Items23"), resources.GetString("cbAlergies.Items24"), resources.GetString("cbAlergies.Items25"), resources.GetString("cbAlergies.Items26"), resources.GetString("cbAlergies.Items27"), resources.GetString("cbAlergies.Items28"), resources.GetString("cbAlergies.Items29"), resources.GetString("cbAlergies.Items30"), resources.GetString("cbAlergies.Items31"), resources.GetString("cbAlergies.Items32") });
            resources.ApplyResources(cbAlergies, "cbAlergies");
            cbAlergies.Name = "cbAlergies";
            // 
            // label15
            // 
            resources.ApplyResources(label15, "label15");
            label15.Name = "label15";
            // 
            // lbAlergies
            // 
            lbAlergies.ContextMenuStrip = contextMenuStrip1;
            lbAlergies.FormattingEnabled = true;
            resources.ApplyResources(lbAlergies, "lbAlergies");
            lbAlergies.Name = "lbAlergies";
            lbAlergies.MouseDoubleClick += lbAlergies_MouseDoubleClick;
            // 
            // label11
            // 
            resources.ApplyResources(label11, "label11");
            label11.Name = "label11";
            // 
            // cbChronicDisease
            // 
            cbChronicDisease.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChronicDisease.FormattingEnabled = true;
            cbChronicDisease.Items.AddRange(new object[] { resources.GetString("cbChronicDisease.Items"), resources.GetString("cbChronicDisease.Items1"), resources.GetString("cbChronicDisease.Items2"), resources.GetString("cbChronicDisease.Items3"), resources.GetString("cbChronicDisease.Items4"), resources.GetString("cbChronicDisease.Items5"), resources.GetString("cbChronicDisease.Items6"), resources.GetString("cbChronicDisease.Items7"), resources.GetString("cbChronicDisease.Items8"), resources.GetString("cbChronicDisease.Items9"), resources.GetString("cbChronicDisease.Items10"), resources.GetString("cbChronicDisease.Items11"), resources.GetString("cbChronicDisease.Items12"), resources.GetString("cbChronicDisease.Items13"), resources.GetString("cbChronicDisease.Items14"), resources.GetString("cbChronicDisease.Items15"), resources.GetString("cbChronicDisease.Items16"), resources.GetString("cbChronicDisease.Items17"), resources.GetString("cbChronicDisease.Items18"), resources.GetString("cbChronicDisease.Items19"), resources.GetString("cbChronicDisease.Items20"), resources.GetString("cbChronicDisease.Items21"), resources.GetString("cbChronicDisease.Items22"), resources.GetString("cbChronicDisease.Items23"), resources.GetString("cbChronicDisease.Items24"), resources.GetString("cbChronicDisease.Items25"), resources.GetString("cbChronicDisease.Items26"), resources.GetString("cbChronicDisease.Items27"), resources.GetString("cbChronicDisease.Items28"), resources.GetString("cbChronicDisease.Items29"), resources.GetString("cbChronicDisease.Items30"), resources.GetString("cbChronicDisease.Items31"), resources.GetString("cbChronicDisease.Items32") });
            resources.ApplyResources(cbChronicDisease, "cbChronicDisease");
            cbChronicDisease.Name = "cbChronicDisease";
            // 
            // label9
            // 
            resources.ApplyResources(label9, "label9");
            label9.Name = "label9";
            // 
            // lbChronicDisease
            // 
            lbChronicDisease.ContextMenuStrip = contextMenuStrip1;
            lbChronicDisease.FormattingEnabled = true;
            resources.ApplyResources(lbChronicDisease, "lbChronicDisease");
            lbChronicDisease.Name = "lbChronicDisease";
            lbChronicDisease.MouseDoubleClick += lbChronicDisease_MouseDoubleClick;
            // 
            // btnEndExamination
            // 
            btnEndExamination.BackColor = Color.Brown;
            btnEndExamination.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnEndExamination, "btnEndExamination");
            btnEndExamination.ForeColor = Color.White;
            btnEndExamination.Name = "btnEndExamination";
            btnEndExamination.UseVisualStyleBackColor = false;
            btnEndExamination.Click += btnEndExamination_Click;
            // 
            // txtDiagnosis
            // 
            resources.ApplyResources(txtDiagnosis, "txtDiagnosis");
            txtDiagnosis.Name = "txtDiagnosis";
            txtDiagnosis.Enter += txtDiagnosis_Enter;
            txtDiagnosis.Leave += txtDiagnosis_Leave;
            // 
            // label7
            // 
            resources.ApplyResources(label7, "label7");
            label7.Name = "label7";
            // 
            // lbTest
            // 
            lbTest.ContextMenuStrip = contextMenuStrip1;
            lbTest.FormattingEnabled = true;
            resources.ApplyResources(lbTest, "lbTest");
            lbTest.Name = "lbTest";
            lbTest.MouseDoubleClick += lbTest_MouseDoubleClick;
            // 
            // cbTests
            // 
            cbTests.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTests.FormattingEnabled = true;
            resources.ApplyResources(cbTests, "cbTests");
            cbTests.Name = "cbTests";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
            // 
            // btnViewResults
            // 
            btnViewResults.BackColor = Color.DarkSlateGray;
            btnViewResults.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnViewResults, "btnViewResults");
            btnViewResults.ForeColor = Color.White;
            btnViewResults.Name = "btnViewResults";
            btnViewResults.UseVisualStyleBackColor = false;
            btnViewResults.Click += btnViewResults_Click;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel1.Controls.Add(label17, 1, 7);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // label17
            // 
            resources.ApplyResources(label17, "label17");
            label17.Name = "label17";
            // 
            // label18
            // 
            resources.ApplyResources(label18, "label18");
            label18.Name = "label18";
            // 
            // lblBloodGroup
            // 
            resources.ApplyResources(lblBloodGroup, "lblBloodGroup");
            lblBloodGroup.Name = "lblBloodGroup";
            // 
            // lblDateOfBirth
            // 
            resources.ApplyResources(lblDateOfBirth, "lblDateOfBirth");
            lblDateOfBirth.Name = "lblDateOfBirth";
            // 
            // lblIdentityNumber
            // 
            resources.ApplyResources(lblIdentityNumber, "lblIdentityNumber");
            lblIdentityNumber.Name = "lblIdentityNumber";
            // 
            // lblLastName
            // 
            resources.ApplyResources(lblLastName, "lblLastName");
            lblLastName.Name = "lblLastName";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(lblFirstName, "lblFirstName");
            lblFirstName.Name = "lblFirstName";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label8
            // 
            resources.ApplyResources(label8, "label8");
            label8.Name = "label8";
            // 
            // label10
            // 
            resources.ApplyResources(label10, "label10");
            label10.Name = "label10";
            // 
            // lblGender
            // 
            resources.ApplyResources(lblGender, "lblGender");
            lblGender.Name = "lblGender";
            // 
            // nupMedicationQuantity
            // 
            resources.ApplyResources(nupMedicationQuantity, "nupMedicationQuantity");
            nupMedicationQuantity.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            nupMedicationQuantity.Name = "nupMedicationQuantity";
            nupMedicationQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // pboxRefreshChronicDisease
            // 
            resources.ApplyResources(pboxRefreshChronicDisease, "pboxRefreshChronicDisease");
            pboxRefreshChronicDisease.Name = "pboxRefreshChronicDisease";
            pboxRefreshChronicDisease.TabStop = false;
            pboxRefreshChronicDisease.Click += pboxRefreshChronicDisease_Click;
            // 
            // pboxRefreshAlergies
            // 
            resources.ApplyResources(pboxRefreshAlergies, "pboxRefreshAlergies");
            pboxRefreshAlergies.Name = "pboxRefreshAlergies";
            pboxRefreshAlergies.TabStop = false;
            pboxRefreshAlergies.Click += pboxRefreshAlergies_Click;
            // 
            // btnAddDisease
            // 
            btnAddDisease.BackColor = Color.Brown;
            btnAddDisease.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnAddDisease, "btnAddDisease");
            btnAddDisease.ForeColor = Color.White;
            btnAddDisease.Name = "btnAddDisease";
            btnAddDisease.UseVisualStyleBackColor = false;
            btnAddDisease.Click += btnAddDisease_Click;
            // 
            // btnAddAllergy
            // 
            btnAddAllergy.BackColor = Color.Brown;
            btnAddAllergy.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnAddAllergy, "btnAddAllergy");
            btnAddAllergy.ForeColor = Color.White;
            btnAddAllergy.Name = "btnAddAllergy";
            btnAddAllergy.UseVisualStyleBackColor = false;
            btnAddAllergy.Click += btnAddAllergy_Click;
            // 
            // lbAlert
            // 
            lbAlert.BackColor = Color.White;
            lbAlert.BorderStyle = BorderStyle.None;
            lbAlert.ContextMenuStrip = contextMenuStrip1;
            resources.ApplyResources(lbAlert, "lbAlert");
            lbAlert.ForeColor = Color.Brown;
            lbAlert.FormattingEnabled = true;
            lbAlert.Name = "lbAlert";
            // 
            // btnAddTest
            // 
            btnAddTest.BackColor = Color.Brown;
            btnAddTest.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnAddTest, "btnAddTest");
            btnAddTest.ForeColor = Color.White;
            btnAddTest.Name = "btnAddTest";
            btnAddTest.UseVisualStyleBackColor = false;
            btnAddTest.Click += btnAddTest_Click;
            // 
            // frmExamination
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnAddTest);
            Controls.Add(lbAlert);
            Controls.Add(btnAddAllergy);
            Controls.Add(btnAddDisease);
            Controls.Add(pboxRefreshAlergies);
            Controls.Add(pboxRefreshChronicDisease);
            Controls.Add(nupMedicationQuantity);
            Controls.Add(lblBloodGroup);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblIdentityNumber);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(lblGender);
            Controls.Add(label16);
            Controls.Add(btnAddMedicine);
            Controls.Add(label14);
            Controls.Add(cbMedicine);
            Controls.Add(label12);
            Controls.Add(lbPrescription);
            Controls.Add(chbHasAttented);
            Controls.Add(txtNotes);
            Controls.Add(label13);
            Controls.Add(cbAlergies);
            Controls.Add(label15);
            Controls.Add(lbAlergies);
            Controls.Add(label11);
            Controls.Add(cbChronicDisease);
            Controls.Add(label9);
            Controls.Add(lbChronicDisease);
            Controls.Add(btnEndExamination);
            Controls.Add(txtDiagnosis);
            Controls.Add(label7);
            Controls.Add(lbTest);
            Controls.Add(cbTests);
            Controls.Add(label6);
            Controls.Add(btnViewResults);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlLayout);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmExamination";
            Load += frmExamination_Load;
            MouseDown += pnlLayout_MouseDown;
            pnlLayout.ResumeLayout(false);
            pnlLayout.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupMedicationQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxRefreshChronicDisease).EndInit();
            ((System.ComponentModel.ISupportInitialize)pboxRefreshAlergies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel pnlLayout;
        private Label label1;
        private Button btnExit;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label16;
        private Button btnAddMedicine;
        private Label label14;
        private ComboBox cbMedicine;
        private Label label12;
        private ListBox lbPrescription;
        private CheckBox chbHasAttented;
        private TextBox txtNotes;
        private Label label13;
        private ComboBox cbAlergies;
        private Label label15;
        private ListBox lbAlergies;
        private Label label11;
        private ComboBox cbChronicDisease;
        private Label label9;
        private ListBox lbChronicDisease;
        private Button btnEndExamination;
        private TextBox txtDiagnosis;
        private Label label7;
        private ListBox lbTest;
        private ComboBox cbTests;
        private Label label6;
        private Button btnViewResults;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label17;
        private Label label18;
        private Label lblBloodGroup;
        private Label lblDateOfBirth;
        private Label lblIdentityNumber;
        private Label lblLastName;
        private Label lblFirstName;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label8;
        private Label label10;
        private Label lblGender;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem silToolStripMenuItem;
        private NumericUpDown nupMedicationQuantity;
        private PictureBox pboxRefreshChronicDisease;
        private PictureBox pboxRefreshAlergies;
        private Button btnAddDisease;
        private Button btnAddAllergy;
        private ListBox lbAlert;
        private Button btnAddTest;
    }
}