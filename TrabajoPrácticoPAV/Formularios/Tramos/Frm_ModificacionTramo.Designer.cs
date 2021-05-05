namespace TrabajoPrácticoPAV.Formularios.Tramos
{
    partial class Frm_ModificacionTramo
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
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Aerolinea2 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.textBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_ASalida = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_ADestino = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.label6);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(855, 39);
            this.BarraSuperior.TabIndex = 35;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "MODIFICAR TRAMO";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Cancelar.Location = new System.Drawing.Point(480, 270);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(117, 40);
            this.Btn_Cancelar.TabIndex = 30;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Modificar.FlatAppearance.BorderSize = 0;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Modificar.Location = new System.Drawing.Point(330, 270);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(117, 40);
            this.Btn_Modificar.TabIndex = 29;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(458, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Duración estimada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(112, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Distancia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(0, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Aeropuerto de destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Aeropuerto de salida:";
            // 
            // textBox_Aerolinea2
            // 
            this.textBox_Aerolinea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Aerolinea2.Location = new System.Drawing.Point(644, 214);
            this.textBox_Aerolinea2.Name = "textBox_Aerolinea2";
            this.textBox_Aerolinea2.Pp_EsPk = false;
            this.textBox_Aerolinea2.Pp_MensajeError = "Ingrese la duración del tramo";
            this.textBox_Aerolinea2.Pp_NombreCampo = "duracion";
            this.textBox_Aerolinea2.Pp_NombreTabla = "Tramo";
            this.textBox_Aerolinea2.Size = new System.Drawing.Size(183, 30);
            this.textBox_Aerolinea2.TabIndex = 28;
            // 
            // textBox_Aerolinea1
            // 
            this.textBox_Aerolinea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Aerolinea1.Location = new System.Drawing.Point(226, 212);
            this.textBox_Aerolinea1.Name = "textBox_Aerolinea1";
            this.textBox_Aerolinea1.Pp_EsPk = false;
            this.textBox_Aerolinea1.Pp_MensajeError = "Ingrese la distancia del tramo";
            this.textBox_Aerolinea1.Pp_NombreCampo = "distancia";
            this.textBox_Aerolinea1.Pp_NombreTabla = "Tramo";
            this.textBox_Aerolinea1.Size = new System.Drawing.Size(216, 30);
            this.textBox_Aerolinea1.TabIndex = 27;
            // 
            // cmb_ASalida
            // 
            this.cmb_ASalida.Enabled = false;
            this.cmb_ASalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_ASalida.FormattingEnabled = true;
            this.cmb_ASalida.Location = new System.Drawing.Point(226, 71);
            this.cmb_ASalida.Name = "cmb_ASalida";
            this.cmb_ASalida.Pp_CampoAceptaNull = false;
            this.cmb_ASalida.Pp_EsPk = true;
            this.cmb_ASalida.Pp_MensajeError = "Ingrese el Aeropuerto de salida";
            this.cmb_ASalida.Pp_NombreCampo = "nombre";
            this.cmb_ASalida.Pp_NombreCampoInsert = "codigoAeropuertoSalida";
            this.cmb_ASalida.Pp_NombreTabla = "Aeropuerto";
            this.cmb_ASalida.Pp_PkTabla = "codigo";
            this.cmb_ASalida.Size = new System.Drawing.Size(601, 33);
            this.cmb_ASalida.TabIndex = 25;
            // 
            // cmb_ADestino
            // 
            this.cmb_ADestino.Enabled = false;
            this.cmb_ADestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_ADestino.FormattingEnabled = true;
            this.cmb_ADestino.Location = new System.Drawing.Point(226, 141);
            this.cmb_ADestino.Name = "cmb_ADestino";
            this.cmb_ADestino.Pp_CampoAceptaNull = false;
            this.cmb_ADestino.Pp_EsPk = true;
            this.cmb_ADestino.Pp_MensajeError = "Ingrese el Aeropuerto de destino";
            this.cmb_ADestino.Pp_NombreCampo = "nombre";
            this.cmb_ADestino.Pp_NombreCampoInsert = "codigoAeropuertoDestino";
            this.cmb_ADestino.Pp_NombreTabla = "Aeropuerto";
            this.cmb_ADestino.Pp_PkTabla = "codigo";
            this.cmb_ADestino.Size = new System.Drawing.Size(601, 33);
            this.cmb_ADestino.TabIndex = 26;
            // 
            // Frm_ModificacionTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 339);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.textBox_Aerolinea2);
            this.Controls.Add(this.textBox_Aerolinea1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_ASalida);
            this.Controls.Add(this.cmb_ADestino);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ModificacionTramo";
            this.Text = "Frm_ModificacionTramo";
            this.Load += new System.EventHandler(this.Frm_ModificacionTramo_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Modificar;
        private Clase.TextBox_Aerolinea textBox_Aerolinea2;
        private Clase.TextBox_Aerolinea textBox_Aerolinea1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Clase.ComboBox_Aerolinea cmb_ASalida;
        private Clase.ComboBox_Aerolinea cmb_ADestino;
        private System.Windows.Forms.Label label3;
    }
}