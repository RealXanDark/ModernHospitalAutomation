using HospitalAutomation.Models;
using System;
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
    public partial class AppointmentCardOld : UserControl
    {
        public AppointmentCardOld()
        {
            InitializeComponent();
        }
        #region Properties
        private string _date;
        private string _hospital;
        private string _clinic;
        private string _doctor;
        private string _owner;
        private string _status;
        private int _appointmentId;
        private Color _color;
        private bool _isButtonVisible;

        private void btnCancelAppointment_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seçili Randevuyu İptal Etmek İstediğinize Emin Misiniz?", "Randevu İptali", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var appointment = ctx.TblAppointments.FirstOrDefault(a => a.AppointmentId == _appointmentId);
                    if (appointment != null)
                    {
                        appointment.StatusId = 3;
                        ctx.SaveChanges();
                        MessageBox.Show("Randevu Başarıyla İptal Edildi!");

                        var parentPanel = this.Parent as FlowLayoutPanel;
                        if (parentPanel != null)
                        {
                            parentPanel.Controls.Remove(this);
                        }
                    }
                }
            }
        }

        [Category("Custom Props")]
        public string Date
        {
            get { return _date; }
            set { _date = value; lblAppointmenDate.Text = value; }
        }
        [Category("Custom Props")]
        public string Hospital
        {
            get { return _hospital; }
            set { _hospital = value; lblHospital.Text = value; }
        }
        [Category("Custom Props")]
        public string Clinic
        {
            get { return _clinic; }
            set { _clinic = value; lblClinic.Text = value; }
        }
        [Category("Custom Props")]
        public string Doctor
        {
            get { return _doctor; }
            set { _doctor = value; lblDoctor.Text = value; }
        }
        [Category("Custom Props")]
        public string Owner
        {
            get { return _owner; }
            set { _owner = value; lblAppointmentOwner.Text = value; }
        }
        [Category("Custom Props")]
        public string Status
        {
            get { return _status; }
            set { _status = value; lblAppointmentStatus.Text = value;}
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
                btnCancelAppointment.Visible = value; // Butonun görünürlüğünü ayarla
            }
        }
        #endregion
    }
}
