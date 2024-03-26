using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Administrador
{

    public partial class AñadirCategoria : Form
    {
        CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
        public AñadirCategoria()
        {
            InitializeComponent();
            CargarCategorias();
        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void BRegistrarCategoria_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.ValidarCamposNoVacios(this))
            {
                try
                {
                    Categoria categoria = new Categoria();
                    categoria.Descripcion = TBNombreCategoria.Text;


                    if (categoriaRepositorio.AgregarCategoria(categoria))
                    {
                        MessageBox.Show("Categoria agregada correctamente");
                        LimpiarTextBoxs();
                        CargarCategorias();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Categoria");
                    }
                }
                catch (Exception ex)
                {
                    // Captura y maneja el error que ocurra en perfilRepositorio.AgregarCategoria(categoria)
                    MessageBox.Show("Error al agregar categoria: " + ex.Message, "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarCategorias()
        {
                List<Categoria> categorias = categoriaRepositorio.ListarCategoriasActivos();
                DataGridViewListarCategorias.Rows.Clear();
                DataGridViewListarCategorias.Refresh();
                foreach (Categoria categoria in categorias)
                {
                    DataGridViewListarCategorias.Rows.Add(categoria.Id, categoria.Descripcion, categoria.Estado);
                }
        }

            // Método para limpiar los TextBox después de agregar un perfil.
        private void LimpiarTextBoxs()
        {
                TBNombreCategoria.Clear();
        }



    }

 
}
