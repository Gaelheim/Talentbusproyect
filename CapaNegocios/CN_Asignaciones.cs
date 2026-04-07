using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Asignaciones
    {
        private CD_Asignaciones objetoCD = new CD_Asignaciones();

        public DataTable MostrarAsignaciones()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarAsignaciones();
            return tabla;
        }

        public void InsertarAsignacion(string Nombre, decimal Porcentaje, string Descripcion)
        {
            objetoCD.InsertarAsignacion(Nombre, Porcentaje, Descripcion);
        }

        public void EditarAsignacion(int Id, string Nombre, decimal Porcentaje, string Descripcion)
        {
            objetoCD.EditarAsignacion(Id, Nombre, Porcentaje, Descripcion);
        }

        public void EliminarAsignacion(int Id)
        {
            objetoCD.EliminarAsignacion(Id);
        }
    }
}
