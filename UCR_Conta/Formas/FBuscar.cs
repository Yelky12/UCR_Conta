using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseFunciones;

namespace UCR_Conta.Formas
{
    public partial class FBuscar : Form
    {
        int renglon=0;
        public string id;

        DataTable dt = new DataTable();




        public FBuscar(string TipoBusqueda)
        {
            InitializeComponent();
            gridBuscar.ReadOnly = true;
            Mostrar(TipoBusqueda);

        }


        public void Mostrar(string Tipo) {

           

            dt = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable(Tipo);//Depende del tipo buscara el sql
            gridBuscar.DataSource = dt;

            if (gridBuscar.Rows.Count != 0)
            {
                //dt = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable(Tipo);//Depende del tipo buscara el sql
                //gridBuscar.DataSource = dt;

                if (Tipo == "BTP") { this.gridBuscar.Columns["Tercero_ID"].Visible = false; }
                if (Tipo == "BTC") { this.gridBuscar.Columns["Tercero_ID"].Visible = false; }
                if (Tipo == "BA") { this.gridBuscar.Columns["Articulos_ID"].Visible = false; }
                if (Tipo == "AC") { this.gridBuscar.Columns["Cuenta_ID"].Visible = false; }
                if (Tipo == "BAD") { this.gridBuscar.Columns["AsientoEncabezado_ID"].Visible = false; }
                if (Tipo == "TT") { this.gridBuscar.Columns["Tercero_ID"].Visible = false; }
            }

        }

        private void gridBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex; //La variable renglon debe estar previamente declarada y ser de tipo entero
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in gridBuscar.Columns)
            {
                if (column.HeaderText == "Tercero_ID") { id = gridBuscar.Rows[renglon].Cells["Tercero_ID"].Value.ToString(); }
                if (column.HeaderText == "Articulos_ID") { id = gridBuscar.Rows[renglon].Cells["Articulos_ID"].Value.ToString(); }
                if (column.HeaderText == "Cuenta_ID") { id = gridBuscar.Rows[renglon].Cells["Cuenta_ID"].Value.ToString(); }
                if (column.HeaderText == "AsientoEncabezado_ID") { id = gridBuscar.Rows[renglon].Cells["AsientoEncabezado_Documento"].Value.ToString(); }
                if (column.HeaderText == "CompraEncabezado_Documento") { id = gridBuscar.Rows[renglon].Cells["CompraEncabezado_Documento"].Value.ToString(); }
                if (column.HeaderText == "VentaEncabezado_Documento") { id = gridBuscar.Rows[renglon].Cells["VentaEncabezado_Documento"].Value.ToString(); }
            }

            //id = gridBuscar.Rows[renglon].Cells["Tercero_ID"].Value.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in gridBuscar.Columns)
            {
                if (column.HeaderText == "Tercero_ID") 
                { 
                    //id = gridBuscar.Rows[renglon].Cells["Tercero_ID"].Value.ToString();
                    dt.DefaultView.RowFilter = string.Format("Nombre Like'%{0}%'", txtBuscar.Text);
                }

                if (column.HeaderText == "Articulos_ID") 
                { 
                    //id = gridBuscar.Rows[renglon].Cells["Articulos_ID"].Value.ToString();
                   dt.DefaultView.RowFilter = string.Format("Articulos_Descripcion Like'%{0}%'", txtBuscar.Text);
                }

                if (column.HeaderText == "Cuenta_ID")
                {
                    //id = gridBuscar.Rows[renglon].Cells["Articulos_ID"].Value.ToString();

                    dt.DefaultView.RowFilter = string.Format("Cuenta_Descripcion Like'%{0}%'", txtBuscar.Text);
                    //directorio.DefaultView.RowFilter = $"contacto LIKE '{TxtFiltrar.Text}%'";
                    //dt.DefaultView.RowFilter = $"Cuenta_Descripcion LIKE '{txtBuscar.Text}%'";
                }

                if (column.HeaderText == "AsientoEncabezado_ID")
                {
                    //id = gridBuscar.Rows[renglon].Cells["Articulos_ID"].Value.ToString();
                    dt.DefaultView.RowFilter = string.Format("Tercero_Nombre Like'%{0}%'", txtBuscar.Text);
                }

                if (column.HeaderText == "CompraEncabezado_Documento")
                {
                    //id = gridBuscar.Rows[renglon].Cells["Articulos_ID"].Value.ToString();
                    dt.DefaultView.RowFilter = string.Format("Tercero_Nombre Like'%{0}%'", txtBuscar.Text);
                }

                if (column.HeaderText == "VentaEncabezado_Documento")
                {
                    //id = gridBuscar.Rows[renglon].Cells["Articulos_ID"].Value.ToString();
                    dt.DefaultView.RowFilter = string.Format("Tercero_Nombre Like'%{0}%'", txtBuscar.Text);
                }

            }

        }



    }
}
