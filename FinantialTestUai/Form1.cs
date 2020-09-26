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
            var cliente = new Cliente( txtNombre.Text,  txtApellido.Text,"DNI", Int32.Parse(NroDocumento.Text) );
           
            entidadFinanciera.AgregarCliente(cliente);
            grillaClientes.DataSource = null;
            grillaClientes.DataSource = entidadFinanciera.Clientes;

        }

        private void btnGenerarNro_Click(object sender, EventArgs e)
        {
            entidadFinanciera.AgregarTarjeta(cboTipoTarjeta.ValueMember);
            grillaTarjetas.DataSource = null;
            grillaTarjetas.DataSource = entidadFinanciera.Tarjeta;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cbotipotarjetavalores = new BindingList<KeyValuePair<TipoTarjeta,int>>();
            cbotipotarjetavalores.Add(new KeyValuePair<TipoTarjeta, int>(TipoTarjeta.Platinum,9999));
            cbotipotarjetavalores.Add(new KeyValuePair<TipoTarjeta, int>(TipoTarjeta.Gold, 8888));
            cbotipotarjetavalores.Add(new KeyValuePair<TipoTarjeta, int>(TipoTarjeta.Plata, 7777));

            cboTipoTarjeta.DataSource = cbotipotarjetavalores;
            cboTipoTarjeta.ValueMember = "Value";
            cboTipoTarjeta.DisplayMember = "Key";
            cboTipoTarjeta.SelectedIndex = 0;

            grillaTarjetas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaTarjetas.MultiSelect = false;

            grillaClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaClientes.MultiSelect = false;

            grillaTarjetasCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grillaTarjetasCliente.MultiSelect = false;

            grillaClientes.DataSource = null;
          
            
            grillaTarjetas.DataSource = null;
            
        }

        private List<Cliente> CargarClientes()
        {
            //entidadFinanciera.Clientes.Add(new Cliente(txtNombre.Text,txtApellido.Text, "DNI", 0));

            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás","Walter" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = {  "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
          
            var listaclientes = from n1 in nombre1
                from n2 in nombre2
                from a1 in apellido1
                select new Cliente  { Nombre = $"{n1}, {n2} ", Apellido = $"{a1}" , TipoDoc = "DNI", NroDocumento = 0 };

           
            return listaclientes.Take(15).ToList();
        }
        private string GenerarDNI()
        {
            Random rnd = new Random();
            string nrorandom = "";
            for (int i = 0; i < 8; i++)
            {
                int numeroazar = rnd.Next(0, 9);
                nrorandom = nrorandom + numeroazar.ToString();
            }

            return nrorandom;
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
            {  //No se porque en un momento determinado el evento manejador dejo de responder y me lo sacaba de indice, tuve que eliminar el evento y volver a generarlo.
                //creeria que alguna metadata del proyecto quedo mal y por lo cual no respondio, lo que no probe es limpiar la solucion.
                grillaTarjetasCliente.DataSource = null;
                grillaTarjetasCliente.DataSource = ((Cliente)grillaClientes.SelectedRows[0].DataBoundItem).RetornarTarjeta();
            }
            catch (Exception )
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Atencion solo es para fines de prueba la lista actual sera reemplazada");
            entidadFinanciera.Clientes = CargarClientes();
            foreach (var cliente in entidadFinanciera.Clientes)
            {
                cliente.NroDocumento = Int32.Parse( GenerarDNI());
            }
            grillaClientes.DataSource = null;
            grillaClientes.DataSource = entidadFinanciera.Clientes;
        }

        private void btnConsumoPesos_Click(object sender, EventArgs e)
        {
            try
            {
                frmconsumo.ActiveForm.Show();
                Cliente cli = (Cliente)(grillaClientes.SelectedRows[0].DataBoundItem);
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente cli = (Cliente)(grillaClientes.SelectedRows[0].DataBoundItem);
                Tarjeta tar = (Tarjeta)(grillaTarjetas.SelectedRows[0].DataBoundItem);
                cli.DesvinculoTarjeta(cli,tar);

                grillaTarjetasCliente.DataSource = null;
                grillaTarjetasCliente.DataSource = cli.RetornarTarjeta();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
