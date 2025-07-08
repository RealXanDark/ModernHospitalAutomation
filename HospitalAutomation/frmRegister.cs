using HospitalAutomation.Models;
using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidateUser;

namespace HospitalAutomation
{
    public partial class frmRegister : Form
    {
        bool gender;
        public frmRegister()
        {
            InitializeComponent();
            loadBloodGroup();
        }

        private void pBoxReturn_Click(object sender, EventArgs e)
        {
            openMainForm();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                int day = int.Parse(cbDay.SelectedItem!.ToString()!);
                int month = int.Parse((cbMonth.SelectedIndex + 1).ToString());
                int year = int.Parse(cbYear.SelectedItem!.ToString()!);

                DateOnly selectedDate = new DateOnly(year, month, day);

                KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                var result = client.TCKimlikNoDogrulaAsync(long.Parse(txtIdentityNo.Text), txtName.Text, txtSurname.Text, selectedDate.Year).Result;
                if (result.Body.TCKimlikNoDogrulaResult)
                {
                    using (var ctx = new DbHanHospitalContext())
                    {
                        // Kimlik, e-posta ve telefon numarası kontrolleri
                        var identityCheck = Methods.CheckIdentityNumberExists(txtIdentityNo.Text.Trim());
                        var emailCheck = Methods.CheckEmailExists(txtEMail.Text.ToLower().Trim());
                        var phoneCheck = Methods.CheckPhoneNumberExists(txtPhoneNumber.Text.Trim());

                        if (identityCheck == 0)
                        {
                            lblInformation.Text = "Girilen Kimlik Bilgileriyle Bir Hesap Zaten Mevcut. Lütfen Hesabınıza Giriş Yapınız!";
                            lblInformation.Visible = true;
                            return;
                        }

                        if (emailCheck == 0)
                        {
                            lblInformation.Text = "Bu E-Posta Adresi Kullanılamaz. Lütfen Farklı Bir E-Posta Deneyiniz!";
                            lblInformation.Visible = true;
                            return;
                        }

                        if (phoneCheck == 0)
                        {
                            lblInformation.Text = "Bu Telefon Numarası Kullanılamaz. Lütfen Farklı Bir Telefon Numarası Deneyiniz!";
                            lblInformation.Visible = true;
                            return;
                        }

                        bool isChanged = false;

                        // Yeni kimlik, e-posta ve telefon numarası ekleme işlemleri
                        if (identityCheck == -1)
                        {
                            var identityNumber = new TblIdentityNumber { IdentityNumber = Encryption.Encrypt(txtIdentityNo.Text) };
                            ctx.TblIdentityNumbers.Add(identityNumber);
                            isChanged = true;
                        }

                        if (emailCheck == -1)
                        {
                            var email = new TblEmailAddress { Email = Encryption.Encrypt(txtEMail.Text.ToLower().Trim()) };
                            ctx.TblEmailAddresses.Add(email);
                            isChanged = true;
                        }

                        if (phoneCheck == -1)
                        {
                            var phoneNumber = new TblPhoneNumber { PhoneNumber = Encryption.Encrypt(txtPhoneNumber.Text.Trim()) };
                            ctx.TblPhoneNumbers.Add(phoneNumber);
                            isChanged = true;
                        }

                        // Eğer yeni kayıt yapıldıysa değişiklikleri kaydet
                        if (isChanged)
                        {
                            ctx.SaveChanges();
                        }

                        // Yeni kullanıcı ve hasta kayıtları
                        var user = new TblUser
                        {
                            IdentityNumberId = Methods.CheckIdentityNumberExists(txtIdentityNo.Text),
                            Password = Encryption.Encrypt(txtPassword.Text),
                            TypeId = 3 // Hasta türü olarak sabit değer girilmiş
                        };

                        var patient = new TblPatient
                        {
                            IdentityNumberId = Methods.CheckIdentityNumberExists(txtIdentityNo.Text),
                            FirstName = Encryption.Encrypt(txtName.Text.ToLower().Trim()),
                            LastName = Encryption.Encrypt(txtSurname.Text.ToLower().Trim()),
                            DateOfBirth = selectedDate,
                            Gender = rbGenderMale.Checked ? true : false,
                            BloodGroupId = (byte)cbBloodGroup.SelectedValue!,
                            EmailId = Methods.CheckEmailExists(txtEMail.Text.ToLower().Trim()),
                            PhoneNumberId = Methods.CheckPhoneNumberExists(txtPhoneNumber.Text.ToLower().Trim())
                        };

                        ctx.TblPatients.Add(patient);
                        ctx.TblUsers.Add(user);

                        using (var transaction = ctx.Database.BeginTransaction())
                        {
                            try
                            {
                                if (ctx.SaveChanges() > 0)
                                {
                                    transaction.Commit();
                                    MessageBox.Show("Kayıt Başarılı");
                                    openMainForm();
                                }
                                else
                                {
                                    MessageBox.Show("Kayıt Sırasında Hata Oluştu. Lütfen Tekrar Deneyin.");
                                }
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"Kayıt sırasında bir hata oluştu: {ex.Message}");
                            }
                        }
                    }

                }
                else
                {
                    lblInformation.Text = "Kimlik Bilgileri Doğrulanamadı Lütfen Tekrar Deneyin!";
                    lblInformation.Visible = true;
                }

            }
            catch (Exception ex)
            {
                Clipboard.SetText(ex.Message);
                MessageBox.Show("Kayıt Sırasında Hata Oluştu Lütfen Tekrar Dene :(");
            }
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            for (int i = 2024; i > 1904; i--)
            {
                cbYear.Items.Add(i);
            }

        }

        void loadBloodGroup()
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var _bloodGroup = ctx.TblBloodGroups.ToList();
                    cbBloodGroup.DataSource = _bloodGroup;
                    cbBloodGroup.DisplayMember = "BloodGroupName";
                    cbBloodGroup.ValueMember = "BloodGroupId";
                    cbBloodGroup.SelectedItem = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi Lütfen Tekrar Dene :(");
            }
            //var bloodGroups = new List<KeyValuePair<string, byte>>()
            //{
            //      new KeyValuePair<string, byte>("O-", 1),
            //      new KeyValuePair<string, byte>("O+", 2),
            //      new KeyValuePair<string, byte>("A-", 3),
            //      new KeyValuePair<string, byte>("A+", 4),
            //      new KeyValuePair<string, byte>("AB-", 5),
            //      new KeyValuePair<string, byte>("AB+", 6),
            //      new KeyValuePair<string, byte>("B-", 7),
            //      new KeyValuePair<string, byte>("B+", 8),                                                    
            //};

            //// 2. ComboBox'ın DataSource özelliğini ayarlayın
            //cbBloodGroup.DataSource = bloodGroups;
            //cbBloodGroup.DisplayMember = "Value";
            //cbBloodGroup.ValueMember = "Key";
        }
        void openMainForm()
        {
            frmLogin frmLogin = new frmLogin();
            Methods.OpenForms(frmLogin);
        }
        public async Task<LocationInfo> GetLocationByIpAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetStringAsync("https://ipinfo.io/json");
                var locationInfo = JsonSerializer.Deserialize<LocationInfo>(response);
                return locationInfo!;
            }
        }

        private void cbDay_DropDown(object sender, EventArgs e)
        {

        }
    }
}
