using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialTestUai.Entities
{
    public class Tarjeta
    {
         List<Consumo> ListaConsumos;
        public Tarjeta(TipoTarjeta TTarjeta)
        {
            Tipotarjeta = TTarjeta;
            nrotarjeta = TTarjeta.prefijo + GeneraNroTarjeta();
            FechaOtorgamiento = DateTime.Now;
            FechaVencimiento = ObtenerFecha(720, DateTime.Now, DateTime.Now.AddDays(2500));
            limite_pesos = 1000;
            limite_dolares = 1000;
            ListaConsumos = new List<Consumo>();
        }


      
        public Tarjeta(string nrot, Cliente titular, DateTime fechaotorgamiento, DateTime fechavencimiento, TipoTarjeta TTarjeta)
        {
            nrotarjeta = nrot;
            Titular = titular;
            FechaOtorgamiento = fechaotorgamiento;
            FechaVencimiento = fechavencimiento;
            Tipotarjeta = TTarjeta;
            ListaConsumos = new List<Consumo>();
        }

        private DateTime ObtenerFecha(int numDates, DateTime dateInit, DateTime dateEnd)
        {
            Random seed = new Random(DateTime.Now.Millisecond);
            DateTime lst = new DateTime();
            TimeSpan interval = dateEnd.Subtract(dateInit);
            int randomMax = (int) interval.TotalDays;
            long randomValue = seed.Next(0, randomMax);
            lst = dateInit.AddDays(randomValue);

            return lst;
        }

        private TipoTarjeta tipotarjeta;

        public TipoTarjeta Tipotarjeta
        {
            get { return tipotarjeta; }
            set { tipotarjeta = value; }
        }

        private string nrotarjeta;

        public string NroTarjeta
        {
            get { return nrotarjeta; }
            set { nrotarjeta = value; }
        }

        public Cliente GetCliente()
        {
            return Titular;
        }

        public Cliente Titular { get; set; }

        public void SetTitular(Cliente cliente)
        {
            Titular = cliente;
        }



        public DateTime FechaOtorgamiento { get; set; }

        public DateTime FechaVencimiento { get; set; }

        public void AgregaConsumo(Consumo consumo)
        {
            try
            {
                ListaConsumos.Add(new Consumo(consumo.Monto, consumo.TipoMoneda));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private decimal saldo_pesos { get; set; }

        private decimal saldo_dolares { get; set; }

        public void AgregaPago(Pago pago)
        {
            if (pago.TipoMoneda == Moneda.Pesos)
            {
                saldo_pesos -= (pago.Monto - (this.tipotarjeta.comision_pago_pesos*pago.Monto));
                limite_pesos += pago.Monto;
            }
            else
            {
                saldo_dolares -= (pago.Monto - (this.tipotarjeta.comision_pago_dolares * pago.Monto));
                limite_dolares += pago.Monto;
            }

        }
        public List<Consumo> RetornarConsumos()
        {
            List<Consumo> listaConsumos = new List<Consumo>();


            foreach (var consumo in ListaConsumos)
            {
                listaConsumos.Add(new Consumo(consumo.Monto, consumo.TipoMoneda));
            }
            return listaConsumos;
        }

        private string GeneraNroTarjeta()
        {
            Random rnd = new Random();
            string nrorandom = "";
            for (int i = 0; i < 12; i++)
            {
                int numeroazar = rnd.Next(0, 9);
                nrorandom = nrorandom + numeroazar.ToString();
            }

            return nrorandom;
        }

        public decimal limite_pesos { get; set; }
        public decimal limite_dolares { get; set; }



        public override string ToString()
        {
            return tipotarjeta.ToString();
        }
    }
}
