using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using Negocio;


namespace Vista
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void eliminarArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListar listar = new FormListar();
            listar.ShowDialog();
        }

        private void verDetalleDeArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDetalle detalle = new FormDetalle();
            detalle.ShowDialog();
        }

        private void buscarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBuscar buscar = new FormBuscar();
            buscar.ShowDialog();
        }

        private void tESTMOSTRARDATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormArticulos MostrarArticulos = new FormArticulos();   
            MostrarArticulos.ShowDialog();  
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAgregar agregar = new FormAgregar();
            agregar.ShowDialog();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormArticulos MostrarArticulos = new FormArticulos();
            MostrarArticulos.ShowDialog();
        }
    }
}
