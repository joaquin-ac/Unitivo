using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Modelos;
using Unitivo.Presentacion.Logica;
using Unitivo.Presentacion.SuperAdministrador;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Administrador
{
    public partial class GestionarProductos : Form
    {
        private ProductoRepositorio productoRepositorio = new ProductoRepositorio();
        private CategoriaRepositorio categoriaRepositorio = new CategoriaRepositorio();
        private TalleRepositorio talleRepositorio = new TalleRepositorio();
        private Producto productoParaEditar = new Producto();
        
        public GestionarProductos()
        {
            InitializeComponent();
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaProductos.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            if (DataGridViewListaProductos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el usuario seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idEliminar = (int)DataGridViewListaProductos.SelectedRows[0].Cells["ID"].Value;
                    if (productoRepositorio.EliminarProducto(idEliminar))
                    {
                        MessageBox.Show("El usuario se eliminó correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarProductos();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el usuario.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (productoParaEditar.Id != 0 && TBNombreProducto.Text != "" && TBPrecioProducto.Text != "" && TBStockAdic.Text != "")
            {
                productoParaEditar = productoRepositorio.BuscarProducto(productoParaEditar.Id);
                productoParaEditar.Nombre = TBNombreProducto.Text;
                productoParaEditar.Precio = (double)decimal.Parse(TBPrecioProducto.Text);
                productoParaEditar.IdCategoria = (int)CBCategoriaProducto.SelectedValue;
                productoParaEditar.IdTalle = (int)CBTalleProducto.SelectedValue;
                int stockAgregar = int.Parse(TBStockAdic.Text);

                if (productoRepositorio.ModificarProducto(productoParaEditar, stockAgregar))
                {
                    CargarProductos();
                    MessageBox.Show("Se modifico con exito", "exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productoParaEditar = new Producto();
                    TBStockProducto.Text = "";
                    TBNombreProducto.Text = "";
                    TBPrecioProducto.Text = "";
                    TBStockAdic.Text = "";
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
                    DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.Stock, producto.IdTalleNavigation.Descripcion, producto.Precio, producto.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.Stock, producto.IdTalleNavigation.Descripcion, producto.Precio, producto.Estado);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListaProductos.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void GestionarProductos_Load(object sender, EventArgs e)
        {
            cargarCategorias();
            cargarTalles();
            CargarProductos();
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            string nom = TBBuscar.Text;
            string cat = CBCatBuscar.Text;
            string talle = CBTalleBuscar.Text;
            CargarProductos(nom, cat, talle);

        }

        private void cargarCategorias()
        {
            var categorias = categoriaRepositorio.ListarCategorias();
            CBCategoriaProducto.DataSource = categorias;
            CBCategoriaProducto.ValueMember = "Id";
            CBCategoriaProducto.DisplayMember = "Descripcion";

            CBCatBuscar.Items.AddRange(categorias.ToArray());
            CBCatBuscar.ValueMember = "Id";
            CBCatBuscar.DisplayMember = "Descripcion";
            CBCatBuscar.Text = "Todos";
        }

        private void cargarTalles()
        {
            var talles = talleRepositorio.ListarTalles();
            CBTalleProducto.DataSource = talles;
            CBTalleProducto.ValueMember = "Id";
            CBTalleProducto.DisplayMember = "Descripcion";

            CBTalleBuscar.Items.AddRange(talles.ToArray());
            CBTalleBuscar.ValueMember = "Id";
            CBTalleBuscar.DisplayMember = "Descripcion";
            CBTalleBuscar.Text = "Todos";
        }

        private void CargarProductos(string nom, string cat, string talle)
        {
            if (cat == "Todos")
            {
                cat = "";
            }
            if (talle == "Todos")
            {
                talle = "";
            }
            List<Producto> productos = productoRepositorio.BuscarProductos(nom, cat, talle);
            DataGridViewListaProductos.Rows.Clear();
            DataGridViewListaProductos.Refresh();
            foreach (Producto producto in productos)
            {
                if (producto.Estado == true)
                {
                    DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.Stock, producto.IdTalleNavigation.Descripcion, producto.Precio, producto.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListaProductos.Rows.Add(producto.Id, producto.Nombre, producto.IdCategoriaNavigation.Descripcion, producto.Stock, producto.IdTalleNavigation.Descripcion, producto.Precio, producto.Estado);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListaProductos.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        private void DataGridViewListaProductos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila que fue doble clickeada

                DataGridViewRow filaSeleccionada = DataGridViewListaProductos.Rows[e.RowIndex];
                bool estadoSelect = (bool)filaSeleccionada.Cells["Estado"].Value;
                if (estadoSelect == false)
                {
                    BEliminarProducto.Enabled = false;
                }
                else
                {
                    BEliminarProducto.Enabled = true;
                }
            }
        }

        private void DataGridViewListaProductos_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila que fue doble clickeada
                DataGridViewRow filaSeleccionada = DataGridViewListaProductos.Rows[e.RowIndex];
                int IdSelect = (int)filaSeleccionada.Cells["ID"].Value;
                if (productoRepositorio.reactivarProducto(IdSelect))
                {
                    MessageBox.Show("Se ha reactivado con exito.", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El puesto ya estaba activo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                CargarProductos();
            }
        }

        private void BModificarProducto_Click(object sender, EventArgs e)
        {
            if (DataGridViewListaProductos.SelectedRows.Count > 0)
            {
                var fila = DataGridViewListaProductos.SelectedRows[0];
                int idProducto = (int)DataGridViewListaProductos.SelectedRows[0].Cells["ID"].Value;

                TBNombreProducto.Text = fila.Cells["Producto"].Value.ToString();
                TBPrecioProducto.Text = fila.Cells["Precio"].Value.ToString();
                CBCategoriaProducto.Text = fila.Cells["Categoria"].Value.ToString();
                CBTalleProducto.Text = fila.Cells["Talle"].Value.ToString();
                TBStockProducto.Text = fila.Cells["Stock"].Value.ToString();
                TBStockAdic.Text = "0";

                productoParaEditar.Id = idProducto;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
        }
    }
}
