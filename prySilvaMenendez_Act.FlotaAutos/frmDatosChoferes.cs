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
    public partial class frmDatosChoferes : Form
    {
        List<Choferes> listaChoferes;
        public frmDatosChoferes(List<Choferes> choferes)
        {
            InitializeComponent();
            listaChoferes = choferes;
        }

        private void frmDatosChoferes_Load(object sender, EventArgs e)
        {
            dgvChoferes.DataSource = null;
            dgvChoferes.DataSource = listaChoferes;
        }
    }
}
