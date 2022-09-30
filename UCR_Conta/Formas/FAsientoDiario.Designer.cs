
namespace UCR_Conta.Formas
{
    partial class FAsientoDiario
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
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigoCuenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTercero = new System.Windows.Forms.Label();
            this.lblDiff = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblSumCre = new System.Windows.Forms.Label();
            this.lblSumDeb = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridAsiento = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBorrarLinea = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.rbtnCredito = new System.Windows.Forms.RadioButton();
            this.rbtnDebito = new System.Windows.Forms.RadioButton();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pickerAsientoDiario = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumAsiento = new System.Windows.Forms.TextBox();
            this.txtIndentiClie = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsiento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(541, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asiento Diario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(114, 128);
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(630, 34);
            this.txtDetalle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(563, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIndentiClie);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtCodigoCuenta);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblTercero);
            this.panel1.Controls.Add(this.lblDiff);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblSumCre);
            this.panel1.Controls.Add(this.lblSumDeb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.gridAsiento);
            this.panel1.Controls.Add(this.btnBorrarLinea);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.rbtnCredito);
            this.panel1.Controls.Add(this.rbtnDebito);
            this.panel1.Controls.Add(this.txtValor);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDescrip);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtIdCliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pickerAsientoDiario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNumAsiento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDetalle);
            this.panel1.Location = new System.Drawing.Point(-2, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 550);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(264, 468);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(97, 25);
            this.btnLimpiar.TabIndex = 106;
            this.btnLimpiar.Text = "Limpiar Form";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(617, 49);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 26);
            this.btnBuscar.TabIndex = 105;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigoCuenta
            // 
            this.txtCodigoCuenta.Location = new System.Drawing.Point(311, 176);
            this.txtCodigoCuenta.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoCuenta.Name = "txtCodigoCuenta";
            this.txtCodigoCuenta.Size = new System.Drawing.Size(90, 20);
            this.txtCodigoCuenta.TabIndex = 104;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(214, 176);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 103;
            this.label10.Text = "Codigo Cuenta";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTercero
            // 
            this.lblTercero.Location = new System.Drawing.Point(249, 103);
            this.lblTercero.Name = "lblTercero";
            this.lblTercero.Size = new System.Drawing.Size(397, 18);
            this.lblTercero.TabIndex = 102;
            this.lblTercero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiff
            // 
            this.lblDiff.Location = new System.Drawing.Point(563, 457);
            this.lblDiff.Name = "lblDiff";
            this.lblDiff.Size = new System.Drawing.Size(101, 20);
            this.lblDiff.TabIndex = 101;
            this.lblDiff.Text = "0";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(434, 457);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 20);
            this.label12.TabIndex = 100;
            this.label12.Text = "Diferencia";
            // 
            // lblSumCre
            // 
            this.lblSumCre.Location = new System.Drawing.Point(641, 426);
            this.lblSumCre.Name = "lblSumCre";
            this.lblSumCre.Size = new System.Drawing.Size(101, 20);
            this.lblSumCre.TabIndex = 99;
            this.lblSumCre.Text = "0";
            // 
            // lblSumDeb
            // 
            this.lblSumDeb.Location = new System.Drawing.Point(526, 426);
            this.lblSumDeb.Name = "lblSumDeb";
            this.lblSumDeb.Size = new System.Drawing.Size(101, 20);
            this.lblSumDeb.TabIndex = 98;
            this.lblSumDeb.Text = "0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(376, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 97;
            this.label9.Text = "Sumas Iguales";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(145, 468);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 25);
            this.btnDelete.TabIndex = 96;
            this.btnDelete.Text = "Eliminar Registro";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 468);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 25);
            this.btnAdd.TabIndex = 95;
            this.btnAdd.Text = "Agregar Registro";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gridAsiento
            // 
            this.gridAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAsiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Cuenta,
            this.Debito,
            this.Credito});
            this.gridAsiento.Location = new System.Drawing.Point(20, 285);
            this.gridAsiento.Name = "gridAsiento";
            this.gridAsiento.Size = new System.Drawing.Size(724, 129);
            this.gridAsiento.TabIndex = 94;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Cuenta
            // 
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Width = 380;
            // 
            // Debito
            // 
            this.Debito.HeaderText = "Debito";
            this.Debito.Name = "Debito";
            // 
            // Credito
            // 
            this.Credito.HeaderText = "Credito";
            this.Credito.Name = "Credito";
            // 
            // btnBorrarLinea
            // 
            this.btnBorrarLinea.Location = new System.Drawing.Point(311, 237);
            this.btnBorrarLinea.Name = "btnBorrarLinea";
            this.btnBorrarLinea.Size = new System.Drawing.Size(96, 26);
            this.btnBorrarLinea.TabIndex = 93;
            this.btnBorrarLinea.Text = "Borrar Linea";
            this.btnBorrarLinea.UseVisualStyleBackColor = true;
            this.btnBorrarLinea.Click += new System.EventHandler(this.btnBorrarLinea_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(194, 237);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(96, 26);
            this.btnRegistrar.TabIndex = 92;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // rbtnCredito
            // 
            this.rbtnCredito.AutoSize = true;
            this.rbtnCredito.Location = new System.Drawing.Point(111, 237);
            this.rbtnCredito.Name = "rbtnCredito";
            this.rbtnCredito.Size = new System.Drawing.Size(58, 17);
            this.rbtnCredito.TabIndex = 91;
            this.rbtnCredito.TabStop = true;
            this.rbtnCredito.Text = "Credito";
            this.rbtnCredito.UseVisualStyleBackColor = true;
            // 
            // rbtnDebito
            // 
            this.rbtnDebito.AutoSize = true;
            this.rbtnDebito.Location = new System.Drawing.Point(20, 237);
            this.rbtnDebito.Name = "rbtnDebito";
            this.rbtnDebito.Size = new System.Drawing.Size(56, 17);
            this.rbtnDebito.TabIndex = 90;
            this.rbtnDebito.TabStop = true;
            this.rbtnDebito.Text = "Debito";
            this.rbtnDebito.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(617, 197);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(127, 20);
            this.txtValor.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(563, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 88;
            this.label8.Text = "Valor";
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(114, 197);
            this.txtDescrip.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(447, 20);
            this.txtDescrip.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 18);
            this.label6.TabIndex = 86;
            this.label6.Text = "Descripción Cuenta";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(114, 176);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(90, 20);
            this.txtId.TabIndex = 85;
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(17, 176);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 84;
            this.label7.Text = "Id Cuenta";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 83;
            this.label4.Text = "Detalle";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(264, 67);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(128, 20);
            this.txtIdCliente.TabIndex = 82;
            this.txtIdCliente.Visible = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(2, 103);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 81;
            this.label5.Text = "ID Tercero";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pickerAsientoDiario
            // 
            this.pickerAsientoDiario.CustomFormat = "MM/dd/yyyy";
            this.pickerAsientoDiario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerAsientoDiario.Location = new System.Drawing.Point(114, 67);
            this.pickerAsientoDiario.Name = "pickerAsientoDiario";
            this.pickerAsientoDiario.Size = new System.Drawing.Size(128, 20);
            this.pickerAsientoDiario.TabIndex = 78;
            this.pickerAsientoDiario.Value = new System.DateTime(2021, 2, 27, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha";
            // 
            // txtNumAsiento
            // 
            this.txtNumAsiento.Location = new System.Drawing.Point(617, 23);
            this.txtNumAsiento.Name = "txtNumAsiento";
            this.txtNumAsiento.Size = new System.Drawing.Size(127, 20);
            this.txtNumAsiento.TabIndex = 3;
            // 
            // txtIndentiClie
            // 
            this.txtIndentiClie.Location = new System.Drawing.Point(116, 101);
            this.txtIndentiClie.Margin = new System.Windows.Forms.Padding(2);
            this.txtIndentiClie.Name = "txtIndentiClie";
            this.txtIndentiClie.Size = new System.Drawing.Size(128, 20);
            this.txtIndentiClie.TabIndex = 107;
            this.txtIndentiClie.Click += new System.EventHandler(this.txtIndentiClie_Click);

            // 
            // FAsientoDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 545);
            this.Controls.Add(this.panel1);
            this.Name = "FAsientoDiario";
            this.Text = "FAsientoDiario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAsiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumAsiento;
        private System.Windows.Forms.DateTimePicker pickerAsientoDiario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.RadioButton rbtnCredito;
        private System.Windows.Forms.RadioButton rbtnDebito;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBorrarLinea;
        private System.Windows.Forms.DataGridView gridAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.Label lblSumDeb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblDiff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblSumCre;
        private System.Windows.Forms.Label lblTercero;
        private System.Windows.Forms.TextBox txtCodigoCuenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtIndentiClie;
    }
}