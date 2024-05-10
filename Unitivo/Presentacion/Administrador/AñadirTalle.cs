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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Unitivo.Presentacion.Administrador
{
    public partial class AñadirTalle : Form
    {
        TalleRepositorio talleRepositorio = new TalleRepositorio();
        private string tipoDeTalle = "Cualquiera";
        public AñadirTalle()
        {
            InitializeComponent();
            CargarTalles();
        }

        private void Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tipoDeTalle == "numeros")
            {
                CommonFunctions.ValidarNumerosSinEspacios(sender, e);
            }
            else if (tipoDeTalle == "letras")
            {
                CommonFunctions.ValidarLetrasSinEspacios(sender, e);
            }
            else
            {
                CommonFunctions.ValidarKeyPress((System.Windows.Forms.TextBox)sender, e);
            }
            
        }

        private void BRegistrarTalle_Click(object sender, EventArgs e)
        {
            if (CommonFunctions.ValidarCamposNoVacios(this))
            {
                try
                {
                    Talle talle = new Talle();
                    talle.Descripcion = TBNombreTalle.Text;


                    if (talleRepositorio.AgregarTalle(talle))
                    {
                        MessageBox.Show("Talle agregada correctamente");
                        LimpiarTextBoxs();
                        CargarTalles();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Talle");
                    }
                }
                catch (Exception ex)
                {
                    // Captura y maneja el error que ocurra en talleRepositorio.AgregarTalle(talle)
                    MessageBox.Show("Error al agregar talle: " + ex.Message, "Talle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Talle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarTalles()
        {
            List<Talle> talles = talleRepositorio.ListarTallesActivos();
            DataGridViewListarTalles.Rows.Clear();
            DataGridViewListarTalles.Refresh();

            foreach (Talle talle in talles)
            {
                if (talle.Estado == true)
                {
                    DataGridViewListarTalles.Rows.Add(talle.Id, talle.Descripcion, talle.Estado);
                }
                else
                {
                    // Agregar la fila con el estado "Inactivo"
                    int rowIndex = DataGridViewListarTalles.Rows.Add(talle.Id, talle.Descripcion, talle.Estado);

                    // Establecer el color de fondo de la fila agregada
                    DataGridViewListarTalles.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        // Método para limpiar los TextBox después de agregar un perfil.
        private void LimpiarTextBoxs()
        {
            TBNombreTalle.Clear();
        }

        private void AñadirTalle_Load(object sender, EventArgs e)
        {

        }

        private void TBNombreTalle_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBNombreTalle.Text) && char.IsDigit(TBNombreTalle.Text[0]))
            {
                // Si el primer carácter es un número

                tipoDeTalle = "numeros";
            }
            else if (!string.IsNullOrEmpty(TBNombreTalle.Text) && char.IsLetter(TBNombreTalle.Text[0]))
            {
                // Si el primer carácter es una letra
                tipoDeTalle = "letras";
            }
            else
            {
                tipoDeTalle = "cualquiera";
            }
        }
    }
}
