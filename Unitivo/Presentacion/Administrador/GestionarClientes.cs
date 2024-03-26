﻿using System;
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
using Unitivo.Presentacion.Logica.Constructores;
using Unitivo.Presentacion.Vendedor;
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.Administrador
{
    public partial class GestionarClientes : Form
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        public GestionarClientes()
        {
            InitializeComponent();
            CargarClientes();
            // Establecer la selección inicial en la primera opción.
            ComboBoxBuscarDni.SelectedIndex = 0;
        }

        private void BuscarPorComboBox(object sender, KeyPressEventArgs e)
        {
            if (ComboBoxBuscarDni.Text == "DNI")
            {
                CommonFunctions.ValidarNumberKeyPress((TextBox)sender, e);
            }
            else
            {
                CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
            }
        }


        private void BModificarCliente_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada en el DataGridView
            if (DataGridViewListarClientes.SelectedRows.Count > 0)
            {
                // Obtén el ID del cliente seleccionado

                int idSeleccionado = Convert.ToInt32(DataGridViewListarClientes.SelectedRows[0].Cells["ID"].Value);

                // Crea una instancia del formulario ModificarCliente y pasa los detalles del cliente como parámetros
                ModificarCliente modificarClienteForm = new ModificarCliente(idSeleccionado);

                // Muestra el formulario ModificarCliente como cuadro de diálogo modal
                DialogResult result = modificarClienteForm.ShowDialog();

                // Puedes realizar acciones después de que se cierre el formulario ModificarCliente si es necesario
                if (result == DialogResult.OK)
                {
                    // Realiza acciones si se cerró el formulario con DialogResult.OK
                    CargarClientes();
                }
            }
            else
            {
                MessageBox.Show("Selecciona un elemento en el DataGridView antes de modificarlo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CargarClientes()
        {
            List<Cliente> clientes = clienteRepositorio.ListarClientes();
            DataGridViewListarClientes.Rows.Clear();
            DataGridViewListarClientes.Refresh();
            foreach (Cliente cliente in clientes)
            {
                if(cliente.Estado == true)
                {
                    DataGridViewListarClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Telefono, cliente.Direccion, cliente.Correo);
                }
                else 
                {
                    int rowIndex = DataGridViewListarClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Telefono, cliente.Direccion, cliente.Correo, "Inactivo");

                    DataGridViewListarClientes.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }


        private void BBuscar_Click(object sender, EventArgs e)
        {
            object parametro = TBBuscar.Text;
            if (parametro != null)
            {
                List<Cliente> clientes = clienteRepositorio.BuscarCliente(parametro);
                if (clientes != null)
                {
                    DataGridViewListarClientes.Rows.Clear();
                    DataGridViewListarClientes.Refresh();
                    foreach (Cliente cliente in clientes)
                    {
                        DataGridViewListarClientes.Rows.Add(cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Dni, cliente.Telefono, cliente.Direccion, cliente.Correo);
                    }
                }
                else
                {
                    DataGridViewListarClientes.Rows.Clear();
                    DataGridViewListarClientes.Refresh();
                }
            }
            else
            {
                CargarClientes();
            }
        }

         private void BEliminarClientes_Click(object sender, EventArgs e)
        {
            if (DataGridViewListarClientes.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            } else
            {
                // Obtén el ID del cliente seleccionado
                int idSeleccionado = Convert.ToInt32(DataGridViewListarClientes.SelectedRows[0].Cells["ID"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el cliente seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if(clienteRepositorio.EliminarCliente(idSeleccionado))
                    {

                        MessageBox.Show("El cliente se eliminó correctamente.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarClientes();
                    } else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el cliente.", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
} 