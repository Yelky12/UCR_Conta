using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UCR_Conta.Formas;

namespace UCR_Conta.Formas
{
    public partial class FReportesPrincipal : Form
    {
        public FReportesPrincipal()
        {
            InitializeComponent();
            pickerIn.Value= DateTime.Now.Date;
            pickerFin.Value = DateTime.Now.Date;
        }

        private void btnBalanzaComprobacion_Click(object sender, EventArgs e)
        {
            string fechain = "";
            string fechafin = "";
            fechain = pickerIn.Value.ToString("yyyy-MM-dd");
            fechafin = pickerFin.Value.ToString("yyyy-MM-dd");


            //Process p = new Process();
            //ProcessStartInfo psi = new ProcessStartInfo("C:\\Program Files (x86)\\SetInfoComp\\SetInfComp\\InformesBalanceComprobacion.exe");
            ////ProcessStartInfo psi = new ProcessStartInfo("C:\\Users\\aguil\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\InformesBalanceComprobacion\\InformesBalanceComprobacion.appref-ms");
            //psi.Arguments = "/" + fechain + "/" + fechafin + "";
            //p.StartInfo = psi;
            //p.Start();

            FInfBalCompro frm = new FInfBalCompro(fechain, fechafin);
            frm.Show();


            

        }

        private void btnConfEstRes_Click(object sender, EventArgs e)
        {
            FConfiEstResul frm = new FConfiEstResul();
            frm.Show();
        }

        private void btnInfEstRes_Click(object sender, EventArgs e)
        {
            FInfEstResultado frm = new FInfEstResultado();
            frm.Show();
        }
    }
}
