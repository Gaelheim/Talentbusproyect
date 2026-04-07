using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talentbusproyect;

namespace CapaDatos
{
    public class CD_Departamentos
    {
        private CD_Conexion conexion = new CD_Conexion();

        public DataTable MostrarDptos()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * From Departamentos";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarDpto(string nombre)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Departamentos (Nombre) VALUES (@nombre)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();

        }

        public void EditarDpto(int id, string nombre)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EditarDepartamento";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", id);
            comando.Parameters.AddWithValue("@Nombre", nombre);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        //metodo para eliminar los datos de nuestra base de datos
        public void EliminarDpto(int id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EliminarDepartamento";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id", id);

            comando.ExecuteNonQuery();
            comando.Parameters.Clear();

        }

    }
}
