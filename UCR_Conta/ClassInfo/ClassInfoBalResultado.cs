using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCR_Conta.ClassInfo
{
    class ClassInfoBalResultado
    {
      public  string  ConfgEstadoResultado_NombreTitulo { get; set; }
      public  string  CentroDeCostos_Descripcion        { get; set; }
      public  int     ConfgEstadoResultado_CuentasFK    { get; set; }
      public  string  Cuenta_Descripcion                { get; set; }
      public  string  ConfgEstadoResultado_Naturaleza   { get; set; }
      public  string  ConfgEstadoResultado_Empresa      { get; set; }
      public  double  AsientoDetalle_Valor              { get; set; }


        public ClassInfoBalResultado()
        {
        }

        public ClassInfoBalResultado(ClassInfoBalResultado Add)
        {
            ConfgEstadoResultado_NombreTitulo = Add.ConfgEstadoResultado_NombreTitulo;
            CentroDeCostos_Descripcion = Add.CentroDeCostos_Descripcion;
            ConfgEstadoResultado_CuentasFK = Add.ConfgEstadoResultado_CuentasFK;
            Cuenta_Descripcion = Add.Cuenta_Descripcion;
            ConfgEstadoResultado_Naturaleza = Add.ConfgEstadoResultado_Naturaleza;
            ConfgEstadoResultado_Empresa = Add.ConfgEstadoResultado_Empresa;
            AsientoDetalle_Valor = Add.AsientoDetalle_Valor;

        }


    }
}
