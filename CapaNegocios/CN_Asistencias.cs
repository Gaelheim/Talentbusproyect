using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocios
{
    public class CN_Asistencias
    {
        private CD_Asistencias objetoCD = new CD_Asistencias();
        public System.Data.DataTable MostrarAsistencias()
        {
            System.Data.DataTable tabla = new System.Data.DataTable();
            tabla = objetoCD.MostrarAsistencias();
            return tabla;
        }
        public System.Data.DataTable MostrarEmpleados()
        {
            System.Data.DataTable tabla2 = new System.Data.DataTable();
            tabla2 = objetoCD.MostrarEmpleados();
            return tabla2;
        }
        public void InsertarAsistencia(int idEmpleado, string Descripcion)
        {
            objetoCD.InsertarAsistencia(idEmpleado, Descripcion);
        }
    }
}
