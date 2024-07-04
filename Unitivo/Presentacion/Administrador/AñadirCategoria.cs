using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Administrador
{

    public partial class AñadirCategoria : Form
    {
        CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
        TipoTalleRepositorio tipoTalleRepositorio = new TipoTalleRepositorio(); // Repositorio para tipoTalle

        public AñadirCategoria()
        {
            InitializeComponent();
            CargarCategorias();
            CargarTipoTalles();
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

                if (CBTipoTalle.SelectedItem != null)
                {
                    categoria.TipoTalleId = ((TipoTalle)CBTipoTalle.SelectedItem).Id; // Guardar el ID de tipoTalle
                }

                if (CBTipoTalle.SelectedItem != null && categoriaRepositorio.AgregarCategoria(categoria))
                {
                    MessageBox.Show("Categoria agregada correctamente");
                    LimpiarTextBoxs();
                    CargarCategorias();
                    CargarTipoTalles();
                }
                else
                {
                    MessageBox.Show("Error al agregar Categoria");
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos y seleccionar un tipo de talle válido", "Talle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarTipoTalles()
        {
            var tipoTalles = tipoTalleRepositorio.ListarTipoTalles();

            CBTipoTalle.Items.AddRange(tipoTalles.ToArray());
            CBTipoTalle.ValueMember = "Id";
            CBTipoTalle.DisplayMember = "Descripcion";
            CBTipoTalle.Text = "Seleccione un tipo de talle";
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
                    DataGridViewListarCategorias.Rows.Add(categoria.Id, categoria.Descripcion, categoria.Estado, categoria.TipoTalleIdNavigation.Descripcion);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListarCategorias.Rows.Add(categoria.Id, categoria.Descripcion, categoria.Estado, categoria.TipoTalleIdNavigation.Descripcion);

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

        private void CBTipoTalle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PanelRegCategoria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }


}
