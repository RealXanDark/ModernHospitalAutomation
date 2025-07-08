using Microsoft.IdentityModel.Protocols.OpenIdConnect;
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
    public partial class frmSettings : Form
    {
        bool isClicked = true;

        private Color selectedMainColor;
        private Color selectedUserColor;

        //private Color btnMain;
        //private Color btnUser;

        private Button? lastClickedButton;
        public frmSettings()
        {
            InitializeComponent();
            if (Properties.Settings.Default.isDarkMode)
            {
                this.BackColor = Color.FromArgb(30, 30, 30);
                btnThemeMode.Image = Properties.Resources.sun;
                btnThemeMode.Tag = "dark"; 
                btnThemeMode.Text = "Aydınlık Mod";
                btnThemeMode.ForeColor = Color.White;
                btnThemeMode.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
                btnThemeMode.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            selectedMainColor = btnMain.BackColor = Properties.Settings.Default.mainPanelColor;
            selectedUserColor = btnUser.BackColor = Properties.Settings.Default.userPanelColor;

            btnMain.BackColor = Properties.Settings.Default.mainPanelColor;
            btnMain.ForeColor = Properties.Settings.Default.mainPanelTextColor;

            btnUser.BackColor = Properties.Settings.Default.userPanelColor;
            btnUser.ForeColor = Properties.Settings.Default.userPanelTextColor;

            //lastClickedButton = btnMainColor;
            btnMain.PerformClick();
        }
        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            if (!isClicked)
            {
                int red = trackBarRed.Value;
                int green = trackBarGreen.Value;
                int blue = trackBarBlue.Value;

                txtRed.Text = red.ToString();
                txtGreen.Text = green.ToString();
                txtBlue.Text = blue.ToString();

             
                Color selectedColor = Color.FromArgb(red, green, blue);

                if (lastClickedButton == btnMain)
                {
                    var openForm = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
                    //openForm.pnlLayout.BackColor = Properties.Settings.Default.mainPanelColor;
                    foreach (var pnl in openForm!.Controls.OfType<Panel>().Where(b => b.Tag?.ToString() == "1"))
                    {
                        pnl.BackColor = selectedColor;
                    }
                    foreach (var lbl in openForm.pnlLayout.Controls.OfType<Label>().Where(b => b.Tag?.ToString() == "1"))
                    {
                        lbl.ForeColor = UpdateButtonTextColor(selectedColor);
                    }
                    if (UpdateButtonTextColor(selectedColor) == Color.White)
                    {
                        openForm.btnExit.BackgroundImage = Properties.Resources.exitWhite;
                        openForm.btnMinimized.BackgroundImage = Properties.Resources.minusWhite;
                    }
                    else
                    {
                        openForm.btnExit.BackgroundImage = Properties.Resources.exitBlack;
                        openForm.btnMinimized.BackgroundImage = Properties.Resources.minusBlack;
                    }
                    btnMain.BackColor = selectedColor;
                    btnMain.ForeColor = UpdateButtonTextColor(selectedColor);
                    selectedMainColor = selectedColor;
                }
                else if (lastClickedButton == btnUser)
                {
                    var openForm = Application.OpenForms.OfType<frmPatient>().FirstOrDefault();
                    openForm!.pnlPatient.BackColor = selectedColor;
                    foreach (var btn in openForm!.pnlPatient.Controls.OfType<Button>().Where(b => b.Tag?.ToString() == "1"))
                    {
                        btn.BackColor = selectedColor;
                        btn.ForeColor = UpdateButtonTextColor(selectedColor);
                    }
                    if (UpdateButtonTextColor(selectedColor) == Color.White)
                    {
                        openForm.btnAppoinment.Image = Properties.Resources.appointmentWhite50x50;
                        openForm.btnMakeAnAppointment.Image = Properties.Resources.makeAppointmentWhite50x50;
                        openForm.btnVisit.Image = Properties.Resources.hospitalWhite50x50;
                        openForm.btnTestResult.Image = Properties.Resources.testResultWhite50x50;
                        openForm.btnNotices.Image = Properties.Resources.notificationWhite50x50;
                        openForm.btnSettings.Image = Properties.Resources.settingsWhite50x50;
                        openForm.btnAccount.Image = Properties.Resources.userWhite50x50;
                        openForm.btnLogOut.Image = Properties.Resources.logOutWhite50x50;
                    }
                    else
                    {
                        openForm.btnAppoinment.Image = Properties.Resources.appointmentBlack50x50;
                        openForm.btnMakeAnAppointment.Image = Properties.Resources.makeAppointmentBlack50x50;
                        openForm.btnVisit.Image = Properties.Resources.hospitalBlack50x50;
                        openForm.btnTestResult.Image = Properties.Resources.testResultBlack50x50;
                        openForm.btnNotices.Image = Properties.Resources.notificationBlack50x50;
                        openForm.btnSettings.Image = Properties.Resources.settingsBlack50x50;
                        openForm.btnAccount.Image = Properties.Resources.userBlack50x50;
                        openForm.btnLogOut.Image = Properties.Resources.logOutBlack50x50;
                    }
                    btnUser.BackColor = selectedColor;
                    btnUser.ForeColor = UpdateButtonTextColor(selectedColor);
                    selectedUserColor = selectedColor;
                }
            }

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (int.TryParse(txt.Text, out int value))
            {
                if (value > 255)
                {
                    txt.Text = string.Empty; 
                }
                else
                {
                    if (txt == txtRed)
                    {
                        trackBarRed.Value = int.Parse(txt.Text);
                    }
                    else if (txt == txtGreen)
                    {
                        trackBarGreen.Value = int.Parse(txt.Text);
                    }
                    else if (txt == txtBlue)
                    {
                        trackBarBlue.Value = int.Parse(txt.Text);
                    }
                }
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Geçersiz karakteri engelle
            }
        }
        private Color UpdateButtonTextColor(Color backgroundColor)
        {
            // Arka plan rengi koyu ise beyaz, açık ise siyah metin rengi ayarla
            int brightness = (backgroundColor.R + backgroundColor.G + backgroundColor.B) / 3;
            return brightness < 128 ? Color.White : Color.Black;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mainPanelColor = selectedMainColor;
            Properties.Settings.Default.userPanelColor = selectedUserColor;
            Properties.Settings.Default.mainPanelTextColor = UpdateButtonTextColor(selectedMainColor);
            Properties.Settings.Default.userPanelTextColor = UpdateButtonTextColor(selectedUserColor);
            Properties.Settings.Default.Save();

            var openForm = Application.OpenForms.OfType<frmPatient>().FirstOrDefault();
            var color = Properties.Settings.Default.userPanelColor;
            openForm!.pnlPatient.BackColor = color;
            foreach (var btn in openForm!.pnlPatient.Controls.OfType<Button>().Where(b => b.Tag?.ToString() == "1"))
            {
                btn.BackColor = color;
                btn.ForeColor = UpdateButtonTextColor(color);
            }

            var openFormMain = Application.OpenForms.OfType<frmMain>().FirstOrDefault();
            foreach (var pnl in openFormMain!.Controls.OfType<Panel>().Where(b => b.Tag?.ToString() == "1"))
            {
                pnl.BackColor = Properties.Settings.Default.mainPanelColor;
            }
            foreach (var lbl in openFormMain.pnlLayout.Controls.OfType<Label>().Where(b => b.Tag?.ToString() == "1"))
            {
                lbl.ForeColor = Properties.Settings.Default.mainPanelTextColor;
            }
            if (Properties.Settings.Default.mainPanelTextColor == Color.White)
            {
                openFormMain.btnExit.BackgroundImage = Properties.Resources.exitWhite;
                openFormMain.btnMinimized.BackgroundImage = Properties.Resources.minusWhite;
            }
            else
            {
                openFormMain.btnExit.BackgroundImage = Properties.Resources.exitBlack;
                openFormMain.btnMinimized.BackgroundImage = Properties.Resources.minusBlack;
            }

            openForm.btnSettings.PerformClick();
        }

        private void btnMainColor_Click(object sender, EventArgs e)
        {
            changeButtonText(btnMain);
            isClicked = true;
            changeTrackbarValue(btnMain);
            isClicked = false;
        }
        private void btnUserPanel_Click(object sender, EventArgs e)
        {
            changeButtonText(btnUser);
            isClicked = true;
            changeTrackbarValue(btnUser);
            isClicked = false;
        }
        void changeButtonText(object sender)
        {

            Button clickedButton = (Button)sender;

            // Eğer son tıklanan buton varsa, "(SEÇİLİ)" kısmını kaldır
            if (lastClickedButton != null)
            {
                if (lastClickedButton.Text.EndsWith(" (SEÇİLİ)"))
                {
                    lastClickedButton.Text = lastClickedButton.Text.Substring(0, lastClickedButton.Text.Length - " (SEÇİLİ)".Length);
                }
            }

            // Şu an tıklanan butona "(SEÇİLİ)" ekle
            if (clickedButton != null)
            {
                clickedButton.Text += " (SEÇİLİ)";
                lastClickedButton = clickedButton; // Son tıklanan butonu güncelle
            }
        }
        void changeTrackbarValue(Button btn)
        {
            if (btn == btnMain)
            {
                trackBarRed.Value = selectedMainColor.R;
                trackBarGreen.Value = selectedMainColor.G;
                trackBarBlue.Value = selectedMainColor.B;

                txtRed.Text = selectedMainColor.R.ToString();
                txtGreen.Text = selectedMainColor.G.ToString();
                txtBlue.Text = selectedMainColor.B.ToString();
            }
            else if (btn == btnUser)
            {
                trackBarRed.Value = selectedUserColor.R;
                trackBarGreen.Value = selectedUserColor.G;
                trackBarBlue.Value = selectedUserColor.B;

                txtRed.Text = selectedUserColor.R.ToString();
                txtGreen.Text = selectedUserColor.G.ToString();
                txtBlue.Text = selectedUserColor.B.ToString();
            }
        }

        private void frmSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            var patient = Application.OpenForms.OfType<frmPatient>().FirstOrDefault();
            patient!.settingsFrm = false;
        }
        public void backDefaultColor()
        {
            var userForm = Application.OpenForms.OfType<frmPatient>().SingleOrDefault();
            var mainForm = Application.OpenForms.OfType<frmMain>().SingleOrDefault();

            var userFormColor = Properties.Settings.Default.userPanelColor;
            var userTextColor = Properties.Settings.Default.userPanelTextColor;

            var mainFormColor = Properties.Settings.Default.mainPanelColor;
            var mainFormTextColor = Properties.Settings.Default.mainPanelTextColor;

            foreach (var pnl in mainForm!.Controls.OfType<Panel>().Where(b => b.Tag?.ToString() == "1"))
            {
                pnl.BackColor = mainFormColor;
            }

            foreach (var lbl in mainForm.pnlLayout.Controls.OfType<Label>().Where(b => b.Tag?.ToString() == "1"))
            {
                lbl.ForeColor = mainFormTextColor;
            }

            mainForm.btnExit.BackgroundImage = mainFormTextColor == Color.White ? Properties.Resources.exitWhite : Properties.Resources.exitBlack;
            mainForm.btnMinimized.BackgroundImage = mainFormTextColor == Color.White ? Properties.Resources.minusWhite : Properties.Resources.minusBlack;

            btnMain.BackColor = mainFormColor;
            btnMain.ForeColor = mainFormTextColor;

            foreach (var btn in userForm!.pnlPatient.Controls.OfType<Button>().Where(b => b.Tag?.ToString() == "1"))
            {
                btn.BackColor = userFormColor;
                btn.ForeColor = userTextColor;
            }

            userForm.pnlPatient.BackColor = userFormColor;

            userForm.btnAppoinment.Image = userTextColor == Color.White ? Properties.Resources.appointmentWhite50x50 : Properties.Resources.appointmentBlack50x50;
            userForm.btnMakeAnAppointment.Image = userTextColor == Color.White ? Properties.Resources.makeAppointmentWhite50x50 : Properties.Resources.makeAppointmentBlack50x50;
            userForm.btnVisit.Image = userTextColor == Color.White ? Properties.Resources.hospitalWhite50x50 : Properties.Resources.hospitalBlack50x50;
            userForm.btnTestResult.Image = userTextColor == Color.White ? Properties.Resources.testResultWhite50x50 : Properties.Resources.testResultBlack50x50;
            userForm.btnNotices.Image = userTextColor == Color.White ? Properties.Resources.notificationWhite50x50 : Properties.Resources.notificationBlack50x50;
            userForm.btnSettings.Image = userTextColor == Color.White ? Properties.Resources.settingsWhite50x50 : Properties.Resources.settingsBlack50x50;
            userForm.btnAccount.Image = userTextColor == Color.White ? Properties.Resources.userWhite50x50 : Properties.Resources.userBlack50x50;
            userForm.btnLogOut.Image = userTextColor == Color.White ? Properties.Resources.logOutWhite50x50 : Properties.Resources.logOutBlack50x50;

            btnUser.BackColor = userFormColor;
            btnUser.ForeColor = userTextColor;

        }
        private void btnDefaultSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.mainPanelColor = Color.FromArgb(225, 37, 27);
            Properties.Settings.Default.mainPanelTextColor = Color.White;
            Properties.Settings.Default.userPanelColor = Color.FromArgb(29, 53, 135);
            Properties.Settings.Default.userPanelTextColor = Color.White;
            Properties.Settings.Default.Save();

            var userForm = Application.OpenForms.OfType<frmPatient>().SingleOrDefault();
            userForm!.btnSettings.PerformClick();
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            if ((string)btnColorMode2.Tag! == "off")
            {
                btnColorMode2.Image = Properties.Resources.toggleOnWhite;
                btnColorMode2.Tag = "on"; // Toggle state
                btnColorMode2.Text = "Karanlık Mod";
                btnColorMode2.ForeColor = Color.White;
                btnColorMode2.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
                btnColorMode2.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
                Properties.Settings.Default.isDarkMode = true;
                this.BackColor = Color.FromArgb(30, 30, 30);
                Properties.Settings.Default.Save();

            }
            else
            {
                btnColorMode2.Image = Properties.Resources.toggleOff;
                btnColorMode2.Tag = "off"; // Toggle state
                btnColorMode2.Text = "Aydınlık Mod";
                btnColorMode2.ForeColor = Color.Black;
                btnColorMode2.FlatAppearance.MouseOverBackColor = Color.White;
                btnColorMode2.FlatAppearance.MouseDownBackColor = Color.White;
                Properties.Settings.Default.isDarkMode = false;
                this.BackColor = Color.White;
                Properties.Settings.Default.Save();
            }
            this.ActiveControl = null;
        }

        private void btnThemeMode_Click(object sender, EventArgs e)
        {
            //if ((string)btnThemeMode.Tag! == "dark")
            //{
            //    Properties.Settings.Default.isDarkMode = true;
            //    btnThemeMode.Text = "Karanlık Mod";
            //    btnThemeMode.Image = Properties.Resources.sun;
            //    btnThemeMode.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            //    btnThemeMode.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 30, 30);
            //    btnThemeMode.ForeColor = Color.White;
            //    this.BackColor = Color.FromArgb(30, 30, 30);
            //}
            //else if ((string)btnThemeMode.Tag! == "ligth")
            //{
            //    Properties.Settings.Default.isDarkMode = false;
            //    btnThemeMode.Text = "Aydınlık Mod";
            //    btnThemeMode.Image = Properties.Resources.moon;
            //    btnThemeMode.FlatAppearance.MouseDownBackColor = Color.White;
            //    btnThemeMode.FlatAppearance.MouseDownBackColor = Color.White;
            //    btnThemeMode.ForeColor = Color.White;
            //    this.BackColor = Color.White;
            //}

            btnThemeMode.Tag = (string)btnThemeMode.Tag! == "ligth" ? "dark" : "ligth";

            string tag = btnThemeMode.Tag!.ToString()!;

            btnColorMode2.Text = tag;

            btnThemeMode.Text = tag == "ligth" ? "Karanlık Mod" : "Aydınlık Mod";
            btnThemeMode.Image = tag == "ligth" ? Properties.Resources.moon : Properties.Resources.sun;

            btnThemeMode.FlatAppearance.MouseOverBackColor = tag == "ligth" ? Color.White : Color.FromArgb(30, 30, 30);
            btnThemeMode.FlatAppearance.MouseDownBackColor = tag == "ligth" ? Color.White : Color.FromArgb(30, 30, 30);

            btnThemeMode.ForeColor = tag == "ligth" ? Color.FromArgb(30, 30, 30) : Color.White;
            this.BackColor = tag == "ligth" ? Color.White : Color.FromArgb(30, 30, 30);

            Properties.Settings.Default.isDarkMode = tag == "ligth" ? false : true;
            Properties.Settings.Default.Save();

            this.ActiveControl = null;
        }
    }
}
