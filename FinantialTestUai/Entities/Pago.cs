

namespace FinantialTestUai.Entities
{
    public class Pago
    {
        public Moneda TipoMoneda { get; set; }

        public decimal Monto { get; set; }

        public Tarjeta Tarjeta { get; set; }
        public Pago(decimal Montoapagar, Moneda moneda)
        {
            TipoMoneda = moneda;
            Monto = Montoapagar;
        }
        
    }
}
