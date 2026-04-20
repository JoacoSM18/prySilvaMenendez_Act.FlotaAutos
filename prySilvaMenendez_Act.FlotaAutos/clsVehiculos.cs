using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaMenendez_Act.FlotaAutos
{
    public class Vehiculos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Año { get; set; }
        public string Patente { get; set; }
        public override string ToString()
        {
            return Marca + " " + Modelo + " (" + Año + ") - " + Patente;
        }

    }
}
