using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCR_Conta.Formas
{
    public partial class FConfiEstResul : Form
    {
        public FConfiEstResul()
        {
            InitializeComponent();
            cargarCuentaMadre();
            MostrarConfigEstRes();
        }


        public void cargarCuentaMadre()
        {
                cmbCuentas.DisplayMember = "Cuenta_Descripcion";
                cmbCuentas.ValueMember = "Cuenta_ID";
                cmbCuentas.DataSource = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("AC");//CM=Cuenta madre
        }

        public void MostrarConfigEstRes()
        {
            dGridConfiResl.DataSource = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("CER");//optiene todas las configuracion de estado Resultado
            this.dGridConfiResl.Columns["ConfgEstadoResultado_ID"].Visible = false;

        }





        private void btnAddVentas_Click(object sender, EventArgs e)
        {
            string Tipo = "";
            int Orden = 0;
            string Naturaleza = "";

            if (rbtVentas.Checked)
            { Tipo = "VENTAS"; Orden = 1; }
            if (rbtCostVentas.Checked)
            { Tipo = "COSTO_VENTAS"; Orden = 2; }
            if (rbtGAdmin.Checked)
            { Tipo = "GASTOS_ADMINISTRATIVOS"; Orden = 3; }
            if (rbtGVentas.Checked)
            { Tipo = "GASTOS_VENTAS"; Orden = 4; }
            if (rbtGFinancie.Checked)
            { Tipo = "GASTOS_FIANCIEROS"; Orden = 5; }
            if (rbtImpuest.Checked)
            { Tipo = "IMPUESTOS"; Orden = 6; }

            if (rbtSuma.Checked)
            { Naturaleza = "SUMA"; }
            else
            { Naturaleza= "RESTA"; }

            

            ClaseEntidades.clsConfgEstResul.clsConfgEstResul_NombreTitulo = Tipo;
            ClaseEntidades.clsConfgEstResul.clsConfgEstResul_Orden = Orden;
            ClaseEntidades.clsConfgEstResul.clsConfgEstResul_CuentasFK= int.Parse(this.cmbCuentas.SelectedValue.ToString());
            ClaseEntidades.clsConfgEstResul.clsConfgEstResul_Naturaleza = Naturaleza;
            ClaseEntidades.clsConfgEstResul.clsConfgEstResul_Empresa = ClaseFunciones.ClassFunciones.EjecutaQueryString("ME");

            ClaseFunciones.ClassFunciones.EjecutaQueryInsert("ICCER");//Agrega la cuenta a la tabla configuracion de estado Resultado
            MostrarConfigEstRes();
        }

  
    }
}
