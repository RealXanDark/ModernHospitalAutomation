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
    public partial class frmPatient : Form
    {
        private Button? lastClickedButton;
        private Color originalColor;
        public bool settingsFrm = false;
        public frmPatient()
        {
            InitializeComponent();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {

            Color panelColor = Properties.Settings.Default.userPanelColor;
            Color textColor = Properties.Settings.Default.userPanelTextColor;

            pnlPatient.BackColor = panelColor;
            foreach (var btn in pnlPatient.Controls.OfType<Button>().Where(b => b.Tag?.ToString() == "1"))
            {
                btn.BackColor = panelColor;
                btn.ForeColor = textColor;
            }
            if (textColor == Color.White)
            {
                btnAppoinment.Image = Properties.Resources.appointmentWhite50x50;
                btnMakeAnAppointment.Image = Properties.Resources.makeAppointmentWhite50x50;
                btnVisit.Image = Properties.Resources.hospitalWhite50x50;
                btnTestResult.Image = Properties.Resources.testResultWhite50x50;
                btnNotices.Image = Properties.Resources.notificationWhite50x50;
                btnSettings.Image = Properties.Resources.settingsWhite50x50;
                btnAccount.Image = Properties.Resources.userWhite50x50;
                btnLogOut.Image = Properties.Resources.logOutWhite50x50;
            }
            else if (textColor == Color.Black)
            {
                btnAppoinment.Image = Properties.Resources.appointmentBlack50x50;
                btnMakeAnAppointment.Image = Properties.Resources.makeAppointmentBlack50x50;
                btnVisit.Image = Properties.Resources.hospitalBlack50x50;
                btnTestResult.Image = Properties.Resources.testResultBlack50x50;
                btnNotices.Image = Properties.Resources.notificationBlack50x50;
                btnSettings.Image = Properties.Resources.settingsBlack50x50;
                btnAccount.Image = Properties.Resources.userBlack50x50;
                btnLogOut.Image = Properties.Resources.logOutBlack50x50;
            }
            Methods.pnl = pnlPatientMain;
            btnAppoinment.PerformClick();
        }
        private void btnAppoinment_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnAppoinment);
            Global.validateSession();
            frmAppointment appointment = new frmAppointment();
            Methods.OpenForms(appointment);
        }

        private void btnMakeAnAppointment_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnMakeAnAppointment);
            Global.validateSession();
            frmMakeAppointment makeappointment = new frmMakeAppointment();
            Methods.OpenForms(makeappointment);
        }
        private void btnVisit_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnVisit);
            Global.validateSession();
            frmVisit visit = new frmVisit();
            Methods.OpenForms(visit);
        }

        private void btnTestResult_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnTestResult);
            Global.validateSession();
            frmPatientTestResult testResult = new frmPatientTestResult();
            Methods.OpenForms(testResult);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnAccount);
            Global.validateSession();
            frmUser user = new frmUser();
            Methods.OpenForms(user);
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
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
        void changeButtonColor(Button btn)
        {
            if (settingsFrm)
            {
                frmSettings settings = new frmSettings();
                settings.backDefaultColor();
            }
            originalColor = Properties.Settings.Default.userPanelColor;
            Button clickedButton = btn;
            if (lastClickedButton != null)
            {
                lastClickedButton.BackColor = originalColor;
            }
            //originalColor = clickedButton.BackColor;
            clickedButton.BackColor = ControlPaint.Light(originalColor);
            lastClickedButton = clickedButton;
            btn.Refresh();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnSettings);
            Global.validateSession();
            frmSettings settings = new frmSettings();
            Methods.OpenForms(settings);
            settingsFrm = true;
        }

        private void btnNotices_Click(object sender, EventArgs e)
        {
            changeButtonColor(btnNotices);
            Global.validateSession();
            frmMail mail = new frmMail();
            Methods.OpenForms(mail);
        }
    }
}
