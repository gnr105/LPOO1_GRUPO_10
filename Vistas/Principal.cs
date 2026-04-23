using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Hacer lo mismo que el boton aceptar para redirigir al formulario Sistema
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Clientes frmCliente = new Clientes();
            frmCliente.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Productos frmProductos = new Productos();
            frmProductos.Show();
        }

        private void btnAddOS_Click(object sender, EventArgs e)
        {
            ObrasSociales frmObraSocial = new ObrasSociales();
            frmObraSocial.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var ee = MessageBox.Show("Desea salir del menu principal?", "Atencion", MessageBoxButtons.OKCancel);
            
            if (ee.Equals(DialogResult.OK))
            {
                this.Close();
                
            }
            
            
            
        }
    }
}
