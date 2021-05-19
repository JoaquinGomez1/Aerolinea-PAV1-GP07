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
            this.label6 = new System.Windows.Forms.Label();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.cmb_nomModelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_Cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_numAvion = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_AeropDestino = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_AeropSalida = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Registrar Vuelo";
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(591, 39);
            this.BarraSuperior.TabIndex = 50;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(12, 7);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(281, 27);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "REGISTRAR NUEVO VUELO";
            // 
            // cmb_nomModelo
            // 
            this.cmb_nomModelo.FormattingEnabled = true;
            this.cmb_nomModelo.Location = new System.Drawing.Point(268, 69);
            this.cmb_nomModelo.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_nomModelo.Name = "cmb_nomModelo";
            this.cmb_nomModelo.Pp_CampoAceptaNull = true;
            this.cmb_nomModelo.Pp_EsPk = false;
            this.cmb_nomModelo.Pp_MensajeError = "Seleccione un modelo";
            this.cmb_nomModelo.Pp_NombreCampo = "nombre";
            this.cmb_nomModelo.Pp_NombreCampoInsert = "idModelo";
            this.cmb_nomModelo.Pp_NombreTabla = "modelo";
            this.cmb_nomModelo.Pp_PkTabla = "idModelo";
            this.cmb_nomModelo.Size = new System.Drawing.Size(243, 24);
            this.cmb_nomModelo.TabIndex = 53;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_Cancelar.Location = new System.Drawing.Point(316, 234);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Pp_Presionado = false;
            this.btn_Cancelar.Size = new System.Drawing.Size(124, 36);
            this.btn_Cancelar.TabIndex = 61;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(176, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 55;
            this.label3.Text = "Modelo";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_Registrar.Location = new System.Drawing.Point(112, 234);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Pp_Presionado = false;
            this.btn_Registrar.Size = new System.Drawing.Size(124, 36);
            this.btn_Registrar.TabIndex = 60;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(125, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Número Avión";
            // 
            // cmb_numAvion
            // 
            this.cmb_numAvion.FormattingEnabled = true;
            this.cmb_numAvion.Location = new System.Drawing.Point(268, 102);
            this.cmb_numAvion.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_numAvion.Name = "cmb_numAvion";
            this.cmb_numAvion.Pp_CampoAceptaNull = true;
            this.cmb_numAvion.Pp_EsPk = false;
            this.cmb_numAvion.Pp_MensajeError = "Seleccione un Numero de Avion";
            this.cmb_numAvion.Pp_NombreCampo = "numeroPorModelo";
            this.cmb_numAvion.Pp_NombreCampoInsert = "numeroPorModelo";
            this.cmb_numAvion.Pp_NombreTabla = "avion";
            this.cmb_numAvion.Pp_PkTabla = "numeroPorModelo";
            this.cmb_numAvion.Size = new System.Drawing.Size(243, 24);
            this.cmb_numAvion.TabIndex = 52;
            // 
            // cmb_AeropDestino
            // 
            this.cmb_AeropDestino.FormattingEnabled = true;
            this.cmb_AeropDestino.Location = new System.Drawing.Point(268, 173);
            this.cmb_AeropDestino.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_AeropDestino.Name = "cmb_AeropDestino";
            this.cmb_AeropDestino.Pp_CampoAceptaNull = true;
            this.cmb_AeropDestino.Pp_EsPk = false;
            this.cmb_AeropDestino.Pp_MensajeError = "Seleccione Aeropuerto destino";
            this.cmb_AeropDestino.Pp_NombreCampo = "nombre";
            this.cmb_AeropDestino.Pp_NombreCampoInsert = "codigoAeropuertoDestino";
            this.cmb_AeropDestino.Pp_NombreTabla = "aeropuerto";
            this.cmb_AeropDestino.Pp_PkTabla = "codigo";
            this.cmb_AeropDestino.Size = new System.Drawing.Size(243, 24);
            this.cmb_AeropDestino.TabIndex = 58;
            // 
            // cmb_AeropSalida
            // 
            this.cmb_AeropSalida.FormattingEnabled = true;
            this.cmb_AeropSalida.Location = new System.Drawing.Point(268, 139);
            this.cmb_AeropSalida.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_AeropSalida.Name = "cmb_AeropSalida";
            this.cmb_AeropSalida.Pp_CampoAceptaNull = true;
            this.cmb_AeropSalida.Pp_EsPk = false;
            this.cmb_AeropSalida.Pp_MensajeError = "Seleccione Aeropuerto de Salida";
            this.cmb_AeropSalida.Pp_NombreCampo = "nombre";
            this.cmb_AeropSalida.Pp_NombreCampoInsert = "codigoAeropuertoSalida";
            this.cmb_AeropSalida.Pp_NombreTabla = "aeropuerto";
            this.cmb_AeropSalida.Pp_PkTabla = "codigo";
            this.cmb_AeropSalida.Size = new System.Drawing.Size(243, 24);
            this.cmb_AeropSalida.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(97, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 57;
            this.label5.Text = "Aeropuerto Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(85, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Aeropuerto Destino";
            // 
            // Frm_AltaVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(591, 298);
            this.Controls.Add(this.cmb_nomModelo);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_numAvion);
            this.Controls.Add(this.cmb_AeropDestino);
            this.Controls.Add(this.cmb_AeropSalida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AltaVuelo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AltaVuelo";
            this.Load += new System.EventHandler(this.Frm_AltaVuelo_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
        private Clase.ComboBox_Aerolinea cmb_nomModelo;
        private Clase.Button_Aerolinea btn_Cancelar;
        private System.Windows.Forms.Label label3;
        private Clase.Button_Aerolinea btn_Registrar;
        private System.Windows.Forms.Label label2;
        private Clase.ComboBox_Aerolinea cmb_numAvion;
        private Clase.ComboBox_Aerolinea cmb_AeropDestino;
        private Clase.ComboBox_Aerolinea cmb_AeropSalida;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}