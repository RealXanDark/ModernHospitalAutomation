using HospitalAutomation.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.CustomControls
{
    public partial class AppointmentCard : UserControl
    {
        public AppointmentCard()
        {
            InitializeComponent();
            IsDarkMode = Properties.Settings.Default.isDarkMode;
            if (IsDarkMode)
            {
                this.BackColor = Color.FromArgb(50, 50, 50);
                lblAppointmentDate.ForeColor = Color.LightSkyBlue;
                lblHospital.ForeColor = Color.White;
                lblClinic.ForeColor = Color.White;
                lblDoctor.ForeColor = Color.White;
                lblAppointmentOwner.ForeColor = Color.Cyan;
                lblAppointmentStatus.ForeColor = Color.LimeGreen;
            }
        }
        #region Properties
        private string? _date;
        private string? _hospital;
        private string? _clinic;
        private string? _doctor;
        private string? _owner;
        private string? _status;
        private int _appointmentId;
        private Color _color;
        private bool _isButtonVisible;
        private bool _isDarkMode;

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçili Randevuyu İptal Etmek İstediğinize Emin Misiniz?", "Randevu İptali", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var appointment = ctx.TblAppointments.SingleOrDefault(a => a.AppointmentId == _appointmentId);
                    if (appointment != null)
                    {
                        appointment.StatusId = 3;
                        ctx.SaveChanges();
                        var parentPanel = this.Parent as FlowLayoutPanel;
                        if (parentPanel != null)
                        {
                            parentPanel.Controls.Remove(this);
                        }
                    }

                }
            }
        }

        private void lblCancelAppointment_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçili Randevuyu İptal Etmek İstediğinize Emin Misiniz?", "Randevu İptali", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var appointment = ctx.TblAppointments.SingleOrDefault(a => a.AppointmentId == _appointmentId);
                    var patient = ctx.TblPatients.SingleOrDefault(p => p.PatientId == Global.user_id);
                    var user = ctx.TblUsers.SingleOrDefault(u => u.IdentityNumberId == patient!.IdentityNumberId);
                    if (appointment != null)
                    {
                        appointment.StatusId = 3;
                        appointment.UpdatedAt = DateTime.Now;
                        appointment.UpdatedBy = user!.UserId;
                        ctx.SaveChanges();
                        var parentPanel = this.Parent as FlowLayoutPanel;
                        if (parentPanel != null)
                        {
                            parentPanel.Controls.Remove(this);
                        }
                    }

                }
            }
        }

        private void AppointmentCard_Load(object sender, EventArgs e)
        {
            //foreach (Control ctrl in this.Controls)
            //{
            //    ctrl.Font = new Font(Properties.Settings.Default.textFont.FontFamily,ctrl.Font.Size,ctrl.Font.Style);
            //}           
        }

        [Category("Custom Props")]
        public string Date
        {
            get { return _date!; }
            set { _date = value; lblAppointmentDate.Text = value; }
        }
        [Category("Custom Props")]
        public string Hospital
        {
            get { return _hospital!; }
            set { _hospital = value; lblHospital.Text = value; }
        }
        [Category("Custom Props")]
        public string Clinic
        {
            get { return _clinic!; }
            set { _clinic = value; lblClinic.Text = value; }
        }
        [Category("Custom Props")]
        public string Doctor
        {
            get { return _doctor!; }
            set { _doctor = value; lblDoctor.Text = value; }
        }
        [Category("Custom Props")]
        public string Owner
        {
            get { return _owner!; }
            set { _owner = value; lblAppointmentOwner.Text = value; }
        }
        [Category("Custom Props")]
        public string Status
        {
            get { return _status!; }
            set { _status = value; lblAppointmentStatus.Text = value; }
        }
        [Category("Custom Props")]
        public Color StatusColor
        {
            get { return _color; }
            set { _color = value; lblAppointmentStatus.ForeColor = _color; }
        }
        [Category("Custom Props")]
        public int AppointmentId
        {
            get { return _appointmentId; }
            set { _appointmentId = value; }
        }
        [Category("Custom Props")]
        public bool IsButtonVisible
        {
            get { return _isButtonVisible; }
            set
            {
                _isButtonVisible = value;
                lblCancelAppointment.Visible = value; // Butonun görünürlüğünü ayarla
            }
        }
        [Category("Custom Props")]
        public bool IsDarkMode
        {
            get { return _isDarkMode; }
            set { _isDarkMode = value; }
        }
        #endregion
    }
}
