using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using ClaseEntidades;

namespace UCR_Conta.Formas
{
    
    public partial class FLogIn : Form
    {
        string UsuarioTipo = string.Empty;
        string Usuario = string.Empty;
        string Tipo = string.Empty;
        public FLogIn()
        {
            InitializeComponent();
        }

        private void btnIng_Click(object sender, EventArgs e)
        {
            clsUsuarios.Usuarios_Usuario = txtUser.Text;
            clsUsuarios.Usuarios_Clave = txtPass.Text;

            UsuarioTipo = ClaseFunciones.ClassFunciones.EjecutaQueryString("OUT"); //--Obtener el Usuario y Tipo
            if (UsuarioTipo == null || UsuarioTipo == "")
            {
                MessageBox.Show("El Usuario o la cloave no es correcta");
                return;
            }
            string[] Sesion = UsuarioTipo.Split('-');

            //--------------------Almacenar en variable de entorno--------------------
            

            ConfigXmlDocument xmlDoc = new ConfigXmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach (XmlElement element in xmlDoc.DocumentElement)
            {

                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value == "User")
                        {
                            node.Attributes[1].Value = Sesion[0];
                        }
                        if (node.Attributes[0].Value == "Type")
                        {
                            node.Attributes[1].Value = Sesion[1];
                        }
                    }
                }
            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("appSettings");

            MessageBox.Show("El Login ha sido correcto");

        }
    }
}
