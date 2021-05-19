
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
            this.lbl_title_modify = new System.Windows.Forms.Label();
            this.txt_nombre_modify = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_title_register = new System.Windows.Forms.Label();
            this.panel_registrar = new System.Windows.Forms.Panel();
            this.btn_registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.txt_nombre_register = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.btn_refrescar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.grid_tripulantes = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.idTripulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.panel_modify.Location = new System.Drawing.Point(619, 44);
            this.panel_modify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_modify.Name = "panel_modify";
            this.panel_modify.Size = new System.Drawing.Size(391, 193);
            this.panel_modify.TabIndex = 11;
            this.panel_modify.Visible = false;
            // 
            // btn_modify
            // 
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Location = new System.Drawing.Point(200, 144);
            this.btn_modify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Pp_Presionado = false;
            this.btn_modify.Size = new System.Drawing.Size(100, 28);
            this.btn_modify.TabIndex = 4;
            this.btn_modify.Text = "Modificar";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click);
            // 
            // lbl_title_modify
            // 
            this.lbl_title_modify.AccessibleName = "group_modify";
            this.lbl_title_modify.AutoSize = true;
            this.lbl_title_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_modify.Location = new System.Drawing.Point(636, 30);
            this.lbl_title_modify.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title_modify.Name = "lbl_title_modify";
            this.lbl_title_modify.Size = new System.Drawing.Size(150, 25);
            this.lbl_title_modify.TabIndex = 6;
            this.lbl_title_modify.Text = "Modificar Cargo";
            this.lbl_title_modify.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_title_modify.Visible = false;
            // 
            // txt_nombre_modify
            // 
            this.txt_nombre_modify.Location = new System.Drawing.Point(143, 89);
            this.txt_nombre_modify.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre_modify.Name = "txt_nombre_modify";
            this.txt_nombre_modify.Pp_EsPk = false;
            this.txt_nombre_modify.Pp_MensajeError = "Complete el Nombre de modificar";
            this.txt_nombre_modify.Pp_NombreCampo = null;
            this.txt_nombre_modify.Pp_NombreTabla = null;
            this.txt_nombre_modify.Size = new System.Drawing.Size(156, 22);
            this.txt_nombre_modify.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // lbl_title_register
            // 
            this.lbl_title_register.AutoSize = true;
            this.lbl_title_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_register.Location = new System.Drawing.Point(69, 31);
            this.lbl_title_register.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_title_register.Name = "lbl_title_register";
            this.lbl_title_register.Size = new System.Drawing.Size(202, 25);
            this.lbl_title_register.TabIndex = 9;
            this.lbl_title_register.Text = "Registrar nuevo cargo";
            // 
            // panel_registrar
            // 
            this.panel_registrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_registrar.Controls.Add(this.btn_registrar);
            this.panel_registrar.Controls.Add(this.txt_nombre_register);
            this.panel_registrar.Controls.Add(this.lbl_nombre);
            this.panel_registrar.Location = new System.Drawing.Point(56, 44);
            this.panel_registrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_registrar.Name = "panel_registrar";
            this.panel_registrar.Size = new System.Drawing.Size(391, 193);
            this.panel_registrar.TabIndex = 8;
            // 
            // btn_registrar
            // 
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Location = new System.Drawing.Point(200, 144);
            this.btn_registrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Pp_Presionado = false;
            this.btn_registrar.Size = new System.Drawing.Size(100, 28);
            this.btn_registrar.TabIndex = 4;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txt_nombre_register
            // 
            this.txt_nombre_register.Location = new System.Drawing.Point(143, 84);
            this.txt_nombre_register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre_register.Name = "txt_nombre_register";
            this.txt_nombre_register.Pp_EsPk = false;
            this.txt_nombre_register.Pp_MensajeError = "Completar nombre";
            this.txt_nombre_register.Pp_NombreCampo = null;
            this.txt_nombre_register.Pp_NombreTabla = null;
            this.txt_nombre_register.Size = new System.Drawing.Size(156, 22);
            this.txt_nombre_register.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(53, 84);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 17);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Location = new System.Drawing.Point(911, 495);
            this.btn_refrescar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Pp_Presionado = false;
            this.btn_refrescar.Size = new System.Drawing.Size(100, 28);
            this.btn_refrescar.TabIndex = 12;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // grid_tripulantes
            // 
            this.grid_tripulantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tripulantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTripulacion,
            this.nombre,
            this.Editar,
            this.Eliminar});
            this.grid_tripulantes.Location = new System.Drawing.Point(56, 272);
            this.grid_tripulantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid_tripulantes.Name = "grid_tripulantes";
            this.grid_tripulantes.Pp_FormatoGrid = null;
            this.grid_tripulantes.Pp_NombreTabla = null;
            this.grid_tripulantes.Size = new System.Drawing.Size(955, 215);
            this.grid_tripulantes.TabIndex = 10;
            this.grid_tripulantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_tripulantes_CellContentClick);
            // 
            // idTripulacion
            // 
            this.idTripulacion.Frozen = true;
            this.idTripulacion.HeaderText = "ID";
            this.idTripulacion.Name = "idTripulacion";
            this.idTripulacion.Width = 65;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 150;
            // 
            // Editar
            // 
            this.Editar.Frozen = true;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Editar.Text = "Editar";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 65;
            // 
            // Eliminar
            // 
            this.Eliminar.Frozen = true;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            this.Eliminar.Width = 65;
            // 
            // Frm_CargoTripulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_refrescar);
            this.Controls.Add(this.lbl_title_modify);
            this.Controls.Add(this.panel_modify);
            this.Controls.Add(this.grid_tripulantes);
            this.Controls.Add(this.lbl_title_register);
            this.Controls.Add(this.panel_registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_CargoTripulacion";
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
        private Clase.Button_Aerolinea btn_registrar;
        private Clase.TextBox_Aerolinea txt_nombre_register;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTripulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}