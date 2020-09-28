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
            try
            {
                if (txtNombre.Text != "" && txtApellido.Text !="" && cboTipoDoc.SelectedItem !=null && NroDocumento.Text!="")
                {
                var cliente = new Cliente(txtNombre.Text, txtApellido.Text, cboTipoDoc.SelectedItem.ToString(), 
                    NroDocumento.Text);

                entidadFinanciera.AgregarCliente(cliente);
                }
                else
                {
                    MessageBox.Show($"Por favor verificar que completo los campos {txtNombre.Name}  {txtApellido.Name} , El Tipo de Documento deberia seleccionarse, {NroDocumento.Name}");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"El error fue {exception.Message} {exception.Source}");
            }
            
            grillaClientes.DataSource = null;
            grillaClientes.DataSource = entidadFinanciera.Clientes;

        }

        private void btnGenerarNro_Click(object sender, EventArgs e)
        {//metodo que genera las tarjetas de credito para la entidad dependiendo del tipo seleccionado en el combo de tipo tarjeta
            try
            {
                if (cboTipoTarjeta.SelectedItem!=null)
                {
                    entidadFinanciera.AgregarTarjeta((TipoTarjeta)cboTipoTarjeta.SelectedItem);
                    grillaTarjetas.DataSource = null;
                    grillaTarjetas.DataSource = entidadFinanciera.Tarjetas;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($" Se intento pero el error fue:{ex.Message} lo mas probable que no haya nada seleccionado en el combo de TipoTarjeta");
            }
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {  
           /* La entidad financiera debe contener los tipos de tarjeta los cuales poseen los porcentajes a calcular
            se inicializan en el load, se deja opcion para el usuario de generar datos aleatorio por medio del boton 
           Precarga de Clientes, o ingreso individual de clientes, los cuales seran tratados luego como titulares de la/s tarjeta que
           se asigen a los mismos. Tambien aunque se realice la precarga, la carga manual es valida en ambos casos.
           Las tarjetas de credito tambien se deben generar antes de la asignacion de un cliente a las mismas, lo cual se deja precargado el
           combo que permite seleccionar el tipo de tarjeta.
            */
            entidadFinanciera.GenerarTiposTarjeta();

            //se agregan los tipos de tarjeta para el alta de las mismas
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
            //Permito agregar una tarjeta a un cliente seleccionado en la grilla 1
            try
            {
                Cliente cli = (Cliente) (grillaClientes.SelectedRows[0].DataBoundItem);
                Tarjeta tar = (Tarjeta) (grillaTarjetas.SelectedRows[0].DataBoundItem);
                cli.AgregarTarjeta(tar);

                actualiza_grilla_tarjetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void grillaClientes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {//en este metodo genero la grilla 3 con el cliente que tengo seleccionado en la grilla1
            try
            {
                grillaTarjetasCliente.DataSource = null;
                grillaTarjetasCliente.DataSource = entidadFinanciera.Tarjetas.FindAll(x => x.Titular == 
                             ((Cliente)grillaClientes.SelectedRows[0].DataBoundItem)).ToList();

            }
            catch (Exception )
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {//realizo la carga masiva de clientes/titulares para la entidad financiera
            if (entidadFinanciera.Clientes!=null)
            {
               entidadFinanciera.Clientes.AddRange( entidadFinanciera.CargarClientes(5));
            }
            else
            {
                entidadFinanciera.Clientes = entidadFinanciera.CargarClientes(5);
            }
            
          
            grillaClientes.DataSource = null;
            grillaClientes.DataSource = entidadFinanciera.Clientes;
        }

        private void actualiza_grilla_tarjetas()
        {
            Cliente cli = (Cliente)(grillaClientes.SelectedRows[0].DataBoundItem);
           
            grillaTarjetasCliente.DataSource = null;
            grillaTarjetasCliente.DataSource = entidadFinanciera.Tarjetas.Find(x => x.Titular==cli);
        }
        private void actualiza_grilla_consumos()
        {//genero un metodo que me actualiza la grilla 4 de consumos, si bien esta por fuera de lo solicitado me sirvio visualmente.
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
                actualiza_grilla_tarjetas();
            }
            catch (Exception )
            {
               
            }
            
        }
        private void btnConsumoPesos_Click(object sender, EventArgs e)
        {

            //metodo que dispara la aceptacion de consumo en pesos de la entidad financiera y termina en la invocacion de agregar consumo de tarjeta
            try
            {

                Tarjeta tar = (Tarjeta)(grillaTarjetasCliente.SelectedRows[0].DataBoundItem);
                Consumo monto = new Consumo(decimal.Parse(txtMontoConsumo.Text), Moneda.Pesos);
                entidadFinanciera.Advertir_Pesos += ExcesoLimite_Advertir;

                entidadFinanciera.Verificar_Limite_Pesos(tar, monto);
                entidadFinanciera.AceptarConsumo(monto, tar);
                txtMontoConsumo.Text = "";
                actualiza_grilla_tarjetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Debe seleccionar un cliente en la grilla de cliente: {ex.Message} o ingresar un valor de monto de consumo");
            }

        }

  
        private void btnConsumoDolar_Click(object sender, EventArgs e)
        {//metodo que dispara la aceptacion de consumo en dolares de la entidad financiera y termina en la invocacion de agregar consumo de tarjeta
            try
            {

                Tarjeta tar = (Tarjeta)(grillaTarjetasCliente.SelectedRows[0].DataBoundItem);
                Consumo monto = new Consumo(decimal.Parse(txtMontoConsumo.Text), Moneda.Dolares);
                entidadFinanciera.Advertir_Dolares += ExcesoLimite_Advertir;
                entidadFinanciera.Verificar_Limite_Dolares(tar, monto);
                entidadFinanciera.AceptarConsumo(monto, tar);
                txtMontoConsumo.Text = "";
                actualiza_grilla_tarjetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Debe seleccionar un cliente en la grilla de cliente: {ex.Message} o ingresar un valor de monto de consumo");
            }
        }
        private void ExcesoLimite_Advertir(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
        private void button2_Click(object sender, EventArgs e)
        {//metodo para desvincular la tarjeta
            try
            {
                Cliente cli = (Cliente)(grillaClientes.SelectedRows[0].DataBoundItem);
                Tarjeta tar = (Tarjeta)(grillaTarjetasCliente.SelectedRows[0].DataBoundItem);
                foreach (var tarjeta in entidadFinanciera.Tarjetas)
                {
                    if (tarjeta.NroTarjeta== tar.NroTarjeta)
                    {
                        entidadFinanciera.EliminarTarjeta(tarjeta);
                    }
                }

                grillaTarjetasCliente.DataSource = null;
                grillaTarjetasCliente.DataSource = cli.RetornarTarjeta();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Debe seleccionar un cliente en la grilla de cliente: {ex.Message} esto le mostrara las tarjetas en la grilla 3");

            }
        }


        private void grillaTarjetasCliente_RowEnter(object sender, DataGridViewCellEventArgs e)
        {//cuando toco una tarjeta en la grilla 3 actualizo los consumos en la grilla 4
            actualiza_grilla_consumos();
        }

        private void grillaTarjetasCliente_RowLeave(object sender, DataGridViewCellEventArgs e)
        {//cuando salgo de la grilla 3 limpio lo que veo en la grilla 4
            grillaMovimientos.DataSource = null;
        }

        private void btnPago_Click(object sender, EventArgs e)
        {//metodo que dispara la aceptacion del pago en pesos 
            try
            {
                Tarjeta tar = (Tarjeta)(grillaTarjetasCliente.SelectedRows[0].DataBoundItem);
                Pago pago = new Pago(decimal.Parse(txtMontoPago.Text), Moneda.Pesos);
                entidadFinanciera.AceptarPago(pago, tar);
                actualiza_grilla_tarjetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
      
        }

        private void btnPagoDolares_Click(object sender, EventArgs e)
        {//metodo que dispara el pago en dolares
            try
            {
                Tarjeta tar = (Tarjeta)(grillaTarjetasCliente.SelectedRows[0].DataBoundItem);
                Pago pago = new Pago(decimal.Parse(txtMontoPago.Text), Moneda.Pesos);
                entidadFinanciera.AceptarPago(pago, tar);
                actualiza_grilla_tarjetas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnSaldoLimite_Click(object sender, EventArgs e)
        {//metodo que permite visualizar saldos y limites de la tarjeta que tengo seleccionada en grilla 3
            try
            {
                Tarjeta tar = (Tarjeta)(grillaTarjetasCliente.SelectedRows[0].DataBoundItem);
                foreach (var tarjeta in entidadFinanciera.Tarjetas)
                {
                    if (tarjeta.NroTarjeta == tar.NroTarjeta)
                    {
                        MessageBox.Show(
                            $"El Saldo en pesos es:{tarjeta.saldo_pesos} , el limite en pesos es: {tarjeta.limite_pesos}, el Saldo en dolares es:{tarjeta.saldo_dolares}, el limite en dolares es:{tarjeta.limite_dolares}");
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
          
        }
    }
}
