namespace TrabajoPrácticoPAV.Formularios.Listados.Tramos_por_viaje
{
    partial class Frm_ReporteViajeXTramo
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
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_Todos = new System.Windows.Forms.RadioButton();
            this.rb_AeroDestino = new System.Windows.Forms.RadioButton();
            this.rb_NumViaje = new System.Windows.Forms.RadioButton();
            this.rbr_AeroSalida = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rpv_Viajextramo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Hasta = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Txt_Desde = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.btn_calcular = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.cmb_aeropuertoDestino = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_aeropuertoSalida = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(89, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Número de viaje";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_Todos);
            this.groupBox3.Controls.Add(this.rb_AeroDestino);
            this.groupBox3.Controls.Add(this.rb_NumViaje);
            this.groupBox3.Controls.Add(this.rbr_AeroSalida);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox3.Location = new System.Drawing.Point(548, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 154);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo Cálculo";
            // 
            // rb_Todos
            // 
            this.rb_Todos.AutoSize = true;
            this.rb_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_Todos.Location = new System.Drawing.Point(6, 114);
            this.rb_Todos.Name = "rb_Todos";
            this.rb_Todos.Size = new System.Drawing.Size(89, 29);
            this.rb_Todos.TabIndex = 0;
            this.rb_Todos.TabStop = true;
            this.rb_Todos.Text = "Todos";
            this.rb_Todos.UseVisualStyleBackColor = true;
            // 
            // rb_AeroDestino
            // 
            this.rb_AeroDestino.AutoSize = true;
            this.rb_AeroDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_AeroDestino.Location = new System.Drawing.Point(6, 85);
            this.rb_AeroDestino.Name = "rb_AeroDestino";
            this.rb_AeroDestino.Size = new System.Drawing.Size(321, 29);
            this.rb_AeroDestino.TabIndex = 0;
            this.rb_AeroDestino.TabStop = true;
            this.rb_AeroDestino.Text = "Buscar por aeropuerto de destino";
            this.rb_AeroDestino.UseVisualStyleBackColor = true;
            // 
            // rb_NumViaje
            // 
            this.rb_NumViaje.AutoSize = true;
            this.rb_NumViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_NumViaje.Location = new System.Drawing.Point(6, 27);
            this.rb_NumViaje.Name = "rb_NumViaje";
            this.rb_NumViaje.Size = new System.Drawing.Size(206, 29);
            this.rb_NumViaje.TabIndex = 0;
            this.rb_NumViaje.TabStop = true;
            this.rb_NumViaje.Text = "Por número de viaje";
            this.rb_NumViaje.UseVisualStyleBackColor = true;
            // 
            // rbr_AeroSalida
            // 
            this.rbr_AeroSalida.AutoSize = true;
            this.rbr_AeroSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rbr_AeroSalida.Location = new System.Drawing.Point(6, 56);
            this.rbr_AeroSalida.Name = "rbr_AeroSalida";
            this.rbr_AeroSalida.Size = new System.Drawing.Size(309, 29);
            this.rbr_AeroSalida.TabIndex = 0;
            this.rbr_AeroSalida.TabStop = true;
            this.rbr_AeroSalida.Text = "Buscar por aeropuerto de salida";
            this.rbr_AeroSalida.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(38, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Aeropuerto de destino";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(50, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Aeropuerto de salida";
            // 
            // rpv_Viajextramo
            // 
            this.rpv_Viajextramo.Location = new System.Drawing.Point(12, 237);
            this.rpv_Viajextramo.Name = "rpv_Viajextramo";
            this.rpv_Viajextramo.ServerReport.BearerToken = null;
            this.rpv_Viajextramo.Size = new System.Drawing.Size(971, 266);
            this.rpv_Viajextramo.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(374, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 36);
            this.label5.TabIndex = 51;
            this.label5.Text = "-";
            // 
            // Txt_Hasta
            // 
            this.Txt_Hasta.Location = new System.Drawing.Point(408, 42);
            this.Txt_Hasta.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Hasta.Name = "Txt_Hasta";
            this.Txt_Hasta.Pp_EsPk = false;
            this.Txt_Hasta.Pp_MensajeError = null;
            this.Txt_Hasta.Pp_NombreCampo = "codigo";
            this.Txt_Hasta.Pp_NombreTabla = "aeropuerto";
            this.Txt_Hasta.Size = new System.Drawing.Size(74, 22);
            this.Txt_Hasta.TabIndex = 50;
            // 
            // Txt_Desde
            // 
            this.Txt_Desde.Location = new System.Drawing.Point(288, 42);
            this.Txt_Desde.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Desde.Name = "Txt_Desde";
            this.Txt_Desde.Pp_EsPk = false;
            this.Txt_Desde.Pp_MensajeError = null;
            this.Txt_Desde.Pp_NombreCampo = "codigo";
            this.Txt_Desde.Pp_NombreTabla = "aeropuerto";
            this.Txt_Desde.Size = new System.Drawing.Size(80, 22);
            this.Txt_Desde.TabIndex = 49;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_calcular.Location = new System.Drawing.Point(694, 187);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Pp_Presionado = false;
            this.btn_calcular.Size = new System.Drawing.Size(169, 31);
            this.btn_calcular.TabIndex = 14;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // cmb_aeropuertoDestino
            // 
            this.cmb_aeropuertoDestino.FormattingEnabled = true;
            this.cmb_aeropuertoDestino.Location = new System.Drawing.Point(288, 117);
            this.cmb_aeropuertoDestino.Name = "cmb_aeropuertoDestino";
            this.cmb_aeropuertoDestino.Pp_CampoAceptaNull = true;
            this.cmb_aeropuertoDestino.Pp_EsPk = false;
            this.cmb_aeropuertoDestino.Pp_MensajeError = null;
            this.cmb_aeropuertoDestino.Pp_NombreCampo = "nombre";
            this.cmb_aeropuertoDestino.Pp_NombreCampoInsert = null;
            this.cmb_aeropuertoDestino.Pp_NombreTabla = "Aeropuerto";
            this.cmb_aeropuertoDestino.Pp_PkTabla = "codigo";
            this.cmb_aeropuertoDestino.Size = new System.Drawing.Size(194, 24);
            this.cmb_aeropuertoDestino.TabIndex = 13;
            // 
            // cmb_aeropuertoSalida
            // 
            this.cmb_aeropuertoSalida.FormattingEnabled = true;
            this.cmb_aeropuertoSalida.Location = new System.Drawing.Point(288, 77);
            this.cmb_aeropuertoSalida.Name = "cmb_aeropuertoSalida";
            this.cmb_aeropuertoSalida.Pp_CampoAceptaNull = true;
            this.cmb_aeropuertoSalida.Pp_EsPk = false;
            this.cmb_aeropuertoSalida.Pp_MensajeError = null;
            this.cmb_aeropuertoSalida.Pp_NombreCampo = "nombre";
            this.cmb_aeropuertoSalida.Pp_NombreCampoInsert = null;
            this.cmb_aeropuertoSalida.Pp_NombreTabla = "Aeropuerto";
            this.cmb_aeropuertoSalida.Pp_PkTabla = "codigo";
            this.cmb_aeropuertoSalida.Size = new System.Drawing.Size(194, 24);
            this.cmb_aeropuertoSalida.TabIndex = 12;
            // 
            // Frm_ReporteViajeXTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 563);
            this.ControlBox = false;
            this.Controls.Add(this.Txt_Hasta);
            this.Controls.Add(this.Txt_Desde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.cmb_aeropuertoDestino);
            this.Controls.Add(this.cmb_aeropuertoSalida);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rpv_Viajextramo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ReporteViajeXTramo";
            this.Text = "Frm_ReporteViajeXTramo";
            this.Load += new System.EventHandler(this.Frm_ReporteViajeXTramo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private Clase.Button_Aerolinea btn_calcular;
        private Clase.ComboBox_Aerolinea cmb_aeropuertoDestino;
        private Clase.ComboBox_Aerolinea cmb_aeropuertoSalida;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_Todos;
        private System.Windows.Forms.RadioButton rb_AeroDestino;
        private System.Windows.Forms.RadioButton rb_NumViaje;
        private System.Windows.Forms.RadioButton rbr_AeroSalida;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private Microsoft.Reporting.WinForms.ReportViewer rpv_Viajextramo;
        private Clase.TextBox_Aerolinea Txt_Hasta;
        private Clase.TextBox_Aerolinea Txt_Desde;
        private System.Windows.Forms.Label label5;
    }
}