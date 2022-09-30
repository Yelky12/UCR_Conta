using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseEntidades;

namespace UCR_Conta.Formas
{
    public partial class FAsientoDiario : Form
    {

        DataTable dtEncabezado = new DataTable();
        DataTable dtDetalle = new DataTable();

        public FAsientoDiario()
        {
            InitializeComponent();
            txtNumAsiento.Enabled = false;
            gridAsiento.Columns[0].ReadOnly = true;
            gridAsiento.Columns[1].ReadOnly = true;
            gridAsiento.Columns[2].ReadOnly = true;
            gridAsiento.Columns[3].ReadOnly = true;
            pickerAsientoDiario.Value = DateTime.Now;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtIdCliente_Click(object sender, EventArgs e)
        {
            //FBuscar frm = new FBuscar("TT"); //Todos los terceros
            //DialogResult res = frm.ShowDialog();

            //if (res == DialogResult.OK)
            //{
            //    //recuperando la variable publica del formulario 2
            //    txtIdCliente.Text = frm.id; //asignamos al texbox el dato de la variable
            //    ClaseEntidades.clsTercero.Tercero_ID = int.Parse( txtIdCliente.Text);

            //    lblTercero.Text = ClaseFunciones.ClassFunciones.EjecutaQueryString("ONT");
            //}
        }


       





        private void txtId_Click(object sender, EventArgs e)
        {
            FBuscar frm = new FBuscar("AC"); //Todas las cuentas asociadas
            DialogResult res = frm.ShowDialog();

            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario 2
                txtId.Text = frm.id; //asignamos al texbox el dato de la variable

                if (txtId.Text != "")
                {
                    clsCuenta.Cuenta_ID = int.Parse(txtId.Text);
                    txtCodigoCuenta.Text = ClaseFunciones.ClassFunciones.EjecutaQueryString("CC"); //Codigo de la cuenta
                    txtDescrip.Text = ClaseFunciones.ClassFunciones.EjecutaQueryString("NC"); //Nombre de la cuenta

                }
                

            }

            

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string Codigo; //Primera Columns
            string Cuenta; // Segunda Columns
            string Debito="0"; //Trcera column
            string Credito="0"; // Cuarta columns

            int n = gridAsiento.Rows.Add();
           
            //Codigo = txtId.Text;
            Codigo = txtCodigoCuenta.Text;
            Cuenta = txtDescrip.Text;
            if (rbtnDebito.Checked == true) { Debito =  txtValor.Text; Credito = "0"; }
            if (rbtnCredito.Checked == true) { Credito = txtValor.Text; Debito = "0"; }

            gridAsiento.Rows[n].Cells[0].Value = Codigo;
            gridAsiento.Rows[n].Cells[1].Value = Cuenta;
            gridAsiento.Rows[n].Cells[2].Value = Debito;
            gridAsiento.Rows[n].Cells[3].Value = Credito;

            //string[] row = { Codigo, Cuenta,  Debito, Credito };
            ////----
            //DataTable dt2 = new DataTable();
            //dt2 = gridAsiento.DataSource as DataTable;

            //DataRow datarow;
            //datarow = dt2.NewRow(); //Con esto le indica que es una nueva fila.
            //datarow["Codigo"] = Codigo;
            //datarow["Cuenta"] = Cuenta;
            //datarow["Debito"] = Debito;
            //datarow["Credito"] = Credito;


            //gridAsiento.Rows.Add(row);
            ActualizarSumas();
        }


        public void ActualizarSumas()
        {
            int lineas = 0;
            float sumdeb = 0;
            float sumcre = 0;
            lineas = gridAsiento.RowCount;

            for (int i = 0; i < lineas-1; i++)
            {
                
                sumdeb = sumdeb + float.Parse((string)gridAsiento.Rows[i].Cells[2].Value);
                sumcre = sumcre + float.Parse((string)gridAsiento.Rows[i].Cells[3].Value);
            }

            lblSumDeb.Text = sumdeb.ToString();
            lblSumCre.Text = sumcre.ToString();
            lblDiff.Text = (sumcre - sumdeb).ToString();

        }


