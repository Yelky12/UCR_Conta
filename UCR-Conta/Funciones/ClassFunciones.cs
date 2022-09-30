using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcceDatos;
using System.Data;



namespace ClaseFunciones
{
   public class ClassFunciones
    {

        public static DataTable EjecutaQuery(string Opcion)
        {
            return clsConexiones.EjecDtaTable("RP");

        }



    }
}
