using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace HospitalAutomation
{
    public partial class frmForgetPasswordVerification : Form
    {      
        byte _time = 120;
        public frmForgetPasswordVerification()
        {
            InitializeComponent();
        }
        public void SendEmail(string toEmailAddress, string verificationCode)
        {
            try
            {
                // Gönderen e-posta bilgileri
                var fromAddress = new MailAddress("dfgdfg@outlook.com", "Your Name");
                var toAddress = new MailAddress(toEmailAddress);
                const string fromPassword = "aaaaaaaa"; // E-posta şifreniz
                // E-posta içeriği
                string subject = "Doğrulama Kodunuz";
                string body = $@"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <style>
        body {{
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }}
        .email-container {{
            max-width: 600px;
            margin: 0 auto;
            background-color: #ffffff;
            padding: 20px;
            border: 1px solid #e0e0e0;
            border-radius: 8px;
        }}
        .header {{
            text-align: center;
            padding: 20px 0;
        }}
        .header img {{
            width: 100px;
        }}
        .content {{
            text-align: center;
            padding: 20px;
        }}
        .content h1 {{
            color: #333333;
        }}
        .content p {{
            color: #666666;
            line-height: 1.5;
        }}
        .code {{
            display: inline-block;
            margin: 20px 0;
            padding: 10px 20px;
            font-size: 24px;
            color: #ffffff;
            background-color: #007BFF;
            border-radius: 4px;
        }}
        .footer {{
            text-align: center;
            padding: 20px;
            font-size: 12px;
            color: #999999;
        }}
    </style>
</head>
<body>
    <div class='email-container'>
        <div class='header'>
            <img src='https://via.placeholder.com/100' alt='Logo'>
        </div>
        <div class='content'>
            <h1>Doğrulama Kodunuz</h1>
            <p>Merhaba,</p>
            <p>Hesabınızı doğrulamak için aşağıdaki doğrulama kodunu kullanın:</p>
            <div class='code'>{verificationCode}</div>
            <p>Bu kodun süresi 10 dakika ile sınırlıdır. Eğer siz bu isteği yapmadıysanız lütfen bu mesajı dikkate almayın.</p>
        </div>
        <div class='footer'>
            <p>© 2024 Şirket Adı. Tüm hakları saklıdır.</p>
        </div>
    </div>
</body>
</html>";

                // SMTP istemcisi oluşturma ve ayarlarını yapma
                var smtp = new SmtpClient
                {
                    Host = "smtp.office365.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };

                // E-posta mesajını oluşturma
                var message = new MailMessage
                {
                    From = fromAddress,
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                message.To.Add(toAddress);

                smtp.Send(message);
                MessageBox.Show("Email başarıyla gönderildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Email gönderilirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SendEmail("fc19053@gmail.com", "123456");
        }
    }
}
