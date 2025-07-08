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

namespace HospitalAutomation
{
    public partial class frmForgetPassword : Form
    {
        public frmForgetPassword()
        {
            InitializeComponent();
        }

        private void pBoxReturn_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            Methods.OpenForms(frmLogin);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new DbHanHospitalContext())
                {
                    var identityNumber = ctx.TblIdentityNumbers.SingleOrDefault(i => i.IdentityNumber == Encryption.Encrypt(txtIdentityNo.Text));
                    var phoneNumber = ctx.TblPhoneNumbers.SingleOrDefault(i => i.PhoneNumber.SequenceEqual(Encryption.Encrypt(txtPhoneNumber.Text)));
                    var check = ctx.TblPatients.Any(p => p.IdentityNumberId == identityNumber.IdentityNumberId && p.PhoneNumberId == phoneNumber.PhoneNumberId && !p.IsDeleted);
                    if (check)
                    {
                        frmForgetPasswordVerification frmForgetPassword = new frmForgetPasswordVerification();
                        Methods.OpenForms(frmForgetPassword);
                    }
                    else
                    {
                        lblInformation.Visible = true;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi Lütfen Tekrar Dene :(");
            }
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn == btnShowIdentityNumber)
            {
                Methods.ToggleButton(btn, txtIdentityNo, Properties.Resources.show, Properties.Resources.hide);
            }
            else if (btn == btnShowPhoneNumber)
            {
                Methods.ToggleButton(btn, txtPhoneNumber, Properties.Resources.show, Properties.Resources.hide);
            }

        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
