
namespace TrabajoPrácticoPAV.Formularios.Tripulacion.Cargo_Tripulacion
{
    partial class Frm_ABMCargoTripulacion
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
            this.panel_modify = new System.Windows.Forms.Panel();
            this.btn_modify = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.txt_nombre_modify = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_title_modify = new System.Windows.Forms.Label();
            this.lbl_title_register = new System.Windows.Forms.Label();
            this.panel_registrar = new System.Windows.Forms.Panel();
            this.btn_buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.txt_nombre_register = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_editar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_refrescar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.grid_tripulantes = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.idTripulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Aerolinea1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.panel_modify.SuspendLayout();
            this.panel_registrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tripulantes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_modify
            // 
            this.panel_modify.AccessibleName = "group_modify";
            this.panel_modify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_modify.Controls.Add(this.btn_modify);
            this.panel_modify.Controls.Add(this.txt_nombre_modify);
            this.panel_modify.Controls.Add(this.label4);
            this.panel_modify.Location = new System.Drawing.Point(399, 36);
            this.panel_modify.Name = "panel_modify";
            this.panel_modify.Size = new System.Drawing.Size(294, 157);
            this.panel_modify.TabIndex = 11;
            this.panel_modify.Visible = false;
            // 
            // btn_modify
            // 
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_modify.Location = new System.Drawing.Point(138, 81);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Pp_Presionado = false;
            this.btn_modify.Size = new System.Drawing.Size(90, 28);
            this.btn_modify.TabIndex = 4;
            this.btn_modify.Text = "Modificar";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // txt_nombre_modify
            // 
            this.txt_nombre_modify.Location = new System.Drawing.Point(110, 48);
            this.txt_nombre_modify.Name = "txt_nombre_modify";
            this.txt_nombre_modify.Pp_EsPk = false;
            this.txt_nombre_modify.Pp_MensajeError = "Complete el Nombre de modificar";
            this.txt_nombre_modify.Pp_NombreCampo = null;
            this.txt_nombre_modify.Pp_NombreTabla = null;
            this.txt_nombre_modify.Size = new System.Drawing.Size(118, 20);
            this.txt_nombre_modify.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(27, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // lbl_title_modify
            // 
            this.lbl_title_modify.AccessibleName = "group_modify";
            this.lbl_title_modify.AutoSize = true;
            this.lbl_title_modify.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_title_modify.Location = new System.Drawing.Point(395, 12);
            this.lbl_title_modify.Name = "lbl_title_modify";
            this.lbl_title_modify.Size = new System.Drawing.Size(133, 21);
            this.lbl_title_modify.TabIndex = 6;
            this.lbl_title_modify.Text = "Modificar Cargo";
            this.lbl_title_modify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_title_modify.Visible = false;
            // 
            // lbl_title_register
            // 
            this.lbl_title_register.AutoSize = true;
            this.lbl_title_register.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_title_register.Location = new System.Drawing.Point(43, 12);
            this.lbl_title_register.Name = "lbl_title_register";
            this.lbl_title_register.Size = new System.Drawing.Size(180, 21);
            this.lbl_title_register.TabIndex = 9;
            this.lbl_title_register.Text = "Registrar nuevo cargo";
            // 
            // panel_registrar
            // 
            this.panel_registrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_registrar.Controls.Add(this.btn_buscar);
            this.panel_registrar.Controls.Add(this.btn_cerrar);
            this.panel_registrar.Controls.Add(this.txt_nombre_register);
            this.panel_registrar.Controls.Add(this.lbl_nombre);
            this.panel_registrar.Location = new System.Drawing.Point(47, 36);
            this.panel_registrar.Name = "panel_registrar";
            this.panel_registrar.Size = new System.Drawing.Size(294, 157);
            this.panel_registrar.TabIndex = 8;
            // 
            // btn_buscar
            // 
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_buscar.Location = new System.Drawing.Point(52, 81);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Pp_Presionado = false;
            this.btn_buscar.Size = new System.Drawing.Size(90, 28);
            this.btn_buscar.TabIndex = 10;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cerrar.Location = new System.Drawing.Point(158, 81);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(90, 28);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Text = "Registrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txt_nombre_register
            // 
            this.txt_nombre_register.Location = new System.Drawing.Point(96, 45);
            this.txt_nombre_register.Name = "txt_nombre_register";
            this.txt_nombre_register.Pp_EsPk = false;
            this.txt_nombre_register.Pp_MensajeError = "Completar nombre";
            this.txt_nombre_register.Pp_NombreCampo = null;
            this.txt_nombre_register.Pp_NombreTabla = null;
            this.txt_nombre_register.Size = new System.Drawing.Size(118, 20);
            this.txt_nombre_register.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_nombre.Location = new System.Drawing.Point(28, 45);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 17);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_eliminar.Location = new System.Drawing.Point(510, 310);
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
            this.btn_editar.Location = new System.Drawing.Point(510, 276);
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
            this.btn_refrescar.Location = new System.Drawing.Point(510, 242);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Pp_Presionado = false;
            this.btn_refrescar.Size = new System.Drawing.Size(90, 28);
            this.btn_refrescar.TabIndex = 12;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // grid_tripulantes
            // 
            this.grid_tripulantes.AllowUserToAddRows = false;
            this.grid_tripulantes.AllowUserToDeleteRows = false;
            this.grid_tripulantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tripulantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTripulacion,
            this.nombre});
            this.grid_tripulantes.Location = new System.Drawing.Point(47, 218);
            this.grid_tripulantes.Name = "grid_tripulantes";
            this.grid_tripulantes.Pp_FormatoGrid = null;
            this.grid_tripulantes.Pp_NombreTabla = null;
            this.grid_tripulantes.ReadOnly = true;
            this.grid_tripulantes.Size = new System.Drawing.Size(400, 175);
            this.grid_tripulantes.TabIndex = 10;
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
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Aerolinea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button_Aerolinea1.Location = new System.Drawing.Point(510, 344);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(90, 28);
            this.button_Aerolinea1.TabIndex = 15;
            this.button_Aerolinea1.Text = "Cerrar";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            this.button_Aerolinea1.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // Frm_ABMCargoTripulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Aerolinea1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_refrescar);
            this.Controls.Add(this.lbl_title_modify);
            this.Controls.Add(this.panel_modify);
            this.Controls.Add(this.grid_tripulantes);
            this.Controls.Add(this.lbl_title_register);
            this.Controls.Add(this.panel_registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABMCargoTripulacion";
            this.Text = "Frm_CargoTripulacion";
            this.Load += new System.EventHandler(this.Frm_CargoTripulacion_Load);
            this.panel_modify.ResumeLayout(false);
            this.panel_modify.PerformLayout();
            this.panel_registrar.ResumeLayout(false);
            this.panel_registrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tripulantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.Button_Aerolinea btn_refrescar;
        private System.Windows.Forms.Panel panel_modify;
        private Clase.Button_Aerolinea btn_modify;
        private System.Windows.Forms.Label lbl_title_modify;
        private Clase.TextBox_Aerolinea txt_nombre_modify;
        private System.Windows.Forms.Label label4;
        private Clase.DataGridView_Aerolinea grid_tripulantes;
        private System.Windows.Forms.Label lbl_title_register;
        private System.Windows.Forms.Panel panel_registrar;
        private Clase.Button_Aerolinea btn_cerrar;
        private Clase.TextBox_Aerolinea txt_nombre_register;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTripulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private Clase.Button_Aerolinea btn_editar;
        private Clase.Button_Aerolinea btn_eliminar;
        private Clase.Button_Aerolinea btn_buscar;
        private Clase.Button_Aerolinea button_Aerolinea1;
    }
}