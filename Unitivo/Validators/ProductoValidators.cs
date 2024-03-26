using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Unitivo.Modelos;
using Unitivo.Presentacion.Vendedor;
using Unitivo.Repositorio.Interfaces;
using Unitivo.Repositorios.Implementaciones;
using Unitivo.Repositorios.Interfaces;

namespace Unitivo.Validators
{
    public class ProductoValidator : AbstractValidator<Producto>
    {

        private readonly ProductoInterface? productoRepositorio;
        private readonly CategoriaInterface? categoriaRepositorio;
        private readonly TalleInterface? talleRepositorio;
        
        public ProductoValidator()
        {
            //validar Nombre
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El campo Nombre es obligatorio.")
                .Must(ExisteNombre).WithMessage("Ya existe un producto con este nombre.")
                ;
            //validar categoria
            RuleFor(x => x.IdCategoria)
                .NotEmpty().WithMessage("El campo Categoria es obligatorio")
                .Must(ExisteCategoria).WithMessage("No existe una categoria con ese id.");
                ;
            //validar talle
            RuleFor(x => x.IdTalle)
                .NotEmpty().WithMessage("El campo Talle es obligatorio")
                .Must(ExisteTalle).WithMessage("No existe un talle con ese id")
                ;
            //validar stock
            RuleFor(x => x.Stock)
                .NotEmpty().WithMessage("El campo Stock es obligatorio")
                .Must(x => x > 0).WithMessage("El campo Stock debe ser mayor a 0")
                ;
            //validar precio
            RuleFor(x => x.Precio)
                .NotEmpty().WithMessage("El campo Telefono es obligatorio")
                .Must(x => x > 0).WithMessage("El campo Precio debe ser mayor a 0")
                ;
            //validar imagen
            RuleFor(x => x.Imagen)
                .NotEmpty().WithMessage("El campo Imagen es obligatorio")
                .Must(x => x.Contains(".jpg") || x.Contains(".png") || x.Contains(".jpeg")).WithMessage("El campo Imagen debe ser un archivo .jpg, .png o .jpeg")
                ;
        }


        private bool ExisteNombre(string nombre){
            if(productoRepositorio!.BuscarProductoNombre(nombre) != null){
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ExisteCategoria(int id)
        {
            if(categoriaRepositorio!.BuscarCategoriaPorId(id) != null){
                return false;
            }
            else
            {
                return true;
            }
        }
        private bool ExisteTalle(int id){
            if(talleRepositorio!.BuscarTallePorId(id) != null){
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
