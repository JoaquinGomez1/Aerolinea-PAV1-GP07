namespace TrabajoPrácticoPAV.Formularios.Facturaciones
{
    partial class Frm_ConsultarFactura
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
            this.Btn_EliminarFactura = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.txt_numeroDoc = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_numeroReserva = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_tipoDoc = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_fechaPago = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.txt_apellido = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_formaPago = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grid_vuelo = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_numeroFactura = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vuelo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_EliminarFactura
            // 
            this.Btn_EliminarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_EliminarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Btn_EliminarFactura.Location = new System.Drawing.Point(224, 445);
            this.Btn_EliminarFactura.Name = "Btn_EliminarFactura";
            this.Btn_EliminarFactura.Pp_Presionado = false;
            this.Btn_EliminarFactura.Size = new System.Drawing.Size(101, 33);
            this.Btn_EliminarFactura.TabIndex = 107;
            this.Btn_EliminarFactura.Text = "Cerrar";
            this.Btn_EliminarFactura.UseVisualStyleBackColor = true;
            this.Btn_EliminarFactura.Click += new System.EventHandler(this.Btn_EliminarFactura_Click_1);
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(558, 32);
            this.BarraSuperior.TabIndex = 105;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(9, 6);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(173, 22);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "ELIMINAR FACTURA";
            // 
            // txt_numeroDoc
            // 
            this.txt_numeroDoc.Enabled = false;
            this.txt_numeroDoc.Location = new System.Drawing.Point(323, 212);
            this.txt_numeroDoc.Name = "txt_numeroDoc";
            this.txt_numeroDoc.Pp_EsPk = true;
            this.txt_numeroDoc.Pp_MensajeError = null;
            this.txt_numeroDoc.Pp_NombreCampo = "numeroDoc";
            this.txt_numeroDoc.Pp_NombreTabla = "Pasajero";
            this.txt_numeroDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_numeroDoc.TabIndex = 95;
            // 
            // txt_numeroReserva
            // 
            this.txt_numeroReserva.Enabled = false;
            this.txt_numeroReserva.Location = new System.Drawing.Point(190, 56);
            this.txt_numeroReserva.Name = "txt_numeroReserva";
            this.txt_numeroReserva.Pp_EsPk = false;
            this.txt_numeroReserva.Pp_MensajeError = null;
            this.txt_numeroReserva.Pp_NombreCampo = "numeroDeReserva";
            this.txt_numeroReserva.Pp_NombreTabla = "Reserva";
            this.txt_numeroReserva.Size = new System.Drawing.Size(100, 20);
            this.txt_numeroReserva.TabIndex = 96;
            // 
            // txt_tipoDoc
            // 
            this.txt_tipoDoc.Enabled = false;
            this.txt_tipoDoc.Location = new System.Drawing.Point(323, 186);
            this.txt_tipoDoc.Name = "txt_tipoDoc";
            this.txt_tipoDoc.Pp_EsPk = true;
            this.txt_tipoDoc.Pp_MensajeError = null;
            this.txt_tipoDoc.Pp_NombreCampo = "tipoDoc";
            this.txt_tipoDoc.Pp_NombreTabla = "Pasajero";
            this.txt_tipoDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_tipoDoc.TabIndex = 97;
            // 
            // txt_fechaPago
            // 
            this.txt_fechaPago.Enabled = false;
            this.txt_fechaPago.Location = new System.Drawing.Point(190, 82);
            this.txt_fechaPago.Mask = "99/99/9999";
            this.txt_fechaPago.Name = "txt_fechaPago";
            this.txt_fechaPago.Pp_EsPk = false;
            this.txt_fechaPago.Pp_MensajeError = null;
            this.txt_fechaPago.Pp_NombreCampo = "fechaPago";
            this.txt_fechaPago.Pp_NombreTabla = "Factura";
            this.txt_fechaPago.Size = new System.Drawing.Size(100, 20);
            this.txt_fechaPago.TabIndex = 92;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Enabled = false;
            this.txt_apellido.Location = new System.Drawing.Point(84, 213);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Pp_EsPk = false;
            this.txt_apellido.Pp_MensajeError = null;
            this.txt_apellido.Pp_NombreCampo = "apellido";
            this.txt_apellido.Pp_NombreTabla = "Pasajero";
            this.txt_apellido.Size = new System.Drawing.Size(116, 20);
            this.txt_apellido.TabIndex = 93;
            // 
            // cmb_formaPago
            // 
            this.cmb_formaPago.Enabled = false;
            this.cmb_formaPago.FormattingEnabled = true;
            this.cmb_formaPago.Location = new System.Drawing.Point(437, 112);
            this.cmb_formaPago.Name = "cmb_formaPago";
            this.cmb_formaPago.Pp_CampoAceptaNull = false;
            this.cmb_formaPago.Pp_EsPk = false;
            this.cmb_formaPago.Pp_MensajeError = null;
            this.cmb_formaPago.Pp_NombreCampo = "descripcion";
            this.cmb_formaPago.Pp_NombreCampoInsert = "idTipoPago";
            this.cmb_formaPago.Pp_NombreTabla = "Tipo_Pago";
            this.cmb_formaPago.Pp_PkTabla = "idTipoPago";
            this.cmb_formaPago.Size = new System.Drawing.Size(94, 21);
            this.cmb_formaPago.TabIndex = 104;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(84, 187);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_EsPk = false;
            this.txt_nombre.Pp_MensajeError = null;
            this.txt_nombre.Pp_NombreCampo = "nombre";
            this.txt_nombre.Pp_NombreTabla = "Pasajero";
            this.txt_nombre.Size = new System.Drawing.Size(116, 20);
            this.txt_nombre.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(221, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 90;
            this.label7.Text = "Numero doc.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(221, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 91;
            this.label8.Text = "Tipo doc.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(319, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 103;
            this.label10.Text = "Forma de pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(24, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 86;
            this.label6.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(29, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 17);
            this.label9.TabIndex = 87;
            this.label9.Text = "Número de factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(24, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 88;
            this.label5.Text = "Nombre";
            // 
            // grid_vuelo
            // 
            this.grid_vuelo.AllowUserToAddRows = false;
            this.grid_vuelo.AllowUserToDeleteRows = false;
            this.grid_vuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_vuelo.Enabled = false;
            this.grid_vuelo.Location = new System.Drawing.Point(12, 263);
            this.grid_vuelo.Name = "grid_vuelo";
            this.grid_vuelo.Pp_FormatoGrid = "idVuelo, Nro. Vuelo, 150;codigoAeropuertoDestino, AEP Destino, 100;codigoAeropuer" +
    "toSalida, AEP Salida, 100";
            this.grid_vuelo.Pp_NombreTabla = "Vuelo";
            this.grid_vuelo.ReadOnly = true;
            this.grid_vuelo.Size = new System.Drawing.Size(519, 167);
            this.grid_vuelo.TabIndex = 102;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 89;
            this.label1.Text = "Fecha de pago";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(29, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Número de reserva";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(13, 176);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 65);
            this.panel2.TabIndex = 101;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_numeroFactura);
            this.panel1.Location = new System.Drawing.Point(13, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 90);
            this.panel1.TabIndex = 100;
            // 
            // txt_numeroFactura
            // 
            this.txt_numeroFactura.Enabled = false;
            this.txt_numeroFactura.Location = new System.Drawing.Point(176, 62);
            this.txt_numeroFactura.Name = "txt_numeroFactura";
            this.txt_numeroFactura.Pp_EsPk = true;
            this.txt_numeroFactura.Pp_MensajeError = null;
            this.txt_numeroFactura.Pp_NombreCampo = "idFactura";
            this.txt_numeroFactura.Pp_NombreTabla = "Factura";
            this.txt_numeroFactura.Size = new System.Drawing.Size(100, 20);
            this.txt_numeroFactura.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 98;
            this.label2.Text = "Datos del pasajero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 16);
            this.label4.TabIndex = 99;
            this.label4.Text = "Información del vuelo";
            // 
            // Frm_ConsultarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 503);
            this.Controls.Add(this.Btn_EliminarFactura);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.txt_numeroDoc);
            this.Controls.Add(this.txt_numeroReserva);
            this.Controls.Add(this.txt_tipoDoc);
            this.Controls.Add(this.txt_fechaPago);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.cmb_formaPago);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grid_vuelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ConsultarFactura";
            this.Text = "Frm_ConsultarFactura";
            this.Load += new System.EventHandler(this.Frm_ConsultarFactura_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_vuelo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Clase.Button_Aerolinea Btn_EliminarFactura;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
        private Clase.TextBox_Aerolinea txt_numeroDoc;
        private Clase.TextBox_Aerolinea txt_numeroReserva;
        private Clase.TextBox_Aerolinea txt_tipoDoc;
        private Clase.MaskedTextBox_Aerolinea txt_fechaPago;
        private Clase.TextBox_Aerolinea txt_apellido;
        private Clase.ComboBox_Aerolinea cmb_formaPago;
        private Clase.TextBox_Aerolinea txt_nombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private Clase.DataGridView_Aerolinea grid_vuelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Clase.TextBox_Aerolinea txt_numeroFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}