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
    public partial class MailCard : UserControl
    {
        public event EventHandler? OnMailCardClicked;
        public MailCard()
        {
            InitializeComponent();
        }

        private void MailCard_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isDarkMode)
            {
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.ForeColor = Color.White;
                }
            }
        }
        public void TriggerMailCardClick()
        {
            OnMailCardClicked?.Invoke(this, EventArgs.Empty);  // Olayı tetikler
        }
        #region
        private string? _shortName;
        private string? _sender;
        private string? _subject;
        private string? _date;
        private int _mailId;

        private void MailCard_Click(object sender, EventArgs e)
        {
            OnMailCardClicked?.Invoke(this, EventArgs.Empty);
        }

        [Category("Custom Props")]
        public int MailId
        {
            get { return _mailId; }
            set { _mailId = value; }
        }
        [Category("Custom Props")]
        public string ShortName
        {
            get { return _shortName!; }
            set { _shortName = value; lblShortName.Text = value; }
        }
        [Category("Custom Props")]
        public string Sender
        {
            get { return _sender!; }
            set { _sender = value; lblSender.Text = value; }
        }
        [Category("Custom Props")]
        public string Subject
        {
            get { return _subject!; }
            set { _subject = value; lblSubject.Text = value; }
        }
        [Category("Custom Props")]
        public string Date
        {
            get { return _date!; }
            set { _date = value; lblDate.Text = value; }
        }
        #endregion
    }
}
