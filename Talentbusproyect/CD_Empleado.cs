using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Talentbusproyect;


namespace CapaDatos
{
    public class CD_Empleado
    {
        private CD_Conexion conexion = new CD_Conexion();

        //TODO: Metodo para mostrar los datos de la tabla Empleados, y retornar un DataTable con los datos obtenidos.
        public DataTable MostrarEmpleados()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select * From Empleados";
            SqlDataReader leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        //TODO: Metodo para mostrar los datos de la tabla Posiciones, y retornar un DataTable con los datos obtenidos.
        public DataTable MostrarPosiciones()
        {
            SqlCommand comando = new SqlCommand();
            DataTable tabla1 = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select Id, Nombre From Posiciones";
            SqlDataReader leer = comando.ExecuteReader();
            tabla1.Load(leer);
            conexion.CerrarConexion();
            return tabla1;
        }

        //TODO: Metodo para insertar los datos de un nuevo empleado en la tabla Empleados, utilizando un comando SQL, y los parametros necesarios para insertar los datos.
        public void InsertarEmpleado( string codigoEmpleado,string nombre, string apellido, string cedula, int tipo, int idPosicion, string estatus)
        {
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "INSERT INTO Posiciones (CodigoEmpleado, Nombre, Apellido, Cedula, Tipo, IdPosicion, Estatus) VALUES (@codigoEmpleado, @nombre, @apellido, @cedula, @tipo, @idPosicion, @estatus)";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add("@codigoEmpleado", SqlDbType.VarChar).Value = codigoEmpleado;
            comando.Parameters.Add("@nombre", SqlDbType.VarChar).Value = nombre;
            comando.Parameters.Add("@apellido", SqlDbType.VarChar).Value = apellido;
            comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = cedula;
            comando.Parameters.Add("@tipo", SqlDbType.TinyInt).Value = tipo;
            comando.Parameters.Add("@idPosicion", SqlDbType.Int).Value = idPosicion;
            comando.Parameters.Add("@estatus", SqlDbType.VarChar).Value = estatus;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
        }

        //TODO: Metodo para editar los datos de un empleado existente en la tabla Empleados, utilizando un comando SQL, y los parametros necesarios para editar los datos.
        public void EditarEmpleado(int id, string codigoEmpleado, string nombre, string apellido, string cedula, int tipo, int idPosicion, string estatus)
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "sp_EditarEmpleado";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id", id);
                comando.Parameters.AddWithValue("@CodigoEmpleado", codigoEmpleado);
                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", apellido);
                comando.Parameters.AddWithValue("@Cedula", cedula);
                comando.Parameters.AddWithValue("@Tipo", tipo);
                comando.Parameters.AddWithValue("@IdPosicion", idPosicion);
                comando.Parameters.AddWithValue("@Estatus", estatus);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
        }
    }
}
