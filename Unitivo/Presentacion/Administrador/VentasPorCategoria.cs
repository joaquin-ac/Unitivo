using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unitivo.Presentacion.Administrador
{
    public partial class VentasPorCategoria : Form
    {
        public VentasPorCategoria()
        {
            InitializeComponent();
        }

        private void BBuscarCategoria_Click(object sender, EventArgs e)
        {
            DateTime fecha = System.DateTime.Now;
            if (DateTimeDesde.Value > DateTimeHasta.Value || DateTimeDesde.Value > fecha || DateTimeHasta.Value > fecha)
            {
                MessageBox.Show("Fecha incorrecta.", "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //CargarVentas(DateTimeDesde.Value, DateTimeHasta.Value.AddDays(1), TBBuscar.Text);
            }
        }
    }
}
