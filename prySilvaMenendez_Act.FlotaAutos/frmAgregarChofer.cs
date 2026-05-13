using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySilvaMenendez_Act.FlotaAutos
{
    public partial class frmAgregarChofer : Form
    {
        public frmAgregarChofer()
        {
            InitializeComponent();
        }

        private void frmAgregarChofer_Load(object sender, EventArgs e)
        {
            mskDNI.Mask = "00000000";
        }

        private void mskCarnet_Enter(object sender, EventArgs e)
        {
            mskCarnet.SelectionStart = 0;
        }

        private void mskNacimiento_Enter(object sender, EventArgs e)
        {
            mskNacimiento.SelectionStart = 0;
        }

        private void mskDNI_Enter(object sender, EventArgs e)
        {
            mskDNI.SelectionStart = 0;
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {

        }
    }
}
