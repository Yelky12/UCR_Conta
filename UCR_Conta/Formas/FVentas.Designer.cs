
namespace UCR_Conta.Formas
{
    partial class FVentas
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
            this.txtMskFecha = new System.Windows.Forms.MaskedTextBox();
            this.pickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbCondicion = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridVentas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gravado = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLInea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtDescTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCalTotal = new System.Windows.Forms.Button();
            this.btnAddDesc = new System.Windows.Forms.Button();
            this.txtGravado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtExe = new System.Windows.Forms.TextBox();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMskFecha
            // 
            this.txtMskFecha.Location = new System.Drawing.Point(326, 24);
            this.txtMskFecha.Mask = "00/00/0000";
            this.txtMskFecha.Name = "txtMskFecha";
            this.txtMskFecha.Size = new System.Drawing.Size(128, 20);
            this.txtMskFecha.TabIndex = 76;
            this.txtMskFecha.ValidatingType = typeof(System.DateTime);
            // 
            // pickerVencimiento
            // 
            this.pickerVencimiento.CustomFormat = "MM/dd/yyyy";
            this.pickerVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerVencimiento.Location = new System.Drawing.Point(113, 49);
            this.pickerVencimiento.Name = "pickerVencimiento";
            this.pickerVencimiento.Size = new System.Drawing.Size(128, 20);
            this.pickerVencimiento.TabIndex = 77;
            this.pickerVencimiento.Value = new System.DateTime(2021, 2, 27, 0, 0, 0, 0);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(221, 389);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 25);
            this.btnUpdate.TabIndex = 75;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(119, 389);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 25);
            this.btnDelete.TabIndex = 74;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(11, 389);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 25);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbCondicion
            // 
            this.cmbCondicion.FormattingEnabled = true;
            this.cmbCondicion.Items.AddRange(new object[] {
            "Contado",
            "Credito"});
            this.cmbCondicion.Location = new System.Drawing.Point(326, 73);
            this.cmbCondicion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCondicion.Name = "cmbCondicion";
            this.cmbCondicion.Size = new System.Drawing.Size(128, 21);
            this.cmbCondicion.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(245, 73);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 18);
            this.label13.TabIndex = 71;
            this.label13.Text = "Condicion";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(113, 75);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(128, 20);
            this.txtIdCliente.TabIndex = 70;
            this.txtIdCliente.Click += new System.EventHandler(this.txtIdCliente_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(33, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 69;
            this.label4.Text = "ID Cliente";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Items.AddRange(new object[] {
            "Colon",
            "Dolar"});
            this.cmbMoneda.Location = new System.Drawing.Point(326, 48);
            this.cmbMoneda.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(128, 21);
            this.cmbMoneda.TabIndex = 68;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(245, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 67;
            this.label5.Text = "Moneda";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridVentas
            // 
            this.gridVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.Precio,
            this.Gravado,
            this.Impuesto,
            this.TotalLInea});
            this.gridVentas.Location = new System.Drawing.Point(22, 116);
            this.gridVentas.Margin = new System.Windows.Forms.Padding(2);
            this.gridVentas.Name = "gridVentas";
            this.gridVentas.RowHeadersWidth = 51;
            this.gridVentas.RowTemplate.Height = 29;
            this.gridVentas.Size = new System.Drawing.Size(753, 122);
            this.gridVentas.TabIndex = 66;
            this.gridVentas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVentas_CellEnter);
            this.gridVentas.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.gridCompras_CellValidating);
            this.gridVentas.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridVentas_CellValueChanged);
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
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(245, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 65;
            this.label3.Text = "Fecha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 64;
            this.label2.Text = "Vencimiento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNDoc
            // 
            this.txtNDoc.Location = new System.Drawing.Point(113, 24);
            this.txtNDoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtNDoc.Name = "txtNDoc";
            this.txtNDoc.Size = new System.Drawing.Size(128, 20);
            this.txtNDoc.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 62;
            this.label1.Text = "N.Documento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescTotal);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnCalTotal);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAddDesc);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtGravado);
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
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 480);
            this.panel1.TabIndex = 78;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(483, 22);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(70, 25);
            this.BtnBuscar.TabIndex = 63;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtDescTotal
            // 
            this.txtDescTotal.Location = new System.Drawing.Point(677, 364);
            this.txtDescTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescTotal.Name = "txtDescTotal";
            this.txtDescTotal.Size = new System.Drawing.Size(95, 20);
            this.txtDescTotal.TabIndex = 81;
            this.txtDescTotal.Text = "0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(559, 366);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 18);
            this.label9.TabIndex = 80;
            this.label9.Text = "Descuento Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalTotal
            // 
            this.btnCalTotal.Location = new System.Drawing.Point(435, 394);
            this.btnCalTotal.Name = "btnCalTotal";
            this.btnCalTotal.Size = new System.Drawing.Size(158, 25);
            this.btnCalTotal.TabIndex = 79;
            this.btnCalTotal.Text = "Calcular Total";
            this.btnCalTotal.UseVisualStyleBackColor = true;
            this.btnCalTotal.Click += new System.EventHandler(this.btnCalTotal_Click);
            // 
            // btnAddDesc
            // 
            this.btnAddDesc.Location = new System.Drawing.Point(435, 335);
            this.btnAddDesc.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddDesc.Name = "btnAddDesc";
            this.btnAddDesc.Size = new System.Drawing.Size(158, 25);
            this.btnAddDesc.TabIndex = 78;
            this.btnAddDesc.Text = "Aplicar Descuento";
            this.btnAddDesc.UseVisualStyleBackColor = true;
            this.btnAddDesc.Click += new System.EventHandler(this.btnAddDesc_Click);
            // 
            // txtGravado
            // 
            this.txtGravado.Location = new System.Drawing.Point(678, 238);
            this.txtGravado.Margin = new System.Windows.Forms.Padding(2);
            this.txtGravado.Name = "txtGravado";
            this.txtGravado.Size = new System.Drawing.Size(95, 20);
            this.txtGravado.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(597, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 66;
            this.label6.Text = "Gravado";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(597, 286);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 18);
            this.label7.TabIndex = 68;
            this.label7.Text = "Sub-Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(678, 285);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(95, 20);
            this.txtSubTotal.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(597, 335);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 18);
            this.label8.TabIndex = 70;
            this.label8.Text = "Descuento";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(678, 333);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(95, 20);
            this.txtDesc.TabIndex = 71;
            this.txtDesc.Text = "0";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(677, 394);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(95, 20);
            this.txtTotal.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(597, 260);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 18);
            this.label10.TabIndex = 72;
            this.label10.Text = "Exento";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(598, 394);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 18);
            this.label12.TabIndex = 76;
            this.label12.Text = "Total";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtExe
            // 
            this.txtExe.Location = new System.Drawing.Point(678, 260);
            this.txtExe.Margin = new System.Windows.Forms.Padding(2);
            this.txtExe.Name = "txtExe";
            this.txtExe.Size = new System.Drawing.Size(95, 20);
            this.txtExe.TabIndex = 73;
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Location = new System.Drawing.Point(678, 309);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(2);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.Size = new System.Drawing.Size(95, 20);
            this.txtImpuesto.TabIndex = 75;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(597, 309);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 18);
            this.label11.TabIndex = 74;
            this.label11.Text = "Impuesto";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 435);
            this.Controls.Add(this.txtMskFecha);
            this.Controls.Add(this.pickerVencimiento);
            this.Controls.Add(this.cmbCondicion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMoneda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gridVentas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FVentas";
            this.Text = "FVentas";
            ((System.ComponentModel.ISupportInitialize)(this.gridVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txtMskFecha;
        private System.Windows.Forms.DateTimePicker pickerVencimiento;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbCondicion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gridVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewComboBoxColumn Gravado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLInea;
        private System.Windows.Forms.TextBox txtDescTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCalTotal;
        private System.Windows.Forms.Button btnAddDesc;
        private System.Windows.Forms.TextBox txtGravado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtExe;
        private System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label label11;
    }
}