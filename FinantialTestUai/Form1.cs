using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FinantialTestUai.Entities;

namespace FinantialTestUai
{
    
    public partial class Form1 : Form
    {
        //Instancio el objeto que contiene clientes y tarjetas Entidad Financiera
        EntidadFinanciera entidadFinanciera = new EntidadFinanciera();
     
        public Form1()
        {
            InitializeComponent();
       

        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            //por cada click agrego un nuevo cliente.
            var cliente = new Cliente( txtNombre.Text,  txtApellido.Text,cboTipoDoc.SelectedItem.ToString(), Int32.Parse(NroDocumento.Text) );
           
            entidadFinanciera.AgregarCliente(cliente);
            grillaClientes.DataSource = null;
            grillaClientes.DataSource = entidadFinanciera.Clientes;

        }

        private void btnGenerarNro_Click(object sender, EventArgs e)
        {
            try
            {
                entidadFinanciera.AgregarTarjeta((TipoTarjeta)cboTipoTarjeta.SelectedItem);
                grillaTarjetas.DataSource = null;
                grillaTarjetas.DataSource = entidadFinanciera.Tarjetas;
            }
            catch (Exception )
            {
               
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
           entidadFinanciera.GenerarTiposTarjeta();

           foreach (var tipotarjeta in entidadFinanciera.TiposTarjetas)
           {
               cboTipoTarjeta.Items.Add(tipotarjeta);
           }

           cboTipoDoc.Items.Add(TipoDocumento.DNI);
            cboTipoDoc.Items.Add(TipoDocumento.LE);
            cboTipoDoc.Items.Add(TipoDocumento.PASAPORTE);
            grillaTarjetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaTarjetas.MultiSelect = false;
            grillaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaClientes.MultiSelect = false;
            grillaTarjetasCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaTarjetasCliente.MultiSelect = false;
            grillaClientes.DataSource = null;
          
            
            grillaTarjetas.DataSource = null;
          
        }

        
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = (Cliente) (grillaClientes.SelectedRows[0].DataBoundItem);
                Tarjeta tar = (Tarjeta) (grillaTarjetas.SelectedRows[0].DataBoundItem);
                cli.AgregarTarjeta(tar);

                grillaTarjetasCliente.DataSource = null;
                grillaTarjetasCliente.DataSource = cli.RetornarTarjeta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void grillaClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            { 
                List<Tarjeta> lisTarjeta = entidadFinanciera.Tarjetas.FindAll(x => x.Titular == ((Cliente) grillaClientes.SelectedRows[0].DataBoundItem)).ToList();
                
                grillaTarjetasCliente.DataSource = null;
                grillaTarjetasCliente.DataSource = lisTarjeta;
                
            }
            catch (Exception )
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (entidadFinanciera.Clientes!=null)
            {
               entidadFinanciera.Clientes.AddRange( entidadFinanciera.CargarClientes());
            }
            else
            {
                entidadFinanciera.Clientes = entidadFinanciera.CargarClientes();
            }
            
          
            grillaClientes.DataSource = null;
            grillaClientes.DataSource = entidadFinanciera.Clientes;
        }

        private void actualiza_grilla_consumos()
        {
            try
            {
                Tarjeta tarjetaseleccionada = ((Tarjeta)grillaTarjetasCliente.SelectedRows[0].DataBoundItem);
                List<Tarjeta> lisTarjeta = entidadFinanciera.Tarjetas.FindAll(x => x.Titular == ((Cliente)grillaClientes.SelectedRows[0].DataBoundItem)).ToList();
                List<Consumo> consumos = new List<Consumo>();
                foreach (var tarjeta in lisTarjeta)
                {
                    if (tarjeta.Titular == ((Cliente)grillaClientes.SelectedRows[0].DataBoundItem) && tarjeta.NroTarjeta == tarjetaseleccionada.NroTarjeta)
                        consumos = tarjeta.RetornarConsumos();
                }
                grillaMovimientos.DataSource = null;
                grillaMovimientos.DataSource = consumos;
            }
            catch (Exception )
            {
               
            }
            
        }
        private void btnConsumoPesos_Click(object sender, EventArgs e)
        {
            try
            {
               
                Tarjeta tar = (Tarjeta)(grillaTarjetasCliente.SelectedRows[0].DataBoundItem);
                Consumo monto = new Consumo(decimal.Parse(txtMontoConsumo.Text), Moneda.Pesos);
               entidadFinanciera.AceptarConsumo(monto,tar);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = (Cliente)(grillaClientes.SelectedRows[0].DataBoundItem);
                Tarjeta tar = (Tarjeta)(grillaTarjetas.SelectedRows[0].DataBoundItem);

                foreach (var tarjeta in cli.RetornarTarjeta())
                {
                    if (tarjeta.NroTarjeta == tar.NroTarjeta)
                    {
                        entidadFinanciera.EliminarTarjeta(tar);
                    }
                }

                grillaTarjetasCliente.DataSource = null;
                grillaTarjetasCliente.DataSource = cli.RetornarTarjeta();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnConsumoDolar_Click(object sender, EventArgs e)
        {
            try
            {

                Tarjeta tar = (Tarjeta)(grillaTarjetasCliente.SelectedRows[0].DataBoundItem);
                Consumo monto = new Consumo(decimal.Parse(txtMontoConsumo.Text), Moneda.Dolares);
                entidadFinanciera.AceptarConsumo(monto, tar);
          

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grillaTarjetasCliente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            actualiza_grilla_consumos();
        }

        private void grillaTarjetasCliente_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            grillaMovimientos.DataSource = null;
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            Tarjeta tar = (Tarjeta)(grillaTarjetasCliente.SelectedRows[0].DataBoundItem);
            Pago pago = new Pago(decimal.Parse(txtMontoPago.Text), Moneda.Pesos);
            entidadFinanciera.AceptarPago(pago,tar);
        }

        private void btnPagoDolares_Click(object sender, EventArgs e)
        {
            Tarjeta tar = (Tarjeta)(grillaTarjetasCliente.SelectedRows[0].DataBoundItem);
            Pago pago = new Pago(decimal.Parse(txtMontoPago.Text), Moneda.Pesos);
            entidadFinanciera.AceptarPago(pago,tar);
        }
    }
}
