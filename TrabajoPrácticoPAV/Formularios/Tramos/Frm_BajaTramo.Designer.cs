namespace TrabajoPrácticoPAV.Formularios.Tramos
{
    partial class Frm_BajaTramo
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
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.textBox_Aerolinea2 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.textBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_ASalida = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_ADestino = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.BarraSuperior.TabIndex = 46;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 27);
            this.label6.TabIndex = 4;
            this.label6.Text = "ELIMINAR TRAMO";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Cancelar.Location = new System.Drawing.Point(466, 305);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(117, 40);
            this.Btn_Cancelar.TabIndex = 41;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Eliminar.Location = new System.Drawing.Point(328, 305);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(117, 40);
            this.Btn_Eliminar.TabIndex = 40;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // textBox_Aerolinea2
            // 
            this.textBox_Aerolinea2.Enabled = false;
            this.textBox_Aerolinea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Aerolinea2.Location = new System.Drawing.Point(647, 249);
            this.textBox_Aerolinea2.Name = "textBox_Aerolinea2";
            this.textBox_Aerolinea2.Pp_EsPk = false;
            this.textBox_Aerolinea2.Pp_MensajeError = "Ingrese la duración del tramo";
            this.textBox_Aerolinea2.Pp_NombreCampo = "duracion";
            this.textBox_Aerolinea2.Pp_NombreTabla = "Tramo";
            this.textBox_Aerolinea2.Size = new System.Drawing.Size(183, 30);
            this.textBox_Aerolinea2.TabIndex = 39;
            // 
            // textBox_Aerolinea1
            // 
            this.textBox_Aerolinea1.Enabled = false;
            this.textBox_Aerolinea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_Aerolinea1.Location = new System.Drawing.Point(229, 247);
            this.textBox_Aerolinea1.Name = "textBox_Aerolinea1";
            this.textBox_Aerolinea1.Pp_EsPk = false;
            this.textBox_Aerolinea1.Pp_MensajeError = "Ingrese la distancia del tramo";
            this.textBox_Aerolinea1.Pp_NombreCampo = "distancia";
            this.textBox_Aerolinea1.Pp_NombreTabla = "Tramo";
            this.textBox_Aerolinea1.Size = new System.Drawing.Size(216, 30);
            this.textBox_Aerolinea1.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(461, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 25);
            this.label5.TabIndex = 45;
            this.label5.Text = "Duración estimada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(112, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Distancia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(0, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "Aeropuerto de destino:";
            // 
            // cmb_ASalida
            // 
            this.cmb_ASalida.Enabled = false;
            this.cmb_ASalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_ASalida.FormattingEnabled = true;
            this.cmb_ASalida.Location = new System.Drawing.Point(229, 106);
            this.cmb_ASalida.Name = "cmb_ASalida";
            this.cmb_ASalida.Pp_CampoAceptaNull = false;
            this.cmb_ASalida.Pp_EsPk = true;
            this.cmb_ASalida.Pp_MensajeError = "Ingrese el Aeropuerto de salida";
            this.cmb_ASalida.Pp_NombreCampo = "nombre";
            this.cmb_ASalida.Pp_NombreCampoInsert = "codigoAeropuertoSalida";
            this.cmb_ASalida.Pp_NombreTabla = "Aeropuerto";
            this.cmb_ASalida.Pp_PkTabla = "codigo";
            this.cmb_ASalida.Size = new System.Drawing.Size(601, 33);
            this.cmb_ASalida.TabIndex = 36;
            // 
            // cmb_ADestino
            // 
            this.cmb_ADestino.Enabled = false;
            this.cmb_ADestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_ADestino.FormattingEnabled = true;
            this.cmb_ADestino.Location = new System.Drawing.Point(229, 176);
            this.cmb_ADestino.Name = "cmb_ADestino";
            this.cmb_ADestino.Pp_CampoAceptaNull = false;
            this.cmb_ADestino.Pp_EsPk = true;
            this.cmb_ADestino.Pp_MensajeError = "Ingrese el Aeropuerto de destino";
            this.cmb_ADestino.Pp_NombreCampo = "nombre";
            this.cmb_ADestino.Pp_NombreCampoInsert = "codigoAeropuertoDestino";
            this.cmb_ADestino.Pp_NombreTabla = "Aeropuerto";
            this.cmb_ADestino.Pp_PkTabla = "codigo";
            this.cmb_ADestino.Size = new System.Drawing.Size(601, 33);
            this.cmb_ADestino.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Aeropuerto de salida:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(203, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "¿Está seguro que desea eliminar el siguiente tramo?";
            // 
            // Frm_BajaTramo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.textBox_Aerolinea2);
            this.Controls.Add(this.textBox_Aerolinea1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_ASalida);
            this.Controls.Add(this.cmb_ADestino);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BajaTramo";
            this.Text = "Frm_BajaTramo";
            this.Load += new System.EventHandler(this.Frm_BajaTramo_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private Clase.TextBox_Aerolinea textBox_Aerolinea2;
        private Clase.TextBox_Aerolinea textBox_Aerolinea1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Clase.ComboBox_Aerolinea cmb_ASalida;
        private Clase.ComboBox_Aerolinea cmb_ADestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}