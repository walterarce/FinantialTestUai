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
            this.btnConsumoDolares = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetasCliente)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grillaClientes
            // 
            this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaClientes.Location = new System.Drawing.Point(13, 75);
            this.grillaClientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grillaClientes.Name = "grillaClientes";
            this.grillaClientes.RowHeadersWidth = 62;
            this.grillaClientes.Size = new System.Drawing.Size(779, 231);
            this.grillaClientes.TabIndex = 0;
            this.grillaClientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaClientes_RowEnter);
            // 
            // grillaTarjetas
            // 
            this.grillaTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTarjetas.Location = new System.Drawing.Point(824, 75);
            this.grillaTarjetas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grillaTarjetas.Name = "grillaTarjetas";
            this.grillaTarjetas.RowHeadersWidth = 62;
            this.grillaTarjetas.Size = new System.Drawing.Size(904, 231);
            this.grillaTarjetas.TabIndex = 1;
            // 
            // grillaTarjetasCliente
            // 
            this.grillaTarjetasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTarjetasCliente.Location = new System.Drawing.Point(505, 364);
            this.grillaTarjetasCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grillaTarjetasCliente.Name = "grillaTarjetasCliente";
            this.grillaTarjetasCliente.RowHeadersWidth = 62;
            this.grillaTarjetasCliente.Size = new System.Drawing.Size(904, 231);
            this.grillaTarjetasCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(608, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Vincular Tarjeta";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(115, 38);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(148, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(115, 82);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(148, 26);
            this.txtApellido.TabIndex = 6;
            // 
            // NroDocumento
            // 
            this.NroDocumento.Location = new System.Drawing.Point(115, 159);
            this.NroDocumento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.Size = new System.Drawing.Size(148, 26);
            this.NroDocumento.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Documento";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(116, 121);
            this.cboTipoDoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(180, 28);
            this.cboTipoDoc.TabIndex = 11;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(0, 187);
            this.btnAddCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(112, 35);
            this.btnAddCliente.TabIndex = 12;
            this.btnAddCliente.Text = "Agregar";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1155, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "TipoTarjeta";
            // 
            // btnGenerarNro
            // 
            this.btnGenerarNro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGenerarNro.Location = new System.Drawing.Point(1459, 35);
            this.btnGenerarNro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerarNro.Name = "btnGenerarNro";
            this.btnGenerarNro.Size = new System.Drawing.Size(177, 35);
            this.btnGenerarNro.TabIndex = 17;
            this.btnGenerarNro.Text = "GenerarNroTarjeta";
            this.btnGenerarNro.UseVisualStyleBackColor = false;
            this.btnGenerarNro.Click += new System.EventHandler(this.btnGenerarNro_Click);
            // 
            // cboTipoTarjeta
            // 
            this.cboTipoTarjeta.FormattingEnabled = true;
            this.cboTipoTarjeta.Items.AddRange(new object[] {
            "Platinum",
            "Gold",
            "Plata"});
            this.cboTipoTarjeta.Location = new System.Drawing.Point(1262, 39);
            this.cboTipoTarjeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboTipoTarjeta.Name = "cboTipoTarjeta";
            this.cboTipoTarjeta.Size = new System.Drawing.Size(180, 28);
            this.cboTipoTarjeta.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(824, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "Desvincular Tarjeta";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Lista de Clientes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1015, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Lista de Tarjetas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(513, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Tarjetas por Cliente";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(189, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 35);
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
            this.groupBox1.Location = new System.Drawing.Point(17, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 246);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Cliente";
            // 
            // btnConsumoPesos
            // 
            this.btnConsumoPesos.Location = new System.Drawing.Point(695, 314);
            this.btnConsumoPesos.Name = "btnConsumoPesos";
            this.btnConsumoPesos.Size = new System.Drawing.Size(166, 45);
            this.btnConsumoPesos.TabIndex = 25;
            this.btnConsumoPesos.Text = "$ Consumo Pesos";
            this.btnConsumoPesos.UseVisualStyleBackColor = true;
            this.btnConsumoPesos.Click += new System.EventHandler(this.btnConsumoPesos_Click);
            // 
            // btnConsumoDolares
            // 
            this.btnConsumoDolares.Location = new System.Drawing.Point(867, 314);
            this.btnConsumoDolares.Name = "btnConsumoDolares";
            this.btnConsumoDolares.Size = new System.Drawing.Size(214, 45);
            this.btnConsumoDolares.TabIndex = 25;
            this.btnConsumoDolares.Text = "Consumo Dolares U$S";
            this.btnConsumoDolares.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1797, 998);
            this.Controls.Add(this.btnConsumoDolares);
            this.Controls.Add(this.btnConsumoPesos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cboTipoTarjeta);
            this.Controls.Add(this.btnGenerarNro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaTarjetasCliente);
            this.Controls.Add(this.grillaTarjetas);
            this.Controls.Add(this.grillaClientes);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Gestion de Tarjetas Consumos Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetasCliente)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnConsumoDolares;
    }
}

