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
    public partial class FManUsuarios : Form
    {
        public FManUsuarios()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            ClaseEntidades.clsUsuarios.Usuarios_Usuario = txtUsuario.Text;
            ClaseEntidades.clsUsuarios.Usuarios_Clave = txtClave.Text;
            if (rBtnActivo.Checked)
            {
                ClaseEntidades.clsUsuarios.Usuarios_Estado = 1;
            }
            else
            {
                ClaseEntidades.clsUsuarios.Usuarios_Estado = 0;
            }
            ClaseEntidades.clsUsuarios.Usuarios_TipoUsuario = (string)this.cmbTipo.SelectedItem;

            if (ClaseEntidades.clsUsuarios.Usuarios_TipoUsuario == null)
            {
                MessageBox.Show("Por favor selecciones un tipo de usuario");
                return;
            }


            //------Enviar a tabla
            ClaseFunciones.ClassFunciones.EjecutaQueryInsert("IUS");//Insertar Usuario
            MessageBox.Show("Usuario ingresado");



        }
    }
}
