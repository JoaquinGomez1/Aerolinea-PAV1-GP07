
namespace TrabajoPrácticoPAV.Formularios.Tripulacion
{
    partial class Frm_ABMTripulacion
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
            this.panel_registrar = new System.Windows.Forms.Panel();
            this.btn_buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.cmb_cargo_register = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.txt_apellido_register = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_nombre_register = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_title_register = new System.Windows.Forms.Label();
            this.lbl_title_modify = new System.Windows.Forms.Label();
            this.panel_modify = new System.Windows.Forms.Panel();
            this.btn_modify = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.cmb_cargo_modify = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.txt_apellido_modify = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_nombre_modify = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_editar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_refrescar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.grid_tripulantes = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.idTripulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.panel_registrar.SuspendLayout();
            this.panel_modify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tripulantes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_registrar
            // 
            this.panel_registrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_registrar.Controls.Add(this.btn_buscar);
            this.panel_registrar.Controls.Add(this.btn_registrar);
            this.panel_registrar.Controls.Add(this.cmb_cargo_register);
            this.panel_registrar.Controls.Add(this.txt_apellido_register);
            this.panel_registrar.Controls.Add(this.txt_nombre_register);
            this.panel_registrar.Controls.Add(this.lbl_cargo);
            this.panel_registrar.Controls.Add(this.lbl_apellido);
            this.panel_registrar.Controls.Add(this.lbl_nombre);
            this.panel_registrar.Location = new System.Drawing.Point(24, 20);
            this.panel_registrar.Name = "panel_registrar";
            this.panel_registrar.Size = new System.Drawing.Size(325, 179);
            this.panel_registrar.TabIndex = 0;
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_buscar.Location = new System.Drawing.Point(54, 117);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Pp_Presionado = false;
            this.btn_buscar.Size = new System.Drawing.Size(90, 28);
            this.btn_buscar.TabIndex = 10;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_registrar.Location = new System.Drawing.Point(171, 117);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Pp_Presionado = false;
            this.btn_registrar.Size = new System.Drawing.Size(90, 28);
            this.btn_registrar.TabIndex = 4;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // cmb_cargo_register
            // 
            this.cmb_cargo_register.FormattingEnabled = true;
            this.cmb_cargo_register.Location = new System.Drawing.Point(113, 81);
            this.cmb_cargo_register.Name = "cmb_cargo_register";
            this.cmb_cargo_register.Pp_CampoAceptaNull = false;
            this.cmb_cargo_register.Pp_EsPk = true;
            this.cmb_cargo_register.Pp_MensajeError = "Elegir un cargo";
            this.cmb_cargo_register.Pp_NombreCampo = "nombre";
            this.cmb_cargo_register.Pp_NombreCampoInsert = null;
            this.cmb_cargo_register.Pp_NombreTabla = "Cargo_Tripulacion";
            this.cmb_cargo_register.Pp_PkTabla = "idCargoTripulacion";
            this.cmb_cargo_register.Size = new System.Drawing.Size(118, 21);
            this.cmb_cargo_register.TabIndex = 5;
            // 
            // txt_apellido_register
            // 
            this.txt_apellido_register.Location = new System.Drawing.Point(113, 55);
            this.txt_apellido_register.Name = "txt_apellido_register";
            this.txt_apellido_register.Pp_EsPk = false;
            this.txt_apellido_register.Pp_MensajeError = "Completar Apellido";
            this.txt_apellido_register.Pp_NombreCampo = null;
            this.txt_apellido_register.Pp_NombreTabla = null;
            this.txt_apellido_register.Size = new System.Drawing.Size(118, 20);
            this.txt_apellido_register.TabIndex = 4;
            // 
            // txt_nombre_register
            // 
            this.txt_nombre_register.Location = new System.Drawing.Point(113, 29);
            this.txt_nombre_register.Name = "txt_nombre_register";
            this.txt_nombre_register.Pp_EsPk = false;
            this.txt_nombre_register.Pp_MensajeError = "Completar nombre";
            this.txt_nombre_register.Pp_NombreCampo = null;
            this.txt_nombre_register.Pp_NombreTabla = null;
            this.txt_nombre_register.Size = new System.Drawing.Size(118, 20);
            this.txt_nombre_register.TabIndex = 3;
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_cargo.Location = new System.Drawing.Point(57, 81);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(38, 13);
            this.lbl_cargo.TabIndex = 2;
            this.lbl_cargo.Text = "Cargo:";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_apellido.Location = new System.Drawing.Point(46, 54);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(47, 13);
            this.lbl_apellido.TabIndex = 1;
            this.lbl_apellido.Text = "Apellido:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_nombre.Location = new System.Drawing.Point(46, 29);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(47, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_title_register
            // 
            this.lbl_title_register.AutoSize = true;
            this.lbl_title_register.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_title_register.Location = new System.Drawing.Point(20, -1);
            this.lbl_title_register.Name = "lbl_title_register";
            this.lbl_title_register.Size = new System.Drawing.Size(229, 21);
            this.lbl_title_register.TabIndex = 3;
            this.lbl_title_register.Text = "Registrar / Buscar Tripulante";
            // 
            // lbl_title_modify
            // 
            this.lbl_title_modify.AccessibleName = "group_modify";
            this.lbl_title_modify.AutoSize = true;
            this.lbl_title_modify.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_title_modify.Location = new System.Drawing.Point(387, -1);
            this.lbl_title_modify.Name = "lbl_title_modify";
            this.lbl_title_modify.Size = new System.Drawing.Size(165, 21);
            this.lbl_title_modify.TabIndex = 6;
            this.lbl_title_modify.Text = "Modificar Tripulante";
            this.lbl_title_modify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_title_modify.Visible = false;
            // 
            // panel_modify
            // 
            this.panel_modify.AccessibleName = "group_modify";
            this.panel_modify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_modify.Controls.Add(this.btn_modify);
            this.panel_modify.Controls.Add(this.cmb_cargo_modify);
            this.panel_modify.Controls.Add(this.txt_apellido_modify);
            this.panel_modify.Controls.Add(this.txt_nombre_modify);
            this.panel_modify.Controls.Add(this.label2);
            this.panel_modify.Controls.Add(this.label3);
            this.panel_modify.Controls.Add(this.label4);
            this.panel_modify.Location = new System.Drawing.Point(391, 20);
            this.panel_modify.Name = "panel_modify";
            this.panel_modify.Size = new System.Drawing.Size(325, 179);
            this.panel_modify.TabIndex = 5;
            this.panel_modify.Visible = false;
            // 
            // btn_modify
            // 
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_modify.Location = new System.Drawing.Point(135, 117);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Pp_Presionado = false;
            this.btn_modify.Size = new System.Drawing.Size(90, 28);
            this.btn_modify.TabIndex = 4;
            this.btn_modify.Text = "Modificar";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // cmb_cargo_modify
            // 
            this.cmb_cargo_modify.FormattingEnabled = true;
            this.cmb_cargo_modify.Location = new System.Drawing.Point(107, 84);
            this.cmb_cargo_modify.Name = "cmb_cargo_modify";
            this.cmb_cargo_modify.Pp_CampoAceptaNull = false;
            this.cmb_cargo_modify.Pp_EsPk = true;
            this.cmb_cargo_modify.Pp_MensajeError = "Elegir un cargo";
            this.cmb_cargo_modify.Pp_NombreCampo = "nombre";
            this.cmb_cargo_modify.Pp_NombreCampoInsert = null;
            this.cmb_cargo_modify.Pp_NombreTabla = "Cargo_Tripulacion";
            this.cmb_cargo_modify.Pp_PkTabla = "idCargoTripulacion";
            this.cmb_cargo_modify.Size = new System.Drawing.Size(118, 21);
            this.cmb_cargo_modify.TabIndex = 5;
            // 
            // txt_apellido_modify
            // 
            this.txt_apellido_modify.Location = new System.Drawing.Point(107, 58);
            this.txt_apellido_modify.Name = "txt_apellido_modify";
            this.txt_apellido_modify.Pp_EsPk = false;
            this.txt_apellido_modify.Pp_MensajeError = null;
            this.txt_apellido_modify.Pp_NombreCampo = null;
            this.txt_apellido_modify.Pp_NombreTabla = null;
            this.txt_apellido_modify.Size = new System.Drawing.Size(118, 20);
            this.txt_apellido_modify.TabIndex = 4;
            // 
            // txt_nombre_modify
            // 
            this.txt_nombre_modify.Location = new System.Drawing.Point(107, 32);
            this.txt_nombre_modify.Name = "txt_nombre_modify";
            this.txt_nombre_modify.Pp_EsPk = false;
            this.txt_nombre_modify.Pp_MensajeError = null;
            this.txt_nombre_modify.Pp_NombreCampo = null;
            this.txt_nombre_modify.Pp_NombreTabla = null;
            this.txt_nombre_modify.Size = new System.Drawing.Size(118, 20);
            this.txt_nombre_modify.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(51, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cargo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label3.Location = new System.Drawing.Point(40, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(40, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_eliminar.Location = new System.Drawing.Point(637, 310);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Pp_Presionado = false;
            this.btn_eliminar.Size = new System.Drawing.Size(90, 28);
            this.btn_eliminar.TabIndex = 14;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_editar.Location = new System.Drawing.Point(637, 276);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Pp_Presionado = false;
            this.btn_editar.Size = new System.Drawing.Size(90, 28);
            this.btn_editar.TabIndex = 13;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_refrescar.Location = new System.Drawing.Point(637, 242);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Pp_Presionado = false;
            this.btn_refrescar.Size = new System.Drawing.Size(90, 28);
            this.btn_refrescar.TabIndex = 7;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // grid_tripulantes
            // 
            this.grid_tripulantes.AllowUserToAddRows = false;
            this.grid_tripulantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tripulantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTripulacion,
            this.nombre,
            this.apellido,
            this.nombreCargo,
            this.idCargo});
            this.grid_tripulantes.Location = new System.Drawing.Point(24, 218);
            this.grid_tripulantes.Name = "grid_tripulantes";
            this.grid_tripulantes.Pp_FormatoGrid = null;
            this.grid_tripulantes.Pp_NombreTabla = null;
            this.grid_tripulantes.ReadOnly = true;
            this.grid_tripulantes.Size = new System.Drawing.Size(593, 175);
            this.grid_tripulantes.TabIndex = 4;
            // 
            // idTripulacion
            // 
            this.idTripulacion.Frozen = true;
            this.idTripulacion.HeaderText = "ID";
            this.idTripulacion.Name = "idTripulacion";
            this.idTripulacion.ReadOnly = true;
            this.idTripulacion.Width = 65;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 150;
            // 
            // apellido
            // 
            this.apellido.Frozen = true;
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            this.apellido.Width = 185;
            // 
            // nombreCargo
            // 
            this.nombreCargo.Frozen = true;
            this.nombreCargo.HeaderText = "Cargo";
            this.nombreCargo.Name = "nombreCargo";
            this.nombreCargo.ReadOnly = true;
            this.nombreCargo.Width = 143;
            // 
            // idCargo
            // 
            this.idCargo.Frozen = true;
            this.idCargo.HeaderText = "IdCargo";
            this.idCargo.Name = "idCargo";
            this.idCargo.ReadOnly = true;
            this.idCargo.Visible = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cerrar.Location = new System.Drawing.Point(637, 344);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(90, 28);
            this.btn_cerrar.TabIndex = 15;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Frm_ABMTripulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_refrescar);
            this.Controls.Add(this.lbl_title_modify);
            this.Controls.Add(this.panel_modify);
            this.Controls.Add(this.grid_tripulantes);
            this.Controls.Add(this.lbl_title_register);
            this.Controls.Add(this.panel_registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABMTripulacion";
            this.Text = "Frm_Tripulacion";
            this.Load += new System.EventHandler(this.Frm_Tripulacion_Load);
            this.panel_registrar.ResumeLayout(false);
            this.panel_registrar.PerformLayout();
            this.panel_modify.ResumeLayout(false);
            this.panel_modify.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tripulantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_registrar;
        private Clase.TextBox_Aerolinea txt_nombre_register;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_apellido;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_title_register;
        private Clase.ComboBox_Aerolinea cmb_cargo_register;
        private Clase.TextBox_Aerolinea txt_apellido_register;
        private Clase.Button_Aerolinea btn_registrar;
        private Clase.DataGridView_Aerolinea grid_tripulantes;
        private System.Windows.Forms.Label lbl_title_modify;
        private System.Windows.Forms.Panel panel_modify;
        private Clase.Button_Aerolinea btn_modify;
        private Clase.ComboBox_Aerolinea cmb_cargo_modify;
        private Clase.TextBox_Aerolinea txt_apellido_modify;
        private Clase.TextBox_Aerolinea txt_nombre_modify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Clase.Button_Aerolinea btn_refrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTripulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCargo;
        private Clase.Button_Aerolinea btn_editar;
        private Clase.Button_Aerolinea btn_eliminar;
        private Clase.Button_Aerolinea btn_buscar;
        private Clase.Button_Aerolinea btn_cerrar;
    }
}