
namespace TrabajoPrácticoPAV.Formularios.Facturaciones
{
    partial class Frm_Facturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_apellido = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_numeroDoc = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_tipoDoc = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.btn_GenerarFactura = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_Aerolinea5 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.grid_vuelo = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.txt_numeroReserva = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.txt_fechaPago = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.btn_buscarPasajero = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(10, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha de pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Datos del pasajero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(10, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número de reserva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Información del vuelo";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_fechaPago);
            this.panel1.Controls.Add(this.txt_numeroReserva);
            this.panel1.Controls.Add(this.textBox_Aerolinea5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(42, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 101);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_numeroDoc);
            this.panel2.Controls.Add(this.txt_tipoDoc);
            this.panel2.Controls.Add(this.txt_apellido);
            this.panel2.Controls.Add(this.txt_nombre);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(42, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 65);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(10, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(10, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(342, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Numero doc.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(342, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tipo doc.";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(70, 11);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_EsPk = false;
            this.txt_nombre.Pp_MensajeError = null;
            this.txt_nombre.Pp_NombreCampo = "nombre";
            this.txt_nombre.Pp_NombreTabla = "Pasajero";
            this.txt_nombre.Size = new System.Drawing.Size(116, 20);
            this.txt_nombre.TabIndex = 3;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(70, 37);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pp_EsPk = false;
            this.txt_apellido.Pp_MensajeError = null;
            this.txt_apellido.Pp_NombreCampo = "apellido";
            this.txt_apellido.Pp_NombreTabla = "Pasajero";
            this.txt_apellido.Size = new System.Drawing.Size(116, 20);
            this.txt_apellido.TabIndex = 3;
            // 
            // txt_numeroDoc
            // 
            this.txt_numeroDoc.Location = new System.Drawing.Point(444, 36);
            this.txt_numeroDoc.Name = "txt_numeroDoc";
            this.txt_numeroDoc.Pp_EsPk = true;
            this.txt_numeroDoc.Pp_MensajeError = null;
            this.txt_numeroDoc.Pp_NombreCampo = "numeroDoc";
            this.txt_numeroDoc.Pp_NombreTabla = "Pasajero";
            this.txt_numeroDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_numeroDoc.TabIndex = 4;
            // 
            // txt_tipoDoc
            // 
            this.txt_tipoDoc.Location = new System.Drawing.Point(444, 10);
            this.txt_tipoDoc.Name = "txt_tipoDoc";
            this.txt_tipoDoc.Pp_EsPk = true;
            this.txt_tipoDoc.Pp_MensajeError = null;
            this.txt_tipoDoc.Pp_NombreCampo = "tipoDoc";
            this.txt_tipoDoc.Pp_NombreTabla = "Pasajero";
            this.txt_tipoDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_tipoDoc.TabIndex = 5;
            // 
            // btn_GenerarFactura
            // 
            this.btn_GenerarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GenerarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_GenerarFactura.Location = new System.Drawing.Point(566, 242);
            this.btn_GenerarFactura.Name = "btn_GenerarFactura";
            this.btn_GenerarFactura.Pp_Presionado = false;
            this.btn_GenerarFactura.Size = new System.Drawing.Size(119, 28);
            this.btn_GenerarFactura.TabIndex = 4;
            this.btn_GenerarFactura.Text = "Generar factura";
            this.btn_GenerarFactura.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cancelar.Location = new System.Drawing.Point(566, 315);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Pp_Presionado = false;
            this.btn_cancelar.Size = new System.Drawing.Size(90, 28);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_eliminar.Location = new System.Drawing.Point(566, 281);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Pp_Presionado = false;
            this.btn_eliminar.Size = new System.Drawing.Size(90, 28);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "Eliminar ";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(10, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Número de factura";
            // 
            // textBox_Aerolinea5
            // 
            this.textBox_Aerolinea5.Enabled = false;
            this.textBox_Aerolinea5.Location = new System.Drawing.Point(171, 66);
            this.textBox_Aerolinea5.Name = "textBox_Aerolinea5";
            this.textBox_Aerolinea5.Pp_EsPk = true;
            this.textBox_Aerolinea5.Pp_MensajeError = null;
            this.textBox_Aerolinea5.Pp_NombreCampo = "idFactura";
            this.textBox_Aerolinea5.Pp_NombreTabla = "Factura";
            this.textBox_Aerolinea5.Size = new System.Drawing.Size(100, 20);
            this.textBox_Aerolinea5.TabIndex = 1;
            // 
            // grid_vuelo
            // 
            this.grid_vuelo.AllowUserToAddRows = false;
            this.grid_vuelo.AllowUserToDeleteRows = false;
            this.grid_vuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_vuelo.Location = new System.Drawing.Point(41, 242);
            this.grid_vuelo.Name = "grid_vuelo";
            this.grid_vuelo.Pp_FormatoGrid = "idVuelo, Nro. Vuelo, 150;codigoAeropuertoDestino, AEP Destino, 100;codigoAeropuer" +
    "toSalida, AEP Salida, 100";
            this.grid_vuelo.Pp_NombreTabla = "Vuelo";
            this.grid_vuelo.ReadOnly = true;
            this.grid_vuelo.Size = new System.Drawing.Size(519, 150);
            this.grid_vuelo.TabIndex = 5;
            // 
            // txt_numeroReserva
            // 
            this.txt_numeroReserva.Location = new System.Drawing.Point(171, 9);
            this.txt_numeroReserva.Mask = "9999999999";
            this.txt_numeroReserva.Name = "txt_numeroReserva";
            this.txt_numeroReserva.Pp_EsPk = true;
            this.txt_numeroReserva.Pp_MensajeError = null;
            this.txt_numeroReserva.Pp_NombreCampo = "numeroDeReserva";
            this.txt_numeroReserva.Pp_NombreTabla = "Reserva";
            this.txt_numeroReserva.Size = new System.Drawing.Size(100, 20);
            this.txt_numeroReserva.TabIndex = 2;
            // 
            // txt_fechaPago
            // 
            this.txt_fechaPago.Location = new System.Drawing.Point(171, 40);
            this.txt_fechaPago.Mask = "99/99/9999";
            this.txt_fechaPago.Name = "txt_fechaPago";
            this.txt_fechaPago.Pp_EsPk = false;
            this.txt_fechaPago.Pp_MensajeError = null;
            this.txt_fechaPago.Pp_NombreCampo = null;
            this.txt_fechaPago.Pp_NombreTabla = null;
            this.txt_fechaPago.Size = new System.Drawing.Size(100, 20);
            this.txt_fechaPago.TabIndex = 3;
            // 
            // btn_buscarPasajero
            // 
            this.btn_buscarPasajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_buscarPasajero.Location = new System.Drawing.Point(351, 29);
            this.btn_buscarPasajero.Name = "btn_buscarPasajero";
            this.btn_buscarPasajero.Pp_Presionado = false;
            this.btn_buscarPasajero.Size = new System.Drawing.Size(123, 27);
            this.btn_buscarPasajero.TabIndex = 6;
            this.btn_buscarPasajero.Text = "Buscar pasajero";
            this.btn_buscarPasajero.UseVisualStyleBackColor = true;
            this.btn_buscarPasajero.Click += new System.EventHandler(this.btn_buscarPasajero_Click);
            // 
            // Frm_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 421);
            this.Controls.Add(this.btn_buscarPasajero);
            this.Controls.Add(this.grid_vuelo);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_GenerarFactura);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Facturacion";
            this.Load += new System.EventHandler(this.Frm_Facturacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vuelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Clase.TextBox_Aerolinea txt_numeroDoc;
        private Clase.TextBox_Aerolinea txt_tipoDoc;
        private Clase.TextBox_Aerolinea txt_apellido;
        private Clase.TextBox_Aerolinea txt_nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Clase.Button_Aerolinea btn_GenerarFactura;
        private Clase.Button_Aerolinea btn_cancelar;
        private Clase.Button_Aerolinea btn_eliminar;
        private Clase.TextBox_Aerolinea textBox_Aerolinea5;
        private System.Windows.Forms.Label label9;
        private Clase.DataGridView_Aerolinea grid_vuelo;
        private Clase.MaskedTextBox_Aerolinea txt_numeroReserva;
        private Clase.MaskedTextBox_Aerolinea txt_fechaPago;
        private Clase.Button_Aerolinea btn_buscarPasajero;
    }
}