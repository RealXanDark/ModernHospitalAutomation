using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation
{
    public class Encryption
    {
        private static SecureString secureKey;
        private static SecureString secureIV;

        // SecureString'den byte array'e dönüştürme
        private static byte[] SecureStringToBytes(SecureString secureStr)
        {
            if (secureStr == null) throw new ArgumentNullException(nameof(secureStr));

            IntPtr strPtr = IntPtr.Zero;
            try
            {
                // SecureString'i çözerek string'e çeviriyoruz
                strPtr = Marshal.SecureStringToGlobalAllocUnicode(secureStr);
                return Encoding.UTF8.GetBytes(Marshal.PtrToStringUni(strPtr)!);
            }
            finally
            {
                // Belleği temizliyoruz
                Marshal.ZeroFreeGlobalAllocUnicode(strPtr);
            }
        }

        // SecureString'e karakter ekleme
        private static SecureString CreateSecureString(string str)
        {
            SecureString secureStr = new SecureString();
            foreach (char c in str)
            {
                secureStr.AppendChar(c);
            }
            secureStr.MakeReadOnly();
            return secureStr;
        }

        // Constructor ile SecureString key ve IV ayarlanıyor
        static Encryption()
        {
            secureKey = CreateSecureString("tRG,V_0YSncPb.9i"); // 16 karakterlik bir anahtar (128-bit)
            secureIV = CreateSecureString("#L.hMJLPc2D@AuAO");  // 16 karakterlik bir IV (128-bit)
        }

        // Veriyi şifreler
        public static byte[] Encrypt(string plainText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = SecureStringToBytes(secureKey);
                aesAlg.IV = SecureStringToBytes(secureIV);

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }

                    // Belleği temizleyin
                    Array.Clear(aesAlg.Key, 0, aesAlg.Key.Length);
                    Array.Clear(aesAlg.IV, 0, aesAlg.IV.Length);

                    return msEncrypt.ToArray();
                }
            }
        }

        // Şifrelenmiş veriyi çözer
        public static string Decrypt(byte[] cipherText)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = SecureStringToBytes(secureKey);
                aesAlg.IV = SecureStringToBytes(secureIV);

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                {
                    // Belleği temizleyin
                    Array.Clear(aesAlg.Key, 0, aesAlg.Key.Length);
                    Array.Clear(aesAlg.IV, 0, aesAlg.IV.Length);

                    return srDecrypt.ReadToEnd();
                }
            }
        }
    }
}
