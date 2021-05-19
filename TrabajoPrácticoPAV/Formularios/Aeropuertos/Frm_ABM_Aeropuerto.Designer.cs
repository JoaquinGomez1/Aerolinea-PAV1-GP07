
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.btn_limpiarr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_aeropuertos = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_Nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_Codigo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_aeropuertos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(29, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aeropuertos";
            // 
            // btn_consultar
            // 
            this.btn_consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_consultar.Location = new System.Drawing.Point(845, 178);
            this.btn_consultar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(127, 50);
            this.btn_consultar.TabIndex = 2;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = false;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_agregar.Location = new System.Drawing.Point(845, 251);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(127, 50);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_modificar.Location = new System.Drawing.Point(845, 324);
            this.btn_modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(127, 50);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_eliminar.Location = new System.Drawing.Point(845, 396);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(127, 50);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_volver.Location = new System.Drawing.Point(55, 476);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(101, 34);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Cerrar";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(119, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(111, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chk_todos.Location = new System.Drawing.Point(724, 122);
            this.chk_todos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(90, 29);
            this.chk_todos.TabIndex = 5;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // btn_limpiarr
            // 
            this.btn_limpiarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_limpiarr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_limpiarr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_limpiarr.Location = new System.Drawing.Point(161, 476);
            this.btn_limpiarr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_limpiarr.Name = "btn_limpiarr";
            this.btn_limpiarr.Size = new System.Drawing.Size(101, 34);
            this.btn_limpiarr.TabIndex = 12;
            this.btn_limpiarr.Text = "Limpiar";
            this.btn_limpiarr.UseVisualStyleBackColor = false;
            this.btn_limpiarr.Click += new System.EventHandler(this.btn_limpiarr_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grid_aeropuertos);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(13, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 484);
            this.panel1.TabIndex = 64;
            // 
            // grid_aeropuertos
            // 
            this.grid_aeropuertos.AllowUserToAddRows = false;
            this.grid_aeropuertos.AllowUserToDeleteRows = false;
            this.grid_aeropuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_aeropuertos.Location = new System.Drawing.Point(32, 162);
            this.grid_aeropuertos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grid_aeropuertos.Name = "grid_aeropuertos";
            this.grid_aeropuertos.Pp_FormatoGrid = null;
            this.grid_aeropuertos.Pp_NombreTabla = null;
            this.grid_aeropuertos.ReadOnly = true;
            this.grid_aeropuertos.Size = new System.Drawing.Size(777, 268);
            this.grid_aeropuertos.TabIndex = 1;
            this.grid_aeropuertos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_aeropuertos_CellClick);
            this.grid_aeropuertos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_aeropuertos_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(32, 37);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(777, 112);
            this.panel3.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(51, 44);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 20);
            this.label14.TabIndex = 65;
            this.label14.Text = "Filtros de búsqueda";
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Nombre.Location = new System.Drawing.Point(257, 119);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Pp_EsPk = false;
            this.txt_Nombre.Pp_MensajeError = null;
            this.txt_Nombre.Pp_NombreCampo = "nombre";
            this.txt_Nombre.Pp_NombreTabla = "Aeropuerto";
            this.txt_Nombre.Size = new System.Drawing.Size(209, 30);
            this.txt_Nombre.TabIndex = 66;
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_Codigo.Location = new System.Drawing.Point(257, 80);
            this.txt_Codigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Pp_EsPk = false;
            this.txt_Codigo.Pp_MensajeError = null;
            this.txt_Codigo.Pp_NombreCampo = "codigo";
            this.txt_Codigo.Pp_NombreTabla = "Aeropuerto";
            this.txt_Codigo.Size = new System.Drawing.Size(209, 30);
            this.txt_Codigo.TabIndex = 67;
            // 
            // Frm_ABM_Aeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(999, 514);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btn_limpiarr);
            this.Controls.Add(this.chk_todos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ABM_Aeropuerto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ABM_Aeropuerto";
            this.Load += new System.EventHandler(this.Frm_ABM_Aeropuerto_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_aeropuertos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_todos;
        private Clase.Button_Aerolinea btn_limpiar;
        private System.Windows.Forms.Button btn_limpiarr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private Clase.TextBox_Aerolinea txt_Nombre;
        private Clase.TextBox_Aerolinea txt_Codigo;
        private Clase.DataGridView_Aerolinea grid_aeropuertos;
    }
}