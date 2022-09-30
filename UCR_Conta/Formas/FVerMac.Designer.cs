
namespace UCR_Conta.Formas
{
    partial class FVerMac
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
            this.btnObtMac = new System.Windows.Forms.Button();
            this.lblMac = new System.Windows.Forms.Label();
            this.btnEnvMac = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnObtMac
            // 
            this.btnObtMac.Location = new System.Drawing.Point(17, 31);
            this.btnObtMac.Name = "btnObtMac";
            this.btnObtMac.Size = new System.Drawing.Size(126, 35);
            this.btnObtMac.TabIndex = 0;
            this.btnObtMac.Text = "Obtener Mac";
            this.btnObtMac.UseVisualStyleBackColor = true;
            this.btnObtMac.Click += new System.EventHandler(this.btnObtMac_Click);
            // 
            // lblMac
            // 
            this.lblMac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMac.Location = new System.Drawing.Point(285, 54);
            this.lblMac.Name = "lblMac";
            this.lblMac.Size = new System.Drawing.Size(201, 22);
            this.lblMac.TabIndex = 1;
            this.lblMac.Text = "MM: MM: MM: SS: SS: SS";
            this.lblMac.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnvMac
            // 
            this.btnEnvMac.Location = new System.Drawing.Point(17, 72);
            this.btnEnvMac.Name = "btnEnvMac";
            this.btnEnvMac.Size = new System.Drawing.Size(126, 35);
            this.btnEnvMac.TabIndex = 2;
            this.btnEnvMac.Text = "Enviar Mac";
            this.btnEnvMac.UseVisualStyleBackColor = true;
            this.btnEnvMac.Click += new System.EventHandler(this.btnEnvMac_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(17, 113);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(126, 35);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar Mac";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatus.Location = new System.Drawing.Point(285, 95);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(201, 23);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(198, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dirección  MAC";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(198, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Estatus";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.btnVerificar);
            this.panel1.Controls.Add(this.btnEnvMac);
            this.panel1.Controls.Add(this.lblMac);
            this.panel1.Controls.Add(this.btnObtMac);
            this.panel1.Location = new System.Drawing.Point(-5, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 273);
            this.panel1.TabIndex = 7;
            // 
            // FVerMac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 256);
            this.Controls.Add(this.panel1);
            this.Name = "FVerMac";
            this.Text = "Activar Producto";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnObtMac;
        private System.Windows.Forms.Label lblMac;
        private System.Windows.Forms.Button btnEnvMac;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}