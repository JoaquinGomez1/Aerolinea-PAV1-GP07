namespace TrabajoPrácticoPAV.Formularios
{
    partial class Frm_ABMClientes
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
            this.btn_agregar_fono = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cal_fecha_nacimiento = new System.Windows.Forms.MonthCalendar();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Cmb_TipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.Txt_telefono = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Txt_Apellido = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Cmb_Ciudad = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.Cmb_Provincia = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.Cmb_Pais = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.Txt_numero_calle = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Txt_nombre_calle = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Pasajero";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Teléfono";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(144, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_agregar_fono
            // 
            this.btn_agregar_fono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_agregar_fono.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_agregar_fono.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_agregar_fono.FlatAppearance.BorderSize = 3;
            this.btn_agregar_fono.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_agregar_fono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_fono.Location = new System.Drawing.Point(360, 102);
            this.btn_agregar_fono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_agregar_fono.Name = "btn_agregar_fono";
            this.btn_agregar_fono.Size = new System.Drawing.Size(27, 22);
            this.btn_agregar_fono.TabIndex = 7;
            this.btn_agregar_fono.Text = "+";
            this.btn_agregar_fono.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(518, 417);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(120, 35);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo de Documento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 178);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Número de documento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Cal_fecha_nacimiento
            // 
            this.Cal_fecha_nacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cal_fecha_nacimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cal_fecha_nacimiento.Location = new System.Drawing.Point(56, 10);
            this.Cal_fecha_nacimiento.MaxSelectionCount = 1;
            this.Cal_fecha_nacimiento.Name = "Cal_fecha_nacimiento";
            this.Cal_fecha_nacimiento.ShowTodayCircle = false;
            this.Cal_fecha_nacimiento.TabIndex = 11;
            this.Cal_fecha_nacimiento.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Cal_fecha_nacimiento_DateChanged);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_registrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar.Location = new System.Drawing.Point(358, 417);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(120, 35);
            this.btn_registrar.TabIndex = 7;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(41, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Domicilio";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.Location = new System.Drawing.Point(250, 178);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.maskedTextBox1.Mask = "99999999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Cmb_Ciudad);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.Cmb_Provincia);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Cmb_Pais);
            this.panel2.Controls.Add(this.Txt_numero_calle);
            this.panel2.Controls.Add(this.Txt_nombre_calle);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(24, 311);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 83);
            this.panel2.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-1, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre de calle";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Número";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(272, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "País";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(460, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Provincia";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(675, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(30, 0, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 22);
            this.label13.TabIndex = 23;
            this.label13.Text = "Ciudad";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Txt_nombre);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Cmb_TipoDoc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Txt_telefono);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Txt_Apellido);
            this.panel1.Controls.Add(this.btn_agregar_fono);
            this.panel1.Location = new System.Drawing.Point(24, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 227);
            this.panel1.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.btn_cancelar);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btn_registrar);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 486);
            this.panel3.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(41, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(157, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "Datos personales";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Cal_fecha_nacimiento);
            this.panel4.Location = new System.Drawing.Point(563, 41);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 227);
            this.panel4.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(576, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Fecha de nacimiento";
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_nombre.Location = new System.Drawing.Point(250, 26);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Pp_MensajeError = "Escribe tu nombre";
            this.Txt_nombre.Pp_NombreCampo = null;
            this.Txt_nombre.Size = new System.Drawing.Size(100, 22);
            this.Txt_nombre.TabIndex = 15;
            // 
            // Cmb_TipoDoc
            // 
            this.Cmb_TipoDoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cmb_TipoDoc.FormattingEnabled = true;
            this.Cmb_TipoDoc.Location = new System.Drawing.Point(250, 140);
            this.Cmb_TipoDoc.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Cmb_TipoDoc.Name = "Cmb_TipoDoc";
            this.Cmb_TipoDoc.Pp_CampoAceptaNull = false;
            this.Cmb_TipoDoc.Pp_MensajeError = "Seleccionar Tipo Doc";
            this.Cmb_TipoDoc.Pp_NombreCampo = "nombre";
            this.Cmb_TipoDoc.Pp_NombreTabla = "Tipo_Documento";
            this.Cmb_TipoDoc.Pp_PkTabla = "tipoDoc";
            this.Cmb_TipoDoc.Size = new System.Drawing.Size(100, 24);
            this.Cmb_TipoDoc.TabIndex = 19;
            // 
            // Txt_telefono
            // 
            this.Txt_telefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_telefono.Location = new System.Drawing.Point(250, 102);
            this.Txt_telefono.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Txt_telefono.Name = "Txt_telefono";
            this.Txt_telefono.Pp_MensajeError = "Escribe tu telefono";
            this.Txt_telefono.Pp_NombreCampo = null;
            this.Txt_telefono.Size = new System.Drawing.Size(100, 22);
            this.Txt_telefono.TabIndex = 17;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_Apellido.Location = new System.Drawing.Point(250, 64);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Pp_MensajeError = "Escribe tu apellido";
            this.Txt_Apellido.Pp_NombreCampo = null;
            this.Txt_Apellido.Size = new System.Drawing.Size(100, 22);
            this.Txt_Apellido.TabIndex = 16;
            // 
            // Cmb_Ciudad
            // 
            this.Cmb_Ciudad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cmb_Ciudad.FormattingEnabled = true;
            this.Cmb_Ciudad.Location = new System.Drawing.Point(769, 16);
            this.Cmb_Ciudad.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Cmb_Ciudad.Name = "Cmb_Ciudad";
            this.Cmb_Ciudad.Pp_CampoAceptaNull = true;
            this.Cmb_Ciudad.Pp_MensajeError = null;
            this.Cmb_Ciudad.Pp_NombreCampo = "nombre";
            this.Cmb_Ciudad.Pp_NombreTabla = "Ciudad";
            this.Cmb_Ciudad.Pp_PkTabla = "idCiudad";
            this.Cmb_Ciudad.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Ciudad.TabIndex = 24;
            // 
            // Cmb_Provincia
            // 
            this.Cmb_Provincia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cmb_Provincia.FormattingEnabled = true;
            this.Cmb_Provincia.Location = new System.Drawing.Point(571, 16);
            this.Cmb_Provincia.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Cmb_Provincia.Name = "Cmb_Provincia";
            this.Cmb_Provincia.Pp_CampoAceptaNull = true;
            this.Cmb_Provincia.Pp_MensajeError = null;
            this.Cmb_Provincia.Pp_NombreCampo = "nombreProv";
            this.Cmb_Provincia.Pp_NombreTabla = "Provincia";
            this.Cmb_Provincia.Pp_PkTabla = "idProvincia";
            this.Cmb_Provincia.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Provincia.TabIndex = 22;
            // 
            // Cmb_Pais
            // 
            this.Cmb_Pais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cmb_Pais.FormattingEnabled = true;
            this.Cmb_Pais.Location = new System.Drawing.Point(347, 16);
            this.Cmb_Pais.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Cmb_Pais.Name = "Cmb_Pais";
            this.Cmb_Pais.Pp_CampoAceptaNull = true;
            this.Cmb_Pais.Pp_MensajeError = null;
            this.Cmb_Pais.Pp_NombreCampo = "nombre";
            this.Cmb_Pais.Pp_NombreTabla = "Pais";
            this.Cmb_Pais.Pp_PkTabla = "idPais";
            this.Cmb_Pais.Size = new System.Drawing.Size(100, 24);
            this.Cmb_Pais.TabIndex = 20;
            this.Cmb_Pais.SelectedIndexChanged += new System.EventHandler(this.Cmb_Pais_SelectedIndexChanged);
            // 
            // Txt_numero_calle
            // 
            this.Txt_numero_calle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_numero_calle.Location = new System.Drawing.Point(157, 48);
            this.Txt_numero_calle.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Txt_numero_calle.Name = "Txt_numero_calle";
            this.Txt_numero_calle.Pp_MensajeError = null;
            this.Txt_numero_calle.Pp_NombreCampo = null;
            this.Txt_numero_calle.Size = new System.Drawing.Size(100, 22);
            this.Txt_numero_calle.TabIndex = 17;
            // 
            // Txt_nombre_calle
            // 
            this.Txt_nombre_calle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Txt_nombre_calle.Location = new System.Drawing.Point(157, 16);
            this.Txt_nombre_calle.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.Txt_nombre_calle.Name = "Txt_nombre_calle";
            this.Txt_nombre_calle.Pp_MensajeError = null;
            this.Txt_nombre_calle.Pp_NombreCampo = null;
            this.Txt_nombre_calle.Size = new System.Drawing.Size(100, 22);
            this.Txt_nombre_calle.TabIndex = 16;
            // 
            // Frm_ABMClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(999, 510);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_ABMClientes";
            this.Text = "Frm_ABMClientes";
            this.Load += new System.EventHandler(this.Frm_ABMClientes_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_agregar_fono;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar Cal_fecha_nacimiento;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label label12;
        private Clase.TextBox_Aerolinea Txt_nombre;
        private Clase.TextBox_Aerolinea Txt_Apellido;
        private Clase.TextBox_Aerolinea Txt_telefono;
        private Clase.ComboBox_Aerolinea Cmb_TipoDoc;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Panel panel2;
        private Clase.ComboBox_Aerolinea Cmb_Ciudad;
        private System.Windows.Forms.Label label13;
        private Clase.ComboBox_Aerolinea Cmb_Provincia;
        private System.Windows.Forms.Label label5;
        private Clase.ComboBox_Aerolinea Cmb_Pais;
        private Clase.TextBox_Aerolinea Txt_numero_calle;
        private Clase.TextBox_Aerolinea Txt_nombre_calle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
    }
}