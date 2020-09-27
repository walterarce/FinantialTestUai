namespace FinantialTestUai
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grillaClientes = new System.Windows.Forms.DataGridView();
            this.grillaTarjetas = new System.Windows.Forms.DataGridView();
            this.grillaTarjetasCliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.NroDocumento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTipoDoc = new System.Windows.Forms.ComboBox();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGenerarNro = new System.Windows.Forms.Button();
            this.cboTipoTarjeta = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConsumoPesos = new System.Windows.Forms.Button();
            this.txtMontoConsumo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grillaMovimientos = new System.Windows.Forms.DataGridView();
            this.btnPago = new System.Windows.Forms.Button();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.btnConsumoDolar = new System.Windows.Forms.Button();
            this.btnPagoDolares = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetasCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaClientes
            // 
            this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaClientes.Location = new System.Drawing.Point(12, 85);
            this.grillaClientes.Name = "grillaClientes";
            this.grillaClientes.RowHeadersWidth = 62;
            this.grillaClientes.Size = new System.Drawing.Size(519, 150);
            this.grillaClientes.TabIndex = 0;
            this.grillaClientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaClientes_RowEnter);
            // 
            // grillaTarjetas
            // 
            this.grillaTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTarjetas.Location = new System.Drawing.Point(583, 85);
            this.grillaTarjetas.Name = "grillaTarjetas";
            this.grillaTarjetas.RowHeadersWidth = 62;
            this.grillaTarjetas.Size = new System.Drawing.Size(603, 150);
            this.grillaTarjetas.TabIndex = 1;
            // 
            // grillaTarjetasCliente
            // 
            this.grillaTarjetasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTarjetasCliente.Location = new System.Drawing.Point(390, 336);
            this.grillaTarjetasCliente.Name = "grillaTarjetasCliente";
            this.grillaTarjetasCliente.RowHeadersWidth = 62;
            this.grillaTarjetasCliente.Size = new System.Drawing.Size(603, 150);
            this.grillaTarjetasCliente.TabIndex = 2;
            this.grillaTarjetasCliente.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTarjetasCliente_RowEnter);
            this.grillaTarjetasCliente.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaTarjetasCliente_RowLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(408, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Vincular Tarjeta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(77, 53);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // NroDocumento
            // 
            this.NroDocumento.Location = new System.Drawing.Point(77, 103);
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.Size = new System.Drawing.Size(100, 20);
            this.NroDocumento.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Documento";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(77, 79);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.cboTipoDoc.TabIndex = 7;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(0, 122);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAddCliente.TabIndex = 12;
            this.btnAddCliente.Text = "Agregar";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "TipoTarjeta";
            // 
            // btnGenerarNro
            // 
            this.btnGenerarNro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGenerarNro.Location = new System.Drawing.Point(197, 19);
            this.btnGenerarNro.Name = "btnGenerarNro";
            this.btnGenerarNro.Size = new System.Drawing.Size(99, 23);
            this.btnGenerarNro.TabIndex = 17;
            this.btnGenerarNro.Text = "Generar Tarjeta";
            this.btnGenerarNro.UseVisualStyleBackColor = false;
            this.btnGenerarNro.Click += new System.EventHandler(this.btnGenerarNro_Click);
            // 
            // cboTipoTarjeta
            // 
            this.cboTipoTarjeta.FormattingEnabled = true;
            this.cboTipoTarjeta.Location = new System.Drawing.Point(73, 19);
            this.cboTipoTarjeta.Name = "cboTipoTarjeta";
            this.cboTipoTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cboTipoTarjeta.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(678, 59);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 24);
            this.button2.TabIndex = 19;
            this.button2.Text = "Desvincular Tarjeta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 79);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Lista de Clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(580, 64);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Lista de Tarjetas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 319);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tarjetas por Cliente";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(129, 59);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Precargar Clientes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboTipoDoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NroDocumento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAddCliente);
            this.groupBox1.Location = new System.Drawing.Point(64, 303);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(240, 160);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Cliente";
            // 
            // btnConsumoPesos
            // 
            this.btnConsumoPesos.Location = new System.Drawing.Point(516, 303);
            this.btnConsumoPesos.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsumoPesos.Name = "btnConsumoPesos";
            this.btnConsumoPesos.Size = new System.Drawing.Size(111, 29);
            this.btnConsumoPesos.TabIndex = 25;
            this.btnConsumoPesos.Text = "Consumo Pesos $";
            this.btnConsumoPesos.UseVisualStyleBackColor = true;
            this.btnConsumoPesos.Click += new System.EventHandler(this.btnConsumoPesos_Click);
            // 
            // txtMontoConsumo
            // 
            this.txtMontoConsumo.Location = new System.Drawing.Point(784, 308);
            this.txtMontoConsumo.Name = "txtMontoConsumo";
            this.txtMontoConsumo.Size = new System.Drawing.Size(100, 20);
            this.txtMontoConsumo.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGenerarNro);
            this.groupBox2.Controls.Add(this.cboTipoTarjeta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(848, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 49);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar Tarjeta";
            // 
            // grillaMovimientos
            // 
            this.grillaMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaMovimientos.Location = new System.Drawing.Point(390, 492);
            this.grillaMovimientos.Name = "grillaMovimientos";
            this.grillaMovimientos.Size = new System.Drawing.Size(606, 150);
            this.grillaMovimientos.TabIndex = 28;
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(999, 353);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(75, 23);
            this.btnPago.TabIndex = 30;
            this.btnPago.Text = "Pago Pesos";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click);
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(1034, 383);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(100, 20);
            this.txtMontoPago.TabIndex = 31;
            // 
            // btnConsumoDolar
            // 
            this.btnConsumoDolar.Location = new System.Drawing.Point(632, 303);
            this.btnConsumoDolar.Name = "btnConsumoDolar";
            this.btnConsumoDolar.Size = new System.Drawing.Size(128, 29);
            this.btnConsumoDolar.TabIndex = 32;
            this.btnConsumoDolar.Text = "Consumo Dolares U$S";
            this.btnConsumoDolar.UseVisualStyleBackColor = true;
            this.btnConsumoDolar.Click += new System.EventHandler(this.btnConsumoDolar_Click);
            // 
            // btnPagoDolares
            // 
            this.btnPagoDolares.Location = new System.Drawing.Point(1080, 353);
            this.btnPagoDolares.Name = "btnPagoDolares";
            this.btnPagoDolares.Size = new System.Drawing.Size(97, 23);
            this.btnPagoDolares.TabIndex = 33;
            this.btnPagoDolares.Text = "Pago Dolares";
            this.btnPagoDolares.UseVisualStyleBackColor = true;
            this.btnPagoDolares.Click += new System.EventHandler(this.btnPagoDolares_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1198, 649);
            this.Controls.Add(this.btnPagoDolares);
            this.Controls.Add(this.btnConsumoDolar);
            this.Controls.Add(this.txtMontoPago);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.grillaMovimientos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMontoConsumo);
            this.Controls.Add(this.btnConsumoPesos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaTarjetasCliente);
            this.Controls.Add(this.grillaTarjetas);
            this.Controls.Add(this.grillaClientes);
            this.Name = "Form1";
            this.Text = "Gestion de Tarjetas Consumos Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetasCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaMovimientos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaClientes;
        private System.Windows.Forms.DataGridView grillaTarjetas;
        private System.Windows.Forms.DataGridView grillaTarjetasCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox NroDocumento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTipoDoc;
        private System.Windows.Forms.Button btnAddCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGenerarNro;
        private System.Windows.Forms.ComboBox cboTipoTarjeta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConsumoPesos;
        private System.Windows.Forms.TextBox txtMontoConsumo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grillaMovimientos;
        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.TextBox txtMontoPago;
        private System.Windows.Forms.Button btnConsumoDolar;
        private System.Windows.Forms.Button btnPagoDolares;
    }
}

