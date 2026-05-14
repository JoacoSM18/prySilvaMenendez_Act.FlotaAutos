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
        public List<Vehiculos> listaVehiculos;
        public frmAgregarVehiculo(List<Vehiculos> vehiculos)
        {
            InitializeComponent();
            listaVehiculos = vehiculos;
        }
        private void frmAgregarVehiculo_Load(object sender, EventArgs e)
        {
            
        }
        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "" || txtModelo.Text == "" || mskPatente.Text == "")
            {
                MessageBox.Show("Datos Incompletos");
                return;
            }
            Vehiculos v = new Vehiculos();
            v.Marca = txtMarca.Text;
            v.Modelo = txtModelo.Text;
            v.Año = (int)numAño.Value;
            v.Patente = mskPatente.Text;
            listaVehiculos.Add(v);
            ConexionBD bd = new ConexionBD();
            bd.GuardarVehiculo(v);
            MessageBox.Show("Vehiculo Agregado Correctamente","Éxito",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtMarca.Clear();
            txtModelo.Clear();
            numAño.Value = 2026;
            mskPatente.Clear();
        }

        private void mskPatente_Click(object sender, EventArgs e)
        {
            mskPatente.SelectionStart = 0;
        }

        private void mskPatente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void numAño_ValueChanged(object sender, EventArgs e)
        {
            if (numAño.Value >= 2016)
            {
                mskPatente.Mask = "LL-000-LL";
            }
            else
            {
                mskPatente.Mask = "LLL-000";
            }
        }
    }
}
