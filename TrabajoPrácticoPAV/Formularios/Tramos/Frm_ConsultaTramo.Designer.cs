namespace TrabajoPrácticoPAV.Formularios.Tramos
{
    partial class Frm_ConsultaTramo
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
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.textBox_Aerolinea2 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.textBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_ASalida = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_ADestino = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Aceptar.FlatAppearance.BorderSize = 0;
            this.Btn_Aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Aceptar.Location = new System.Drawing.Point(392, 272);
            this.Btn_Aceptar.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(100, 40);
            this.Btn_Aceptar.TabIndex = 53;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = false;
            this.Btn_Aceptar.Click += new System.EventHandler(this.Btn_Aceptar_Click);
            // 
            // textBox_Aerolinea2
            // 
            this.textBox_Aerolinea2.Enabled = false;
            this.textBox_Aerolinea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Aerolinea2.Location = new System.Drawing.Point(653, 216);
            this.textBox_Aerolinea2.Name = "textBox_Aerolinea2";
            this.textBox_Aerolinea2.Pp_EsPk = false;
            this.textBox_Aerolinea2.Pp_MensajeError = "Ingrese la duración del tramo";
            this.textBox_Aerolinea2.Pp_NombreCampo = "duracion";
            this.textBox_Aerolinea2.Pp_NombreTabla = "Tramo";
            this.textBox_Aerolinea2.Size = new System.Drawing.Size(183, 30);
            this.textBox_Aerolinea2.TabIndex = 51;
            // 
            // textBox_Aerolinea1
            // 
            this.textBox_Aerolinea1.Enabled = false;
            this.textBox_Aerolinea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Aerolinea1.Location = new System.Drawing.Point(235, 214);
            this.textBox_Aerolinea1.Name = "textBox_Aerolinea1";
            this.textBox_Aerolinea1.Pp_EsPk = false;
            this.textBox_Aerolinea1.Pp_MensajeError = "Ingrese la distancia del tramo";
            this.textBox_Aerolinea1.Pp_NombreCampo = "distancia";
            this.textBox_Aerolinea1.Pp_NombreTabla = "Tramo";
            this.textBox_Aerolinea1.Size = new System.Drawing.Size(216, 30);
            this.textBox_Aerolinea1.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(467, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 57;
            this.label5.Text = "Duración estimada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(112, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Distancia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(0, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 55;
            this.label4.Text = "Aeropuerto de destino:";
            // 
            // cmb_ASalida
            // 
            this.cmb_ASalida.Enabled = false;
            this.cmb_ASalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_ASalida.FormattingEnabled = true;
            this.cmb_ASalida.Location = new System.Drawing.Point(235, 73);
            this.cmb_ASalida.Name = "cmb_ASalida";
            this.cmb_ASalida.Pp_CampoAceptaNull = false;
            this.cmb_ASalida.Pp_EsPk = true;
            this.cmb_ASalida.Pp_MensajeError = "Ingrese el Aeropuerto de salida";
            this.cmb_ASalida.Pp_NombreCampo = "nombre";
            this.cmb_ASalida.Pp_NombreCampoInsert = "codigoAeropuertoSalida";
            this.cmb_ASalida.Pp_NombreTabla = "Aeropuerto";
            this.cmb_ASalida.Pp_PkTabla = "codigo";
            this.cmb_ASalida.Size = new System.Drawing.Size(601, 33);
            this.cmb_ASalida.TabIndex = 48;
            // 
            // cmb_ADestino
            // 
            this.cmb_ADestino.Enabled = false;
            this.cmb_ADestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_ADestino.FormattingEnabled = true;
            this.cmb_ADestino.Location = new System.Drawing.Point(235, 143);
            this.cmb_ADestino.Name = "cmb_ADestino";
            this.cmb_ADestino.Pp_CampoAceptaNull = false;
            this.cmb_ADestino.Pp_EsPk = true;
            this.cmb_ADestino.Pp_MensajeError = "Ingrese el Aeropuerto de destino";
            this.cmb_ADestino.Pp_NombreCampo = "nombre";
            this.cmb_ADestino.Pp_NombreCampoInsert = "codigoAeropuertoDestino";
            this.cmb_ADestino.Pp_NombreTabla = "Aeropuerto";
            this.cmb_ADestino.Pp_PkTabla = "codigo";
            this.cmb_ADestino.Size = new System.Drawing.Size(601, 33);
            this.cmb_ADestino.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 54;
            this.label3.Text = "Aeropuerto de salida:";
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.label6);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(871, 39);
            this.BarraSuperior.TabIndex = 59;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "DETALLES TRAMO";
            // 
            // Frm_ConsultaTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 339);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.textBox_Aerolinea2);
            this.Controls.Add(this.textBox_Aerolinea1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_ASalida);
            this.Controls.Add(this.cmb_ADestino);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ConsultaTramo";
            this.Text = "Frm_ConsultaTramo";
            this.Load += new System.EventHandler(this.Frm_ConsultaTramo_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Aceptar;
        private Clase.TextBox_Aerolinea textBox_Aerolinea2;
        private Clase.TextBox_Aerolinea textBox_Aerolinea1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Clase.ComboBox_Aerolinea cmb_ASalida;
        private Clase.ComboBox_Aerolinea cmb_ADestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label label6;
    }
}