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
    public partial class frmAgregarAlquiler : Form
    {
        public List<Vehiculos> listaVehiculos;
        public List<Alquileres> listaAlquileres = new List<Alquileres>();
        double precio;
        double aumento;
        String appseleccionada;
        public frmAgregarAlquiler(List<Vehiculos> vehiculos)
        {
            InitializeComponent();
            listaVehiculos = vehiculos;
        }

        private void frmAgregarAlquiler_Load(object sender, EventArgs e)
        {
            cmbVehiculos.DataSource = listaVehiculos;
            monthCalendar1.MaxDate = new DateTime(2026, 12, 31);
            monthCalendar1.MinDate = DateTime.Today;
            monthCalendar1.MaxSelectionCount = 31;
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            DateTime inicio = monthCalendar1.SelectionStart;
            DateTime fin = monthCalendar1.SelectionEnd;
            if (btnCabify.Checked == false && btnDidi.Checked == false && btnUber.Checked == false || cmbVehiculos.SelectedIndex == -1 || monthCalendar1.SelectionEnd == monthCalendar1.SelectionStart)
            {
                MessageBox.Show("Datos Incompletos, Por Favor Complete todos los Campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (btnCabify.Checked == true)
            {
                appseleccionada = "Cabify";
            }
            else if (btnDidi.Checked == true)
            {
                appseleccionada = "Didi";
            }
            else if (btnUber.Checked == true)
            {
                appseleccionada = "Uber";
            }
            Alquileres Alquiler = new Alquileres();
            Alquiler.App = appseleccionada;
            Alquiler.Vehiculo = ((Vehiculos)cmbVehiculos.SelectedItem).Modelo;
            Alquiler.FechaInicio = monthCalendar1.SelectionStart;
            Alquiler.FechaFin = monthCalendar1.SelectionEnd;
            listaAlquileres.Add(Alquiler);
            if (((Vehiculos)cmbVehiculos.SelectedItem).Año >= 2020)
            {
                precio = 70000;
            }
            else if (((Vehiculos)cmbVehiculos.SelectedItem).Año >= 2010)
            {
                precio = 50000;
            }
            else if (((Vehiculos)cmbVehiculos.SelectedItem).Año >= 2006)
            {
                precio = 45000;
            }
            else
            {
                precio = 35000;
            }
            if ((fin - inicio).Days >= 21)
            {
                aumento = 1.4;
            }
            else if ((fin - inicio).Days >= 14)
            {
                aumento = 1.3;
            }
            else if ((fin - inicio).Days >= 7)
            {
                aumento = 1.2;
            }
            else if ((fin - inicio).Days >= 4)
            {
                aumento = 1.1;
            }
            else
            {
                aumento = 1.05;
            }
            DialogResult resultado = MessageBox.Show("El Total a Pagar es de $" + precio * aumento, "¿Desea Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                MessageBox.Show("Alquiler Agregado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
