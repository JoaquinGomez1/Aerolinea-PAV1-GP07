namespace TrabajoPrácticoPAV.Formularios.Pasajeros
{
    partial class Frm_ABMPasajeros
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
            this.Txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.btn_cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label6 = new System.Windows.Forms.Label();
            this.Grid_Pasajero = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Cmb_TipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Btn_Buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.chk_Todos = new System.Windows.Forms.CheckBox();
            this.Btn_Modificar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Limpiar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Pasajero)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Msktxt_NumeroDOC
            // 
            this.Msktxt_NumeroDOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Msktxt_NumeroDOC.Location = new System.Drawing.Point(574, 120);
            this.Msktxt_NumeroDOC.Mask = "99999999";
            this.Msktxt_NumeroDOC.Name = "Msktxt_NumeroDOC";
            this.Msktxt_NumeroDOC.Pp_EsPk = false;
            this.Msktxt_NumeroDOC.Pp_MensajeError = null;
            this.Msktxt_NumeroDOC.Pp_NombreCampo = "numeroDoc";
            this.Msktxt_NumeroDOC.Pp_NombreTabla = "Pasajero";
            this.Msktxt_NumeroDOC.Size = new System.Drawing.Size(100, 30);
            this.Msktxt_NumeroDOC.TabIndex = 57;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_nombre.Location = new System.Drawing.Point(172, 81);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Pp_EsPk = false;
            this.Txt_nombre.Pp_MensajeError = "Escribe tu nombre";
            this.Txt_nombre.Pp_NombreCampo = "nombre";
            this.Txt_nombre.Pp_NombreTabla = "Pasajero";
            this.Txt_nombre.Size = new System.Drawing.Size(148, 30);
            this.Txt_nombre.TabIndex = 41;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cancelar.Location = new System.Drawing.Point(55, 476);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Pp_Presionado = false;
            this.btn_cancelar.Size = new System.Drawing.Size(102, 34);
            this.btn_cancelar.TabIndex = 55;
            this.btn_cancelar.Text = "Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(368, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tipo de Documento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Grid_Pasajero
            // 
            this.Grid_Pasajero.AllowUserToAddRows = false;
            this.Grid_Pasajero.AllowUserToDeleteRows = false;
            this.Grid_Pasajero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid_Pasajero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Pasajero.Location = new System.Drawing.Point(46, 179);
            this.Grid_Pasajero.MultiSelect = false;
            this.Grid_Pasajero.Name = "Grid_Pasajero";
            this.Grid_Pasajero.Pp_FormatoGrid = "nombre, Nombre, 175;apellido,Apellido, 175;tipoDoc, Tipo Documento, 65;numeroDoc," +
    " Número de documento, 100";
            this.Grid_Pasajero.Pp_NombreTabla = "Pasajero";
            this.Grid_Pasajero.ReadOnly = true;
            this.Grid_Pasajero.RowTemplate.Height = 24;
            this.Grid_Pasajero.Size = new System.Drawing.Size(778, 268);
            this.Grid_Pasajero.TabIndex = 56;
            this.Grid_Pasajero.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Pasajero_CellClick);
            this.Grid_Pasajero.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Pasajero_CellContentDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(341, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 25);
            this.label7.TabIndex = 31;
            this.label7.Text = "Número de documento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(50, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 20);
            this.label14.TabIndex = 40;
            this.label14.Text = "Filtros de búsqueda";
            // 
            // Cmb_TipoDoc
            // 
            this.Cmb_TipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cmb_TipoDoc.FormattingEnabled = true;
            this.Cmb_TipoDoc.Location = new System.Drawing.Point(574, 81);
            this.Cmb_TipoDoc.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Cmb_TipoDoc.Name = "Cmb_TipoDoc";
            this.Cmb_TipoDoc.Pp_CampoAceptaNull = false;
            this.Cmb_TipoDoc.Pp_EsPk = false;
            this.Cmb_TipoDoc.Pp_MensajeError = "Seleccionar Tipo Doc";
            this.Cmb_TipoDoc.Pp_NombreCampo = "nombreTipoDoc";
            this.Cmb_TipoDoc.Pp_NombreCampoInsert = "tipoDoc";
            this.Cmb_TipoDoc.Pp_NombreTabla = "Tipo_Documento";
            this.Cmb_TipoDoc.Pp_PkTabla = "tipoDoc";
            this.Cmb_TipoDoc.Size = new System.Drawing.Size(100, 33);
            this.Cmb_TipoDoc.TabIndex = 46;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_registrar.Location = new System.Drawing.Point(846, 251);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Pp_Presionado = false;
            this.btn_registrar.Size = new System.Drawing.Size(127, 50);
            this.btn_registrar.TabIndex = 54;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(74, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 28);
            this.label1.TabIndex = 28;
            this.label1.Text = "Registrar Pasajero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(75, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nombre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Apellido.Location = new System.Drawing.Point(172, 120);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Pp_EsPk = false;
            this.Txt_Apellido.Pp_MensajeError = "Escribe tu apellido";
            this.Txt_Apellido.Pp_NombreCampo = "apellido";
            this.Txt_Apellido.Pp_NombreTabla = "Pasajero";
            this.Txt_Apellido.Size = new System.Drawing.Size(148, 30);
            this.Txt_Apellido.TabIndex = 43;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Buscar.Location = new System.Drawing.Point(846, 179);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Pp_Presionado = false;
            this.Btn_Buscar.Size = new System.Drawing.Size(127, 50);
            this.Btn_Buscar.TabIndex = 51;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // chk_Todos
            // 
            this.chk_Todos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chk_Todos.Location = new System.Drawing.Point(734, 130);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(90, 29);
            this.chk_Todos.TabIndex = 58;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Modificar.Enabled = false;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Modificar.Location = new System.Drawing.Point(846, 323);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Pp_Presionado = false;
            this.Btn_Modificar.Size = new System.Drawing.Size(127, 50);
            this.Btn_Modificar.TabIndex = 60;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Limpiar.Location = new System.Drawing.Point(161, 476);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Pp_Presionado = false;
            this.Btn_Limpiar.Size = new System.Drawing.Size(102, 34);
            this.Btn_Limpiar.TabIndex = 61;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Eliminar.Enabled = false;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Eliminar.Location = new System.Drawing.Point(846, 395);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Pp_Presionado = false;
            this.Btn_Eliminar.Size = new System.Drawing.Size(127, 50);
            this.Btn_Eliminar.TabIndex = 59;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 485);
            this.panel1.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(32, 37);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 111);
            this.panel3.TabIndex = 0;
            // 
            // Frm_ABMPasajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 514);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.chk_Todos);
            this.Controls.Add(this.Msktxt_NumeroDOC);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Grid_Pasajero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Cmb_TipoDoc);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABMPasajeros";
            this.Load += new System.EventHandler(this.Frm_ABMPasajeros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Pasajero)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.MaskedTextBox_Aerolinea Msktxt_NumeroDOC;
        private Clase.TextBox_Aerolinea Txt_nombre;
        private Clase.Button_Aerolinea btn_cancelar;
        private System.Windows.Forms.Label label6;
        private Clase.DataGridView_Aerolinea Grid_Pasajero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private Clase.ComboBox_Aerolinea Cmb_TipoDoc;
        private Clase.Button_Aerolinea btn_registrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Clase.TextBox_Aerolinea Txt_Apellido;
        private Clase.Button_Aerolinea Btn_Buscar;
        private System.Windows.Forms.CheckBox chk_Todos;
        private Clase.Button_Aerolinea Btn_Modificar;
        private Clase.Button_Aerolinea Btn_Limpiar;
        private Clase.Button_Aerolinea Btn_Eliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
    }
}