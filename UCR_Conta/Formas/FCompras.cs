using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClaseEntidades;
//using UCR_Conta.Validator;
using Validator;

namespace UCR_Conta.Formas
{
    public partial class FCompras : Form
    {
        int Globalcolumna = 0;
        int GlobalDocumento = 0;
        Boolean ErrorVal;
        DataTable dt = new DataTable();
        DataTable dtDetalle = new DataTable();
        string Estado = "";

        public FCompras()
        {
            InitializeComponent();
            //Bloquear la columna
            gridCompras.Columns[5].ReadOnly = true;
            gridCompras.Columns[6].ReadOnly = true;
            gridCompras.Columns[1].ReadOnly = true;
            //Colocar fecha
            //txtMskFecha.Text = Convert.ToDateTime(DateTime.Now).ToString();
            txtMskFecha.Text = string.Format("{0:MM/dd/yyyy}", DateTime.Now);
            txtMskFecha.ReadOnly = true;

        }



        private void gridCompras_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (ErrorVal == false && e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4)
            {
                ActualizarGravado();
                ActualizarTotalLinea();
                ActualizarSubTotal();
            }



        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            //if (txtDesc.Text == "")
            //{ txtDesc.Text = "0"; }
            //ActualizarSubTotal();
        }

        private void txtIdCliente_Click(object sender, EventArgs e)
        {
            FBuscar frm = new FBuscar("BTP"); //Buscar Cliente Tipo Proveedor
            DialogResult res = frm.ShowDialog();

            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario 2
                txtIdCliente.Text = frm.id; //asignamos al texbox el dato de la variable

            }
        }






        public void ActualizarTotalLinea() {

            int Contador;
            int Precio;
            int Cantidad;
            double TotalLinea;
            double PorcentajeImpuesto;

            // Iterate through the rows, skipping the Starting TotalLinea row.
            for (Contador = 1; Contador <= (gridCompras.Rows.Count - 1);
                Contador++)
            {
                Precio = 0;
                Cantidad = 0;


                if (gridCompras.Rows[Contador - 1].Cells["Precio"].Value != null)
                {
                    // Verify that the cell value is not an empty string.
                    if (gridCompras.Rows[Contador - 1]
                        .Cells["Precio"].Value.ToString().Length != 0)
                    {
                        Precio = int.Parse(gridCompras.Rows[Contador - 1]
                            .Cells["Precio"].Value.ToString());
                    }
                }

                if (gridCompras.Rows[Contador - 1].Cells["Cantidad"].Value != null)
                {
                    if (gridCompras.Rows[Contador - 1]
                        .Cells["Cantidad"].Value.ToString().Length != 0)
                    {
                        Cantidad = int.Parse(gridCompras.Rows[Contador - 1]
                            .Cells["Cantidad"].Value.ToString());
                    }
                }



                //TotalLinea = (Precio * Cantidad);
                if (gridCompras.Rows[Contador - 1].Cells["Gravado"].Value != null)
                {
                    // Verify that the cell value is not an empty string.
                    if (gridCompras.Rows[Contador - 1].Cells["Gravado"].Value.ToString().Length != 0)
                    {
                        if (gridCompras.Rows[Contador - 1].Cells["Gravado"].Value.ToString().Contains("Si"))
                        {
                            gridCompras.Rows[Contador - 1].Cells["TotalLinea"].Value =
                            ((Precio * Cantidad) + double.Parse(gridCompras.Rows[Contador - 1].Cells["Impuesto"].Value.ToString())).ToString();
                        }
                    }
                }
                else

                {
                    gridCompras.Rows[Contador - 1].Cells["TotalLinea"].Value =
                        (Precio * Cantidad).ToString();
                }





            }


        }





        public void ActualizarGravado()
        {

            int Contador;
            float TotalLinea;
            double Impuesto;
            double TotalGravado;
            TotalGravado = 0;
            TotalLinea = 0;

            // Iterate through the rows, skipping the Starting TotalLinea row.
            for (Contador = 1; Contador <= (gridCompras.Rows.Count - 1);
                Contador++)
            {

                if (gridCompras.Rows[Contador - 1].Cells["Gravado"].Value != null)
                {
                    // Verify that the cell value is not an empty string.
                    if (gridCompras.Rows[Contador - 1].Cells["Gravado"].Value.ToString().Length != 0)
                    {
                        if (gridCompras.Rows[Contador - 1].Cells["Gravado"].Value.ToString().Contains("Si"))
                        {

                            TotalLinea = TotalLinea + float.Parse(gridCompras.Rows[Contador - 1]
                            .Cells["TotalLinea"].Value.ToString());

                            ClaseEntidades.clsArticulos.Articulos_ID = int.Parse(gridCompras.Rows[Contador - 1].Cells["Codigo"].Value.ToString());
                            //Obtener impuesto de articulo
                            Impuesto = double.Parse(ClaseFunciones.ClassFunciones.EjecutaQueryString("OIA")) / 100;
                            gridCompras.Rows[Contador - 1].Cells["Impuesto"].Value =
                            (int.Parse(gridCompras.Rows[Contador - 1].Cells["Cantidad"].Value.ToString()) * int.Parse(gridCompras.Rows[Contador - 1].Cells["Precio"].Value.ToString()))
                            * Impuesto;

                        }
                        else
                        {
                            gridCompras.Rows[Contador - 1].Cells["Impuesto"].Value = 0;
                        }
                    }
                }

                if (gridCompras.Rows[Contador - 1].Cells["Gravado"].Value != null)
                {
                    // Verify that the cell value is not an empty string.
                    if (gridCompras.Rows[Contador - 1].Cells["Gravado"].Value.ToString().Length != 0)
                    {
                        if (gridCompras.Rows[Contador - 1].Cells["Gravado"].Value.ToString().Contains("Si"))
                        {
                            TotalGravado = TotalGravado + double.Parse(gridCompras.Rows[Contador - 1].Cells["Impuesto"].Value.ToString());

                        }
                    }
                }





            }

            //this.txtGravado.Text = String.Format("{0:0,0.00}", TotalLinea*0.13);
            this.txtGravado.Text = TotalGravado + "";

        }



        public void ActualizarSubTotal()
        {

            int Contador;
            float SubTotal;
            float Impuesto;
            float Total;
            float Descuento;

            Impuesto = 0;
            SubTotal = 0;
            Total = 0;
            Descuento = 0;

            // Iterate through the rows, skipping the Starting TotalLinea row.
            for (Contador = 1; Contador <= (gridCompras.Rows.Count - 1);
                Contador++)
            {

                if (gridCompras.Rows[Contador - 1].Cells["TotalLinea"].Value != null)
                {
                    // Verify that the cell value is not an empty string.
                    if (gridCompras.Rows[Contador - 1].Cells["TotalLinea"].Value.ToString().Length != 0)
                    {

                        SubTotal = SubTotal + float.Parse(gridCompras.Rows[Contador - 1]
                        .Cells["TotalLinea"].Value.ToString());

                    }
                }


            }

            this.txtSubTotal.Text = String.Format("{0:0,0.00}", SubTotal);
            Impuesto = (float)( SubTotal * 0.13);
            this.txtImpuesto.Text = String.Format("{0:0,0.00}", Impuesto);

            //if (txtDesc.TextLength > 0)
            //{
            //Descuento = SubTotal * (float.Parse(txtDesc.Text))/100;
            //}


            //Total = (SubTotal + Impuesto)- Descuento;
            //this.txtTotal.Text = String.Format("{0:0,0.00}", Total);

        }

        

        private void btnAddDesc_Click(object sender, EventArgs e)
        {
            AplicarDescuento();
        }

        public void AplicarDescuento()
        {
            //ActualizarSubTotal();
            float Descuento;
            float SubTotal;
            float NewDescTotal;

            Descuento = float.Parse(txtDesc.Text);
            SubTotal = float.Parse(txtSubTotal.Text);
            NewDescTotal = 0;

            if (txtDesc.Text != "0")
            {

                NewDescTotal = SubTotal * (Descuento/100);
            }

            this.txtDescTotal.Text = String.Format("{0:0,0.00}", NewDescTotal);

        }

        public void ActualizarTotal()
        {
            //ActualizarSubTotal();
            float DescuentoTotal;
            float SubTotal;
            float Impuesto;
            float Total;

            DescuentoTotal = float.Parse(txtDescTotal.Text);
            SubTotal = float.Parse(txtSubTotal.Text);
            Impuesto = float.Parse(txtImpuesto.Text);
            Total = 0;

            Total = (SubTotal - DescuentoTotal) + Impuesto;
            

            this.txtTotal.Text = String.Format("{0:0,0.00}", Total);

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            //---Se necesita el subTotal en la tabla?
            int Moneda = 0;
            string FechaVen;

            if (ErrorVal == false)
            {
                //--------------------Ingreso de Encabezado-------------------------
                FechaVen = pickerVencimiento.Value.ToString("MM/dd/yyyy");
                GlobalDocumento = int.Parse(ClaseFunciones.ClassFunciones.EjecutaQueryString("CEDM")) + 1;// Obtener el documento mayor y sumarle un uno
                clsMoneda.Moneda_Nombre = (string)this.cmbMoneda.SelectedItem;
                if (clsMoneda.Moneda_Nombre != null)
                {
                    Moneda = int.Parse(ClaseFunciones.ClassFunciones.EjecutaQueryString("MO"));
                }
                else
                {
                    MessageBox.Show("Por favor selecciones una moneda");
                    return;
                }
                clsCompraEncabezado.CompraEncabezado_Documento = GlobalDocumento;
                clsCompraEncabezado.CompraEncabezado_Vencimiento = FechaVen;
                clsCompraEncabezado.CompraEncabezado_IDClienteFK = int.Parse(this.txtIdCliente.Text);
                clsCompraEncabezado.CompraEncabezado_Fecha = this.txtMskFecha.Text;
                clsCompraEncabezado.CompraEncabezado_IDMonedaFK = Moneda.ToString();
                if ((string)this.cmbCondicion.SelectedItem != null)
                {
                    clsCompraEncabezado.CompraEncabezado_Condicion = (string)this.cmbCondicion.SelectedItem;
                }
                else
                {
                    MessageBox.Show("Por favor selecciones una condicion de pago");
                    return;
                }
                clsCompraEncabezado.CompraEncabezado_Gravado = double.Parse(this.txtGravado.Text);
                clsCompraEncabezado.CompraEncabezado_Descuento = double.Parse(this.txtDesc.Text);
                clsCompraEncabezado.CompraEncabezado_Impuesto = double.Parse(this.txtImpuesto.Text);
                clsCompraEncabezado.CompraEncabezado_Total = double.Parse(this.txtTotal.Text);
                //Enviar a tabla
                ClaseFunciones.ClassFunciones.EjecutaQueryInsert("CE");//Insertar Encabezado

                int CantDetalle = 0;
                CantDetalle = gridCompras.RowCount;
                string CharGravado = "";


                for (int i = 0; i < gridCompras.Rows.Count - 1; i++)
                {


                    if (gridCompras.Rows[i].Cells["Gravado"].Value.ToString() == "Si") { CharGravado = "T"; } else { CharGravado = "F"; }
                    clsCompraDetalle.CompraDetalle_IdEncabezadoFK = int.Parse(ClaseFunciones.ClassFunciones.EjecutaQueryString("CEID"));
                    clsCompraDetalle.CompraDetalle_ArticuloFK = int.Parse(gridCompras.Rows[i].Cells["Codigo"].Value.ToString());
                    clsCompraDetalle.CompraDetalle_Cant = double.Parse(gridCompras.Rows[i].Cells["Cantidad"].Value.ToString());
                    clsCompraDetalle.CompraDetalle_Precio = double.Parse(gridCompras.Rows[i].Cells["Precio"].Value.ToString());
                    clsCompraDetalle.CompraDetalle_Gravado = CharGravado;
                    clsCompraDetalle.CompraDetalle_Impuesto = double.Parse(gridCompras.Rows[i].Cells["Impuesto"].Value.ToString());
                    clsCompraDetalle.CompraDetalle_Total = double.Parse(gridCompras.Rows[i].Cells["TotalLinea"].Value.ToString());

                    //Enviar a tabla
                    ClaseFunciones.ClassFunciones.EjecutaQueryInsert("CD");//Insertar Detalle
                }

                txtNDoc.Text = GlobalDocumento.ToString();
                MessageBox.Show("Se ha ingresado correctamente la factura numero :" + GlobalDocumento.ToString());

            }
        }


        private void gridCompras_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Globalcolumna = e.ColumnIndex; //La variable renglon debe estar previamente declarada y ser de tipo entero
            if (Globalcolumna == 0 && Estado != "BuscarCompra")
            {
                //MessageBox.Show("Columna " + Globalcolumna);

                FBuscar frm = new FBuscar("BA"); //Buscar todos los articulos
                DialogResult res = frm.ShowDialog();

                if (res == DialogResult.OK)
                {
                    //recuperando la variable publica del formulario 2
                    string val = frm.id;
                    gridCompras.Rows[e.RowIndex].Cells["Codigo"].Value = val; //asignamos al texbox el dato de la variable
                    ClaseEntidades.clsArticulos.Articulos_ID = int.Parse(val);
                    gridCompras.Rows[e.RowIndex].Cells["Descripcion"].Value = ClaseFunciones.ClassFunciones.EjecutaQueryString("DA");
                }

            }
        }

        private void gridCompras_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //https://webprogramacion.com/368/csharp/validar-datos-de-una-celda-en-un-datagridview.aspx
            GValidator ObjValida = new GValidator();
            string mensaje = "";

            if (!gridCompras.Rows[e.RowIndex].IsNewRow)
            {
                //======================Cantidad========================
                if (e.ColumnIndex == 2)
                {
                    mensaje = ObjValida.ValidarCampoNumPositMensaje(e.FormattedValue.ToString());

                    if (mensaje.Contains("|"))
                    {
                        MessageBox.Show(mensaje, "Error de validación",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }

                //======================Precio========================
                if (e.ColumnIndex == 3)
                {
                    mensaje = ObjValida.ValidarCampoNumPositMensaje(e.FormattedValue.ToString());

                    if (mensaje.Contains("|") && ErrorVal == false)
                    {
                        MessageBox.Show(mensaje, "Error de validación",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }




        public Boolean Validar()
        {

            GValidator ObjValida = new GValidator();
            string errStr = "";

            for (int i = 0; i < gridCompras.Rows.Count - 1 && errStr == ""; i++)
            {

                if (ObjValida.ValidarCampoNumPositMensaje((gridCompras.Rows[i].Cells["Cantidad"].Value.ToString())).Contains("|"))
                {
                    errStr = errStr + "1";
                }

                if (ObjValida.ValidarCampoNumPositMensaje((gridCompras.Rows[i].Cells["Precio"].Value.ToString())).Contains("|"))
                {
                    errStr = errStr + "1";
                }

            }


            if (errStr.Contains("1"))
            {
                MessageBox.Show("No se guardará la informacion, por favor revise las columnas Cantidad y Precio ", "Error de validación",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FBuscar frm = new FBuscar("BCT"); //Buscar Compras Todas 
            DialogResult res = frm.ShowDialog();

            if (res == DialogResult.OK)
            {
                //--Cambio de estado
                Estado = "BuscarCompra";
                //recuperando la variable publica del formulario 2
                txtNDoc.Text = frm.id; //asignamos al texbox el dato de la variable
                //Limpiar Grid
                gridCompras.Rows.Clear();
                gridCompras.Refresh();
                ClaseEntidades.clsCompraEncabezado.CompraEncabezado_ID = int.Parse(txtNDoc.Text);
                dt = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("OCE");//Obtener el encabezado compras

                foreach (DataRow row in dt.Rows) {
                    ClaseEntidades.clsCompraEncabezado.CompraEncabezado_ID = int.Parse(row[0].ToString());
                    ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Documento = int.Parse(row[1].ToString());
                    ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Vencimiento = row[2].ToString();
                    ClaseEntidades.clsCompraEncabezado.CompraEncabezado_IDClienteFK = int.Parse(row[3].ToString());
                    ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Fecha = row[4].ToString();
                    ClaseEntidades.clsCompraEncabezado.CompraEncabezado_IDMonedaFK = row[5].ToString();
                    ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Condicion = row[6].ToString();
                    ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Gravado = float.Parse(row[7].ToString());
                    ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Descuento = float.Parse(row[8].ToString());
                    ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Impuesto = float.Parse(row[9].ToString());
                    ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Total = float.Parse(row[10].ToString());
                }
                //Cargarlos a los txt
                txtIdCliente.Text = ClaseEntidades.clsCompraEncabezado.CompraEncabezado_IDClienteFK.ToString();
                DateTime ComDate = DateTime.Parse(ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Vencimiento.ToString());
                pickerVencimiento.Value = ComDate;
                txtIdCliente.Text = ClaseEntidades.clsCompraEncabezado.CompraEncabezado_IDClienteFK.ToString();
                DateTime ComDate2 = DateTime.Parse(ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Fecha.ToString());
                txtMskFecha.Text = ComDate2.ToString("MM/dd/yyyy");
                cmbMoneda.SelectedIndex = int.Parse(ClaseEntidades.clsCompraEncabezado.CompraEncabezado_IDMonedaFK.ToString()) - 1;
                cmbCondicion.Text = ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Condicion.ToString();
                txtGravado.Text = ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Gravado.ToString();
                txtDesc.Text = ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Descuento.ToString();
                txtImpuesto.Text = ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Impuesto.ToString();
                txtTotal.Text = ClaseEntidades.clsCompraEncabezado.CompraEncabezado_Total.ToString();

                dtDetalle = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("OCD");//Obtener el Detalle compras
                int Lineas = 0;
                foreach (DataRow row in dtDetalle.Rows)
                {
                    ClaseEntidades.clsCompraDetalle.CompraDetalle_ID = int.Parse(row[0].ToString());
                    ClaseEntidades.clsCompraDetalle.CompraDetalle_IdEncabezadoFK = int.Parse(row[1].ToString());
                    ClaseEntidades.clsCompraDetalle.CompraDetalle_ArticuloFK = int.Parse(row[2].ToString());
                    ClaseEntidades.clsCompraDetalle.CompraDetalle_Cant = float.Parse(row[3].ToString());
                    ClaseEntidades.clsCompraDetalle.CompraDetalle_Precio = float.Parse(row[4].ToString());
                    ClaseEntidades.clsCompraDetalle.CompraDetalle_Gravado = row[5].ToString();
                    ClaseEntidades.clsCompraDetalle.CompraDetalle_Impuesto = float.Parse(row[6].ToString());
                    ClaseEntidades.clsCompraDetalle.CompraDetalle_Total = float.Parse(row[7].ToString());

                    //gridCompras
                    gridCompras.Rows.Add();
                    gridCompras.Rows[Lineas].Cells[0].Value = ClaseEntidades.clsCompraDetalle.CompraDetalle_ArticuloFK;
                    ClaseEntidades.clsArticulos.Articulos_ID = ClaseEntidades.clsCompraDetalle.CompraDetalle_ArticuloFK;
                    gridCompras.Rows[Lineas].Cells[1].Value = ClaseFunciones.ClassFunciones.EjecutaQueryString("DA");
                    gridCompras.Rows[Lineas].Cells[2].Value = ClaseEntidades.clsCompraDetalle.CompraDetalle_Cant;
                    gridCompras.Rows[Lineas].Cells[3].Value = ClaseEntidades.clsCompraDetalle.CompraDetalle_Precio;
                    //if (gridCompras.Rows[i].Cells["Gravado"].Value.ToString() == "Si") { CharGravado = "T"; } else { CharGravado = "F"; }
                    if (ClaseEntidades.clsCompraDetalle.CompraDetalle_Gravado == "T") { gridCompras.Rows[Lineas].Cells[4].Value = "Si"; } else { gridCompras.Rows[Lineas].Cells[4].Value = "No"; }
                    //gridCompras.Rows[Lineas].Cells[4].Value = ClaseEntidades.clsCompraDetalle.CompraDetalle_Gravado;
                    gridCompras.Rows[Lineas].Cells[5].Value = ClaseEntidades.clsCompraDetalle.CompraDetalle_Impuesto;
                    gridCompras.Rows[Lineas].Cells[6].Value = ClaseEntidades.clsCompraDetalle.CompraDetalle_Total;
                    Lineas = Lineas + 1;
                }


                Estado = "";
            }

            //if (txtNDoc.Text == "")
            //{
            //    clsCompraEncabezado.CompraEncabezado_ID = int.Parse( txtNDoc.Text);
            //    ClaseFunciones.ClassFunciones.EjecutaQueryInsert("");//Insertar Encabezado

            //}



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCalTotal_Click(object sender, EventArgs e)
        {
            ActualizarTotal();

        }
    }
 }
