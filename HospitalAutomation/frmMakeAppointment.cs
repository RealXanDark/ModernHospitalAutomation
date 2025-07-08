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
    public partial class frmMakeAppointment : Form
    {
        bool change = false;
        public frmMakeAppointment()
        {
            InitializeComponent();
            if (Properties.Settings.Default.isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Tag?.ToString() == "1")
                    {
                        if (ctrl is Label)
                        {
                            ctrl.ForeColor = Color.White;
                        }

                    }
                    if (ctrl is ComboBox)
                    {
                        ctrl.BackColor = Color.FromArgb(30, 30, 30);
                        ctrl.ForeColor = Color.White;
                    }
                }
            }
            if (DateTime.Now.Hour > 17)
            {
                dtpDate.MinDate = DateTime.Now.AddDays(1);
            }
            else
            {
                dtpDate.MinDate = DateTime.Now;
            }
            
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "dd/MM/yyyy";
        }

        private void frmMakeAppointment_Load(object sender, EventArgs e)
        {
            try
            {
                

                using (var ctx = new DbHanHospitalContext())
                {
                    var province = ctx.TblProvinces.Where(p => p.ProvinceHasBranch == true).OrderBy(p => p.ProvinceName).ToList();
                    cbProvince.DataSource = province;
                    cbProvince.DisplayMember = "ProvinceName";
                    cbProvince.ValueMember = "ProvinceId";
                    cbProvince.SelectedItem = null;
                }
            }
            catch (Exception)
            {

            }
           
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProvince.Focused)
            {
                ResetControls(1);
                int provinceId = (int)cbProvince.SelectedValue!;
                using (var ctx = new DbHanHospitalContext())
                {
                    var districts = ctx.TblDistricts.Where(d => d.DistrictParentId == provinceId && d.DistrictHasBranch == true).ToList();
                    cbDistrict.DataSource = districts;
                    cbDistrict.DisplayMember = "DistrictName";
                    cbDistrict.ValueMember = "DistrictId";
                    cbDistrict.Enabled = true;
                    cbDistrict.SelectedItem = null;

                }
            }
        }

        private void cbDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDistrict.Focused)
            {
                ResetControls(2);
                int districtId = (int)cbDistrict.SelectedValue!; 
                using (var ctx = new DbHanHospitalContext())
                {
                    var hospitals = ctx.TblHospitals.Where(d => d.HospitalDistrictId == districtId && d.HospitalIsActive == true).ToList();
                    cbHospital.DataSource = hospitals;
                    cbHospital.DisplayMember = "HospitalName";
                    cbHospital.ValueMember = "HospitalId";
                    cbHospital.Enabled = true;
                    cbHospital.SelectedItem = null;
                }
            }
        }

        private void cbHospital_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbHospital.Focused)
            {
                ResetControls(3);
                int hospitalId = (int)cbHospital.SelectedValue!;
                using (var ctx = new DbHanHospitalContext())
                {
                    var clinics = ctx.TblHospitalClinics
                        .Include(c => c.Clinic) 
                        .Where(c => c.HospitalId == hospitalId && c.ClinicIsActive)
                        .Select(c => new { c.HospitalClinicId, c.Clinic.ClinicName }) 
                        .ToList();

                    cbClinic.DataSource = clinics;
                    cbClinic.DisplayMember = "ClinicName"; 
                    cbClinic.ValueMember = "HospitalClinicId"; 
                    cbClinic.Enabled = true;
                    cbClinic.SelectedItem = null;
                }
            }
        }

        private void cbClinic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClinic.Focused)
            {
                ResetControls(4);
                int hospitalId = (int)cbHospital.SelectedValue!;
                int clinicId = (int)cbClinic.SelectedValue!;
                using (var ctx = new DbHanHospitalContext())
                {
                    var doctors = ctx.TblDoctors.Include(d => d.Title).Where(d => d.HospitalId == hospitalId && d.ClinicId == clinicId).ToList();
                    cbDoctor.DataSource = doctors;
                    cbDoctor.DisplayMember = $"DoctorFullName";
                    cbDoctor.ValueMember = "DoctorId";
                    cbDoctor.Enabled = true;
                    cbDoctor.SelectedItem = null;
                }
            }
        }

        private void cbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDoctor.Focused)
            {
                ResetControls(5);
                dtpDate.Enabled = true;
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDate.Focused)
            {
                ResetControls(6);
                int doctorid = (int)cbDoctor.SelectedValue!;
                using (var ctx = new DbHanHospitalContext())
                {
                    var selectedDate = DateOnly.FromDateTime(dtpDate.Value.Date);
                    var reservedappointments = ctx.TblAppointments
                        .Where(a => a.DoctorId == doctorid && a.StatusId == 1 && a.AppointmentDate == selectedDate)
                        .Select(a => a.AppointmentTimeId)
                        .ToList();

                    var availableAppointments = ctx.TblAppointmentTimes
                        .Where(t => !reservedappointments.Contains(t.AppointmentTimeId))
                        .ToList();

                    // Eğer seçili tarih bugünün tarihi ise, yalnızca mevcut saatten sonraki saatleri listeleyin
                    if (selectedDate == DateOnly.FromDateTime(DateTime.Now))
                    {
                        var currentTime = TimeOnly.FromDateTime(DateTime.Now);
                        availableAppointments = availableAppointments
                            .Where(t => t.AppointmentTime > currentTime)
                            .ToList();
                    }

                    cbTime.DataSource = availableAppointments;
                    cbTime.DisplayMember = "AppointmentTime";
                    cbTime.ValueMember = "AppointmentTimeId";
                    cbTime.Enabled = true;
                    cbTime.SelectedItem = null;
                }
            }
        }

        private void btnReviewAppointment_Click(object sender, EventArgs e)
        {
            frmAppointmentConfirmation confirmation = new frmAppointmentConfirmation((int)cbDoctor.SelectedValue!, (int)cbHospital.SelectedValue!, (int)cbClinic.SelectedValue!, DateOnly.FromDateTime(dtpDate.Value.Date), (int)cbTime.SelectedValue!, cbTime.Text, cbDoctor.Text, cbHospital.Text, cbClinic.Text);
            confirmation.StartPosition = FormStartPosition.CenterParent;
            confirmation.ShowDialog();
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTime.SelectedItem != null)
            {
                btnReviewAppointment.Enabled = true;
            }
            else
            {
                btnReviewAppointment.Enabled = false;
            }
        }
        private void ResetControls(int startTag)
        {
            foreach (Control control in Controls)
            {
                if (control.Tag != null && int.TryParse(control.Tag.ToString(), out int tagValue))
                {
                    if (tagValue > startTag)
                    {
                        if (control is System.Windows.Forms.ComboBox comboBox)
                        {
                            comboBox.DataSource = null;
                            comboBox.Items.Clear();
                            comboBox.Enabled = false;
                            comboBox.SelectedItem = null;
                        }
                        else if (control is DateTimePicker dateTimePicker)
                        {
                            dateTimePicker.Enabled = false;
                            if (DateTime.Now.Hour > 17)
                            {
                                dateTimePicker.Value = DateTime.Now.AddDays(1);
                            }
                            else
                            {
                                dateTimePicker.Value = DateTime.Now;
                            }
                           
                        }
                    }
                }
            }
        }
    }
}
