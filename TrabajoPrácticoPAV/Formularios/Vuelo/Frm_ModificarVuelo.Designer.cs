namespace TrabajoPrácticoPAV.Formularios.Vuelo
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
            this.label7 = new System.Windows.Forms.Label();
            this.txt_idVuelo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Vuelo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(101, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Duracion Estimada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(162, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(111, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Número Avión";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(444, 132);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Aeropuerto Salida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(444, 167);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Aeropuerto Destino";
            // 
            // txt_duracionestimada
            // 
            this.txt_duracionestimada.Location = new System.Drawing.Point(271, 286);
            this.txt_duracionestimada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_duracionestimada.Name = "txt_duracionestimada";
            this.txt_duracionestimada.Pp_EsPk = false;
            this.txt_duracionestimada.Pp_MensajeError = "Ingrese una duracion estimada";
            this.txt_duracionestimada.Pp_NombreCampo = "duracionEstimada";
            this.txt_duracionestimada.Pp_NombreTabla = "";
            this.txt_duracionestimada.Size = new System.Drawing.Size(131, 22);
            this.txt_duracionestimada.TabIndex = 6;
            // 
            // cmb_nomModelo
            // 
            this.cmb_nomModelo.FormattingEnabled = true;
            this.cmb_nomModelo.Location = new System.Drawing.Point(242, 132);
            this.cmb_nomModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_nomModelo.Name = "cmb_nomModelo";
            this.cmb_nomModelo.Pp_CampoAceptaNull = false;
            this.cmb_nomModelo.Pp_EsPk = false;
            this.cmb_nomModelo.Pp_MensajeError = "Seleccionar un modelo";
            this.cmb_nomModelo.Pp_NombreCampo = "nombre";
            this.cmb_nomModelo.Pp_NombreCampoInsert = "idModelo";
            this.cmb_nomModelo.Pp_NombreTabla = "modelo";
            this.cmb_nomModelo.Pp_PkTabla = "idModelo";
            this.cmb_nomModelo.Size = new System.Drawing.Size(160, 24);
            this.cmb_nomModelo.TabIndex = 7;
            this.cmb_nomModelo.SelectionChangeCommitted += new System.EventHandler(this.cmb_nomModelo_SelectionChangeCommitted);
            // 
            // cmb_numAvion
            // 
            this.cmb_numAvion.FormattingEnabled = true;
            this.cmb_numAvion.Location = new System.Drawing.Point(242, 167);
            this.cmb_numAvion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_numAvion.Name = "cmb_numAvion";
            this.cmb_numAvion.Pp_CampoAceptaNull = false;
            this.cmb_numAvion.Pp_EsPk = false;
            this.cmb_numAvion.Pp_MensajeError = "Seleccionar un avion";
            this.cmb_numAvion.Pp_NombreCampo = "numeroPorModelo";
            this.cmb_numAvion.Pp_NombreCampoInsert = "numeroPorModelo";
            this.cmb_numAvion.Pp_NombreTabla = "avion";
            this.cmb_numAvion.Pp_PkTabla = "numeroPorModelo";
            this.cmb_numAvion.Size = new System.Drawing.Size(160, 24);
            this.cmb_numAvion.TabIndex = 8;
            // 
            // cmb_AeropDestino
            // 
            this.cmb_AeropDestino.FormattingEnabled = true;
            this.cmb_AeropDestino.Location = new System.Drawing.Point(620, 164);
            this.cmb_AeropDestino.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_AeropDestino.Name = "cmb_AeropDestino";
            this.cmb_AeropDestino.Pp_CampoAceptaNull = false;
            this.cmb_AeropDestino.Pp_EsPk = false;
            this.cmb_AeropDestino.Pp_MensajeError = "Seleccionar un Aeropuerto de destino";
            this.cmb_AeropDestino.Pp_NombreCampo = "nombre";
            this.cmb_AeropDestino.Pp_NombreCampoInsert = "codigoAeropuertoDestino";
            this.cmb_AeropDestino.Pp_NombreTabla = "aeropuerto";
            this.cmb_AeropDestino.Pp_PkTabla = "codigo";
            this.cmb_AeropDestino.Size = new System.Drawing.Size(243, 24);
            this.cmb_AeropDestino.TabIndex = 9;
            // 
            // cmb_AeropSalida
            // 
            this.cmb_AeropSalida.FormattingEnabled = true;
            this.cmb_AeropSalida.Location = new System.Drawing.Point(620, 132);
            this.cmb_AeropSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmb_AeropSalida.Name = "cmb_AeropSalida";
            this.cmb_AeropSalida.Pp_CampoAceptaNull = false;
            this.cmb_AeropSalida.Pp_EsPk = false;
            this.cmb_AeropSalida.Pp_MensajeError = "Seleccionar un Aeropuerto de salida";
            this.cmb_AeropSalida.Pp_NombreCampo = "nombre";
            this.cmb_AeropSalida.Pp_NombreCampoInsert = "codigoAeropuertoSalida";
            this.cmb_AeropSalida.Pp_NombreTabla = "Aeropuerto";
            this.cmb_AeropSalida.Pp_PkTabla = "codigo";
            this.cmb_AeropSalida.Size = new System.Drawing.Size(243, 24);
            this.cmb_AeropSalida.TabIndex = 10;
            // 
            // btn_ModificacionVuelo
            // 
            this.btn_ModificacionVuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_ModificacionVuelo.Location = new System.Drawing.Point(302, 388);
            this.btn_ModificacionVuelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ModificacionVuelo.Name = "btn_ModificacionVuelo";
            this.btn_ModificacionVuelo.Pp_Presionado = false;
            this.btn_ModificacionVuelo.Size = new System.Drawing.Size(100, 28);
            this.btn_ModificacionVuelo.TabIndex = 11;
            this.btn_ModificacionVuelo.Text = "Aceptar";
            this.btn_ModificacionVuelo.UseVisualStyleBackColor = true;
            this.btn_ModificacionVuelo.Click += new System.EventHandler(this.btn_ModificacionVuelo_Click);
            // 
            // button_Aerolinea2
            // 
            this.button_Aerolinea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_Aerolinea2.Location = new System.Drawing.Point(448, 388);
            this.button_Aerolinea2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Aerolinea2.Name = "button_Aerolinea2";
            this.button_Aerolinea2.Pp_Presionado = false;
            this.button_Aerolinea2.Size = new System.Drawing.Size(100, 28);
            this.button_Aerolinea2.TabIndex = 12;
            this.button_Aerolinea2.Text = "Cancelar";
            this.button_Aerolinea2.UseVisualStyleBackColor = true;
            this.button_Aerolinea2.Click += new System.EventHandler(this.button_Aerolinea2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.Location = new System.Drawing.Point(111, 56);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Codigo del vuelo";
            // 
            // txt_idVuelo
            // 
            this.txt_idVuelo.Enabled = false;
            this.txt_idVuelo.Location = new System.Drawing.Point(251, 56);
            this.txt_idVuelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_idVuelo.Name = "txt_idVuelo";
            this.txt_idVuelo.Pp_EsPk = true;
            this.txt_idVuelo.Pp_MensajeError = null;
            this.txt_idVuelo.Pp_NombreCampo = "idVuelo";
            this.txt_idVuelo.Pp_NombreTabla = "Vuelo";
            this.txt_idVuelo.Size = new System.Drawing.Size(151, 22);
            this.txt_idVuelo.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(444, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Aeropuertos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(111, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Avión";
            // 
            // Frm_ModificarVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(999, 510);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_idVuelo);
            this.Controls.Add(this.label7);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label7;
        private Clase.TextBox_Aerolinea txt_idVuelo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}