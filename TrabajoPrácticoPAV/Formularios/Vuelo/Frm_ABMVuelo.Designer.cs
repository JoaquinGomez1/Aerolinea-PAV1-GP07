﻿namespace TrabajoPrácticoPAV.Formularios
{
    partial class Frm_ABMVuelo
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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.check_vuelo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_box = new System.Windows.Forms.CheckBox();
            this.btn_limpiar1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_consultar1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_registrar1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_borrar1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_modificar1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.grilla_ABM_vuelo1 = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_NumAvion = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_nomModelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.Cmb_Nromodelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_Nroavion = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.grilla_ABM_Vuelos = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_limpiar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_modificar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_borrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_consultar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_ABM_vuelo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_ABM_Vuelos)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(150, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Modelo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label6.Location = new System.Drawing.Point(107, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Número Avion";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cancelar.Location = new System.Drawing.Point(626, 364);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(90, 28);
            this.btn_cancelar.TabIndex = 13;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Vuelo";
            // 
            // check_vuelo
            // 
            this.check_vuelo.AutoSize = true;
            this.check_vuelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.check_vuelo.Location = new System.Drawing.Point(380, 102);
            this.check_vuelo.Name = "check_vuelo";
            this.check_vuelo.Size = new System.Drawing.Size(67, 21);
            this.check_vuelo.TabIndex = 22;
            this.check_vuelo.Text = "Todos";
            this.check_vuelo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Vuelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre Modelo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Numero Avion";
            // 
            // chk_box
            // 
            this.chk_box.AutoSize = true;
            this.chk_box.Location = new System.Drawing.Point(347, 89);
            this.chk_box.Name = "chk_box";
            this.chk_box.Size = new System.Drawing.Size(56, 17);
            this.chk_box.TabIndex = 11;
            this.chk_box.Text = "Todos";
            this.chk_box.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar1
            // 
            this.btn_limpiar1.Location = new System.Drawing.Point(175, 113);
            this.btn_limpiar1.Name = "btn_limpiar1";
            this.btn_limpiar1.Pp_Presionado = false;
            this.btn_limpiar1.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar1.TabIndex = 10;
            this.btn_limpiar1.Text = "Limpiar";
            this.btn_limpiar1.UseVisualStyleBackColor = true;
            // 
            // btn_consultar1
            // 
            this.btn_consultar1.Location = new System.Drawing.Point(265, 113);
            this.btn_consultar1.Name = "btn_consultar1";
            this.btn_consultar1.Pp_Presionado = false;
            this.btn_consultar1.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar1.TabIndex = 9;
            this.btn_consultar1.Text = "Consultar";
            this.btn_consultar1.UseVisualStyleBackColor = true;
            this.btn_consultar1.Click += new System.EventHandler(this.btn_consultar1_Click);
            // 
            // btn_registrar1
            // 
            this.btn_registrar1.Location = new System.Drawing.Point(201, 347);
            this.btn_registrar1.Name = "btn_registrar1";
            this.btn_registrar1.Pp_Presionado = false;
            this.btn_registrar1.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar1.TabIndex = 8;
            this.btn_registrar1.Text = "Registrar";
            this.btn_registrar1.UseVisualStyleBackColor = true;
            this.btn_registrar1.Click += new System.EventHandler(this.btn_registrar1_Click);
            // 
            // btn_borrar1
            // 
            this.btn_borrar1.Location = new System.Drawing.Point(119, 347);
            this.btn_borrar1.Name = "btn_borrar1";
            this.btn_borrar1.Pp_Presionado = false;
            this.btn_borrar1.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar1.TabIndex = 7;
            this.btn_borrar1.Text = "Borrar";
            this.btn_borrar1.UseVisualStyleBackColor = true;
            this.btn_borrar1.Click += new System.EventHandler(this.btn_borrar1_Click);
            // 
            // btn_modificar1
            // 
            this.btn_modificar1.Location = new System.Drawing.Point(37, 347);
            this.btn_modificar1.Name = "btn_modificar1";
            this.btn_modificar1.Pp_Presionado = false;
            this.btn_modificar1.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar1.TabIndex = 6;
            this.btn_modificar1.Text = "Modificar";
            this.btn_modificar1.UseVisualStyleBackColor = true;
            this.btn_modificar1.Click += new System.EventHandler(this.btn_modificar1_Click);
            // 
            // grilla_ABM_vuelo1
            // 
            this.grilla_ABM_vuelo1.AllowUserToAddRows = false;
            this.grilla_ABM_vuelo1.AllowUserToDeleteRows = false;
            this.grilla_ABM_vuelo1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_ABM_vuelo1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column10,
            this.Column7,
            this.Column8,
            this.Column9});
            this.grilla_ABM_vuelo1.Location = new System.Drawing.Point(37, 163);
            this.grilla_ABM_vuelo1.Name = "grilla_ABM_vuelo1";
            this.grilla_ABM_vuelo1.Pp_FormatoGrid = null;
            this.grilla_ABM_vuelo1.Pp_NombreTabla = "Vuelo";
            this.grilla_ABM_vuelo1.ReadOnly = true;
            this.grilla_ABM_vuelo1.Size = new System.Drawing.Size(595, 154);
            this.grilla_ABM_vuelo1.TabIndex = 5;
            this.grilla_ABM_vuelo1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_ABM_vuelo1_CellClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Duracion Estimada";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Modelo";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Aeropuerto Salida";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Aeropuerto Destino";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "id_Vuelo";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // cmb_NumAvion
            // 
            this.cmb_NumAvion.FormattingEnabled = true;
            this.cmb_NumAvion.Location = new System.Drawing.Point(175, 86);
            this.cmb_NumAvion.Name = "cmb_NumAvion";
            this.cmb_NumAvion.Pp_CampoAceptaNull = true;
            this.cmb_NumAvion.Pp_EsPk = false;
            this.cmb_NumAvion.Pp_MensajeError = null;
            this.cmb_NumAvion.Pp_NombreCampo = "numeroPorModelo";
            this.cmb_NumAvion.Pp_NombreCampoInsert = null;
            this.cmb_NumAvion.Pp_NombreTabla = "avion";
            this.cmb_NumAvion.Pp_PkTabla = "numeroPorModelo";
            this.cmb_NumAvion.Size = new System.Drawing.Size(165, 21);
            this.cmb_NumAvion.TabIndex = 4;
            // 
            // cmb_nomModelo
            // 
            this.cmb_nomModelo.FormattingEnabled = true;
            this.cmb_nomModelo.Location = new System.Drawing.Point(175, 58);
            this.cmb_nomModelo.Name = "cmb_nomModelo";
            this.cmb_nomModelo.Pp_CampoAceptaNull = true;
            this.cmb_nomModelo.Pp_EsPk = false;
            this.cmb_nomModelo.Pp_MensajeError = null;
            this.cmb_nomModelo.Pp_NombreCampo = "nombre";
            this.cmb_nomModelo.Pp_NombreCampoInsert = null;
            this.cmb_nomModelo.Pp_NombreTabla = "modelo";
            this.cmb_nomModelo.Pp_PkTabla = "idModelo";
            this.cmb_nomModelo.Size = new System.Drawing.Size(165, 21);
            this.cmb_nomModelo.TabIndex = 3;
            // 
            // Cmb_Nromodelo
            // 
            this.Cmb_Nromodelo.FormattingEnabled = true;
            this.Cmb_Nromodelo.Location = new System.Drawing.Point(210, 71);
            this.Cmb_Nromodelo.Name = "Cmb_Nromodelo";
            this.Cmb_Nromodelo.Pp_CampoAceptaNull = true;
            this.Cmb_Nromodelo.Pp_EsPk = false;
            this.Cmb_Nromodelo.Pp_MensajeError = "";
            this.Cmb_Nromodelo.Pp_NombreCampo = "nombre";
            this.Cmb_Nromodelo.Pp_NombreCampoInsert = null;
            this.Cmb_Nromodelo.Pp_NombreTabla = "modelo";
            this.Cmb_Nromodelo.Pp_PkTabla = "idModelo";
            this.Cmb_Nromodelo.Size = new System.Drawing.Size(160, 21);
            this.Cmb_Nromodelo.TabIndex = 12;
            // 
            // cmb_Nroavion
            // 
            this.cmb_Nroavion.FormattingEnabled = true;
            this.cmb_Nroavion.Location = new System.Drawing.Point(210, 102);
            this.cmb_Nroavion.Name = "cmb_Nroavion";
            this.cmb_Nroavion.Pp_CampoAceptaNull = true;
            this.cmb_Nroavion.Pp_EsPk = false;
            this.cmb_Nroavion.Pp_MensajeError = "";
            this.cmb_Nroavion.Pp_NombreCampo = "numeroPorModelo";
            this.cmb_Nroavion.Pp_NombreCampoInsert = null;
            this.cmb_Nroavion.Pp_NombreTabla = "Avion";
            this.cmb_Nroavion.Pp_PkTabla = "numeroPorModelo";
            this.cmb_Nroavion.Size = new System.Drawing.Size(160, 21);
            this.cmb_Nroavion.TabIndex = 13;
            // 
            // grilla_ABM_Vuelos
            // 
            this.grilla_ABM_Vuelos.AllowUserToDeleteRows = false;
            this.grilla_ABM_Vuelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla_ABM_Vuelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.grilla_ABM_Vuelos.Location = new System.Drawing.Point(36, 182);
            this.grilla_ABM_Vuelos.Name = "grilla_ABM_Vuelos";
            this.grilla_ABM_Vuelos.Pp_FormatoGrid = null;
            this.grilla_ABM_Vuelos.Pp_NombreTabla = null;
            this.grilla_ABM_Vuelos.ReadOnly = true;
            this.grilla_ABM_Vuelos.Size = new System.Drawing.Size(545, 150);
            this.grilla_ABM_Vuelos.TabIndex = 23;
            this.grilla_ABM_Vuelos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rid_vuelo_CellClick);
            this.grilla_ABM_Vuelos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_vuelo_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Duracion estimada";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "id_vuelo";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Modelo del Avion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Aeropuerto destino";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Aeropuerto Salida";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 150;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(210, 139);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Pp_Presionado = false;
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 24;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(49, 350);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Pp_Presionado = false;
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 25;
            this.btn_registrar.Text = "Agregar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click_1);
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(130, 350);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Pp_Presionado = false;
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 26;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(211, 350);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Pp_Presionado = false;
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 27;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(302, 138);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Pp_Presionado = false;
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 28;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // Frm_ABMVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(749, 414);
            this.Controls.Add(this.chk_box);
            this.Controls.Add(this.btn_limpiar1);
            this.Controls.Add(this.btn_consultar1);
            this.Controls.Add(this.btn_registrar1);
            this.Controls.Add(this.btn_borrar1);
            this.Controls.Add(this.btn_modificar1);
            this.Controls.Add(this.grilla_ABM_vuelo1);
            this.Controls.Add(this.cmb_NumAvion);
            this.Controls.Add(this.cmb_nomModelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABMVuelo";
            this.Text = "Frm_ABMVuelo";
            this.Load += new System.EventHandler(this.Frm_ABMVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla_ABM_vuelo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grilla_ABM_Vuelos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_cancelar;
        private Clase.ComboBox_Aerolinea Cmb_Nromodelo;
        private Clase.ComboBox_Aerolinea cmb_Nroavion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_vuelo;
        private Clase.DataGridView_Aerolinea grilla_ABM_Vuelos;
        private Clase.Button_Aerolinea btn_limpiar;
        private Clase.Button_Aerolinea btn_registrar;
        private Clase.Button_Aerolinea btn_modificar;
        private Clase.Button_Aerolinea btn_borrar;
        private Clase.Button_Aerolinea btn_consultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Clase.ComboBox_Aerolinea cmb_nomModelo;
        private Clase.ComboBox_Aerolinea cmb_NumAvion;
        private Clase.DataGridView_Aerolinea grilla_ABM_vuelo1;
        private Clase.Button_Aerolinea btn_modificar1;
        private Clase.Button_Aerolinea btn_borrar1;
        private Clase.Button_Aerolinea btn_registrar1;
        private Clase.Button_Aerolinea btn_consultar1;
        private Clase.Button_Aerolinea btn_limpiar1;
        private System.Windows.Forms.CheckBox chk_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}