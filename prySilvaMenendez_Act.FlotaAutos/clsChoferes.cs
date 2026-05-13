using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaMenendez_Act.FlotaAutos
{
    internal class Choferes
    {
        public string Nombre { get; set; }
        public int DNI { get; set; }
        public DateTime Nacimiento { get; set; }
        public int NroCarnet { get; set; }
        public string Seguro { get; set; }
        public override string ToString()
        {
            return Nombre + " " + DNI + " (" + Nacimiento + ") - " + NroCarnet + " - " + Seguro;
        }
    }
}
