using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Negocio;
using Microsoft.VisualBasic.ApplicationServices;

namespace Capa_Presentacion
{
    public partial class login : Form
    {
        CN_Trabajador objetoCN = new CN_Trabajador();

        private string idZona = null;
        private string valor = null;
        public login()
        {
            InitializeComponent();
        }


        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            CN_Trabajador objetoCN = new CN_Trabajador();
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (objetoCN.VerificarUsuario(usuario, contraseña))
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                
                // Redirecciona al formulario principal
                Principal Principal = new Principal();
                Principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }

        }
    }
}
