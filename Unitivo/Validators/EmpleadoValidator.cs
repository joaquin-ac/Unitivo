using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Unitivo.Modelos;

namespace Unitivo.Validators
{
    public class EmpleadoValidator : AbstractValidator<Empleado>
    {
        public EmpleadoValidator()
        {
            //validar dni 
            RuleFor(x => x.Dni)
                .NotEmpty().WithMessage("El campo Dni es obligatorio")
                .InclusiveBetween(999999, 99999999).WithMessage("El campo Dni debe tener 8 caracteres")
                ;
            //validar nombre
            RuleFor(x => x.Nombre)
                .NotEmpty().WithMessage("El campo Nombre es obligatorio")
                .Length(3, 50).WithMessage("El campo Nombre debe tener entre 3 y 50 caracteres")
                ;
            //validar apellido
            RuleFor(x => x.Apellido)
                .NotEmpty().WithMessage("El campo Apellido es obligatorio")
                .Length(3, 50).WithMessage("El campo Apellido debe tener entre 3 y 50 caracteres")
                ;
            //validar email
            RuleFor(x => x.Correo)
                .NotEmpty().WithMessage("El campo Email es obligatorio")
                .EmailAddress().WithMessage("El campo Email no es valido")
                ;
            //validar telefono
            RuleFor(x => x.Telefono)
                .NotEmpty().WithMessage("El campo Telefono es obligatorio")
                .Length(10, 10).WithMessage("El campo Telefono debe tener 10 caracteres")
                ;
            //validar direccion
            RuleFor(x => x.Direccion)
                .NotEmpty().WithMessage("El campo Direccion es obligatorio")
                .Length(3, 50).WithMessage("El campo Direccion debe tener entre 3 y 50 caracteres")
                ;
            //rule para valdidar la edad, es un campo date
            RuleFor(x => x.Edad)
                .NotEmpty().WithMessage("El campo Edad es obligatorio")
                .Must(x => (DateTime.Now - x).TotalDays / 365 <= 60).WithMessage("El Empleado debe ser menor a 60 años")
                .Must(x => (DateTime.Now - x).TotalDays / 365 >= 18).WithMessage("El Empleado debe ser mayor de edad")
                ;
        }
    }
}
