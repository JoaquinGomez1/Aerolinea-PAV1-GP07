namespace TrabajoPrácticoPAV.Formularios
{
    partial class Frm_ABMReservas
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
            this.btn_registrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_nDoc = new System.Windows.Forms.Label();
            this.lbl_tipoDoc = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_fechaNacimiento = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_currentDate = new System.Windows.Forms.Label();
            this.textBox_Aerolinea2 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.textBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_claseAsiento = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.maskedTextBox_Aerolinea2 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.cmb_tipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.Mtxt_numeroDoc = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.btn_buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_agregar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.grid_pasajeros = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_refrescar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Aerolinea3 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_titularReserva = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pasajeros)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(633, 337);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(90, 28);
            this.btn_registrar.TabIndex = 0;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar pasajero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero Documento";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(-40, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 74;
            this.label4.Text = "Fecha Nacimiento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(-21, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Tipo de Documento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label7.Location = new System.Drawing.Point(-12, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "Número de documento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label5.Location = new System.Drawing.Point(-24, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Apellido";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label10.Location = new System.Drawing.Point(1, 32);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 67;
            this.label10.Text = "Nombre";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_nombre.Location = new System.Drawing.Point(148, 35);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(70, 16);
            this.lbl_nombre.TabIndex = 75;
            this.lbl_nombre.Text = "???";
            this.lbl_nombre.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_nDoc
            // 
            this.lbl_nDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_nDoc.Location = new System.Drawing.Point(148, 122);
            this.lbl_nDoc.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_nDoc.Name = "lbl_nDoc";
            this.lbl_nDoc.Size = new System.Drawing.Size(70, 16);
            this.lbl_nDoc.TabIndex = 76;
            this.lbl_nDoc.Text = "???";
            this.lbl_nDoc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_tipoDoc
            // 
            this.lbl_tipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_tipoDoc.Location = new System.Drawing.Point(148, 95);
            this.lbl_tipoDoc.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_tipoDoc.Name = "lbl_tipoDoc";
            this.lbl_tipoDoc.Size = new System.Drawing.Size(70, 16);
            this.lbl_tipoDoc.TabIndex = 77;
            this.lbl_tipoDoc.Text = "???";
            this.lbl_tipoDoc.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_apellido.Location = new System.Drawing.Point(148, 63);
            this.lbl_apellido.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(70, 16);
            this.lbl_apellido.TabIndex = 78;
            this.lbl_apellido.Text = "???";
            this.lbl_apellido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_fechaNacimiento
            // 
            this.lbl_fechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbl_fechaNacimiento.Location = new System.Drawing.Point(148, 149);
            this.lbl_fechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento";
            this.lbl_fechaNacimiento.Size = new System.Drawing.Size(70, 16);
            this.lbl_fechaNacimiento.TabIndex = 79;
            this.lbl_fechaNacimiento.Text = "???";
            this.lbl_fechaNacimiento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label8.Location = new System.Drawing.Point(32, 3);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 34);
            this.label8.TabIndex = 80;
            this.label8.Text = "Fecha de reserva";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label11.Location = new System.Drawing.Point(34, 36);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 82;
            this.label11.Text = "Asignar fecha viaje";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label9.Location = new System.Drawing.Point(308, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 16);
            this.label9.TabIndex = 85;
            this.label9.Text = "Clase de asiento";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label12.Location = new System.Drawing.Point(32, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 27);
            this.label12.TabIndex = 86;
            this.label12.Text = "Origen del viaje";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label13.Location = new System.Drawing.Point(41, 87);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 28);
            this.label13.TabIndex = 87;
            this.label13.Text = "Destino del viaje";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_currentDate
            // 
            this.lbl_currentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_currentDate.Location = new System.Drawing.Point(161, 13);
            this.lbl_currentDate.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_currentDate.Name = "lbl_currentDate";
            this.lbl_currentDate.Size = new System.Drawing.Size(134, 16);
            this.lbl_currentDate.TabIndex = 90;
            this.lbl_currentDate.Text = "Fecha actual";
            this.lbl_currentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Aerolinea2
            // 
            this.textBox_Aerolinea2.Location = new System.Drawing.Point(171, 93);
            this.textBox_Aerolinea2.Name = "textBox_Aerolinea2";
            this.textBox_Aerolinea2.Pp_EsPk = false;
            this.textBox_Aerolinea2.Pp_MensajeError = null;
            this.textBox_Aerolinea2.Pp_NombreCampo = null;
            this.textBox_Aerolinea2.Pp_NombreTabla = null;
            this.textBox_Aerolinea2.Size = new System.Drawing.Size(100, 20);
            this.textBox_Aerolinea2.TabIndex = 89;
            // 
            // textBox_Aerolinea1
            // 
            this.textBox_Aerolinea1.Location = new System.Drawing.Point(171, 67);
            this.textBox_Aerolinea1.Name = "textBox_Aerolinea1";
            this.textBox_Aerolinea1.Pp_EsPk = false;
            this.textBox_Aerolinea1.Pp_MensajeError = null;
            this.textBox_Aerolinea1.Pp_NombreCampo = null;
            this.textBox_Aerolinea1.Pp_NombreTabla = null;
            this.textBox_Aerolinea1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Aerolinea1.TabIndex = 88;
            // 
            // cmb_claseAsiento
            // 
            this.cmb_claseAsiento.FormattingEnabled = true;
            this.cmb_claseAsiento.Location = new System.Drawing.Point(318, 59);
            this.cmb_claseAsiento.Name = "cmb_claseAsiento";
            this.cmb_claseAsiento.Pp_CampoAceptaNull = false;
            this.cmb_claseAsiento.Pp_EsPk = false;
            this.cmb_claseAsiento.Pp_MensajeError = "Cargar clase de asiento";
            this.cmb_claseAsiento.Pp_NombreCampo = "nombre";
            this.cmb_claseAsiento.Pp_NombreCampoInsert = null;
            this.cmb_claseAsiento.Pp_NombreTabla = "Tipo_Asiento";
            this.cmb_claseAsiento.Pp_PkTabla = "idTipo";
            this.cmb_claseAsiento.Size = new System.Drawing.Size(101, 21);
            this.cmb_claseAsiento.TabIndex = 84;
            // 
            // maskedTextBox_Aerolinea2
            // 
            this.maskedTextBox_Aerolinea2.Location = new System.Drawing.Point(170, 41);
            this.maskedTextBox_Aerolinea2.Mask = "00/00/0000";
            this.maskedTextBox_Aerolinea2.Name = "maskedTextBox_Aerolinea2";
            this.maskedTextBox_Aerolinea2.Pp_EsPk = false;
            this.maskedTextBox_Aerolinea2.Pp_MensajeError = null;
            this.maskedTextBox_Aerolinea2.Pp_NombreCampo = null;
            this.maskedTextBox_Aerolinea2.Pp_NombreTabla = null;
            this.maskedTextBox_Aerolinea2.Size = new System.Drawing.Size(101, 20);
            this.maskedTextBox_Aerolinea2.TabIndex = 83;
            this.maskedTextBox_Aerolinea2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox_Aerolinea2.ValidatingType = typeof(System.DateTime);
            // 
            // cmb_tipoDoc
            // 
            this.cmb_tipoDoc.FormattingEnabled = true;
            this.cmb_tipoDoc.Location = new System.Drawing.Point(151, 64);
            this.cmb_tipoDoc.Name = "cmb_tipoDoc";
            this.cmb_tipoDoc.Pp_CampoAceptaNull = false;
            this.cmb_tipoDoc.Pp_EsPk = false;
            this.cmb_tipoDoc.Pp_MensajeError = "Cargar tipo doc";
            this.cmb_tipoDoc.Pp_NombreCampo = "nombreTipoDoc";
            this.cmb_tipoDoc.Pp_NombreCampoInsert = null;
            this.cmb_tipoDoc.Pp_NombreTabla = "Tipo_Documento";
            this.cmb_tipoDoc.Pp_PkTabla = "tipoDoc";
            this.cmb_tipoDoc.Size = new System.Drawing.Size(60, 21);
            this.cmb_tipoDoc.TabIndex = 5;
            // 
            // Mtxt_numeroDoc
            // 
            this.Mtxt_numeroDoc.Location = new System.Drawing.Point(151, 33);
            this.Mtxt_numeroDoc.Mask = "00000000";
            this.Mtxt_numeroDoc.Name = "Mtxt_numeroDoc";
            this.Mtxt_numeroDoc.Pp_EsPk = false;
            this.Mtxt_numeroDoc.Pp_MensajeError = "Completar Numero Doc";
            this.Mtxt_numeroDoc.Pp_NombreCampo = "numeroDoc";
            this.Mtxt_numeroDoc.Pp_NombreTabla = "Pasajero";
            this.Mtxt_numeroDoc.Size = new System.Drawing.Size(60, 20);
            this.Mtxt_numeroDoc.TabIndex = 4;
            this.Mtxt_numeroDoc.ValidatingType = typeof(int);
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_buscar.Location = new System.Drawing.Point(9, 91);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Pp_Presionado = false;
            this.btn_buscar.Size = new System.Drawing.Size(90, 28);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_modificar.Location = new System.Drawing.Point(635, 263);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(87, 28);
            this.btn_modificar.TabIndex = 91;
            this.btn_modificar.Text = "Modificar Reserva";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button1.Location = new System.Drawing.Point(635, 300);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 92;
            this.button1.Text = "Eliminar Reserva";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_agregar.Location = new System.Drawing.Point(121, 91);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Pp_Presionado = false;
            this.btn_agregar.Size = new System.Drawing.Size(90, 28);
            this.btn_agregar.TabIndex = 93;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // grid_pasajeros
            // 
            this.grid_pasajeros.AllowUserToAddRows = false;
            this.grid_pasajeros.AllowUserToDeleteRows = false;
            this.grid_pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_pasajeros.Location = new System.Drawing.Point(276, 212);
            this.grid_pasajeros.Name = "grid_pasajeros";
            this.grid_pasajeros.Pp_FormatoGrid = "nombre, Nombre, 120;apellido,Apellido, 120;tipoDoc, Tipo Documento, 65;numeroDoc," +
    " Número de documento, 100";
            this.grid_pasajeros.Pp_NombreTabla = "Pasajero";
            this.grid_pasajeros.ReadOnly = true;
            this.grid_pasajeros.Size = new System.Drawing.Size(353, 151);
            this.grid_pasajeros.TabIndex = 94;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 17);
            this.label14.TabIndex = 95;
            this.label14.Text = "Datos del pasajero";
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_refrescar.Location = new System.Drawing.Point(635, 226);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Pp_Presionado = false;
            this.btn_refrescar.Size = new System.Drawing.Size(87, 28);
            this.btn_refrescar.TabIndex = 96;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cerrar.Location = new System.Drawing.Point(635, 336);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(87, 28);
            this.btn_cerrar.TabIndex = 97;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmb_tipoDoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.Mtxt_numeroDoc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(15, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 136);
            this.panel1.TabIndex = 98;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_nombre);
            this.panel2.Controls.Add(this.lbl_nDoc);
            this.panel2.Controls.Add(this.lbl_tipoDoc);
            this.panel2.Controls.Add(this.lbl_apellido);
            this.panel2.Controls.Add(this.lbl_fechaNacimiento);
            this.panel2.Location = new System.Drawing.Point(15, 188);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 175);
            this.panel2.TabIndex = 99;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox_Aerolinea2);
            this.panel3.Controls.Add(this.btn_registrar);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.maskedTextBox_Aerolinea2);
            this.panel3.Controls.Add(this.cmb_claseAsiento);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lbl_currentDate);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.textBox_Aerolinea1);
            this.panel3.Location = new System.Drawing.Point(276, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(449, 136);
            this.panel3.TabIndex = 100;
            // 
            // button_Aerolinea3
            // 
            this.button_Aerolinea3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Aerolinea3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_Aerolinea3.Location = new System.Drawing.Point(635, 189);
            this.button_Aerolinea3.Name = "button_Aerolinea3";
            this.button_Aerolinea3.Pp_Presionado = false;
            this.button_Aerolinea3.Size = new System.Drawing.Size(87, 28);
            this.button_Aerolinea3.TabIndex = 101;
            this.button_Aerolinea3.Text = "Registrar";
            this.button_Aerolinea3.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(273, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 17);
            this.label15.TabIndex = 96;
            this.label15.Text = "Titular de Reserva: ";
            // 
            // lbl_titularReserva
            // 
            this.lbl_titularReserva.AutoSize = true;
            this.lbl_titularReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_titularReserva.Location = new System.Drawing.Point(474, 189);
            this.lbl_titularReserva.Name = "lbl_titularReserva";
            this.lbl_titularReserva.Size = new System.Drawing.Size(32, 17);
            this.lbl_titularReserva.TabIndex = 101;
            this.lbl_titularReserva.Text = "???";
            // 
            // Frm_ABMReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 374);
            this.Controls.Add(this.button_Aerolinea3);
            this.Controls.Add(this.lbl_titularReserva);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_refrescar);
            this.Controls.Add(this.grid_pasajeros);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_ABMReservas";
            this.Text = "Frm_ABMReservas";
            this.Load += new System.EventHandler(this.Frm_ABMReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_pasajeros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label label1;
        private Clase.Button_Aerolinea btn_buscar;
        private Clase.MaskedTextBox_Aerolinea Mtxt_numeroDoc;
        private Clase.ComboBox_Aerolinea cmb_tipoDoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_nDoc;
        private System.Windows.Forms.Label lbl_tipoDoc;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_fechaNacimiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private Clase.MaskedTextBox_Aerolinea maskedTextBox_Aerolinea2;
        private Clase.ComboBox_Aerolinea cmb_claseAsiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Clase.TextBox_Aerolinea textBox_Aerolinea1;
        private Clase.TextBox_Aerolinea textBox_Aerolinea2;
        private System.Windows.Forms.Label lbl_currentDate;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button button1;
        private Clase.Button_Aerolinea btn_agregar;
        private Clase.DataGridView_Aerolinea grid_pasajeros;
        private System.Windows.Forms.Label label14;
        private Clase.Button_Aerolinea btn_refrescar;
        private Clase.Button_Aerolinea btn_cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Clase.Button_Aerolinea button_Aerolinea3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_titularReserva;
    }
}