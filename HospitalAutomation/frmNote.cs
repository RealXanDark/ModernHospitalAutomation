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
    public partial class frmNote : Form
    {
        public frmNote()
        {

            InitializeComponent();
            dataGridView1.AutoSize = true;
        }

        private void frmNote_Load(object sender, EventArgs e)
        {
            using (var ctx = new DbHanHospitalContext())
            {
                var x = ctx.TblAppointments.ToList();
                dataGridView1.DataSource = x;
            }
        }

        private void dataGridView1_SizeChanged(object sender, EventArgs e)
        {

        }
    }
}
