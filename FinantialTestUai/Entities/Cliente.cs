using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinantialTestUai.Entities
{
    public class Cliente 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDoc { get; set; }
        public int NroDocumento { get; set; }

       

        public List<Tarjeta> ListaTarjetas { get; set; } = new List<Tarjeta>();

        public void AgregarTarjeta(Tarjeta tarjeta)
        {
            try
            {
                if (tarjeta.GetCliente() == null)
                {
                    //ListaTarjetas.Add();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public List<Tarjeta> OwnListCard()
        {
            List<Tarjeta> listaTarjetas = new List<Tarjeta>();
            foreach (var tarjeta in ListaTarjetas)
            {
                listaTarjetas.Add(new Tarjeta(){NroTarjeta = tarjeta.NroTarjeta, Titular = tarjeta.Titular,FechaOtorgamiento = tarjeta.FechaOtorgamiento, FechaVencimiento = tarjeta.FechaVencimiento});//tengo que arreglarlo porque el tipo solamente no me sirve para esta forma de retorno
            }

            return listaTarjetas;
        }

        public override string ToString()
        {
            return $"{Nombre} , {Apellido}";
        }
    }
}
