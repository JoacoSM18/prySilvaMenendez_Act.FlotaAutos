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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarChofer_Click(object sender, EventArgs e)
        {
            frmAgregarChofer AgregarChofer = new frmAgregarChofer();
            AgregarChofer.ShowDialog();
        }

        private void btnAgregarVehiculo_Click_1(object sender, EventArgs e)
        {
            frmAgregarVehiculo AgregarVehiculo = new frmAgregarVehiculo();
            AgregarVehiculo.ShowDialog();
        }

        private void btnAgregarAlquiler_Click(object sender, EventArgs e)
        {
            frmAgregarAlquiler AgregarAlquiler = new frmAgregarAlquiler();
            AgregarAlquiler.ShowDialog();
        }

        private void btnVerAlquileresEnCurso_Click(object sender, EventArgs e)
        {
            frmVerAlquileres VerAlquileres = new frmVerAlquileres();
            VerAlquileres.ShowDialog();
        }

        private void btnVerDatosVehiculos_Click(object sender, EventArgs e)
        {
            frmDatosVehiculos DatosVehiculos = new frmDatosVehiculos();
            DatosVehiculos.ShowDialog();
        }

        private void btnVerDatosChoferes_Click(object sender, EventArgs e)
        {
            frmDatosChoferes DatosChoferes = new frmDatosChoferes();
            DatosChoferes.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
