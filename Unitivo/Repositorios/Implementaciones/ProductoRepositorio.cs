using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public ProductoRepositorio() {
            _contexto = Contexto.dbContexto;
        }

        private void CargarTalleYCategorias()
        {
            _contexto?.Categorias.Load();
            _contexto?.Talles.Load();

            LocalStorage.categorias = _contexto?.Categorias.ToList();
            LocalStorage.talles = _contexto?.Talles.ToList();
        }
        public void AgregarProducto(Producto x)
        {
            try
            {
                var validator = new ProductoValidator();
                var result = validator.Validate(x);

                if(!result.IsValid)
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

                x.Imagen = nombreAleatorio;
                x.Estado = true;
                x.FechaCreacion = DateTime.Now;

                _contexto?.Productos.Add(x);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Producto BuscarProducto(int id)
        {
            return _contexto?.Productos.Find(id)!;
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
            if (LocalStorage.categorias.IsNullOrEmpty() || LocalStorage.talles.IsNullOrEmpty())
            {
                CargarTalleYCategorias();
            }
            if (LocalStorage.productos.IsNullOrEmpty())
            {
                LocalStorage.productos = _contexto?.Productos.ToList();
            }
           return LocalStorage.productos!;
        }

        public bool ModificarProducto(Producto x, int stockAdic)
        {
            Producto? producto = _contexto?.Productos.Find(x.Id);
            producto!.Stock = producto.Stock + stockAdic;
            _contexto?.Productos.Update(producto);
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public List<Producto> ListarProductosActivos(){
            return _contexto?.Productos.Where(c => c.Estado == true || c.Stock != 0).ToList()!;
        }

        public List<Producto> BuscarProductoNombre(string nombre){
            return _contexto?.Productos.Where(c => c.Nombre == nombre).ToList()!;
        }
    }
}
