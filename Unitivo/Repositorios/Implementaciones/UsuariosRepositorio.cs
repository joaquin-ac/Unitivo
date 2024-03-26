using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Validators;
using BCrypt.Net;
using Unitivo.Sessions;

namespace Unitivo.Repositorios.Implementaciones
{
    public class  UsuariosRepositorio : UsuarioInterface
    {
        private readonly UnitivoContext? _contexto;
        EmpleadoRepositorio empleadoRepositorio = new EmpleadoRepositorio();

        public UsuariosRepositorio(){
            _contexto = Contexto.dbContexto;
        }

        public void CargarEmpleados(){
            _contexto?.Empleados.Load();
            _contexto?.Perfiles.Load();
        }
        
        public bool AgregarUsuario(Usuario x)
        {
            try{
                var validator = new UsuarioValidator();
                var result = validator.Validate(x);

                if(!result.IsValid){
                    StringBuilder sb = new StringBuilder();
                    foreach(var failure in result.Errors)
                    {
                        sb.AppendLine($"{failure.PropertyName}: {failure.ErrorMessage}");
                    }
                    throw new ValidationException(sb.ToString());
                }

                //debo encriptar la contraseña
                string salt = BCrypt.Net.BCrypt.GenerateSalt();

                x.Password = BCrypt.Net.BCrypt.HashPassword(x.Password, salt);


                x.Estado = true;
                x.FechaCreacion = DateTime.Now;

                _contexto?.Usuarios.Add(x);
                _contexto?.SaveChanges();
                
                return true;
            }
            catch(Exception ex){
                string message = ex.Message;
                if (ex.InnerException != null)
                {
                    message += "\nInner Exception: " + ex.InnerException.Message;
                }
                MessageBox.Show(message, "Usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Usuario BuscarUsuarioPorId(int id)
        {
            return _contexto?.Usuarios.Find(id)!;
        }

        public List<Usuario> BuscarUsuario(object parametro){
            if(int.TryParse(parametro.ToString(), out int id))
            {
                List<Usuario> usuarios = _contexto?.Usuarios.Where(u => u.Id == id).ToList()!;
                return usuarios;
            }
            else if( parametro is string)
            {
                string cadena = (string)parametro;
                return _contexto?.Usuarios.Where(u => u.NombreUsuario!.Contains(cadena)).ToList()!;
            }
            else{
                return new List<Usuario>();
            }
        }
    
        public bool EliminarUsuario(int id)
        {
            Usuario? usuario = _contexto?.Usuarios.Find(id);
            if(usuario == null) return false;
            usuario.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public List<Usuario> ListarUsuarios()
        {
            return _contexto?.Usuarios.ToList()!;
        }

        public List<Usuario> ListarUsuariosActivos()
        {
            CargarEmpleados();
            return _contexto?.Usuarios.Where(u => u.Estado == true).ToList()!;
        }
        public bool ModificarUsuario(Usuario x)
        {
            try{
                var validator = new UsuarioValidator();
                var result = validator.Validate(x);
                if(!result.IsValid){
                    StringBuilder sb = new StringBuilder();
                    foreach(var failure in result.Errors){
                        sb.AppendLine($"{failure.PropertyName}: {failure.ErrorMessage}");
                    }
                    throw new ValidationException(sb.ToString());
                }

                if(BuscarUsuarioPorId(x.Id).NombreUsuario != x.NombreUsuario){
                    MessageBox.Show("No se puede modificar el nombre de usuario");
                    return false;
                }

                string salt = BCrypt.Net.BCrypt.GenerateSalt();

                x.Password = BCrypt.Net.BCrypt.HashPassword(x.Password, salt);
                
                _contexto?.Usuarios.Update(x);
                int resultado = _contexto?.SaveChanges() ?? 0;
                return resultado > 0;
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Usuario LoggUser(string usuario, string password){
            try{    
                Usuario? user = _contexto?.Usuarios.Where(u => u.NombreUsuario == usuario).FirstOrDefault();
                if(user == null){
                    MessageBox.Show("Usuario no encontrado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null!;
                }else{
                    if(BCrypt.Net.BCrypt.Verify(password, user.Password)){
                        if(user.Estado == false){
                            MessageBox.Show("Usuario desactivado", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return null!;
                        }else{
                            Session.usuario = user;
                            return user!;
                        }
                    }else{
                        MessageBox.Show("Contraseña incorrecta", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null!;
                    }
                }
            }catch(Exception ex){
                MessageBox.Show(ex.Message, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null!;
            }
        }
    }         
}
