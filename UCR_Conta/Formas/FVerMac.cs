using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseEntidades;

namespace UCR_Conta.Formas
{
    public partial class FVerMac : Form
    {
        public FVerMac()
        {
            InitializeComponent();
        }

        private void btnObtMac_Click(object sender, EventArgs e)
        {
            clsMac.MacNum = ClaseFunciones.ClassFunciones.MantenimientoMac("OM");
            lblMac.Text = clsMac.MacNum.ToString();
        }

        private void btnEnvMac_Click(object sender, EventArgs e)
        {
            ClaseFunciones.ClassFunciones.MantenimientoMac("EM");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsMac.MacNum = ClaseFunciones.ClassFunciones.MantenimientoMac("OM");
            lblMac.Text = clsMac.MacNum.ToString();

            string TipoEstatus = ClaseFunciones.ClassFunciones.MantenimientoMac("VM");

            if (TipoEstatus == "1")
            {
                lblStatus.Text = "Activo";
            }
            else
            {
                lblStatus.Text = "Inactivo";
            }
            
        }
    }
}
