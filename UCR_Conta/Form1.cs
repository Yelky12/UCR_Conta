using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCR_Conta.Formas;


namespace UCR_Conta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCatCuenta_Click(object sender, EventArgs e)
        {
            FManCatCuentas frm = new FManCatCuentas();
            frm.Show();
        }

        private void btnCompas_Click(object sender, EventArgs e)
        {
            FCompras frm = new FCompras();
            frm.Show();
        }

        private void btnArticulo_Click(object sender, EventArgs e)
        {
            FManArticulos frm = new FManArticulos();
            frm.Show();
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FManEmpresa frm = new FManEmpresa();
            frm.Show();
        }

        private void btnTercero_Click(object sender, EventArgs e)
        {
            FManTercero frm = new FManTercero();
            frm.Show();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            FVentas frm = new FVentas();
            frm.Show();
        }

        private void btnConfigServ_Click(object sender, EventArgs e)
        {
            FManServer frm = new FManServer();
            frm.Show();
        }

        private void btnAsiento_Click(object sender, EventArgs e)
        {
            FAsientoDiario frm = new FAsientoDiario();
            frm.Show();

        }

        private void btnLibMayo_Click(object sender, EventArgs e)
        {

        }

        private void btnMac_Click(object sender, EventArgs e)
        {
            FVerMac frm = new FVerMac();
            frm.Show();
        }

        private void btnCentCosto_Click(object sender, EventArgs e)
        {
            FManCentroCost frm = new FManCentroCost();
            frm.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FReportesPrincipal frm = new FReportesPrincipal();
            frm.Show();
        }
    }
}
