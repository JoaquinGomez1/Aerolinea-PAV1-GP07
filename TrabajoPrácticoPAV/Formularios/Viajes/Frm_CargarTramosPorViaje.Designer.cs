
namespace TrabajoPrácticoPAV.Formularios.Viajes
{
    partial class Frm_CargarTramosPorViaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CargarTramosPorViaje));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Btn_Minimizar = new System.Windows.Forms.PictureBox();
            this.Btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.Titulo = new System.Windows.Forms.Label();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.grid_tramos = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.head_aeropuertoSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.head_aeropuertoDestino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.head_duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.head_distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_tramoViaje = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tramos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tramoViaje)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Tramos del viaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tramos";
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Btn_Minimizar);
            this.BarraSuperior.Controls.Add(this.Btn_Cerrar);
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(875, 32);
            this.BarraSuperior.TabIndex = 49;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // Btn_Minimizar
            // 
            this.Btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Minimizar.Image")));
            this.Btn_Minimizar.Location = new System.Drawing.Point(811, 4);
            this.Btn_Minimizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Minimizar.Name = "Btn_Minimizar";
            this.Btn_Minimizar.Size = new System.Drawing.Size(22, 24);
            this.Btn_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Minimizar.TabIndex = 6;
            this.Btn_Minimizar.TabStop = false;
            this.Btn_Minimizar.Click += new System.EventHandler(this.Btn_Minimizar_Click);
            // 
            // Btn_Cerrar
            // 
            this.Btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cerrar.Image")));
            this.Btn_Cerrar.Location = new System.Drawing.Point(842, 4);
            this.Btn_Cerrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cerrar.Name = "Btn_Cerrar";
            this.Btn_Cerrar.Size = new System.Drawing.Size(22, 24);
            this.Btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btn_Cerrar.TabIndex = 5;
            this.Btn_Cerrar.TabStop = false;
            this.Btn_Cerrar.Click += new System.EventHandler(this.Btn_Cerrar_Click);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(9, 6);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(264, 22);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "REGISTRAR TRAMOS DEL VIAJE";
            // 
            // btn_registrar
            // 
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_registrar.Location = new System.Drawing.Point(746, 296);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(90, 28);
            this.btn_registrar.TabIndex = 52;
            this.btn_registrar.Text = "Registrar ";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_agregar.Location = new System.Drawing.Point(364, 95);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(90, 28);
            this.btn_agregar.TabIndex = 53;
            this.btn_agregar.Text = "Agregar →";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_eliminar.Location = new System.Drawing.Point(396, 182);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 28);
            this.btn_eliminar.TabIndex = 54;
            this.btn_eliminar.Text = "← Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(490, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Tramos del viaje";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.grid_tramos);
            this.panel1.Controls.Add(this.grid_tramoViaje);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_registrar);
            this.panel1.Controls.Add(this.btn_eliminar);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Location = new System.Drawing.Point(16, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(848, 329);
            this.panel1.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label4.Location = new System.Drawing.Point(13, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 17);
            this.label4.TabIndex = 57;
            this.label4.Text = "* Seleccionar fila para poder agregarla o eliminarla";
            // 
            // grid_tramos
            // 
            this.grid_tramos.AllowUserToAddRows = false;
            this.grid_tramos.AllowUserToDeleteRows = false;
            this.grid_tramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tramos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.head_aeropuertoSalida,
            this.head_aeropuertoDestino,
            this.head_duracion,
            this.head_distancia});
            this.grid_tramos.Location = new System.Drawing.Point(13, 44);
            this.grid_tramos.Margin = new System.Windows.Forms.Padding(2);
            this.grid_tramos.MultiSelect = false;
            this.grid_tramos.Name = "grid_tramos";
            this.grid_tramos.Pp_FormatoGrid = "codigoAeropuertoSalida, Aeropuerto Salida, 175;codigoAeropuertoDestino, Aeropuert" +
    "o destino, 175;duracion, Duración, 75;distancia, Distancia, 75";
            this.grid_tramos.Pp_NombreTabla = "Tramo";
            this.grid_tramos.ReadOnly = true;
            this.grid_tramos.RowTemplate.Height = 24;
            this.grid_tramos.Size = new System.Drawing.Size(346, 212);
            this.grid_tramos.TabIndex = 50;
            // 
            // head_aeropuertoSalida
            // 
            this.head_aeropuertoSalida.HeaderText = "Aeropuerto Salida";
            this.head_aeropuertoSalida.Name = "head_aeropuertoSalida";
            this.head_aeropuertoSalida.ReadOnly = true;
            // 
            // head_aeropuertoDestino
            // 
            this.head_aeropuertoDestino.HeaderText = "Aeropuerto Destino";
            this.head_aeropuertoDestino.Name = "head_aeropuertoDestino";
            this.head_aeropuertoDestino.ReadOnly = true;
            // 
            // head_duracion
            // 
            this.head_duracion.HeaderText = "Duracion";
            this.head_duracion.Name = "head_duracion";
            this.head_duracion.ReadOnly = true;
            // 
            // head_distancia
            // 
            this.head_distancia.HeaderText = "Distancia";
            this.head_distancia.Name = "head_distancia";
            this.head_distancia.ReadOnly = true;
            // 
            // grid_tramoViaje
            // 
            this.grid_tramoViaje.AllowUserToAddRows = false;
            this.grid_tramoViaje.AllowUserToDeleteRows = false;
            this.grid_tramoViaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tramoViaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.grid_tramoViaje.Location = new System.Drawing.Point(490, 44);
            this.grid_tramoViaje.Margin = new System.Windows.Forms.Padding(2);
            this.grid_tramoViaje.MultiSelect = false;
            this.grid_tramoViaje.Name = "grid_tramoViaje";
            this.grid_tramoViaje.Pp_FormatoGrid = "codigoAeropuertoSalida, Aeropuerto Salida, 175;codigoAeropuertoDestino, Aeropuert" +
    "o destino, 175;duracion, Duración, 75;distancia, Distancia, 75";
            this.grid_tramoViaje.Pp_NombreTabla = "Tramo";
            this.grid_tramoViaje.ReadOnly = true;
            this.grid_tramoViaje.RowTemplate.Height = 24;
            this.grid_tramoViaje.Size = new System.Drawing.Size(346, 212);
            this.grid_tramoViaje.TabIndex = 56;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Aeropuerto Salida";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Aeropuerto Destino";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Duracion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Distancia";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Frm_CargarTramosPorViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 376);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Frm_CargarTramosPorViaje";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_CargarTramosPorViaje";
            this.Load += new System.EventHandler(this.Frm_CargarTramosPorViaje_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Btn_Cerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tramos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tramoViaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.PictureBox Btn_Minimizar;
        private System.Windows.Forms.PictureBox Btn_Cerrar;
        private Clase.DataGridView_Aerolinea grid_tramos;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn head_aeropuertoSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn head_aeropuertoDestino;
        private System.Windows.Forms.DataGridViewTextBoxColumn head_duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn head_distancia;
        private Clase.DataGridView_Aerolinea grid_tramoViaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}