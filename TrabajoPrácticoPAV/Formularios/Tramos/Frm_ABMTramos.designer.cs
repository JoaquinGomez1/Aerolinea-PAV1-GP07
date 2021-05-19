namespace TrabajoPrácticoPAV.Formularios
{
    partial class Frm_ABMTramos
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chb_todos_tramo = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Cerrar = new System.Windows.Forms.Button();
            this.grid_tramos = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.cmb_ASalida = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_ADestino = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tramos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 22;
            this.label1.Text = "Consultar tramos";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(38, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Filtros de búsqueda";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(50, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aeropuerto de destino:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(61, 68);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aeropuerto de salida:";
            // 
            // chb_todos_tramo
            // 
            this.chb_todos_tramo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chb_todos_tramo.AutoSize = true;
            this.chb_todos_tramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chb_todos_tramo.Location = new System.Drawing.Point(653, 99);
            this.chb_todos_tramo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chb_todos_tramo.Name = "chb_todos_tramo";
            this.chb_todos_tramo.Size = new System.Drawing.Size(72, 24);
            this.chb_todos_tramo.TabIndex = 4;
            this.chb_todos_tramo.Text = "Todos";
            this.chb_todos_tramo.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(634, 145);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(95, 41);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Registrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Registrar.FlatAppearance.BorderSize = 0;
            this.Btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Registrar.Location = new System.Drawing.Point(634, 204);
            this.Btn_Registrar.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(95, 41);
            this.Btn_Registrar.TabIndex = 23;
            this.Btn_Registrar.Text = "Registrar";
            this.Btn_Registrar.UseVisualStyleBackColor = false;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Modificar.Enabled = false;
            this.Btn_Modificar.FlatAppearance.BorderSize = 0;
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Modificar.Location = new System.Drawing.Point(634, 263);
            this.Btn_Modificar.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(95, 41);
            this.Btn_Modificar.TabIndex = 24;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = false;
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Limpiar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Limpiar.FlatAppearance.BorderSize = 0;
            this.Btn_Limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Limpiar.Location = new System.Drawing.Point(41, 387);
            this.Btn_Limpiar.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(76, 28);
            this.Btn_Limpiar.TabIndex = 26;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = false;
            this.Btn_Limpiar.Click += new System.EventHandler(this.Btn_Limpiar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Btn_Cerrar.BackColor = System.Drawing.SystemColors.Control;
            this.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Cerrar.Location = new System.Drawing.Point(121, 387);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(76, 28);
            this.Btn_Cerrar.TabIndex = 27;
            this.Btn_Cerrar.Text = "Cerrar";
            this.Btn_Cerrar.UseVisualStyleBackColor = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // grid_tramos
            // 
            this.grid_tramos.AllowUserToAddRows = false;
            this.grid_tramos.AllowUserToDeleteRows = false;
            this.grid_tramos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.grid_tramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tramos.Location = new System.Drawing.Point(34, 145);
            this.grid_tramos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grid_tramos.MultiSelect = false;
            this.grid_tramos.Name = "grid_tramos";
            this.grid_tramos.Pp_FormatoGrid = "codigoAeropuertoSalida, Aeropuerto Salida, 175;codigoAeropuertoDestino, Aeropuert" +
    "o destino, 175;duracion, Duración, 75;distancia, Distancia, 75";
            this.grid_tramos.Pp_NombreTabla = "Tramo";
            this.grid_tramos.ReadOnly = true;
            this.grid_tramos.RowTemplate.Height = 24;
            this.grid_tramos.Size = new System.Drawing.Size(584, 218);
            this.grid_tramos.TabIndex = 2;
            this.grid_tramos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_tramos_CellContentClick);
            this.grid_tramos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid_tramos_MouseDoubleClick);
            // 
            // cmb_ASalida
            // 
            this.cmb_ASalida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_ASalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_ASalida.FormattingEnabled = true;
            this.cmb_ASalida.Location = new System.Drawing.Point(236, 65);
            this.cmb_ASalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_ASalida.Name = "cmb_ASalida";
            this.cmb_ASalida.Pp_CampoAceptaNull = true;
            this.cmb_ASalida.Pp_EsPk = false;
            this.cmb_ASalida.Pp_MensajeError = null;
            this.cmb_ASalida.Pp_NombreCampo = "nombre";
            this.cmb_ASalida.Pp_NombreCampoInsert = "codigoAeropuertoSalida";
            this.cmb_ASalida.Pp_NombreTabla = "Aeropuerto";
            this.cmb_ASalida.Pp_PkTabla = "codigo";
            this.cmb_ASalida.Size = new System.Drawing.Size(378, 28);
            this.cmb_ASalida.TabIndex = 5;
            // 
            // cmb_ADestino
            // 
            this.cmb_ADestino.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmb_ADestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_ADestino.FormattingEnabled = true;
            this.cmb_ADestino.Location = new System.Drawing.Point(236, 95);
            this.cmb_ADestino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_ADestino.Name = "cmb_ADestino";
            this.cmb_ADestino.Pp_CampoAceptaNull = true;
            this.cmb_ADestino.Pp_EsPk = false;
            this.cmb_ADestino.Pp_MensajeError = null;
            this.cmb_ADestino.Pp_NombreCampo = "nombre";
            this.cmb_ADestino.Pp_NombreCampoInsert = "codigoAeropuertoDestino";
            this.cmb_ADestino.Pp_NombreTabla = "Aeropuerto";
            this.cmb_ADestino.Pp_PkTabla = "codigo";
            this.cmb_ADestino.Size = new System.Drawing.Size(378, 28);
            this.cmb_ADestino.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(10, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 394);
            this.panel1.TabIndex = 28;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(24, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 91);
            this.panel2.TabIndex = 0;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Eliminar.Enabled = false;
            this.Btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Eliminar.Location = new System.Drawing.Point(634, 322);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2, 20, 2, 2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Pp_Presionado = false;
            this.Btn_Eliminar.Size = new System.Drawing.Size(95, 41);
            this.Btn_Eliminar.TabIndex = 60;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Frm_ABMTramos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.ControlBox = false;
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Cerrar);
            this.Controls.Add(this.Btn_Limpiar);
            this.Controls.Add(this.Btn_Modificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Btn_Registrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_tramos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_ASalida);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.cmb_ADestino);
            this.Controls.Add(this.chb_todos_tramo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_ABMTramos";
            this.Text = "Frm_ABMTramos";
            this.Load += new System.EventHandler(this.Frm_ABMTramos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tramos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Clase.DataGridView_Aerolinea grid_tramos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Clase.ComboBox_Aerolinea cmb_ADestino;
        private Clase.ComboBox_Aerolinea cmb_ASalida;
        private System.Windows.Forms.CheckBox chb_todos_tramo;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Cerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Clase.Button_Aerolinea Btn_Eliminar;
    }
}