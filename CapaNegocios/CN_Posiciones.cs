using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Posiciones
    {
        private CD_Posiciones objetoCD = new CD_Posiciones();

        public DataTable MostrarPosiciones()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarPosiciones();
            return tabla;
        }

        public DataTable MostrarDptos()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = objetoCD.MostrarDptos();
            return tabla1;
        }

        public void InsertarPosicion(string nombre, decimal salario, int idDpto)
        {
            objetoCD.InsertarPosicion(nombre, salario, idDpto);
        }

        public void EditarPosicion(int id, string nombre, decimal salario, int idDpto)
        {
            objetoCD.EditarPosicion(id, nombre, salario, idDpto);
        }

        public void EliminarPosicion(string id)
        {
            objetoCD.EliminarPosicion(id);
        }
    }
}
