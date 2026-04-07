using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;


namespace CapaNegocios
{
    public class CN_Deducciones
    {
        private CD_Deducciones objetoCD = new CD_Deducciones();
        public System.Data.DataTable MostrarDeducciones()
        {
            System.Data.DataTable tabla = new System.Data.DataTable();
            tabla = objetoCD.MostrarDeducciones();
            return tabla;
        }
        public void InsertarDeduccion(string Nombre, decimal Porcentaje, string Descripcion)
        {
            objetoCD.InsertarDeduccion(Nombre, Porcentaje, Descripcion);
        }
        public void EditarDeduccion(int Id, string Nombre, decimal Porcentaje, string Descripcion)
        {
            objetoCD.EditarDeduccion(Id, Nombre, Porcentaje, Descripcion);
        }
        public void EliminarDeduccion(int Id)
        {
            objetoCD.EliminarDeduccion(Id);
        }
    }
}
