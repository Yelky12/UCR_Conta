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
using ClaseFunciones;


namespace UCR_Conta.Formas
{
    
    public partial class FManCentroCost : Form
    {
        int renglon = 0;
        public FManCentroCost()
        {
            InitializeComponent();
            mostrarCentroCostos();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            clsCentroCostos.CentroDeCostos_CentroDeCostos = txtCodigo.Text;
            clsCentroCostos.CentroDeCostos_Descripcion = txtDescripcion.Text;
            if (ChkEsUltimo.Checked)
            {
                clsCentroCostos.CentroDeCostos_EsUltimoNivel = "T";
            }
            else 
            {
                clsCentroCostos.CentroDeCostos_EsUltimoNivel = "F";
            }
            clsCentroCostos.CentroDeCostos_Comentarios = TxtComent.Text;
            //Enviar a tabla
            ClaseFunciones.ClassFunciones.EjecutaQueryInsert("ICC");//Insertar Centro Costos
            MessageBox.Show("Se ha ingresado correctamente el centro de costos :" + txtCodigo.Text);
            mostrarCentroCostos();
        }




        public void mostrarCentroCostos()
        {
            gridCentCosto.DataSource = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("OTC");//Obtiene todos los centros de Costos
            this.gridCentCosto.Columns["CentroDeCostos_ID"].Visible = false;
            gridCentCosto.Columns["CentroDeCostos_CentroDeCostos"].Width = 280;
        }

        private void gridCentCosto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex; //La variable renglon debe estar previamente declarada y ser de tipo entero

            ChkEsUltimo.Checked = false;


            txtCodigo.Text = gridCentCosto.Rows[renglon].Cells["CentroDeCostos_CentroDeCostos"].Value.ToString();
            txtDescripcion.Text = gridCentCosto.Rows[renglon].Cells["CentroDeCostos_Descripcion"].Value.ToString();

            //----Llenar los Radio Butons
            string Tipo = gridCentCosto.Rows[renglon].Cells["CentroDeCostos_EsUltimoNivel"].Value.ToString();
            if (Tipo.Equals("T")) ChkEsUltimo.Checked = true;
            if (Tipo.Equals("F")) ChkEsUltimo.Checked = false;

            TxtComent.Text = gridCentCosto.Rows[renglon].Cells["CentroDeCostos_Comentarios"].Value.ToString();

            // Setea el Nombre con el Index del ComboBox para mostra el que tiene la misma descripcion




        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            clsCentroCostos.CentroDeCostos_CentroDeCostos = txtCodigo.Text;
            //Eliminar registro
            ClaseFunciones.ClassFunciones.EjecutaQueryInsert("ICC");//Insertar Centro Costos


        }
    }
}
