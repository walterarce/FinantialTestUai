using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialTestUai.Entities
{
    public class Tarjeta
    {
        
        public Tarjeta(string nrotipotarjeta)
        {
            nrotarjeta = nrotipotarjeta + GeneraNroTarjeta();
            FechaOtorgamiento=DateTime.Now;
            FechaVencimiento = getDates(720,DateTime.Now, DateTime.Now.AddDays(2500));
            Limite = new Limite() { TipoMoneda = 0, Monto = 1000f };
        }

        public Tarjeta()
        {
            
        }

        public Tarjeta(string nrot, Cliente titular, DateTime fechaotorgamiento, DateTime fechavencimiento )
        {
            nrotarjeta = nrot;
            Titular = titular;
            FechaOtorgamiento = fechaotorgamiento;
            FechaVencimiento = fechavencimiento;
        }
        private DateTime getDates(int numDates, DateTime dateInit, DateTime dateEnd)
                     {
                         Random seed = new Random(DateTime.Now.Millisecond);
            DateTime lst = new DateTime();
                     
                               // Obtenemos el intervalo de tiempo
                               TimeSpan interval = dateEnd.Subtract(dateInit);
                                // Se calcula el número de días
                                 int randomMax = (int)interval.TotalDays;
                               // Se obtiene un número aleatorio
                               long randomValue = seed.Next(0, randomMax);
                            // Se le añade a la fecha inicial
                            lst= dateInit.AddDays(randomValue);
                       
                    return lst;
                    }
        private TipoTarjeta tipotarjeta { get; set; }

        public string nrotarjeta;

        public string NroTarjeta
        {
            get { return nrotarjeta; }
            set { nrotarjeta = value; }
        }

        public Cliente GetCliente() { return Titular; }
        public Cliente Titular { get; set; }

        public void SetTitular(Cliente cliente)
        {
            Titular = cliente;
        }
        public DateTime FechaOtorgamiento { get; set; }

        public DateTime FechaVencimiento { get; set; }


        public List<Consumo> ListaMovimientos { get; set; }

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

         public Limite Limite
         {
             get => default;
             set
             {
                
             }
         }

         public Pago Pago
         {
             get => default;
             set
             {
             }
         }

         public List<Consumo> listaConsumo
         {
             get => default;
             set
             {
             }
         }
    }
}
