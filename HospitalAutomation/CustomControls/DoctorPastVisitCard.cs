using HospitalAutomation.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class DoctorPastVisitCard : UserControl
    {

        public DoctorPastVisitCard()
        {
            InitializeComponent();
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            frmPrescription prescription = Application.OpenForms.OfType<frmPrescription>().SingleOrDefault()!;
            if (prescription == null)
            {
                prescription = new frmPrescription(_appointmentId);
                prescription.Show();
            }
            else
            {
                prescription.BringToFront();
                prescription.Focus();
            }
            
        }

        #region Properties
        private string? _dateTime;
        private string? _hospitalName;
        private string? _clinicName;
        private string? _doctorName;
        private string? _patientName;
        private string? _patientIdentityNumber;
        private string? _diagnosis;
        private string? _notes;

        private int _appointmentId;
        private int _visitId;
        private int _doctorId;
        private int _patientId;

        private DateOnly _dateOnly;

        private void DoctorPastVisitCard_Load(object sender, EventArgs e)
        {
            using (var ctx = new DbHanHospitalContext())
            {
                var allergy = ctx.TblPatientAllergies.Include(a => a.Allergy)
                       .Where(a => a.PatientId == _patientId
                                && a.DiagnosisDate.Date == _dateOnly.ToDateTime(TimeOnly.MinValue).Date)
                       .ToList();
                lbAlergieDisease.DataSource = allergy;
                lbAlergieDisease.DisplayMember = "DisplayName";

                var disease = ctx.TblPatientChronicDiseases.Include(a => a.ChronicDisease)
                       .Where(a => a.PatientId == _patientId
                                && a.DiagnosisDate.Date == _dateOnly.ToDateTime(TimeOnly.MinValue).Date)
                       .ToList();
                lbDisease.DataSource = disease;
                lbDisease.DisplayMember = "DisplayName";

                lbAlergieDisease.ClearSelected();
                lbDisease.ClearSelected();
            }
        }

        private void DoctorPastVisitCard_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAnalyses analyses = Application.OpenForms.OfType<frmAnalyses>().SingleOrDefault()!;
            if (analyses == null)
            {
                analyses = new frmAnalyses(_patientId);
                analyses.Show();
            }
            else
            {
                analyses.BringToFront();
                analyses.Focus();
            }
        }

        [Category("Custom Props")]
        public int VisitId
        {
            get { return _visitId; }
            set { _visitId = value; }
        }
        [Category("Custom Props")]
        public int AppointmentId
        {
            get { return _appointmentId; }
            set { _appointmentId = value; }
        }
        [Category("Custom Props")]
        public int DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }
        [Category("Custom Props")]
        public string? Date
        {
            get { return _dateTime; }
            set { _dateTime = value; lblDate.Text = value; }
        }
        [Category("Custom Props")]
        public DateOnly DateOnly
        {
            get { return _dateOnly; }
            set { _dateOnly = value; }
        }
        [Category("Custom Props")]
        public string? HospitalName
        {
            get { return _hospitalName; }
            set { _hospitalName = value; lblHospitalName.Text = value; }
        }
        [Category("Custom Props")]
        public string? DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; lblDoctorName.Text = value; }
        }
        [Category("Custom Props")]
        public string? ClinicName
        {
            get { return _clinicName; }
            set { _clinicName = value; lblClinicName.Text = value; }
        }
        [Category("Custom Props")]
        public string? Diagnosis
        {
            get { return _diagnosis; }
            set { _diagnosis = value; txtDiagnosis.Text = value; }
        }
        [Category("Custom Props")]
        public string? Notes
        {
            get { return _notes; }
            set { _notes = value; txtNotes.Text = value; }
        }
        [Category("Custom Props")]
        public string? PatientName
        {
            get { return _patientName; }
            set { _patientName = value; lblPatientName.Text = value; }
        }
        [Category("Custom Props")]
        public int PatientId
        {
            get { return _patientId; }
            set { _patientId = value; }
        }
        public string? PatientIdentityNumber
        {
            get { return _patientIdentityNumber; }
            set { _patientIdentityNumber = value; lblPatientIdentityNumber.Text = value; }
        }
        #endregion
    }
}
