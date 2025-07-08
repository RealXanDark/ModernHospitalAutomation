using HospitalAutomation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.CustomControls
{
    public partial class VisitCard : UserControl
    {
        #region Properties
        private string? _date;
        private string? _hospitalName;
        private string? _clinicName;
        private string? _doctorName;
        private string? _diagnosis;
        private string? _notes;
        private string? _evaluate;

        private int _appointmentId;
        private int _visitId;
        private int _doctorId;

        private byte? _rate;

        bool isClicked = false;
        bool isRated;

        byte? lastClicked;
        public VisitCard()
        {
            InitializeComponent();
        }
        [Category("Custom Props")]
        public int VisitId
        {
            get { return _visitId; }
            set { _visitId = value; }
        }
        [Category("Custom Props")]
        public int AppointmentId
        {
            get { return _appointmentId; }
            set { _appointmentId = value; }
        }
        [Category("Custom Props")]
        public int DoctorId
        {
            get { return _doctorId; }
            set { _doctorId = value; }
        }
        [Category("Custom Props")]
        public string? Date
        {
            get { return _date; }
            set { _date = value; lblDate.Text = value; }
        }
        [Category("Custom Props")]
        public string? HospitalName
        {
            get { return _hospitalName; }
            set { _hospitalName = value; lblHospitalName.Text = value; }
        }
        [Category("Custom Props")]
        public string? DoctorName
        {
            get { return _doctorName; }
            set { _doctorName = value; lblDoctorName.Text = value; }
        }
        [Category("Custom Props")]
        public string? ClinicName
        {
            get { return _clinicName; }
            set { _clinicName = value; lblClinicName.Text = value; }
        }
        [Category("Custom Props")]
        public string? Diagnosis
        {
            get { return _diagnosis; }
            set { _diagnosis = value; txtDiagnosis.Text = value; }
        }
        [Category("Custom Props")]
        public string? Notes
        {
            get { return _notes; }
            set { _notes = value; txtNotes.Text = value; }
        }
        [Category("Custom Props")]
        public string? Evaluate
        {
            get { return _evaluate; }
            set { _evaluate = value; txtEvaluate.Text = value; }
        }
        [Category("Custom Props")]
        public byte? Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
        private void pbStar_Click(object sender, EventArgs e)
        {
            if (!isRated)
            {
                PictureBox star = (PictureBox)sender;

                if (lastClicked == byte.Parse(star.Tag!.ToString()!))
                {
                    foreach (var item in Controls)
                    {
                        if (item is PictureBox)
                        {
                            PictureBox box = (PictureBox)item;
                            box.Image = Properties.Resources.starGray;
                        }
                    }
                    isClicked = false;
                    lastClicked = null;
                    btnRegister.Visible = false;
                    txtEvaluate.Visible = false;
                    lblEvaluate.Visible = false;
                    txtEvaluate.Text = string.Empty;
                    this.Focus();

                }
                else
                {
                    foreach (Control item in Controls)
                    {
                        if (item is PictureBox)
                        {
                            PictureBox rateStar = (PictureBox)item;
                            if (int.Parse(rateStar.Tag!.ToString()!) <= int.Parse(star.Tag!.ToString()!))
                            {
                                rateStar.Image = Properties.Resources.starYellow;
                            }
                            else if (int.Parse(rateStar.Tag!.ToString()!) >= int.Parse(star.Tag!.ToString()!))
                            {
                                rateStar.Image = Properties.Resources.starGray;
                            }
                        }
                    }
                    isClicked = true;
                    lastClicked = byte.Parse(star.Tag!.ToString()!);
                    btnRegister.Visible = true;
                    txtEvaluate.Visible = true;
                    lblEvaluate.Visible = true;
                }
            }
        }
        #endregion

        private void pbStar5_MouseHover(object sender, EventArgs e)
        {
            if (!isClicked && !isRated)
            {
                PictureBox star = (PictureBox)sender;
                foreach (Control item in Controls)
                {
                    if (item is PictureBox)
                    {
                        PictureBox rateStar = (PictureBox)item;
                        if (int.Parse(rateStar.Tag!.ToString()!) <= int.Parse(star.Tag!.ToString()!))
                        {
                            rateStar.Image = Properties.Resources.starYellow;
                        }
                        else if (int.Parse(rateStar.Tag!.ToString()!) >= int.Parse(star.Tag!.ToString()!))
                        {
                            rateStar.Image = Properties.Resources.starGray;
                        }
                    }
                }
            }
        }

        private void pbStar5_MouseLeave(object sender, EventArgs e)
        {
            if (!isClicked && !isRated)
            {
                foreach (PictureBox star in Controls.OfType<PictureBox>())
                {
                    star.Image = Properties.Resources.starGray;
                }
            }

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var visit = ctx.TblVisits.FirstOrDefault(v => v.VisitId == _visitId);
                    visit!.Rates = lastClicked;
                    visit.Comment = txtEvaluate.Text;
                    var doctorRate = ctx.TblDoctorRates.FirstOrDefault(d => d.DoctorId == _doctorId);
                    doctorRate!.TotalRating += lastClicked!.Value;
                    doctorRate.TotalRatingCount += 1;
                    ctx.SaveChanges();
                    btnRegister.Visible = false;
                }
            }
            catch (Exception)
            {

            }

        }

        private void VisitCard_Load(object sender, EventArgs e)
        {
            if (_rate != null)
            {
                isRated = true;
                foreach (PictureBox star in Controls.OfType<PictureBox>())
                {
                    if (int.Parse(star.Tag!.ToString()!) <= _rate)
                    {
                        star.Image = Properties.Resources.starYellow;
                    }
                }
                txtEvaluate.Visible = true;
                txtEvaluate.ReadOnly = true;

            }
        }

        private void btnPrescription_Click(object sender, EventArgs e)
        {
            frmPrescription prescription = new frmPrescription(_appointmentId);
            prescription.Show();
        }

        private void VisitCard_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
    }
}
