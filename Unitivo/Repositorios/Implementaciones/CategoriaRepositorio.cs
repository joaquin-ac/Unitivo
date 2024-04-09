using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorio.Interfaces;
using Unitivo.Sessions;
using Unitivo.Presentacion.Logica.Constructores;
using Unitivo.Validators;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Unitivo.Repositorios.Implementaciones
{
    public class CategoriaRepositorio : CategoriaInterface{
        private readonly UnitivoContext? _contexto;

        public CategoriaRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }    
        
        public bool AgregarCategoria(Categoria x){
            if (BuscarCategoria(x.Descripcion).Count > 0)
            {
                return false;
            }
            try{
                x.Estado = true;
                _contexto?.Categorias.Add(x);
                _contexto?.SaveChanges();
                return true;
            }   
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            } 
        }
        public bool EliminarCategoria(int id){
            Categoria? Categoria = _contexto?.Categorias.Find(id);
            if(Categoria == null) return false;
            Categoria.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
        public bool ModificarCategoria(Categoria Categoria){
            try
            {
                if(BuscarCategoriaExacta(Categoria.Descripcion).Count > 0){
                    MessageBox.Show("Ya existe un Categoria con esa descripcion", "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                _contexto?.Categorias.Update(Categoria);
                int resultado = _contexto?.SaveChanges() ?? 0;
                return resultado > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Categorias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public Categoria BuscarCategoriaPorId(int id){
            Categoria Categoria = _contexto?.Categorias.Find(id)!;
            return Categoria;
        
        }
        
        public List<Categoria> BuscarCategoria(string nombre){
            List<Categoria> Categorias = _contexto?.Categorias.Where(x => x.Descripcion.Contains(nombre)).ToList()!;
            return Categorias;
        }

        public List<Categoria> BuscarCategoriaExacta(string nombre)
        {
            List<Categoria> Categorias = _contexto?.Categorias.Where(x => x.Descripcion == nombre).ToList()!;
            return Categorias;
        }

        public List<Categoria> ListarCategorias(){
            List<Categoria> Categorias = _contexto?.Categorias.ToList()!;
            return Categorias;
        }
        public List<Categoria> ListarCategoriasActivos(){
            List<Categoria> Categorias = _contexto?.Categorias.Where(x => x.Estado == true).ToList()!;
            return Categorias;
        }

        public bool reactivarCategoria(int id)
        {
            Categoria cat = (from c in _contexto?.Categorias
                            where c.Id == id
                            select c).First();
            cat.Estado = true;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
    }
}