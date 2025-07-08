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
    public partial class frmDoctorAppointment : Form
    {
        public frmDoctorAppointment()
        {
            InitializeComponent();
        }

        private void frmDoctorAppointment_Load(object sender, EventArgs e)
        {
            getAppointment();
        }
        public void getAppointment()
        {
            try
            {
                flpDoctorAppointment.Controls.Clear();
                using (var ctx = new DbHanHospitalContext())
                {
                    var appointment = ctx.TblAppointments.Include(a => a.Patient).ThenInclude(p => p.IdentityNumber).Include(a => a.AppointmentTime).Where(a => a.DoctorId == Global.user_id && a.AppointmentDate == DateOnly.FromDateTime(DateTime.Today) && a.StatusId == 1).Select(x => new
                    {
                        x.AppointmentId,
                        PatientName =  Encryption.Decrypt(x.Patient.FirstName) + " " + Encryption.Decrypt(x.Patient.LastName),
                        PatientIdentityNumber = Encryption.Decrypt(x.Patient.IdentityNumber.IdentityNumber),
                        HospitalName = x.Hospital.HospitalName,
                        //ClinicName = x.Clinic.Clinic.ClinicName,
                        x.AppointmentDate,
                        x.AppointmentTime.AppointmentTime,
                        DoctorName = x.Doctor.DoctorFullName,
                        x.StatusId,
                    }).OrderBy(a => a.AppointmentDate).ThenBy(a => a.AppointmentTime).ToList();
                    foreach (var item in appointment)
                    {
                        DoctorAppointmentCard doctorAppointmentCard = new DoctorAppointmentCard();
                        doctorAppointmentCard.Date = item.AppointmentDate.ToString();
                        doctorAppointmentCard.Time = item.AppointmentTime.ToString()!;
                        doctorAppointmentCard.Owner = item.PatientName.ToString();
                        doctorAppointmentCard.IdentityNumber = item.PatientIdentityNumber.ToString();
                        doctorAppointmentCard.AppointmentId = item.AppointmentId;
                        flpDoctorAppointment.Controls.Add(doctorAppointmentCard);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
