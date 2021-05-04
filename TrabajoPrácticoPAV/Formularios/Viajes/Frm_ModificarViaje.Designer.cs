
namespace TrabajoPrácticoPAV.Formularios.Viajes
{
    partial class Frm_ModificarViaje
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
            this.cmb_numero_viaje = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.mtb_presencia = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.mtb_llegada = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.mtb_salida = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.lbl_duracionEstimada = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Viaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Horario de Presencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Numero de Viaje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Horario de Salida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Horario de Llegada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Duración Estimada";
            // 
            // cmb_numero_viaje
            // 
            this.cmb_numero_viaje.FormattingEnabled = true;
            this.cmb_numero_viaje.Location = new System.Drawing.Point(201, 59);
            this.cmb_numero_viaje.Name = "cmb_numero_viaje";
            this.cmb_numero_viaje.Pp_CampoAceptaNull = false;
            this.cmb_numero_viaje.Pp_MensajeError = "Seleccionar un campo";
            this.cmb_numero_viaje.Pp_NombreCampo = "numeroDeViaje";
            this.cmb_numero_viaje.Pp_NombreMora = null;
            this.cmb_numero_viaje.Pp_NombreTabla = "Viaje";
            this.cmb_numero_viaje.Pp_PkTabla = "numeroDeViaje";
            this.cmb_numero_viaje.Size = new System.Drawing.Size(88, 21);
            this.cmb_numero_viaje.TabIndex = 6;
            this.cmb_numero_viaje.SelectedIndexChanged += new System.EventHandler(this.numero_viaje_SelectedIndexChanged);
            // 
            // mtb_presencia
            // 
            this.mtb_presencia.Location = new System.Drawing.Point(225, 90);
            this.mtb_presencia.Mask = "00:00";
            this.mtb_presencia.Name = "mtb_presencia";
            this.mtb_presencia.Pp_NombreCampo = null;
            this.mtb_presencia.Pp_NombreTabla = null;
            this.mtb_presencia.Size = new System.Drawing.Size(34, 20);
            this.mtb_presencia.TabIndex = 7;
            this.mtb_presencia.ValidatingType = typeof(System.DateTime);
            // 
            // mtb_llegada
            // 
            this.mtb_llegada.Location = new System.Drawing.Point(225, 153);
            this.mtb_llegada.Mask = "00:00";
            this.mtb_llegada.Name = "mtb_llegada";
            this.mtb_llegada.Pp_NombreCampo = null;
            this.mtb_llegada.Pp_NombreTabla = null;
            this.mtb_llegada.Size = new System.Drawing.Size(34, 20);
            this.mtb_llegada.TabIndex = 8;
            this.mtb_llegada.ValidatingType = typeof(System.DateTime);
            this.mtb_llegada.TextChanged += new System.EventHandler(this.mtb_llegada_TextChanged);
            // 
            // mtb_salida
            // 
            this.mtb_salida.Location = new System.Drawing.Point(225, 122);
            this.mtb_salida.Mask = "00:00";
            this.mtb_salida.Name = "mtb_salida";
            this.mtb_salida.Pp_NombreCampo = null;
            this.mtb_salida.Pp_NombreTabla = null;
            this.mtb_salida.Size = new System.Drawing.Size(34, 20);
            this.mtb_salida.TabIndex = 9;
            this.mtb_salida.ValidatingType = typeof(System.DateTime);
            this.mtb_salida.TextChanged += new System.EventHandler(this.mtb_salida_TextChanged);
            // 
            // lbl_duracionEstimada
            // 
            this.lbl_duracionEstimada.AutoSize = true;
            this.lbl_duracionEstimada.Location = new System.Drawing.Point(225, 184);
            this.lbl_duracionEstimada.Name = "lbl_duracionEstimada";
            this.lbl_duracionEstimada.Size = new System.Drawing.Size(25, 13);
            this.lbl_duracionEstimada.TabIndex = 10;
            this.lbl_duracionEstimada.Text = "???";
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(184, 271);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 11;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(93, 271);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Frm_ModificarViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(782, 354);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.lbl_duracionEstimada);
            this.Controls.Add(this.mtb_salida);
            this.Controls.Add(this.mtb_llegada);
            this.Controls.Add(this.mtb_presencia);
            this.Controls.Add(this.cmb_numero_viaje);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_ModificarViaje";
            this.Text = "Frm_ModificarViaje";
            this.Load += new System.EventHandler(this.Frm_ModificarViaje_Load);
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
        private Clase.ComboBox_Aerolinea cmb_numero_viaje;
        private Clase.MaskedTextBox_Aerolinea mtb_presencia;
        private Clase.MaskedTextBox_Aerolinea mtb_llegada;
        private Clase.MaskedTextBox_Aerolinea mtb_salida;
        private System.Windows.Forms.Label lbl_duracionEstimada;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}