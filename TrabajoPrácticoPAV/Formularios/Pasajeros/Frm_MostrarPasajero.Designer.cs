namespace TrabajoPrácticoPAV.Formularios.Pasajeros
{
    partial class Frm_MostrarPasajero
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
            this.maskedTextBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.txt_Fecha = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.Msktxt_NumeroDOC = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.Cmb_Ciudad = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.btn_cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_nombre_calle = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Cmb_TipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label12 = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBox_Aerolinea1
            // 
            this.maskedTextBox_Aerolinea1.Enabled = false;
            this.maskedTextBox_Aerolinea1.Location = new System.Drawing.Point(634, 135);
            this.maskedTextBox_Aerolinea1.Mask = "99999";
            this.maskedTextBox_Aerolinea1.Name = "maskedTextBox_Aerolinea1";
            this.maskedTextBox_Aerolinea1.Pp_EsPk = false;
            this.maskedTextBox_Aerolinea1.Pp_NombreCampo = "numeroCalle";
            this.maskedTextBox_Aerolinea1.Pp_NombreTabla = "Pasajero";
            this.maskedTextBox_Aerolinea1.PromptChar = ' ';
            this.maskedTextBox_Aerolinea1.Size = new System.Drawing.Size(125, 22);
            this.maskedTextBox_Aerolinea1.TabIndex = 105;
            // 
            // txt_Fecha
            // 
            this.txt_Fecha.Enabled = false;
            this.txt_Fecha.Location = new System.Drawing.Point(251, 249);
            this.txt_Fecha.Mask = "00/00/0000";
            this.txt_Fecha.Name = "txt_Fecha";
            this.txt_Fecha.Pp_EsPk = false;
            this.txt_Fecha.Pp_NombreCampo = "fechaNacimiento";
            this.txt_Fecha.Pp_NombreTabla = "Pasajero";
            this.txt_Fecha.Size = new System.Drawing.Size(90, 22);
            this.txt_Fecha.TabIndex = 104;
            this.txt_Fecha.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 249);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 22);
            this.label1.TabIndex = 103;
            this.label1.Text = "Fecha Nacimiento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(783, 39);
            this.BarraSuperior.TabIndex = 102;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(12, 7);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(223, 27);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "DETALLES PASAJERO";
            // 
            // Msktxt_NumeroDOC
            // 
            this.Msktxt_NumeroDOC.Enabled = false;
            this.Msktxt_NumeroDOC.Location = new System.Drawing.Point(251, 209);
            this.Msktxt_NumeroDOC.Mask = "99999999";
            this.Msktxt_NumeroDOC.Name = "Msktxt_NumeroDOC";
            this.Msktxt_NumeroDOC.Pp_EsPk = true;
            this.Msktxt_NumeroDOC.Pp_NombreCampo = "numeroDoc";
            this.Msktxt_NumeroDOC.Pp_NombreTabla = "Pasajero";
            this.Msktxt_NumeroDOC.PromptChar = ' ';
            this.Msktxt_NumeroDOC.Size = new System.Drawing.Size(90, 22);
            this.Msktxt_NumeroDOC.TabIndex = 101;
            // 
            // Cmb_Ciudad
            // 
            this.Cmb_Ciudad.Enabled = false;
            this.Cmb_Ciudad.FormattingEnabled = true;
            this.Cmb_Ciudad.Location = new System.Drawing.Point(634, 171);
            this.Cmb_Ciudad.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Cmb_Ciudad.Name = "Cmb_Ciudad";
            this.Cmb_Ciudad.Pp_CampoAceptaNull = true;
            this.Cmb_Ciudad.Pp_EsPk = false;
            this.Cmb_Ciudad.Pp_MensajeError = "Por favor ingrese la ciudad";
            this.Cmb_Ciudad.Pp_NombreCampo = "nombreCiudad";
            this.Cmb_Ciudad.Pp_NombreCampoInsert = "idCiudad";
            this.Cmb_Ciudad.Pp_NombreTabla = "Ciudad";
            this.Cmb_Ciudad.Pp_PkTabla = "idCiudad";
            this.Cmb_Ciudad.Size = new System.Drawing.Size(125, 24);
            this.Cmb_Ciudad.TabIndex = 98;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(540, 171);
            this.label13.Margin = new System.Windows.Forms.Padding(29, 0, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 22);
            this.label13.TabIndex = 97;
            this.label13.Text = "Ciudad";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Enabled = false;
            this.Txt_nombre.Location = new System.Drawing.Point(251, 97);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Pp_EsPk = false;
            this.Txt_nombre.Pp_MensajeError = "Escribe tu nombre";
            this.Txt_nombre.Pp_NombreCampo = "nombre";
            this.Txt_nombre.Pp_NombreTabla = "Pasajero";
            this.Txt_nombre.Size = new System.Drawing.Size(177, 22);
            this.Txt_nombre.TabIndex = 93;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cancelar.Location = new System.Drawing.Point(330, 289);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Pp_Presionado = false;
            this.btn_cancelar.Size = new System.Drawing.Size(120, 34);
            this.btn_cancelar.TabIndex = 100;
            this.btn_cancelar.Text = "Aceptar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 171);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 87;
            this.label6.Text = "Tipo de Documento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_nombre_calle
            // 
            this.Txt_nombre_calle.Enabled = false;
            this.Txt_nombre_calle.Location = new System.Drawing.Point(634, 95);
            this.Txt_nombre_calle.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Txt_nombre_calle.Name = "Txt_nombre_calle";
            this.Txt_nombre_calle.Pp_EsPk = false;
            this.Txt_nombre_calle.Pp_MensajeError = null;
            this.Txt_nombre_calle.Pp_NombreCampo = "calle";
            this.Txt_nombre_calle.Pp_NombreTabla = "Pasajero";
            this.Txt_nombre_calle.Size = new System.Drawing.Size(125, 22);
            this.Txt_nombre_calle.TabIndex = 95;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(538, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 88;
            this.label9.Text = "Número";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 22);
            this.label7.TabIndex = 86;
            this.label7.Text = "Número de documento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(469, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 22);
            this.label8.TabIndex = 85;
            this.label8.Text = "Nombre de calle";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(78, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 20);
            this.label14.TabIndex = 92;
            this.label14.Text = "Datos personales";
            // 
            // Cmb_TipoDoc
            // 
            this.Cmb_TipoDoc.Enabled = false;
            this.Cmb_TipoDoc.FormattingEnabled = true;
            this.Cmb_TipoDoc.Location = new System.Drawing.Point(251, 171);
            this.Cmb_TipoDoc.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Cmb_TipoDoc.Name = "Cmb_TipoDoc";
            this.Cmb_TipoDoc.Pp_CampoAceptaNull = false;
            this.Cmb_TipoDoc.Pp_EsPk = true;
            this.Cmb_TipoDoc.Pp_MensajeError = "Seleccionar el tipo de documento";
            this.Cmb_TipoDoc.Pp_NombreCampo = "nombreTipoDoc";
            this.Cmb_TipoDoc.Pp_NombreCampoInsert = "tipoDoc";
            this.Cmb_TipoDoc.Pp_NombreTabla = "Tipo_Documento";
            this.Cmb_TipoDoc.Pp_PkTabla = "tipoDoc";
            this.Cmb_TipoDoc.Size = new System.Drawing.Size(90, 24);
            this.Cmb_TipoDoc.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 89;
            this.label3.Text = "Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 90;
            this.label4.Text = "Nombre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Enabled = false;
            this.Txt_Apellido.Location = new System.Drawing.Point(251, 135);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Pp_EsPk = false;
            this.Txt_Apellido.Pp_MensajeError = "Escribe tu apellido";
            this.Txt_Apellido.Pp_NombreCampo = "apellido";
            this.Txt_Apellido.Pp_NombreTabla = "Pasajero";
            this.Txt_Apellido.Size = new System.Drawing.Size(177, 22);
            this.Txt_Apellido.TabIndex = 94;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(523, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 91;
            this.label12.Text = "Domicilio";
            // 
            // Frm_MostrarPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 335);
            this.Controls.Add(this.maskedTextBox_Aerolinea1);
            this.Controls.Add(this.txt_Fecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.Msktxt_NumeroDOC);
            this.Controls.Add(this.Cmb_Ciudad);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_nombre_calle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Cmb_TipoDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_MostrarPasajero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MostrarPasajero";
            this.Load += new System.EventHandler(this.Frm_MostrarPasajero_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.MaskedTextBox_Aerolinea maskedTextBox_Aerolinea1;
        private Clase.MaskedTextBox_Aerolinea txt_Fecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
        private Clase.MaskedTextBox_Aerolinea Msktxt_NumeroDOC;
        private Clase.ComboBox_Aerolinea Cmb_Ciudad;
        private System.Windows.Forms.Label label13;
        private Clase.TextBox_Aerolinea Txt_nombre;
        private Clase.Button_Aerolinea btn_cancelar;
        private System.Windows.Forms.Label label6;
        private Clase.TextBox_Aerolinea Txt_nombre_calle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private Clase.ComboBox_Aerolinea Cmb_TipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Clase.TextBox_Aerolinea Txt_Apellido;
        private System.Windows.Forms.Label label12;
    }
}