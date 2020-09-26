using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinantialTestUai.Entities
{
    public class Cliente 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDoc { get; set; }
        public int NroDocumento { get; set; }

        List<Tarjeta> ListaTarjetas;
        public Cliente(string nombre, string apellido, string tipo, int nro)
        {
            Nombre = nombre;
            Apellido = apellido;
            tipo = TipoDoc;
            NroDocumento = nro;
            ListaTarjetas = new List<Tarjeta>();
            
        }

        public Cliente()
        {
            ListaTarjetas = new List<Tarjeta>();
        }
        public void AgregarTarjeta(Tarjeta tarjeta)
        {
            try
            {
                if (tarjeta.GetCliente() == null)
                {
                    ListaTarjetas.Add(new Tarjeta(tarjeta.NroTarjeta,tarjeta.Titular,tarjeta.FechaOtorgamiento,tarjeta.FechaVencimiento));
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
        public void DesvinculoTarjeta(Cliente cliente, Tarjeta tarjeta)
        {
            try
            {
                if (tarjeta.GetCliente() == cliente)
                {
                    tarjeta.SetTitular(null);
                }
            }
            catch (Exception)
            {

            }
        }
        public List<Tarjeta> RetornarTarjeta()
        {
            List<Tarjeta> lstTar = new List<Tarjeta>();
           

            foreach (var tar in ListaTarjetas)
            {
                lstTar.Add(new Tarjeta(tar.NroTarjeta, tar.Titular, tar.FechaOtorgamiento, tar.FechaVencimiento));
            }
            return lstTar;
        }

        public override string ToString()
        {
            return $"{Nombre} , {Apellido}";
        }
    }
}
