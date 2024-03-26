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
using Unitivo.Repositorios.Implementaciones;

namespace Unitivo.Presentacion.SuperAdministrador
{
    public partial class GestionarPuestos : Form
    {
        PerfilRepositorio perfilRepositorio = new PerfilRepositorio();
        Perfile perfilParaEditar = new Perfile();
        public GestionarPuestos()
        {
            InitializeComponent();

        }

        private void String_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarStringKeyPress((TextBox)sender, e);
        }

        private void BEliminarPerfiles_Click(object sender, EventArgs e)
        {
            if (DataGridViewListarPerfiles.SelectedRows.Count == 0)
            {
                // No hay una fila seleccionada en el dgvEmpleados, muestra un mensaje de error.
                MessageBox.Show("Debe seleccionar una fila para eliminar un puesto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }

            if (DataGridViewListarPerfiles.SelectedRows.Count > 0)
            {
                int idEliminar = (int)DataGridViewListarPerfiles.SelectedRows[0].Cells["ID"].Value;
                perfilRepositorio.EliminarPerfil(idEliminar);

                CargarPerfiles();
            }
        }

        private void CargarPerfiles()
        {
            List<Perfile> perfiles = perfilRepositorio.ListarPerfilesActivos();
            DataGridViewListarPerfiles.Rows.Clear();
            DataGridViewListarPerfiles.Refresh();
            foreach (Perfile perfile in perfiles)
            {
                DataGridViewListarPerfiles.Rows.Add(perfile.Id, perfile.DescripcionPerfil, perfile.EstadoPerfil);
            }

            List<Perfile> perfilesDes = perfilRepositorio.ListarPerfilesDesactivos();
            DataGridViewListarPerfilesDesactivados.Rows.Clear();
            DataGridViewListarPerfilesDesactivados.Refresh();
            foreach (Perfile perfile in perfilesDes)
            {
                DataGridViewListarPerfilesDesactivados.Rows.Add(perfile.Id, perfile.DescripcionPerfil, perfile.EstadoPerfil);
            }

        }

        // Método para limpiar los TextBox después de agregar un perfil.
        private void LimpiarTextBoxs()
        {
            TBGestionPerfil.Clear();
        }

        private void GestionarPuestos_Load(object sender, EventArgs e)
        {
            CargarPerfiles();
        }

        private void BBuscarPerfil_Click(object sender, EventArgs e)
        {
            CargarPerfiles(perfilRepositorio.BuscarPerfil(TBGestionPerfil.Text));
        }

        private void CargarPerfiles(List<Perfile> nuevosPerfiles)
        {
            List<Perfile> perfiles = nuevosPerfiles;
            DataGridViewListarPerfiles.Rows.Clear();
            DataGridViewListarPerfiles.Refresh();
            foreach (Perfile perfile in perfiles)
            {
                DataGridViewListarPerfiles.Rows.Add(perfile.Id, perfile.DescripcionPerfil, perfile.EstadoPerfil);
            }
        }

        private void BModificarPerfiles_Click(object sender, EventArgs e)
        {
            if (DataGridViewListarPerfiles.SelectedRows.Count > 0)
            {
                string PuestoSeleccionado = Convert.ToString(DataGridViewListarPerfiles.SelectedRows[0].Cells["Descripcion"].Value);

                TBModPerfil.Text = PuestoSeleccionado;

                perfilParaEditar.Id = Convert.ToInt32(DataGridViewListarPerfiles.SelectedRows[0].Cells["ID"].Value);
                perfilParaEditar.DescripcionPerfil = PuestoSeleccionado;
                perfilParaEditar.EstadoPerfil = (bool)DataGridViewListarPerfiles.SelectedRows[0].Cells["Estado"].Value;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila para modificar un empleado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Salir del método sin realizar ninguna acción adicional.
            }
        }

        private void BModEmpleado_Click(object sender, EventArgs e)
        {
            perfilParaEditar.DescripcionPerfil = TBModPerfil.Text;
            perfilRepositorio.ModificarPerfil(perfilParaEditar);
            perfilParaEditar = new Perfile();
            CargarPerfiles();
            TBModPerfil.Text = "";

        }

        private void DataGridViewListarPerfilesDesactivados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener la fila que fue doble clickeada
                DataGridViewRow filaSeleccionada = DataGridViewListarPerfilesDesactivados.Rows[e.RowIndex];
                int IdSelect = (int)filaSeleccionada.Cells["DID"].Value;
                perfilRepositorio.ReactivarPerfil(IdSelect);
                CargarPerfiles();
            }
        }
    }
}
