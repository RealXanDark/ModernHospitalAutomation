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
    public partial class frmAppointment : Form
    {
        private Button? lastClickedButton;
        private Color originalColor = Color.FromArgb(109, 122, 224);
        public frmAppointment()
        {     
            InitializeComponent();
            if (Properties.Settings.Default.isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
            }
            dgwAppointment.AutoGenerateColumns = false;
            flpAppointment.HorizontalScroll.Visible = false;
            flpAppointment.VerticalScroll.Visible = false;
        }

        private void frmAppointment_Load(object sender, EventArgs e)
        { 
            btnActiveAppointment.PerformClick();
        }
        void loadDGW(byte type)
        {
            try
            {
                var currentDate = DateOnly.FromDateTime(DateTime.Now);
                var currentTime = TimeOnly.FromDateTime(DateTime.Now);
                flpAppointment.Controls.Clear();
                //Delete.Visible = type;
                using (var ctx = new DbHanHospitalContext())
                {
                    var query = ctx.TblAppointments.Include(x => x.AppointmentTime).Include(x => x.Doctor).ThenInclude(d => d.Title)
                        .Include(x => x.Clinic).Include(x => x.Hospital).Include(x => x.Patient)
                        .Where(x => x.PatientId == Global.user_id && !x.IsDeleted && (type == 4 ? (x.StatusId == 2 || x.StatusId == 4) : x.StatusId == type)).Select(x => new
                        {
                            x.AppointmentId,
                            PatientName = Encryption.Decrypt(x.Patient.FirstName) + " " + Encryption.Decrypt(x.Patient.LastName),
                            HospitalName = x.Hospital.HospitalName,
                            ClinicName = x.Clinic.Clinic.ClinicName,
                            x.AppointmentDate,
                            x.AppointmentTime.AppointmentTime,
                            DoctorName = x.Doctor.DoctorFullName,
                            x.StatusId,
                        });

                    var appointments = query
                        .OrderBy(a => a.AppointmentDate)
                        .ThenBy(a => a.AppointmentTime)
                        .ToList();
                    foreach (var item in appointments)
                    {
                        AppointmentCard appointmentCard = new AppointmentCard();
                        appointmentCard.Date = $"{item.AppointmentDate.ToString()} {item.AppointmentTime.ToString()}";
                        appointmentCard.Hospital = item.HospitalName;
                        appointmentCard.Clinic = item.ClinicName;
                        appointmentCard.Doctor = item.DoctorName;
                        appointmentCard.Owner = item.PatientName;
                        appointmentCard.AppointmentId = item.AppointmentId;
                        if (item.StatusId == 1)
                        {
                            appointmentCard.Status = "Aktif Randevu";
                            appointmentCard.StatusColor = Color.DarkGreen;
                        }
                        else if (item.StatusId == 2)
                        {
                            appointmentCard.Status = "Geçmiş Randevu";
                            appointmentCard.StatusColor = Color.DarkSeaGreen;
                            appointmentCard.IsButtonVisible = false;
                        }
                        else if (item.StatusId == 3)
                        {
                            appointmentCard.Status = "İptal Edildi";
                            appointmentCard.StatusColor = Color.FromArgb(225, 37, 27);
                            appointmentCard.IsButtonVisible = false;
                        }
                        else if (item.StatusId == 4)
                        {
                            appointmentCard.Status = "Randevuya Gidilmedi (Lütfen Gitmeyeceğiniz Randevuları İptal Ediniz!)";
                            appointmentCard.StatusColor = Color.DarkSeaGreen;
                            appointmentCard.IsButtonVisible = false;
                        }
                        flpAppointment.Controls.Add(appointmentCard);
                    }

                    dgwAppointment.DataSource = appointments;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Randevular Yüklenirken Hata Oluştu Lütfen Tekrar Dene :(" + ex.Message);
            }
        }
        private void btnActiveAppointment_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnActiveAppointment);
            loadDGW(1);
        }

        private void btnCanceledAppointment_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnCanceledAppointment);
            loadDGW(3);
        }


        private void btnPastAppointment_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnPastAppointment);
            loadDGW(4);
        }
        void changeButtonColor(Button btn)
        {
            Button clickedButton = btn;


            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = originalColor;
            }


            originalColor = clickedButton.BackColor;
            clickedButton.BackColor = Color.FromArgb(79, 88, 162); 

            lastClickedButton = clickedButton;
        }
    }
}
