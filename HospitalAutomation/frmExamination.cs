using HospitalAutomation.Models;
using HospitalAutomation.Properties;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation
{
    public partial class frmExamination : Form
    {
        private bool _isChronicDiseaseUpdating = false;
        private bool _isAllergyUpdating = false;

        private List<TblTest> _addedTest = new List<TblTest>();
        private List<TblTest> _allTest = new List<TblTest>();

        private List<TblMedication> _addedMedication = new List<TblMedication>();
        private List<TblMedication> _allMedication = new List<TblMedication>();

        private List<TblPatientChronicDisease> _existingDiseases = new List<TblPatientChronicDisease>();
        private List<TblPatientChronicDisease> _addedDiseases = new List<TblPatientChronicDisease>();
        private List<TblChronicDisease> _cbDiseases = new List<TblChronicDisease>();

        private List<TblPatientAllergy> _existingAllergy = new List<TblPatientAllergy>();
        private List<TblPatientAllergy> _addedAllergy = new List<TblPatientAllergy>();
        private List<TblAllergy> _cbAllergy = new List<TblAllergy>();

        private int id;
        private int patient_id;
        private int patientId;

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        public frmExamination(int _appointmentId)
        {
            InitializeComponent();
            id = _appointmentId;

            lbAlert.LostFocus += ListBox1_LostFocus!;
        }
        private void frmExamination_Load(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var appointment = ctx.TblAppointments.Include(a => a.Patient).ThenInclude(a => a.IdentityNumber).Include(a => a.Patient).ThenInclude(p => p.BloodGroup).FirstOrDefault(a => a.AppointmentId == id);
                    lblFirstName.Text = Encryption.Decrypt(appointment!.Patient.FirstName);
                    lblLastName.Text = Encryption.Decrypt(appointment?.Patient.LastName!);
                    lblIdentityNumber.Text = Encryption.Decrypt(appointment.Patient.IdentityNumber.IdentityNumber);
                    lblDateOfBirth.Text = appointment!.Patient.DateOfBirth.ToString();
                    lblBloodGroup.Text = appointment!.Patient.BloodGroup.BloodGroupName;
                    lblGender.Text = appointment!.Patient.Gender ? "Erkek" : "Kadın";
                    patient_id = appointment.PatientId;

                    patientId = appointment.Patient.PatientId;

                    _existingDiseases = ctx.TblPatientChronicDiseases
                        .Include(c => c.ChronicDisease)
                        .Where(c => c.PatientId == patient_id && c.IsActive)
                        .OrderByDescending(c => c.DiagnosisDate)
                        .ToList();

                    _existingAllergy = ctx.TblPatientAllergies
                        .Include(a => a.Allergy)
                        .Where(a => a.PatientId == patient_id && a.IsActive)
                        .OrderByDescending(a => a.DiagnosisDate)
                        .ToList();

                    var diseaseId = _existingDiseases
                        .Select(c => c.ChronicDiseaseId)
                        .ToList();

                    updateCbAllergy();
                    updateCbDisease();

                    updateLbDisease();
                    updateLbAllergy();

                    getMedicationcb();
                    getMedicationcb();

                    getTest();

                    checkAlert();

                    //var alergy = ctx.TblPatientAllergies.Include(a => a.Allergy).Where(a => a.PatientId == appointment.PatientUserId).ToList();
                    //foreach (var item in alergy)
                    //{
                    //    lbAlergies.Items.Add(item.Allergy!.AllergyName);
                    //}
                    //var chronic = ctx.TblPatientChronicDiseases.Include(c => c.ChronicDisease).Where(c => c.PatientUserId == appointment.PatientUserId).ToList();
                    //foreach (var item in chronic)
                    //{
                    //    lbChronicDisease.Items.Add(item.ChronicDisease!.DiseaseName);
                    //}
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void pnlLayout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Global.AddDoctorLogAsync("Muayane Ekranından Değişiklik Yapılmadan Çıkıldı",null!);
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Hasta Gelmedi Olarak İşaretlenecek Onaylıyor Musunuz?");
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            //lbPrescription.Items.Add(txtMedicineQuantity.Text.ToString() + " Adet " + cbMedicine.DisplayMember.ToString());
            //txtMedicineQuantity.Text = "1";
            //cbMedicine.Items.Remove(cbMedicine.SelectedItem);

            if (cbMedicine.SelectedItem != null)
            {
                var selectedMedication = (TblMedication)cbMedicine.SelectedItem;
                selectedMedication.Quantity = Convert.ToByte(nupMedicationQuantity.Value);
                _addedMedication.Add(selectedMedication);

                getMedicationcb();

                lbPrescription.DataSource = null;
                lbPrescription.DataSource = _addedMedication;
                lbPrescription.DisplayMember = "lbName";
                lbPrescription.ValueMember = "MedicationId";
                Global.AddDoctorLogAsync("İlaç Eklendi", $"Medication Id : {selectedMedication.MedicationId} Medication Name : {selectedMedication.MedicationName} Medication Quatity : {selectedMedication.Quantity} Patient Id : {patientId}");
            }
        }

        private void lbPrescription_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbPrescription.SelectedItem != null)
            {
                _addedMedication.Remove(_addedMedication.Find(a => a.MedicationId == Convert.ToInt32(lbPrescription.SelectedValue))!);

                getMedicationcb();

                lbPrescription.DataSource = null;
                lbPrescription.DataSource = _addedMedication;
                lbPrescription.DisplayMember = "lbName";
                lbPrescription.ValueMember = "MedicationId";

                Global.AddDoctorLogAsync("İlaç Silindi", $"Medication Id : {lbPrescription.SelectedValue} Patient Id : {patientId}");
            }
        }

        private void btnEndExamination_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var appointment = ctx.TblAppointments.FirstOrDefault(a => a.AppointmentId == id);
                    bool hasAttented = chbHasAttented.Checked;

                    if (hasAttented)
                    {
                        appointment!.StatusId = 4;
                    }
                    else
                    {
                        appointment!.StatusId = 2;

                        foreach (var medication in _addedMedication)
                        {
                            var prescription = new TblPrescription { AppointmentId = id, PatientId = patient_id, DoctorId = Global.user_id, MedicationId = medication.MedicationId, MedicationQuantity = medication.Quantity };
                            ctx.TblPrescriptions.Add(prescription);
                        }
                        foreach (var item in _existingDiseases)
                        {
                            if (item.IsDeleted)
                            {
                                var disease = ctx.TblPatientChronicDiseases.FirstOrDefault(d => d.ChronicDiseaseId == item.ChronicDiseaseId && d.IsActive)!;
                                disease.IsActive = false;
                            }
                        }
                        foreach (var disease in _addedDiseases)
                        {
                            var newDisease = new TblPatientChronicDisease
                            {
                                PatientId = disease.PatientId,
                                ChronicDiseaseId = disease.ChronicDiseaseId,
                                DiagnosisDate = disease.DiagnosisDate,
                                IsActive = true
                            };
                            ctx.TblPatientChronicDiseases.Add(newDisease);
                        }
                        foreach (var item in _existingAllergy)
                        {
                            if (item.IsDeleted)
                            {
                                var allergy = ctx.TblPatientAllergies.FirstOrDefault(a => a.AllergyId == item.AllergyId && a.IsActive)!;
                                allergy.IsActive = false;
                            }
                        }
                        if (_addedAllergy.Count != 0)
                        {
                            foreach (var allergy in _addedAllergy)
                            {
                                var newAllergy = new TblPatientAllergy
                                {
                                    PatientId = allergy.PatientId,
                                    AllergyId = allergy.AllergyId,
                                    DiagnosisDate = allergy.DiagnosisDate,
                                    IsActive = true
                                };
                                ctx.TblPatientAllergies.Add(newAllergy);
                            }
                        }
                        if (_addedTest.Count != 0)
                        {
                            foreach (var test in _addedTest)
                            {
                                var newTest = new TblTestResult
                                {
                                    AppointmentId = appointment.AppointmentId,
                                    TestId = test.TestId,
                                    DoctorId = Global.user_id,
                                    PatientId = appointment.PatientId,
                                };
                                ctx.TblTestResults.Add(newTest);
                            }
                        }
                        var visit = new TblVisit { HospitalId = appointment.HospitalId, ClinicId = appointment.ClinicId, AppointmentId = appointment.AppointmentId, DoctorId = Global.user_id, PatientId = appointment.PatientId, VisitDate = DateTime.Now, Diagnosis = txtDiagnosis.Text == string.Empty ? null : txtDiagnosis.Text, Notes = txtNotes.Text == string.Empty ? null : txtNotes.Text };
                        ctx.TblVisits.Add(visit);
                    }

                    ctx.SaveChanges();

                    Global.AddDoctorLogAsync("Muayene Bitirildi", $"Patient Id : {patientId} Appointment Id : {appointment.AppointmentId}");

                    frmDoctorAppointment doctor = new frmDoctorAppointment();
                    this.Close();
                    //doctor.btnAppoinment.PerformClick();
                    Methods.OpenForms(doctor);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lbChronicDisease_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbChronicDisease.SelectedItem != null)
            {
                var selectedDisease = lbChronicDisease.SelectedItem as TblPatientChronicDisease;
                if (selectedDisease != null)
                {


                    if (_existingDiseases.Select(d => d.ChronicDiseaseId).Contains(selectedDisease.ChronicDiseaseId))
                    {
                        selectedDisease.IsDeleted = selectedDisease.IsDeleted ? false : true;
                    }

                    if (_addedDiseases.Contains(selectedDisease))
                    {
                        _addedDiseases.Remove(selectedDisease);
                    }

                    int topIndex = lbChronicDisease.TopIndex;

                    lbChronicDisease.DataSource = null;
                    lbChronicDisease.DataSource = _existingDiseases
                        .Concat(_addedDiseases)
                        .OrderByDescending(c => c.DiagnosisDate)
                        .ToList();

                    lbChronicDisease.DisplayMember = "DisplayName";
                    lbChronicDisease.ValueMember = "ChronicDiseaseId";
                    lbChronicDisease.ClearSelected();

                    lbChronicDisease.TopIndex = topIndex;
                    Global.AddDoctorLogAsync("Hastalık Silindi", $"Disease Id : {selectedDisease!.ChronicDiseaseId} Disease Name : {selectedDisease!.ChronicDisease.DiseaseName} Patient Id : {patient_id}");
                }
                updateCbDisease();
            }
        }

        private void lbAlergies_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbAlergies.SelectedItem != null)
            {
                var selectedAllergy = lbAlergies.SelectedItem as TblPatientAllergy;
                if (selectedAllergy != null)
                {
                    if (_existingAllergy.Select(a => a.AllergyId).Contains(selectedAllergy.AllergyId))
                    {
                        selectedAllergy.IsDeleted = selectedAllergy.IsDeleted ? false : true;
                    }

                    if (_addedAllergy.Contains(selectedAllergy))
                    {
                        _addedAllergy.Remove(selectedAllergy);
                    }
                    updateLbAllergy();
                    Global.AddDoctorLogAsync("Alerji Silindi", $"Allergy Id : {selectedAllergy!.AllergyId} Allergy Name : {selectedAllergy!.Allergy.AllergyName} Patient Id : {patient_id}");
                }
                updateCbAllergy();
            }
        }
        void getTest()
        {
            using (var ctx = new DbHanHospitalContext())
            {
                cbTests.DataSource = null;
                cbTests.DataSource = ctx.TblTests
                    .Where(t => !_addedTest
                    .Select(t => t.TestId)
                    .Contains(t.TestId))
                    .OrderBy(t => t.TestName)
                    .ToList();
                cbTests.DisplayMember = "TestName";
                cbTests.ValueMember = "TestId";
            }
        }
        void getMedicationcb()
        {
            using (var ctx = new DbHanHospitalContext())
            {
                cbMedicine.DataSource = null;
                cbMedicine.DataSource = ctx.TblMedications
                    .Where(m => !_addedMedication
                    .Select(a => a.MedicationId)
                    .Contains(m.MedicationId))
                    .OrderBy(m => m.MedicationType)
                    .ThenBy(m => m.MedicationName)
                    .ToList();
                cbMedicine.DisplayMember = "cbName";
                cbMedicine.ValueMember = "MedicationId";
            }
        }

        private void pboxRefreshChronicDisease_Click(object sender, EventArgs e)
        {
            _addedDiseases.Clear();
            foreach (var disease in _existingDiseases)
            {
                disease.IsDeleted = false;
            }
            updateCbDisease();
            lbChronicDisease.DataSource = _existingDiseases;
            lbChronicDisease.DisplayMember = "DisplayName";
            lbChronicDisease.ValueMember = "ChronicDiseaseId";
            lbChronicDisease.ClearSelected();
            Global.AddDoctorLogAsync("Hastalıklar Kutusu Yeniden Yüklendi", $"Patient Id : {patientId}");
        }

        private void pboxRefreshAlergies_Click(object sender, EventArgs e)
        {
            _addedAllergy.Clear();
            foreach (var allergy in _existingAllergy)
            {
                allergy.IsDeleted = false;
            }
            updateCbAllergy();
            lbAlergies.DataSource = _existingAllergy;
            lbAlergies.DisplayMember = "DisplayName";
            lbAlergies.ValueMember = "AllergyId";
            lbAlergies.ClearSelected();
            Global.AddDoctorLogAsync("Alerjiler Kutusu Yeniden Yüklendi", $"Patient Id : {patientId}");
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            //frmDoctor doctor = Application.OpenForms.OfType<frmDoctor>().FirstOrDefault()!;
            //doctor.btnAppoinment.PerformClick();
            Global.AddDoctorLogAsync("Test Sonucu Sayfası Açıldı", $"Patient Id : {patientId}");
            frmAnalyses analyses = new frmAnalyses(patientId);
            analyses.Owner = this;
            analyses.Show();
        }

        void updateCbDisease()
        {
            using (var ctx = new DbHanHospitalContext())
            {
                _cbDiseases = ctx.TblChronicDiseases
                    .Where(c => !_addedDiseases
                    .Concat(_existingDiseases)
                    .Select(d => d.ChronicDiseaseId)
                    .Contains(c.ChronicDiseaseId))
                    .OrderBy(c => c.DiseaseName)
                    .ToList();

                cbChronicDisease.DataSource = _cbDiseases;
                cbChronicDisease.DisplayMember = "DiseaseName";
                cbChronicDisease.ValueMember = "ChronicDiseaseId";
            }
        }
        void updateCbAllergy()
        {
            using (var ctx = new DbHanHospitalContext())
            {
                _cbAllergy = ctx.TblAllergies
                    .Where(a => !_addedAllergy
                    .Concat(_existingAllergy)
                    .Select(a => a.AllergyId)
                    .Contains(a.AllergyId))
                    .OrderBy(a => a.AllergyName)
                    .ToList();

                cbAlergies.DataSource = _cbAllergy;
                cbAlergies.DisplayMember = "AllergyName";
                cbAlergies.ValueMember = "AllergyId";
            }
        }
        void updateLbAllergy()
        {
            int topIndex = lbAlergies.TopIndex;

            lbAlergies.DataSource = null;
            lbAlergies.DataSource = _existingAllergy
                .Concat(_addedAllergy)
                .OrderByDescending(c => c.DiagnosisDate)
                .ToList();

            lbAlergies.DisplayMember = "DisplayName";
            lbAlergies.ValueMember = "AllergyId";

            lbAlergies.ClearSelected();
            lbAlergies.TopIndex = topIndex;
        }
        void updateLbDisease()
        {
            int topIndex = lbChronicDisease.TopIndex;

            lbChronicDisease.DataSource = null;
            lbChronicDisease.DataSource = _existingDiseases
                        .Concat(_addedDiseases)
                        .OrderByDescending(c => c.DiagnosisDate)
                        .ToList();

            lbChronicDisease.DisplayMember = "DisplayName";
            lbChronicDisease.ValueMember = "ChronicDiseaseId";

            lbChronicDisease.ClearSelected();
            lbChronicDisease.TopIndex = topIndex;
        }
        void updateLbTest()
        {
            int topIndex = lbTest.TopIndex;

            lbTest.DataSource = null;
            lbTest.DataSource = _addedTest
                .OrderByDescending(t => t.AddedDate)
                .ToList();

            lbTest.DisplayMember = "TestName";
            lbTest.ValueMember = "TestId";

            lbTest.ClearSelected();
            lbTest.TopIndex = topIndex;
        }

        private void btnAddDisease_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbChronicDisease.SelectedValue! != null)
                {
                    using (var ctx = new DbHanHospitalContext())
                    {
                        var chronicDiseaseId = int.Parse(cbChronicDisease.SelectedValue!.ToString()!);
                        var chronicDisease = ctx.TblChronicDiseases.Find(chronicDiseaseId);

                        _addedDiseases.Add(new TblPatientChronicDisease
                        {
                            PatientId = patient_id,
                            ChronicDiseaseId = chronicDiseaseId,
                            DiagnosisDate = DateTime.Now,
                            IsActive = true,
                            ChronicDisease = chronicDisease!,
                            IsNew = true,
                        });
                        updateLbDisease();
                        Global.AddDoctorLogAsync("Hastalık Eklendi", $"Disease Id : {chronicDisease!.ChronicDiseaseId} Disease Name : {chronicDisease!.DiseaseName} Patient Id : {patient_id}");
                    }
                    updateCbDisease();

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnAddAllergy_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbAlergies.SelectedValue != null)
                {
                    using (var ctx = new DbHanHospitalContext())
                    {
                        var allergyId = int.Parse(cbAlergies.SelectedValue!.ToString()!);
                        var allergy = ctx.TblAllergies.Find(allergyId);

                        _addedAllergy.Add(new TblPatientAllergy
                        {
                            PatientId = patient_id,
                            AllergyId = allergyId,
                            DiagnosisDate = DateTime.Now,
                            IsActive = true,
                            Allergy = allergy!,
                            IsNew = true,
                        });
                        updateLbAllergy();
                        Global.AddDoctorLogAsync("Alerji Eklendi", $"Allergy Id : {allergy!.AllergyId} Allergy Name : {allergy!.AllergyName} Patient Id : {patient_id}");
                    }
                    updateCbAllergy();
                }

            }
            catch (Exception)
            {

            }
        }

        private void chbHasAttented_CheckedChanged(object sender, EventArgs e)
        {
            if (chbHasAttented.Checked)
            {
                Global.AddDoctorLogAsync("Hasta Gelmedi Olarak İşaretlendi", $"Patient Id : {patientId}");
            }
            else
            {
                Global.AddDoctorLogAsync("Hasta Gelmedi İşareti Kaldırıldı", $"Patient Id : {patientId}");
            }
        }
        private void ListBox1_LostFocus(object sender, EventArgs e)
        {
            lbAlert.ClearSelected(); // Seçili öğeleri kaldır
        }
        void checkAlert()
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var alert = ctx.TblPatientChronicDiseases.Include(c => c.ChronicDisease).Where(c => c.PatientId == patient_id && c.ChronicDisease.AlertRequired && c.IsActive).Select(c => c.ChronicDisease.DiseaseName).ToList();

                    foreach (var x in alert)
                    {
                        lbAlert.Items.Add($"{x} POZİTİF ÖNLEM AL!!!");
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void btnAddTest_Click(object sender, EventArgs e)
        {
            if (cbTests.SelectedValue != null)
            {
                var selectedTest = (TblTest)cbTests.SelectedItem!;
                selectedTest.AddedDate = DateTime.Now;
                _addedTest.Add(selectedTest);
                getTest();
                updateLbTest();
                Global.AddDoctorLogAsync("Test Eklendi", $"Test Id : {selectedTest.TestId} Test Name : {selectedTest.TestName} Patient Id : {patient_id}");
            }

        }

        private void lbTest_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lbTest.SelectedItem != null)
            {
                var selectedTest = lbTest.SelectedItem as TblTest;
                if (selectedTest != null)
                {

                    if (_addedTest.Contains(selectedTest))
                    {
                        _addedTest.Remove(selectedTest);
                    }
                    updateLbTest();
                }
                getTest();
                Global.AddDoctorLogAsync("Test Silindi", $"Test Id : {selectedTest!.TestId} Test Name : {selectedTest.TestName} Patient Id : {patientId}");
            }
        }


        private void txtDiagnosis_Enter(object sender, EventArgs e)
        {
            Global.AddDoctorLogAsync("Tanı Kutucuğuna Girildi", null!);
        }

        private void txtDiagnosis_Leave(object sender, EventArgs e)
        {
            Global.AddDoctorLogAsync("Tanı Kutucuğundan Çıkıldı", $"Diagnosis : {txtDiagnosis.Text}");
        }

        private void txtNotes_Enter(object sender, EventArgs e)
        {
            Global.AddDoctorLogAsync("Not Kutucuğuna Girildi", null!);
        }

        private void txtNotes_Leave(object sender, EventArgs e)
        {
            Global.AddDoctorLogAsync("Not Kutucuğundan Çıkıldı", $"Notes : {txtNotes.Text}");
        }
    }
}
