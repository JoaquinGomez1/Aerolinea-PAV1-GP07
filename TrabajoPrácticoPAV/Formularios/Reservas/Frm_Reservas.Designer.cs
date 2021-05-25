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
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_currentDate = new System.Windows.Forms.Label();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_registro = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_precio = new System.Windows.Forms.Label();
            this.lbl_numeroViaje = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_cantPasajeros = new System.Windows.Forms.Label();
            this.lbl_docTitular = new System.Windows.Forms.Label();
            this.lbl_nombreTitular = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Aerolinea1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_cargarPasajeros = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_consultarPasajeros = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.grid_reservas = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.cmb_destino = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_origen = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.button_Aerolinea3 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.maskedTextBox_Aerolinea2 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.cmb_claseAsiento = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_refrescar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.numeroReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaReserva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDeViaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_registro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reservas)).BeginInit();
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
            this.label11.Location = new System.Drawing.Point(31, 36);
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
            this.label9.Location = new System.Drawing.Point(289, 15);
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
            this.label12.Location = new System.Drawing.Point(22, 62);
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
            this.label13.Location = new System.Drawing.Point(31, 87);
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
            this.lbl_currentDate.Location = new System.Drawing.Point(151, 13);
            this.lbl_currentDate.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_currentDate.Name = "lbl_currentDate";
            this.lbl_currentDate.Size = new System.Drawing.Size(134, 16);
            this.lbl_currentDate.TabIndex = 90;
            this.lbl_currentDate.Text = "Fecha actual";
            this.lbl_currentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_modificar
            // 
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_modificar.Location = new System.Drawing.Point(506, 287);
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
            this.button1.Location = new System.Drawing.Point(506, 319);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 28);
            this.button1.TabIndex = 92;
            this.button1.Text = "Eliminar Reserva";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_registro
            // 
            this.panel_registro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_registro.Controls.Add(this.label14);
            this.panel_registro.Controls.Add(this.lbl_precio);
            this.panel_registro.Controls.Add(this.lbl_numeroViaje);
            this.panel_registro.Controls.Add(this.label10);
            this.panel_registro.Controls.Add(this.cmb_destino);
            this.panel_registro.Controls.Add(this.cmb_origen);
            this.panel_registro.Controls.Add(this.lbl_cantPasajeros);
            this.panel_registro.Controls.Add(this.lbl_docTitular);
            this.panel_registro.Controls.Add(this.lbl_nombreTitular);
            this.panel_registro.Controls.Add(this.label4);
            this.panel_registro.Controls.Add(this.label3);
            this.panel_registro.Controls.Add(this.label2);
            this.panel_registro.Controls.Add(this.button_Aerolinea3);
            this.panel_registro.Controls.Add(this.btn_registrar);
            this.panel_registro.Controls.Add(this.label8);
            this.panel_registro.Controls.Add(this.label11);
            this.panel_registro.Controls.Add(this.maskedTextBox_Aerolinea2);
            this.panel_registro.Controls.Add(this.cmb_claseAsiento);
            this.panel_registro.Controls.Add(this.label9);
            this.panel_registro.Controls.Add(this.label12);
            this.panel_registro.Controls.Add(this.lbl_currentDate);
            this.panel_registro.Controls.Add(this.label13);
            this.panel_registro.Location = new System.Drawing.Point(25, 21);
            this.panel_registro.Name = "panel_registro";
            this.panel_registro.Size = new System.Drawing.Size(697, 157);
            this.panel_registro.TabIndex = 100;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label14.Location = new System.Drawing.Point(299, 67);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 16);
            this.label14.TabIndex = 113;
            this.label14.Text = "Precio:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_precio
            // 
            this.lbl_precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_precio.Location = new System.Drawing.Point(302, 93);
            this.lbl_precio.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_precio.Name = "lbl_precio";
            this.lbl_precio.Size = new System.Drawing.Size(101, 16);
            this.lbl_precio.TabIndex = 112;
            this.lbl_precio.Text = "???";
            this.lbl_precio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_numeroViaje
            // 
            this.lbl_numeroViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_numeroViaje.Location = new System.Drawing.Point(170, 118);
            this.lbl_numeroViaje.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_numeroViaje.Name = "lbl_numeroViaje";
            this.lbl_numeroViaje.Size = new System.Drawing.Size(101, 28);
            this.lbl_numeroViaje.TabIndex = 111;
            this.lbl_numeroViaje.Text = "???";
            this.lbl_numeroViaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label10.Location = new System.Drawing.Point(31, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 28);
            this.label10.TabIndex = 110;
            this.label10.Text = "Numero de Viaje";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cantPasajeros
            // 
            this.lbl_cantPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_cantPasajeros.Location = new System.Drawing.Point(600, 84);
            this.lbl_cantPasajeros.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_cantPasajeros.Name = "lbl_cantPasajeros";
            this.lbl_cantPasajeros.Size = new System.Drawing.Size(125, 34);
            this.lbl_cantPasajeros.TabIndex = 107;
            this.lbl_cantPasajeros.Text = "???";
            this.lbl_cantPasajeros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_docTitular
            // 
            this.lbl_docTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_docTitular.Location = new System.Drawing.Point(556, 46);
            this.lbl_docTitular.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_docTitular.Name = "lbl_docTitular";
            this.lbl_docTitular.Size = new System.Drawing.Size(125, 34);
            this.lbl_docTitular.TabIndex = 106;
            this.lbl_docTitular.Text = "???";
            this.lbl_docTitular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nombreTitular
            // 
            this.lbl_nombreTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_nombreTitular.Location = new System.Drawing.Point(558, 3);
            this.lbl_nombreTitular.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_nombreTitular.Name = "lbl_nombreTitular";
            this.lbl_nombreTitular.Size = new System.Drawing.Size(125, 34);
            this.lbl_nombreTitular.TabIndex = 105;
            this.lbl_nombreTitular.Text = "???";
            this.lbl_nombreTitular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(437, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 34);
            this.label4.TabIndex = 104;
            this.label4.Text = "Documento del Titular";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(437, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 34);
            this.label3.TabIndex = 103;
            this.label3.Text = "Cantidad de Pasajeros";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(437, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 34);
            this.label2.TabIndex = 102;
            this.label2.Text = "Pasajero Titular";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(32, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 105;
            this.label1.Text = "Cargar Reserva";
            // 
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Aerolinea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Aerolinea1.Location = new System.Drawing.Point(506, 254);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(87, 28);
            this.button_Aerolinea1.TabIndex = 106;
            this.button_Aerolinea1.Text = "Todos";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            this.button_Aerolinea1.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // btn_cargarPasajeros
            // 
            this.btn_cargarPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cargarPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cargarPasajeros.Location = new System.Drawing.Point(619, 299);
            this.btn_cargarPasajeros.Name = "btn_cargarPasajeros";
            this.btn_cargarPasajeros.Pp_Presionado = false;
            this.btn_cargarPasajeros.Size = new System.Drawing.Size(90, 51);
            this.btn_cargarPasajeros.TabIndex = 104;
            this.btn_cargarPasajeros.Text = "Cargar Pasajeros";
            this.btn_cargarPasajeros.UseVisualStyleBackColor = true;
            this.btn_cargarPasajeros.Click += new System.EventHandler(this.btn_cargarPasajeros_Click);
            // 
            // btn_consultarPasajeros
            // 
            this.btn_consultarPasajeros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultarPasajeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_consultarPasajeros.Location = new System.Drawing.Point(619, 240);
            this.btn_consultarPasajeros.Name = "btn_consultarPasajeros";
            this.btn_consultarPasajeros.Pp_Presionado = false;
            this.btn_consultarPasajeros.Size = new System.Drawing.Size(90, 53);
            this.btn_consultarPasajeros.TabIndex = 103;
            this.btn_consultarPasajeros.Text = "Consultar Pasajeros";
            this.btn_consultarPasajeros.UseVisualStyleBackColor = true;
            this.btn_consultarPasajeros.Click += new System.EventHandler(this.btn_consultarPasajeros_Click);
            // 
            // grid_reservas
            // 
            this.grid_reservas.AllowUserToAddRows = false;
            this.grid_reservas.AllowUserToDeleteRows = false;
            this.grid_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_reservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroReserva,
            this.fechaReserva,
            this.fechaViaje,
            this.numeroDeViaje,
            this.costo});
            this.grid_reservas.Location = new System.Drawing.Point(25, 209);
            this.grid_reservas.Name = "grid_reservas";
            this.grid_reservas.Pp_FormatoGrid = null;
            this.grid_reservas.Pp_NombreTabla = null;
            this.grid_reservas.ReadOnly = true;
            this.grid_reservas.Size = new System.Drawing.Size(466, 178);
            this.grid_reservas.TabIndex = 102;
            // 
            // cmb_destino
            // 
            this.cmb_destino.FormattingEnabled = true;
            this.cmb_destino.Location = new System.Drawing.Point(170, 97);
            this.cmb_destino.Name = "cmb_destino";
            this.cmb_destino.Pp_CampoAceptaNull = true;
            this.cmb_destino.Pp_EsPk = false;
            this.cmb_destino.Pp_MensajeError = "Cargar destino del viaje";
            this.cmb_destino.Pp_NombreCampo = "nombre";
            this.cmb_destino.Pp_NombreCampoInsert = null;
            this.cmb_destino.Pp_NombreTabla = "Aeropuerto";
            this.cmb_destino.Pp_PkTabla = "codigo";
            this.cmb_destino.Size = new System.Drawing.Size(101, 21);
            this.cmb_destino.TabIndex = 109;
            this.cmb_destino.SelectedIndexChanged += new System.EventHandler(this.cmb_destino_SelectedIndexChanged);
            // 
            // cmb_origen
            // 
            this.cmb_origen.FormattingEnabled = true;
            this.cmb_origen.Location = new System.Drawing.Point(170, 67);
            this.cmb_origen.Name = "cmb_origen";
            this.cmb_origen.Pp_CampoAceptaNull = true;
            this.cmb_origen.Pp_EsPk = false;
            this.cmb_origen.Pp_MensajeError = "Cargar origen viaje";
            this.cmb_origen.Pp_NombreCampo = "nombre";
            this.cmb_origen.Pp_NombreCampoInsert = null;
            this.cmb_origen.Pp_NombreTabla = "Aeropuerto";
            this.cmb_origen.Pp_PkTabla = "codigo";
            this.cmb_origen.Size = new System.Drawing.Size(101, 21);
            this.cmb_origen.TabIndex = 108;
            this.cmb_origen.SelectedIndexChanged += new System.EventHandler(this.cmb_origen_SelectedIndexChanged);
            // 
            // button_Aerolinea3
            // 
            this.button_Aerolinea3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Aerolinea3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_Aerolinea3.Location = new System.Drawing.Point(305, 118);
            this.button_Aerolinea3.Name = "button_Aerolinea3";
            this.button_Aerolinea3.Pp_Presionado = false;
            this.button_Aerolinea3.Size = new System.Drawing.Size(87, 28);
            this.button_Aerolinea3.TabIndex = 101;
            this.button_Aerolinea3.Text = "Registrar";
            this.button_Aerolinea3.UseVisualStyleBackColor = true;
            this.button_Aerolinea3.Click += new System.EventHandler(this.button_Aerolinea3_Click);
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
            // cmb_claseAsiento
            // 
            this.cmb_claseAsiento.FormattingEnabled = true;
            this.cmb_claseAsiento.Location = new System.Drawing.Point(302, 40);
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
            this.cmb_claseAsiento.TextChanged += new System.EventHandler(this.cmb_claseAsiento_TextChanged);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cerrar.Location = new System.Drawing.Point(506, 352);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(87, 28);
            this.btn_cerrar.TabIndex = 97;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_refrescar.Location = new System.Drawing.Point(506, 220);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Pp_Presionado = false;
            this.btn_refrescar.Size = new System.Drawing.Size(87, 28);
            this.btn_refrescar.TabIndex = 96;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            // 
            // numeroReserva
            // 
            this.numeroReserva.HeaderText = "Numero Reserva";
            this.numeroReserva.Name = "numeroReserva";
            this.numeroReserva.ReadOnly = true;
            // 
            // fechaReserva
            // 
            this.fechaReserva.HeaderText = "Fecha de reserva";
            this.fechaReserva.Name = "fechaReserva";
            this.fechaReserva.ReadOnly = true;
            // 
            // fechaViaje
            // 
            this.fechaViaje.HeaderText = "Fecha Salida";
            this.fechaViaje.Name = "fechaViaje";
            this.fechaViaje.ReadOnly = true;
            // 
            // numeroDeViaje
            // 
            this.numeroDeViaje.HeaderText = "Numero Viaje";
            this.numeroDeViaje.Name = "numeroDeViaje";
            this.numeroDeViaje.ReadOnly = true;
            // 
            // costo
            // 
            this.costo.HeaderText = "Precio";
            this.costo.Name = "costo";
            this.costo.ReadOnly = true;
            // 
            // Frm_ABMReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 413);
            this.Controls.Add(this.button_Aerolinea1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cargarPasajeros);
            this.Controls.Add(this.btn_consultarPasajeros);
            this.Controls.Add(this.grid_reservas);
            this.Controls.Add(this.panel_registro);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_refrescar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_modificar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_ABMReservas";
            this.Text = "Frm_ABMReservas";
            this.Load += new System.EventHandler(this.Frm_ABMReservas_Load);
            this.panel_registro.ResumeLayout(false);
            this.panel_registro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_reservas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private Clase.MaskedTextBox_Aerolinea maskedTextBox_Aerolinea2;
        private Clase.ComboBox_Aerolinea cmb_claseAsiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_currentDate;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button button1;
        private Clase.Button_Aerolinea btn_refrescar;
        private Clase.Button_Aerolinea btn_cerrar;
        private System.Windows.Forms.Panel panel_registro;
        private Clase.Button_Aerolinea button_Aerolinea3;
        private Clase.DataGridView_Aerolinea grid_reservas;
        private Clase.Button_Aerolinea btn_consultarPasajeros;
        private Clase.Button_Aerolinea btn_cargarPasajeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cantPasajeros;
        private System.Windows.Forms.Label lbl_docTitular;
        private System.Windows.Forms.Label lbl_nombreTitular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Clase.ComboBox_Aerolinea cmb_destino;
        private Clase.ComboBox_Aerolinea cmb_origen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_precio;
        private System.Windows.Forms.Label lbl_numeroViaje;
        private System.Windows.Forms.Label label10;
        private Clase.Button_Aerolinea button_Aerolinea1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaReserva;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDeViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
    }
}