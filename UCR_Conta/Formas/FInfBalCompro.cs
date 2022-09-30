using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
using ClassInfo;
using AcceDatos;

namespace UCR_Conta.Formas
{
    public partial class FInfBalCompro : Form
    {

        public FInfBalCompro(string FechaIn, string FechaFin)
        {
            InitializeComponent();
            //this.Load += FInfBalCompro_Load;
            CargarReporte(FechaIn, FechaFin);
        }

        private void FInfBalCompro_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            //CargarReporte();
        }


        private void CargarReporte( string Fechain, string Fechafin)
        {
            List<ClassInfoBalCompro> Agregar = new List<ClassInfoBalCompro>();
            Conexionsql AcederDatos = new Conexionsql();
            foreach (DataRow Lista in AcederDatos.Datos(Fechain, Fechafin).Rows)
            {
                Agregar.Add(new ClassInfoBalCompro
                {
                    AsientoEncabezado_Fecha = Lista[0].ToString(),
                    Cuenta_Codigo = Lista[1].ToString(),
                    Cuenta_Descripcion = Lista[2].ToString(),
                    Debito =  double.Parse(Lista[3].ToString()),
                    Credito = double.Parse(Lista[4].ToString())
                    
                });
            }
            ///Mostrar datos en el reporte
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UCR_Conta.Informes.InfoBalCompro.rdlc";
            ReportDataSource rds1 = new ReportDataSource("InfoBalCompro", Agregar); //Nombre de el conjunto de datos
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds1);
            

            //Enviar parametros al informe RDLC
            ReportParameter FechainInfo = new ReportParameter("FechaIn", Fechain);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { FechainInfo });
            ReportParameter FechafinInfo = new ReportParameter("FechaFin", Fechafin);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { FechafinInfo });
            string InfEmpresa = AcederDatos.ObtenerEmpresa();
            ReportParameter Empresa = new ReportParameter("Empresa", InfEmpresa);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { Empresa });




            this.reportViewer1.RefreshReport();
        }

        public class Conexionsql
        {
            /// <summary>
            /// Retorna Tabla con datos
            /// </summary>
            /// <returns></returns>
            public DataTable Datos(string Fechain, string Fechafin)
            {
                string StrSql = "";

                StrSql = "select AsientoEncabezado_Fecha, Cuenta_Codigo, Cuenta_Descripcion,    "
                         + "   Case when AsientoDetalle_Tipo = 'Debito' then AsientoDetalle.AsientoDetalle_Valor"
                         + "   else 0   end as Debito,"
                         + "   Case when AsientoDetalle_Tipo = 'Credito'"
                         + "   then AsientoDetalle.AsientoDetalle_Valor"
                         + "   else 0   end as Credito"
                         + "   from AsientoDetalle inner join Cuenta on (AsientoDetalle_CodigoCuentaFK = Cuenta.Cuenta_ID)"
                         + "   inner"
                         + "   join AsientoEncabezado on (AsientoEncabezado.AsientoEncabezado_ID = AsientoDetalle.AsientoDetalle_NumeroAsientoFK)"
                         + "   where AsientoEncabezado_Fecha BETWEEN '" + Fechain +  "' and '"+ Fechafin + "'   order by Cuenta_Codigo";

                return clsConexiones.EjecDtaTable(StrSql);
            }



            public string ObtenerEmpresa()
            {
                string sql = "";
                sql = $"Select Empresa_Nombre from Empresa";

                return clsConexiones.EjecString(sql);
            }


            }
    }

}
