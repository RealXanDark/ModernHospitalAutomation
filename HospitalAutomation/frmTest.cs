using HospitalAutomation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Logging;
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
    public partial class frmTest : Form
    {

        public frmTest()
        {
            InitializeComponent();
        }

        private void frmTest_Load(object sender, EventArgs e)
        {



            //using (var ctx = new DbHanHospitalContext())
            //{
            //    var result = ctx.TblTestResults
            //                .Include(r => r.Test)
            //                .Where(r => r.PatientId == 1)
            //                .Select(r => new
            //                {
            //                    ResultDate = r.ResultDate,
            //                    //PatientIdentityNumber = r.Patient.PatientIdentityNumber,
            //                    //PatientFirstName = r.Patient.PatientFirstName,
            //                    //PatientLastName = r.Patient.PatientLastName,
            //                    TestName = r.Test.TestName,
            //                    Min = r.Test.MinValueMale,
            //                    Max = r.Test.MaxValueMale,
            //                    TestResult = r.TestResult
            //                })
            //                .ToList();
            //    if (result.Any())
            //    {
            //        dgwAppointment.DataSource = result;
            //        dgwAppointment.Columns["ResultDate"].HeaderText = "Sonuç Tarihi";
            //        //dgwAppointment.Columns["PatientIdentityNumber"].HeaderText = "Kimlik Numarası";
            //        //dgwAppointment.Columns["PatientFirstName"].HeaderText = "Ad";
            //        //dgwAppointment.Columns["PatientLastName"].HeaderText = "Soyad";
            //        dgwAppointment.Columns["TestName"].HeaderText = "Test";
            //        dgwAppointment.Columns["Min"].HeaderText = "Min Değer";
            //        dgwAppointment.Columns["Max"].HeaderText = "Max Değer";
            //        dgwAppointment.Columns["TestResult"].HeaderText = "Test Sonucu";
            //        dgwAppointment.ClearSelection();
            //    }
            //    else
            //    {

            //    }
            //}

            //using (var ctx = new DbHanHospitalContext())
            //{
            //    var list = ctx.TblDoctorLogs.Select(l => new
            //    {
            //        l.Id,
            //        l.UserId,
            //        l.ActivityType,
            //        ActivityParameters = l.ActivityParameters != null ? Encryption.Decrypt(l.ActivityParameters) : null,
            //        l.Datetime,
            //    }
            //    ).ToList();
            //    // DataGridView'in tarih sütununun formatını milisaniyeleri gösterecek şekilde ayarlıyoruz


            //    dataGridView1.DataSource = list;
            //    dataGridView1.Columns["Datetime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
            //}
        }

        async void refresh()
        {

                bool isScrollAtBottom = dataGridView1.FirstDisplayedScrollingRowIndex >= dataGridView1.RowCount - dataGridView1.DisplayedRowCount(false);

                // Mevcut scroll pozisyonunu kaydet
                int verticalScrollPos = dataGridView1.FirstDisplayedScrollingRowIndex;
                int horizontalScrollPos = dataGridView1.FirstDisplayedScrollingColumnIndex;


                using (var ctx = new DbHanHospitalContext())
                {
                    var list = ctx.TblDoctorLogs.Select(l => new
                    {
                        l.Id,
                        l.UserId,
                        l.SessionId,
                        l.ActivityType,
                        ActivityParameters = l.ActivityParameters != null ? Encryption.Decrypt(l.ActivityParameters) : null,
                        l.Datetime,
                    }
                    ).Where(s => s.SessionId == 12).ToList();
                    // DataGridView'in tarih sütununun formatını milisaniyeleri gösterecek şekilde ayarlıyoruz


                    dataGridView1.DataSource = list;
                    dataGridView1.Columns["Datetime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss.fff";
                    if (isScrollAtBottom && dataGridView1.RowCount > 0)
                    {
                        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                    }
                    else
                    {
                        // Scroll pozisyonunu geri yükle
                        if (verticalScrollPos >= 0 && verticalScrollPos < dataGridView1.RowCount)
                        {
                            dataGridView1.FirstDisplayedScrollingRowIndex = verticalScrollPos;
                        }

                        if (horizontalScrollPos >= 0 && horizontalScrollPos < dataGridView1.ColumnCount)
                        {
                            dataGridView1.FirstDisplayedScrollingColumnIndex = horizontalScrollPos;
                        }
                    }
                }
        }

        private void dgwAppointment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (dgwAppointment.Columns[e.ColumnIndex].Name == "TestResult")
            //{
            //    // Min ve Max değerlerini kontrol et, null ise işlem yapma
            //    var minCellValue = dgwAppointment.Rows[e.RowIndex].Cells["Min"].Value;
            //    var maxCellValue = dgwAppointment.Rows[e.RowIndex].Cells["Max"].Value;
            //    var testResultValue = dgwAppointment.Rows[e.RowIndex].Cells["TestResult"].Value;

            //    // Eğer TestResult, Min ya da Max null ise varsayılan rengi koru
            //    if (minCellValue != null && maxCellValue != null && testResultValue != null)
            //    {
            //        // Min, Max ve TestResult değerlerini decimal'e dönüştür
            //        var minValue = Convert.ToDecimal(minCellValue);
            //        var maxValue = Convert.ToDecimal(maxCellValue);
            //        var testResult = Convert.ToDecimal(testResultValue);

            //        // Eğer test sonucu minValue'den küçükse hücreyi sarıya boya
            //        if (testResult < minValue)
            //        {
            //            e.CellStyle!.BackColor = Color.Yellow;
            //        }
            //        // Eğer test sonucu maxValue'den büyükse hücreyi kırmızıya boya
            //        else if (testResult > maxValue)
            //        {
            //            e.CellStyle!.BackColor = Color.FromArgb(255, 236, 238);
            //        }
            //        else
            //        {
            //            e.CellStyle!.BackColor = Color.White; // Şart sağlanmazsa varsayılan beyaz arka plan
            //        }
            //    }
            //    else
            //    {
            //        if (Convert.ToDecimal(testResultValue) > 0)
            //        {
            //            e.Value = "Pozitif";
            //            e.CellStyle!.BackColor = Color.FromArgb(255, 236, 238);
            //        }
            //        else if (Convert.ToDecimal(testResultValue) == 0)
            //        {
            //            e.Value = "Negatif";
            //            e.CellStyle!.BackColor = Color.White;
            //        }
            //        if (testResultValue == null)
            //        {
            //            e.Value = testResultValue;
            //            e.CellStyle!.BackColor = Color.White;
            //        }

            //    }
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgwAppointment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
