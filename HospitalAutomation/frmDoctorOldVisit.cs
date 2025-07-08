using HospitalAutomation.CustomControls;
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

namespace HospitalAutomation
{
    public partial class frmDoctorOldVisit : Form
    {
        public frmDoctorOldVisit()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Global.AddDoctorLogAsync("Eski Ziyaretler Sayfasında Arama Yapıldı", txtIdentityNumber.Text);
                if (txtIdentityNumber.Text != string.Empty)
                {
                    flpDoctorOldVisit.Controls.Clear();
                    using (var ctx = new DbHanHospitalContext())
                    {
                        var id = ctx.TblPatients.Include(p => p.IdentityNumber).SingleOrDefault(p => p.IdentityNumber.IdentityNumber.SequenceEqual(Encryption.Encrypt(txtIdentityNumber.Text)) && !p.IsDeleted);
                        var appointment = ctx.TblVisits.Where(a => a.DoctorId == Global.user_id && a.PatientId == id.PatientId).Select(x => new
                        {
                            x.AppointmentId,
                            PatientId = x.PatientId,
                            PatientName = Encryption.Decrypt(x.Patient.FirstName) + " " + Encryption.Decrypt(x.Patient.LastName),
                            PatientIdentityNumber = Encryption.Decrypt(x.Patient.IdentityNumber.IdentityNumber),
                            HospitalName = x.Hospital.HospitalName,
                            ClinicName = x.Clinic.Clinic.ClinicName,
                            x.VisitDate,
                            DoctorName = x.Doctor.DoctorFullName,
                            x.Diagnosis,
                            x.Notes,
                        }).OrderBy(a => a.VisitDate).ToList();
                        foreach (var item in appointment)
                        {
                            DoctorPastVisitCard visitCard = new DoctorPastVisitCard();
                            visitCard.Date = item.VisitDate.ToString();
                            visitCard.HospitalName = item.HospitalName;
                            visitCard.ClinicName = item.ClinicName;
                            visitCard.DoctorName = item.DoctorName;

                            visitCard.AppointmentId = item.AppointmentId;

                            visitCard.PatientName = item.PatientName;
                            visitCard.PatientIdentityNumber = item.PatientIdentityNumber;

                            visitCard.Notes = item.Notes;
                            visitCard.Diagnosis = item.Diagnosis;

                            visitCard.PatientId = item.PatientId;

                            int day = item.VisitDate.Day;
                            int month = item.VisitDate.Month;
                            int year = item.VisitDate.Year;

                            DateOnly selectedDate = new DateOnly(year, month, day);

                            visitCard.DateOnly = selectedDate;


                            flpDoctorOldVisit.Controls.Add(visitCard);
                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmDoctorOldVisit_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmAnalyses analyses = Application.OpenForms.OfType<frmAnalyses>().SingleOrDefault()!;
            frmPrescription prescription = Application.OpenForms.OfType<frmPrescription>().SingleOrDefault()!;

            if (analyses != null)
            {
                analyses.Dispose();
            }
            if (prescription != null)
            {
                prescription.Dispose();
            }
        }
    }
}
