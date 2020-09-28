using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FinantialTestUai.Entities
{
    public class EntidadFinanciera
    {
        
        //delegado y envento para advertir sobre exceso limite pesos
        public delegate void delAdvertir(string mensaje);
        public event delAdvertir Advertir_Pesos;
        //delegado y evento para advertir sobre exceso limite dolares
        public delegate void delAdvertirDolar(string mensaje);
        public event delAdvertirDolar Advertir_Dolares;

        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Tarjeta> Tarjetas { get; set; } = new List<Tarjeta>();
        public List<TipoTarjeta> TiposTarjetas { get; set; } = new List<TipoTarjeta>();
        public List<Pago> pagosTarjetas { get; set; } = new List<Pago>();

        public void AgregarCliente(Cliente cl)
        {
            try
            {
                if(!this.Clientes.Exists(x=>x.NroDocumento==cl.NroDocumento))
                {
                    Clientes.Add(new Cliente(cl.Nombre, cl.Apellido, cl.TipoDoc, cl.NroDocumento));
                }
                else
                {
                    MessageBox.Show("El dni ya existe");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           
        }

        public void AgregarTarjeta(TipoTarjeta tipotarjeta)
        {//metodo que ingresa las tarjetas a la entidad financiera
            try
            {
                if (tipotarjeta!=null)
                {
                    Tarjetas.Add(new Tarjeta(tipotarjeta));
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          
        }

        public List<Cliente> CargarClientes(int cantidad)
        {//metodo de carga random utilizo un cartesiano para poder tener nombres y apellidos
           
           
                string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás", "Walter" };
                string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
                string[] nombre2 = { "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
                string[] nrodoc = {"25187617","22992634","30455222","34885566","44852787","945852","1548832","512455"};
            var listaclientes = from n1 in nombre1
                    from n2 in nombre2
                    from a1 in apellido1
                    from doc1 in nrodoc
                    select new Cliente
                    {
                        Nombre = $"{n1}, {n2} ",
                        Apellido = $"{a1}",
                        TipoDoc = "DNI",
                        NroDocumento =$"{doc1}"
                    };
              
              

            return listaclientes.Take(7).ToList(); 
        }

        public void GenerarTiposTarjeta()
        {//Metodo para la carga de tipos de tarjeta de la entidad, aqui si se agregan nuevos tipos se puede agregar
            //como asi tambien el manejo de comisiones
            TiposTarjetas.Add(new TipoTarjeta()
            {
                prefijo = "9999", nombretarjeta = "Platinum", comision_pago_dolares = 1, comision_pago_pesos = 10, limite_pesos=15000, limite_dolares = 1500
            });
            TiposTarjetas.Add(new TipoTarjeta()
            {
                prefijo = "8888", nombretarjeta = "Gold", comision_pago_dolares = 2, comision_pago_pesos = 20 , limite_pesos=7500, limite_dolares = 500
            });
            TiposTarjetas.Add(new TipoTarjeta()
            {
                prefijo = "7777", nombretarjeta = "Plata", comision_pago_dolares = 3, comision_pago_pesos = 30, limite_pesos=2500, limite_dolares = 50
            });
        }

        public void AceptarConsumo(Consumo consumo, Tarjeta inTarjeta)
        {//Metodo para la aceptacion de un nuevo consumo evaluando el tipo de moneda
            foreach (var tarjeta in Tarjetas)
            {
                if (tarjeta.NroTarjeta == inTarjeta.NroTarjeta)
                {
                    if (consumo.TipoMoneda == Moneda.Pesos)
                    {
                        if (tarjeta.limite_pesos >= consumo.Monto)
                        {
                            tarjeta.limite_pesos -= consumo.Monto;
                            tarjeta.AgregaConsumo(consumo);
                            
                        }
                    }
                    else
                    {
                        if (tarjeta.limite_dolares >= consumo.Monto)
                        {
                            tarjeta.limite_dolares -= consumo.Monto;
                            tarjeta.AgregaConsumo(consumo);
                        }
                    }
                }
            }
        }

        public void AceptarPago(Pago pago, Tarjeta tar)
        {//metodo que evalua la aceptacion del pago
            foreach (var tarjeta in Tarjetas)
            {

                if (tarjeta.NroTarjeta == tar.NroTarjeta)
                {
                    if (pago.TipoMoneda == Moneda.Pesos)
                    {
                        if (tarjeta.Tipotarjeta.limite_pesos > tarjeta.limite_pesos)
                        {
                            tarjeta.AgregaPago(pago);
                        }
                    }
                    else
                    {
                        if (tarjeta.Tipotarjeta.limite_dolares > tarjeta.limite_dolares)
                        {
                            tarjeta.AgregaPago(pago);
                        }
                    }
                }
                    
            }
        }
        public void Verificar_Limite_Pesos(Tarjeta tarjeta,Consumo consumo)
        {//metodo para verificar y generar mensaje sobre el exceso en pesos
            if (Advertir_Pesos!=null && tarjeta.limite_pesos < consumo.Monto)
            {
                this.Advertir_Pesos($"Se esta excediendo, no se puede tomar el consumo , excedido en {consumo.Monto - tarjeta.limite_pesos}");

            }

        }

        public void Verificar_Limite_Dolares(Tarjeta tarjeta, Consumo consumo)
        {//metodo para verificar y generar mensaje sobre el exceso en dolares
            if (Advertir_Dolares != null && tarjeta.limite_dolares < consumo.Monto)
            {
                this.Advertir_Dolares($"Se esta excediendo, no se puede tomar el consumo , excedido en {consumo.Monto - tarjeta.limite_dolares}");

            }

        }
        private string GenerarDNI()
        {//metodo para generar DNI Random
            Random rnd = new Random();
            string nrorandom = "" ;

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    int numeroazar = rnd.Next(0, 9);
                    nrorandom = nrorandom  + numeroazar.ToString();
                }
            }
            

            return nrorandom;
        }

        public void EliminarTarjeta(Tarjeta tarjetain)
        {//Metodo para eliminar la tarjeta
            try
            {
                foreach (var tarjeta in Tarjetas)
                {
                    if (tarjeta.NroTarjeta == tarjetain.NroTarjeta && tarjeta.RetornarConsumos().Count==0 && tarjeta.Titular!=null)
                    {
                        MessageBox.Show($"Se Desvinculo la tarjeta {tarjeta.NroTarjeta} al titular: {tarjeta.Titular}");
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
