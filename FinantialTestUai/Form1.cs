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
            var cliente = new Cliente() { Nombre = txtNombre.Text, Apellido = txtApellido.Text, NroDocumento = Int32.Parse(NroDocumento.Text) };
            entidadFinanciera.Clientes.Add(cliente);

        }

        private void btnGenerarNro_Click(object sender, EventArgs e)
        {
            entidadFinanciera.Tarjeta.Add(new Tarjeta("9999"));
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
            grillaClientes.DataSource = CargarClientes();
        }

        private List<Cliente> CargarClientes()
        {
            entidadFinanciera.Clientes.Add(new Cliente(){Nombre = "Walter", Apellido = "Arce"});

            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás","Walter" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = {  "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };
          
            var listaclientes = from n1 in nombre1
                from n2 in nombre2
                from a1 in apellido1
                select new Cliente  { Nombre = $"{n1}, {n2} ", Apellido = $"{a1}" , TipoDoc = "DNI", NroDocumento = Int32.Parse(GenerarDNI()) };

            return listaclientes.Take(20).ToList();
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

                tar.Titular = cli;
                cli.ListaTarjetas.Add(tar);

                grillaTarjetasCliente.DataSource = null;
                grillaTarjetasCliente.DataSource = cli.OwnListCard();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}
