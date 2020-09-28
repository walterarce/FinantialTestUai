using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace FinantialTestUai.Entities
{
    public class Tarjeta
    {
        

      
        List<Consumo> ListaConsumos;
        public Tarjeta(TipoTarjeta TTarjeta)
        {
            try
            {
                    Tipotarjeta = TTarjeta;
                    nrotarjeta = TTarjeta.prefijo + GeneraNroTarjeta();
                    FechaOtorgamiento = DateTime.Now;
                    FechaVencimiento = ObtenerFecha(720, DateTime.Now, DateTime.Now.AddDays(2500));
                    limite_dolares = TTarjeta.limite_dolares;
                    limite_pesos = TTarjeta.limite_pesos;
                    ListaConsumos = new List<Consumo>();
               
                
            }
            catch (Exception ex)
            {
                throw;

            }
          
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


        public Tarjeta(string nrot, DateTime fechaotorgamiento, DateTime fechavencimiento)
        {
            nrotarjeta = nrot;
            FechaOtorgamiento = fechaotorgamiento;
            FechaVencimiento = fechavencimiento;
            ListaConsumos = new List<Consumo>();
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
        {//metodo que agrega el consumo aceptado
            try
            {
                ListaConsumos.Add(new Consumo(consumo.Monto, consumo.TipoMoneda));
                if (consumo.TipoMoneda == Moneda.Pesos)
                {
                    saldo_pesos += saldo_pesos + consumo.Monto;
                }
                else
                {
                    saldo_dolares += saldo_dolares + consumo.Monto;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public decimal saldo_pesos { get; set; }
        public decimal saldo_dolares { get; set; }
        public decimal limite_pesos { get; set; }
        public decimal limite_dolares { get; set; }

        public void AgregaPago(Pago pago)
        {//metodo que agrega el pago
            if (pago.TipoMoneda == Moneda.Pesos)
            {
                var porcentaje = (this.tipotarjeta.comision_pago_pesos* pago.Monto)/100;
                saldo_pesos -= (pago.Monto - porcentaje);
                if((limite_pesos + (pago.Monto - porcentaje)> this.Tipotarjeta.limite_pesos))
                {
                    limite_pesos = this.Tipotarjeta.limite_pesos;
                }
                else
                {
                    limite_pesos += (pago.Monto - porcentaje);
                }
              
            }
            else
            {
                var porcentaje = (this.tipotarjeta.comision_pago_dolares * pago.Monto)/100;
                saldo_dolares -= (pago.Monto - porcentaje);
                if ((limite_dolares + (pago.Monto - porcentaje) > this.Tipotarjeta.limite_dolares))
                {
                    limite_dolares = this.Tipotarjeta.limite_dolares;
                }
                else
                {
                    limite_dolares += (pago.Monto - porcentaje);
                }
                
            }

        }
        public List<Consumo> RetornarConsumos()
        {//metodo que devuelve la lista de consumos dado que los voy incorporando en una lista simil resumen de movimientos de la tarjeta
            List<Consumo> listaConsumos = new List<Consumo>();


            foreach (var consumo in ListaConsumos)
            {
                listaConsumos.Add(new Consumo(consumo.Monto, consumo.TipoMoneda));
            }
            return listaConsumos;
        }

        private string GeneraNroTarjeta()
        {//este metodo es el que me genera random los 12 digitos restantes de una tarjeta, aseguro tener pocas probabilidades que se repitan en 
            //la carga 
            Random rnd = new Random();
            string nrorandom = "";
            for (int i = 0; i < 12; i++)
            {
                int numeroazar = rnd.Next(0, 9);
                nrorandom = nrorandom + numeroazar.ToString();
            }

            return nrorandom;
        }

        private DateTime ObtenerFecha(int numDates, DateTime dateInit, DateTime dateEnd)
        {//metodo que me permite obtener diferentes fechas aleatorias
            Random seed = new Random(DateTime.Now.Millisecond);
            DateTime lst = new DateTime();
            TimeSpan interval = dateEnd.Subtract(dateInit);
            int randomMax = (int)interval.TotalDays;
            long randomValue = seed.Next(0, randomMax);
            lst = dateInit.AddDays(randomValue);

            return lst;
        }

        public override string ToString()
        {
            return tipotarjeta.ToString();
        }
    }
}
