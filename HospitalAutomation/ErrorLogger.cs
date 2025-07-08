using HospitalAutomation.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation
{
    public static class ErrorLogger
    {
        public static string LogError(Exception ex)
        {
            try
            {
                // Hata veritabanına kaydediliyor
                using (var ctx = new DbHanHospitalContext())
                {
                    var errorLog = new TblErrorLog
                    {
                        MacAddress = Global.macAddress!,
                        ErrorMessage = ex.Message,
                        ErrorStack = ex.StackTrace,
                    };

                    ctx.TblErrorLogs.Add(errorLog);
                    ctx.SaveChanges();
                }
            }
            catch (Exception logEx)
            {
                System.IO.File.AppendAllText("log.txt", logEx.ToString());
            }

            // Kullanıcı dostu mesajı göstermek için
            string userFriendlyMessage = GetFriendlyErrorMessage(ex);
            return userFriendlyMessage;
        }

        private static string GetFriendlyErrorMessage(Exception ex)
        {
            if (ex is NullReferenceException)
            {
                return "Bir işlem sırasında beklenmedik bir veri eksikliği oluştu. Lütfen destek ekibiyle iletişime geçin.";
            }
            else if (ex is SqlException)
            {
                return "Veritabanına bağlanırken bir hata oluştu. Lütfen bağlantınızı kontrol edin ya da destek ekibiyle iletişime geçin.";
            }
            else if (ex is FileNotFoundException)
            {
                return "Gerekli dosya bulunamadı. Lütfen dosya konumunu kontrol edin.";
            }
            else if (ex is UnauthorizedAccessException)
            {
                return "Yetkisiz erişim hatası. Bu işlemi yapmak için gerekli izinlere sahip olmadığınız görünüyor.";
            }
            else if (ex is InvalidOperationException)
            {
                return "Geçersiz işlem gerçekleştirildi. Lütfen tekrar deneyin.";
            }
            else
            {
                // Eğer bilinen bir hata türü değilse genel bir mesaj gösterebiliriz
                return "Beklenmeyen bir hata meydana geldi. Lütfen tekrar deneyin veya destek ekibiyle iletişime geçin.";
            }
        }
    }
}
