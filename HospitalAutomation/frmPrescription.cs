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

namespace HospitalAutomation
{
    public partial class frmPrescription : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        int _id;

        public frmPrescription(int _appointmentId)
        {
            InitializeComponent();
            _id = _appointmentId;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void frmPrescription_Load(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var prescription = ctx.TblPrescriptions
                        .Include(p => p.Medication)
                        .Where(p => p.AppointmentId == _id)
                        .Select(p => new
                        {
                            p.PrescriptionCreationDate.Date,
                            p.Medication.MedicationName,
                            p.MedicationQuantity
                        })
                        .ToList();
                    dgwPrescription.DataSource = prescription;
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
    }
}