        public void EliminaLinea() 
        {

            if (gridAsiento.CurrentRow.Index != -1)
            {
                gridAsiento.Rows.RemoveAt(gridAsiento.CurrentRow.Index);
            }
            ActualizarSumas();

        }

        private void btnBorrarLinea_Click(object sender, EventArgs e)
        {
            EliminaLinea();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNumAsiento.Text != "")
            {
                MessageBox.Show("No se puede agregar un registro sin antes limpiar el formulario");
                return;
            }

            int NumeroAsiento = 0;
            int CodigoCuenta = 0;

            ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_Fecha = this.pickerAsientoDiario.Text;
            ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_IdTerceroFK = int.Parse(this.txtIdCliente.Text);
            ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_Detalle = txtDetalle.Text;
            NumeroAsiento = int.Parse(ClaseFunciones.ClassFunciones.EjecutaQueryString("CAM"));
            if (NumeroAsiento == 0)
            { NumeroAsiento = 1; }
            else 
            { NumeroAsiento = NumeroAsiento + 1; }
            ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_Documento = NumeroAsiento;
            //Enviar a tabla encabezado
            ClaseFunciones.ClassFunciones.EjecutaQueryInsert("AE");//Insertar Encabezado
            txtNumAsiento.Text = NumeroAsiento.ToString();


            for (int i = 0; i < gridAsiento.Rows.Count - 1; i++)
            {
                //Buscar IdCuenta
                ClaseEntidades.clsCuenta.Cuenta_Codigo = gridAsiento.Rows[i].Cells["Codigo"].Value.ToString().Replace("\r", "").Replace(" ","");
                CodigoCuenta = int.Parse(ClaseFunciones.ClassFunciones.EjecutaQueryString("IDC"));
                //CodigoCuenta = ClaseFunciones.ClassFunciones.EjecutaQueryString("IDC");

                clsAsientoDetalle.AsientoDetalle_NumeroAsientoFK = NumeroAsiento;
                clsAsientoDetalle.AsientoDetalle_Linea = i;
                //clsAsientoDetalle.AsientoDetalle_CodigoCuentaFK = int.Parse( gridAsiento.Rows[i].Cells["Codigo"].Value.ToString() );
                clsAsientoDetalle.AsientoDetalle_CodigoCuentaFK = CodigoCuenta;
                if (gridAsiento.Rows[i].Cells["Debito"].Value.ToString() != "0")
                { 
                    clsAsientoDetalle.AsientoDetalle_Tipo = "Debito";
                    clsAsientoDetalle.AsientoDetalle_Valor = double.Parse(gridAsiento.Rows[i].Cells["Debito"].Value.ToString());
                }
                if (gridAsiento.Rows[i].Cells["Credito"].Value.ToString() != "0")
                { 
                    clsAsientoDetalle.AsientoDetalle_Tipo = "Credito";
                    clsAsientoDetalle.AsientoDetalle_Valor = double.Parse(gridAsiento.Rows[i].Cells["Credito"].Value.ToString());
                }

                //Enviar a tabla detalle
                ClaseFunciones.ClassFunciones.EjecutaQueryInsert("AD");//Insertar Detalle
            }


            MessageBox.Show("Se ha agregado satisfactoriamente la informacion");
            //LimpiarForm();

        }

        


