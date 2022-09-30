using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using UCR_Conta.ClassInfo;
using AcceDatos;


namespace UCR_Conta.Formas
{
    public partial class FInfEstResultado : Form
    {
        public FInfEstResultado()
        {
            InitializeComponent();
            CargarReporte();
        }

        private void FInfEstResultado_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }


        private void CargarReporte()
        {
            List<ClassInfoBalResultado> AgregarVENTAS = new List<ClassInfoBalResultado>();
            List<ClassInfoBalResultado> AgregarCOSTO_VENTAS = new List<ClassInfoBalResultado>();
            Conexionsql AcederDatos = new Conexionsql();
            //---------Se envian las VENTAS----------------------------------------
            foreach (DataRow Lista in AcederDatos.Datos("VENTAS").Rows)
            {
                AgregarVENTAS.Add(new ClassInfoBalResultado
                {
                    ConfgEstadoResultado_NombreTitulo = Lista[0].ToString(),
                    CentroDeCostos_Descripcion = Lista[1].ToString(),
                    ConfgEstadoResultado_CuentasFK = int.Parse(Lista[2].ToString()),
                    Cuenta_Descripcion = Lista[3].ToString(),
                    ConfgEstadoResultado_Naturaleza = Lista[4].ToString(),
                    ConfgEstadoResultado_Empresa = Lista[5].ToString(),
                    AsientoDetalle_Valor = double.Parse(Lista[6].ToString())

                });
            }
            ///Mostrar datos en el reporte
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UCR_Conta.Informes.InfoEstResultado.rdlc";
            ReportDataSource rds1 = new ReportDataSource("DatasetEstResultado", AgregarVENTAS); //Nombre de el conjunto de datos
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);




            ////--Se envian las COSTO_VENTAS------------------------------------------------
            //foreach (DataRow Lista in AcederDatos.Datos("COSTO_VENTAS").Rows)
            //{
            //    AgregarCOSTO_VENTAS.Add(new ClassInfoBalResultado
            //    {
            //        ConfgEstadoResultado_NombreTitulo = Lista[0].ToString(),
            //        CentroDeCostos_Descripcion = Lista[1].ToString(),
            //        ConfgEstadoResultado_CuentasFK = int.Parse(Lista[2].ToString()),
            //        Cuenta_Descripcion = Lista[3].ToString(),
            //        ConfgEstadoResultado_Naturaleza = Lista[4].ToString(),
            //        ConfgEstadoResultado_Empresa = Lista[5].ToString(),
            //        AsientoDetalle_Valor = double.Parse(Lista[6].ToString())

            //    });
            //}
            /////Mostrar datos en el reporte
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "UCR_Conta.Informes.InfoEstResultado.rdlc";
            //ReportDataSource rds2 = new ReportDataSource("DatasetEstResultado", AgregarCOSTO_VENTAS); //Nombre de el conjunto de datos
            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(rds2);


