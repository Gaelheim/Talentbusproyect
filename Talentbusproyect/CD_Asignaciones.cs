using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Asignaciones
    {
        private Talentbusproyect.CD_Conexion conexion = new Talentbusproyect.CD_Conexion();

        public DataTable MostrarAsignaciones()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * From Asignaciones";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarAsignacion(string Nombre, decimal Porcentaje, string Descripcion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Asignaciones (Nombre, Porcentaje, Descripcion) VALUES (@Nombre, @Porcentaje, @Descripcion)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
            comando.Parameters.Add("@Porcentaje", SqlDbType.Decimal).Value = Porcentaje;
            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Descripcion;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EditarAsignacion(int Id, string Nombre, decimal Porcentaje, string Descripcion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EditarAsignacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", Id);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Porcentaje", Porcentaje);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarAsignacion(string Id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EliminarAsignacion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", Id);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

    }
}
