namespace TrabajoPrácticoPAV.Formularios.Grupos_familiares
{
    partial class Frm_ABMGrupoFamiliar
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chk_Todos = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Msktxt_NumeroDOC = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.Txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Cmb_TipoDoc = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.Txt_Apellido = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Btn_Cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_limpiar1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Consultar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Btn_Modificar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.grid_Familiares = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.tipodoc1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipodoc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Familiares)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(49, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Filtros de búsqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Buscar Grupo Familiar";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(974, 485);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(32, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 111);
            this.panel2.TabIndex = 0;
            // 
            // chk_Todos
            // 
            this.chk_Todos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_Todos.AutoSize = true;
            this.chk_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chk_Todos.Location = new System.Drawing.Point(734, 131);
            this.chk_Todos.Name = "chk_Todos";
            this.chk_Todos.Size = new System.Drawing.Size(90, 29);
            this.chk_Todos.TabIndex = 67;
            this.chk_Todos.Text = "Todos";
            this.chk_Todos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(368, 82);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Tipo de Documento";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(341, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Número de documento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(74, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "Apellido";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(75, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 18, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 62;
            this.label4.Text = "Nombre";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Msktxt_NumeroDOC
            // 
            this.Msktxt_NumeroDOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Msktxt_NumeroDOC.Location = new System.Drawing.Point(574, 121);
            this.Msktxt_NumeroDOC.Mask = "99999999";
            this.Msktxt_NumeroDOC.Name = "Msktxt_NumeroDOC";
            this.Msktxt_NumeroDOC.Pp_EsPk = false;
            this.Msktxt_NumeroDOC.Pp_MensajeError = null;
            this.Msktxt_NumeroDOC.Pp_NombreCampo = "numeroDoc";
            this.Msktxt_NumeroDOC.Pp_NombreTabla = "Pasajero";
            this.Msktxt_NumeroDOC.Size = new System.Drawing.Size(100, 30);
            this.Msktxt_NumeroDOC.TabIndex = 66;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_nombre.Location = new System.Drawing.Point(172, 82);
            this.Txt_nombre.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Pp_EsPk = false;
            this.Txt_nombre.Pp_MensajeError = "Escribe tu nombre";
            this.Txt_nombre.Pp_NombreCampo = "nombre";
            this.Txt_nombre.Pp_NombreTabla = "Pasajero";
            this.Txt_nombre.Size = new System.Drawing.Size(148, 30);
            this.Txt_nombre.TabIndex = 63;
            // 
            // Cmb_TipoDoc
            // 
            this.Cmb_TipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Cmb_TipoDoc.FormattingEnabled = true;
            this.Cmb_TipoDoc.Location = new System.Drawing.Point(574, 82);
            this.Cmb_TipoDoc.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Cmb_TipoDoc.Name = "Cmb_TipoDoc";
            this.Cmb_TipoDoc.Pp_CampoAceptaNull = true;
            this.Cmb_TipoDoc.Pp_EsPk = false;
            this.Cmb_TipoDoc.Pp_MensajeError = "Seleccionar Tipo Doc";
            this.Cmb_TipoDoc.Pp_NombreCampo = "nombreTipoDoc";
            this.Cmb_TipoDoc.Pp_NombreCampoInsert = "tipoDoc";
            this.Cmb_TipoDoc.Pp_NombreTabla = "Tipo_Documento";
            this.Cmb_TipoDoc.Pp_PkTabla = "tipoDoc";
            this.Cmb_TipoDoc.Size = new System.Drawing.Size(100, 33);
            this.Cmb_TipoDoc.TabIndex = 65;
            // 
            // Txt_Apellido
            // 
            this.Txt_Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Txt_Apellido.Location = new System.Drawing.Point(172, 121);
            this.Txt_Apellido.Margin = new System.Windows.Forms.Padding(11, 2, 11, 2);
            this.Txt_Apellido.Name = "Txt_Apellido";
            this.Txt_Apellido.Pp_EsPk = false;
            this.Txt_Apellido.Pp_MensajeError = "Escribe tu apellido";
            this.Txt_Apellido.Pp_NombreCampo = "apellido";
            this.Txt_Apellido.Pp_NombreTabla = "Pasajero";
            this.Txt_Apellido.Size = new System.Drawing.Size(148, 30);
            this.Txt_Apellido.TabIndex = 64;
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Cerrar.Location = new System.Drawing.Point(55, 476);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Pp_Presionado = false;
            this.Btn_Cerrar.Size = new System.Drawing.Size(102, 34);
            this.Btn_Cerrar.TabIndex = 29;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = true;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // btn_limpiar1
            // 
            this.btn_limpiar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_limpiar1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpiar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar1.Location = new System.Drawing.Point(161, 476);
            this.btn_limpiar1.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar1.Name = "btn_limpiar1";
            this.btn_limpiar1.Pp_Presionado = false;
            this.btn_limpiar1.Size = new System.Drawing.Size(102, 34);
            this.btn_limpiar1.TabIndex = 26;
            this.btn_limpiar1.Text = "Limpiar";
            this.btn_limpiar1.UseVisualStyleBackColor = true;
            this.btn_limpiar1.Click += new System.EventHandler(this.btn_limpiar1_Click);
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Consultar.Location = new System.Drawing.Point(846, 179);
            this.Btn_Consultar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Pp_Presionado = false;
            this.Btn_Consultar.Size = new System.Drawing.Size(127, 50);
            this.Btn_Consultar.TabIndex = 25;
            this.Btn_Consultar.Text = "Buscar";
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            this.Btn_Consultar.Click += new System.EventHandler(this.Btn_Consultar_Click);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Registrar.Location = new System.Drawing.Point(845, 254);
            this.Btn_Registrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Pp_Presionado = false;
            this.Btn_Registrar.Size = new System.Drawing.Size(127, 50);
            this.Btn_Registrar.TabIndex = 24;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = true;
            this.Btn_Registrar.Click += new System.EventHandler(this.btn_registrar1_Click);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Eliminar.Enabled = false;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Eliminar.Location = new System.Drawing.Point(845, 398);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Pp_Presionado = false;
            this.Btn_Eliminar.Size = new System.Drawing.Size(127, 50);
            this.Btn_Eliminar.TabIndex = 23;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.btn_borrar1_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Modificar.Enabled = false;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Modificar.Location = new System.Drawing.Point(845, 326);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Pp_Presionado = false;
            this.Btn_Modificar.Size = new System.Drawing.Size(127, 50);
            this.Btn_Modificar.TabIndex = 22;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            this.Btn_Modificar.Click += new System.EventHandler(this.btn_modificar1_Click);
            // 
            // grid_Familiares
            // 
            this.grid_Familiares.AllowUserToAddRows = false;
            this.grid_Familiares.AllowUserToDeleteRows = false;
            this.grid_Familiares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Familiares.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipodoc1,
            this.numero1,
            this.tipodoc2,
            this.numero2});
            this.grid_Familiares.Location = new System.Drawing.Point(46, 179);
            this.grid_Familiares.Name = "grid_Familiares";
            this.grid_Familiares.Pp_FormatoGrid = null;
            this.grid_Familiares.Pp_NombreTabla = "Familiar_X_Pasajero";
            this.grid_Familiares.ReadOnly = true;
            this.grid_Familiares.RowTemplate.Height = 24;
            this.grid_Familiares.Size = new System.Drawing.Size(778, 268);
            this.grid_Familiares.TabIndex = 0;
            this.grid_Familiares.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Familiares_CellClick);
            this.grid_Familiares.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Familiares_CellContentDoubleClick);
            // 
            // tipodoc1
            // 
            this.tipodoc1.HeaderText = "Column1";
            this.tipodoc1.Name = "tipodoc1";
            this.tipodoc1.ReadOnly = true;
            this.tipodoc1.Visible = false;
            // 
            // numero1
            // 
            this.numero1.HeaderText = "Column1";
            this.numero1.Name = "numero1";
            this.numero1.ReadOnly = true;
            this.numero1.Visible = false;
            // 
            // tipodoc2
            // 
            this.tipodoc2.HeaderText = "Column1";
            this.tipodoc2.Name = "tipodoc2";
            this.tipodoc2.ReadOnly = true;
            this.tipodoc2.Visible = false;
            // 
            // numero2
            // 
            this.numero2.HeaderText = "Column1";
            this.numero2.Name = "numero2";
            this.numero2.ReadOnly = true;
            this.numero2.Visible = false;
            // 
            // Frm_ABMGrupoFamiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 514);
            this.Controls.Add(this.chk_Todos);
            this.Controls.Add(this.Msktxt_NumeroDOC);
            this.Controls.Add(this.Txt_nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cmb_TipoDoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Apellido);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_limpiar1);
            this.Controls.Add(this.Btn_Consultar);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_Familiares);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABMGrupoFamiliar";
            this.Text = "Frm_ABMGrupoFamiliar";
            this.Load += new System.EventHandler(this.Frm_ABMGrupoFamiliar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Familiares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.DataGridView_Aerolinea grid_Familiares;
        private Clase.Button_Aerolinea Btn_Cerrar;
        private System.Windows.Forms.Label label7;
        private Clase.Button_Aerolinea btn_limpiar1;
        private Clase.Button_Aerolinea Btn_Consultar;
        private Clase.Button_Aerolinea Btn_Registrar;
        private Clase.Button_Aerolinea Btn_Eliminar;
        private Clase.Button_Aerolinea Btn_Modificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chk_Todos;
        private Clase.MaskedTextBox_Aerolinea Msktxt_NumeroDOC;
        private Clase.TextBox_Aerolinea Txt_nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Clase.ComboBox_Aerolinea Cmb_TipoDoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Clase.TextBox_Aerolinea Txt_Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodoc1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipodoc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero2;
    }
}