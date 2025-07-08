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
    public partial class frmError : Form
    {

        #region

        private string? _btnFirstText;
        private string? _btnSecondText;

        [Category("Custom Props")]
        public string ButtonFirstText
        {
            get { return _btnFirstText!; }
            set { _btnFirstText = value; btnRetry.Text = value; }
        }
        [Category("Custom Props")]
        public string ButtonSecondText
        {
            get { return _btnSecondText!; }
            set { _btnSecondText = value; btnOk.Text = value; }
        }

        #endregion


        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

        public Action? OnOkButtonClick { get; set; }
        public Action? OnRetryButtonClick { get; set; }
        public frmError(string errorText)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblInformation.Text = errorText!;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            OnOkButtonClick?.Invoke();
        }
        private void pnlLayout_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            OnRetryButtonClick?.Invoke();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
    }
}
