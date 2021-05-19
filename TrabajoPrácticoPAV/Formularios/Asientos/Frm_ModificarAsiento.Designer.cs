namespace TrabajoPrácticoPAV.Formularios.Asientos
{
    partial class Frm_ModificarAsiento
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
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_registrarAsiento = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_clase = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_numeroAvion = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_nombreModelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idasiento = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_estado = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_cerrar.Location = new System.Drawing.Point(250, 188);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(74, 28);
            this.btn_cerrar.TabIndex = 19;
            this.btn_cerrar.Text = "Cancelar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_registrarAsiento
            // 
            this.btn_registrarAsiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_registrarAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_registrarAsiento.Location = new System.Drawing.Point(106, 188);
            this.btn_registrarAsiento.Name = "btn_registrarAsiento";
            this.btn_registrarAsiento.Pp_Presionado = false;
            this.btn_registrarAsiento.Size = new System.Drawing.Size(74, 28);
            this.btn_registrarAsiento.TabIndex = 18;
            this.btn_registrarAsiento.Text = "Registrar";
            this.btn_registrarAsiento.UseVisualStyleBackColor = false;
            this.btn_registrarAsiento.Click += new System.EventHandler(this.btn_registrarAsiento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(69, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Estado del Asiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(88, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Clase del avión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(76, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Numero del avión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(79, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Modelo del Avión";
            // 
            // cmb_clase
            // 
            this.cmb_clase.FormattingEnabled = true;
            this.cmb_clase.Location = new System.Drawing.Point(214, 124);
            this.cmb_clase.Name = "cmb_clase";
            this.cmb_clase.Pp_CampoAceptaNull = false;
            this.cmb_clase.Pp_EsPk = false;
            this.cmb_clase.Pp_MensajeError = "Seleccione la clase del asiento";
            this.cmb_clase.Pp_NombreCampo = "nombre";
            this.cmb_clase.Pp_NombreCampoInsert = "tipoAsiento";
            this.cmb_clase.Pp_NombreTabla = "Tipo_Asiento";
            this.cmb_clase.Pp_PkTabla = "idTipo";
            this.cmb_clase.Size = new System.Drawing.Size(164, 21);
            this.cmb_clase.TabIndex = 12;
            // 
            // cmb_numeroAvion
            // 
            this.cmb_numeroAvion.Enabled = false;
            this.cmb_numeroAvion.FormattingEnabled = true;
            this.cmb_numeroAvion.Location = new System.Drawing.Point(214, 98);
            this.cmb_numeroAvion.Name = "cmb_numeroAvion";
            this.cmb_numeroAvion.Pp_CampoAceptaNull = true;
            this.cmb_numeroAvion.Pp_EsPk = false;
            this.cmb_numeroAvion.Pp_MensajeError = "Seleccione el numero del avion";
            this.cmb_numeroAvion.Pp_NombreCampo = "numeroPorModelo";
            this.cmb_numeroAvion.Pp_NombreCampoInsert = "numeroPorModelo";
            this.cmb_numeroAvion.Pp_NombreTabla = "avion";
            this.cmb_numeroAvion.Pp_PkTabla = "numeroPorModelo";
            this.cmb_numeroAvion.Size = new System.Drawing.Size(164, 21);
            this.cmb_numeroAvion.TabIndex = 11;
            // 
            // cmb_nombreModelo
            // 
            this.cmb_nombreModelo.Enabled = false;
            this.cmb_nombreModelo.FormattingEnabled = true;
            this.cmb_nombreModelo.Location = new System.Drawing.Point(214, 71);
            this.cmb_nombreModelo.Name = "cmb_nombreModelo";
            this.cmb_nombreModelo.Pp_CampoAceptaNull = true;
            this.cmb_nombreModelo.Pp_EsPk = false;
            this.cmb_nombreModelo.Pp_MensajeError = "Seleccione el modelo del avion";
            this.cmb_nombreModelo.Pp_NombreCampo = "nombre";
            this.cmb_nombreModelo.Pp_NombreCampoInsert = "idModelo";
            this.cmb_nombreModelo.Pp_NombreTabla = "modelo";
            this.cmb_nombreModelo.Pp_PkTabla = "idModelo";
            this.cmb_nombreModelo.Size = new System.Drawing.Size(164, 21);
            this.cmb_nombreModelo.TabIndex = 10;
            this.cmb_nombreModelo.SelectionChangeCommitted += new System.EventHandler(this.cmb_nombreModelo_SelectionChangeCommitted_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(69, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Codigo del Asiento";
            // 
            // txt_idasiento
            // 
            this.txt_idasiento.Enabled = false;
            this.txt_idasiento.Location = new System.Drawing.Point(214, 44);
            this.txt_idasiento.Name = "txt_idasiento";
            this.txt_idasiento.Pp_EsPk = true;
            this.txt_idasiento.Pp_MensajeError = null;
            this.txt_idasiento.Pp_NombreCampo = "numeroAsiento";
            this.txt_idasiento.Pp_NombreTabla = "Asientos";
            this.txt_idasiento.Size = new System.Drawing.Size(164, 20);
            this.txt_idasiento.TabIndex = 21;
            // 
            // txt_estado
            // 
            this.txt_estado.Location = new System.Drawing.Point(214, 151);
            this.txt_estado.Name = "txt_estado";
            this.txt_estado.Pp_EsPk = false;
            this.txt_estado.Pp_MensajeError = "Ingrese el estado del asiento";
            this.txt_estado.Pp_NombreCampo = "estado";
            this.txt_estado.Pp_NombreTabla = "Asientos";
            this.txt_estado.Size = new System.Drawing.Size(164, 20);
            this.txt_estado.TabIndex = 13;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(443, 32);
            this.BarraSuperior.TabIndex = 51;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(9, 6);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(183, 22);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "MODIFICAR ASIENTO";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(10, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 195);
            this.panel1.TabIndex = 52;
            // 
            // Frm_ModificarAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(443, 242);
            this.Controls.Add(this.BarraSuperior);
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
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ModificarAsiento";
            this.Text = "Frm_ModificarAsiento";
            this.Load += new System.EventHandler(this.Frm_ModificarAsiento_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private Clase.TextBox_Aerolinea txt_idasiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel panel1;
    }
}