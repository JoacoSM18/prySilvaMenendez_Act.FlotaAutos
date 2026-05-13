using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prySilvaMenendez_Act.FlotaAutos
{
    public class Alquileres
    {
        public string App { get; set; }
        public string Vehiculo { get; set; }
        public DateTime Intervalo { get; set; }
        public override string ToString()
        {
            return App + " - " + Vehiculo + " (" + Intervalo + ")";
        }

    }
}
