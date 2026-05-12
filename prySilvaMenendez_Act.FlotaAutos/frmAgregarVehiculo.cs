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
        List<Vehiculos> listaVehiculos = new List<Vehiculos>();

        public frmAgregarVehiculo()
        {
            InitializeComponent();
        }
        private void frmAgregarVehiculo_Load(object sender, EventArgs e)
        {
            mskPatente.Mask = "AA-000-AA";
        }
        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "" || txtModelo.Text == "" || mskPatente.Text == "")
            {
                MessageBox.Show("Datos Incompletos, Por Favor Complete todos los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarca.Focus();
                return;
            }
            Vehiculos Vehiculo = new Vehiculos();
            Vehiculo.Marca = txtMarca.Text;
            Vehiculo.Modelo = txtModelo.Text;
            Vehiculo.Año = (int)numAño.Value;
            Vehiculo.Patente = mskPatente.Text;
            MessageBox.Show("Vehiculo Agregado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtMarca.Clear ();
            txtModelo.Clear ();
            numAño.Value = 2026;
            mskPatente.Clear ();
        }

        private void mskPatente_Click(object sender, EventArgs e)
        {
            mskPatente.SelectionStart = 0;
        }
    }
}
