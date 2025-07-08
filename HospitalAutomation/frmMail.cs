using HospitalAutomation.CustomControls;
using HospitalAutomation.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace HospitalAutomation
{
    public partial class frmMail : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool HideCaret(IntPtr hWnd);
        public frmMail()
        {
            InitializeComponent();
            if (Properties.Settings.Default.isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                pboxRefreshMail.Image = Properties.Resources.refreshWhite;
                rtbMail.BackColor = Color.FromArgb(30,30,30);
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Label)
                    {
                        ctrl.ForeColor = Color.White;
                    }
                }
            }
        }

        private void frmMail_Load(object sender, EventArgs e)
        {

            try
            {
                LoadOldMail();
                if (flpMail.Controls.Count > 0)
                {
                    var firstCard = flpMail.Controls[0] as MailCard;
                    if (firstCard != null)
                    {
                        firstCard.TriggerMailCardClick(); // İlk kontrolün tıklama olayını tetikle
                    }
                }  
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //using (var ctx = new DbHanHospitalContext())
            //{
            //    var mail = new TblHospitalMail { SenderId = 1,ReceiverId = 17, Subject = "Merhaba", Body = rtbMail.Rtf!};
            //    ctx.TblHospitalMails.Add(mail);
            //    ctx.SaveChanges();
            //}

            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    // Başlık bilgilerini tanımla
                    string sende2r = "Gönderen: ali@example.com";
                    string recipient = "Alıcı: veli@example.com";
                    string date = "Tarih: 13 Eylül 2024";
                    string subject = "Konu: Proje Güncellemesi";

                    // Başlık kısmını RTF formatında hazırla
                    string headerRtf = $@"
        {{\rtf1\ansi\ansicpg1254\deff0\nouicompat\deflang1055
        {{\fonttbl{{\f0\fnil\fcharset162 Arial;}}}}
        {{\colortbl ;\red0\green0\blue128;\red0\green0\blue0;\red0\green100\blue0;\red255\green0\blue0;\red128\green128\blue128;}}
        \viewkind4\uc1 
        \pard\cf1\b\f0\fs28 {subject}\par
        \par
        \f0\fs24 {sende2r}\par
        {recipient}\par
        {date}\par
        \par
        \pard\par
        }}";

                    
                    string bodyContentRtf = @"\pard\f0\fs20 Bu bir deneme e-postasıdır.\par";

                    // Başlık ve body içeriğini birleştir
                    string fullRtf = headerRtf + bodyContentRtf;

                    // Veritabanına kaydet
                    var newMail = new TblHospitalMail
                    {
                        SenderId = 1,
                        ReceiverId = 2,
                        SentDateTime = DateTime.Now,
                        Subject = "Proje Güncellemesi",
                        Body = fullRtf
                    };

                    ctx.TblHospitalMails.Add(newMail);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void LoadMail(int id)
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    string? receiverName, identityNo = null, senderName = null;
                    //if (Global.type_id == 3)
                    //{
                    //    var user = ctx.TblPatients.SingleOrDefault(p => p.PatientId == Global.user_id);
                    //    receiverName = Encryption.Decrypt(user!.PatientFirstName) + " " + Encryption.Decrypt(user.PatientLastName);
                    //    identityNo = Encryption.Decrypt(user.PatientIdentityNumber);
                    //}
                    //else
                    //{
                    //    receiverName = null;
                    //}
                    var mail = ctx.TblHospitalMails.Where(m => m.MailId == id).FirstOrDefault();
                    if (mail != null)
                    {
                        var sender = ctx.TblUsers.SingleOrDefault(u => u.UserId == mail.SenderId);
                        if (sender.TypeId == 2)
                        {
                            var doctor = ctx.TblDoctors.SingleOrDefault(d => d.DoctorId == sender.UserId);
                            senderName = doctor.DoctorFullName;
                        }

                       
                        string filledRtf = mail.Body
                            .Replace("{user.IdentityNumber\\}", identityNo)
                            .Replace("{ticket.number\\}", "12345");
                        rtbMail.Rtf = filledRtf;
                        lblSender.Text = $"Gönderen : {(mail.SenderId == 0 ? "Sistem" : mail.SenderId.ToString())}";
                        lblReceiver.Text = $"Alıcı : {senderName/*receiverName*/}";
                        lblDate.Text = $"Tarih : {mail.SentDateTime}";
                        lblSubject.Text = $"Konu : {mail.Subject}";
                        ChangeBlackTextToWhiteIfDarkMode(rtbMail, Properties.Settings.Default.isDarkMode);
                        mail.IsRead = true;
                        ctx.SaveChanges();
                        Clipboard.SetText(rtbMail.Text);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void LoadOldMail()
        {
            flpMail.Controls.Clear();
            using (var ctx = new DbHanHospitalContext())
            {
                string? senderName = null;

                //var patient = ctx.TblPatients.SingleOrDefault(p => p.PatientId == Global.user_id);
                //var user = ctx.TblUsers.SingleOrDefault(u => u.IdentityNumberId == patient.IdentityNumberId);
                var mail = ctx.TblHospitalMails.Where(m => m.ReceiverId == Global.user_id).OrderByDescending(m => m.SentDateTime).ToList();

                if (mail != null)
                {
                    foreach (var x in mail)
                    {
                        var sender = ctx.TblUsers.SingleOrDefault(u => u.UserId == x.SenderId);
                        string mailTemp = "";
                        if (sender.TypeId == 2)
                        {
                            var doctor = ctx.TblDoctors.SingleOrDefault(d => d.IdentityNumberId == sender.IdentityNumberId);
                            var mails = ctx.TblEmailAddresses.Single(m => m.EmailId == doctor.EmailId);
                            mailTemp = Encryption.Decrypt(mails.Email);
                        }
                        
                        MailCard card = new MailCard();
                        card.ShortName = senderName.ToUpper();
                        card.Sender = mailTemp;
                        card.Subject = x.Subject;
                        card.Date = x.SentDateTime.ToString();
                        card.MailId = x.MailId; // MailId'yi ayarlıyoruz

                       
                        card.OnMailCardClicked += (s, ev) =>
                        {
                            
                            int selectedMailId = card.MailId;
                            
                            LoadMail(selectedMailId);
                        };

                        
                        flpMail.Controls.Add(card);
                    }
                }
            }
        }
        private void ChangeBlackTextToWhiteIfDarkMode(RichTextBox richTextBox, bool isDarkMode)
        {
            //if (isDarkMode) // Dark mode kontrolü
            //{
            //    // RichTextBox'ın metnini ve mevcut rengi al
            //    int originalSelectionStart = richTextBox.SelectionStart;
            //    int originalSelectionLength = richTextBox.SelectionLength;

            //    // Metni döngü ile kontrol et
            //    for (int i = 0; i < richTextBox.TextLength; i++)
            //    {
            //        // Seçili metni kontrol et
            //        richTextBox.Select(i, 1); // Sadece bir karakteri seç

            //        // Eğer karakterin rengi siyah ise
            //        if (richTextBox.SelectionColor == Color.Black)
            //        {
            //            // Rengini beyaz yap
            //            richTextBox.SelectionColor = Color.White;
            //        }
            //    }

            //    // Seçimi eski haline getir
            //    richTextBox.Select(originalSelectionStart, originalSelectionLength);
            //}
            if (isDarkMode)
            {
                int textLength = richTextBox.TextLength;

                // RichTextBox'ı güncellemek için bu işlemi suspend ediyoruz (performans için)
                richTextBox.SuspendLayout();

                // Tüm metin boyunca döngü ile her karakterin rengini kontrol ediyoruz
                for (int i = 0; i < textLength; i++)
                {
                    // Her karakteri teker teker seçiyoruz
                    richTextBox.Select(i, 1);

                    // Eğer seçilen metnin rengi siyahsa
                    if (richTextBox.SelectionColor == Color.Black)
                    {
                        // Rengi beyaz yap
                        richTextBox.SelectionColor = Color.White;
                    }
                }

                // Seçimi kaldırmak ve RichTextBox'ı tekrar güncellemeye başlamak için
                richTextBox.DeselectAll();
                richTextBox.ResumeLayout();
            }
            
        }
        private void rtbMail_Click(object sender, EventArgs e)
        {
            HideCaret(rtbMail.Handle);
        }

        private void rtbMail_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void rtbMail_SelectionChanged(object sender, EventArgs e)
        {
            HideCaret(rtbMail.Handle);
        }

        private void rtbMail_Enter(object sender, EventArgs e)
        {
            HideCaret(rtbMail.Handle);
        }

        private void pboxRefreshMail_Click(object sender, EventArgs e)
        {
            LoadOldMail();
        }

        private void btnLoadMore_Click(object sender, EventArgs e)
        {
            ChangeBlackTextToWhiteIfDarkMode(rtbMail,true);
        }
    }
}
