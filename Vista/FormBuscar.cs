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
    public partial class FormBuscar : Form
    {
        List<Articulo> lista = new List<Articulo>();
        public FormBuscar()
        {
            InitializeComponent();
        }

        private void FormBuscar_Load(object sender, EventArgs e)
        {
            cargar();
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
            pbxArticulo.Load(lista[0].imagenUrl);
            cbxCampo.Items.Add("Codigo");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Descripcion");
            cbxCampo.Items.Add("Marca");
            cbxCampo.Items.Add("Categoria");
            cbxCampo.Items.Add("Precio");
            
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();
            cbxCriterio.Text = "";
            cbxCriterio.Items.Clear();

            if (opcion == "Precio" || opcion == "Precio" )
            {
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = textBox1.Text;
                dgvArticulos.DataSource = negocio.buscarPorCriterio(campo, criterio, filtro);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            lista = negocio.listado();
            dgvArticulos.DataSource = lista;

        }

        private void btnVerTodo_Click(object sender, EventArgs e)
        {
            cargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            FormDetalle detalle = new FormDetalle(seleccionado);
            detalle.ShowDialog();
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

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.imagenUrl);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
