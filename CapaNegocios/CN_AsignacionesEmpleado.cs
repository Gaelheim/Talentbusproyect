using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_AsignacionesEmpleado
    {
        private CD_AsignacionesEmpleado objetoCD = new CD_AsignacionesEmpleado();

        public DataTable MostrarAsignacionesEmpleado()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarAsignacionesEmpleado();
            return tabla;
        }

        public DataTable MostrarAsignaciones()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = objetoCD.MostrarAsignaciones();
            return tabla1;
        }

        public DataTable MostrarEmpleados()
        {
            DataTable tabla2 = new DataTable();
            tabla2 = objetoCD.MostrarEmpleados();
            return tabla2;
        }

        public void InsertarAsignacionEmpleado(int idEmpleado, int idAsignacion, int Tipo, DateOnly fechaEfectividad)
        {
            objetoCD.InsertarAsignacionEmpleado(idEmpleado, idAsignacion, Tipo, fechaEfectividad);
        }

        public void EditarAsignacionEmpleado(int id, int idEmpleado, int idAsignacion, int Tipo, DateOnly fechaEfectividad)
        {
            objetoCD.EditarAsignacionEmpleado(id, idEmpleado, idAsignacion, Tipo, fechaEfectividad);
        }

        public void EliminarAsignacionEmpleado(int id)
        {
            objetoCD.EliminarAsignacionEmpleado(id);
        }
    }
}
