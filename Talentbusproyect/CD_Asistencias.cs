using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Asistencias
    {
        private Talentbusproyect.CD_Conexion conexion = new Talentbusproyect.CD_Conexion();
       
        public DataTable MostrarAsistencias()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * From Asistencias";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarEmpleados()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla2 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT Id, Nombre + ' ' + Apellido AS NombreCompleto FROM Empleados";
            SqlDataReader leer = comando.ExecuteReader();
            tabla2.Load(leer);
            conexion.CerrarConexion();
            return tabla2;
        }

        public void InsertarAsistencia(int idEmpleado, string Descripcion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Asistencias (IdEmpleado, Descripcion) VALUES (@idEmpleado, @Descripcion)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleado;
            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Descripcion;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

    }
}
