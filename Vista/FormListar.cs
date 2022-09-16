using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using dominio;

namespace Vista
{
    public partial class FormListar : Form
    {
        List<Articulo> lista = new List<Articulo>();
        public FormListar()
        {
            InitializeComponent();
        }

        private void FormListar_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            lista = negocio.listado();
            dgvArticulos.DataSource = lista;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
            pbxArticulo.Load(lista[0].imagenUrl);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.imagenUrl);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

             pbxArticulo.Load("https://educacionprivada.org/wp-content/plugins/all-in-one-video-gallery/public/assets/images/placeholder-image.png");
            }
        }
    }
}
