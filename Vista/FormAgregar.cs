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
    public partial class FormAgregar : Form
    {
        private Articulo articulo = null; 

        public FormAgregar()
        {
            InitializeComponent();
        }

        public FormAgregar(Articulo articulo) // constructor de modificar
        {
            InitializeComponent();
            this.articulo = articulo;   // pasamanos entre ventanas
            Text = "Modificar Articulo";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void BtnAceptar_Click(object sender, EventArgs e) // parte de front
        {
            //Articulo nuevoArt = new Articulo();   
            ArticuloNegocio negocio = new ArticuloNegocio();    

            try
            {//precarga de elementos
                if(articulo==null) //si apreta aceptar en el form y el art esta null estas por agregar uno nuevo
                articulo = new Articulo();  

                articulo.codigo = txtCodeArt.Text;
                articulo.nombre = TxtNameArt.Text;
                articulo.descripcion = TxtDesc.Text;
                articulo.imagenUrl = TxtImagenUrl.Text;
                articulo.marca = (Marca)CboMarca.SelectedItem;//aca capturo el obj completo
                articulo.categoria= (Categoria)CboCategoria.SelectedItem;
                articulo.precio = decimal.Parse(txtPrecio.Text);

                if(articulo.id!=0) // si modifico tiene ID
                {
                    negocio.Modificar(articulo);
                    MessageBox.Show("Agregado exitosamente");

                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }


               

                Close();    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                CboCategoria.DataSource = categoriaNegocio.listar();
                CboCategoria.ValueMember = "id"; //valor clave
                CboCategoria.DisplayMember = "descripcion"; //propiedad de obj 
                
                if(articulo!=null) // si true esta modificando. Precargo datos de modificar
                {
                    txtCodeArt.Text = articulo.codigo;
                    TxtNameArt.Text = articulo.nombre;
                    TxtDesc.Text = articulo.descripcion;
                    TxtImagenUrl.Text = articulo.imagenUrl;
                    cargarImagen(articulo.imagenUrl);// precarga dato url del elemento seleccionado
                    CboCategoria.SelectedValue = articulo.categoria.id; // con esto preseleccion el Combobox
                    txtPrecio.Text = articulo.precio.ToString();
                }
            
            }
            catch (Exception ex)
            {

                throw;
            }


            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                CboMarca.DataSource = marcaNegocio.listar();
                CboMarca.ValueMember = "id";
                CboMarca.DisplayMember = "descripcion";

                if (articulo != null) // si true esta modificando. Precargo datos de modificar
                {
                    txtCodeArt.Text = articulo.codigo;
                    TxtNameArt.Text = articulo.nombre;
                    TxtDesc.Text = articulo.descripcion;
                    TxtImagenUrl.Text = articulo.imagenUrl;
                    cargarImagen(articulo.imagenUrl);// precarga dato url del elemento seleccionado
                    CboMarca.SelectedValue=articulo.marca.id;
                    txtPrecio.Text = articulo.precio.ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void cargarImagen(string imagen) //si la imagen falla entonces muestra imagen x defecto
        {
            try
            {
                PbxImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                PbxImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void TxtImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(TxtImagenUrl.Text);
        }
    }
}
