using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCR_Conta.Formas;

namespace UCR_Conta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FCompras frm = new FCompras();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FVentas frm = new FVentas();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FManCatCuentas frm = new FManCatCuentas();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FManTercero frm = new FManTercero();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FManEmpresa frm = new FManEmpresa();
            frm.Show();
        }
    }
}
