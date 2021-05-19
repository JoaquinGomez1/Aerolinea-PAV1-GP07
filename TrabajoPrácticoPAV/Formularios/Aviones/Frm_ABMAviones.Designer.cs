
namespace TrabajoPrácticoPAV.Formularios
{
    partial class Frm_ABMAviones
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_aviones = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_volver = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_numero = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_Modelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_limpiar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_agregar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_aviones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aviones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(23, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero ";
            // 
            // Editar
            // 
            this.Editar.FillWeight = 50F;
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Editar.Width = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(397, 53);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(72, 24);
            this.chk_todos.TabIndex = 17;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            this.chk_todos.CheckedChanged += new System.EventHandler(this.chk_todos_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chk_todos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_numero);
            this.panel1.Controls.Add(this.cmb_Modelo);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.panel1.Location = new System.Drawing.Point(39, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 100);
            this.panel1.TabIndex = 18;
            // 
            // grid_aviones
            // 
            this.grid_aviones.AllowUserToAddRows = false;
            this.grid_aviones.AllowUserToDeleteRows = false;
            this.grid_aviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_aviones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nombre,
            this.idModelo});
            this.grid_aviones.Location = new System.Drawing.Point(39, 153);
            this.grid_aviones.Name = "grid_aviones";
            this.grid_aviones.ReadOnly = true;
            this.grid_aviones.Size = new System.Drawing.Size(583, 218);
            this.grid_aviones.TabIndex = 19;
            this.grid_aviones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_aviones_CellClick);
            this.grid_aviones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_aviones_CellContentClick);
            // 
            // numero
            // 
            this.numero.HeaderText = "Numero";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Modelo";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 180;
            // 
            // idModelo
            // 
            this.idModelo.HeaderText = "IdModelo";
            this.idModelo.Name = "idModelo";
            this.idModelo.ReadOnly = true;
            this.idModelo.Visible = false;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_volver.Location = new System.Drawing.Point(41, 381);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(76, 28);
            this.btn_volver.TabIndex = 20;
            this.btn_volver.Text = "Cerrar";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(13, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 393);
            this.panel2.TabIndex = 21;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(90, 19);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Pp_EsPk = true;
            this.txt_numero.Pp_MensajeError = null;
            this.txt_numero.Pp_NombreCampo = "numeroPorModelo";
            this.txt_numero.Pp_NombreTabla = "Avion";
            this.txt_numero.Size = new System.Drawing.Size(177, 26);
            this.txt_numero.TabIndex = 4;
            // 
            // cmb_Modelo
            // 
            this.cmb_Modelo.FormattingEnabled = true;
            this.cmb_Modelo.Location = new System.Drawing.Point(90, 50);
            this.cmb_Modelo.Name = "cmb_Modelo";
            this.cmb_Modelo.Pp_CampoAceptaNull = false;
            this.cmb_Modelo.Pp_EsPk = false;
            this.cmb_Modelo.Pp_MensajeError = "No se ha cargado un valor de modelo";
            this.cmb_Modelo.Pp_NombreCampo = "nombre";
            this.cmb_Modelo.Pp_NombreCampoInsert = "idModelo";
            this.cmb_Modelo.Pp_NombreTabla = "Modelo";
            this.cmb_Modelo.Pp_PkTabla = "idModelo";
            this.cmb_Modelo.Size = new System.Drawing.Size(177, 28);
            this.cmb_Modelo.TabIndex = 7;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_eliminar.Location = new System.Drawing.Point(628, 329);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Pp_Presionado = false;
            this.btn_eliminar.Size = new System.Drawing.Size(95, 41);
            this.btn_eliminar.TabIndex = 16;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiar.Location = new System.Drawing.Point(121, 381);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Pp_Presionado = false;
            this.btn_limpiar.Size = new System.Drawing.Size(76, 28);
            this.btn_limpiar.TabIndex = 16;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_agregar.Location = new System.Drawing.Point(628, 241);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Pp_Presionado = false;
            this.btn_agregar.Size = new System.Drawing.Size(95, 41);
            this.btn_agregar.TabIndex = 16;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(628, 153);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Pp_Presionado = false;
            this.btn_buscar.Size = new System.Drawing.Size(95, 41);
            this.btn_buscar.TabIndex = 15;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // Frm_ABMAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.grid_aviones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABMAviones";
            this.Text = "Frm_ABMAviones";
            this.Load += new System.EventHandler(this.Frm_ABMAviones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_aviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_numero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Clase.ComboBox_Aerolinea cmb_Modelo;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private Clase.Button_Aerolinea btn_buscar;
        private Clase.Button_Aerolinea btn_agregar;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.Panel panel1;
        private Clase.Button_Aerolinea btn_limpiar;
        private Clase.Button_Aerolinea btn_eliminar;
        private System.Windows.Forms.DataGridView grid_aviones;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModelo;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Panel panel2;
    }
}