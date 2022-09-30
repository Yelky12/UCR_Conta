using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClaseEntidades;
using ClaseFunciones;

namespace UCR_Conta.Formas
{
    public partial class FManEmpresa : Form
    {
        public FManEmpresa()
        {
            InitializeComponent();
            MostrarEmpresa();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsEmpresa.Empresa_Nombre = txtEmpresa.Text;
            ClaseFunciones.ClassFunciones.EjecutaQueryUpdate("AE");
            MostrarEmpresa();
        }


        public void MostrarEmpresa() { 
            txtEmpresa.Text = ClaseFunciones.ClassFunciones.EjecutaQueryString("ME");
        }

    }
}
