using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialTestUai.Entities
{
    public class EntidadFinanciera
    {
       
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Tarjeta> Tarjeta { get; set; } = new List<Tarjeta>();
        

        public void AgregarCliente(Cliente cl)
        {
            Clientes.Add(new Cliente(cl.Nombre,cl.Apellido,cl.TipoDoc,cl.NroDocumento));
        }
        public void AgregarTarjeta(string tipotarjeta)
        {
            Tarjeta.Add(new Tarjeta(tipotarjeta));
        }
    }
   
}
