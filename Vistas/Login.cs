using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClaseBase;

namespace Vistas
{
    public partial class Login : Form
    {
        List<Usuario> listUsuarios = new List<Usuario>();
        List<Rol> listRol = new List<Rol>();
        //Rol oRol = new Rol(1, "Administrador");
        //Rol oRol = new Rol(2, "Operador");
        //Rol oRol = new Rol(3, "Auditor");

        public Login()
        {
            InitializeComponent();
            CargarDatosIniciales();

        }

        private void CargarDatosIniciales()
        {
            listRol.Add(new Rol(1, "Administrador"));
            listRol.Add(new Rol(2, "Operador"));
            listRol.Add(new Rol(3, "Auditor"));

            listUsuarios.Add(new Usuario(1, "Test", "123", "Rodriguez", 1));
            listUsuarios.Add(new Usuario(2, "Marcos", "444", "Valdez", 2));
            listUsuarios.Add(new Usuario(3, "Agustin", "555", "Callata", 3));


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txtUsuario.Text;
            string pass = txtContraseña.Text;

            var usuarioValido = listUsuarios.Find(u => u.Usu_NombreUsuario == user && u.Usu_Contraseña == pass);

            if (usuarioValido != null)
            {
                Principal frmPrincipal = new Principal();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            //Solo se ejecuta si el login es correcto
            //Principal home = new Principal();
            //home.Show();

            //else
            //MessageBox de error
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var ee = MessageBox.Show("Desea Salir?", "Atencion", MessageBoxButtons.OKCancel);
            if (ee == DialogResult.Yes)
            {
                Application.Exit();
            }
        
        }

    }
}
