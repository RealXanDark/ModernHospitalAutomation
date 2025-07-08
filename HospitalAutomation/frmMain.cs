using HospitalAutomation.Models;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;

namespace HospitalAutomation
{
    public partial class frmMain : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();
        public frmMain()
        {
            InitializeComponent();
        }

        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            DialogResult dialogResult = MessageBox.Show("Çýkmak istiyor musunuz?", "Çýkýþ", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (Global.isLogin)
                {
                    using (var ctx = new DbHanHospitalContext())
                    {
                        DateTime time = DateTime.Now;
                        var sessionToken = ctx.TblSessionTokens.FirstOrDefault(t => t.Token == Global.token);
                        if (sessionToken != null)
                        {
                            sessionToken.TokenExpiresAt = time;
                            sessionToken.TokenIsActive = false;
                        }
                        var log = ctx.TblUserSessionLogs.FirstOrDefault(l => l.SessionToken == Global.token);
                        if (log != null)
                        {
                            log.LogoutTime = time;
                            log.SessionDuration = (long)(time - log.LoginTime).TotalMilliseconds;
                            ctx.SaveChanges();
                            Global.AddDoctorLogAsync("Oturum Kapatýldý", $"User Id : {Global.user_id}");
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    Application.Exit();
                }

            }

           
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlLayout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CheckDatabaseConnection();
            foreach (var pnl in this.Controls.OfType<Panel>().Where(b => b.Tag?.ToString() == "1"))
            {
                pnl.BackColor = Properties.Settings.Default.mainPanelColor;
            }
            foreach (var lbl in pnlLayout.Controls.OfType<Label>().Where(b => b.Tag?.ToString() == "1"))
            {
                lbl.ForeColor = Properties.Settings.Default.mainPanelTextColor;
            }
            if (Properties.Settings.Default.mainPanelTextColor == Color.White)
            {
                btnExit.BackgroundImage = Properties.Resources.exitWhite;
                btnMinimized.BackgroundImage = Properties.Resources.minusWhite;
            }
            else
            {
                btnExit.BackgroundImage = Properties.Resources.exitBlack;
                btnMinimized.BackgroundImage = Properties.Resources.minusBlack;
            }

            Methods.pnl = this.pnlMain;
            frmLogin frm = new frmLogin();
            Methods.OpenForms(frm);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var ctx = new DbHanHospitalContext())
            {
                ctx.TblDoctorLogs.AddRange(Global.DoctorLogsList!);
                ctx.SaveChanges();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //using (var ctx = new DbHanHospitalContext())
            //{
            //    ctx.TblDoctorLogs.AddRange(Global.DoctorLogsList!);
            //    ctx.SaveChanges();
            //}
        }
        private void CheckDatabaseConnection()
        {
            try
            {
                using (var context = new DbHanHospitalContext())
                {
                    if (!context.Database.CanConnect()) //veritabaný baðlantýsý kontrolü
                    {
                        throw new Exception("Veritabaný baðlantýsý baþarýsýz.");
                    }
                }
            }
            catch (Exception ex)
            {

                frmError errorForm = new frmError(ex.Message);
                errorForm.ButtonSecondText = "Kapat";
                // Butona basýldýðýnda önce form kapanýr, ardýndan baðlantý tekrar kontrol edilir
                errorForm.OnOkButtonClick = () =>
                {
                    Application.Exit();
                };
                errorForm.OnRetryButtonClick = () =>
                {
                    Application.Restart();
                };
                
                errorForm.ShowDialog();
            }
        }
    }
}
