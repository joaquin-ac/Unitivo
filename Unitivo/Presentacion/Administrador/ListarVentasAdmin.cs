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

namespace Unitivo.Presentacion.Administrador
{
    public partial class ListarVentasAdmin : Form
    {
        public ListarVentasAdmin()
        {
            InitializeComponent();
        }

        private void NumStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CommonFunctions.ValidarKeyPress((TextBox)sender, e);
        }

        private void BVerDetalle_Click(object sender, EventArgs e)
        {
            // Crea una instancia del formulario DetalleVenta.
            DetalleVenta detalleVentaForm = new DetalleVenta();

            // Muestra el formulario de manera modal.
            DialogResult result = detalleVentaForm.ShowDialog();

            // Puedes manejar el resultado del formulario si es necesario.
            if (result == DialogResult.OK)
            {
                // Realiza alguna acción después de que el usuario cierre el formulario DetalleVenta.
            }
        }

    }
}
