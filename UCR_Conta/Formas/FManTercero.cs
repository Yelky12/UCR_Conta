using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClaseFunciones;
using ClaseEntidades;

namespace UCR_Conta.Formas
{
    public partial class FManTercero : Form
    {
        int renglon = 0;
        public FManTercero()
        {
            InitializeComponent();
            Mostrar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tipo = "";
            if (rbtnCliente.Checked == true) tipo = "C";
            if (rbtnProveedor.Checked == true) tipo = "P";
            clsTercero.Tercero_Identificador = txtIdentificador.Text;
            clsTercero.Tercero_Nombre = txtNombre.Text;
            clsTercero.Tercero_Tipo = tipo;
            ClaseFunciones.ClassFunciones.EjecutaQueryInsert("TE");//TE=Insertar Tercero
            Mostrar();
        }


        public void Mostrar() {
            gridTercero.DataSource = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("TT");//optiene todos los terceros
            this.gridTercero.Columns["Tercero_ID"].Visible = false;
        }

        private void gridTercero_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex; //La variable renglon debe estar previamente declarada y ser de tipo entero

            lblID.Text = gridTercero.Rows[renglon].Cells["Tercero_ID"].Value.ToString();
            txtIdentificador.Text = gridTercero.Rows[renglon].Cells["Indentificador"].Value.ToString();
            txtNombre.Text = gridTercero.Rows[renglon].Cells["Nombre"].Value.ToString();

            string tipo = gridTercero.Rows[renglon].Cells["Tipo"].Value.ToString();
            if (tipo == "C") rbtnCliente.Checked = true;
            if (tipo == "P") rbtnProveedor.Checked = true;
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsTercero.Tercero_Identificador = txtIdentificador.Text;
            ClaseFunciones.ClassFunciones.EjecutaQueryDelete("DT");//DE=Borrar Tercero
            Mostrar();
        }
    }
}
