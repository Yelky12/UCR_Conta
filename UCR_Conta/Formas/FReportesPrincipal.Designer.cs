
namespace UCR_Conta.Formas
{
    partial class FReportesPrincipal
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
            this.btnConfEstRes = new System.Windows.Forms.Button();
            this.pickerFin = new System.Windows.Forms.DateTimePicker();
            this.pickerIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBalanzaComprobacion = new System.Windows.Forms.Button();
            this.btnInfEstRes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInfEstRes);
            this.panel1.Controls.Add(this.btnConfEstRes);
            this.panel1.Controls.Add(this.pickerFin);
            this.panel1.Controls.Add(this.pickerIn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBalanzaComprobacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnConfEstRes
            // 
            this.btnConfEstRes.Location = new System.Drawing.Point(12, 62);
            this.btnConfEstRes.Name = "btnConfEstRes";
            this.btnConfEstRes.Size = new System.Drawing.Size(126, 44);
            this.btnConfEstRes.TabIndex = 66;
            this.btnConfEstRes.Text = "ConfiguracionEstado Resultado";
            this.btnConfEstRes.UseVisualStyleBackColor = true;
            this.btnConfEstRes.Click += new System.EventHandler(this.btnConfEstRes_Click);
            // 
            // pickerFin
            // 
            this.pickerFin.CustomFormat = "MM/dd/yyyy";
            this.pickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerFin.Location = new System.Drawing.Point(338, 38);
            this.pickerFin.Name = "pickerFin";
            this.pickerFin.Size = new System.Drawing.Size(128, 20);
            this.pickerFin.TabIndex = 65;
            this.pickerFin.Value = new System.DateTime(2021, 2, 27, 0, 0, 0, 0);
            // 
            // pickerIn
            // 
            this.pickerIn.CustomFormat = "MM/dd/yyyy";
            this.pickerIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickerIn.Location = new System.Drawing.Point(338, 12);
            this.pickerIn.Name = "pickerIn";
            this.pickerIn.Size = new System.Drawing.Size(128, 20);
            this.pickerIn.TabIndex = 64;
            this.pickerIn.Value = new System.DateTime(2021, 2, 27, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Fecha Final";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Fecha Inicio";
            // 
            // btnBalanzaComprobacion
            // 
            this.btnBalanzaComprobacion.Location = new System.Drawing.Point(12, 12);
            this.btnBalanzaComprobacion.Name = "btnBalanzaComprobacion";
            this.btnBalanzaComprobacion.Size = new System.Drawing.Size(126, 44);
            this.btnBalanzaComprobacion.TabIndex = 0;
            this.btnBalanzaComprobacion.Text = "Balanza de Comprobacion";
            this.btnBalanzaComprobacion.UseVisualStyleBackColor = true;
            this.btnBalanzaComprobacion.Click += new System.EventHandler(this.btnBalanzaComprobacion_Click);
            // 
            // btnInfEstRes
            // 
            this.btnInfEstRes.Location = new System.Drawing.Point(12, 112);
            this.btnInfEstRes.Name = "btnInfEstRes";
            this.btnInfEstRes.Size = new System.Drawing.Size(126, 44);
            this.btnInfEstRes.TabIndex = 67;
            this.btnInfEstRes.Text = "Estado de Resultado";
            this.btnInfEstRes.UseVisualStyleBackColor = true;
            this.btnInfEstRes.Click += new System.EventHandler(this.btnInfEstRes_Click);
            // 
            // FReportesPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FReportesPrincipal";
            this.Text = "FReportesPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBalanzaComprobacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker pickerFin;
        private System.Windows.Forms.DateTimePicker pickerIn;
        private System.Windows.Forms.Button btnConfEstRes;
        private System.Windows.Forms.Button btnInfEstRes;
    }
}