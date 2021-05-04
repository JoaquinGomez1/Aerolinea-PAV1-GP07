namespace TrabajoPrácticoPAV.Formularios
{
    partial class Frm_ABMVuelo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.Cmb_Nromodelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_Tramo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_Nroavion = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.textBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.textBox_Aerolinea2 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(100, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código del Vuelo ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(72, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Duracion Estimada ??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(111, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(170, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tramo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(122, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Número Avion";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_registrar.Location = new System.Drawing.Point(264, 343);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(90, 28);
            this.btn_registrar.TabIndex = 12;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cancelar.Location = new System.Drawing.Point(360, 343);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 28);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Cmb_Nromodelo
            // 
            this.Cmb_Nromodelo.FormattingEnabled = true;
            this.Cmb_Nromodelo.Location = new System.Drawing.Point(225, 147);
            this.Cmb_Nromodelo.Name = "Cmb_Nromodelo";
            this.Cmb_Nromodelo.Pp_CampoAceptaNull = true;
            this.Cmb_Nromodelo.Pp_MensajeError = "linea3";
            this.Cmb_Nromodelo.Pp_NombreCampo = "idModelo";
            this.Cmb_Nromodelo.Pp_NombreTabla = "modelo";
            this.Cmb_Nromodelo.Pp_PkTabla = "idModelo";
            this.Cmb_Nromodelo.Size = new System.Drawing.Size(121, 21);
            this.Cmb_Nromodelo.TabIndex = 12;
            // 
            // cmb_Tramo
            // 
            this.cmb_Tramo.FormattingEnabled = true;
            this.cmb_Tramo.Location = new System.Drawing.Point(225, 225);
            this.cmb_Tramo.Name = "cmb_Tramo";
            this.cmb_Tramo.Pp_CampoAceptaNull = true;
            this.cmb_Tramo.Pp_MensajeError = "linea5";
            this.cmb_Tramo.Pp_NombreCampo = "idTramo";
            this.cmb_Tramo.Pp_NombreTabla = "Tramo";
            this.cmb_Tramo.Pp_PkTabla = "idTramo";
            this.cmb_Tramo.Size = new System.Drawing.Size(121, 21);
            this.cmb_Tramo.TabIndex = 14;
            // 
            // cmb_Nroavion
            // 
            this.cmb_Nroavion.FormattingEnabled = true;
            this.cmb_Nroavion.Location = new System.Drawing.Point(225, 184);
            this.cmb_Nroavion.Name = "cmb_Nroavion";
            this.cmb_Nroavion.Pp_CampoAceptaNull = true;
            this.cmb_Nroavion.Pp_MensajeError = "linea4";
            this.cmb_Nroavion.Pp_NombreCampo = "numeroPorModelo";
            this.cmb_Nroavion.Pp_NombreTabla = "Avion";
            this.cmb_Nroavion.Pp_PkTabla = "idModelo";
            this.cmb_Nroavion.Size = new System.Drawing.Size(121, 21);
            this.cmb_Nroavion.TabIndex = 13;
            // 
            // textBox_Aerolinea1
            // 
            this.textBox_Aerolinea1.Location = new System.Drawing.Point(226, 70);
            this.textBox_Aerolinea1.Name = "textBox_Aerolinea1";
            this.textBox_Aerolinea1.Pp_MensajeError = "Ingrese el código del vuelo";
            this.textBox_Aerolinea1.Pp_NombreCampo = "idVuelo";
            this.textBox_Aerolinea1.Size = new System.Drawing.Size(120, 20);
            this.textBox_Aerolinea1.TabIndex = 15;
            // 
            // textBox_Aerolinea2
            // 
            this.textBox_Aerolinea2.Location = new System.Drawing.Point(226, 112);
            this.textBox_Aerolinea2.Name = "textBox_Aerolinea2";
            this.textBox_Aerolinea2.Pp_MensajeError = "Ingrese la duracion estimada";
            this.textBox_Aerolinea2.Pp_NombreCampo = "duracionEstimada";
            this.textBox_Aerolinea2.Size = new System.Drawing.Size(120, 20);
            this.textBox_Aerolinea2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Registrar Vuelo";
            // 
            // Frm_ABMVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(749, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Aerolinea2);
            this.Controls.Add(this.textBox_Aerolinea1);
            this.Controls.Add(this.cmb_Tramo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.cmb_Nroavion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cmb_Nromodelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABMVuelo";
            this.Text = "Frm_ABMVuelo";
            this.Load += new System.EventHandler(this.Frm_ABMVuelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_cancelar;
        private Clase.ComboBox_Aerolinea cmb_Tramo;
        private Clase.ComboBox_Aerolinea Cmb_Nromodelo;
        private Clase.ComboBox_Aerolinea cmb_Nroavion;
        private Clase.TextBox_Aerolinea textBox_Aerolinea1;
        private Clase.TextBox_Aerolinea textBox_Aerolinea2;
        private System.Windows.Forms.Label label1;
    }
}