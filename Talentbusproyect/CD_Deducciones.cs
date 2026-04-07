using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Deducciones
    {
        private Talentbusproyect.CD_Conexion conexion = new Talentbusproyect.CD_Conexion();

        public DataTable MostrarDeducciones()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * From Deducciones";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarDeduccion(string Nombre, decimal Porcentaje, string Descripcion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Deducciones (Nombre, Porcentaje, Descripcion) VALUES (@Nombre, @Porcentaje, @Descripcion)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = Nombre;
            comando.Parameters.Add("@Porcentaje", SqlDbType.Decimal).Value = Porcentaje;
            comando.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = Descripcion;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EditarDeduccion(int Id, string Nombre, decimal Porcentaje, string Descripcion)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EditarDeduccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", Id);
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Porcentaje", Porcentaje);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        public void EliminarDeduccion(string Id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EliminarDeduccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", Id);
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
