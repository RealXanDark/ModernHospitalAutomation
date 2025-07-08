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
    public partial class DoctorAppointmentCard : UserControl
    {

        public DoctorAppointmentCard()
        {
            InitializeComponent();
        }
        #region Properties
        private string? _date;
        private string? _time;
        private string? _identityNumber;
        private string? _owner;
        private int _appointmentId;
        //private string _surname;
        //private string _date_of_birth;
        //private string _blood_group;
        //private string _gender;
        //private string _complaint;

        private void lblAppointmentStatus_Click(object sender, EventArgs e)
        {
            Global.AddDoctorLogAsync("Randevular Sayfasından Hasta Çağırıldı", $"Appointment Id : {_appointmentId} Patient Identity Number : {_identityNumber}");
            frmExamination examination = new frmExamination(AppointmentId);
            examination.StartPosition = FormStartPosition.CenterParent;
            examination.ShowDialog(this);
        }

        [Category("Custom Props")]
        public string Date
        {
            get { return _date!; }
            set { _date = value; lblAppointmentDate.Text = value; }
        }
        [Category("Custom Props")]
        public string Time
        {
            get { return _time!; }
            set { _time = value; lblTime.Text = value; }
        }
        [Category("Custom Props")]
        public string Owner
        {
            get { return _owner!; }
            set { _owner = value; lblAppointmentOwner.Text = value; }
        }
        [Category("Custom Props")]
        public string IdentityNumber
        {
            get { return _identityNumber!; }
            set { _identityNumber = value; lblIdentityNumber.Text = value; }
        }
        [Category("Custom Props")]
        public int AppointmentId
        {
            get { return _appointmentId; }
            set { _appointmentId = value; }
        }
        #endregion
    }
}
