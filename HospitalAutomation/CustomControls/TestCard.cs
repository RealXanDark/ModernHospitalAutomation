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
    public partial class TestCard : UserControl
    {
        #region Properties
        public TestCard()
        {
            InitializeComponent();
            dgwAppointment.AutoSize = true;
        }

        private void dgwAppointment_SizeChanged(object sender, EventArgs e)
        {
            this.Height = dgwAppointment.Height + 5;
        }

        [Category("Custom Props")]
        public object DataSource
        {
            get { return dgwAppointment.DataSource; }
            set { dgwAppointment.DataSource = value; }
        }
        #endregion
    }
}
