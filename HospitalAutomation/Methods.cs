using HospitalAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation
{
    internal static class Methods
    {
        public static Panel? pnl;
        public static frmMain form = new frmMain();
        public static void OpenForms(Form frm)
        {
            try
            {
                

                foreach (Control control in pnl!.Controls)
                {
                    if (control is Form)
                    {
                        ((Form)control).Close();   // Formu kapat
                        ((Form)control).Dispose(); // Bellekten serbest bırak
                    }
                }

                pnl!.Controls.Clear();
                frm.MdiParent = form;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.Dock = DockStyle.Fill;
                frm.Size = pnl.Size;
                pnl.Controls.Add(frm);
                frm.Show();
             }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi Lütfen Tekrar Dene1 :(" + ex.Message);
            }
        }
        public static void ToggleButton(Button btn, TextBox txt, Image showImage, Image hideImage)
        {
            bool isHidden = btn.Tag!.ToString() == "hide";
            btn.BackgroundImage = isHidden ? showImage : hideImage;
            btn.Tag = isHidden ? "show" : "hide";
            txt.UseSystemPasswordChar = !isHidden;
        }
        public static int CheckIdentityNumberExists(string value)
        {
            try
            {
                var encryptedValue = Encryption.Encrypt(value);
                using (var ctx = new DbHanHospitalContext())
                {
                    var dbValue = ctx.TblIdentityNumbers.SingleOrDefault(i => i.IdentityNumber == encryptedValue);
                    if (dbValue != null)
                    {
                        var isActive = ctx.TblPatients.Any(p => p.IdentityNumberId == dbValue.IdentityNumberId && !p.IsDeleted);
                        
                        if (isActive)
                        {
                            return 0;
                        }
                        else
                        {
                            return dbValue.IdentityNumberId;
                        }
                    }
                    else
                    {
                        return -1;
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }       
        public static int CheckEmailExists(string value)
        {
            try
            {
                var encryptedValue = Encryption.Encrypt(value);
                using (var ctx = new DbHanHospitalContext())
                {
                    var dbValue = ctx.TblEmailAddresses.SingleOrDefault(e => e.Email == encryptedValue);
                    if (dbValue != null)
                    {
                        var isActive = ctx.TblPatients.Any(p => p.EmailId == dbValue.EmailId && !p.IsDeleted);
                        if (isActive)
                        {
                            return 0;
                        }
                        else
                        {
                            return dbValue.EmailId;
                        }
                    }
                    else
                    {
                        return -1;
                    }
                    
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static int CheckPhoneNumberExists(string value)
        {
            try
            {
                var encryptedValue = Encryption.Encrypt(value);
                using (var ctx = new DbHanHospitalContext())
                {
                    var dbValue = ctx.TblPhoneNumbers.SingleOrDefault(p => p.PhoneNumber == encryptedValue);
                    if (dbValue != null)
                    {
                        var isActive = ctx.TblPatients.Any(p => p.PhoneNumberId == dbValue.PhoneNumberId && !p.IsDeleted);

                        if (isActive)
                        {
                            return 0;
                        }
                        else
                        {
                            return dbValue.PhoneNumberId;
                        }
                    }
                    else
                    {
                        return -1;
                    }  
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
