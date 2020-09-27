using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinantialTestUai.Entities
{
    public class EntidadFinanciera
    {
       
        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Tarjeta> Tarjetas { get; set; } = new List<Tarjeta>();
        public List<TipoTarjeta> TiposTarjetas { get; set; } = new List<TipoTarjeta>();
        public List<Pago> pagosTarjetas { get; set; } = new List<Pago>();
        public void AgregarCliente(Cliente cl)
        {
            Clientes.Add(new Cliente(cl.Nombre,cl.Apellido,cl.TipoDoc,cl.NroDocumento));
        }
        public void AgregarTarjeta(TipoTarjeta tipotarjeta)
        {
            Tarjetas.Add(new Tarjeta(tipotarjeta));
        }
        public List<Cliente> CargarClientes()
        {


            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás", "Walter" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaclientes = from n1 in nombre1
                from n2 in nombre2
                from a1 in apellido1
                select new Cliente { Nombre = $"{n1}, {n2} ", Apellido = $"{a1}", TipoDoc = "DNI", NroDocumento = int.Parse(GenerarDNI()) };


            return listaclientes.Take(5).ToList();
        }

        public void GenerarTiposTarjeta()
        {
            TiposTarjetas.Add(new TipoTarjeta(){prefijo = "9999", nombretarjeta = "Platinum", comision_pago_dolares = 1, comision_pago_pesos = 10});
            TiposTarjetas.Add(new TipoTarjeta() { prefijo = "8888", nombretarjeta = "Gold", comision_pago_dolares = 2, comision_pago_pesos = 20 });
            TiposTarjetas.Add(new TipoTarjeta() { prefijo = "7777", nombretarjeta = "Plata", comision_pago_dolares = 3, comision_pago_pesos = 30 });
        }

        public void AceptarConsumo(Consumo consumo, Tarjeta inTarjeta)
        {
            foreach (var tarjeta in Tarjetas)
            {
                if (Tarjetas.Exists(x => x.NroTarjeta== inTarjeta.NroTarjeta))
                {
                    tarjeta.AgregaConsumo(consumo);
                }
            }
        }

        public void AceptarPago(Pago pago, Tarjeta tar)
        {
            foreach (var tarjeta in Tarjetas)
            {
                if(tarjeta.NroTarjeta==tar.NroTarjeta)
                    tarjeta.AgregaPago(pago);
            }
        }
        private string GenerarDNI()
        {
            Random rnd = new Random();
            string nrorandom = "";
            for (int i = 0; i < 8; i++)
            {
                int numeroazar = rnd.Next(0, 9);
                nrorandom = nrorandom + numeroazar.ToString();
            }

            return nrorandom;
        }
        public void EliminarTarjeta(Tarjeta tarjetain)
        {

            try
            {
                foreach (var tarjeta in Tarjetas)
                {
                    if (tarjeta.NroTarjeta == tarjetain.NroTarjeta)
                    {
                        tarjeta.Titular = null;
                    }
                    
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
   
}
