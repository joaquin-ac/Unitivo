using FluentValidation;
using System.Text;
using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Validators;
namespace Unitivo.Repositorios.Implementaciones
{
    public class EmpleadoRepositorio : EmpleadoInterface
    {
        private readonly UnitivoContext? _contexto;

        public EmpleadoRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }

        public bool AgregarEmpleado(Empleado x)
        {
            //          try
            //        {
            //se valida el modelo
            var validator = new EmpleadoValidator();
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

            // se valida que no exista un empleado con el mismo dni
            if (BuscarEmpleadosPorDni(x.Dni) != null)
            {
                MessageBox.Show("El DNI ya est� asociado a un empleado.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Retorna false si ya existe un empleado con el mismo DNI
            }
            //   Validar que el correo sea �nico

            if (BuscarEmpleadosPorMail(x.Correo) != null)
            {
                MessageBox.Show("El correo ya est� asociado a un empleado.", "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false; // Retorna false si ya existe un empleado con el mismo correo
            }

            // se agregan los demas campos obligatorios
            x.FechaCreacion = DateTime.Now;
            x.Estado = true;

            // Agrega el empleado al contexto de Entity Framework

            _contexto?.Empleados.Add(x);
            _contexto?.SaveChanges();

            // Retorna true si el empleado se agreg� con �xito
            return true;
            //           }
            //         catch (Exception ex)
            //       {
            // Retorna false si hubo un error durante la inserci�n
            //        MessageBox.Show(ex.Message, "Empleados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //          return false;
            //        }

        }

        public bool EliminarEmpleado(int id)
        {
            Empleado? empleado = _contexto?.Empleados.Find(id);
            if (empleado == null) return false;
            empleado.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public bool ModificarEmpleado(Empleado empleado)
        {
            _contexto?.Empleados.Update(empleado);
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public Empleado buscarEmpleado(int id)
        {
            return _contexto?.Empleados.Find(id)!;
        }

        public Empleado BuscarEmpleadosPorDni(int id)
        {
            return _contexto?.Empleados.Find(id)!;
        }

        public Empleado BuscarEmpleadosPorMail(string correo)
        {
            return _contexto?.Empleados.FirstOrDefault(c => c.Correo == correo)!;
        }

        public List<Empleado> ListarEmpleados()
        {
            return _contexto?.Empleados.ToList()!;
        }

        public List<Empleado> ListarEmpleadosActivos()
        {
            return _contexto?.Empleados.Where(c => c.Estado == true).ToList()!;
        }
    }
}