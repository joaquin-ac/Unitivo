using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unitivo.Presentacion.Logica;
using Unitivo.Presentacion.Vendedor;

namespace Unitivo.Formularios.Vendedor
{
    public partial class AñadirVentas : Form
    {
        public AñadirVentas()
        {
            InitializeComponent();
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
        }

        private void BBuscarCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBDniCliVenta.Text))
            {
                // El TextBox está vacío, así que debes mostrar el formulario BuscarCliente como un diálogo modal.
                BuscarCliente buscarClienteForm = new BuscarCliente();
                DialogResult result = buscarClienteForm.ShowDialog();

                // Aquí puedes manejar el resultado si es necesario.
                if (result == DialogResult.OK)
                {
                    // Realiza alguna acción después de seleccionar un cliente en el formulario BuscarCliente.
                }
            }
            else
            {
                // El TextBox no está vacío, realiza alguna acción o muestra un mensaje de error.
            }
        }

        private void BBuscarProducto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TBProductoVenta.Text))
            {
                // El TextBox está vacío, así que debes mostrar el formulario BuscarProducto como un diálogo modal.
                BuscarProducto buscarProductoForm = new BuscarProducto();
                DialogResult result = buscarProductoForm.ShowDialog();

                // Aquí puedes manejar el resultado si es necesario.
                if (result == DialogResult.OK)
                {
                    // Realiza alguna acción después de seleccionar un producto en el formulario BuscarProducto.
                }
            }
            else
            {
                // El TextBox no está vacío, realiza alguna acción o muestra un mensaje de error.
            }
        }

        private void BAñadir_Click(object sender, EventArgs e)
        {
            // Verificar si alguno de los campos está vacío.
            if (string.IsNullOrEmpty(TBDniCliVenta.Text) ||
                string.IsNullOrEmpty(TBNombreCliVenta.Text) ||
                string.IsNullOrEmpty(TBApellidoCliVenta.Text) ||
                string.IsNullOrEmpty(TBTelCliVenta.Text) ||
                string.IsNullOrEmpty(TBProductoVenta.Text) ||
                string.IsNullOrEmpty(TBPrecio.Text) ||
                string.IsNullOrEmpty(TBStock.Text) ||
                string.IsNullOrEmpty(TBTalle.Text) ||
                string.IsNullOrEmpty(TBCantidad.Text))
            {
                // Al menos uno de los campos está vacío, mostrar un mensaje de error.
                MessageBox.Show("Por favor, complete todos los campos antes de añadir la venta.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Todos los campos están llenos, puedes realizar la acción de agregar el producto.
                // Agregar código aquí para realizar la acción deseada, por ejemplo, agregar el producto a una lista o base de datos.

                // Después de agregar el producto, mostrar un mensaje de éxito.
                MessageBox.Show("Venta añadida con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void BEliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgvListaVentas.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvListaVentas, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }

        private void BModificarProducto_Click(object sender, EventArgs e)
        {
            if (dgvListaVentas.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvListaVentas, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para modificar un producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            // Aquí puedes agregar el código para eliminar el producto seleccionado.
        }


        private void BConfirmar_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario ModificarPerfiles
            FacturaVenta facturaVentaForm = new FacturaVenta();

            // Mostrar el formulario como un cuadro de diálogo modal
            DialogResult result = facturaVentaForm.ShowDialog();

            // Aquí puedes realizar acciones después de que se cierre el formulario ModificarPerfiles
            if (result == DialogResult.OK)
            {
                // Por ejemplo, actualizar la lista de perfiles o realizar otras acciones necesarias
                // después de modificar el perfil.
            }
        }





    }
}
