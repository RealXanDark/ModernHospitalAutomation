using HospitalAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace HospitalAutomation
{
    internal static class Global
    {
        public static string? token;
        public static bool isLogin = false;
        public static int user_id;
        public static int type_id;
        public static bool isRestrictionExempt;
        public static string? macAddress;
        public static string? captchaText;
        public static bool isLastOpenFormSettings;
        public static int sessionId;

        public static int _initialTickCount;
        public static DateTime _initialTime;

        public static List<TblDoctorLog> DoctorLogsList = new List<TblDoctorLog>();


        public static DateTime GetCurrentTime()
        {
            // Uygulama başlangıcından itibaren geçen süreyi milisaniye cinsinden al
            int elapsedMilliseconds = Environment.TickCount - _initialTickCount;

            // Milisaniyeyi TimeSpan'e çevir
            TimeSpan elapsedTime = TimeSpan.FromMilliseconds(elapsedMilliseconds);

            // Başlangıç zamanına geçen süreyi ekle
            return _initialTime.Add(elapsedTime);
        }

        public static async void AddDoctorLogAsync(string activityType, string parameters)
        {
            //var logEntry = new TblDoctorLog
            //{
            //    SessionId = Global.sessionId,
            //    UserId = Global.user_id,
            //    ActivityType = activityType,
            //    ActivityParameters = parameters != null ? Encryption.Encrypt(parameters) : null,
            //    Datetime = GetCurrentTime()
            //};
            //DoctorLogsList.Add(logEntry);



            using (var ctx = new DbHanHospitalContext())
            {
                var log = new TblDoctorLog
                {
                    SessionId = Global.sessionId,
                    UserId = Global.user_id,
                    ActivityType = activityType,
                    ActivityParameters = parameters != null ? Encryption.Encrypt(parameters) : null,
                    Datetime = GetCurrentTime()
                };
                ctx.Add(log);
                ctx.SaveChanges();
            }
        }


        public static void validateSession()
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {

                    if (!ctx.Database.CanConnect())
                    {
                        MessageBox.Show("Veritabanı Bağlantısı Kesildi Lütfen Tekrar Giriş Yapın!");
                        Application.Restart();
                    }
                    else
                    {
                        var tkn = ctx.TblSessionTokens.FirstOrDefault(t => t.Token == token!);
                        if (tkn == null || tkn.TokenIsActive == false || (!isRestrictionExempt && tkn.TokenCreatedAt.AddMinutes(20) < DateTime.Now))
                        {
                            MessageBox.Show("Oturumun Süresi Doldu!");
                            Application.Restart();
                        }
                    }
                    
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi Lütfen Tekrar Giriş Yapın!");
                Application.Restart();
            }
        }
        public static bool checkBlackList(string identityNumber, string macAdress)
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var blacklist = ctx.TblBlacklists.FirstOrDefault(b => b.UserIdentityNumber == long.Parse(identityNumber) || b.DeviceMacAddress == macAdress);
                    return blacklist != null;
                }
            }
            catch (Exception)
            {
                Application.Restart();
                return false;
            }
        }
        public static Bitmap GenerateComplexCaptchaImage(string text)
        {
            int width = 195;
            int height = 55;
            Bitmap bmp = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(bmp);
            Random rand = new Random();

            // Anti-aliasing etkinleştir
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Arka plan için gradient renk geçişi
            using (System.Drawing.Drawing2D.LinearGradientBrush backgroundBrush =
                   new System.Drawing.Drawing2D.LinearGradientBrush(
                       new Rectangle(0, 0, width, height),
                       Color.LightBlue, Color.White,
                       45f))
            {
                g.FillRectangle(backgroundBrush, new Rectangle(0, 0, width, height));
            }

            // Arka plan deseni ekle
            using (Pen pen = new Pen(Color.LightGray, 1))
            {
                for (int i = 0; i < 5; i++)
                {
                    g.DrawBezier(pen, new Point(rand.Next(width), rand.Next(height)),
                                      new Point(rand.Next(width), rand.Next(height)),
                                      new Point(rand.Next(width), rand.Next(height)),
                                      new Point(rand.Next(width), rand.Next(height)));
                }
            }

            // Karakterleri modern font ile çiz
            using (Font font = new Font("Calibri", 22, FontStyle.Bold))
            {
                using (Brush brush = new SolidBrush(Color.DarkSlateGray))
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        float x = 10 + i * 30;
                        float y = 10 + rand.Next(10);  // Karakterleri yukarı/aşağı kaydır
                        g.TranslateTransform(x, y);
                        g.RotateTransform(rand.Next(-25, 25)); // Karakterleri döndür
                        g.DrawString(text[i].ToString(), font, brush, 0, 0);
                        g.ResetTransform();
                    }
                }
            }

            
            using (Pen pen = new Pen(Color.Gray, 0.5f))
            {
                for (int i = 0; i < 50; i++) 
                {
                    g.DrawEllipse(pen, rand.Next(width), rand.Next(height), 2, 2);
                }
            }

            g.Dispose();
            return bmp;
        }
        public static string GenerateCaptchaText(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random rand = new Random();
            return captchaText = new string(Enumerable.Repeat(chars, length)
                .Select(s => s[rand.Next(s.Length)]).ToArray());
            
        }
        //public static void ApplyFont(Control control)
        //{
        //    
        //    foreach (Control c in control.Controls)
        //    {
        //        
        //        float currentFontSize = c.Font.Size;
        //        FontStyle currentFontStyle = c.Font.Style;

        //        
        //        c.Font = new Font(FontFamily, currentFontSize, currentFontStyle);

        //       
        //        if (c.Controls.Count > 0)
        //        {
        //            ApplyFont(c); 
        //        }
        //    }
        //}

    }
}
