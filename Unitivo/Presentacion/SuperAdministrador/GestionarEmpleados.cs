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
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class GestionarEmpleados : Form
    {
        EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();

        public GestionarEmpleados()
        {
            InitializeComponent();
            CargarEmpleados();
            // Establecer la selección inicial en la primera opción.
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BModificarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)
            {
                int idSeleccionado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["ID"].Value);

                ModificarEmpleado modificarEmpleadoForm = new ModificarEmpleado(idSeleccionado);

                DialogResult result = modificarEmpleadoForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    CargarEmpleados();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
        }

        private void CargarEmpleados()
        {
            List<Modelos.Empleado> empleados = empleadoRepositorio.ListarEmpleados();
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.Refresh();
            foreach (Modelos.Empleado empleado in empleados)
            {
                if (empleado.Estado == true)
                {
                    dgvEmpleados.Rows.Add(empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Telefono, empleado.Direccion, empleado.Correo, empleado.Edad);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = dgvEmpleados.Rows.Add(empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Dni, empleado.Telefono, empleado.Direccion, empleado.Correo, empleado.Edad, "Inactivo");

                    // Establecer el color de fondo de la fila agregada
                    dgvEmpleados.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }


        private void BEliminarEmpleado_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
            else
            {
                int idSeleccionado = Convert.ToInt32(dgvEmpleados.SelectedRows[0].Cells["ID"].Value);

                DialogResult result = MessageBox.Show("¿Está seguro que desea eliminar el empleado seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (empleadoRepositorio.EliminarEmpleado(idSeleccionado))
                    {
                        MessageBox.Show("El empleado se eliminó correctamente.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarEmpleados();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrió un error al eliminar el empleado.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
