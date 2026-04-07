using CapaDatos;
using System.Data;

namespace CapaNegocios
{
    public class CN_Departamentos
    {
        private CD_Departamentos objetoCD = new CD_Departamentos();

        public DataTable MostrarDptos()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarDptos();
            return tabla;
        }

        public void InsertarDpto(string nombre)
        {
            objetoCD.InsertarDpto(nombre);
        }

        public void EditarDpto(int id, string nombre)
        {
            objetoCD.EditarDpto(id, nombre);
        }

        public void EliminarDpto(string id)
        {
            objetoCD.EliminarDpto(id);
        }
    }
}
