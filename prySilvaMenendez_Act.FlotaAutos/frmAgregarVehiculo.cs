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
    public partial class frmAgregarVehiculo : Form
    {
        public frmAgregarVehiculo()
        {
            InitializeComponent();
        }

        private void mskPatente_Enter(object sender, EventArgs e)
        {
            mskPatente.SelectionStart = 0;

        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculos Vehiculo = new Vehiculos();
            Vehiculo.Marca = txtMarca.Text;
            Vehiculo.Modelo = txtModelo.Text;
            Vehiculo.Año = (int)numAño.Value;
            Vehiculo.Patente = mskPatente.Text;
        }
    }
}
