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

namespace HospitalAutomation
{
    public partial class frmViewDoctor : Form
    {
        public frmViewDoctor()
        {
            InitializeComponent();
        }

        private void frmViewDoctor_Load(object sender, EventArgs e)
        {
            //using (var ctx = new DbHanHospitalContext())
            //{
            //    var doctors = ctx.TblDoctors.Select(d => new
            //    {
            //        Id = d.DoctorId,
            //        DoctorIdentityNumber = Encryption.Decrypt(d.DoctorIdentityNumber),
            //        DoctorFirstName = Encryption.Decrypt(d.DoctorFirstName),
            //        DoctorLastName = Encryption.Decrypt(d.DoctorLastName),
            //        DoctorEmail =Encryption.Decrypt(d.DoctorEmail),
            //        DoctorPhoneNumber = Encryption.Decrypt(d.DoctorPhoneNumber),
            //        DoctorHospital = d.DoctorHospitalId,
            //        DoctorClinic = d.DoctorClinicId,
            //    }).Where(d => d.DoctorHospital == 438 && d.DoctorClinic == 37175).Take(100000).ToList();
            //    dataGridView1.DataSource = doctors;

            //    var users = ctx.TblUsers.Select(d => new
            //    {
            //        Id = d.UserId,
            //        DoctorIdentityNumber = Encryption.Decrypt(d.UserIdentityNumber),
            //        DoctorPassword = Encryption.Decrypt(d.UserPassword)
            //    }).Where(u => u.Id == 87781).Take(10000).ToList();
            //    dataGridView2.DataSource = users;
            //}
        }
    }
}
