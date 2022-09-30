
namespace UCR_Conta.Formas
{
    partial class FCompras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gridCompras = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gravado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLInea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGravado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExe = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbCondicion = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMskFecha = new System.Windows.Forms.MaskedTextBox();
            this.pickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalTotal = new System.Windows.Forms.Button();
            this.btnAddDesc = new System.Windows.Forms.Button();
            this.BtnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "N.Documento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNDoc
            // 
            this.txtNDoc.Location = new System.Drawing.Point(100, 14);
            this.txtNDoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtNDoc.Name = "txtNDoc";
            this.txtNDoc.Size = new System.Drawing.Size(128, 20);
            this.txtNDoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vencimiento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(232, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridCompras
            // 
            this.gridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Gravado,
            this.Impuesto,
            this.TotalLInea});
            this.gridCompras.Location = new System.Drawing.Point(9, 106);
            this.gridCompras.Margin = new System.Windows.Forms.Padding(2);
            this.gridCompras.Name = "gridCompras";
            this.gridCompras.RowHeadersWidth = 51;
            this.gridCompras.RowTemplate.Height = 29;
            this.gridCompras.Size = new System.Drawing.Size(753, 122);
            this.gridCompras.TabIndex = 6;
            this.gridCompras.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCompras_CellEnter);
            this.gridCompras.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridCompras_CellValidating);
            this.gridCompras.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCompras_CellValueChanged);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Gravado
            // 
            this.Gravado.DataPropertyName = "Gravado";
            this.Gravado.HeaderText = "Gravado";
            this.Gravado.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.Gravado.Name = "Gravado";
            this.Gravado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Gravado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            // 
            // TotalLInea
            // 
            this.TotalLInea.HeaderText = "TotalLinea";
            this.TotalLInea.MinimumWidth = 6;
            this.TotalLInea.Name = "TotalLInea";
            this.TotalLInea.Width = 125;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(232, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Moneda";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Items.AddRange(new object[] {
            "Colon",
            "Dolar"});
            this.cmbMoneda.Location = new System.Drawing.Point(313, 38);
            this.cmbMoneda.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(128, 21);
            this.cmbMoneda.TabIndex = 9;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(100, 65);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(128, 20);
            this.txtIdCliente.TabIndex = 11;
            this.txtIdCliente.Click += new System.EventHandler(this.txtIdCliente_Click);
            this.txtIdCliente.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 63);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID Cliente";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGravado
            // 
            this.txtGravado.Location = new System.Drawing.Point(666, 235);
            this.txtGravado.Margin = new System.Windows.Forms.Padding(2);
            this.txtGravado.Name = "txtGravado";
            this.txtGravado.Size = new System.Drawing.Size(95, 20);
            this.txtGravado.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(585, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gravado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(666, 282);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(95, 20);
            this.txtSubTotal.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(585, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Sub-Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(666, 330);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(95, 20);
            this.txtDesc.TabIndex = 17;
            this.txtDesc.Text = "0";
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(585, 332);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Descuento";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExe
            // 
            this.txtExe.Location = new System.Drawing.Point(666, 257);
            this.txtExe.Margin = new System.Windows.Forms.Padding(2);
            this.txtExe.Name = "txtExe";
            this.txtExe.Size = new System.Drawing.Size(95, 20);
            this.txtExe.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(585, 257);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Exento";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(666, 306);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(95, 20);
            this.txtImpuesto.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(585, 306);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Impuesto";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(665, 391);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(95, 20);
            this.txtTotal.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(586, 391);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Total";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCondicion
            // 
            this.cmbCondicion.FormattingEnabled = true;
            this.cmbCondicion.Items.AddRange(new object[] {
            "Contado",
            "Credito"});
            this.cmbCondicion.Location = new System.Drawing.Point(313, 63);
            this.cmbCondicion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCondicion.Name = "cmbCondicion";
            this.cmbCondicion.Size = new System.Drawing.Size(128, 21);
            this.cmbCondicion.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(232, 63);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 18);
            this.label13.TabIndex = 53;
            this.label13.Text = "Condicion";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(218, 391);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 25);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(116, 391);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 25);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(8, 391);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 25);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMskFecha
            // 
            this.txtMskFecha.Location = new System.Drawing.Point(313, 14);
            this.txtMskFecha.Mask = "00/00/0000";
            this.txtMskFecha.Name = "txtMskFecha";
            this.txtMskFecha.Size = new System.Drawing.Size(128, 20);
            this.txtMskFecha.TabIndex = 59;
            this.txtMskFecha.ValidatingType = typeof(System.DateTime);
            // 
            // pickerVencimiento
            // 
            this.pickerVencimiento.CustomFormat = "MM/dd/yyyy";
            this.pickerVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerVencimiento.Location = new System.Drawing.Point(100, 39);
            this.pickerVencimiento.Name = "pickerVencimiento";
            this.pickerVencimiento.Size = new System.Drawing.Size(128, 20);
            this.pickerVencimiento.TabIndex = 60;
            this.pickerVencimiento.Value = new System.DateTime(2021, 2, 27, 0, 0, 0, 0);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescTotal);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnCalTotal);
            this.panel1.Controls.Add(this.btnAddDesc);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.txtGravado);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSubTotal);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDesc);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtExe);
            this.panel1.Controls.Add(this.txtImpuesto);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(811, 480);
            this.panel1.TabIndex = 61;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDescTotal
            // 
            this.txtDescTotal.Location = new System.Drawing.Point(665, 361);
            this.txtDescTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescTotal.Name = "txtDescTotal";
            this.txtDescTotal.Size = new System.Drawing.Size(95, 20);
            this.txtDescTotal.TabIndex = 65;
            this.txtDescTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(547, 363);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 18);
            this.label9.TabIndex = 64;
            this.label9.Text = "Descuento Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalTotal
            // 
            this.btnCalTotal.Location = new System.Drawing.Point(423, 391);
            this.btnCalTotal.Name = "btnCalTotal";
            this.btnCalTotal.Size = new System.Drawing.Size(158, 25);
            this.btnCalTotal.TabIndex = 63;
            this.btnCalTotal.Text = "Calcular Total";
            this.btnCalTotal.UseVisualStyleBackColor = true;
            this.btnCalTotal.Click += new System.EventHandler(this.btnCalTotal_Click);
            // 
            // btnAddDesc
            // 
            this.btnAddDesc.Location = new System.Drawing.Point(423, 332);
            this.btnAddDesc.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDesc.Name = "btnAddDesc";
            this.btnAddDesc.Size = new System.Drawing.Size(158, 25);
            this.btnAddDesc.TabIndex = 62;
            this.btnAddDesc.Text = "Aplicar Descuento";
            this.btnAddDesc.UseVisualStyleBackColor = true;
            this.btnAddDesc.Click += new System.EventHandler(this.btnAddDesc_Click);
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(479, 17);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(70, 25);
            this.BtnBuscar.TabIndex = 62;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // FCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 423);
            this.Controls.Add(this.pickerVencimiento);
            this.Controls.Add(this.txtMskFecha);
            this.Controls.Add(this.cmbCondicion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridCompras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FCompras";
            this.Text = "FCompras";
            ((System.ComponentModel.ISupportInitialize)(this.gridCompras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridCompras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGravado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCondicion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox txtMskFecha;
        private System.Windows.Forms.DateTimePicker pickerVencimiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewComboBoxColumn Gravado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLInea;
        private System.Windows.Forms.Button btnAddDesc;
        private System.Windows.Forms.Button btnCalTotal;
        private System.Windows.Forms.TextBox txtDescTotal;
        private System.Windows.Forms.Label label9;
    }
}