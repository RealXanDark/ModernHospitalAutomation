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
    public partial class frmPatientTestResult : Form
    {
        public frmPatientTestResult()
        {
            InitializeComponent();
            if (Properties.Settings.Default.isDarkMode)
            {
                this.BackColor = Color.FromArgb(30,30,30);
                dgwAppointment.BackgroundColor = Color.FromArgb(30, 30, 30);
                dgwAppointment.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
                dgwAppointment.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
                dgwAppointment.DefaultCellStyle.BackColor = Color.FromArgb(30, 30, 30);
                dgwAppointment.DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void frmPatientTestResult_Load(object sender, EventArgs e)
        {
            using (var ctx = new DbHanHospitalContext())
            {
                var result = ctx.TblTestResults
                            .Include(r => r.Test)
                            .Where(r => r.PatientId == Global.user_id)
                            .Select(r => new
                            {
                                ResultDate = r.ResultDate,
                                //PatientIdentityNumber = r.Patient.PatientIdentityNumber,
                                //PatientFirstName = r.Patient.PatientFirstName,
                                //PatientLastName = r.Patient.PatientLastName,
                                TestName = r.Test.TestName,
                                Min = r.Test.MinValueMale,
                                Max = r.Test.MaxValueMale,
                                TestResult = r.TestResult
                            })
                            .ToList();
                if (result.Any())
                {
                    dgwAppointment.DataSource = result;
                    dgwAppointment.Columns["ResultDate"].HeaderText = "Sonuç Tarihi";
                    //dgwAppointment.Columns["PatientIdentityNumber"].HeaderText = "Kimlik Numarası";
                    //dgwAppointment.Columns["PatientFirstName"].HeaderText = "Ad";
                    //dgwAppointment.Columns["PatientLastName"].HeaderText = "Soyad";
                    dgwAppointment.Columns["TestName"].HeaderText = "Test";
                    dgwAppointment.Columns["Min"].HeaderText = "Min Değer";
                    dgwAppointment.Columns["Max"].HeaderText = "Max Değer";
                    dgwAppointment.Columns["TestResult"].HeaderText = "Test Sonucu";
                    dgwAppointment.DataBindingComplete += (s, ev) =>
                    {
                        dgwAppointment.ClearSelection();
                    };
                }
                else
                {
                    lblInfo.Visible = true;
                }
            }
        }

        private void dgwAppointment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgwAppointment.Columns[e.ColumnIndex].Name == "TestResult")
            {
                // Min ve Max değerlerini kontrol et, null ise işlem yapma
                var minCellValue = dgwAppointment.Rows[e.RowIndex].Cells["Min"].Value;
                var maxCellValue = dgwAppointment.Rows[e.RowIndex].Cells["Max"].Value;
                var testResultValue = dgwAppointment.Rows[e.RowIndex].Cells["TestResult"].Value;
                var resultDate = dgwAppointment.Rows[e.RowIndex].Cells["ResultDate"].Value;

                // Eğer TestResult, Min ya da Max null ise varsayılan rengi koru
                if (minCellValue != null && maxCellValue != null && testResultValue != null)
                {
                    // Min, Max ve TestResult değerlerini decimal'e dönüştür
                    var minValue = Convert.ToDecimal(minCellValue);
                    var maxValue = Convert.ToDecimal(maxCellValue);
                    var testResult = Convert.ToDecimal(testResultValue);

                    // Eğer test sonucu minValue'den küçükse hücreyi sarıya boya
                    if (testResult < minValue && resultDate != null)
                    {
                        e.CellStyle!.BackColor = Color.Khaki;
                        e.CellStyle.ForeColor = Color.FromArgb(30, 30, 30);
                        MessageBox.Show("Test0");
                    }
                    // Eğer test sonucu maxValue'den büyükse hücreyi kırmızıya boya
                    else if (testResult > maxValue)
                    {
                        e.CellStyle!.BackColor = Color.IndianRed;
                        e.CellStyle.ForeColor = Color.FromArgb(30, 30, 30);
                    }
                    else
                    {
                        /*e.CellStyle!.BackColor = Color.FromArgb(30,30,30);*/ // Şart sağlanmazsa varsayılan beyaz arka plan
                    }
                }
                else
                {
                    if (Convert.ToDecimal(testResultValue) > 0)
                    {
                        e.Value = "Pozitif";
                        e.CellStyle!.BackColor = Color.IndianRed;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (Convert.ToDecimal(testResultValue) == 0 && resultDate != null)
                    {
                        e.Value = "Negatif";
                        e.CellStyle!.BackColor = Color.Khaki;
                        e.CellStyle!.ForeColor = Color.Black;
                        MessageBox.Show("Test1");
                    }
                    if (testResultValue == null)
                    {
                        e.Value = testResultValue;
                    }

                }
            }   
        }
    }
}
