using System.Data;
using System.Data.SqlClient;

namespace Talentbusproyect
{
    public class CD_Conexion
    {
        //TODO: crear una variable de tipo SqlConnection, y asignarle la cadena de conexion a la base de datos.
        private SqlConnection Conexion = new SqlConnection("Server=.;DataBase= TalentBus;Integrated Security=true");

        //TODO: metodo para abrir la conexion a la base de datos, y retornar la conexion abierta.
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;

        }

        //TODO: metodo para cerrar la conexion a la base de datos, y retornar la conexion cerrada.
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;

        }

    }
}
