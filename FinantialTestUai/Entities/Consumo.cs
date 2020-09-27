﻿using System;


namespace FinantialTestUai.Entities
{
    public class Consumo
    {
        public Consumo(decimal monto, Moneda tmoneda)
        {
            Monto = monto;
            TipoMoneda = tmoneda;
            Desripcion = "Consumo generado....";
            Fecha = DateTime.Now;
        }
        public Moneda TipoMoneda { get; set; }
        public string Desripcion { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        


    }
}
