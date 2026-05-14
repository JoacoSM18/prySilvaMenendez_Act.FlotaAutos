using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace prySilvaMenendez_Act.FlotaAutos
{
    public class ConexionBD
    {
        OleDbConnection conexion;
        public ConexionBD()
        {
            conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=|DataDirectory|\\FlotaAutos.accdb");
        }
        public void Abrir()
        {
            conexion.Open();
        }
        public void Cerrar()
        {
            conexion.Close();
        }
        public void GuardarVehiculo(Vehiculos v)
        {
            Abrir();
            string query = "INSERT INTO Vehiculos (Marca, Modelo, Año, Patente) VALUES (?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(query, conexion);
            cmd.Parameters.AddWithValue("?", v.Marca);
            cmd.Parameters.AddWithValue("?", v.Modelo);
            cmd.Parameters.AddWithValue("?", v.Año);
            cmd.Parameters.AddWithValue("?", v.Patente);
            cmd.ExecuteNonQuery();
            Cerrar();
        }

        public void GuardarAlquiler(Alquileres a)
        {
            Abrir();
            string query = "INSERT INTO Alquileres (Vehiculo, FechaInicio, FechaFin, Total) VALUES (?, ?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(query, conexion);
            cmd.Parameters.AddWithValue("?", a.Vehiculo);
            cmd.Parameters.AddWithValue("?", a.FechaInicio);
            cmd.Parameters.AddWithValue("?", a.FechaFin);
            cmd.Parameters.AddWithValue("?", a.Total);
            cmd.ExecuteNonQuery();
            Cerrar();
        }

        public void GuardarChofer(Choferes c)
        {
            Abrir();
            string query = "INSERT INTO Choferes (Nombre, DNI, Nacimiento) VALUES (?, ?, ?)";
            OleDbCommand cmd = new OleDbCommand(query, conexion);
            cmd.Parameters.AddWithValue("?", c.Nombre);
            cmd.Parameters.AddWithValue("?", c.DNI);
            cmd.Parameters.AddWithValue("?", c.Nacimiento);
            cmd.ExecuteNonQuery();
            Cerrar();
        }
    }
}