            //Enviar parametros al informe RDLC
            //ReportParameter FechainInfo = new ReportParameter("FechaIn", Fechain);
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { FechainInfo });
            //ReportParameter FechafinInfo = new ReportParameter("FechaFin", Fechafin);
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { FechafinInfo });
            //string InfEmpresa = AcederDatos.ObtenerEmpresa();
            //ReportParameter Empresa = new ReportParameter("Empresa", InfEmpresa);
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Empresa });


            this.reportViewer1.RefreshReport();
        }

        public class Conexionsql
        {
            /// <summary>
            /// Retorna Tabla con datos
            /// </summary>
            /// <returns></returns>
            public DataTable Datos(string tipo)
            {
                string StrSql = "";
                switch (tipo)
                {
                    case "VENTAS":
                        StrSql = " Select ConfgEstadoResultado_NombreTitulo,CC.CentroDeCostos_Descripcion,ConfgEstadoResultado_CuentasFK,      " +
                                " C.Cuenta_Descripcion,ConfgEstadoResultado_Naturaleza, ConfgEstadoResultado_Empresa, AD.AsientoDetalle_Valor " +
                                "    from ConfgEstadoResultado CER                                                                            " +
                                "    inner join  AsientoDetalle AD on CER.ConfgEstadoResultado_CuentasFK = AD.AsientoDetalle_CodigoCuentaFK   " +
                                "    inner Join Cuenta C on C.Cuenta_ID = AD.AsientoDetalle_CodigoCuentaFK                                    " +
                                "    inner join CentroDeCostos CC on CC.CentroDeCostos_ID = C.Cuenta_CentroCostoFK                            " +
                                
                                "    order by CER.ConfgEstadoResultado_Orden asc,                                                             " +
                                "    CC.CentroDeCostos_ID desc,                                                                               " +
                                "    CER.ConfgEstadoResultado_Naturaleza desc;                                                                " ;
                        break;

                    case "COSTO_VENTAS":
                        StrSql = " Select ConfgEstadoResultado_NombreTitulo,CC.CentroDeCostos_Descripcion,ConfgEstadoResultado_CuentasFK,      " +
                                " C.Cuenta_Descripcion,ConfgEstadoResultado_Naturaleza, ConfgEstadoResultado_Empresa, AD.AsientoDetalle_Valor " +
                                "    from ConfgEstadoResultado CER                                                                            " +
                                "    inner join  AsientoDetalle AD on CER.ConfgEstadoResultado_CuentasFK = AD.AsientoDetalle_CodigoCuentaFK   " +
                                "    inner Join Cuenta C on C.Cuenta_ID = AD.AsientoDetalle_CodigoCuentaFK                                    " +
                                "    inner join CentroDeCostos CC on CC.CentroDeCostos_ID = C.Cuenta_CentroCostoFK                            " +
                                "    Where ConfgEstadoResultado_NombreTitulo='COSTO_VENTA'                                                     " +
                                "    order by CER.ConfgEstadoResultado_Orden asc,                                                             " +
                                "    CC.CentroDeCostos_ID desc,                                                                               " +
                                "    CER.ConfgEstadoResultado_Naturaleza desc;                                                                ";
                        break;

                    case "GASTOS_ADMINISTRATIVOS":
                        StrSql = " Select ConfgEstadoResultado_NombreTitulo,CC.CentroDeCostos_Descripcion,ConfgEstadoResultado_CuentasFK,      " +
                                " C.Cuenta_Descripcion,ConfgEstadoResultado_Naturaleza, ConfgEstadoResultado_Empresa, AD.AsientoDetalle_Valor " +
                                "    from ConfgEstadoResultado CER                                                                            " +
                                "    inner join  AsientoDetalle AD on CER.ConfgEstadoResultado_CuentasFK = AD.AsientoDetalle_CodigoCuentaFK   " +
                                "    inner Join Cuenta C on C.Cuenta_ID = AD.AsientoDetalle_CodigoCuentaFK                                    " +
                                "    inner join CentroDeCostos CC on CC.CentroDeCostos_ID = C.Cuenta_CentroCostoFK                            " +
                                "    Where ConfgEstadoResultado_NombreTitulo='GASTOS_ADMINISTRATIVOS'                                                     " +
                                "    order by CER.ConfgEstadoResultado_Orden asc,                                                             " +
                                "    CC.CentroDeCostos_ID desc,                                                                               " +
                                "    CER.ConfgEstadoResultado_Naturaleza desc;                                                                ";
                        break;

                    case "GASTOS_VENTAS":
                        StrSql = " Select ConfgEstadoResultado_NombreTitulo,CC.CentroDeCostos_Descripcion,ConfgEstadoResultado_CuentasFK,      " +
                                " C.Cuenta_Descripcion,ConfgEstadoResultado_Naturaleza, ConfgEstadoResultado_Empresa, AD.AsientoDetalle_Valor " +
                                "    from ConfgEstadoResultado CER                                                                            " +
                                "    inner join  AsientoDetalle AD on CER.ConfgEstadoResultado_CuentasFK = AD.AsientoDetalle_CodigoCuentaFK   " +
                                "    inner Join Cuenta C on C.Cuenta_ID = AD.AsientoDetalle_CodigoCuentaFK                                    " +
                                "    inner join CentroDeCostos CC on CC.CentroDeCostos_ID = C.Cuenta_CentroCostoFK                            " +
                                "    Where ConfgEstadoResultado_NombreTitulo='GASTOS_VENTAS'                                                     " +
                                "    order by CER.ConfgEstadoResultado_Orden asc,                                                             " +
                                "    CC.CentroDeCostos_ID desc,                                                                               " +
                                "    CER.ConfgEstadoResultado_Naturaleza desc;                                                                ";
                        break;

                    case "GASTOS_FIANCIEROS":
                        StrSql = " Select ConfgEstadoResultado_NombreTitulo,CC.CentroDeCostos_Descripcion,ConfgEstadoResultado_CuentasFK,      " +
                                " C.Cuenta_Descripcion,ConfgEstadoResultado_Naturaleza, ConfgEstadoResultado_Empresa, AD.AsientoDetalle_Valor " +
                                "    from ConfgEstadoResultado CER                                                                            " +
                                "    inner join  AsientoDetalle AD on CER.ConfgEstadoResultado_CuentasFK = AD.AsientoDetalle_CodigoCuentaFK   " +
                                "    inner Join Cuenta C on C.Cuenta_ID = AD.AsientoDetalle_CodigoCuentaFK                                    " +
                                "    inner join CentroDeCostos CC on CC.CentroDeCostos_ID = C.Cuenta_CentroCostoFK                            " +
                                "    Where ConfgEstadoResultado_NombreTitulo='GASTOS_FIANCIEROS'                                                     " +
                                "    order by CER.ConfgEstadoResultado_Orden asc,                                                             " +
                                "    CC.CentroDeCostos_ID desc,                                                                               " +
                                "    CER.ConfgEstadoResultado_Naturaleza desc;                                                                ";
                        break;

                    case "IMPUESTOS":
                        StrSql = " Select ConfgEstadoResultado_NombreTitulo,CC.CentroDeCostos_Descripcion,ConfgEstadoResultado_CuentasFK,      " +
                                " C.Cuenta_Descripcion,ConfgEstadoResultado_Naturaleza, ConfgEstadoResultado_Empresa, AD.AsientoDetalle_Valor " +
                                "    from ConfgEstadoResultado CER                                                                            " +
                                "    inner join  AsientoDetalle AD on CER.ConfgEstadoResultado_CuentasFK = AD.AsientoDetalle_CodigoCuentaFK   " +
                                "    inner Join Cuenta C on C.Cuenta_ID = AD.AsientoDetalle_CodigoCuentaFK                                    " +
                                "    inner join CentroDeCostos CC on CC.CentroDeCostos_ID = C.Cuenta_CentroCostoFK                            " +
                                "    Where ConfgEstadoResultado_NombreTitulo='IMPUESTOS'                                                     " +
                                "    order by CER.ConfgEstadoResultado_Orden asc,                                                             " +
                                "    CC.CentroDeCostos_ID desc,                                                                               " +
                                "    CER.ConfgEstadoResultado_Naturaleza desc;                                                                ";
                        break;


                }
                return clsConexiones.EjecDtaTable(StrSql);
            }

        }


    }
}
