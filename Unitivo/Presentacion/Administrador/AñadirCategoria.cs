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
                if (categoria.Estado == true)
                {
                    DataGridViewListarCategorias.Rows.Add(categoria.Id, categoria.Descripcion, categoria.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListarCategorias.Rows.Add(categoria.Id, categoria.Descripcion, categoria.Estado);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListarCategorias.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        // Método para limpiar los TextBox después de agregar un perfil.
        private void LimpiarTextBoxs()
        {
            TBNombreCategoria.Clear();
        }

        private void AñadirCategoria_Load(object sender, EventArgs e)
        {

        }
    }


}
