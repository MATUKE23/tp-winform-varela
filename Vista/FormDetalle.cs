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
    public partial class FormDetalle : Form
    {
        private Articulo articulo = null;
        public FormDetalle()
        {
            InitializeComponent();
        }
        public FormDetalle(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
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

        private void FormDetalle_Load(object sender, EventArgs e)
        {
            txtCodigo.Text = articulo.codigo;
            txtNombre.Text = articulo.nombre;
            txtDescripcion.Text = articulo.descripcion;
            txtCategoria.Text = "" + articulo.categoria;
            txtMarca.Text = "" + articulo.marca;
            txtPrecio.Text = "" + articulo.precio;

            cargarImagen(articulo.imagenUrl);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
