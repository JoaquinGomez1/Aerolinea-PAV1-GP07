namespace TrabajoPrácticoPAV.Formularios.Asientos
{
    partial class Frm_ABMAsientos
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
            this.label5 = new System.Windows.Forms.Label();
            this.chk_asientos = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_Clase = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_limpiar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_modificar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.cmb_Modelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_NumeroAvion = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.grilla_ABMAsiento = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_ABMAsiento)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asientos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Avión";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Número de Avión ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Modelo";
            // 
            // chk_asientos
            // 
            this.chk_asientos.AutoSize = true;
            this.chk_asientos.Location = new System.Drawing.Point(439, 136);
            this.chk_asientos.Name = "chk_asientos";
            this.chk_asientos.Size = new System.Drawing.Size(56, 17);
            this.chk_asientos.TabIndex = 14;
            this.chk_asientos.Text = "Todos";
            this.chk_asientos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Clase ";
            // 
            // cmb_Clase
            // 
            this.cmb_Clase.FormattingEnabled = true;
            this.cmb_Clase.Location = new System.Drawing.Point(228, 132);
            this.cmb_Clase.Name = "cmb_Clase";
            this.cmb_Clase.Pp_CampoAceptaNull = true;
            this.cmb_Clase.Pp_EsPk = false;
            this.cmb_Clase.Pp_MensajeError = "Selccione una clase";
            this.cmb_Clase.Pp_NombreCampo = "nombre";
            this.cmb_Clase.Pp_NombreCampoInsert = "idTipo";
            this.cmb_Clase.Pp_NombreTabla = "Tipo_Asiento";
            this.cmb_Clase.Pp_PkTabla = "idTipo";
            this.cmb_Clase.Size = new System.Drawing.Size(195, 21);
            this.cmb_Clase.TabIndex = 16;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(125, 379);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Pp_Presionado = false;
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 13;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(32, 379);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 12;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Enabled = false;
            this.btn_eliminar.Location = new System.Drawing.Point(648, 305);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Pp_Presionado = false;
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 11;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Enabled = false;
            this.btn_modificar.Location = new System.Drawing.Point(648, 266);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Pp_Presionado = false;
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 10;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(648, 218);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Pp_Presionado = false;
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 9;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(648, 178);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Pp_Presionado = false;
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 8;
            this.btn_buscar.Text = "Buscar ";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // cmb_Modelo
            // 
            this.cmb_Modelo.FormattingEnabled = true;
            this.cmb_Modelo.Location = new System.Drawing.Point(228, 62);
            this.cmb_Modelo.Name = "cmb_Modelo";
            this.cmb_Modelo.Pp_CampoAceptaNull = true;
            this.cmb_Modelo.Pp_EsPk = false;
            this.cmb_Modelo.Pp_MensajeError = "Seleccione un modelo de avión";
            this.cmb_Modelo.Pp_NombreCampo = "nombre";
            this.cmb_Modelo.Pp_NombreCampoInsert = "idModelo";
            this.cmb_Modelo.Pp_NombreTabla = "Modelo";
            this.cmb_Modelo.Pp_PkTabla = "idModelo";
            this.cmb_Modelo.Size = new System.Drawing.Size(195, 21);
            this.cmb_Modelo.TabIndex = 7;
            this.cmb_Modelo.SelectionChangeCommitted += new System.EventHandler(this.cmb_Modelo_SelectionChangeCommitted);
            // 
            // cmb_NumeroAvion
            // 
            this.cmb_NumeroAvion.FormattingEnabled = true;
            this.cmb_NumeroAvion.Location = new System.Drawing.Point(228, 95);
            this.cmb_NumeroAvion.Name = "cmb_NumeroAvion";
            this.cmb_NumeroAvion.Pp_CampoAceptaNull = true;
            this.cmb_NumeroAvion.Pp_EsPk = false;
            this.cmb_NumeroAvion.Pp_MensajeError = "Seleccione un número de avión";
            this.cmb_NumeroAvion.Pp_NombreCampo = "numeroPorModelo";
            this.cmb_NumeroAvion.Pp_NombreCampoInsert = "numeroPorModelo";
            this.cmb_NumeroAvion.Pp_NombreTabla = "Avion";
            this.cmb_NumeroAvion.Pp_PkTabla = "numeroPorModelo";
            this.cmb_NumeroAvion.Size = new System.Drawing.Size(195, 21);
            this.cmb_NumeroAvion.TabIndex = 3;
            this.cmb_NumeroAvion.SelectionChangeCommitted += new System.EventHandler(this.cmb_NumeroAvion_SelectionChangeCommitted);
            // 
            // grilla_ABMAsiento
            // 
            this.grilla_ABMAsiento.AllowUserToAddRows = false;
            this.grilla_ABMAsiento.AllowUserToDeleteRows = false;
            this.grilla_ABMAsiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_ABMAsiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grilla_ABMAsiento.Location = new System.Drawing.Point(32, 178);
            this.grilla_ABMAsiento.Name = "grilla_ABMAsiento";
            this.grilla_ABMAsiento.Pp_FormatoGrid = "";
            this.grilla_ABMAsiento.Pp_NombreTabla = "Asientos";
            this.grilla_ABMAsiento.ReadOnly = true;
            this.grilla_ABMAsiento.Size = new System.Drawing.Size(590, 150);
            this.grilla_ABMAsiento.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero de asiento";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Modelo del Avión";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Número del avión";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Clase";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Estado";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Frm_ABMAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(749, 414);
            this.Controls.Add(this.cmb_Clase);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chk_asientos);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cmb_Modelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_NumeroAvion);
            this.Controls.Add(this.grilla_ABMAsiento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABMAsientos";
            this.Text = "Frm_ABMAsientos";
            this.Load += new System.EventHandler(this.Frm_ABMAsientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_ABMAsiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Clase.DataGridView_Aerolinea grilla_ABMAsiento;
        private Clase.ComboBox_Aerolinea cmb_NumeroAvion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Clase.ComboBox_Aerolinea cmb_Modelo;
        private Clase.Button_Aerolinea btn_buscar;
        private Clase.Button_Aerolinea btn_registrar;
        private Clase.Button_Aerolinea btn_modificar;
        private Clase.Button_Aerolinea btn_eliminar;
        private Clase.Button_Aerolinea btn_cerrar;
        private Clase.Button_Aerolinea btn_limpiar;
        private System.Windows.Forms.CheckBox chk_asientos;
        private System.Windows.Forms.Label label6;
        private Clase.ComboBox_Aerolinea cmb_Clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}