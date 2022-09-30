using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInfo
{
    public  class ClassInfoBalCompro
    {
        

            public  string AsientoEncabezado_Fecha { get; set; }
            public  string Cuenta_Codigo { get; set; }
            public  string Cuenta_Descripcion { get; set; }
            public  double Debito { get; set; }
            public  double Credito { get; set; }

            public ClassInfoBalCompro()
            {
            }

            public  ClassInfoBalCompro(ClassInfoBalCompro Add)
            {
                AsientoEncabezado_Fecha = Add.AsientoEncabezado_Fecha;
                Cuenta_Codigo = Add.Cuenta_Codigo;
                Cuenta_Descripcion = Add.Cuenta_Descripcion;
                Debito = Add.Debito;
                Credito = Add.Credito;

            }


     }
}


