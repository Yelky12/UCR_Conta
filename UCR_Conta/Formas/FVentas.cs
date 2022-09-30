using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClaseEntidades;
using Validator;

namespace UCR_Conta.Formas
{
    public partial class FVentas : Form
    {
        int Globalcolumna = 0;
        int GlobalDocumento = 0;
        Boolean ErrorVal;
        string errstr = "";
        DataTable dt = new DataTable();
        DataTable dtDetalle = new DataTable();
        string Estado = "";

        public FVentas()
        {
            InitializeComponent();
            //Bloquear la columna
            gridVentas.Columns[5].ReadOnly = true;
            gridVentas.Columns[6].ReadOnly = true;
            gridVentas.Columns[1].ReadOnly = true;
            //Colocar fecha
            //txtMskFecha.Text = Convert.ToDateTime(DateTime.Now).ToString();
            txtMskFecha.Text = string.Format("{0:MM/dd/yyyy}", DateTime.Now);
            txtMskFecha.ReadOnly = true;
        }





        

        private void gridVentas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
            if (txtDesc.Text == "") 
            { txtDesc.Text = "0"; }
            ActualizarSubTotal();
        }

        private void txtIdCliente_Click(object sender, EventArgs e)
        {
            FBuscar frm = new FBuscar("BTC"); //Buscar Cliente Tipo Cliente
            DialogResult res = frm.ShowDialog();

            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario 2
                txtIdCliente.Text = frm.id; //asignamos al texbox el dato de la variable

            }
        }


        public void ActualizarTotalLinea()
        {

            int Contador;
            int Precio;
            int Cantidad;
            double TotalLinea;
            double PorcentajeImpuesto;

            // Iterate through the rows, skipping the Starting TotalLinea row.
            for (Contador = 1; Contador <= (gridVentas.Rows.Count - 1);
                Contador++)
            {
                Precio = 0;
                Cantidad = 0;


                if (gridVentas.Rows[Contador - 1].Cells["Precio"].Value != null)
                {
                    // Verify that the cell value is not an empty string.
                    if (gridVentas.Rows[Contador - 1]
                        .Cells["Precio"].Value.ToString().Length != 0)
                    {
                        Precio = int.Parse(gridVentas.Rows[Contador - 1]
                            .Cells["Precio"].Value.ToString());
                    }
                }

                if (gridVentas.Rows[Contador - 1].Cells["Cantidad"].Value != null)
                {
                    if (gridVentas.Rows[Contador - 1]
                        .Cells["Cantidad"].Value.ToString().Length != 0)
                    {
                        Cantidad = int.Parse(gridVentas.Rows[Contador - 1]
                            .Cells["Cantidad"].Value.ToString());
                    }
                }
                //gridVentas.Rows[Contador - 1].Cells["TotalLinea"].Value =
                //    (Precio * Cantidad).ToString();



                if (gridVentas.Rows[Contador - 1].Cells["Gravado"].Value != null)
                {
                    // Verify that the cell value is not an empty string.
                    if (gridVentas.Rows[Contador - 1].Cells["Gravado"].Value.ToString().Length != 0)
                    {
                        if (gridVentas.Rows[Contador - 1].Cells["Gravado"].Value.ToString().Contains("Si"))
                        {
                            gridVentas.Rows[Contador - 1].Cells["TotalLinea"].Value =
                            ((Precio * Cantidad) + double.Parse(gridVentas.Rows[Contador - 1].Cells["Impuesto"].Value.ToString())).ToString();
                        }
                    }
                }
                else

                {
                    gridVentas.Rows[Contador - 1].Cells["TotalLinea"].Value =
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
            for (Contador = 1; Contador <= (gridVentas.Rows.Count - 1);
                Contador++)
            {

                if (gridVentas.Rows[Contador - 1].Cells["Gravado"].Value != null)
                {
                    // Verify that the cell value is not an empty string.
                    if (gridVentas.Rows[Contador - 1].Cells["Gravado"].Value.ToString().Length != 0)
                    {
                        if (gridVentas.Rows[Contador - 1].Cells["Gravado"].Value.ToString().Contains("Si"))
                        {
                            TotalLinea = TotalLinea + float.Parse(gridVentas.Rows[Contador - 1]
                            .Cells["TotalLinea"].Value.ToString());

                            ClaseEntidades.clsArticulos.Articulos_ID = int.Parse(gridVentas.Rows[Contador - 1].Cells["Codigo"].Value.ToString());
                            //Obtener impuesto de articulo
                            Impuesto = double.Parse(ClaseFunciones.ClassFunciones.EjecutaQueryString("OIA")) / 100;
                            gridVentas.Rows[Contador - 1].Cells["Impuesto"].Value =
                            (int.Parse(gridVentas.Rows[Contador - 1].Cells["Cantidad"].Value.ToString()) * int.Parse(gridVentas.Rows[Contador - 1].Cells["Precio"].Value.ToString()))
                            * Impuesto;
                        }
                        else
                        {
                            gridVentas.Rows[Contador - 1].Cells["Impuesto"].Value = 0;
                        }
                    }
                }

                if (gridVentas.Rows[Contador - 1].Cells["Gravado"].Value != null)
                {
                    // Verify that the cell value is not an empty string.
                    if (gridVentas.Rows[Contador - 1].Cells["Gravado"].Value.ToString().Length != 0)
                    {
                        if (gridVentas.Rows[Contador - 1].Cells["Gravado"].Value.ToString().Contains("Si"))
                        {
                            TotalGravado = TotalGravado + double.Parse(gridVentas.Rows[Contador - 1].Cells["Impuesto"].Value.ToString());

                        }
                    }
                }


            }
            //this.txtGravado.Text = String.Format("{0:0,0.00}", TotalLinea * 0.13);
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
            for (Contador = 1; Contador <= (gridVentas.Rows.Count - 1);
                Contador++)
            {

                if (gridVentas.Rows[Contador - 1].Cells["TotalLinea"].Value != null)
                {
                    // Verify that the cell value is not an empty string.
                    if (gridVentas.Rows[Contador - 1].Cells["TotalLinea"].Value.ToString().Length != 0)
                    {

                        SubTotal = SubTotal + float.Parse(gridVentas.Rows[Contador - 1]
                        .Cells["TotalLinea"].Value.ToString());

                    }
                }


            }

            this.txtSubTotal.Text = String.Format("{0:0,0.00}", SubTotal);
            Impuesto = (float)(SubTotal * 0.13);
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

                NewDescTotal = SubTotal * (Descuento / 100);
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

            



            if (Validar() == true)
            {
                //--------------------Ingreso de Encabezado-------------------------
                FechaVen = pickerVencimiento.Value.ToString("MM/dd/yyyy");
                GlobalDocumento = int.Parse(ClaseFunciones.ClassFunciones.EjecutaQueryString("VEDM")) + 1;// Obtener el documento mayor y sumarle un uno
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

                clsVentaEncabezado.VentaEncabezado_Documento = GlobalDocumento;
                clsVentaEncabezado.VentaEncabezado_Vencimiento = FechaVen;
                clsVentaEncabezado.VentaEncabezado_IDClienteFK = int.Parse(this.txtIdCliente.Text);
                clsVentaEncabezado.VentaEncabezado_Fecha = this.txtMskFecha.Text;
                clsVentaEncabezado.VentaEncabezado_IDMonedaFK = Moneda.ToString();
                if ((string)this.cmbCondicion.SelectedItem != null)
                {
                    clsVentaEncabezado.VentaEncabezado_Condicion = (string)this.cmbCondicion.SelectedItem;
                }
                else
                {
                    MessageBox.Show("Por favor selecciones una condicion de pago");
                    return;
                }
                clsVentaEncabezado.VentaEncabezado_Gravado = double.Parse(this.txtGravado.Text);
                clsVentaEncabezado.VentaEncabezado_Descuento = double.Parse(this.txtDesc.Text);
                clsVentaEncabezado.VentaEncabezado_Impuesto = double.Parse(this.txtImpuesto.Text);
                clsVentaEncabezado.VentaEncabezado_Total = double.Parse(this.txtTotal.Text);
                //Enviar a tabla
                ClaseFunciones.ClassFunciones.EjecutaQueryInsert("VE");//Insertar Encabezado

                int CantDetalle = 0;
                CantDetalle = gridVentas.RowCount;
                string CharGravado = "";


                for (int i = 0; i < gridVentas.Rows.Count - 1; i++)
                {
                    if (gridVentas.Rows[i].Cells["Gravado"].Value.ToString() == "Si") { CharGravado = "T"; } else { CharGravado = "F"; }
                    clsVentaDetalle.VentaDetalle_IdEncabezadoFK = int.Parse(ClaseFunciones.ClassFunciones.EjecutaQueryString("VEID"));
                    clsVentaDetalle.VentaDetalle_ArticuloFK = int.Parse(gridVentas.Rows[i].Cells["Codigo"].Value.ToString());
                    clsVentaDetalle.VentaDetalle_Cant = double.Parse(gridVentas.Rows[i].Cells["Cantidad"].Value.ToString());
                    clsVentaDetalle.VentaDetalle_Precio = double.Parse(gridVentas.Rows[i].Cells["Precio"].Value.ToString());
                    clsVentaDetalle.VentaDetalle_Gravado = CharGravado;
                    clsVentaDetalle.VentaDetalle_Impuesto = double.Parse(gridVentas.Rows[i].Cells["Impuesto"].Value.ToString());
                    clsVentaDetalle.VentaDetalle_Total = double.Parse(gridVentas.Rows[i].Cells["TotalLinea"].Value.ToString());

                    //Enviar a tabla
                    ClaseFunciones.ClassFunciones.EjecutaQueryInsert("VD");//Insertar Detalle
                }
                txtNDoc.Text = GlobalDocumento.ToString();
                MessageBox.Show("Se ha ingresado correctamente la factura numero :" + GlobalDocumento.ToString());
            }
        }


        private void gridVentas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Globalcolumna = e.ColumnIndex; //La variable renglon debe estar previamente declarada y ser de tipo entero
            if (Globalcolumna == 0 && Estado != "BuscarVenta")
            {
                //MessageBox.Show("Columna " + Globalcolumna);

                FBuscar frm = new FBuscar("BA"); //Buscar todos los articulos
                DialogResult res = frm.ShowDialog();

                if (res == DialogResult.OK)
                {
                    //recuperando la variable publica del formulario 2
                    string val = frm.id;
                    gridVentas.Rows[e.RowIndex].Cells["Codigo"].Value = val; //asignamos al texbox el dato de la variable
                    ClaseEntidades.clsArticulos.Articulos_ID = int.Parse(val);
                    gridVentas.Rows[e.RowIndex].Cells["Descripcion"].Value = ClaseFunciones.ClassFunciones.EjecutaQueryString("DA");
                }

            }
        }


        private void gridCompras_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //https://webprogramacion.com/368/csharp/validar-datos-de-una-celda-en-un-datagridview.aspx
            GValidator ObjValida = new GValidator();
            string mensaje = "";

            if (!gridVentas.Rows[e.RowIndex].IsNewRow)
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

            for (int i = 0; i < gridVentas.Rows.Count - 1 && errStr == ""; i++)
            {

                if (ObjValida.ValidarCampoNumPositMensaje((gridVentas.Rows[i].Cells["Cantidad"].Value.ToString())).Contains("|")) 
                {
                    errStr = errStr+"1";
                }

                if (ObjValida.ValidarCampoNumPositMensaje((gridVentas.Rows[i].Cells["Precio"].Value.ToString())).Contains("|"))
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
            FBuscar frm = new FBuscar("BVT"); //Buscar Compras Todas 
            DialogResult res = frm.ShowDialog();

            if (res == DialogResult.OK)
            {
                //--Cambio de estado
                Estado = "BuscarVenta";
                //recuperando la variable publica del formulario 2
                txtNDoc.Text = frm.id; //asignamos al texbox el dato de la variable
                //Limpiar Grid
                gridVentas.Rows.Clear();
                gridVentas.Refresh();
                ClaseEntidades.clsVentaEncabezado.VentaEncabezado_ID = int.Parse(txtNDoc.Text);
                dt = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("OVE");//Obtener el encabezado venta

                foreach (DataRow row in dt.Rows)
                {
                    ClaseEntidades.clsVentaEncabezado.VentaEncabezado_ID = int.Parse(row[0].ToString());
                    ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Documento = int.Parse(row[1].ToString());
                    ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Vencimiento = row[2].ToString();
                    ClaseEntidades.clsVentaEncabezado.VentaEncabezado_IDClienteFK = int.Parse(row[3].ToString());
                    ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Fecha = row[4].ToString();
                    ClaseEntidades.clsVentaEncabezado.VentaEncabezado_IDMonedaFK = row[5].ToString();
                    ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Condicion = row[6].ToString();
                    ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Gravado = float.Parse(row[7].ToString());
                    ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Descuento = float.Parse(row[8].ToString());
                    ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Impuesto = float.Parse(row[9].ToString());
                    ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Total = float.Parse(row[10].ToString());
                }
                //Cargarlos a los txt
                txtIdCliente.Text = ClaseEntidades.clsVentaEncabezado.VentaEncabezado_IDClienteFK.ToString();
                DateTime VenDate = DateTime.Parse(ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Vencimiento.ToString());
                pickerVencimiento.Value = VenDate;
                txtIdCliente.Text = ClaseEntidades.clsVentaEncabezado.VentaEncabezado_IDClienteFK.ToString();
                DateTime VenDate2 = DateTime.Parse(ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Fecha.ToString());
                txtMskFecha.Text = VenDate2.ToString("MM/dd/yyyy");
                cmbMoneda.SelectedIndex = int.Parse(ClaseEntidades.clsVentaEncabezado.VentaEncabezado_IDMonedaFK.ToString()) - 1;
                cmbCondicion.Text = ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Condicion.ToString();
                txtGravado.Text = ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Gravado.ToString();
                txtDesc.Text = ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Descuento.ToString();
                txtImpuesto.Text = ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Impuesto.ToString();
                txtTotal.Text = ClaseEntidades.clsVentaEncabezado.VentaEncabezado_Total.ToString();

                dtDetalle = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("OVD");//Obtener el Detalle ventas
                int Lineas = 0;
                foreach (DataRow row in dtDetalle.Rows)
                {
                    ClaseEntidades.clsVentaDetalle.VentaDetalle_ID = int.Parse(row[0].ToString());
                    ClaseEntidades.clsVentaDetalle.VentaDetalle_IdEncabezadoFK = int.Parse(row[1].ToString());
                    ClaseEntidades.clsVentaDetalle.VentaDetalle_ArticuloFK = int.Parse(row[2].ToString());
                    ClaseEntidades.clsVentaDetalle.VentaDetalle_Cant = float.Parse(row[3].ToString());
                    ClaseEntidades.clsVentaDetalle.VentaDetalle_Precio = float.Parse(row[4].ToString());
                    ClaseEntidades.clsVentaDetalle.VentaDetalle_Gravado = row[5].ToString();
                    ClaseEntidades.clsVentaDetalle.VentaDetalle_Impuesto = float.Parse(row[6].ToString());
                    ClaseEntidades.clsVentaDetalle.VentaDetalle_Total = float.Parse(row[7].ToString());

                    //gridVentas
                    gridVentas.Rows.Add();
                    gridVentas.Rows[Lineas].Cells[0].Value = ClaseEntidades.clsVentaDetalle.VentaDetalle_ArticuloFK;
                    ClaseEntidades.clsArticulos.Articulos_ID = ClaseEntidades.clsVentaDetalle.VentaDetalle_ArticuloFK;
                    gridVentas.Rows[Lineas].Cells[1].Value = ClaseFunciones.ClassFunciones.EjecutaQueryString("DA");
                    gridVentas.Rows[Lineas].Cells[2].Value = ClaseEntidades.clsVentaDetalle.VentaDetalle_Cant;
                    gridVentas.Rows[Lineas].Cells[3].Value = ClaseEntidades.clsVentaDetalle.VentaDetalle_Precio;
                    //if (gridVentas.Rows[i].Cells["Gravado"].Value.ToString() == "Si") { CharGravado = "T"; } else { CharGravado = "F"; }
                    if (ClaseEntidades.clsVentaDetalle.VentaDetalle_Gravado == "T") { gridVentas.Rows[Lineas].Cells[4].Value = "Si"; } else { gridVentas.Rows[Lineas].Cells[4].Value = "No"; }
                    //gridVentas.Rows[Lineas].Cells[4].Value = ClaseEntidades.clsVentaDetalle.VentaDetalle_Gravado;
                    gridVentas.Rows[Lineas].Cells[5].Value = ClaseEntidades.clsVentaDetalle.VentaDetalle_Impuesto;
                    gridVentas.Rows[Lineas].Cells[6].Value = ClaseEntidades.clsVentaDetalle.VentaDetalle_Total;
                    Lineas = Lineas + 1;
                }


                Estado = "";
            }

            //if (txtNDoc.Text == "")
            //{
            //    clsVentaEncabezado.VentaEncabezado_ID = int.Parse(txtNDoc.Text);
            //    ClaseFunciones.ClassFunciones.EjecutaQueryInsert("");//Insertar Encabezado

            //}



        }

        private void btnCalTotal_Click(object sender, EventArgs e)
        {
            ActualizarTotal();
        }
    }
}
