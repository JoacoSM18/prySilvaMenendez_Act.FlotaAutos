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
        List<Choferes> listaChoferes = new List<Choferes>();
        public frmAgregarChofer()
        {
            InitializeComponent();
        }

        private void frmAgregarChofer_Load(object sender, EventArgs e)
        {
            mskDNI.Mask = "00000000";
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || mskDNI.Text == "" || mskNacimiento.Text == "" || mskCarnet.Text == "" || cmbSeguros.Text == "")
            {
                MessageBox.Show("Datos Incompletos, Por Favor Complete todos los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            Choferes Chofer = new Choferes();
            Chofer.Nombre = txtNombre.Text;
            Chofer.DNI = Convert.ToInt32(mskDNI.Text);
            Chofer.Nacimiento = DateTime.Parse(mskNacimiento.Text);
            Chofer.NroCarnet = Convert.ToInt32(mskCarnet.Text);
            Chofer.Seguro = cmbSeguros.Text;
            listaChoferes.Add(Chofer);
            MessageBox.Show("Chofer Agregado Correctamente", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNombre.Clear();
            mskDNI.Clear();
            mskNacimiento.Clear();
            mskCarnet.Clear();
            cmbSeguros.SelectedIndex = -1;
            txtNombre.Focus();
        }

        private void mskDNI_Click(object sender, EventArgs e)
        {
            mskDNI.SelectionStart = 0;
        }

        private void mskNacimiento_Click(object sender, EventArgs e)
        {
            mskNacimiento.SelectionStart = 0;
        }

        private void mskCarnet_Click(object sender, EventArgs e)
        {
            mskCarnet.SelectionStart = 0;
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }
    }
}
