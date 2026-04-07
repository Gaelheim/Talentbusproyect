using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Empleados
    {
        private CD_Empleado objetoCD = new CD_Empleado();

        public DataTable MostrarEmpleados()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarEmpleados();
            return tabla;
        }

        public DataTable MostrarPosiciones()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = objetoCD.MostrarPosiciones();
            return tabla1;
        }

        public void InsertarEmpleado(string codigoEmpleado, string nombre, string apellido, string cedula, int tipo, int idPosicion, string estatus)
        {
            objetoCD.InsertarEmpleado(codigoEmpleado, nombre, apellido, cedula, tipo, idPosicion, estatus);
        }

        public void EditarEmpleado(int id, string codigoEmpleado, string nombre, string apellido, string cedula, int tipo, int idPosicion, string estatus)
        {
            objetoCD.EditarEmpleado(id, codigoEmpleado, nombre, apellido, cedula, tipo, idPosicion, estatus);
        }
    }
}
