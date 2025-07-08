using HospitalAutomation.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmUser : Form
    {
        string? oldMail, oldPhone;
        bool firstLoad = true;
        public frmUser()
        {
            InitializeComponent();
            if (Properties.Settings.Default.isDarkMode)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl.Tag?.ToString() == "1")
                    {
                        if (ctrl is Label)
                        {
                            ctrl.ForeColor = Color.White;
                        }
                        //if (ctrl is TextBox) 
                        //{
                        //    ctrl.BackColor = Color.FromArgb(39,39,39);
                        //    ctrl.ForeColor = Color.White;
                        //}

                    }
                }
                this.BackColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            try
            {

                using (var ctx = new DbHanHospitalContext())
                {
                    var patient = ctx.TblPatients
                        .Include(p => p.BloodGroup)
                        .Include(p => p.Email)
                        .Include(p => p.PhoneNumber)
                        .Include(p => p.IdentityNumber)
                        .FirstOrDefault(p => p.PatientId == Global.user_id);
                    txtEMail.Text = Encryption.Decrypt(patient!.Email.Email);
                    txtPhoneNumber.Text = Encryption.Decrypt(patient!.PhoneNumber.PhoneNumber);
                    oldMail = Encryption.Decrypt(patient!.Email.Email);
                    oldPhone = Encryption.Decrypt(patient!.PhoneNumber.PhoneNumber);
                    label11.Text = Encryption.Decrypt(patient!.FirstName);
                    label12.Text = Encryption.Decrypt(patient!.LastName).ToUpper();


                    textBox1.Text = Encryption.Decrypt(patient.IdentityNumber.IdentityNumber);
                    textBox2.Text = patient.DateOfBirth.ToString();

                    label13.Text = Encryption.Decrypt(patient.IdentityNumber.IdentityNumber);
                    label14.Text = patient.DateOfBirth.ToString();
                    label15.Text = patient.BloodGroup.BloodGroupName;
                    firstLoad = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Test");
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            x();
            this.ActiveControl = null;
            //try
            //{
            //    using (var ctx = new DbHanHospitalContext())
            //    {
            //        var patient = ctx.TblPatients.FirstOrDefault(u => u.PatientId == Global.user_id);
            //        var user = ctx.TblUsers.FirstOrDefault(u => u.UserIdentityNumber == patient!.PatientIdentityNumber && u.UserIsDeleted == false);
            //        if (patient != null && user != null)
            //        {
            //            MessageBox.Show(Encryption.Decrypt(user.UserPassword) + " " + Encryption.Decrypt(Encryption.Encrypt(txtOldPassword.Text)));
            //            if (Encryption.Encrypt(txtOldPassword.Text).SequenceEqual(user.UserPassword))
            //            {
            //                if (txtNewPassword.Text != string.Empty && txtNewPasswordConfirm.Text != string.Empty)
            //                {
            //                    if (txtNewPassword.Text == txtNewPasswordConfirm.Text && txtNewPasswordConfirm.Text != string.Empty)
            //                    {
            //                        user.UserPassword = Encryption.Encrypt(txtNewPasswordConfirm.Text);
            //                    }
            //                    else if (txtNewPasswordConfirm.Text != string.Empty || txtNewPassword.Text != string.Empty)
            //                    {
            //                        lblInformation.Text = "Yeni şifreler eşleşmiyor!";
            //                        lblInformation.Visible = true;
            //                    }
            //                    else if (txtNewPassword.Text == string.Empty)
            //                    {
            //                        lblInformation.Text = "Yeni Şifre Boş Geçilemez!";
            //                        lblInformation.Visible = true;
            //                    }
            //                    else if (txtNewPasswordConfirm.Text == string.Empty)
            //                    {
            //                        lblInformation.Text = "Şifre Onay Boş Geçilemez!";
            //                        lblInformation.Visible = true;
            //                    }
            //                }
            //                if (oldMail != txtEMail.Text)
            //                {
            //                    patient.PatientEmail = Encryption.Encrypt(txtEMail.Text.Trim());
            //                }
            //                if (oldPhone != txtPhoneNumber.Text)
            //                {
            //                    patient.PatientPhoneNumber = Encryption.Encrypt(txtPhoneNumber.Text.Trim());
            //                }
            //                if (ctx.SaveChanges() == 1)
            //                {
            //                    MessageBox.Show("Bilgileriniz Başarıyla Değiştirilmiştir!");
            //                    frmUser usr = new frmUser();
            //                    Methods.OpenForms(usr);
            //                }
            //                else
            //                {
            //                    lblInformation.Text = "Değişiklikler Yapılırken Bir Hata Meydana Geldi Lütfen Tekrar Dene :(";
            //                    lblInformation.Visible = true;
            //                }
            //            }
            //            else
            //            {
            //                lblInformation.Text = "Mevcut Şifreniz Yanlış";
            //                lblInformation.Visible = true;
            //            }
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }
        private bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".com");
        }

        private void ShowErrorMessage(string message)
        {
            lblInformation.Text = message;
            lblInformation.Visible = true;
        }
        private void frmUser_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            using (var ctx = new DbHanHospitalContext())
            {
                var patient = ctx.TblPatients.FirstOrDefault(u => u.PatientId == Global.user_id);
                var user = ctx.TblUsers.FirstOrDefault(u => u.IdentityNumberId == patient!.IdentityNumberId && !u.IsDeleted);
                if (user != null)
                {
                    if (Encryption.Encrypt(txtOldPassword.Text).SequenceEqual(user.Password))
                    {
                        foreach (Control ctrl in this.Controls)
                        {
                            if ((string)ctrl.Tag! == "1" && !ctrl.Enabled)
                            {
                                ctrl.Enabled = true;
                            }
                        }
                        txtOldPassword.Enabled = false;
                        btnVerify.Enabled = false;
                        lblCurrentPassword.Enabled = false;
                        lblInfoOldPassword.Visible = false;
                        lblInformation.Visible = false;
                        btnSaveChanges.Enabled = true;
                        this.ActiveControl = null;
                    }
                    else
                    {
                        lblInformation.Text = "Mevcut Şifreniz Yanlış";
                        lblInformation.Visible = true;
                    }
                }
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            //if (!firstLoad)
            //{
            //    if (txtEMail.Text != oldMail || txtPhoneNumber.Text != oldPhone || (txtNewPassword.Text != string.Empty && txtNewPassword.Text == txtNewPasswordConfirm.Text && txtNewPassword.Text.Length >= 5))
            //    {
            //        btnSaveChanges.Enabled = true;
            //    }
            //    else if (txtEMail.Text == oldMail && txtPhoneNumber.Text == oldPhone)
            //    {
            //        btnSaveChanges.Enabled = false;
            //    }
            //}

        }
        void x()
        {
            using (var ctx = new DbHanHospitalContext())
            {
                var patient = ctx.TblPatients.FirstOrDefault(u => u.PatientId == Global.user_id);
                var user = ctx.TblUsers.FirstOrDefault(u => u.IdentityNumberId == patient!.IdentityNumberId && u.IsDeleted == false);
                if (user != null && patient != null)
                {
                    bool isChanged = false;

                    // Şifre kontrolü
                    if (!Encryption.Encrypt(txtOldPassword.Text).SequenceEqual(user.Password))
                    {
                        ShowErrorMessage("Mevcut Şifreniz Yanlış");
                        return;
                    }

                    // E-posta kontrolü ve güncellemesi
                    if (txtEMail.Text != oldMail)
                    {
                        if (IsValidEmail(txtEMail.Text))
                        {
                            var emailCheck = Methods.CheckEmailExists(txtEMail.Text.ToLower().Trim());
                            if (emailCheck == 0)
                            {
                                ShowErrorMessage("Bu E-Posta Adresi Kullanılamaz. Lütfen Farklı Bir E-Posta Deneyiniz!");
                                return;
                            }
                            else if (emailCheck == -1)
                            {
                                var email = new TblEmailAddress { Email = Encryption.Encrypt(txtEMail.Text.ToLower().Trim()) };
                                ctx.TblEmailAddresses.Add(email);
                                ctx.SaveChanges();
                                patient.EmailId = email.EmailId;
                            }
                            else
                            {
                                patient!.EmailId = emailCheck;
                            }
                            isChanged = true;
                        }
                        else
                        {
                            ShowErrorMessage("Lütfen Maili İstenilen Formatta Giriniz!");
                            return;
                        }
                    }

                    // Telefon numarası kontrolü ve güncellemesi
                    if (txtPhoneNumber.Text != oldPhone)
                    {
                        if (txtPhoneNumber.Text.Length == 10)
                        {
                            var phoneCheck = Methods.CheckPhoneNumberExists(txtPhoneNumber.Text.Trim());
                            if (phoneCheck == 0)
                            {
                                ShowErrorMessage("Bu Telefon Numarası Kullanılamaz. Lütfen Farklı Bir Telefon Numarası Deneyiniz!");
                                return;
                            }
                            else if (phoneCheck == -1)
                            {
                                var phoneNumber = new TblPhoneNumber { PhoneNumber = Encryption.Encrypt(txtPhoneNumber.Text.Trim()) };
                                ctx.TblPhoneNumbers.Add(phoneNumber);
                                ctx.SaveChanges();
                                patient!.PhoneNumberId = phoneNumber.PhoneNumberId;
                            }
                            else
                            {
                                patient!.PhoneNumberId = phoneCheck;
                            }
                            isChanged = true;
                        }
                        else
                        {
                            ShowErrorMessage("Lütfen Telefon Numarasını 10 Hane Olacak Şekilde Giriniz!");
                            return;
                        }
                    }

                    // Yeni şifre kontrolü ve güncellemesi
                    if (!string.IsNullOrEmpty(txtNewPassword.Text))
                    {
                        if (txtNewPassword.Text.Length >= 5 && txtNewPassword.Text == txtNewPasswordConfirm.Text && !Encryption.Encrypt(txtNewPassword.Text).SequenceEqual(user.Password))
                        {
                            user.Password = Encryption.Encrypt(txtNewPassword.Text);
                            isChanged = true;
                        }
                        else if (Encryption.Encrypt(txtNewPassword.Text).SequenceEqual(user.Password))
                        {
                            ShowErrorMessage("Yeni Şifre Eski Şifre İle Aynı Olamaz!");
                            return;
                        }
                        else if (txtNewPassword.Text != string.Empty && txtNewPassword.Text == txtNewPasswordConfirm.Text && txtNewPassword.Text.Length < 5)
                        {
                            ShowErrorMessage("Şifre 5 Karakterden Kısa Olamaz!");
                            return;
                        }
                        else
                        {
                            ShowErrorMessage("Yeni Şifreler Eşleşmiyor!");
                            return;
                        }
                    }

                    // Değişiklik yapıldıysa veritabanını kaydet
                    if (isChanged)
                    {
                        if (ctx.SaveChanges() > 0)
                        {
                            MessageBox.Show("Bilgileriniz Başarıyla Değiştirilmiştir!");
                            frmUser usr = new frmUser();
                            Methods.OpenForms(usr);
                        }
                        else
                        {
                            ShowErrorMessage("Değişiklikler Yapılırken Bir Hata Meydana Geldi Lütfen Tekrar Dene :(");
                        }
                    }
                    else
                    {
                        ShowErrorMessage("Herhangi bir değişiklik yapılmadı.");
                    }
                }
            }
        }
    }
}
