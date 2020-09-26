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
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetasCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaClientes
            // 
            this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaClientes.Location = new System.Drawing.Point(19, 49);
            this.grillaClientes.Name = "grillaClientes";
            this.grillaClientes.Size = new System.Drawing.Size(381, 150);
            this.grillaClientes.TabIndex = 0;
            this.grillaClientes.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaClientes_RowEnter);
            // 
            // grillaTarjetas
            // 
            this.grillaTarjetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTarjetas.Location = new System.Drawing.Point(435, 49);
            this.grillaTarjetas.Name = "grillaTarjetas";
            this.grillaTarjetas.Size = new System.Drawing.Size(434, 150);
            this.grillaTarjetas.TabIndex = 1;
            // 
            // grillaTarjetasCliente
            // 
            this.grillaTarjetasCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaTarjetasCliente.Location = new System.Drawing.Point(899, 49);
            this.grillaTarjetasCliente.Name = "grillaTarjetasCliente";
            this.grillaTarjetasCliente.Size = new System.Drawing.Size(240, 150);
            this.grillaTarjetasCliente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gestion de Tarjetas Consumos Clientes";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Asociar a ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(138, 332);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(138, 359);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // NroDocumento
            // 
            this.NroDocumento.Location = new System.Drawing.Point(138, 413);
            this.NroDocumento.Name = "NroDocumento";
            this.NroDocumento.Size = new System.Drawing.Size(100, 20);
            this.NroDocumento.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Documento";
            // 
            // cboTipoDoc
            // 
            this.cboTipoDoc.FormattingEnabled = true;
            this.cboTipoDoc.Location = new System.Drawing.Point(138, 386);
            this.cboTipoDoc.Name = "cboTipoDoc";
            this.cboTipoDoc.Size = new System.Drawing.Size(121, 21);
            this.cboTipoDoc.TabIndex = 11;
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(138, 449);
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
            this.label5.Location = new System.Drawing.Point(391, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "NroTarjeta";
            // 
            // btnGenerarNro
            // 
            this.btnGenerarNro.Location = new System.Drawing.Point(587, 333);
            this.btnGenerarNro.Name = "btnGenerarNro";
            this.btnGenerarNro.Size = new System.Drawing.Size(118, 23);
            this.btnGenerarNro.TabIndex = 17;
            this.btnGenerarNro.Text = "GenerarNroTarjeta";
            this.btnGenerarNro.UseVisualStyleBackColor = true;
            this.btnGenerarNro.Click += new System.EventHandler(this.btnGenerarNro_Click);
            // 
            // cboTipoTarjeta
            // 
            this.cboTipoTarjeta.FormattingEnabled = true;
            this.cboTipoTarjeta.Items.AddRange(new object[] {
            "Platinum",
            "Gold",
            "Plata"});
            this.cboTipoTarjeta.Location = new System.Drawing.Point(460, 335);
            this.cboTipoTarjeta.Name = "cboTipoTarjeta";
            this.cboTipoTarjeta.Size = new System.Drawing.Size(121, 21);
            this.cboTipoTarjeta.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 649);
            this.Controls.Add(this.cboTipoTarjeta);
            this.Controls.Add(this.btnGenerarNro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.cboTipoDoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NroDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaTarjetasCliente);
            this.Controls.Add(this.grillaTarjetas);
            this.Controls.Add(this.grillaClientes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaTarjetasCliente)).EndInit();
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
    }
}

