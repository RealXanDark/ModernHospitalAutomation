namespace HospitalAutomation.CustomControls
{
    partial class MailCard
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
            lblShortName = new Label();
            lblSender = new Label();
            lblSubject = new Label();
            lblDate = new Label();
            SuspendLayout();
            // 
            // lblShortName
            // 
            lblShortName.AutoSize = true;
            lblShortName.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblShortName.Location = new Point(0, -2);
            lblShortName.Name = "lblShortName";
            lblShortName.Size = new Size(71, 50);
            lblShortName.TabIndex = 0;
            lblShortName.Text = "CD";
            lblShortName.Click += MailCard_Click;
            // 
            // lblSender
            // 
            lblSender.AutoSize = true;
            lblSender.Location = new Point(75, 2);
            lblSender.Name = "lblSender";
            lblSender.Size = new Size(115, 15);
            lblSender.TabIndex = 1;
            lblSender.Text = "fc19053@gmail.com";
            lblSender.Click += MailCard_Click;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(75, 17);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(107, 15);
            lblSubject.TabIndex = 2;
            lblSubject.Text = "Konu : Toplantı Hk.";
            lblSubject.Click += MailCard_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(75, 32);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(38, 15);
            lblDate.TabIndex = 3;
            lblDate.Text = "Tarih :";
            lblDate.Click += MailCard_Click;
            // 
            // MailCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(lblDate);
            Controls.Add(lblSubject);
            Controls.Add(lblSender);
            Controls.Add(lblShortName);
            Name = "MailCard";
            Size = new Size(277, 52);
            Load += MailCard_Load;
            Click += MailCard_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblShortName;
        private Label lblSender;
        private Label lblSubject;
        private Label lblDate;
    }
}
