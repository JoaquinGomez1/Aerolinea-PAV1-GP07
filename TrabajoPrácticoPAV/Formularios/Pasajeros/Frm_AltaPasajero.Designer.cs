namespace TrabajoPrácticoPAV.Formularios.Pasajeros
{
    partial class Frm_AltaPasajero
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
            this.Msktxt_NumeroDOC = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.Cmb_Ciudad = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.Cal_fecha_nacimiento = new System.Windows.Forms.MonthCalendar();
            this.label13 = new System.Windows.Forms.Label();
            this.Txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Cmb_Provincia = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cmb_Pais = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Txt_numero_calle = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_nombre_calle = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Cmb_TipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_telefono = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_agregar_fono = new System.Windows.Forms.Button();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // Msktxt_NumeroDOC
            // 
            this.Msktxt_NumeroDOC.Location = new System.Drawing.Point(249, 260);
            this.Msktxt_NumeroDOC.Mask = "99999999";
            this.Msktxt_NumeroDOC.Name = "Msktxt_NumeroDOC";
            this.Msktxt_NumeroDOC.Pp_EsPk = false;
            this.Msktxt_NumeroDOC.Pp_NombreCampo = "numeroDoc";
            this.Msktxt_NumeroDOC.Pp_NombreTabla = "Pasajero";
            this.Msktxt_NumeroDOC.Size = new System.Drawing.Size(100, 22);
            this.Msktxt_NumeroDOC.TabIndex = 56;
            // 
            // Cmb_Ciudad
            // 
            this.Cmb_Ciudad.FormattingEnabled = true;
            this.Cmb_Ciudad.Location = new System.Drawing.Point(865, 382);
            this.Cmb_Ciudad.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Cmb_Ciudad.Name = "Cmb_Ciudad";
            this.Cmb_Ciudad.Pp_CampoAceptaNull = true;
            this.Cmb_Ciudad.Pp_EsPk = false;
            this.Cmb_Ciudad.Pp_MensajeError = null;
            this.Cmb_Ciudad.Pp_NombreCampo = "nombreCiudad";
            this.Cmb_Ciudad.Pp_NombreCampoInsert = null;
            this.Cmb_Ciudad.Pp_NombreTabla = "Ciudad";
            this.Cmb_Ciudad.Pp_PkTabla = "idCiudad";
            this.Cmb_Ciudad.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Ciudad.TabIndex = 53;
            // 
            // Cal_fecha_nacimiento
            // 
            this.Cal_fecha_nacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cal_fecha_nacimiento.Location = new System.Drawing.Point(405, 99);
            this.Cal_fecha_nacimiento.MaxSelectionCount = 1;
            this.Cal_fecha_nacimiento.Name = "Cal_fecha_nacimiento";
            this.Cal_fecha_nacimiento.ShowTodayCircle = false;
            this.Cal_fecha_nacimiento.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(771, 382);
            this.label13.Margin = new System.Windows.Forms.Padding(29, 0, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 22);
            this.label13.TabIndex = 52;
            this.label13.Text = "Ciudad";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(249, 108);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Pp_EsPk = false;
            this.Txt_nombre.Pp_MensajeError = "Escribe tu nombre";
            this.Txt_nombre.Pp_NombreCampo = "nombre";
            this.Txt_nombre.Pp_NombreTabla = "Pasajero";
            this.Txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.Txt_nombre.TabIndex = 41;
            // 
            // Cmb_Provincia
            // 
            this.Cmb_Provincia.FormattingEnabled = true;
            this.Cmb_Provincia.Location = new System.Drawing.Point(667, 382);
            this.Cmb_Provincia.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Cmb_Provincia.Name = "Cmb_Provincia";
            this.Cmb_Provincia.Pp_CampoAceptaNull = true;
            this.Cmb_Provincia.Pp_EsPk = false;
            this.Cmb_Provincia.Pp_MensajeError = null;
            this.Cmb_Provincia.Pp_NombreCampo = "nombreProvincia";
            this.Cmb_Provincia.Pp_NombreCampoInsert = null;
            this.Cmb_Provincia.Pp_NombreTabla = "Provincia";
            this.Cmb_Provincia.Pp_PkTabla = "idProvincia";
            this.Cmb_Provincia.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Provincia.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(401, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(556, 382);
            this.label5.Margin = new System.Windows.Forms.Padding(29, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 22);
            this.label5.TabIndex = 48;
            this.label5.Text = "Provincia";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 22);
            this.label2.TabIndex = 31;
            this.label2.Text = "Teléfono";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Cmb_Pais
            // 
            this.Cmb_Pais.FormattingEnabled = true;
            this.Cmb_Pais.Location = new System.Drawing.Point(443, 382);
            this.Cmb_Pais.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Cmb_Pais.Name = "Cmb_Pais";
            this.Cmb_Pais.Pp_CampoAceptaNull = true;
            this.Cmb_Pais.Pp_EsPk = false;
            this.Cmb_Pais.Pp_MensajeError = null;
            this.Cmb_Pais.Pp_NombreCampo = "nombrePais";
            this.Cmb_Pais.Pp_NombreCampoInsert = null;
            this.Cmb_Pais.Pp_NombreTabla = "Pais";
            this.Cmb_Pais.Pp_PkTabla = "idPais";
            this.Cmb_Pais.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Pais.TabIndex = 47;
            this.Cmb_Pais.SelectedIndexChanged += new System.EventHandler(this.Cmb_Pais_SelectedIndexChanged);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cancelar.Location = new System.Drawing.Point(481, 491);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Pp_Presionado = false;
            this.btn_cancelar.Size = new System.Drawing.Size(120, 34);
            this.btn_cancelar.TabIndex = 55;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Txt_numero_calle
            // 
            this.Txt_numero_calle.Location = new System.Drawing.Point(253, 414);
            this.Txt_numero_calle.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Txt_numero_calle.Name = "Txt_numero_calle";
            this.Txt_numero_calle.Pp_EsPk = false;
            this.Txt_numero_calle.Pp_MensajeError = null;
            this.Txt_numero_calle.Pp_NombreCampo = null;
            this.Txt_numero_calle.Pp_NombreTabla = null;
            this.Txt_numero_calle.Size = new System.Drawing.Size(100, 22);
            this.Txt_numero_calle.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 222);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tipo de Documento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_nombre_calle
            // 
            this.Txt_nombre_calle.Location = new System.Drawing.Point(253, 382);
            this.Txt_nombre_calle.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Txt_nombre_calle.Name = "Txt_nombre_calle";
            this.Txt_nombre_calle.Pp_EsPk = false;
            this.Txt_nombre_calle.Pp_MensajeError = null;
            this.Txt_nombre_calle.Pp_NombreCampo = null;
            this.Txt_nombre_calle.Pp_NombreTabla = null;
            this.Txt_nombre_calle.Size = new System.Drawing.Size(100, 22);
            this.Txt_nombre_calle.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(368, 382);
            this.label10.Margin = new System.Windows.Forms.Padding(29, 0, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "País";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(157, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 34;
            this.label9.Text = "Número";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 22);
            this.label7.TabIndex = 32;
            this.label7.Text = "Número de documento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(95, 382);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 22);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nombre de calle";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(76, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 20);
            this.label14.TabIndex = 40;
            this.label14.Text = "Datos personales";
            // 
            // Cmb_TipoDoc
            // 
            this.Cmb_TipoDoc.FormattingEnabled = true;
            this.Cmb_TipoDoc.Location = new System.Drawing.Point(249, 222);
            this.Cmb_TipoDoc.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Cmb_TipoDoc.Name = "Cmb_TipoDoc";
            this.Cmb_TipoDoc.Pp_CampoAceptaNull = false;
            this.Cmb_TipoDoc.Pp_EsPk = false;
            this.Cmb_TipoDoc.Pp_MensajeError = "Seleccionar Tipo Doc";
            this.Cmb_TipoDoc.Pp_NombreCampo = "nombreTipoDoc";
            this.Cmb_TipoDoc.Pp_NombreCampoInsert = null;
            this.Cmb_TipoDoc.Pp_NombreTabla = "Tipo_Documento";
            this.Cmb_TipoDoc.Pp_PkTabla = "tipoDoc";
            this.Cmb_TipoDoc.Size = new System.Drawing.Size(100, 24);
            this.Cmb_TipoDoc.TabIndex = 46;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_registrar.Location = new System.Drawing.Point(328, 491);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Pp_Presionado = false;
            this.btn_registrar.Size = new System.Drawing.Size(120, 34);
            this.btn_registrar.TabIndex = 54;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(107, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Location = new System.Drawing.Point(249, 184);
            this.Txt_telefono.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Pp_EsPk = false;
            this.Txt_telefono.Pp_MensajeError = "Escribe tu telefono";
            this.Txt_telefono.Pp_NombreCampo = "numeroTelefono";
            this.Txt_telefono.Pp_NombreTabla = "Telefono";
            this.Txt_telefono.Size = new System.Drawing.Size(100, 22);
            this.Txt_telefono.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(142, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nombre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Location = new System.Drawing.Point(249, 146);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Pp_EsPk = false;
            this.Txt_Apellido.Pp_MensajeError = "Escribe tu apellido";
            this.Txt_Apellido.Pp_NombreCampo = "apellido";
            this.Txt_Apellido.Pp_NombreTabla = "Pasajero";
            this.Txt_Apellido.Size = new System.Drawing.Size(100, 22);
            this.Txt_Apellido.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(158, 345);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Domicilio";
            // 
            // btn_agregar_fono
            // 
            this.btn_agregar_fono.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_agregar_fono.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_agregar_fono.FlatAppearance.BorderSize = 3;
            this.btn_agregar_fono.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_agregar_fono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_fono.Location = new System.Drawing.Point(370, 184);
            this.btn_agregar_fono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar_fono.Name = "btn_agregar_fono";
            this.btn_agregar_fono.Size = new System.Drawing.Size(27, 22);
            this.btn_agregar_fono.TabIndex = 37;
            this.btn_agregar_fono.Text = "+";
            this.btn_agregar_fono.UseVisualStyleBackColor = true;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.label15);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(1008, 39);
            this.BarraSuperior.TabIndex = 57;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(212, 27);
            this.label15.TabIndex = 4;
            this.label15.Text = "REGISTRAR TRAMO";
            // 
            // Frm_AltaPasajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 566);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.Msktxt_NumeroDOC);
            this.Controls.Add(this.Cmb_Ciudad);
            this.Controls.Add(this.Cal_fecha_nacimiento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.Cmb_Provincia);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cmb_Pais);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.Txt_numero_calle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_nombre_calle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Cmb_TipoDoc);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_telefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_agregar_fono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AltaPasajero";
            this.Text = "Frm_AltaPasajero";
            this.Load += new System.EventHandler(this.Frm_AltaPasajero_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.MaskedTextBox_Aerolinea Msktxt_NumeroDOC;
        private Clase.ComboBox_Aerolinea Cmb_Ciudad;
        private System.Windows.Forms.MonthCalendar Cal_fecha_nacimiento;
        private System.Windows.Forms.Label label13;
        private Clase.TextBox_Aerolinea Txt_nombre;
        private Clase.ComboBox_Aerolinea Cmb_Provincia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Clase.ComboBox_Aerolinea Cmb_Pais;
        private Clase.Button_Aerolinea btn_cancelar;
        private Clase.TextBox_Aerolinea Txt_numero_calle;
        private System.Windows.Forms.Label label6;
        private Clase.TextBox_Aerolinea Txt_nombre_calle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private Clase.ComboBox_Aerolinea Cmb_TipoDoc;
        private Clase.Button_Aerolinea btn_registrar;
        private System.Windows.Forms.Label label3;
        private Clase.TextBox_Aerolinea Txt_telefono;
        private System.Windows.Forms.Label label4;
        private Clase.TextBox_Aerolinea Txt_Apellido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_agregar_fono;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label label15;
    }
}