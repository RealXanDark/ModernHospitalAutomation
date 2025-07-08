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
    public partial class frmDoctor : Form
    {
        private Button lastClickedButton;
        private Color originalColor = Color.FromArgb(29, 53, 135);
        public frmDoctor()
        {
            InitializeComponent();
            //tmrMail.Start(); çok fazla performans harcıyor kullanılmayabilir.
            Global.AddDoctorLogAsync("Oturum Başlatıldı", $"User Id : {Global.user_id}");
        }

        private void btnAppoinment_Click(object sender, EventArgs e)
        {
            Global.AddDoctorLogAsync("Randevular Sayfasına Girildi",null!);
            changeButtonColor(btnAppoinment);
            Global.validateSession();
            frmDoctorAppointment appointment = new frmDoctorAppointment();
            Methods.OpenForms(appointment);
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {

            frmTest frmTest = new frmTest();

            frmTest.Show();

            CheckNewMail(false);
            Methods.pnl = pnlDoctorMain;
            btnAppoinment.PerformClick();    
        }
        void changeButtonColor(Button btn)
        {
            Button clickedButton = btn;
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = originalColor;
            }
            originalColor = clickedButton.BackColor;
            clickedButton.BackColor = Color.FromArgb(40, 75, 194);
            lastClickedButton = clickedButton;
        }

        private void btnMakeAnAppointment_Click(object sender, EventArgs e)
        {
            Global.AddDoctorLogAsync("Eski Ziyaretler Sayfasına Girildi", null!);
            changeButtonColor(btnPastVisit);
            Global.validateSession();
            frmDoctorOldVisit oldVisit = new frmDoctorOldVisit();
            Methods.OpenForms(oldVisit);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Global.AddDoctorLogAsync("Çıkış Yap Butonuna Basıldı", null!);
            DialogResult dialogResult = MessageBox.Show("Oturumu Kapatmak İstediğinizden Emin Misiniz?", "Oturumu Kapat", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
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
                        Properties.Settings.Default.rememberMe = false;
                        Properties.Settings.Default.Save();
                        frmMain? mainForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
                        Methods.pnl = mainForm!.pnlMain;
                        frmLogin frmLogin = new frmLogin();
                        Methods.OpenForms(frmLogin);
                    }
                }
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Global.AddDoctorLogAsync("Hesabım Sayfasına Girildi", null!);
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            Global.AddDoctorLogAsync("Mail Sayfasına Girildi", null!);
            btnMail.FlatAppearance.BorderColor = Color.FromArgb(29, 53, 135);
            changeButtonColor(btnMail);
            lastClickedButton = btnMail;
            frmMail mail = new frmMail();
            Methods.OpenForms(mail);
        }

        private void tmrMail_Tick(object sender, EventArgs e)
        {
            if (lastClickedButton == btnMail)
            {
                CheckNewMail(true);
            }
            else
            {
                CheckNewMail(false);
            }
        }
        private void CheckNewMail(bool lastClickedButton)
        {
            using (var ctx = new DbHanHospitalContext())
            {
                var mail = ctx.TblHospitalMails.Where(m => m.ReceiverId == Global.user_id && !m.IsRead).Count();
                if (mail > 0)
                {
                    btnMail.Text = $"Mail ({mail})";
                    if (!lastClickedButton)
                    {
                        btnMail.FlatAppearance.BorderSize = 1;
                        btnMail.FlatAppearance.BorderColor = Color.White;
                    }
                }
                else
                {
                    btnMail.Text = "Mail";
                }
            }
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {

        }

        private void btnTestResult_Click(object sender, EventArgs e)
        {
            Global.AddDoctorLogAsync("Test Sonuçları Sayfasına Girildi", null!);
            changeButtonColor(btnTestResult);
            Global.validateSession();
            frmPastTreatment pastTreatment = new frmPastTreatment();
            Methods.OpenForms(pastTreatment);
        }
    }
}
