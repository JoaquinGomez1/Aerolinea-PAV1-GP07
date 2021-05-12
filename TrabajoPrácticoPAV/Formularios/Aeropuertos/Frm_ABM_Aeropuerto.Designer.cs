
namespace TrabajoPrácticoPAV.Formularios.Aeropuertos
{
    partial class Frm_ABM_Aeropuerto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_Aeropuerto));
            this.label1 = new System.Windows.Forms.Label();
            this.grid_aeropuertos = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCiudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cmb_codigos = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.pic_deseleccionar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_aeropuertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_deseleccionar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aeropuertos";
            // 
            // grid_aeropuertos
            // 
            this.grid_aeropuertos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.grid_aeropuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_aeropuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.IdCiudad});
            this.grid_aeropuertos.Location = new System.Drawing.Point(25, 155);
            this.grid_aeropuertos.Name = "grid_aeropuertos";
            this.grid_aeropuertos.Size = new System.Drawing.Size(453, 214);
            this.grid_aeropuertos.TabIndex = 1;
            this.grid_aeropuertos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_aeropuertos_CellClick);
            this.grid_aeropuertos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_aeropuertos_CellDoubleClick);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.Width = 200;
            // 
            // IdCiudad
            // 
            this.IdCiudad.HeaderText = "IdCiudad";
            this.IdCiudad.Name = "IdCiudad";
            this.IdCiudad.Width = 90;
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_consultar.Location = new System.Drawing.Point(483, 167);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_agregar.Location = new System.Drawing.Point(483, 196);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_modificar.Location = new System.Drawing.Point(484, 225);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_eliminar.Location = new System.Drawing.Point(484, 254);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_volver.Location = new System.Drawing.Point(25, 375);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(75, 23);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "< Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(250, 134);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(15, 14);
            this.chk_todos.TabIndex = 5;
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Todos";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(241, 73);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(121, 20);
            this.txt_nombre.TabIndex = 10;
            // 
            // cmb_codigos
            // 
            this.cmb_codigos.FormattingEnabled = true;
            this.cmb_codigos.Location = new System.Drawing.Point(241, 48);
            this.cmb_codigos.Name = "cmb_codigos";
            this.cmb_codigos.Pp_CampoAceptaNull = false;
            this.cmb_codigos.Pp_EsPk = false;
            this.cmb_codigos.Pp_MensajeError = null;
            this.cmb_codigos.Pp_NombreCampo = "codigo";
            this.cmb_codigos.Pp_NombreCampoInsert = "codigo";
            this.cmb_codigos.Pp_NombreTabla = "Aeropuerto";
            this.cmb_codigos.Pp_PkTabla = "codigo";
            this.cmb_codigos.Size = new System.Drawing.Size(121, 21);
            this.cmb_codigos.TabIndex = 11;
            // 
            // pic_deseleccionar
            // 
            this.pic_deseleccionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_deseleccionar.BackgroundImage")));
            this.pic_deseleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_deseleccionar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_deseleccionar.Location = new System.Drawing.Point(368, 51);
            this.pic_deseleccionar.Name = "pic_deseleccionar";
            this.pic_deseleccionar.Size = new System.Drawing.Size(18, 10);
            this.pic_deseleccionar.TabIndex = 8;
            this.pic_deseleccionar.TabStop = false;
            this.pic_deseleccionar.Click += new System.EventHandler(this.pic_deseleccionar_Click);
            // 
            // Frm_ABM_Aeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(573, 402);
            this.Controls.Add(this.cmb_codigos);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.pic_deseleccionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chk_todos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.grid_aeropuertos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ABM_Aeropuerto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ABM_Aeropuerto";
            this.Load += new System.EventHandler(this.Frm_ABM_Aeropuerto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_aeropuertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_deseleccionar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_aeropuertos;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic_deseleccionar;
        private System.Windows.Forms.TextBox txt_nombre;
        private Clase.ComboBox_Aerolinea cmb_codigos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCiudad;
    }
}