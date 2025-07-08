namespace HospitalAutomation
{
    partial class frmPrescription
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrescription));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgwPrescription = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            Prescription = new DataGridViewTextBoxColumn();
            pnlLayout = new Panel();
            btnMinimized = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwPrescription).BeginInit();
            pnlLayout.SuspendLayout();
            SuspendLayout();
            // 
            // dgwPrescription
            // 
            dgwPrescription.AllowUserToAddRows = false;
            dgwPrescription.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgwPrescription.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwPrescription.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwPrescription.BackgroundColor = Color.White;
            dgwPrescription.BorderStyle = BorderStyle.None;
            dgwPrescription.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgwPrescription.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(109, 122, 224);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(109, 122, 224);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgwPrescription.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(dgwPrescription, "dgwPrescription");
            dgwPrescription.Columns.AddRange(new DataGridViewColumn[] { Date, quantity, Prescription });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(229, 226, 244);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgwPrescription.DefaultCellStyle = dataGridViewCellStyle3;
            dgwPrescription.EnableHeadersVisualStyles = false;
            dgwPrescription.GridColor = Color.WhiteSmoke;
            dgwPrescription.Name = "dgwPrescription";
            dgwPrescription.ReadOnly = true;
            dgwPrescription.RowHeadersVisible = false;
            dgwPrescription.RowTemplate.DividerHeight = 1;
            dgwPrescription.RowTemplate.Height = 35;
            dgwPrescription.RowTemplate.Resizable = DataGridViewTriState.False;
            dgwPrescription.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            resources.ApplyResources(Date, "Date");
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // quantity
            // 
            quantity.DataPropertyName = "MedicationQuantity";
            resources.ApplyResources(quantity, "quantity");
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            // 
            // Prescription
            // 
            Prescription.DataPropertyName = "MedicationName";
            resources.ApplyResources(Prescription, "Prescription");
            Prescription.Name = "Prescription";
            Prescription.ReadOnly = true;
            // 
            // pnlLayout
            // 
            pnlLayout.BackColor = Color.FromArgb(43, 43, 43);
            pnlLayout.Controls.Add(btnMinimized);
            pnlLayout.Controls.Add(btnExit);
            resources.ApplyResources(pnlLayout, "pnlLayout");
            pnlLayout.Name = "pnlLayout";
            pnlLayout.MouseDown += pnlLayout_MouseDown;
            // 
            // btnMinimized
            // 
            resources.ApplyResources(btnMinimized, "btnMinimized");
            btnMinimized.FlatAppearance.BorderSize = 0;
            btnMinimized.Name = "btnMinimized";
            btnMinimized.UseVisualStyleBackColor = true;
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
            // frmPrescription
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlLayout);
            Controls.Add(dgwPrescription);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrescription";
            Load += frmPrescription_Load;
            ((System.ComponentModel.ISupportInitialize)dgwPrescription).EndInit();
            pnlLayout.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwPrescription;
        public Panel pnlLayout;
        private Button btnMinimized;
        private Button btnExit;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn Prescription;
    }
}