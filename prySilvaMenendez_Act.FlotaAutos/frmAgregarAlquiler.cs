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
            int precioPorDia;
            int dias = (fin - inicio).Days + 1;
            double total;

            Vehiculos v = (Vehiculos)cmbVehiculos.SelectedItem;

            if (v.Año >= 2020)
            {
                precioPorDia = 70000;
            }
            else if (v.Año >= 2010)
            {
                precioPorDia = 50000;
            }
            else if (v.Año >= 2006)
            {
                precioPorDia = 45000;
            }
            else
            {
                precioPorDia = 35000;
            }
            total = precioPorDia * dias;
            DialogResult resultado = MessageBox.Show("El Total a Pagar es de $" + total +"\n¿Desea Continuar?", "Confirmación",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }
            Alquileres a = new Alquileres();
            a.App = appseleccionada;
            a.Vehiculo = v.Patente;
            a.FechaInicio = inicio;
            a.FechaFin = fin;
            a.Total = total;
            listaAlquileres.Add(a);
            ConexionBD bd = new ConexionBD();
            bd.GuardarAlquiler(a);
            MessageBox.Show("Alquiler Agregado Correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnCabify.Checked = false;
            btnDidi.Checked = false;
            btnUber.Checked = false;
            cmbVehiculos.SelectedIndex = -1;
            monthCalendar1.SetDate(DateTime.Today);
        }
    }
}
