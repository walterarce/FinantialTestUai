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
        public void Inicializar(Cliente cliente)
        {
            agregar_cliente(cliente);
        }

        private void agregar_cliente(Cliente cl)
        {

            Clientes.Add(new Cliente(){Apellido =cl.Nombre, Nombre = cl.Apellido});
        }
    }
   
}
