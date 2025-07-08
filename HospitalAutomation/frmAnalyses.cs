using HospitalAutomation.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalAutomation
{
    public partial class frmAnalyses : Form
    {
        int patientId;

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        public frmAnalyses(int _patientId)
        {
            InitializeComponent();
            patientId = _patientId;
        }

        private void frmAnalyses_Load(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var result = ctx.TblTestResults.Include(r => r.Patient).ThenInclude(r => r.IdentityNumber)
                        .Include(r => r.Test)
                        .Where(r => r.PatientId == patientId /*&& r.ResultDate != null*/)
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
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pnlLayout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                        e.CellStyle!.BackColor = Color.FromArgb(255, 253, 190);
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
    }
}
