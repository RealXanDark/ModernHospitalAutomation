namespace HospitalAutomation.CustomControls
{
    partial class TestCard
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgwAppointment = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwAppointment).BeginInit();
            SuspendLayout();
            // 
            // dgwAppointment
            // 
            dgwAppointment.AllowUserToAddRows = false;
            dgwAppointment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgwAppointment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgwAppointment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwAppointment.BackgroundColor = Color.White;
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
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(229, 226, 244);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgwAppointment.DefaultCellStyle = dataGridViewCellStyle3;
            dgwAppointment.EnableHeadersVisualStyles = false;
            dgwAppointment.GridColor = Color.WhiteSmoke;
            dgwAppointment.Location = new Point(3, 3);
            dgwAppointment.Name = "dgwAppointment";
            dgwAppointment.ReadOnly = true;
            dgwAppointment.RowHeadersVisible = false;
            dgwAppointment.RowTemplate.DividerHeight = 1;
            dgwAppointment.RowTemplate.Height = 35;
            dgwAppointment.RowTemplate.Resizable = DataGridViewTriState.False;
            dgwAppointment.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgwAppointment.Size = new Size(1229, 128);
            dgwAppointment.TabIndex = 2;
            dgwAppointment.SizeChanged += dgwAppointment_SizeChanged;
            // 
            // TestCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgwAppointment);
            Name = "TestCard";
            Size = new Size(1235, 134);
            ((System.ComponentModel.ISupportInitialize)dgwAppointment).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwAppointment;
    }
}
