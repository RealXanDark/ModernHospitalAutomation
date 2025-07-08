using HospitalAutomation.Models;
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
    public partial class frmSupportTicket : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        public frmSupportTicket()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pnlLayout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmSupportTicket_Load(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var requesttypes = ctx.TblRequestTypes.ToList();
                    cbRequestTypes.DataSource = requesttypes;
                    cbRequestTypes.ValueMember = "RequestTypeId";
                    cbRequestTypes.DisplayMember = "RequestTypeName";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSendTicket_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdentityNumber.Text.Length == 11 && cbRequestTypes.SelectedIndex != -1)
                {
                    using (var ctx = new DbHanHospitalContext())
                    {
                        var ticket = new TblSupportTicket
                        {
                            MacAddress = Global.macAddress!,
                            UserIdentityNo = long.Parse(txtIdentityNumber.Text),
                            RequestTypeId = (byte)cbRequestTypes.SelectedValue!,
                            IssueDescription = txtIssueDescription.Text
                        };
                        ctx.TblSupportTickets.Add(ticket);
                        ctx.SaveChanges();
                        MessageBox.Show($"Destek talebiniz başarıyla kaydedildi.Talebinizi Takip Edebilmeniz İçin Talep Numarası : {ticket.TicketId}", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        returnLoginPage();
                    }
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnQueryTicket_Click(object sender, EventArgs e)
        {
            frmQueryTicket frmQueryTicket = new frmQueryTicket();
            Methods.OpenForms(frmQueryTicket);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBoxReturn_Click(object sender, EventArgs e)
        {
            returnLoginPage();
        }
        void returnLoginPage()
        {
            frmLogin frmLogin = new frmLogin();
            Methods.OpenForms(frmLogin);
        }
    }
}
