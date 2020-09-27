using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialTestUai.Entities
{
    public class TipoTarjeta
    {
        public string nombretarjeta { get; set; }

        public string prefijo { get; set; }
        public decimal comision_pago_pesos { get; set; }

        public decimal comision_pago_dolares { get; set; }

        public override string ToString()
        {
            return nombretarjeta;
        }
    }
}
