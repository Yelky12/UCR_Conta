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
    public partial class FManCatCuentas : Form
    {
        int renglon = 0;
        public FManCatCuentas()
        {
            InitializeComponent();
            cargarCuentaMadre();
            cargarCentroCosto();
            mostrarCuentas();
        }



        public void cargarCuentaMadre()
        {

            cbCuentaMadre.DisplayMember = "Cuenta_Descripcion";
            cbCuentaMadre.ValueMember = "Cuenta_ID";
            cbCuentaMadre.DataSource = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("CM");//CM=Cuenta madre
        }

        public void cargarCentroCosto()
        {
            cbCentroCosto.DisplayMember = "CentroDeCostos_Descripcion";
            cbCentroCosto.ValueMember = "CentroDeCostos_ID";
            cbCentroCosto.DataSource = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("CC");//CM=Centro Costo
        }




        public void cargarCuenta_Codigo(object sender, EventArgs e)
        {
           
            //clsCuenta.Cuenta_Madre = int.Parse(this.cbCuentaMadre.SelectedValue.ToString());
            //txtId.Text = ClaseFunciones.ClassFunciones.EjecutaQueryString("OCM");//OCM=Obtener Cuenta madre
        }



        public void RefresacarcargarCuentaMadre()
        {

            cbCuentaMadre.DisplayMember = "Cuenta_Descripcion";
            cbCuentaMadre.ValueMember = "Cuenta_ID";
            cbCuentaMadre.DataSource = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("CM");//CM=Cuenta madre
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Cuenta_Tipo = 0;
            if (rbtnMadre.Checked == true) Cuenta_Tipo = 1;
            if (rbtnIntermedia.Checked == true) Cuenta_Tipo = 2;
            if (rbtnUltimo.Checked == true) Cuenta_Tipo = 3;
            clsCuenta.Cuenta_Descripcion = this.txtDescrip.Text;
            clsCuenta.Cuenta_Madre = int.Parse( this.cbCuentaMadre.SelectedValue.ToString());
            clsCuenta.Cuenta_Tipo = Cuenta_Tipo;
            clsCuenta.Cuenta_Codigo = txtId.Text;
            clsCuenta.Cuenta_CentroCostoFK = int.Parse(this.cbCentroCosto.SelectedValue.ToString());
            ClaseFunciones.ClassFunciones.EjecutaQueryInsert("CM");//CM=Cuenta madre
            RefresacarcargarCuentaMadre();
            mostrarCuentas();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            clsCuenta.Cuenta_Codigo = this.txtId.Text;
            ClaseFunciones.ClassFunciones.EjecutaQueryDelete("DC");//--DC=Delete cuenta
            RefresacarcargarCuentaMadre();
        }

      

        public void mostrarCuentas() 
        {
            gridCuentas.DataSource = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("TC");//optiene todas las cuentas
            //this.gridCuentas.Columns["ConfgEstadoResultado_ID"].Visible = false;

        }

        private void gridCuentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex; //La variable renglon debe estar previamente declarada y ser de tipo entero

            rbtnMadre.Checked = false;
            rbtnIntermedia.Checked = false;
            rbtnUltimo.Checked = false;
            txtId.Text = "";
            txtId.Text = gridCuentas.Rows[renglon].Cells["Codigo Cuenta"].Value.ToString();
            txtDescrip.Text = gridCuentas.Rows[renglon].Cells["Descripcion"].Value.ToString();
            
            //----Llenar los Radio Butons
            string Tipo = gridCuentas.Rows[renglon].Cells["Tipo"].Value.ToString();
            if (Tipo.Equals("1")) rbtnMadre.Checked = true;
            if (Tipo.Equals("2")) rbtnIntermedia.Checked = true;
            if (Tipo.Equals("3")) rbtnUltimo.Checked = true;

            //----Obtener el string de la Cuenta Madre
            string CMadre = gridCuentas.Rows[renglon].Cells["Cuenta Madre"].Value.ToString(); // Se optiene el ID de la cuenta madre
            ClaseEntidades.clsCuenta.Cuenta_Madre = int.Parse(CMadre);                        // Se combierte en un entero y se guarda en la entidad
            string StringNombre = ClaseFunciones.ClassFunciones.EjecutaQueryString("NCM");    // Obtiene la descripcion de la cuenta madre -->NombreCuentaMadre
            if (StringNombre == "" || StringNombre == null)
            {
                MessageBox.Show("No se encuentra la cuenta madre, por favor actualizarla");
                cbCuentaMadre.Text = "";
            }
            else
            {
                cbCuentaMadre.SelectedIndex = cbCuentaMadre.FindStringExact(StringNombre);             // Setea el Nombre con el Index del ComboBox para mostra el que tiene la misma descripcion
            }
            //---
            string CCostos = gridCuentas.Rows[renglon].Cells["Centro de Costos"].Value.ToString();
            cbCentroCosto.SelectedIndex = cbCentroCosto.FindStringExact(CCostos);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            clsCuenta.Cuenta_ID = int.Parse(gridCuentas.Rows[renglon].Cells["Cuenta_ID"].Value.ToString());
            int Cuenta_Tipo = 0;
            if (rbtnMadre.Checked == true) Cuenta_Tipo = 1;
            if (rbtnIntermedia.Checked == true) Cuenta_Tipo = 2;
            if (rbtnUltimo.Checked == true) Cuenta_Tipo = 3;
            clsCuenta.Cuenta_Descripcion = this.txtDescrip.Text;
            clsCuenta.Cuenta_Madre = int.Parse(this.cbCuentaMadre.SelectedValue.ToString());
            clsCuenta.Cuenta_Tipo = Cuenta_Tipo;
            clsCuenta.Cuenta_Codigo = txtId.Text;
            clsCuenta.Cuenta_CentroCostoFK = int.Parse(this.cbCentroCosto.SelectedValue.ToString());
            ClaseFunciones.ClassFunciones.EjecutaQueryUpdate("ACC");//ACC=Actualizar Catalogo de Cuentas
            RefresacarcargarCuentaMadre();
            mostrarCuentas();

        }
    }
}
