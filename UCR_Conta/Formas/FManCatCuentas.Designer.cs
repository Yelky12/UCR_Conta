
namespace UCR_Conta.Formas
{
    partial class FManCatCuentas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCentroCosto = new System.Windows.Forms.ComboBox();
            this.gridCuentas = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.rbtnIntermedia = new System.Windows.Forms.RadioButton();
            this.rbtnMadre = new System.Windows.Forms.RadioButton();
            this.rbtnUltimo = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCuentaMadre = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescrip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbCentroCosto);
            this.panel1.Controls.Add(this.gridCuentas);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.rbtnIntermedia);
            this.panel1.Controls.Add(this.rbtnMadre);
            this.panel1.Controls.Add(this.rbtnUltimo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cbCuentaMadre);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDescrip);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(609, 460);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(2, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Centro de Costo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCentroCosto
            // 
            this.cbCentroCosto.FormattingEnabled = true;
            this.cbCentroCosto.Location = new System.Drawing.Point(98, 108);
            this.cbCentroCosto.Margin = new System.Windows.Forms.Padding(2);
            this.cbCentroCosto.Name = "cbCentroCosto";
            this.cbCentroCosto.Size = new System.Drawing.Size(447, 21);
            this.cbCentroCosto.TabIndex = 15;
            this.cbCentroCosto.Text = "0";
            // 
            // gridCuentas
            // 
            this.gridCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCuentas.Location = new System.Drawing.Point(3, 269);
            this.gridCuentas.Name = "gridCuentas";
            this.gridCuentas.Size = new System.Drawing.Size(598, 173);
            this.gridCuentas.TabIndex = 14;
            this.gridCuentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCuentas_CellClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(411, 222);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(70, 28);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 222);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(70, 28);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 222);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 28);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rbtnIntermedia
            // 
            this.rbtnIntermedia.AutoSize = true;
            this.rbtnIntermedia.Location = new System.Drawing.Point(43, 174);
            this.rbtnIntermedia.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnIntermedia.Name = "rbtnIntermedia";
            this.rbtnIntermedia.Size = new System.Drawing.Size(110, 17);
            this.rbtnIntermedia.TabIndex = 10;
            this.rbtnIntermedia.TabStop = true;
            this.rbtnIntermedia.Text = "Cuenta intermedia";
            this.rbtnIntermedia.UseVisualStyleBackColor = true;
            // 
            // rbtnMadre
            // 
            this.rbtnMadre.AutoSize = true;
            this.rbtnMadre.Location = new System.Drawing.Point(43, 155);
            this.rbtnMadre.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnMadre.Name = "rbtnMadre";
            this.rbtnMadre.Size = new System.Drawing.Size(91, 17);
            this.rbtnMadre.TabIndex = 9;
            this.rbtnMadre.TabStop = true;
            this.rbtnMadre.Text = "Cuenta madre";
            this.rbtnMadre.UseVisualStyleBackColor = true;
            // 
            // rbtnUltimo
            // 
            this.rbtnUltimo.AutoSize = true;
            this.rbtnUltimo.Location = new System.Drawing.Point(43, 194);
            this.rbtnUltimo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnUltimo.Name = "rbtnUltimo";
            this.rbtnUltimo.Size = new System.Drawing.Size(129, 17);
            this.rbtnUltimo.TabIndex = 8;
            this.rbtnUltimo.TabStop = true;
            this.rbtnUltimo.Text = "Cuenta de ultimo nivel";
            this.rbtnUltimo.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tipo de cuenta:";
            // 
            // cbCuentaMadre
            // 
            this.cbCuentaMadre.FormattingEnabled = true;
            this.cbCuentaMadre.Location = new System.Drawing.Point(98, 83);
            this.cbCuentaMadre.Margin = new System.Windows.Forms.Padding(2);
            this.cbCuentaMadre.Name = "cbCuentaMadre";
            this.cbCuentaMadre.Size = new System.Drawing.Size(447, 21);
            this.cbCuentaMadre.TabIndex = 6;
            this.cbCuentaMadre.Text = "0";
            this.cbCuentaMadre.SelectedIndexChanged += new System.EventHandler(this.cargarCuenta_Codigo);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(14, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cuenta madre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescrip
            // 
            this.txtDescrip.Location = new System.Drawing.Point(98, 62);
            this.txtDescrip.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(447, 20);
            this.txtDescrip.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripción";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(98, 41);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(90, 20);
            this.txtId.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mantenimiento Catalogo Cuentas";
            // 
            // FManCatCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 457);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FManCatCuentas";
            this.Text = "FManCatCuentas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.RadioButton rbtnIntermedia;
        private System.Windows.Forms.RadioButton rbtnMadre;
        private System.Windows.Forms.RadioButton rbtnUltimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCuentaMadre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescrip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridCuentas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCentroCosto;
    }
}