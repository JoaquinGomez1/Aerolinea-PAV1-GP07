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
            this.maskedTextBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.button_Aerolinea1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Aerolinea2 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.grid_pasajeros = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            ((System.ComponentModel.ISupportInitialize)(this.grid_pasajeros)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(633, 337);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(71, 26);
            this.btn_registrar.TabIndex = 0;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(30, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar pasajero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tipo Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numero Documento";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.Location = new System.Drawing.Point(-27, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 18);
            this.label4.TabIndex = 74;
            this.label4.Text = "Fecha Nacimiento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label6.Location = new System.Drawing.Point(-15, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 16);
            this.label6.TabIndex = 64;
            this.label6.Text = "Tipo de Documento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.Location = new System.Drawing.Point(-27, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 18);
            this.label7.TabIndex = 63;
            this.label7.Text = "Número de documento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label5.Location = new System.Drawing.Point(45, 194);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 66;
            this.label5.Text = "Apellido";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.Location = new System.Drawing.Point(71, 163);
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
            this.lbl_nombre.Location = new System.Drawing.Point(155, 163);
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
            this.lbl_nDoc.Location = new System.Drawing.Point(155, 256);
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
            this.lbl_tipoDoc.Location = new System.Drawing.Point(155, 222);
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
            this.lbl_apellido.Location = new System.Drawing.Point(155, 192);
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
            this.lbl_fechaNacimiento.Location = new System.Drawing.Point(155, 287);
            this.lbl_fechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_fechaNacimiento.Name = "lbl_fechaNacimiento";
            this.lbl_fechaNacimiento.Size = new System.Drawing.Size(70, 16);
            this.lbl_fechaNacimiento.TabIndex = 79;
            this.lbl_fechaNacimiento.Text = "???";
            this.lbl_fechaNacimiento.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label8.Location = new System.Drawing.Point(516, 23);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 80;
            this.label8.Text = "Fecha actual";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label11.Location = new System.Drawing.Point(492, 54);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 16);
            this.label11.TabIndex = 82;
            this.label11.Text = "Asignar fecha viaje";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label9.Location = new System.Drawing.Point(498, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 85;
            this.label9.Text = "Clase de asiento";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label12.Location = new System.Drawing.Point(252, 50);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 16);
            this.label12.TabIndex = 86;
            this.label12.Text = "Origen del viaje";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label13.Location = new System.Drawing.Point(251, 83);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 16);
            this.label13.TabIndex = 87;
            this.label13.Text = "Destino del viaje";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_currentDate
            // 
            this.lbl_currentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_currentDate.Location = new System.Drawing.Point(586, 23);
            this.lbl_currentDate.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.lbl_currentDate.Name = "lbl_currentDate";
            this.lbl_currentDate.Size = new System.Drawing.Size(134, 16);
            this.lbl_currentDate.TabIndex = 90;
            this.lbl_currentDate.Text = "Fecha actual";
            this.lbl_currentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Aerolinea2
            // 
            this.textBox_Aerolinea2.Location = new System.Drawing.Point(363, 83);
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
            this.textBox_Aerolinea1.Location = new System.Drawing.Point(362, 47);
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
            this.cmb_claseAsiento.Location = new System.Drawing.Point(603, 85);
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
            this.maskedTextBox_Aerolinea2.Location = new System.Drawing.Point(603, 54);
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
            this.cmb_tipoDoc.Location = new System.Drawing.Point(128, 81);
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
            // maskedTextBox_Aerolinea1
            // 
            this.maskedTextBox_Aerolinea1.Location = new System.Drawing.Point(128, 51);
            this.maskedTextBox_Aerolinea1.Mask = "00000000";
            this.maskedTextBox_Aerolinea1.Name = "maskedTextBox_Aerolinea1";
            this.maskedTextBox_Aerolinea1.Pp_EsPk = false;
            this.maskedTextBox_Aerolinea1.Pp_MensajeError = null;
            this.maskedTextBox_Aerolinea1.Pp_NombreCampo = null;
            this.maskedTextBox_Aerolinea1.Pp_NombreTabla = null;
            this.maskedTextBox_Aerolinea1.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBox_Aerolinea1.TabIndex = 4;
            this.maskedTextBox_Aerolinea1.ValidatingType = typeof(int);
            // 
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.Location = new System.Drawing.Point(50, 112);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(75, 23);
            this.button_Aerolinea1.TabIndex = 3;
            this.button_Aerolinea1.Text = "Buscar";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(23, 337);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(102, 26);
            this.btn_modificar.TabIndex = 91;
            this.btn_modificar.Text = "Modificar Reserva";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 26);
            this.button1.TabIndex = 92;
            this.button1.Text = "Eliminar Reserva";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button_Aerolinea2
            // 
            this.button_Aerolinea2.Location = new System.Drawing.Point(150, 112);
            this.button_Aerolinea2.Name = "button_Aerolinea2";
            this.button_Aerolinea2.Pp_Presionado = false;
            this.button_Aerolinea2.Size = new System.Drawing.Size(75, 23);
            this.button_Aerolinea2.TabIndex = 93;
            this.button_Aerolinea2.Text = "Agregar";
            this.button_Aerolinea2.UseVisualStyleBackColor = true;
            // 
            // grid_pasajeros
            // 
            this.grid_pasajeros.AllowUserToAddRows = false;
            this.grid_pasajeros.AllowUserToDeleteRows = false;
            this.grid_pasajeros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_pasajeros.Location = new System.Drawing.Point(255, 122);
            this.grid_pasajeros.Name = "grid_pasajeros";
            this.grid_pasajeros.Pp_FormatoGrid = "nombre, Nombre, 120;apellido,Apellido, 120;tipoDoc, Tipo Documento, 65;numeroDoc," +
    " Número de documento, 100";
            this.grid_pasajeros.Pp_NombreTabla = "";
            this.grid_pasajeros.ReadOnly = true;
            this.grid_pasajeros.Size = new System.Drawing.Size(449, 201);
            this.grid_pasajeros.TabIndex = 94;
            // 
            // Frm_ABMReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 374);
            this.Controls.Add(this.grid_pasajeros);
            this.Controls.Add(this.button_Aerolinea2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.lbl_currentDate);
            this.Controls.Add(this.textBox_Aerolinea2);
            this.Controls.Add(this.textBox_Aerolinea1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_claseAsiento);
            this.Controls.Add(this.maskedTextBox_Aerolinea2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_fechaNacimiento);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_tipoDoc);
            this.Controls.Add(this.lbl_nDoc);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_tipoDoc);
            this.Controls.Add(this.maskedTextBox_Aerolinea1);
            this.Controls.Add(this.button_Aerolinea1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_ABMReservas";
            this.Text = "Frm_ABMReservas";
            this.Load += new System.EventHandler(this.Frm_ABMReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_pasajeros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Label label1;
        private Clase.Button_Aerolinea button_Aerolinea1;
        private Clase.MaskedTextBox_Aerolinea maskedTextBox_Aerolinea1;
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
        private Clase.Button_Aerolinea button_Aerolinea2;
        private Clase.DataGridView_Aerolinea grid_pasajeros;
    }
}