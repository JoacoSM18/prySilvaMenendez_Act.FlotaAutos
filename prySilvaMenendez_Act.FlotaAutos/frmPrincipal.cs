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
        public List<Vehiculos> listaVehiculos = new List<Vehiculos>();
        public List<Choferes> listaChoferes = new List<Choferes>();
        public List<Alquileres> listaAlquileres = new List<Alquileres>();
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
            frmAgregarVehiculo AgregarVehiculo = new frmAgregarVehiculo(listaVehiculos);
            AgregarVehiculo.ShowDialog();
        }

        private void btnAgregarAlquiler_Click(object sender, EventArgs e)
        {
            frmAgregarAlquiler AgregarAlquiler = new frmAgregarAlquiler(listaVehiculos);
            AgregarAlquiler.ShowDialog();
        }

        private void btnVerAlquileresEnCurso_Click(object sender, EventArgs e)
        {
            frmVerAlquileres VerAlquileres = new frmVerAlquileres(listaAlquileres);
            VerAlquileres.ShowDialog();
        }

        private void btnVerDatosVehiculos_Click(object sender, EventArgs e)
        {
            frmDatosVehiculos DatosVehiculos = new frmDatosVehiculos(listaVehiculos);
            DatosVehiculos.ShowDialog();
        }

        private void btnVerDatosChoferes_Click(object sender, EventArgs e)
        {
            frmDatosChoferes DatosChoferes = new frmDatosChoferes(listaChoferes);
            DatosChoferes.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
