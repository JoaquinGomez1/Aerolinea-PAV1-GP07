namespace TrabajoPrácticoPAV.Formularios.Vuelo
{
    partial class Frm_AltaVuelo
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
            this.btn_Cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_Registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.cmb_AeropSalida = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_AeropDestino = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.textBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_nomModelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_numAvion = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Duracion Estimada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero Avion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aeropuerto Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Aeropuerto Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(55, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Registrar Vuelo";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(390, 326);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Pp_Presionado = false;
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 12;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(293, 326);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Pp_Presionado = false;
            this.btn_Registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Registrar.TabIndex = 11;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // cmb_AeropSalida
            // 
            this.cmb_AeropSalida.FormattingEnabled = true;
            this.cmb_AeropSalida.Location = new System.Drawing.Point(160, 177);
            this.cmb_AeropSalida.Name = "cmb_AeropSalida";
            this.cmb_AeropSalida.Pp_CampoAceptaNull = true;
            this.cmb_AeropSalida.Pp_EsPk = false;
            this.cmb_AeropSalida.Pp_MensajeError = "Seleccione Aeropuerto de Salida";
            this.cmb_AeropSalida.Pp_NombreCampo = "nombre";
            this.cmb_AeropSalida.Pp_NombreCampoInsert = "codigoAeropuertoSalida";
            this.cmb_AeropSalida.Pp_NombreTabla = "aeropuerto";
            this.cmb_AeropSalida.Pp_PkTabla = "codigo";
            this.cmb_AeropSalida.Size = new System.Drawing.Size(194, 21);
            this.cmb_AeropSalida.TabIndex = 9;
            // 
            // cmb_AeropDestino
            // 
            this.cmb_AeropDestino.FormattingEnabled = true;
            this.cmb_AeropDestino.Location = new System.Drawing.Point(160, 204);
            this.cmb_AeropDestino.Name = "cmb_AeropDestino";
            this.cmb_AeropDestino.Pp_CampoAceptaNull = true;
            this.cmb_AeropDestino.Pp_EsPk = false;
            this.cmb_AeropDestino.Pp_MensajeError = "Seleccione Aeropuerto destino";
            this.cmb_AeropDestino.Pp_NombreCampo = "nombre";
            this.cmb_AeropDestino.Pp_NombreCampoInsert = "codigoAeropuertoDestino";
            this.cmb_AeropDestino.Pp_NombreTabla = "aeropuerto";
            this.cmb_AeropDestino.Pp_PkTabla = "codigo";
            this.cmb_AeropDestino.Size = new System.Drawing.Size(194, 21);
            this.cmb_AeropDestino.TabIndex = 8;
            // 
            // textBox_Aerolinea1
            // 
            this.textBox_Aerolinea1.Location = new System.Drawing.Point(164, 232);
            this.textBox_Aerolinea1.Name = "textBox_Aerolinea1";
            this.textBox_Aerolinea1.Pp_EsPk = false;
            this.textBox_Aerolinea1.Pp_MensajeError = "Ingresar duracion estimada";
            this.textBox_Aerolinea1.Pp_NombreCampo = "duracionEstimada";
            this.textBox_Aerolinea1.Pp_NombreTabla = "Vuelo";
            this.textBox_Aerolinea1.Size = new System.Drawing.Size(121, 20);
            this.textBox_Aerolinea1.TabIndex = 2;
            // 
            // cmb_nomModelo
            // 
            this.cmb_nomModelo.FormattingEnabled = true;
            this.cmb_nomModelo.Location = new System.Drawing.Point(164, 114);
            this.cmb_nomModelo.Name = "cmb_nomModelo";
            this.cmb_nomModelo.Pp_CampoAceptaNull = true;
            this.cmb_nomModelo.Pp_EsPk = false;
            this.cmb_nomModelo.Pp_MensajeError = null;
            this.cmb_nomModelo.Pp_NombreCampo = "nombre";
            this.cmb_nomModelo.Pp_NombreCampoInsert = "idModelo";
            this.cmb_nomModelo.Pp_NombreTabla = "modelo";
            this.cmb_nomModelo.Pp_PkTabla = "idModelo";
            this.cmb_nomModelo.Size = new System.Drawing.Size(121, 21);
            this.cmb_nomModelo.TabIndex = 1;
            this.cmb_nomModelo.SelectionChangeCommitted += new System.EventHandler(this.cmb_nomModelo_SelectionChangeCommitted);
            // 
            // cmb_numAvion
            // 
            this.cmb_numAvion.FormattingEnabled = true;
            this.cmb_numAvion.Location = new System.Drawing.Point(164, 141);
            this.cmb_numAvion.Name = "cmb_numAvion";
            this.cmb_numAvion.Pp_CampoAceptaNull = true;
            this.cmb_numAvion.Pp_EsPk = false;
            this.cmb_numAvion.Pp_MensajeError = "Seleccione un Numero de Avion";
            this.cmb_numAvion.Pp_NombreCampo = "numeroPorModelo";
            this.cmb_numAvion.Pp_NombreCampoInsert = "numeroPorModelo";
            this.cmb_numAvion.Pp_NombreTabla = "avion";
            this.cmb_numAvion.Pp_PkTabla = "numeroPorModelo";
            this.cmb_numAvion.Size = new System.Drawing.Size(121, 21);
            this.cmb_numAvion.TabIndex = 0;
            // 
            // Frm_AltaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(733, 375);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_AeropSalida);
            this.Controls.Add(this.cmb_AeropDestino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Aerolinea1);
            this.Controls.Add(this.cmb_nomModelo);
            this.Controls.Add(this.cmb_numAvion);
            this.Name = "Frm_AltaVuelo";
            this.Text = "Frm_AltaVuelo";
            this.Load += new System.EventHandler(this.Frm_AltaVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.ComboBox_Aerolinea cmb_numAvion;
        private Clase.ComboBox_Aerolinea cmb_nomModelo;
        private Clase.TextBox_Aerolinea textBox_Aerolinea1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Clase.ComboBox_Aerolinea cmb_AeropDestino;
        private Clase.ComboBox_Aerolinea cmb_AeropSalida;
        private System.Windows.Forms.Label label6;
        private Clase.Button_Aerolinea btn_Registrar;
        private Clase.Button_Aerolinea btn_Cancelar;
    }
}