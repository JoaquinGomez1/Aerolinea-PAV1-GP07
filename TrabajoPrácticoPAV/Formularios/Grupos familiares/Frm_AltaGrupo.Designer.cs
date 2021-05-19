namespace TrabajoPrácticoPAV.Formularios.Grupos_familiares
{
    partial class Frm_AltaGrupo
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
            this.chk_Todos = new System.Windows.Forms.CheckBox();
            this.Msktxt_NumeroDOC = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.Txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label6 = new System.Windows.Forms.Label();
            this.Grid_Pasajero = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Cmb_TipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Apellido = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Panel_Busqueda = new System.Windows.Forms.Panel();
            this.Btn_AgregarPrimero = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_AgregarSegundo = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Grid_Grupo = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.Btn_Registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.tipoDoc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDoc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoP1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDoc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDoc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoP2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Pasajero)).BeginInit();
            this.Panel_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Grupo)).BeginInit();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Todos
            // 
            this.chk_Todos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chk_Todos.Location = new System.Drawing.Point(580, 102);
            this.chk_Todos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(72, 24);
            this.chk_Todos.TabIndex = 69;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // Msktxt_NumeroDOC
            // 
            this.Msktxt_NumeroDOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Msktxt_NumeroDOC.Location = new System.Drawing.Point(390, 57);
            this.Msktxt_NumeroDOC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Msktxt_NumeroDOC.Mask = "99999999";
            this.Msktxt_NumeroDOC.Name = "Msktxt_NumeroDOC";
            this.Msktxt_NumeroDOC.Pp_EsPk = false;
            this.Msktxt_NumeroDOC.Pp_MensajeError = null;
            this.Msktxt_NumeroDOC.Pp_NombreCampo = "numeroDoc";
            this.Msktxt_NumeroDOC.Pp_NombreTabla = "Pasajero";
            this.Msktxt_NumeroDOC.Size = new System.Drawing.Size(78, 26);
            this.Msktxt_NumeroDOC.TabIndex = 68;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_nombre.Location = new System.Drawing.Point(88, 25);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Pp_EsPk = false;
            this.Txt_nombre.Pp_MensajeError = "Escribe tu nombre";
            this.Txt_nombre.Pp_NombreCampo = "nombre";
            this.Txt_nombre.Pp_NombreTabla = "Pasajero";
            this.Txt_nombre.Size = new System.Drawing.Size(114, 26);
            this.Txt_nombre.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(237, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 60;
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
            this.Grid_Pasajero.Location = new System.Drawing.Point(7, 93);
            this.Grid_Pasajero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grid_Pasajero.MultiSelect = false;
            this.Grid_Pasajero.Name = "Grid_Pasajero";
            this.Grid_Pasajero.Pp_FormatoGrid = "nombre, Nombre, 175;apellido,Apellido, 175;tipoDoc, Tipo Documento, 65;numeroDoc," +
    " Número de documento, 100";
            this.Grid_Pasajero.Pp_NombreTabla = "Pasajero";
            this.Grid_Pasajero.ReadOnly = true;
            this.Grid_Pasajero.RowTemplate.Height = 24;
            this.Grid_Pasajero.Size = new System.Drawing.Size(384, 198);
            this.Grid_Pasajero.TabIndex = 67;
            this.Grid_Pasajero.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Pasajero_CellClick);
            this.Grid_Pasajero.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Pasajero_CellContentDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(217, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 20);
            this.label7.TabIndex = 59;
            this.label7.Text = "Número de documento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 17);
            this.label14.TabIndex = 63;
            this.label14.Text = "Filtros de búsqueda";
            // 
            // Cmb_TipoDoc
            // 
            this.Cmb_TipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cmb_TipoDoc.FormattingEnabled = true;
            this.Cmb_TipoDoc.Location = new System.Drawing.Point(390, 25);
            this.Cmb_TipoDoc.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.Cmb_TipoDoc.Name = "Cmb_TipoDoc";
            this.Cmb_TipoDoc.Pp_CampoAceptaNull = false;
            this.Cmb_TipoDoc.Pp_EsPk = false;
            this.Cmb_TipoDoc.Pp_MensajeError = "Seleccionar Tipo Doc";
            this.Cmb_TipoDoc.Pp_NombreCampo = "nombreTipoDoc";
            this.Cmb_TipoDoc.Pp_NombreCampoInsert = "tipoDoc";
            this.Cmb_TipoDoc.Pp_NombreTabla = "Tipo_Documento";
            this.Cmb_TipoDoc.Pp_PkTabla = "tipoDoc";
            this.Cmb_TipoDoc.Size = new System.Drawing.Size(78, 28);
            this.Cmb_TipoDoc.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(16, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 61;
            this.label3.Text = "Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 15, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Nombre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Apellido.Location = new System.Drawing.Point(88, 57);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Pp_EsPk = false;
            this.Txt_Apellido.Pp_MensajeError = "Escribe tu apellido";
            this.Txt_Apellido.Pp_NombreCampo = "apellido";
            this.Txt_Apellido.Pp_NombreTabla = "Pasajero";
            this.Txt_Apellido.Size = new System.Drawing.Size(114, 26);
            this.Txt_Apellido.TabIndex = 65;
            // 
            // Panel_Busqueda
            // 
            this.Panel_Busqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel_Busqueda.Controls.Add(this.Btn_AgregarPrimero);
            this.Panel_Busqueda.Controls.Add(this.Btn_AgregarSegundo);
            this.Panel_Busqueda.Controls.Add(this.chk_Todos);
            this.Panel_Busqueda.Controls.Add(this.Btn_Buscar);
            this.Panel_Busqueda.Controls.Add(this.label14);
            this.Panel_Busqueda.Controls.Add(this.Msktxt_NumeroDOC);
            this.Panel_Busqueda.Controls.Add(this.Txt_Apellido);
            this.Panel_Busqueda.Controls.Add(this.Txt_nombre);
            this.Panel_Busqueda.Controls.Add(this.label4);
            this.Panel_Busqueda.Controls.Add(this.label6);
            this.Panel_Busqueda.Controls.Add(this.label3);
            this.Panel_Busqueda.Controls.Add(this.Grid_Pasajero);
            this.Panel_Busqueda.Controls.Add(this.Cmb_TipoDoc);
            this.Panel_Busqueda.Controls.Add(this.label7);
            this.Panel_Busqueda.Location = new System.Drawing.Point(10, 36);
            this.Panel_Busqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Panel_Busqueda.Name = "Panel_Busqueda";
            this.Panel_Busqueda.Size = new System.Drawing.Size(476, 305);
            this.Panel_Busqueda.TabIndex = 70;
            // 
            // Btn_AgregarPrimero
            // 
            this.Btn_AgregarPrimero.Enabled = false;
            this.Btn_AgregarPrimero.Location = new System.Drawing.Point(395, 204);
            this.Btn_AgregarPrimero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_AgregarPrimero.Name = "Btn_AgregarPrimero";
            this.Btn_AgregarPrimero.Pp_Presionado = false;
            this.Btn_AgregarPrimero.Size = new System.Drawing.Size(71, 41);
            this.Btn_AgregarPrimero.TabIndex = 71;
            this.Btn_AgregarPrimero.Text = "Primer Pasajero";
            this.Btn_AgregarPrimero.UseVisualStyleBackColor = true;
            this.Btn_AgregarPrimero.Click += new System.EventHandler(this.Btn_AgregarPrimero_Click);
            // 
            // Btn_AgregarSegundo
            // 
            this.Btn_AgregarSegundo.Enabled = false;
            this.Btn_AgregarSegundo.Location = new System.Drawing.Point(395, 250);
            this.Btn_AgregarSegundo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_AgregarSegundo.Name = "Btn_AgregarSegundo";
            this.Btn_AgregarSegundo.Pp_Presionado = false;
            this.Btn_AgregarSegundo.Size = new System.Drawing.Size(71, 41);
            this.Btn_AgregarSegundo.TabIndex = 72;
            this.Btn_AgregarSegundo.Text = "Segundo Pasajero";
            this.Btn_AgregarSegundo.UseVisualStyleBackColor = true;
            this.Btn_AgregarSegundo.Click += new System.EventHandler(this.Btn_AgregarSegundo_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(395, 93);
            this.Btn_Buscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Pp_Presionado = false;
            this.Btn_Buscar.Size = new System.Drawing.Size(71, 41);
            this.Btn_Buscar.TabIndex = 70;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Location = new System.Drawing.Point(490, 348);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Pp_Presionado = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(71, 31);
            this.Btn_Cerrar.TabIndex = 73;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Grid_Grupo
            // 
            this.Grid_Grupo.AllowUserToAddRows = false;
            this.Grid_Grupo.AllowUserToDeleteRows = false;
            this.Grid_Grupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Grupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoDoc1,
            this.numeroDoc1,
            this.nombreP1,
            this.apellidoP1,
            this.relacion,
            this.tipoDoc2,
            this.numeroDoc2,
            this.nombreP2,
            this.apellidoP2});
            this.Grid_Grupo.Location = new System.Drawing.Point(490, 36);
            this.Grid_Grupo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Grid_Grupo.Name = "Grid_Grupo";
            this.Grid_Grupo.Pp_FormatoGrid = null;
            this.Grid_Grupo.Pp_NombreTabla = null;
            this.Grid_Grupo.RowTemplate.Height = 24;
            this.Grid_Grupo.Size = new System.Drawing.Size(432, 305);
            this.Grid_Grupo.TabIndex = 72;
            this.Grid_Grupo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Grupo_CellContentDoubleClick);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.Location = new System.Drawing.Point(415, 348);
            this.Btn_Registrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Pp_Presionado = false;
            this.Btn_Registrar.Size = new System.Drawing.Size(71, 31);
            this.Btn_Registrar.TabIndex = 74;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = true;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(932, 32);
            this.BarraSuperior.TabIndex = 73;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(9, 6);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(190, 22);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "REGISTRAR RELACIÓN";
            // 
            // tipoDoc1
            // 
            this.tipoDoc1.HeaderText = "Column1";
            this.tipoDoc1.Name = "tipoDoc1";
            this.tipoDoc1.Visible = false;
            // 
            // numeroDoc1
            // 
            this.numeroDoc1.HeaderText = "Column1";
            this.numeroDoc1.Name = "numeroDoc1";
            this.numeroDoc1.Visible = false;
            // 
            // nombreP1
            // 
            this.nombreP1.HeaderText = "Nombre";
            this.nombreP1.Name = "nombreP1";
            this.nombreP1.ReadOnly = true;
            this.nombreP1.Width = 80;
            // 
            // apellidoP1
            // 
            this.apellidoP1.HeaderText = "Apellido";
            this.apellidoP1.Name = "apellidoP1";
            this.apellidoP1.ReadOnly = true;
            // 
            // relacion
            // 
            this.relacion.HeaderText = "Relación";
            this.relacion.MaxInputLength = 20;
            this.relacion.Name = "relacion";
            this.relacion.Width = 55;
            // 
            // tipoDoc2
            // 
            this.tipoDoc2.HeaderText = "Column1";
            this.tipoDoc2.Name = "tipoDoc2";
            this.tipoDoc2.Visible = false;
            // 
            // numeroDoc2
            // 
            this.numeroDoc2.HeaderText = "Column1";
            this.numeroDoc2.Name = "numeroDoc2";
            this.numeroDoc2.Visible = false;
            // 
            // nombreP2
            // 
            this.nombreP2.HeaderText = "Nombre";
            this.nombreP2.Name = "nombreP2";
            this.nombreP2.ReadOnly = true;
            this.nombreP2.Width = 80;
            // 
            // apellidoP2
            // 
            this.apellidoP2.HeaderText = "Apellido";
            this.apellidoP2.Name = "apellidoP2";
            this.apellidoP2.ReadOnly = true;
            // 
            // Frm_AltaGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 383);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.Grid_Grupo);
            this.Controls.Add(this.Panel_Busqueda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_AltaGrupo";
            this.Text = "Frm_AltaGrupo";
            this.Load += new System.EventHandler(this.Frm_AltaGrupo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Pasajero)).EndInit();
            this.Panel_Busqueda.ResumeLayout(false);
            this.Panel_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Grupo)).EndInit();
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Todos;
        private Clase.MaskedTextBox_Aerolinea Msktxt_NumeroDOC;
        private Clase.TextBox_Aerolinea Txt_nombre;
        private System.Windows.Forms.Label label6;
        private Clase.DataGridView_Aerolinea Grid_Pasajero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private Clase.ComboBox_Aerolinea Cmb_TipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Clase.TextBox_Aerolinea Txt_Apellido;
        private System.Windows.Forms.Panel Panel_Busqueda;
        private Clase.Button_Aerolinea Btn_Cerrar;
        private Clase.Button_Aerolinea Btn_AgregarSegundo;
        private Clase.DataGridView_Aerolinea Grid_Grupo;
        private Clase.Button_Aerolinea Btn_Buscar;
        private Clase.Button_Aerolinea Btn_AgregarPrimero;
        private Clase.Button_Aerolinea Btn_Registrar;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDoc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoP1;
        private System.Windows.Forms.DataGridViewTextBoxColumn relacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDoc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDoc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreP2;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoP2;
    }
}