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
    public partial class frmVisit : Form
    {
        private int currentPage = 0;
        private const int pageSize = 5;

        public frmVisit()
        {
            InitializeComponent();
            if (Properties.Settings.Default.isDarkMode)
            {
                this.BackColor = Color.FromArgb(30,30,30);
            }
        }

        private void frmVisit_Load(object sender, EventArgs e)
        {
            LoadVisits();
        }
        private void LoadVisits()
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    // Skip ile önceki sayfaları atla, Take ile sadece 10 kayıt al
                    var visits = ctx.TblVisits.Include(v => v.Doctor)
                                              .Include(v => v.Hospital)
                                              .Include(v => v.Clinic)
                                              .ThenInclude(v => v.Clinic)
                                              .Where(v => v.PatientId == 2)
                                              .Skip(currentPage * pageSize)
                                              .Take(pageSize)
                                              .ToList();
                    if (visits.Any())
                    {
                        foreach (var v in visits)
                        {
                            VisitCard card = new VisitCard
                            {
                                VisitId = v.VisitId,
                                AppointmentId = v.AppointmentId,
                                DoctorId = v.DoctorId,
                                Date = v.VisitDate.ToShortDateString(),
                                HospitalName = v.Hospital.HospitalName,
                                ClinicName = v.Clinic.Clinic.ClinicName,
                                DoctorName = v.Doctor.DoctorFullName,
                                Rate = v.Rates,
                                Diagnosis = v.Diagnosis,
                                Notes = v.Notes,
                                Evaluate = v.Comment
                            };
                            flpAppointment.Controls.Add(card);
                        }

                        // Eğer çekilen veri sayısı 10'dan azsa, bir daha veri olmayabilir
                        if (visits.Count < pageSize)
                        {
                            btnLoadMore.Enabled = false; // Daha fazla yükle butonunu devre dışı bırak
                        }
                        btnLoadMore.Visible = true;
                    }
                    else
                    {
                        lblInfo.Visible = true;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                // Hatalar burada işlenebilir
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

        private void btnLoadMore_Click(object sender, EventArgs e)
        {
            currentPage++;  // Sayfa numarasını artır
            LoadVisits();
        }
    }
}
