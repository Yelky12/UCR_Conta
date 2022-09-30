using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCR_Conta.Formas
{
    public partial class FPorcentaje : Form
    {
        public string porcentaje;
        public FPorcentaje()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            porcentaje = txtPorcentaje.Text;
            if (porcentaje == "" || porcentaje == "null")
            {
                porcentaje = "0";
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar);

        }
    }
}
