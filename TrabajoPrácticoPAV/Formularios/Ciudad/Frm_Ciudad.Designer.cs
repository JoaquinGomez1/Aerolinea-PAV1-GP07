
namespace TrabajoPrácticoPAV.Formularios.Ciudad
{
    partial class Frm_Ciudad
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_title_register = new System.Windows.Forms.Label();
            this.panel_registrar = new System.Windows.Forms.Panel();
            this.lbl_provincia = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_title_modify = new System.Windows.Forms.Label();
            this.btn_refrescar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.comboBox_Aerolinea2 = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_modify = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.txt_nombre_modify = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.grid_ciudades = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.idCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idProvincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.txt_nombre_register = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.idProvinciaOculto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_modify.SuspendLayout();
            this.panel_registrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ciudades)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_modify
            // 
            this.panel_modify.AccessibleName = "group_modify";
            this.panel_modify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_modify.Controls.Add(this.comboBox_Aerolinea2);
            this.panel_modify.Controls.Add(this.btn_modify);
            this.panel_modify.Controls.Add(this.txt_nombre_modify);
            this.panel_modify.Controls.Add(this.label2);
            this.panel_modify.Controls.Add(this.label4);
            this.panel_modify.Location = new System.Drawing.Point(433, 38);
            this.panel_modify.Name = "panel_modify";
            this.panel_modify.Size = new System.Drawing.Size(325, 179);
            this.panel_modify.TabIndex = 9;
            this.panel_modify.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(43, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Provincia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(43, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // lbl_title_register
            // 
            this.lbl_title_register.AutoSize = true;
            this.lbl_title_register.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_title_register.Location = new System.Drawing.Point(53, 27);
            this.lbl_title_register.Name = "lbl_title_register";
            this.lbl_title_register.Size = new System.Drawing.Size(119, 21);
            this.lbl_title_register.TabIndex = 7;
            this.lbl_title_register.Text = "Cargar Ciudad";
            // 
            // panel_registrar
            // 
            this.panel_registrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_registrar.Controls.Add(this.comboBox_Aerolinea1);
            this.panel_registrar.Controls.Add(this.btn_registrar);
            this.panel_registrar.Controls.Add(this.txt_nombre_register);
            this.panel_registrar.Controls.Add(this.lbl_provincia);
            this.panel_registrar.Controls.Add(this.lbl_nombre);
            this.panel_registrar.Location = new System.Drawing.Point(42, 38);
            this.panel_registrar.Name = "panel_registrar";
            this.panel_registrar.Size = new System.Drawing.Size(325, 179);
            this.panel_registrar.TabIndex = 6;
            // 
            // lbl_provincia
            // 
            this.lbl_provincia.AutoSize = true;
            this.lbl_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_provincia.Location = new System.Drawing.Point(41, 68);
            this.lbl_provincia.Name = "lbl_provincia";
            this.lbl_provincia.Size = new System.Drawing.Size(70, 17);
            this.lbl_provincia.TabIndex = 2;
            this.lbl_provincia.Text = "Provincia:";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lbl_nombre.Location = new System.Drawing.Point(44, 41);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 17);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_title_modify
            // 
            this.lbl_title_modify.AutoSize = true;
            this.lbl_title_modify.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_title_modify.Location = new System.Drawing.Point(444, 27);
            this.lbl_title_modify.Name = "lbl_title_modify";
            this.lbl_title_modify.Size = new System.Drawing.Size(141, 21);
            this.lbl_title_modify.TabIndex = 10;
            this.lbl_title_modify.Text = "Modificar Ciudad";
            this.lbl_title_modify.Visible = false;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_refrescar.Location = new System.Drawing.Point(668, 417);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Pp_Presionado = false;
            this.btn_refrescar.Size = new System.Drawing.Size(90, 28);
            this.btn_refrescar.TabIndex = 11;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.UseVisualStyleBackColor = true;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click_1);
            // 
            // comboBox_Aerolinea2
            // 
            this.comboBox_Aerolinea2.FormattingEnabled = true;
            this.comboBox_Aerolinea2.Location = new System.Drawing.Point(111, 67);
            this.comboBox_Aerolinea2.Name = "comboBox_Aerolinea2";
            this.comboBox_Aerolinea2.Pp_CampoAceptaNull = false;
            this.comboBox_Aerolinea2.Pp_EsPk = true;
            this.comboBox_Aerolinea2.Pp_MensajeError = "Se ha detectado un error al momento de modificar la provincia";
            this.comboBox_Aerolinea2.Pp_NombreCampo = "nombreProvincia";
            this.comboBox_Aerolinea2.Pp_NombreCampoInsert = null;
            this.comboBox_Aerolinea2.Pp_NombreTabla = "Provincia";
            this.comboBox_Aerolinea2.Pp_PkTabla = "idProvincia";
            this.comboBox_Aerolinea2.Size = new System.Drawing.Size(118, 21);
            this.comboBox_Aerolinea2.TabIndex = 8;
            // 
            // btn_modify
            // 
            this.btn_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_modify.Location = new System.Drawing.Point(139, 106);
            this.btn_modify.Name = "btn_modify";
            this.btn_modify.Pp_Presionado = false;
            this.btn_modify.Size = new System.Drawing.Size(90, 28);
            this.btn_modify.TabIndex = 4;
            this.btn_modify.Text = "Modificar";
            this.btn_modify.UseVisualStyleBackColor = true;
            this.btn_modify.Click += new System.EventHandler(this.btn_modify_Click_1);
            // 
            // txt_nombre_modify
            // 
            this.txt_nombre_modify.Location = new System.Drawing.Point(111, 41);
            this.txt_nombre_modify.Name = "txt_nombre_modify";
            this.txt_nombre_modify.Pp_EsPk = false;
            this.txt_nombre_modify.Pp_MensajeError = null;
            this.txt_nombre_modify.Pp_NombreCampo = null;
            this.txt_nombre_modify.Pp_NombreTabla = null;
            this.txt_nombre_modify.Size = new System.Drawing.Size(118, 20);
            this.txt_nombre_modify.TabIndex = 3;
            // 
            // grid_ciudades
            // 
            this.grid_ciudades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ciudades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCiudad,
            this.nombre,
            this.nombreProvincia,
            this.Editar,
            this.Eliminar,
            this.idProvincia,
            this.idProvinciaOculto});
            this.grid_ciudades.Location = new System.Drawing.Point(42, 236);
            this.grid_ciudades.Name = "grid_ciudades";
            this.grid_ciudades.Pp_FormatoGrid = null;
            this.grid_ciudades.Pp_NombreTabla = null;
            this.grid_ciudades.Size = new System.Drawing.Size(716, 175);
            this.grid_ciudades.TabIndex = 8;
            this.grid_ciudades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ciudades_CellContentClick_1);
            // 
            // idCiudad
            // 
            this.idCiudad.Frozen = true;
            this.idCiudad.HeaderText = "ID";
            this.idCiudad.Name = "idCiudad";
            this.idCiudad.Width = 65;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 150;
            // 
            // nombreProvincia
            // 
            this.nombreProvincia.Frozen = true;
            this.nombreProvincia.HeaderText = "Provincia";
            this.nombreProvincia.Name = "nombreProvincia";
            this.nombreProvincia.Width = 143;
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
            // idProvincia
            // 
            this.idProvincia.Frozen = true;
            this.idProvincia.HeaderText = "IdProvincia";
            this.idProvincia.Name = "idProvincia";
            this.idProvincia.Visible = false;
            // 
            // comboBox_Aerolinea1
            // 
            this.comboBox_Aerolinea1.FormattingEnabled = true;
            this.comboBox_Aerolinea1.Location = new System.Drawing.Point(117, 68);
            this.comboBox_Aerolinea1.Name = "comboBox_Aerolinea1";
            this.comboBox_Aerolinea1.Pp_CampoAceptaNull = false;
            this.comboBox_Aerolinea1.Pp_EsPk = true;
            this.comboBox_Aerolinea1.Pp_MensajeError = "Se ha detectado un error en cargar provincia";
            this.comboBox_Aerolinea1.Pp_NombreCampo = "nombreProvincia";
            this.comboBox_Aerolinea1.Pp_NombreCampoInsert = null;
            this.comboBox_Aerolinea1.Pp_NombreTabla = "Provincia";
            this.comboBox_Aerolinea1.Pp_PkTabla = "idProvincia";
            this.comboBox_Aerolinea1.Size = new System.Drawing.Size(118, 21);
            this.comboBox_Aerolinea1.TabIndex = 6;
            // 
            // btn_registrar
            // 
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_registrar.Location = new System.Drawing.Point(145, 106);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Pp_Presionado = false;
            this.btn_registrar.Size = new System.Drawing.Size(90, 28);
            this.btn_registrar.TabIndex = 4;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // txt_nombre_register
            // 
            this.txt_nombre_register.Location = new System.Drawing.Point(117, 41);
            this.txt_nombre_register.Name = "txt_nombre_register";
            this.txt_nombre_register.Pp_EsPk = false;
            this.txt_nombre_register.Pp_MensajeError = "Completar nombre";
            this.txt_nombre_register.Pp_NombreCampo = null;
            this.txt_nombre_register.Pp_NombreTabla = null;
            this.txt_nombre_register.Size = new System.Drawing.Size(118, 20);
            this.txt_nombre_register.TabIndex = 3;
            // 
            // idProvinciaOculto
            // 
            this.idProvinciaOculto.HeaderText = "idProvincia";
            this.idProvinciaOculto.Name = "idProvinciaOculto";
            this.idProvinciaOculto.Visible = false;
            // 
            // Frm_Ciudad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_refrescar);
            this.Controls.Add(this.lbl_title_modify);
            this.Controls.Add(this.panel_modify);
            this.Controls.Add(this.grid_ciudades);
            this.Controls.Add(this.lbl_title_register);
            this.Controls.Add(this.panel_registrar);
            this.Name = "Frm_Ciudad";
            this.Text = "Frm_Ciudad";
            this.Load += new System.EventHandler(this.Frm_Ciudad_Load_1);
            this.panel_modify.ResumeLayout(false);
            this.panel_modify.PerformLayout();
            this.panel_registrar.ResumeLayout(false);
            this.panel_registrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ciudades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_modify;
        private Clase.Button_Aerolinea btn_modify;
        private Clase.TextBox_Aerolinea txt_nombre_modify;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Clase.DataGridView_Aerolinea grid_ciudades;
        private System.Windows.Forms.Label lbl_title_register;
        private System.Windows.Forms.Panel panel_registrar;
        private Clase.Button_Aerolinea btn_registrar;
        private Clase.TextBox_Aerolinea txt_nombre_register;
        private System.Windows.Forms.Label lbl_provincia;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCiudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProvincia;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProvincia;
        private System.Windows.Forms.Label lbl_title_modify;
        private Clase.Button_Aerolinea btn_refrescar;
        private Clase.ComboBox_Aerolinea comboBox_Aerolinea1;
        private Clase.ComboBox_Aerolinea comboBox_Aerolinea2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProvinciaOculto;
    }
}