
namespace TrabajoPrácticoPAV.Formularios.Tripulacion_x_vuelo
{
    partial class Frm_ABM_TripulacionxVuelo
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
            this.label2 = new System.Windows.Forms.Label();
            this.chk_todos = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.dataGrid_tripulacionxVuelo = new System.Windows.Forms.DataGridView();
            this.idTripulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVuelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idVuelo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_idTripulacion = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_tripulacionxVuelo)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(68, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "ID tripulación";
            // 
            // chk_todos
            // 
            this.chk_todos.AutoSize = true;
            this.chk_todos.Location = new System.Drawing.Point(213, 127);
            this.chk_todos.Name = "chk_todos";
            this.chk_todos.Size = new System.Drawing.Size(56, 17);
            this.chk_todos.TabIndex = 47;
            this.chk_todos.Text = "Todos";
            this.chk_todos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(173, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tripulación por vuelo";
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_salir.Location = new System.Drawing.Point(390, 258);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(90, 28);
            this.btn_salir.TabIndex = 40;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_consultar.Location = new System.Drawing.Point(390, 87);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(90, 28);
            this.btn_consultar.TabIndex = 42;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_eliminar.Location = new System.Drawing.Point(390, 224);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 28);
            this.btn_eliminar.TabIndex = 43;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_agregar.Location = new System.Drawing.Point(390, 190);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(90, 28);
            this.btn_agregar.TabIndex = 44;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // dataGrid_tripulacionxVuelo
            // 
            this.dataGrid_tripulacionxVuelo.AllowUserToAddRows = false;
            this.dataGrid_tripulacionxVuelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_tripulacionxVuelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTripulacion,
            this.idVuelo});
            this.dataGrid_tripulacionxVuelo.Location = new System.Drawing.Point(48, 190);
            this.dataGrid_tripulacionxVuelo.Name = "dataGrid_tripulacionxVuelo";
            this.dataGrid_tripulacionxVuelo.Size = new System.Drawing.Size(336, 203);
            this.dataGrid_tripulacionxVuelo.TabIndex = 39;
            this.dataGrid_tripulacionxVuelo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_tripulacionxVuelo_CellClick);
            // 
            // idTripulacion
            // 
            this.idTripulacion.HeaderText = "ID tripulación";
            this.idTripulacion.Name = "idTripulacion";
            // 
            // idVuelo
            // 
            this.idVuelo.HeaderText = "ID vuelo";
            this.idVuelo.Name = "idVuelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(68, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 51;
            this.label3.Text = "ID vuelo";
            // 
            // txt_idVuelo
            // 
            this.txt_idVuelo.Location = new System.Drawing.Point(213, 95);
            this.txt_idVuelo.Name = "txt_idVuelo";
            this.txt_idVuelo.Pp_EsPk = false;
            this.txt_idVuelo.Pp_MensajeError = null;
            this.txt_idVuelo.Pp_NombreCampo = null;
            this.txt_idVuelo.Pp_NombreTabla = null;
            this.txt_idVuelo.Size = new System.Drawing.Size(100, 20);
            this.txt_idVuelo.TabIndex = 50;
            // 
            // txt_idTripulacion
            // 
            this.txt_idTripulacion.Location = new System.Drawing.Point(213, 64);
            this.txt_idTripulacion.Name = "txt_idTripulacion";
            this.txt_idTripulacion.Pp_EsPk = false;
            this.txt_idTripulacion.Pp_MensajeError = null;
            this.txt_idTripulacion.Pp_NombreCampo = null;
            this.txt_idTripulacion.Pp_NombreTabla = null;
            this.txt_idTripulacion.Size = new System.Drawing.Size(100, 20);
            this.txt_idTripulacion.TabIndex = 48;
            // 
            // Frm_ABM_TripulacionxVuelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(609, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_idVuelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_idTripulacion);
            this.Controls.Add(this.chk_todos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.dataGrid_tripulacionxVuelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABM_TripulacionxVuelo";
            this.Text = "Frm_ABM_TripulacionxVuelo";
            this.Load += new System.EventHandler(this.Frm_ABM_TripulacionxVuelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_tripulacionxVuelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_idTripulacion;
        private System.Windows.Forms.CheckBox chk_todos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridView dataGrid_tripulacionxVuelo;
        private System.Windows.Forms.Label label3;
        private Clase.TextBox_Aerolinea txt_idVuelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTripulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVuelo;
    }
}