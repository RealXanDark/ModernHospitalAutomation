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
    public partial class frmQueryTicket : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool HideCaret(IntPtr hWnd);
        public frmQueryTicket()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnQueryTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentityNumber.Text.Length == 11 && txtTicketNumber.Text != string.Empty)
                {
                    using (var ctx = new DbHanHospitalContext())
                    {
                        var ticket = ctx.TblSupportTickets.Include(t => t.RequestType).Where(t => t.UserIdentityNo == long.Parse(txtIdentityNumber.Text) && t.TicketId == int.Parse(txtTicketNumber.Text)).FirstOrDefault();
                        if (ticket != null)
                        {
                            lblInformation.Visible = false;

                            pnlControls.Visible = true;

                            lblRequest.Text = $"Talep : {ticket.RequestType.RequestTypeName}";
                            lblTicketNumber.Text = $"Talep Numarası : {ticket.TicketId}";
                            lblStatus.Text = ticket.Status == 1 ? "Durum: Açık" : "Durum: Çözüldü";
                            lblLastUpdate.Text = $"Son Güncelleme : {ticket.LastUpdate.ToString("dd.MM.yyyy HH:mm")}";

                            rtbTicket.Text = ticket.Response;
                        }
                        else
                        {
                            lblInformation.Text = "Talep Bulunamadı!";
                            lblInformation.Visible = true;
                            pnlControls.Visible = false;
                        }
                    }
                }
                else
                {
                    lblInformation.Text = "Lütfen İstenen Değerleri Doğru Şekilde Giriniz!";
                    lblInformation.Visible = true;
                }
                this.ActiveControl = null;

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
            this.Close();
        }

        private void pBoxReturn_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            Methods.OpenForms(frmLogin);
        }

        private void frmQueryTicket_Load(object sender, EventArgs e)
        {

        }

        private void rtbTicket_Click(object sender, EventArgs e)
        {
            HideCaret(rtbTicket.Handle);
        }
    }
}
