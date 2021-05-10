namespace TrabajoPrácticoPAV.Formularios.Asientos
{
    partial class Frm_BajaAsiento
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
            this.txt_idasiento = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_registrarAsiento = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_estado = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_clase = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_numeroAvion = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_nombreModelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.SuspendLayout();
            // 
            // txt_idasiento
            // 
            this.txt_idasiento.Enabled = false;
            this.txt_idasiento.Location = new System.Drawing.Point(240, 57);
            this.txt_idasiento.Name = "txt_idasiento";
            this.txt_idasiento.Pp_EsPk = true;
            this.txt_idasiento.Pp_MensajeError = null;
            this.txt_idasiento.Pp_NombreCampo = "numeroAsiento";
            this.txt_idasiento.Pp_NombreTabla = "Asientos";
            this.txt_idasiento.Size = new System.Drawing.Size(121, 20);
            this.txt_idasiento.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(128, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Codigo del Asiento";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(342, 253);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 31;
            this.btn_cerrar.Text = "Cancelar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_registrarAsiento
            // 
            this.btn_registrarAsiento.Location = new System.Drawing.Point(261, 253);
            this.btn_registrarAsiento.Name = "btn_registrarAsiento";
            this.btn_registrarAsiento.Pp_Presionado = false;
            this.btn_registrarAsiento.Size = new System.Drawing.Size(75, 23);
            this.btn_registrarAsiento.TabIndex = 30;
            this.btn_registrarAsiento.Text = "Borrar";
            this.btn_registrarAsiento.UseVisualStyleBackColor = true;
            this.btn_registrarAsiento.Click += new System.EventHandler(this.btn_registrarAsiento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(128, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Estado del Asiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(128, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Clase del avión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(128, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Numero del avión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(125, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Modelo del Avión";
            // 
            // txt_estado
            // 
            this.txt_estado.Enabled = false;
            this.txt_estado.Location = new System.Drawing.Point(237, 178);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Pp_EsPk = false;
            this.txt_estado.Pp_MensajeError = "Ingrese el estado del asiento";
            this.txt_estado.Pp_NombreCampo = "estado";
            this.txt_estado.Pp_NombreTabla = "Asientos";
            this.txt_estado.Size = new System.Drawing.Size(121, 20);
            this.txt_estado.TabIndex = 25;
            // 
            // cmb_clase
            // 
            this.cmb_clase.Enabled = false;
            this.cmb_clase.FormattingEnabled = true;
            this.cmb_clase.Location = new System.Drawing.Point(237, 150);
            this.cmb_clase.Name = "cmb_clase";
            this.cmb_clase.Pp_CampoAceptaNull = false;
            this.cmb_clase.Pp_EsPk = false;
            this.cmb_clase.Pp_MensajeError = "Seleccione la clase del asiento";
            this.cmb_clase.Pp_NombreCampo = "nombre";
            this.cmb_clase.Pp_NombreCampoInsert = "tipoAsiento";
            this.cmb_clase.Pp_NombreTabla = "Tipo_Asiento";
            this.cmb_clase.Pp_PkTabla = "idTipo";
            this.cmb_clase.Size = new System.Drawing.Size(121, 21);
            this.cmb_clase.TabIndex = 24;
            // 
            // cmb_numeroAvion
            // 
            this.cmb_numeroAvion.Enabled = false;
            this.cmb_numeroAvion.FormattingEnabled = true;
            this.cmb_numeroAvion.Location = new System.Drawing.Point(237, 122);
            this.cmb_numeroAvion.Name = "cmb_numeroAvion";
            this.cmb_numeroAvion.Pp_CampoAceptaNull = true;
            this.cmb_numeroAvion.Pp_EsPk = false;
            this.cmb_numeroAvion.Pp_MensajeError = "Seleccione el numero del avion";
            this.cmb_numeroAvion.Pp_NombreCampo = "numeroPorModelo";
            this.cmb_numeroAvion.Pp_NombreCampoInsert = "numeroPorModelo";
            this.cmb_numeroAvion.Pp_NombreTabla = "avion";
            this.cmb_numeroAvion.Pp_PkTabla = "numeroPorModelo";
            this.cmb_numeroAvion.Size = new System.Drawing.Size(121, 21);
            this.cmb_numeroAvion.TabIndex = 23;
            // 
            // cmb_nombreModelo
            // 
            this.cmb_nombreModelo.Enabled = false;
            this.cmb_nombreModelo.FormattingEnabled = true;
            this.cmb_nombreModelo.Location = new System.Drawing.Point(237, 94);
            this.cmb_nombreModelo.Name = "cmb_nombreModelo";
            this.cmb_nombreModelo.Pp_CampoAceptaNull = true;
            this.cmb_nombreModelo.Pp_EsPk = false;
            this.cmb_nombreModelo.Pp_MensajeError = "Seleccione el modelo del avion";
            this.cmb_nombreModelo.Pp_NombreCampo = "nombre";
            this.cmb_nombreModelo.Pp_NombreCampoInsert = "idModelo";
            this.cmb_nombreModelo.Pp_NombreTabla = "modelo";
            this.cmb_nombreModelo.Pp_PkTabla = "idModelo";
            this.cmb_nombreModelo.Size = new System.Drawing.Size(121, 21);
            this.cmb_nombreModelo.TabIndex = 22;
            // 
            // Frm_BajaAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(658, 303);
            this.Controls.Add(this.txt_idasiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_registrarAsiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_estado);
            this.Controls.Add(this.cmb_clase);
            this.Controls.Add(this.cmb_numeroAvion);
            this.Controls.Add(this.cmb_nombreModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BajaAsiento";
            this.Text = "Frm_BajaAsiento";
            this.Load += new System.EventHandler(this.Frm_BajaAsiento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.TextBox_Aerolinea txt_idasiento;
        private System.Windows.Forms.Label label5;
        private Clase.Button_Aerolinea btn_cerrar;
        private Clase.Button_Aerolinea btn_registrarAsiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clase.TextBox_Aerolinea txt_estado;
        private Clase.ComboBox_Aerolinea cmb_clase;
        private Clase.ComboBox_Aerolinea cmb_numeroAvion;
        private Clase.ComboBox_Aerolinea cmb_nombreModelo;
    }
}