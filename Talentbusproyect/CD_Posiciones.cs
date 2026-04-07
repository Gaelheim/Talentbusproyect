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
    public class CD_Posiciones
    {
        private CD_Conexion conexion = new CD_Conexion();
        public DataTable MostrarPosiciones()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * From Posiciones";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable MostrarDptos()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla1 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select Id, Nombre From Departamentos";
            SqlDataReader leer = comando.ExecuteReader();
            tabla1.Load(leer);
            conexion.CerrarConexion();
            return tabla1;

        }

        public void InsertarPosicion(string nombre, decimal salario, int idDpto)
        {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "INSERT INTO Posiciones (Nombre, Salario, IdDepartamento) VALUES (@nombre, @salario, @idDpto)";
                comando.CommandType = CommandType.Text;
                comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
                comando.Parameters.Add("@idDpto", SqlDbType.Int).Value = idDpto;
                comando.Parameters.Add("@salario", SqlDbType.Decimal).Value = salario;
                comando.ExecuteNonQuery();
                conexion.CerrarConexion();

        }

        public void EditarPosicion(int id, string nombre, decimal salario, int idDpto)
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_EditarPosicion";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Salario", salario);
                comando.Parameters.AddWithValue("@IdDepartamento", idDpto);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
        }

        //metodo para eliminar los datos de nuestra base de datos
        public void EliminarPosicion(int id)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "sp_EliminarPosicion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
