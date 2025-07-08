namespace HospitalAutomation
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            txtBlue = new TextBox();
            txtGreen = new TextBox();
            txtRed = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            trackBarRed = new TrackBar();
            trackBarGreen = new TrackBar();
            trackBarBlue = new TrackBar();
            btnSave = new Button();
            btnUser = new Button();
            btnMain = new Button();
            btnDefaultSettings = new Button();
            btnColorMode2 = new Button();
            btnThemeMode = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBarRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).BeginInit();
            SuspendLayout();
            // 
            // txtBlue
            // 
            resources.ApplyResources(txtBlue, "txtBlue");
            txtBlue.Name = "txtBlue";
            txtBlue.TextChanged += txt_TextChanged;
            txtBlue.KeyPress += txt_KeyPress;
            // 
            // txtGreen
            // 
            resources.ApplyResources(txtGreen, "txtGreen");
            txtGreen.Name = "txtGreen";
            txtGreen.TextChanged += txt_TextChanged;
            txtGreen.KeyPress += txt_KeyPress;
            // 
            // txtRed
            // 
            resources.ApplyResources(txtRed, "txtRed");
            txtRed.Name = "txtRed";
            txtRed.TextChanged += txt_TextChanged;
            txtRed.KeyPress += txt_KeyPress;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.Blue;
            label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.Green;
            label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.Red;
            label1.Name = "label1";
            // 
            // trackBarRed
            // 
            resources.ApplyResources(trackBarRed, "trackBarRed");
            trackBarRed.Maximum = 255;
            trackBarRed.Name = "trackBarRed";
            trackBarRed.TabStop = false;
            trackBarRed.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBarGreen
            // 
            resources.ApplyResources(trackBarGreen, "trackBarGreen");
            trackBarGreen.Maximum = 255;
            trackBarGreen.Name = "trackBarGreen";
            trackBarGreen.TabStop = false;
            trackBarGreen.ValueChanged += trackBar_ValueChanged;
            // 
            // trackBarBlue
            // 
            resources.ApplyResources(trackBarBlue, "trackBarBlue");
            trackBarBlue.Maximum = 255;
            trackBarBlue.Name = "trackBarBlue";
            trackBarBlue.TabStop = false;
            trackBarBlue.ValueChanged += trackBar_ValueChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkSlateGray;
            btnSave.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnSave, "btnSave");
            btnSave.ForeColor = Color.White;
            btnSave.Name = "btnSave";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnUser
            // 
            btnUser.BackColor = Color.FromArgb(109, 122, 224);
            btnUser.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnUser, "btnUser");
            btnUser.ForeColor = Color.White;
            btnUser.Name = "btnUser";
            btnUser.UseVisualStyleBackColor = false;
            btnUser.Click += btnUserPanel_Click;
            // 
            // btnMain
            // 
            btnMain.BackColor = Color.FromArgb(109, 122, 224);
            btnMain.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnMain, "btnMain");
            btnMain.ForeColor = Color.White;
            btnMain.Name = "btnMain";
            btnMain.UseVisualStyleBackColor = false;
            btnMain.Click += btnMainColor_Click;
            // 
            // btnDefaultSettings
            // 
            btnDefaultSettings.BackColor = Color.DarkSlateGray;
            btnDefaultSettings.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnDefaultSettings, "btnDefaultSettings");
            btnDefaultSettings.ForeColor = Color.White;
            btnDefaultSettings.Name = "btnDefaultSettings";
            btnDefaultSettings.UseVisualStyleBackColor = false;
            btnDefaultSettings.Click += btnDefaultSettings_Click;
            // 
            // btnColorMode2
            // 
            btnColorMode2.FlatAppearance.BorderSize = 0;
            btnColorMode2.FlatAppearance.MouseDownBackColor = Color.White;
            btnColorMode2.FlatAppearance.MouseOverBackColor = Color.White;
            resources.ApplyResources(btnColorMode2, "btnColorMode2");
            btnColorMode2.Image = Properties.Resources.toggleOff;
            btnColorMode2.Name = "btnColorMode2";
            btnColorMode2.Tag = "off";
            btnColorMode2.UseVisualStyleBackColor = true;
            btnColorMode2.Click += btnColor_Click;
            // 
            // btnThemeMode
            // 
            btnThemeMode.FlatAppearance.BorderSize = 0;
            btnThemeMode.FlatAppearance.MouseDownBackColor = Color.White;
            btnThemeMode.FlatAppearance.MouseOverBackColor = Color.White;
            resources.ApplyResources(btnThemeMode, "btnThemeMode");
            btnThemeMode.Image = Properties.Resources.moon;
            btnThemeMode.Name = "btnThemeMode";
            btnThemeMode.Tag = "ligth";
            btnThemeMode.UseVisualStyleBackColor = true;
            btnThemeMode.Click += btnThemeMode_Click;
            // 
            // frmSettings
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnThemeMode);
            Controls.Add(btnColorMode2);
            Controls.Add(btnDefaultSettings);
            Controls.Add(btnUser);
            Controls.Add(btnMain);
            Controls.Add(btnSave);
            Controls.Add(txtBlue);
            Controls.Add(txtGreen);
            Controls.Add(txtRed);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBarRed);
            Controls.Add(trackBarGreen);
            Controls.Add(trackBarBlue);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSettings";
            FormClosing += frmSettings_FormClosing;
            Load += frmSettings_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBlue;
        private TextBox txtGreen;
        private TextBox txtRed;
        private Label label3;
        private Label label2;
        private Label label1;
        private TrackBar trackBarRed;
        private TrackBar trackBarGreen;
        private TrackBar trackBarBlue;
        private Button btnSave;
        private Button btnCanceledAppointment;
        private Button btnUser;
        public Button btnMain;
        private Button btnDefaultSettings;
        private PictureBox pictureBox1;
        private Button btnColorMode2;
        private Button btnThemeMode;
    }
}