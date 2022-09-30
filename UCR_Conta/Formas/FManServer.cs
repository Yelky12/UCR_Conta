using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Xml;

namespace UCR_Conta.Formas
{
    public partial class FManServer : Form
    {
        public FManServer()
        {
            InitializeComponent();
            mostrarServidor();
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string NewServ = "";
            NewServ = txtServidor.Text;

            ConfigXmlDocument xmlDoc = new ConfigXmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement element in xmlDoc.DocumentElement) {

                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "Server")
                        {
                            node.Attributes[1].Value = NewServ;
                        }
                    }
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");

            MessageBox.Show("El servidor ha sido actualizado");
        }

        public void mostrarServidor() {

            string serv = "";
            serv = ConfigurationManager.AppSettings["Server"];
            txtServidor.Text = serv;

        }
    }
}