        public void BuscarAsiento()
        {
            FBuscar frm = new FBuscar("BAD"); //Buscar Asiento Diario
            DialogResult res = frm.ShowDialog();

            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario 2
                txtNumAsiento.Text = frm.id; //asignamos al texbox el dato de la variable
                if (txtNumAsiento.Text != "")
                {
                    CargarEncabezadoYDetalle();
                }
                else
                {
                    MessageBox.Show("No hay Asientos en la base de datos");
                }
            }



        }

        public void CargarEncabezadoYDetalle()
        {

            //---------------Encabezado-----------
            ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_Documento = int.Parse(this.txtNumAsiento.Text);
            dtEncabezado = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("OEA");

            #region Comentario
            //pickerAsientoDiario.Value = string.Format("{0:MM/dd/yyyy}", DateTime.Now);
            //string Campo1 = dtEncabezado.Rows[0]["AsientoEncabezado_Fecha"].ToString();
            //string Campo2 = dtEncabezado.Rows[0]["Tercero_Identificador"].ToString();
            //string Campo3 = dtEncabezado.Rows[0]["Tercero_Nombre"].ToString();
            //string Campo4 = dtEncabezado.Rows[0]["AsientoEncabezado_Detalle"].ToString();
            #endregion

            //15/02/2022 12:00:00 a. m.
            //string fecha = "15/02/2022 12:00:00 a. m.";
            //string fecha = "15/02/2022 12:00:00 a. m.".Replace(" 12:00:00 a. m.", "");
            //fecha = fecha.Replace("/", "-");
            //DateTime dt = new DateTime(fecha);
            //Convert.ToDateTime(fecha, CultureInfo.InvariantCulture);
            //DateTime outputDateTimeValue;
            //DateTime.TryParseExact("15/02/2022 12:00:00", "dd-MM-yyyy", 
            //System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out outputDateTimeValue);
            //DateTime fecha2 = Convert.ToDateTime(fecha, CultureInfo.InvariantCulture);

            string fecha = dtEncabezado.Rows[0]["AsientoEncabezado_Fecha"].ToString().Replace(" 12:00:00 a. m.", "");

            var dateTest = DateTime.Parse(fecha.ToString(), new CultureInfo("es-ES", true));
            CultureInfo provider = new CultureInfo("es-ES");
            DateTime FechaEncabezado = DateTime.Parse(fecha.ToString(), provider);


            //Formato Fecha
            //var date = DateTime.Parse(dtEncabezado.Rows[0]["AsientoEncabezado_Fecha"].ToString(), new CultureInfo("en-US", true));
            //CultureInfo provider = new CultureInfo("es-ES");
            //DateTime FechaEncabezado = DateTime.Parse(dtEncabezado.Rows[0]["AsientoEncabezado_Fecha"].ToString(), provider, DateTimeStyles.NoCurrentDateDefault);
            pickerAsientoDiario.Value = FechaEncabezado;
            txtIdCliente.Text = dtEncabezado.Rows[0]["Tercero_Identificador"].ToString();
            lblTercero.Text = dtEncabezado.Rows[0]["Tercero_Nombre"].ToString();
            txtDetalle.Text = dtEncabezado.Rows[0]["AsientoEncabezado_Detalle"].ToString();

            try
            {
            //--------------Detalle----------------
            gridAsiento.Columns.Remove("Codigo");
            gridAsiento.Columns.Remove("Cuenta");
            gridAsiento.Columns.Remove("Debito");
            gridAsiento.Columns.Remove("Credito");
            ClaseEntidades.clsAsientoDetalle.AsientoDetalle_NumeroAsientoFK = int.Parse(this.txtNumAsiento.Text);
            
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message.ToString()); 
            }
            dtDetalle.Clear();
            dtDetalle = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("ODA");
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Cuenta");
            dt.Columns.Add("Debito");
            dt.Columns.Add("Credito");

            for (int i = 0; i < dtDetalle.Rows.Count ; i++)
            {
                DataRow row = dt.NewRow();

                row["Codigo"] = dtDetalle.Rows[i]["Cuenta_Codigo"].ToString();
                row["Cuenta"] = dtDetalle.Rows[i]["Cuenta_Descripcion"].ToString();
                row["Debito"] = dtDetalle.Rows[i]["Debito"].ToString();
                row["Credito"] = dtDetalle.Rows[i]["Credito"].ToString();

                dt.Rows.Add(row);

                //dt.Rows.Add(
                //    dtDetalle.Rows[i]["Cuenta.Cuenta_Codigo"].ToString(),
                //    dtDetalle.Rows[i]["Cuenta.Cuenta_Descripcion"].ToString(),
                //    dtDetalle.Rows[i]["Debito"].ToString(),
                //    dtDetalle.Rows[i]["Credito"].ToString()
                //);
            }


            gridAsiento.DataSource = dt;
            AnchoColumnas();
            ActualizarSumas();
        }


        public void AnchoColumnas() 
        {
            gridAsiento.Columns[0].Width = 100;
            gridAsiento.Columns[0].Name = "Codigo";
            gridAsiento.Columns[1].Width = 380;
            gridAsiento.Columns[0].Name = "Cuenta";
            gridAsiento.Columns[2].Width = 100;
            gridAsiento.Columns[0].Name = "Debito";
            gridAsiento.Columns[3].Width = 100;
            gridAsiento.Columns[0].Name = "Credito";



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtNumAsiento.Text != "")
            {
                //--Eliminar Detalle
                ClaseEntidades.clsAsientoDetalle.AsientoDetalle_NumeroAsientoFK = int.Parse(txtNumAsiento.Text);
                ClaseFunciones.ClassFunciones.EjecutaQueryDelete("RAD");

                //--Eliminar encabezado
                ClaseEntidades.clsAsientoEncabezado.AsientoEncabezado_Documento = int.Parse(txtNumAsiento.Text);
                ClaseFunciones.ClassFunciones.EjecutaQueryDelete("RAE");
                MessageBox.Show("Se ha eliminado el Asiento: " + txtNumAsiento.Text );

                LimpiarForm();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un asiento");
            
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarAsiento();
            gridAsiento.Columns[0].ReadOnly = true;
            gridAsiento.Columns[1].ReadOnly = true;
            gridAsiento.Columns[2].ReadOnly = true;
            gridAsiento.Columns[3].ReadOnly = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            LimpiarForm();
            //gridAsiento.Columns[0].ReadOnly = false;
            //gridAsiento.Columns[1].ReadOnly = false;
            //gridAsiento.Columns[2].ReadOnly = false;
            //gridAsiento.Columns[3].ReadOnly = false;


        }

        public void LimpiarForm()
        {

            txtNumAsiento.Text = "";
            txtIdCliente.Text = "";
            txtIndentiClie.Text = "";
            lblTercero.Text = "";
            txtDetalle.Text = "";
            txtId.Text = "";
            txtCodigoCuenta.Text = "";
            txtDescrip.Text = "";
            txtValor.Text = "";
            rbtnCredito.Checked = false;
            rbtnDebito.Checked = false;

            //Limpiar Grid
            //DataTable dtDetalle = new DataTable();
            //gridAsiento.Columns.Clear();
            //dtDetalle.Columns.Add("Codigo");
            //dtDetalle.Columns.Add("Cuenta");
            //dtDetalle.Columns.Add("Debito");
            //dtDetalle.Columns.Add("Credito");
            //gridAsiento.DataSource = dtDetalle;

            //gridAsiento.Rows.Clear();
            //gridAsiento.Refresh();

            dtDetalle.Clear();
            //dtDetalle = ClaseFunciones.ClassFunciones.EjecutaQueryDataTable("ODA");
            DataTable dt = new DataTable();
            dt.Columns.Add("Codigo");
            dt.Columns.Add("Cuenta");
            dt.Columns.Add("Debito");
            dt.Columns.Add("Credito");

            gridAsiento.DataSource = dt;

        }

        private void txtIndentiClie_Click(object sender, EventArgs e)
        {
            BuscarTercero();
        }


        private void BuscarTercero()
        {

            FBuscar frm = new FBuscar("TT"); //Todos los terceros
            DialogResult res = frm.ShowDialog();

            if (res == DialogResult.OK)
            {
                //recuperando la variable publica del formulario 2
                txtIdCliente.Text = frm.id; //asignamos al texbox el dato de la variable
                ClaseEntidades.clsTercero.Tercero_ID = int.Parse(txtIdCliente.Text);
                lblTercero.Text = ClaseFunciones.ClassFunciones.EjecutaQueryString("ONT");
                txtIndentiClie.Text = ClaseFunciones.ClassFunciones.EjecutaQueryString("OIT");
            }

        }

        
    }
}
