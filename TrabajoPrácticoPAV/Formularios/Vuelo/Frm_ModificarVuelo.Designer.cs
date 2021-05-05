﻿namespace TrabajoPrácticoPAV.Formularios.Vuelo
{
    partial class Frm_ModificarVuelo
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_duracionestimada = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_nomModelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_numAvion = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_AeropDestino = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_AeropSalida = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_ModificacionVuelo = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.button_Aerolinea2 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Vuelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duracion Estimada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número Avion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aeropuerto Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aeropuerto Destino";
            // 
            // txt_duracionestimada
            // 
            this.txt_duracionestimada.Location = new System.Drawing.Point(164, 93);
            this.txt_duracionestimada.Name = "txt_duracionestimada";
            this.txt_duracionestimada.Pp_EsPk = false;
            this.txt_duracionestimada.Pp_MensajeError = null;
            this.txt_duracionestimada.Pp_NombreCampo = "duracionEstimada";
            this.txt_duracionestimada.Pp_NombreTabla = null;
            this.txt_duracionestimada.Size = new System.Drawing.Size(165, 20);
            this.txt_duracionestimada.TabIndex = 6;
            // 
            // cmb_nomModelo
            // 
            this.cmb_nomModelo.FormattingEnabled = true;
            this.cmb_nomModelo.Location = new System.Drawing.Point(164, 118);
            this.cmb_nomModelo.Name = "cmb_nomModelo";
            this.cmb_nomModelo.Pp_CampoAceptaNull = false;
            this.cmb_nomModelo.Pp_EsPk = false;
            this.cmb_nomModelo.Pp_MensajeError = null;
            this.cmb_nomModelo.Pp_NombreCampo = "nombre";
            this.cmb_nomModelo.Pp_NombreCampoInsert = "idModelo";
            this.cmb_nomModelo.Pp_NombreTabla = "modelo";
            this.cmb_nomModelo.Pp_PkTabla = "idModelo";
            this.cmb_nomModelo.Size = new System.Drawing.Size(165, 21);
            this.cmb_nomModelo.TabIndex = 7;
            // 
            // cmb_numAvion
            // 
            this.cmb_numAvion.FormattingEnabled = true;
            this.cmb_numAvion.Location = new System.Drawing.Point(164, 144);
            this.cmb_numAvion.Name = "cmb_numAvion";
            this.cmb_numAvion.Pp_CampoAceptaNull = false;
            this.cmb_numAvion.Pp_EsPk = false;
            this.cmb_numAvion.Pp_MensajeError = "Seleccionar un avion";
            this.cmb_numAvion.Pp_NombreCampo = "numeroPorModelo";
            this.cmb_numAvion.Pp_NombreCampoInsert = "numeroPorModelo";
            this.cmb_numAvion.Pp_NombreTabla = "avion";
            this.cmb_numAvion.Pp_PkTabla = "numeroPorModelo";
            this.cmb_numAvion.Size = new System.Drawing.Size(165, 21);
            this.cmb_numAvion.TabIndex = 8;
            // 
            // cmb_AeropDestino
            // 
            this.cmb_AeropDestino.FormattingEnabled = true;
            this.cmb_AeropDestino.Location = new System.Drawing.Point(164, 171);
            this.cmb_AeropDestino.Name = "cmb_AeropDestino";
            this.cmb_AeropDestino.Pp_CampoAceptaNull = false;
            this.cmb_AeropDestino.Pp_EsPk = false;
            this.cmb_AeropDestino.Pp_MensajeError = "Seleccionar un Aeropuerto de destino";
            this.cmb_AeropDestino.Pp_NombreCampo = "nombre";
            this.cmb_AeropDestino.Pp_NombreCampoInsert = "codigoAeropuertoDestino";
            this.cmb_AeropDestino.Pp_NombreTabla = "aeropuerto";
            this.cmb_AeropDestino.Pp_PkTabla = "codigo";
            this.cmb_AeropDestino.Size = new System.Drawing.Size(165, 21);
            this.cmb_AeropDestino.TabIndex = 9;
            // 
            // cmb_AeropSalida
            // 
            this.cmb_AeropSalida.FormattingEnabled = true;
            this.cmb_AeropSalida.Location = new System.Drawing.Point(164, 207);
            this.cmb_AeropSalida.Name = "cmb_AeropSalida";
            this.cmb_AeropSalida.Pp_CampoAceptaNull = false;
            this.cmb_AeropSalida.Pp_EsPk = false;
            this.cmb_AeropSalida.Pp_MensajeError = "Seleccionar un Aeropuerto de salida";
            this.cmb_AeropSalida.Pp_NombreCampo = "nombre";
            this.cmb_AeropSalida.Pp_NombreCampoInsert = "codigoAeropuertoSalida";
            this.cmb_AeropSalida.Pp_NombreTabla = "Aeropuerto";
            this.cmb_AeropSalida.Pp_PkTabla = "codigo";
            this.cmb_AeropSalida.Size = new System.Drawing.Size(165, 21);
            this.cmb_AeropSalida.TabIndex = 10;
            // 
            // btn_ModificacionVuelo
            // 
            this.btn_ModificacionVuelo.Location = new System.Drawing.Point(254, 338);
            this.btn_ModificacionVuelo.Name = "btn_ModificacionVuelo";
            this.btn_ModificacionVuelo.Pp_Presionado = false;
            this.btn_ModificacionVuelo.Size = new System.Drawing.Size(75, 23);
            this.btn_ModificacionVuelo.TabIndex = 11;
            this.btn_ModificacionVuelo.Text = "Aceptar";
            this.btn_ModificacionVuelo.UseVisualStyleBackColor = true;
            this.btn_ModificacionVuelo.Click += new System.EventHandler(this.btn_ModificacionVuelo_Click);
            // 
            // button_Aerolinea2
            // 
            this.button_Aerolinea2.Location = new System.Drawing.Point(336, 338);
            this.button_Aerolinea2.Name = "button_Aerolinea2";
            this.button_Aerolinea2.Pp_Presionado = false;
            this.button_Aerolinea2.Size = new System.Drawing.Size(75, 23);
            this.button_Aerolinea2.TabIndex = 12;
            this.button_Aerolinea2.Text = "Cancelar";
            this.button_Aerolinea2.UseVisualStyleBackColor = true;
            this.button_Aerolinea2.Click += new System.EventHandler(this.button_Aerolinea2_Click);
            // 
            // Frm_ModificarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(749, 414);
            this.Controls.Add(this.button_Aerolinea2);
            this.Controls.Add(this.btn_ModificacionVuelo);
            this.Controls.Add(this.cmb_AeropSalida);
            this.Controls.Add(this.cmb_AeropDestino);
            this.Controls.Add(this.cmb_numAvion);
            this.Controls.Add(this.cmb_nomModelo);
            this.Controls.Add(this.txt_duracionestimada);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ModificarVuelo";
            this.Text = "Frm_ModificarVuelo";
            this.Load += new System.EventHandler(this.Frm_ModificarVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Clase.TextBox_Aerolinea txt_duracionestimada;
        private Clase.ComboBox_Aerolinea cmb_nomModelo;
        private Clase.ComboBox_Aerolinea cmb_numAvion;
        private Clase.ComboBox_Aerolinea cmb_AeropDestino;
        private Clase.ComboBox_Aerolinea cmb_AeropSalida;
        private Clase.Button_Aerolinea btn_ModificacionVuelo;
        private Clase.Button_Aerolinea button_Aerolinea2;
    }
}