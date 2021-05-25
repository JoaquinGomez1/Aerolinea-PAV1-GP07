
namespace TrabajoPrácticoPAV.Formularios.Reservas
{
    partial class Frm_CargarPasajerosPorReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CargarPasajerosPorReserva));
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_aceptar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.lbl_titularReserva = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_refrescar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.grid_pasajeros = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_nDoc = new System.Windows.Forms.Label();
            this.lbl_tipoDoc = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_fechaNacimiento = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_tipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Aerolinea1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Mtxt_numeroDoc = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Aerolinea2 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pasajeros)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Btn_Minimizar);
            this.BarraSuperior.Controls.Add(this.Btn_Cerrar);
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(752, 32);
            this.BarraSuperior.TabIndex = 107;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(693, 4);
            this.Btn_Minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(22, 24);
            this.Btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Minimizar.TabIndex = 6;
            this.Btn_Minimizar.TabStop = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(719, 4);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(22, 24);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 5;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(9, 6);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(180, 22);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "CARGAR PASAJEROS";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_aceptar);
            this.panel3.Controls.Add(this.lbl_titularReserva);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.btn_cancelar);
            this.panel3.Controls.Add(this.btn_refrescar);
            this.panel3.Controls.Add(this.grid_pasajeros);
            this.panel3.Controls.Add(this.btn_eliminar);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(752, 412);
            this.panel3.Size = new System.Drawing.Size(752, 414);
            this.panel3.TabIndex = 116;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_aceptar.Location = new System.Drawing.Point(251, 368);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Pp_Presionado = false;
            this.btn_aceptar.Size = new System.Drawing.Size(90, 28);
            this.btn_aceptar.TabIndex = 124;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lbl_titularReserva
            // 
            this.lbl_titularReserva.AutoSize = true;
            this.lbl_titularReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_titularReserva.Location = new System.Drawing.Point(483, 38);
            this.lbl_titularReserva.Name = "lbl_titularReserva";
            this.lbl_titularReserva.Size = new System.Drawing.Size(32, 17);
            this.lbl_titularReserva.TabIndex = 123;
            this.lbl_titularReserva.Text = "???";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(282, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(153, 17);
            this.label15.TabIndex = 120;
            this.label15.Text = "Titular de Reserva: ";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cancelar.Location = new System.Drawing.Point(411, 368);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Pp_Presionado = false;
            this.btn_cancelar.Size = new System.Drawing.Size(90, 28);
            this.btn_cancelar.TabIndex = 122;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_refrescar.Location = new System.Drawing.Point(639, 155);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Pp_Presionado = false;
            this.btn_refrescar.Size = new System.Drawing.Size(90, 28);
            this.btn_refrescar.TabIndex = 121;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            // 
            // grid_pasajeros
            // 
            this.grid_pasajeros.AllowUserToAddRows = false;
            this.grid_pasajeros.AllowUserToDeleteRows = false;
            this.grid_pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_pasajeros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.apellido,
            this.tipoDoc,
            this.numeroDoc});
            this.grid_pasajeros.Location = new System.Drawing.Point(285, 66);
            this.grid_pasajeros.Name = "grid_pasajeros";
            this.grid_pasajeros.Pp_FormatoGrid = "nombre, Nombre, 120;apellido,Apellido, 120;tipoDoc, Tipo Documento, 65;numeroDoc," +
    " Número de documento, 100";
            this.grid_pasajeros.Pp_NombreTabla = "Pasajero";
            this.grid_pasajeros.ReadOnly = true;
            this.grid_pasajeros.Size = new System.Drawing.Size(340, 213);
            this.grid_pasajeros.TabIndex = 119;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // tipoDoc
            // 
            this.tipoDoc.HeaderText = "Tipo Documento";
            this.tipoDoc.Name = "tipoDoc";
            this.tipoDoc.ReadOnly = true;
            // 
            // numeroDoc
            // 
            this.numeroDoc.HeaderText = "Documento";
            this.numeroDoc.Name = "numeroDoc";
            this.numeroDoc.ReadOnly = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_eliminar.Location = new System.Drawing.Point(639, 188);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 28);
            this.btn_eliminar.TabIndex = 118;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
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
            this.panel2.Location = new System.Drawing.Point(17, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 175);
            this.panel2.TabIndex = 117;
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmb_tipoDoc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button_Aerolinea1);
            this.panel1.Controls.Add(this.Mtxt_numeroDoc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_Aerolinea2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(17, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 136);
            this.panel1.TabIndex = 116;
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
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Aerolinea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_Aerolinea1.Location = new System.Drawing.Point(9, 91);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(90, 28);
            this.button_Aerolinea1.TabIndex = 3;
            this.button_Aerolinea1.Text = "Buscar";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            this.button_Aerolinea1.Click += new System.EventHandler(this.button_Aerolinea1_Click);
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
            // button_Aerolinea2
            // 
            this.button_Aerolinea2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Aerolinea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_Aerolinea2.Location = new System.Drawing.Point(121, 91);
            this.button_Aerolinea2.Name = "button_Aerolinea2";
            this.button_Aerolinea2.Pp_Presionado = false;
            this.button_Aerolinea2.Size = new System.Drawing.Size(90, 28);
            this.button_Aerolinea2.TabIndex = 93;
            this.button_Aerolinea2.Text = "Agregar";
            this.button_Aerolinea2.UseVisualStyleBackColor = true;
            this.button_Aerolinea2.Click += new System.EventHandler(this.button_Aerolinea2_Click);
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
            // Frm_CargarPasajerosPorReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 444);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_CargarPasajerosPorReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_CargarPasajerosPorReserva";
            this.Load += new System.EventHandler(this.Frm_CargarPasajerosPorReserva_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pasajeros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.PictureBox Btn_Minimizar;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel panel3;
        private Clase.Button_Aerolinea btn_aceptar;
        private System.Windows.Forms.Label lbl_titularReserva;
        private System.Windows.Forms.Label label15;
        private Clase.Button_Aerolinea btn_cancelar;
        private Clase.Button_Aerolinea btn_refrescar;
        private Clase.DataGridView_Aerolinea grid_pasajeros;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_nDoc;
        private System.Windows.Forms.Label lbl_tipoDoc;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_fechaNacimiento;
        private System.Windows.Forms.Panel panel1;
        private Clase.ComboBox_Aerolinea cmb_tipoDoc;
        private System.Windows.Forms.Label label1;
        private Clase.Button_Aerolinea button_Aerolinea1;
        private Clase.MaskedTextBox_Aerolinea Mtxt_numeroDoc;
        private System.Windows.Forms.Label label2;
        private Clase.Button_Aerolinea button_Aerolinea2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDoc;
    }
}