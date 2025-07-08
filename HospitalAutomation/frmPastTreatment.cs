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
    public partial class frmPastTreatment : Form
    {
        public frmPastTreatment()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //        using (var ctx = new DbHanHospitalContext())
            //        {
            //            var result = ctx.TblTestResults
            //.Include(r => r.Patient)
            //.Include(r => r.Test)
            //.Where(r => r.Patient.PatientIdentityNumber.ToString().Contains(txtIdentityNumber.Text))
            //.Select(r => new
            //{
            //    ResultDate = r.ResultDate,
            //    PatientIdentityNumber = r.Patient.PatientIdentityNumber,
            //    PatientFirstName = r.Patient.PatientFirstName,
            //    PatientLastName = r.Patient.PatientLastName,
            //    TestName = r.Test.TestName,
            //    Min = r.Test.MinValueMale,
            //    Max = r.Test.MaxValueMale,
            //    TestResult = r.TestResult,
            //})
            //.ToList();
            //            dgwAppointment.DataSource = result;
            //            dgwAppointment.Columns["ResultDate"].HeaderText = "Sonuç Tarihi";
            //            dgwAppointment.Columns["PatientIdentityNumber"].HeaderText = "Kimlik Numarası";
            //            dgwAppointment.Columns["PatientFirstName"].HeaderText = "Ad";
            //            dgwAppointment.Columns["PatientLastName"].HeaderText = "Soyad";
            //            dgwAppointment.Columns["TestName"].HeaderText = "Test";
            //            dgwAppointment.Columns["Min"].HeaderText = "Min Değer";
            //            dgwAppointment.Columns["Max"].HeaderText = "Max Değer";
            //            dgwAppointment.Columns["TestResult"].HeaderText = "Test Sonucu";
            //            dgwAppointment.ClearSelection();
            //        }
            if (lblInfo.Visible)
            {
                lblInfo.Visible = false;
            }
        }
        private void FilterData(string searchText)
        {

        }

        private void dgwAppointment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgwAppointment.Columns[e.ColumnIndex].Name == "TestResult")
            {
                // Min ve Max değerlerini kontrol et, null ise işlem yapma
                var minCellValue = dgwAppointment.Rows[e.RowIndex].Cells["Min"].Value;
                var maxCellValue = dgwAppointment.Rows[e.RowIndex].Cells["Max"].Value;
                var testResultValue = dgwAppointment.Rows[e.RowIndex].Cells["TestResult"].Value;

                // Eğer TestResult, Min ya da Max null ise varsayılan rengi koru
                if (minCellValue != null && maxCellValue != null && testResultValue != null)
                {
                    // Min, Max ve TestResult değerlerini decimal'e dönüştür
                    var minValue = Convert.ToDecimal(minCellValue);
                    var maxValue = Convert.ToDecimal(maxCellValue);
                    var testResult = Convert.ToDecimal(testResultValue);

                    // Eğer test sonucu minValue'den küçükse hücreyi sarıya boya
                    if (testResult < minValue)
                    {
                        e.CellStyle!.BackColor = Color.Yellow;
                    }
                    // Eğer test sonucu maxValue'den büyükse hücreyi kırmızıya boya
                    else if (testResult > maxValue)
                    {
                        e.CellStyle!.BackColor = Color.FromArgb(255, 236, 238);
                    }
                    else
                    {
                        e.CellStyle!.BackColor = Color.White; // Şart sağlanmazsa varsayılan beyaz arka plan
                    }
                }
                else
                {
                    // Min, Max ya da TestResult null ise, varsayılan hücre rengini koru
                    e.CellStyle!.BackColor = Color.White;
                }
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                Global.AddDoctorLogAsync("Test Sayfasında Arama Yapıldı",txtIdentityNumber.Text);
                if (txtIdentityNumber.Text.Length < 11)
                {
                    lblInfo.Text = "Lütfen Kimlik Numarasını 11 Hane Olacak Şekilde Giriniz!";
                    lblInfo.Visible = true;
                }
                else
                {
                    dgwAppointment.DataSource = null;
                    lblInfo.Visible = false;
                    using (var ctx = new DbHanHospitalContext())
                    {
                        var id = ctx.TblPatients.Include(p => p.IdentityNumber).SingleOrDefault(p => p.IdentityNumber.IdentityNumber.SequenceEqual(Encryption.Encrypt(txtIdentityNumber.Text)) && !p.IsDeleted);
                        if (id != null) 
                        {
                            if (!Global.isRestrictionExempt)
                            {
                                var doctor = ctx.TblDoctors
                                .Where(d => d.DoctorId == Global.user_id)
                                .Select(d => new { d.HospitalId })
                                .FirstOrDefault();

                                bool hasAppointment = ctx.TblAppointments.Include(a => a.Patient).ThenInclude(a => a.IdentityNumber).Include(a => a.Doctor)
                                    .Any(a => a.PatientId == id.PatientId && a.HospitalId == doctor!.HospitalId); // currentDoctorHospitalId, aktif doktorun hastane ID'si

                                if (!hasAppointment)
                                {
                                    lblInfo.Text = "Hasta bu hastaneden daha önce randevu almamış, test sonuçları görüntülenemez!";
                                    lblInfo.Visible = true;
                                    return;
                                }
                            }
                        }
                        else
                        {
                            lblInfo.Text = "Girilen Kimlik Bilgileriyle İlişkili Test Sonucu Bulunamadı!";
                            lblInfo.Visible = true;
                            return;
                        }

                        //var result = ctx.TblTestResults
                        //    .Include(r => r.Patient)
                        //    .Include(r => r.Test)
                        //    .Where(r => r.Patient.IdentityNumberId == id.IdentityNumberId)
                        //    .Select(r => new
                        //    {
                        //        ResultDate = r.ResultDate,
                        //        PatientIdentityNumber = Encryption.Decrypt(r.Patient.IdentityNumber.IdentityNumber),
                        //        PatientFirstName = Encryption.Decrypt(r.Patient.FirstName),
                        //        PatientLastName = Encryption.Decrypt(r.Patient.LastName),
                        //        TestName = r.Test.TestName,
                        //        Min = r.Test.MinValueMale,
                        //        Max = r.Test.MaxValueMale,
                        //        TestResult = r.TestResult
                        //    })
                        //    .ToList();


                        var result = ctx.TblTestResults.Include(r => r.Patient).ThenInclude(r => r.IdentityNumber)
                        .Include(r => r.Test)
                        .Where(r => r.PatientId == id.PatientId /*&& r.ResultDate != null*/)
                        .Select(r => new
                        {
                            ResultDate = r.ResultDate,
                            PatientIdentityNumber = Encryption.Decrypt(r.Patient.IdentityNumber.IdentityNumber),
                            PatientFirstName = Encryption.Decrypt(r.Patient.FirstName),
                            PatientLastName = Encryption.Decrypt(r.Patient.LastName),
                            TestName = r.Test.TestName,
                            Min = r.Test.MinValueMale,
                            Max = r.Test.MaxValueMale,
                            TestResult = r.TestResult
                        })
                        .ToList();
                        if (result.Any())
                        {
                            //dgwAppointment.DataSource = result;
                            //dgwAppointment.Columns["ResultDate"].HeaderText = "Sonuç Tarihi";
                            //dgwAppointment.Columns["PatientIdentityNumber"].HeaderText = "Kimlik Numarası";
                            //dgwAppointment.Columns["PatientFirstName"].HeaderText = "Ad";
                            //dgwAppointment.Columns["PatientLastName"].HeaderText = "Soyad";
                            //dgwAppointment.Columns["TestName"].HeaderText = "Test";
                            //dgwAppointment.Columns["Min"].HeaderText = "Min Değer";
                            //dgwAppointment.Columns["Max"].HeaderText = "Max Değer";
                            //dgwAppointment.Columns["TestResult"].HeaderText = "Test Sonucu";
                            //dgwAppointment.ClearSelection();

                            dgwAppointment.DataSource = result;
                            dgwAppointment.Columns["ResultDate"].HeaderText = "Sonuç Tarihi";
                            dgwAppointment.Columns["PatientIdentityNumber"].HeaderText = "Kimlik Numarası";
                            dgwAppointment.Columns["PatientFirstName"].HeaderText = "Ad";
                            dgwAppointment.Columns["PatientLastName"].HeaderText = "Soyad";
                            dgwAppointment.Columns["TestName"].HeaderText = "Test";
                            dgwAppointment.Columns["Min"].HeaderText = "Min Değer";
                            dgwAppointment.Columns["Max"].HeaderText = "Max Değer";
                            dgwAppointment.Columns["TestResult"].HeaderText = "Test Sonucu";
                            dgwAppointment.ClearSelection();
                        }
                        else
                        {
                            lblInfo.Text = "Girilen Kimlik Bilgileriyle İlişkili Test Sonucu Bulunamadı!";
                            lblInfo.Visible = true;
                        }
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Hata");
            }

        }
    }
}
