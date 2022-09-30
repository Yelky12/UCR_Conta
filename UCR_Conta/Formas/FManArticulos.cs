using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using ClaseFunciones;
using ClaseEntidades;
using System.Windows.Forms;

namespace UCR_Conta.Formas
{
    public partial class FManArticulos : Form
    {
        int renglon = 0;
        public FManArticulos()
        {
            InitializeComponent();
            cargarCuentaMadre();
            mostrarArticulos();
        }


        public void cargarCuentaMadre()
        {

            cbCuentaAsoc.DisplayMember = "Cuenta_Descripcion";
            cbCuentaAsoc.ValueMember = "Cuenta_ID";
            cbCuentaAsoc.DataSource = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("AC");//AC=Cuenta Articulos
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsArticulos.Articulos_Descripcion = this.txtDescripcion.Text;
            clsArticulos.Articulos_Medida = this.txtUnidad.Text;
            clsArticulos.Articulos_IDCuentaFK = int.Parse(this.cbCuentaAsoc.SelectedValue.ToString());
            clsArticulos.Articulos_Impuesto = double.Parse( this.txtImpuesto.Text.Replace("%", ""));
            clsArticulos.Articulos_Estado = 1;
            ClaseFunciones.ClassFunciones.EjecutaQueryInsert("AR");//AR=Articulo
            mostrarArticulos();
        }

        public void mostrarArticulos() 
        {

            gridArticulos.DataSource = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("TA");//optiene todos los articulos
            try
            {
                if(gridArticulos.Rows.Count>0)
                { 
                    this.gridArticulos.Columns["Articulos_ID"].Visible = false;
                    gridArticulos.Columns["Cuenta"].Width = 280;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                MessageBox.Show("La tabla esta vacia");
            }

        }

        private void txtImpuesto_Click(object sender, EventArgs e)
        {
            FPorcentaje frm = new FPorcentaje(); //Buscar Cliente Tipo Proveedor
            DialogResult res = frm.ShowDialog();

            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario 2
                txtImpuesto.Text = frm.porcentaje + "%"; //asignamos al texbox el dato de la variable

            }


        }

        private void gridArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex; //La variable renglon debe estar previamente declarada y ser de tipo entero
            txtCodigo.Text = gridArticulos.Rows[renglon].Cells["Articulos_ID"].Value.ToString();
            txtDescripcion.Text = gridArticulos.Rows[renglon].Cells["Descripcion Articulo"].Value.ToString();
            txtUnidad.Text = gridArticulos.Rows[renglon].Cells["Unidad de medida"].Value.ToString();
            cbCuentaAsoc.SelectedIndex = cbCuentaAsoc.FindStringExact(gridArticulos.Rows[renglon].Cells["Cuenta"].Value.ToString());
            txtImpuesto.Text = gridArticulos.Rows[renglon].Cells["Impuesto"].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsArticulos.Articulos_ID = int.Parse(this.txtCodigo.Text);
            clsArticulos.Articulos_Estado = 0;
            ClaseFunciones.ClassFunciones.EjecutaQueryUpdate("CEA");//Cambiar estado de Articulo a eliminado
            mostrarArticulos();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsArticulos.Articulos_ID = int.Parse(txtCodigo.Text);
            clsArticulos.Articulos_Descripcion = this.txtDescripcion.Text;
            clsArticulos.Articulos_Medida = this.txtUnidad.Text;
            clsArticulos.Articulos_IDCuentaFK = int.Parse(this.cbCuentaAsoc.SelectedValue.ToString());
            clsArticulos.Articulos_Impuesto = double.Parse(this.txtImpuesto.Text.Replace("%", ""));
            ClaseFunciones.ClassFunciones.EjecutaQueryUpdate("AA");//Actualizar Articulo
            mostrarArticulos();
        }
    }
}
