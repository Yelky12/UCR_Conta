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
        public static int CompraEncabezado_Documento{ get; set; }
        public static string CompraEncabezado_Vencimiento { get; set; }
        public static int CompraEncabezado_IDClienteFK { get; set; }
        public static string CompraEncabezado_Fecha{ get; set; }
        public static string CompraEncabezado_IDMonedaFK { get; set; }
        public static string CompraEncabezado_Condicion { get; set; }
        public static double CompraEncabezado_Gravado { get; set; }
        public static double CompraEncabezado_Descuento { get; set; }
        public static double CompraEncabezado_Impuesto { get; set; }
        public static double CompraEncabezado_Total { get; set; }
    }


    public static class clsVentaEncabezado
    {
        public static int VentaEncabezado_ID { get; set; }
        public static int VentaEncabezado_Documento { get; set; }
        public static string VentaEncabezado_Vencimiento { get; set; }
        public static int VentaEncabezado_IDClienteFK { get; set; }
        public static string VentaEncabezado_Fecha { get; set; }
        public static string VentaEncabezado_IDMonedaFK { get; set; }
        public static string VentaEncabezado_Condicion { get; set; }
        public static double VentaEncabezado_Gravado { get; set; }
        public static double VentaEncabezado_Descuento { get; set; }
        public static double VentaEncabezado_Impuesto { get; set; }
        public static double VentaEncabezado_Total { get; set; }
    }


    public static class clsCompraDetalle
    {
        public static int CompraDetalle_ID              { get; set; }
        public static int CompraDetalle_IdEncabezadoFK  { get; set; }
        public static int CompraDetalle_ArticuloFK      { get; set; }
        public static double CompraDetalle_Cant         { get; set; }
        public static double CompraDetalle_Precio       { get; set; }
        public static string CompraDetalle_Gravado      { get; set; }
        public static double CompraDetalle_Impuesto     { get; set; }
        public static double CompraDetalle_Total        { get; set; }
    }


    public static class clsVentaDetalle
    {
        public static int VentaDetalle_ID { get; set; }
        public static int VentaDetalle_IdEncabezadoFK { get; set; }
        public static int VentaDetalle_ArticuloFK{ get; set; }
        public static double VentaDetalle_Cant { get; set; }
        public static double VentaDetalle_Precio { get; set; }
        public static string VentaDetalle_Gravado { get; set; }
        public static double VentaDetalle_Impuesto { get; set; }
        public static double VentaDetalle_Total { get; set; }
    }


    public static class clsArticulos
    {
        public static int Articulos_ID { get; set; }
        public static string Articulos_Descripcion{ get; set; }
        public static string Articulos_Medida { get; set; }
        public static int Articulos_IDCuentaFK{ get; set; }
        public static double Articulos_Impuesto{ get; set; }
        public static int Articulos_Estado { get; set; }
    }




    public static class clsCuenta
    {
        public static int Cuenta_ID { get; set; }
        public static string Cuenta_Descripcion { get; set; }
        public static int Cuenta_Madre { get; set; }
        public static int Cuenta_Tipo { get; set; }
        public static string Cuenta_Codigo { get; set; }
        public static int Cuenta_CentroCostoFK { get; set; }
    }


    public static class clsAsientoEncabezado
    { 
        public static int AsientoEncabezado_ID { get; set; }
        public static int AsientoEncabezado_Documento { get; set; }
        public static string AsientoEncabezado_Fecha { get; set; }
        public static int AsientoEncabezado_IdTerceroFK { get; set; }
        public static string AsientoEncabezado_Detalle { get; set; }

    }



    public static class clsAsientoDetalle
    {
        public static int AsientoDetalle_ID { get; set; }
        public static int AsientoDetalle_NumeroAsientoFK { get; set; }
        public static int AsientoDetalle_Linea { get; set; }
        public static int AsientoDetalle_CodigoCuentaFK { get; set; }
        public static string AsientoDetalle_Tipo { get; set; }
        public static double AsientoDetalle_Valor { get; set; }

    }

    public static class clsCentroCostos
    {
        public static int CentroDeCostos_ID { get; set; }
        public static string CentroDeCostos_CentroDeCostos { get; set; }
        public static string CentroDeCostos_Descripcion { get; set; }
        public static string CentroDeCostos_EsUltimoNivel { get; set; }
        public static string CentroDeCostos_Comentarios{ get; set; }


    }


    public static class clsMac
    {
        public static string MacNum { get; set; }  

    }


    public static class clsEstadoResultado
    {
        public static int clsEstResultado_ID { get; set; }
        public static string clsEstResultado_NombreTitulo { get; set; }
        public static int clsEstResultado_Orden { get; set; }
        public static int clsEstResultado_CuentasFK { get; set; }
        public static string clsEstResultado_Naturaleza { get; set; }

    }

    public static class clsConfgEstResul
    {
        public static int clsConfgEstResul_ID { get; set; }
        public static string clsConfgEstResul_NombreTitulo { get; set; }
        public static int clsConfgEstResul_Orden { get; set; }
        public static int clsConfgEstResul_CuentasFK { get; set; }
        public static string clsConfgEstResul_Naturaleza { get; set; }
        public static string clsConfgEstResul_Empresa { get; set; }


    }




    public static class ClaseEnt
    {

    }

}
