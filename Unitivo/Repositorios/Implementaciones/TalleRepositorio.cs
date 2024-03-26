using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorio.Interfaces;
using Unitivo.Sessions;
using Unitivo.Presentacion.Logica.Constructores;
using Unitivo.Validators;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Unitivo.Repositorios.Interfaces;

namespace Unitivo.Repositorios.Implementaciones
{
    public class TalleRepositorio : TalleInterface
    {
        private readonly UnitivoContext? _contexto;

        public TalleRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }

        public bool AgregarTalle(Talle x)
        {
            try
            {
                x.Estado = true;
                _contexto?.Talles.Add(x);
                _contexto?.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Talles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool EliminarTalle(int id)
        {
            Talle? Talle = _contexto?.Talles.Find(id);
            if (Talle == null) return false;
            Talle.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
        public bool ModificarTalle(Talle Talle)
        {
            try
            {
                if (BuscarTalle(Talle.Descripcion) != null)
                {
                    MessageBox.Show("Ya existe un Talle con esa descripcion", "Talles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _contexto?.Talles.Update(Talle);
                int resultado = _contexto?.SaveChanges() ?? 0;
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Talles", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public Talle BuscarTallePorId(int id)
        {
            Talle Talle = _contexto?.Talles.Find(id)!;
            return Talle;
        }

        public List<Talle> BuscarTalle(string nombre)
        {
            List<Talle> Talles = _contexto?.Talles.Where(x => x.Descripcion.Contains(nombre)).ToList()!;
            return Talles;
        }

        public List<Talle> ListarTalles()
        {
            List<Talle> Talles = _contexto?.Talles.ToList()!;
            return Talles;
        }
        public List<Talle> ListarTallesActivos()
        {
            List<Talle> Talles = _contexto?.Talles.Where(x => x.Estado == true).ToList()!;
            return Talles;
        }
    }
}

