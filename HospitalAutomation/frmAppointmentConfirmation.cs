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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HospitalAutomation
{
    public partial class frmAppointmentConfirmation : Form
    {
        private int doctor_id;
        private int hospital_id;
        private int clinic_id;
        private DateOnly appointment_date;
        private int time_id;
        private string time_string;
        private string doctor_name;
        private string hospital_name;
        private string clinic_name;
        public frmAppointmentConfirmation(int doctorid, int hospitalid, int clinicid, DateOnly appointmentdate, int timeid, string time, string doctorname, string hospitalname, string clinicname)
        {
            InitializeComponent();
            doctor_id = doctorid;
            hospital_id = hospitalid;
            clinic_id = clinicid;
            appointment_date = appointmentdate;
            time_id = timeid;
            time_string = time;
            doctor_name = doctorname;
            hospital_name = hospitalname;
            clinic_name = clinicname;
        }

        private void frmAppointmentConfirmation_Load(object sender, EventArgs e)
        {

            using (var ctx = new DbHanHospitalContext())
            {
                var fullName = ctx.TblPatients.Where(u => u.PatientId == Global.user_id).Select(u => Encryption.Decrypt(u.FirstName) + " " + Encryption.Decrypt(u.LastName)).FirstOrDefault();
                lblAppointmentOwner.Text = fullName;
            }
            lblAppointmenDate.Text = appointment_date.ToString();
            lblAppointmentTime.Text = time_string;
            lblHospital.Text = hospital_name;
            lblClinic.Text = clinic_name;
            lblDoctor.Text = doctor_name;

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var patient = ctx.TblPatients.SingleOrDefault(p => p.PatientId == Global.user_id);
                    var user = ctx.TblUsers.SingleOrDefault(u => u.IdentityNumberId == patient!.IdentityNumberId);

                    var appointment = new TblAppointment { PatientId = Global.user_id, DoctorId = doctor_id, HospitalId = hospital_id, ClinicId = clinic_id, AppointmentDate = appointment_date, AppointmentTimeId = time_id, StatusId = 1,CreatedBy = user!.UserId,UpdatedBy = user.UserId};
                    ctx.TblAppointments.Add(appointment);
                    int result = ctx.SaveChanges();
                    if (result == 1)
                    {
                        MessageBox.Show("Randevunuz Başarıyla Oluşturuldu. Sağlıklı Günler Dileriz.");
                        this.Close();
                        frmMakeAppointment makeappointment = new frmMakeAppointment();
                        Methods.OpenForms(makeappointment);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Randevu Oluşturulurken Bir Hata Meydana Geldi Lütfen Tekrar Dene :(");
            }


        }
    }
}
