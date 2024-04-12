using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Sessions;
using Unitivo.Validators;

namespace Unitivo.Repositorios.Implementaciones
{
    public class ProductoRepositorio : ProductoInterface
    {
        private readonly UnitivoContext? _contexto;
        public ProductoRepositorio()
        {
            _contexto = Contexto.dbContexto;
            _contexto?.Categorias.Load();
            _contexto?.Talles.Load();
        }

        private void CargarTalleYCategorias()
        {
            _contexto?.Categorias.Load();
            _contexto?.Talles.Load();

            LocalStorage.categorias = _contexto?.Categorias.ToList();
            LocalStorage.talles = _contexto?.Talles.ToList();
        }
        public bool AgregarProducto(Producto x)
        {
            try
            {
                var validator = new ProductoValidator();
                var result = validator.Validate(x);

                if (!result.IsValid)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var failure in result.Errors)
                    {
                        sb.AppendLine($"{failure.PropertyName}: {failure.ErrorMessage}");
                    }
                    throw new ValidationException(sb.ToString());
                }

                string nombreAleatorio = Path.Combine("C:\\MisImagenes",
                Guid.NewGuid().ToString() + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg"
                );

                x.Imagen = "";
                x.Estado = true;
                x.FechaCreacion = DateTime.Now;

                _contexto?.Productos.Add(x);
                _contexto?.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Producto BuscarProducto(int id)
        {
            Producto prod = (from p in _contexto?.Productos
                             where p.Id == id
                             select p).First();
            return prod;
        }

        public bool EliminarProducto(int id)
        {
            Producto? producto = _contexto?.Productos.Find(id);
            if (producto == null) return false;
            producto.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public List<Producto> ListarProductos()
        {
            return _contexto?.Productos.ToList()!;
        }

        public bool ModificarProducto(Producto x, int stockAdic)
        {
            
            var validator = new ProductoValidator();
            var result = validator.Validate(x);

            try
            {
                if (!result.IsValid)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var failure in result.Errors)
                    {
                        sb.AppendLine($"{failure.PropertyName}: {failure.ErrorMessage}");
                    }
                    throw new ValidationException(sb.ToString());
                }


                Producto producto = (from p in _contexto?.Productos
                                      where p.Id == x.Id
                                      select p).First();
                MessageBox.Show(x.Stock.ToString());
                producto.Stock = x.Stock;
                producto.Nombre = x.Nombre;
                producto.Precio = x.Precio;
                producto.IdCategoria = x.IdCategoria;
                producto.IdTalle = x.IdTalle;
                producto.FechaModificacion = DateTime.Now;

                _contexto?.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Producto> ListarProductosActivos()
        {
            return _contexto?.Productos.Where(c => c.Estado == true || c.Stock != 0).ToList()!;
        }

        public List<Producto> BuscarProductoNombre(string nombre)
        {
            return _contexto?.Productos.Where(c => c.Nombre.Contains(nombre)).ToList()!;
        }

        public List<Producto> BuscarProductoNombreExacto(string nombre)
        {
            return _contexto?.Productos.Where(c => c.Nombre == nombre).ToList()!;
        }

        public List<Producto> BuscarProductos(string nom, string cat, string talle)
        {

            List<Producto> prods = (from p in _contexto?.Productos
                                    where p.IdCategoriaNavigation.Descripcion.Contains(cat) && p.Nombre.Contains(nom) && p.IdTalleNavigation.Descripcion.Contains(talle)
                                    select p).ToList();

            return prods;
        }

        public bool ReducirStockProducto(int id, int stockReducir)
        {

            Producto? producto = (from p in _contexto?.Productos
                                  where p.Id == id
                                  select p).First();

            producto.Stock -= stockReducir;
            if (producto.Stock <= 0)
            {
                producto.Estado = false;
            }

            try
            {
                _contexto?.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Producto> BuscarProductosActivos(string nom, string cat, string talle)
        {

            List<Producto> prods = (from p in _contexto?.Productos
                                    where p.Estado == true && p.IdCategoriaNavigation.Descripcion.Contains(cat) && p.Nombre.Contains(nom) && p.IdTalleNavigation.Descripcion.Contains(talle)
                                    select p).ToList();

            return prods;
        }

        public bool reactivarProducto(int idProducto)
        {
            Producto prod = (from p in _contexto?.Productos
                             where p.Id == idProducto
                             select p).First();
            prod.Estado = true;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }
    }

}
