using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClaseFunciones;

namespace UCR_Conta.Formas
{
    public partial class FManCatCuentas : Form
    {
        public FManCatCuentas()
        {
            InitializeComponent();
            cargarCuentaMadre();
        }



        public void cargarCuentaMadre()
        {

            cbCuentaMadre.DisplayMember = "Cuenta_Descripcion";
            cbCuentaMadre.DisplayMember = "Cuenta_ID";
            cbCuentaMadre.DataSource = ClaseFunciones.ClassFunciones.EjecutaQuery;
        }



    }
}
