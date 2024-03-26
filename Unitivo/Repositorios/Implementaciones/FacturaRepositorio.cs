using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unitivo.Modelos;
using Unitivo.Recursos;
using Unitivo.Repositorios.Interfaces;
using Unitivo.Sessions;
using Unitivo.Validators;
using FluentValidation;


namespace Unitivo.Repositorios.Implementaciones
{
    public class FacturaRepositorio : FacturaInterface
    {
        private readonly UnitivoContext? _contexto;

        public FacturaRepositorio()
        {
            _contexto = Contexto.dbContexto;
        }

        public bool AgregarFactura(Factura x){
            try
            {
               

               
                
                // se agregan los demas campos obligatorios
                x.FechaCreacion = DateTime.Now;
                x.Estado = true;

                // Agrega el Factura al contexto de Entity Framework

                _contexto?.Facturas.Add(x);
                _contexto?.SaveChanges();

                // Retorna true si el Factura se agreg� con �xito
                return true;
            }
            catch (Exception ex)
            {
                // Retorna false si hubo un error durante la inserci�n
                MessageBox.Show(ex.Message, "Facturas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        public bool EliminarFactura(int id){
            Factura? Factura = _contexto?.Facturas.Find(id);
            if(Factura == null) return false;
            Factura.Estado = false;
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public bool ModificarFactura(Factura Factura){
            _contexto?.Facturas.Update(Factura);
            int resultado = _contexto?.SaveChanges() ?? 0;
            return resultado > 0;
        }

        public Factura buscarFactura(int id){
           return _contexto?.Facturas.Find(id)!;
        }
        
        public Factura BuscarFacturasPorDni(int id){
           return _contexto?.Facturas.Find(id)!;
        }
        
        public List<Factura> ListarFacturas(){
            return _contexto?.Facturas.ToList()!;
        }
    
        public List<Factura> ListarFacturasActivos(){
            return _contexto?.Facturas.Where(c => c.Estado == true).ToList()!;
        }
    }
}