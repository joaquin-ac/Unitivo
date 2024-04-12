using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Repositorios.Implementaciones;
using Unitivo.Sessions;

namespace Unitivo.Presentacion.Administrador
{
    public partial class AñadirProducto : Form
    {
        private ProductoRepositorio productoRepositorio = new ProductoRepositorio();
        private CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
        private TalleRepositorio talleRepositorio = new TalleRepositorio();

        private string? rutaImagenProducto;
        private Image? image;
        public AñadirProducto()
        {
            InitializeComponent();
            AñadirProducto_Load();
        }

        private void AñadirProducto_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            cargarTalles();
            CargarProductos();
        }
        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void Num_DecimalKeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarDecimalKeyPress((TextBox)sender, e);
        }


        private void CargarProductos()
        {
            List<Producto> productos = productoRepositorio.ListarProductos();
            DataGridViewListaProductos.Rows.Clear();
            DataGridViewListaProductos.Refresh();
            foreach (Producto producto in productos)
            {
                if (producto.Estado == true)
                {
                    DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.Stock, producto.Precio, producto.IdTalleNavigation.Descripcion);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.Stock, producto.Precio, producto.IdTalleNavigation.Descripcion);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListaProductos.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void BAñadirProducto_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.ValidarCamposNoVacios(this) && CBCategoria.Text != "" && CBTalle.Text != "" && !(TBPrecio.Text.Contains(".") && TBPrecio.Text.Split('.')[1].Length > 2))
            {
                Producto producto = new Producto();
                producto.Nombre = TBNombreProducto.Text;
                producto.IdCategoria = (int)CBCategoria.SelectedValue;
                producto.Stock = int.Parse(TBStock.Text);
                producto.Precio = double.Parse(TBPrecio.Text);
                producto.IdTalle = (int)CBTalle.SelectedValue;
                producto.Imagen = rutaImagenProducto!;

                if (productoRepositorio!.AgregarProducto(producto))
                {
                    MessageBox.Show("Producto agregado correctamente.");
                    LimpiarTextBoxs();
                    cargarCategorias();
                    cargarTalles();
                    CargarProductos();
                }
                else
                {
                    MessageBox.Show("Error al agregar el Producto.");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenProducto = openFileDialog.FileName;
                    pictureBoxProducto.Image = Image.FromFile(rutaImagenProducto);
                    image!.Save(rutaImagenProducto);
                }
            }
        }

        private void LimpiarTextBoxs()
        {
            TBNombreProducto.Text = "";
            TBPrecio.Text = "";
            TBStock.Text = "";
            CBCategoria.SelectedValue = 0;
            CBTalle.SelectedValue = 0;
        }
        private void AñadirProducto_Load()
        {
            // Cargar las categorías.
            CBCategoria.DataSource = LocalStorage.categorias;
            CBCategoria.DisplayMember = "Nombre";
            CBCategoria.ValueMember = "Id";

            // Cargar los talles.
            CBTalle.DataSource = LocalStorage.talles;
            CBTalle.DisplayMember = "Nombre";
            CBTalle.ValueMember = "Id";
        }

        private bool verificarCamposNulos()
        {
            // Verificar si algún TextBox está vacío.
            if (string.IsNullOrWhiteSpace(TBNombreProducto.Text) ||
                CBCategoria.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(TBStock.Text) ||
                string.IsNullOrWhiteSpace(TBPrecio.Text) ||
                CBTalle.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(rutaImagenProducto)
                )
            {
                MessageBox.Show("Todos los campos son obligatorios. Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("Producto registrado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
        }

        private void cargarCategorias()
        {
            var categorias = categoriaRepositorio.ListarCategorias();
            CBCategoria.DataSource = categorias;
            CBCategoria.ValueMember = "Id";
            CBCategoria.DisplayMember = "Descripcion";
        }

        private void cargarTalles()
        {
            var talles = talleRepositorio.ListarTalles();
            CBTalle.DataSource = talles;
            CBTalle.ValueMember = "Id";
            CBTalle.DisplayMember = "Descripcion";
        }

        private void DataGridViewListaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
