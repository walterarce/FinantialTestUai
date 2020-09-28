using System;
using System.Collections.Generic;
using System.Linq;


namespace FinantialTestUai.Entities
{
    public class Cliente 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDoc { get; set; }
        public string NroDocumento { get; set; }

        List<Tarjeta> ListaTarjetas;
        public Cliente(string nombre, string apellido, string tipo, string nro)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDoc = tipo;
            NroDocumento = nro;
            ListaTarjetas = new List<Tarjeta>();
            
        }

        public Cliente()
        {
            ListaTarjetas = new List<Tarjeta>();
        }
        public void AgregarTarjeta(Tarjeta tarjeta)
        {//Permite agregar una tarjeta a un cliente/titular seleccionado en la grilla 1 , valido que la misma ya no haya sido asignada a otro
            try
            {
                if (tarjeta.GetCliente() == null)
                {
                    ListaTarjetas.Add(new Tarjeta(tarjeta.NroTarjeta,tarjeta.Titular,tarjeta.FechaOtorgamiento,tarjeta.FechaVencimiento,tarjeta.Tipotarjeta));
                    ListaTarjetas.Last<Tarjeta>().SetTitular(this);
                    tarjeta.SetTitular(this);
                }
                else
                {
                    throw new Exception("Nro de tarjeta ya otorgado");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
      
        public List<Tarjeta> RetornarTarjeta()
        {//metodo que retorna las tarjetas del cliente
            List<Tarjeta> lstTar = new List<Tarjeta>();
           

            foreach (var tar in ListaTarjetas)
            {
                lstTar.Add(new Tarjeta(tar.NroTarjeta, tar.FechaOtorgamiento, tar.FechaVencimiento));
            }
            return lstTar;
        }
        
        public override string ToString()
        {
            return $"{Nombre} , {Apellido}";
        }
    }
}
