using HospitalAutomation.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation
{
    public partial class frmLogin : Form
    {
        TimeOnly currentTime;

        DateTime _endTime;

        private int _initialTickCount;

        private static double banRemainingSecond;

        bool isTempBan;


        public frmLogin()
        {
            
            InitializeComponent();
            _initialTickCount = Environment.TickCount;

            

        }
        public async Task PerformLoginAsync()
        {
            if (Properties.Settings.Default.rememberMe)
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var user = GetUser(ctx, Properties.Settings.Default.identityNumber, Properties.Settings.Default.password);
                    if (user != null)
                    {
                        await ProcessLoginSuccess(user, ctx); // Oturum aç
                        OpenFormBasedOnUserType(user, ctx);   // Diğer formu aç
                        return; // İşlemi tamamla, login formu açılmayacak
                    }
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            //try
            //{
            //    //string x = "asdfsadf";
            //    //int y = int.Parse(x);

            //    int loginCount = checkFailedLogin(Global.macAddress!, GetCurrentTime().AddMinutes(-5), GetCurrentTime());
            //    using (var ctx = new DbHanHospitalContext())
            //    {

            //        if (loginCount < 3)
            //        {
            //            var user = GetUser(ctx, txtIdentityNo.Text, txtPassword.Text);
            //            if (user != null)
            //            {
            //                TimeOnly start = user.UserType.TblUserAccessHour!.StartTime!.Value;
            //                TimeOnly end = user.UserType.TblUserAccessHour!.EndTime!.Value;

            //                if (user.UserTypeId == 2)
            //                {
            //                    Global.isRestrictionExempt = ctx.TblDoctors
            //                            .Where(d => d.DoctorId == user.UserId)
            //                            .Select(d => d.IsRestrictionExempt)
            //                            .FirstOrDefault();
            //                }

            //                if (currentTime >= start && currentTime <= end || Global.isRestrictionExempt)
            //                {
            //                    var sessionToken = new TblSessionToken { UserId = user.UserId, Token = GenerateToken(), TokenIsActive = true };
            //                    var log = new TblUserActivityLog { UserId = user.UserId, SessionToken = sessionToken.Token, MacAddress = Global.macAddress! };
            //                    //int patientid = ctx.TblPatients.Where(p => p.PatientIdentityNumber == user.UserIdentityNumber).Select(p => p.PatientId).FirstOrDefault();
            //                    ctx.TblSessionTokens.Add(sessionToken);
            //                    ctx.TblUserActivityLogs.Add(log);
            //                    ctx.SaveChanges();
            //                    Global.token = sessionToken.Token;
            //                    Global.isLogin = true;
            //                    //frmDoctor patient = new frmDoctor();
            //                    //Methods.OpenForms(patient);
            //                    if (user.UserTypeId == 1)
            //                    {

            //                    }
            //                    else if (user.UserTypeId == 2)
            //                    {
            //                        Global.user_id = ctx.TblDoctors.Where(d => d.DoctorIdentityNumber == user.UserIdentityNumber && d.DoctorIsActive).Select(d => d.DoctorId).SingleOrDefault();
            //                        frmDoctor frmDoctor = new frmDoctor();
            //                        Methods.OpenForms(frmDoctor);
            //                    }
            //                    else if (user.UserTypeId == 3)
            //                    {
            //                        Global.user_id = ctx.TblPatients.Where(p => p.PatientIdentityNumber == user.UserIdentityNumber && p.PatientIsDeleted == false).Select(p => p.PatientId).SingleOrDefault();
            //                        frmPatient patient = new frmPatient();
            //                        Methods.OpenForms(patient);
            //                    }
            //                }
            //                else
            //                {
            //                    DisplayMessage("Bu Saat Aralığında Erişim İzniniz Yok!");
            //                }

            //            }
            //            else
            //            {
            //                DisplayMessage("Kullanıcı Adı Veya Şifre Yanlış");
            //            }

            //        }
            //        else if (loginCount >= 3 && loginCount < 6)
            //        {
            //            DisplayMessage("Doğrulama Gerekli");
            //        }
            //        else if (loginCount == 6)
            //        {
            //            DisplayMessage("Çok Sayıda Hatalı Giriş Denemesi Yaptınız. Lütfen 5 Dakika Sonra Tekrar Deneyin.");

            //            var currentTime = GetCurrentTime();
            //            var tempBan = new TblTempBannedMacAddress { MacAddress = Global.macAddress!, BanStartTime = currentTime, BanEndTime = currentTime.AddMinutes(5) };
            //            ctx.TblTempBannedMacAddresses.Add(tempBan);
            //            ctx.SaveChanges();

            //            return;
            //        }
            //        var failedLogin = new TblFailedLoginAttempt { MacAddress = Global.macAddress!, AttemptTime = GetCurrentTime() };
            //        ctx.TblFailedLoginAttempts.Add(failedLogin);
            //        ctx.SaveChanges();

            //    }
            //}
            //catch (Exception ex)
            //{
            //    frmError frmError = new frmError(ErrorLogger.LogError(ex));
            //    frmError.StartPosition = FormStartPosition.CenterParent;
            //    frmError.OnOkButtonClick = () =>
            //    {
            //        frmError.Dispose(); // Kaynakları serbest bırak ve formu tamamen kapat
            //    };
            //    frmError.OnRetryButtonClick = () =>
            //    {
            //        frmError.Dispose();
            //        btnLogin.PerformClick();
            //    };
            //    frmError.ShowDialog(this);

            //}

            if (txtIdentityNo.Text.Length == 11 && txtPassword.Text != string.Empty)
            {
                check();
            }
            else
            {
                DisplayMessage("Kullanıcı Adı/Şifre Alanları Boş Geçilemez!");
            }
        }
        private static string GenerateToken(int size = 100)
        {
            var tokenData = new byte[size];
            RandomNumberGenerator.Fill(tokenData);
            return Convert.ToBase64String(tokenData);
        }
        void checkButtonColor()
        {
            //foreach (Button btn in this.Controls.OfType<Button>().Where(b => b.Tag?.ToString() == "1"))
            //{
            //    btn.BackColor = Properties.Settings.Default.btnColor;
            //}
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.Tag?.ToString() == "1")
                {
                    if (ctrl is Label)
                    {
                        ctrl.ForeColor = Properties.Settings.Default.mainPanelColor;
                    }
                    else
                    {
                        ctrl.BackColor = Properties.Settings.Default.mainPanelColor;
                    }

                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            try
            {
                //foreach (Control ctrl in this.Controls)
                //{
                //    ctrl.Font = new Font(Properties.Settings.Default.textFont.FontFamily, ctrl.Font.Size, ctrl.Font.Style);
                //}
                if (Properties.Settings.Default.rememberMe)
                {
                    PerformLoginAsync();
                }
                CheckTemporaryBan();
                if (isTempBan)
                {
                    DisplayMessage($"Çok Fazla Hatalı Deneme Yaptığınız İçin {((DateTime)_endTime!).ToString("dd.MM.yyyy HH:mm")} Tarihine Kadar Erişiminiz Kısıtlanmıştır!");
                    tmrCheckTempBan.Start();
                }
                else
                {
                    int loginCount = checkFailedLogin(Global.macAddress!, Global.GetCurrentTime().AddMinutes(-5), Global.GetCurrentTime());
                    if (loginCount >= 3)
                    {
                        pbCaptcha.Visible = true;
                        txtCaptcha.Visible = true;
                        pboxRefreshCaptcha.Visible = true;
                        pbCaptcha.Image = Global.GenerateComplexCaptchaImage(Global.GenerateCaptchaText(5));
                    }
                }
            }
            catch (Exception ex)
            {
                frmError frmError = new frmError(ErrorLogger.LogError(ex));
                frmError.StartPosition = FormStartPosition.CenterParent;
                frmError.ButtonSecondText = "Tamam";
                frmError.OnOkButtonClick = () =>
                {
                    frmError.Dispose(); 
                };
                frmError.OnRetryButtonClick = () =>
                {
                    frmError.Dispose();
                    Application.Restart();
                };
                frmError.ShowDialog(this);
            }

        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister();
            Methods.OpenForms(register);
        }

        private void lblForgetPassword_Click(object sender, EventArgs e)
        {
            frmForgetPassword forgetPassword = new frmForgetPassword();
            Methods.OpenForms(forgetPassword);
        }
        private void lblSendTicket_Click(object sender, EventArgs e)
        {
            frmSupportTicket frmSupportTicket = new frmSupportTicket();
            Methods.OpenForms(frmSupportTicket);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn == btnShowIdentityNumber)
            {
                Methods.ToggleButton(btn, txtIdentityNo, Properties.Resources.show, Properties.Resources.hide);
            }
            else if (btn == btnShowPassword)
            {
                Methods.ToggleButton(btn, txtPassword, Properties.Resources.show, Properties.Resources.hide);
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private DateTime GetCurrentTimeFromApi()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string apiKey = "MNPAG3GJD4FY1";
                    string url = $"http://api.timezonedb.com/v2.1/get-time-zone?key={apiKey}&format=json&by=zone&zone=Europe/Istanbul";

                    // Asenkron metodu senkron olarak bekletmek için .Result kullanıyoruz
                    HttpResponseMessage response = client.GetAsync(url).Result;
                    response.EnsureSuccessStatusCode();
                    string responseBody = response.Content.ReadAsStringAsync().Result;

                    // JSON verisini çözümle
                    var jsonDocument = JsonDocument.Parse(responseBody);
                    string currentTimeString = jsonDocument.RootElement.GetProperty("formatted").GetString()!;

                    //DateTime currentDateTime = DateTime.Parse(currentTimeString);
                    //return TimeOnly.FromDateTime(currentDateTime);

                    DateTime currentDateTime = DateTime.Parse(currentTimeString);
                    return currentDateTime;
                }
                catch (HttpRequestException ex)
                {
                    frmError frmError = new frmError(ErrorLogger.LogError(ex));
                    frmError.StartPosition = FormStartPosition.CenterParent;
                    frmError.OnOkButtonClick = () =>
                    {
                        frmError.Dispose(); 
                    };
                    frmError.OnRetryButtonClick = () =>
                    {
                        frmError.Dispose();
                        GetCurrentTimeFromApi();
                    };
                    frmError.ShowDialog(this);
                    throw;
                }
            }
        }

        
        private TblUser? GetUser(DbHanHospitalContext ctx, string identityNo, string password)
        {
            var id = ctx.TblIdentityNumbers.SingleOrDefault(i => i.IdentityNumber == Encryption.Encrypt(identityNo));
            var query = ctx.TblUsers
                //.Include(u => u.TypeId)
                .Include(u => u.IdentityNumber)
                .Where(u => u.IdentityNumberId == id.IdentityNumberId && u.Password == Encryption.Encrypt(password) && !u.IsDeleted);

            return query.FirstOrDefault();
        }
        private async Task ProcessLoginSuccess(TblUser user, DbHanHospitalContext ctx)
        {
            var locationInfo = await GetLocationByIpAsync();
            var sessionToken = new TblSessionToken { UserId = user.UserId, Token = GenerateToken(), TokenIsActive = true };
            var log = new TblUserSessionLog
            {
                UserId = user.UserId,
                MacAddress = Global.macAddress!,
                IpAddress = locationInfo.ip,
                Country = locationInfo.country,
                City = locationInfo.city,
                Location = locationInfo.loc,
                SessionToken = sessionToken.Token
            };
            if (locationInfo.country != "TR")
            {
                var mail = new TblHospitalMail
                {
                    SenderId = 1,
                    ReceiverId = user.UserId,
                    Subject = "VPN Kullanımı Hakkında",
                    Body = "{\\rtf1\\ansi\\ansicpg1254\\deff0\\nouicompat\\deflang1055{\\fonttbl{\\f0\\fnil\\fcharset162 Segoe UI;}{\\f1\\fnil\\fcharset238 Segoe UI;}{\\f2\\fnil\\fcharset0 Segoe UI;}}\r\n{\\colortbl ;\\red255\\green0\\blue0;}\r\n{\\*\\generator Riched20 10.0.22621}\\viewkind4\\uc1 \r\n\\pard\\b\\f0\\fs41 De\\f1\\u287?\\f0 erli Kullan\\f1\\u305?\\f0 c\\f1\\u305?\\f0 m\\f1\\u305?\\f0 z;\\b0\\par\r\n\\par\r\nHesab\\f1\\u305?\\f0 n\\f1\\u305?\\f0 zda \\cf1\\b VPN\\cf0  \\b0 Kullan\\f1\\u305?\\f0 m\\f1\\u305?\\f0  Tespit Edilmi\\f1\\'ba\\f0 tir. Vpn Kullan\\f1\\u305?\\f0 m\\f1\\u305?\\f0  Kullan\\f1\\u305?\\f0 m \\f1\\'aa\\f0 artlar\\f1\\u305?\\f0 m\\f1\\u305?\\f0 z Gere\\f1\\u287?\\f0 i Ve Yasalarca \\cf1\\b Yasaklanm\\f1\\u305?\\'ba\\f0 t\\f1\\u305?\\f0 r\\cf0\\b0 .\\par\r\nTekrardan Vpn Kullanmaman\\f1\\u305?\\f0 z \\f2\\lang1033\\'d6\\f0\\lang1055 nemle Rica Olunur Aksi Halde Hesab\\f1\\u305?\\f0 n\\f1\\u305?\\f0 z Ask\\f1\\u305?\\f0 ya Al\\f1\\u305?\\f0 nabilir.\\par\r\n\\par\r\nSa\\f1\\u287?\\f0 l\\f1\\u305?\\f0 kl\\f1\\u305?\\f0 , Mutlu G\\f2\\lang1033\\'fc\\f0\\lang1055 nler Dileriz.\\par\r\n\\b Han Hastaneleri.\\b0\\par\r\n}\r\n"
                };
                ctx.TblHospitalMails.Add(mail);
            }
            ctx.TblSessionTokens.Add(sessionToken);
            ctx.TblUserSessionLogs.Add(log);
            try
            {
                await ctx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
             // SaveChanges asenkron
            Global.sessionId = log.SessionId;
            Global.token = sessionToken.Token;
            Global.isLogin = true;
        }
        private void OpenFormBasedOnUserType(TblUser user, DbHanHospitalContext ctx)
        {
            if (user.TypeId == 2)
            {
                Global.type_id = 2;
                Global.user_id = ctx.TblDoctors
                    .Where(d => d.IdentityNumberId == user.IdentityNumberId && !d.IsDeleted)
                    .Select(d => d.DoctorId)
                    .SingleOrDefault();
                Methods.OpenForms(new frmDoctor());
            }
            else if (user.TypeId == 3)
            {
                Global.type_id = 3;
                Global.user_id = ctx.TblPatients
                    .Where(p => p.IdentityNumberId == user.IdentityNumberId && !p.IsDeleted)
                    .Select(p => p.PatientId)
                    .SingleOrDefault();
                Methods.OpenForms(new frmPatient());
            }
        }
        private void DisplayMessage(string message)
        {
            lblInformation.Text = message;
            lblInformation.Visible = true;
        }
        private async void check()
        {
            try
            {
                CheckTemporaryBan();
                if (!isTempBan)
                {
                    int loginCount = checkFailedLogin(Global.macAddress!, Global.GetCurrentTime().AddMinutes(-5), Global.GetCurrentTime());
                    using (var ctx = new DbHanHospitalContext())
                    {
                        if (loginCount < 3)
                        {
                            var user = GetUser(ctx, txtIdentityNo.Text, txtPassword.Text);
                            if (user == null)
                            {
                                DisplayMessage("Kullanıcı Adı Veya Şifre Yanlış");
                                AddFailedLogin();
                                if (loginCount >= 2)
                                {
                                    // 2 hatalı giriş sonrası CAPTCHA'yı göster
                                    pbCaptcha.Visible = true;
                                    txtCaptcha.Visible = true;
                                    pboxRefreshCaptcha.Visible = true;
                                    pbCaptcha.Image = Global.GenerateComplexCaptchaImage(Global.GenerateCaptchaText(5));
                                }
                            }
                            else
                            {
                                // Giriş başarılı
                                await ProcessLoginSuccess(user, ctx);
                                SaveLoginInfo(txtIdentityNo.Text, txtPassword.Text, chkRememberMe.Checked);
                                OpenFormBasedOnUserType(user, ctx);
                            }
                        }
                        else if (loginCount >= 3 && loginCount < 6)
                        {
                            // 3-5 hatalı giriş arasında CAPTCHA doğrulaması gerekiyor
                            if (txtCaptcha.Text == Global.captchaText)
                            {
                                var user = GetUser(ctx, txtIdentityNo.Text, txtPassword.Text);
                                if (user != null)
                                {
                                    await ProcessLoginSuccess(user, ctx);
                                    SaveLoginInfo(txtIdentityNo.Text, txtPassword.Text, chkRememberMe.Checked);
                                    OpenFormBasedOnUserType(user, ctx);
                                }
                                else
                                {
                                    DisplayMessage("Kullanıcı Adı Veya Şifre Yanlış");
                                    AddFailedLogin();
                                    loginCount++;  // Hatalı giriş sonrası loginCount'u arttır.
                                    pbCaptcha.Image = Global.GenerateComplexCaptchaImage(Global.GenerateCaptchaText(5));
                                }
                            }
                            else
                            {
                                DisplayMessage("Doğrulama Kodu Yanlış!");
                            }
                        }
                        else if (loginCount >= 6)
                        {
                            HandleTemporaryBan();
                            CheckTemporaryBan();
                            DisplayMessage($"Çok Fazla Hatalı Deneme Yaptığınız İçin {((DateTime)_endTime!).ToString("dd.MM.yyyy HH:mm")} Tarihine Kadar Erişiminiz Kısıtlanmıştır!");

                            pbCaptcha.Visible = false;
                            txtCaptcha.Visible = false;
                            pboxRefreshCaptcha.Visible = false;
                        }
                    }
                }
                else
                {
                    // Geçici yasak aktifse uyarı göster.
                    ShowLabel();
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda daha açıklayıcı bir mesaj yazdır.
                DisplayMessage("Bir hata meydana geldi: " + ex.Message);
            }
        }
        private int checkFailedLogin(string macAdress, DateTime time5ago, DateTime timeNow)
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var failedLogin = ctx.TblFailedLoginAttempts.Where(f => f.MacAddress == macAdress && f.AttemptTime >= time5ago && f.AttemptTime <= timeNow).Count();
                    return failedLogin;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void HandleTemporaryBan()
        {
            var time = Global.GetCurrentTime();
            using (var ctx = new DbHanHospitalContext())
            {
                var tempBan = new TblTempBannedMacAddress
                {
                    MacAddress = Global.macAddress!,
                    BanStartTime = time,
                    BanEndTime = time.AddMinutes(5)
                };
                ctx.TblTempBannedMacAddresses.Add(tempBan);
                ctx.SaveChanges();
            }
        }
        private void CheckTemporaryBan()
        {
            using (var ctx = new DbHanHospitalContext())
            {
                var tempBan = ctx.TblTempBannedMacAddresses
                                 .Where(b => b.MacAddress == Global.macAddress && b.BanEndTime > Global.GetCurrentTime())
                                 .FirstOrDefault();

                if (tempBan != null)
                {
                    isTempBan = true;
                    _endTime = tempBan.BanEndTime;
                    GetSecond();
                }
                else
                {
                    isTempBan &= false;
                }

            }
        }

        private void AddFailedLogin()
        {
            using (var ctx = new DbHanHospitalContext())
            {
                var failedLogin = new TblFailedLoginAttempt { MacAddress = Global.macAddress!, AttemptTime = Global.GetCurrentTime() };
                ctx.TblFailedLoginAttempts.Add(failedLogin);
                ctx.SaveChanges();
            }
        }
        private void pboxRefreshCaptcha_Click(object sender, EventArgs e)
        {
            pbCaptcha.Image = Global.GenerateComplexCaptchaImage(Global.GenerateCaptchaText(5));
        }
        
        private static async Task<LocationInfo> GetLocationByIpAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync("https://ipinfo.io/json");
                var locationInfo = JsonSerializer.Deserialize<LocationInfo>(response);
                return locationInfo!;
            }
        }

        private void ShowLabel()
        {
            lblInformation.Visible = false; // İlk önce gizle
            tmrLblInfo.Start(); // Timer'ı başlat
        }
        private void tmrLblInfo_Tick(object sender, EventArgs e)
        {
            lblInformation.Visible = true;
            tmrLblInfo.Stop();
        }
        private void tmrCheckTempBan_Tick(object sender, EventArgs e)
        {
            banRemainingSecond--;
            if (banRemainingSecond < 1)
            {
                DisplayMessage("Ban Kalkmıştır!");
                isTempBan = false;
                tmrCheckTempBan.Stop();
            }
        }
        //private DateTime RemoveMilliseconds(DateTime dateTime)
        //{
        //    return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
        //}
        private void GetSecond()
        {
            banRemainingSecond = (_endTime - Global.GetCurrentTime()).TotalSeconds;
            tmrCheckTempBan.Start();
        }

        private void SaveLoginInfo(string identityNo, string password, bool rememberMe)
        {
            if (rememberMe)
            {
                // Kullanıcı bilgilerini ayarlara kaydet
                Properties.Settings.Default.identityNumber = identityNo;
                Properties.Settings.Default.password = password;
                Properties.Settings.Default.rememberMe = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                // Ayarları temizle
                Properties.Settings.Default.identityNumber = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.rememberMe = false;
                Properties.Settings.Default.Save();
            }
        }

        private void frmLogin_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }

}
