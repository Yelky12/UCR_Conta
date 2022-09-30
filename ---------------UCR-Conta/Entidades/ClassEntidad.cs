using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEntidades
{
    public static class clsMoneda
    {
        public static int Moneda_ID { get; set; }
        public static string Moneda_Nombre { get; set; }
        public static float Moneda_Cambio { get; set; }
    }

    public static class clsEmpresa
    {
        public static int Empresa_ID { get; set; }
        public static string Empresa_Nombre { get; set; }
    }

    public static class clsTercero
    {
        public static int Tercero_ID { get; set; }
        public static string Tercero_Identificador { get; set; }
        public static string Tercero_Nombre { get; set; }
        public static string Tercero_Tipo { get; set; }
    }

    public static class clsCompraEncabezado
    {
        public static int CompraEncabezado_ID { get; set; }
        public static int CompraEncabezado_Identificador { get; set; }
        public static string CompraEncabezado_Vencimiento { get; set; }
        public static int CompraEncabezado_IDClienteFK { get; set; }
        public static string CompraEncabezado_Fecha{ get; set; }
        public static int CompraEncabezado_IDMonedaFK { get; set; }
        public static string CompraEncabezado_Condicion { get; set; }
        public static double CompraEncabezado_Gravado { get; set; }
        public static double CompraEncabezado_Descuento { get; set; }
        public static double CompraEncabezado_Impuesto { get; set; }
        public static double CompraEncabezado_Total { get; set; }
    }


    public static class clsVentaEncabezado
    {
        public static int VentaEncabezado_ID { get; set; }
        public static int VentaEncabezado_Identificador { get; set; }
        public static string VentaEncabezado_Vencimiento { get; set; }
        public static int VentaEncabezado_IDClienteFK { get; set; }
        public static string VentaEncabezado_Fecha { get; set; }
        public static int VentaEncabezado_IDMonedaFK { get; set; }
        public static string VentaEncabezado_Condicion { get; set; }
        public static double VentaEncabezado_Gravado { get; set; }
        public static double VentaEncabezado_Descuento { get; set; }
        public static double VentaEncabezado_Impuesto { get; set; }
        public static double VentaEncabezado_Total { get; set; }
    }


    public static class clsCompraDetalle
    {
        public static int CompraDetalle_ID { get; set; }
        public static int CompraDetalle_DocumentoFK { get; set; }
        public static string CompraDetalle_Descripcion { get; set; }
        public static double CompraDetalle_Cant { get; set; }
        public static double CompraDetalle_Precio { get; set; }
        public static string CompraDetalle_Gravado { get; set; }
        public static double CompraDetalle_Total { get; set; }
    }


    public static class clsVentaDetalle
    {
        public static int VentaDetalle_ID { get; set; }
        public static int VentaDetalle_DocumentoFK { get; set; }
        public static string VentaDetalle_Descripcion { get; set; }
        public static double VentaDetalle_Cant { get; set; }
        public static double VentaDetalle_Precio { get; set; }
        public static string VentaDetalle_Gravado { get; set; }
        public static double VentaDetalle_Total { get; set; }
    }


    public static class clsArticulos
    {
        public static int Articulos_ID { get; set; }
        public static string Articulos_Nombre { get; set; }
        public static string Articulos_Medida { get; set; }
        public static int Moneda_IDCuentaFK { get; set; }
    }




    public static class clsCuenta
    {
        public static int Cuenta_ID { get; set; }
        public static string Cuenta_Descripcion { get; set; }
        public static int Cuenta_Madre { get; set; }
        public static int Cuenta_Tipo { get; set; }
    }





    public static class ClaseEnt
    {

    }

}
