namespace TrabajoPrácticoPAV.Formularios.Tipo_Asientos
{
    partial class Frm_ABMTipoAsientos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_modificar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_limpiar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.grid_TipoAsiento = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chb_Todos = new System.Windows.Forms.CheckBox();
            this.cmb_Clase = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TipoAsiento)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(29, -2);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar Tipo de Asiento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(77, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Filtros de búsqueda";
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(806, 202);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Pp_Presionado = false;
            this.btn_buscar.Size = new System.Drawing.Size(109, 41);
            this.btn_buscar.TabIndex = 23;
            this.btn_buscar.Text = "Buscar ";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(806, 263);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Pp_Presionado = false;
            this.btn_registrar.Size = new System.Drawing.Size(109, 41);
            this.btn_registrar.TabIndex = 24;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(54, 441);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(100, 28);
            this.btn_cerrar.TabIndex = 27;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(806, 324);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Pp_Presionado = false;
            this.btn_modificar.Size = new System.Drawing.Size(109, 41);
            this.btn_modificar.TabIndex = 25;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(180, 441);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Pp_Presionado = false;
            this.btn_limpiar.Size = new System.Drawing.Size(100, 28);
            this.btn_limpiar.TabIndex = 28;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(806, 385);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Pp_Presionado = false;
            this.btn_eliminar.Size = new System.Drawing.Size(109, 41);
            this.btn_eliminar.TabIndex = 26;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // grid_TipoAsiento
            // 
            this.grid_TipoAsiento.AllowUserToAddRows = false;
            this.grid_TipoAsiento.AllowUserToDeleteRows = false;
            this.grid_TipoAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TipoAsiento.Location = new System.Drawing.Point(54, 202);
            this.grid_TipoAsiento.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_TipoAsiento.Name = "grid_TipoAsiento";
            this.grid_TipoAsiento.Pp_FormatoGrid = null;
            this.grid_TipoAsiento.Pp_NombreTabla = "Tipo_Asiento";
            this.grid_TipoAsiento.ReadOnly = true;
            this.grid_TipoAsiento.RowTemplate.Height = 24;
            this.grid_TipoAsiento.Size = new System.Drawing.Size(701, 226);
            this.grid_TipoAsiento.TabIndex = 21;
            this.grid_TipoAsiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_TipoAsiento_CellClick);
            this.grid_TipoAsiento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_TipoAsiento_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.chb_Todos);
            this.panel2.Controls.Add(this.cmb_Clase);
            this.panel2.Location = new System.Drawing.Point(54, 48);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 136);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(120, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Clase";
            // 
            // chb_Todos
            // 
            this.chb_Todos.AutoSize = true;
            this.chb_Todos.Checked = true;
            this.chb_Todos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chb_Todos.Location = new System.Drawing.Point(326, 56);
            this.chb_Todos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chb_Todos.Name = "chb_Todos";
            this.chb_Todos.Size = new System.Drawing.Size(70, 21);
            this.chb_Todos.TabIndex = 29;
            this.chb_Todos.Text = "Todos";
            this.chb_Todos.UseVisualStyleBackColor = true;
            // 
            // cmb_Clase
            // 
            this.cmb_Clase.FormattingEnabled = true;
            this.cmb_Clase.Location = new System.Drawing.Point(190, 54);
            this.cmb_Clase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_Clase.Name = "cmb_Clase";
            this.cmb_Clase.Pp_CampoAceptaNull = true;
            this.cmb_Clase.Pp_EsPk = false;
            this.cmb_Clase.Pp_MensajeError = null;
            this.cmb_Clase.Pp_NombreCampo = "nombre";
            this.cmb_Clase.Pp_NombreCampoInsert = null;
            this.cmb_Clase.Pp_NombreTabla = "Tipo_Asiento";
            this.cmb_Clase.Pp_PkTabla = "idTipo";
            this.cmb_Clase.Size = new System.Drawing.Size(121, 24);
            this.cmb_Clase.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.grid_TipoAsiento);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_limpiar);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.btn_registrar);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 488);
            this.panel1.TabIndex = 30;
            // 
            // Frm_ABMTipoAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(999, 514);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_ABMTipoAsientos";
            this.Text = "Frm_ABMTipoAsientos";
            this.Load += new System.EventHandler(this.Frm_ABMTipoAsientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TipoAsiento)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private Clase.Button_Aerolinea btn_buscar;
        private Clase.Button_Aerolinea btn_registrar;
        private Clase.Button_Aerolinea btn_cerrar;
        private Clase.Button_Aerolinea btn_modificar;
        private Clase.Button_Aerolinea btn_limpiar;
        private Clase.Button_Aerolinea btn_eliminar;
        private Clase.DataGridView_Aerolinea grid_TipoAsiento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chb_Todos;
        private Clase.ComboBox_Aerolinea cmb_Clase;
        private System.Windows.Forms.Panel panel1;
    }
}