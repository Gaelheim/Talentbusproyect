using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_AsignacionesEmpleado
    {
        private Talentbusproyect.CD_Conexion conexion = new Talentbusproyect.CD_Conexion();
    
        public DataTable MostrarAsignacionesEmpleado()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * From AsignacionesEmpleado";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarAsignaciones()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla1 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select Id, Nombre From Asignaciones";
            SqlDataReader leer = comando.ExecuteReader();
            tabla1.Load(leer);
            conexion.CerrarConexion();
            return tabla1;
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

        public void InsertarAsignacionEmpleado(int idEmpleado, int idAsignacion, int Tipo, DateOnly fechaEfectividad)
        { 
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO AsignacionesEmpleado (IdEmpleado, IdAsignacion, Tipo, FechaEfectividad) VALUES (@idEmpleado, @idAsignacion, @Tipo, @fechaEfectividad)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add("@idEmpleado", SqlDbType.Int).Value = idEmpleado;
            comando.Parameters.Add("@idAsignacion", SqlDbType.Int).Value = idAsignacion;
            comando.Parameters.Add("@Tipo", SqlDbType.TinyInt).Value = Tipo;
            comando.Parameters.Add("@fechaEfectividad", SqlDbType.Date).Value = fechaEfectividad;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

        public void EditarAsignacionEmpleado(int Id, int idEmpleado, int idAsignacion, int Tipo, DateOnly fechaEfectividad)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EditarAsignacionEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", Id);
            comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
            comando.Parameters.AddWithValue("@idAsignacion", idAsignacion);
            comando.Parameters.AddWithValue("@Tipo", Tipo);
            comando.Parameters.AddWithValue("@fechaEfectividad", fechaEfectividad);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarAsignacionEmpleado(int Id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EliminarAsignacionEmpleado";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", Id);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
}
