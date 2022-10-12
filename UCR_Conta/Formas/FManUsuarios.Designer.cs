
namespace UCR_Conta.Formas
{
    partial class FManUsuarios
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnInactivo = new System.Windows.Forms.RadioButton();
            this.rBtnActivo = new System.Windows.Forms.RadioButton();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtClave);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 453);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(194, 266);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 35);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Actualizar Usuario";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(53, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 35);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Agregar Usuario";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnInactivo);
            this.groupBox1.Controls.Add(this.rBtnActivo);
            this.groupBox1.Location = new System.Drawing.Point(53, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 52);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado de usuario";
            // 
            // rBtnInactivo
            // 
            this.rBtnInactivo.AutoSize = true;
            this.rBtnInactivo.Location = new System.Drawing.Point(115, 20);
            this.rBtnInactivo.Name = "rBtnInactivo";
            this.rBtnInactivo.Size = new System.Drawing.Size(63, 17);
            this.rBtnInactivo.TabIndex = 7;
            this.rBtnInactivo.TabStop = true;
            this.rBtnInactivo.Text = "Inactivo";
            this.rBtnInactivo.UseVisualStyleBackColor = true;
            // 
            // rBtnActivo
            // 
            this.rBtnActivo.AutoSize = true;
            this.rBtnActivo.Location = new System.Drawing.Point(44, 20);
            this.rBtnActivo.Name = "rBtnActivo";
            this.rBtnActivo.Size = new System.Drawing.Size(55, 17);
            this.rBtnActivo.TabIndex = 6;
            this.rBtnActivo.TabStop = true;
            this.rBtnActivo.Text = "Activo";
            this.rBtnActivo.UseVisualStyleBackColor = true;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(183, 112);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(234, 20);
            this.txtClave.TabIndex = 5;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(183, 81);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(234, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo de Usuario";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Consultor",
            "Administrador"});
            this.cmbTipo.Location = new System.Drawing.Point(183, 148);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(234, 21);
            this.cmbTipo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clave de usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario";
            // 
            // FManUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 400);
            this.Controls.Add(this.panel1);
            this.Name = "FManUsuarios";
            this.Text = "FManUsuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBtnInactivo;
        private System.Windows.Forms.RadioButton rBtnActivo;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    }
}