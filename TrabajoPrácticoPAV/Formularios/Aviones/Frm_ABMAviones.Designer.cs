
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABMAviones));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grid_aviones = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Modelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.txt_numero = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.picBox_buscar = new System.Windows.Forms.PictureBox();
            this.picBox_actualizar = new System.Windows.Forms.PictureBox();
            this.picBox_agregar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_aviones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_buscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_actualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_agregar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aviones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero ";
            // 
            // grid_aviones
            // 
            this.grid_aviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_aviones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Nombre,
            this.IdModelo,
            this.Eliminar});
            this.grid_aviones.Location = new System.Drawing.Point(47, 178);
            this.grid_aviones.Name = "grid_aviones";
            this.grid_aviones.Size = new System.Drawing.Size(394, 177);
            this.grid_aviones.TabIndex = 3;
            this.grid_aviones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Numero";
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Modelo";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // IdModelo
            // 
            this.IdModelo.HeaderText = "IdModelo";
            this.IdModelo.Name = "IdModelo";
            this.IdModelo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.IdModelo.Visible = false;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.Width = 50;
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
            this.label2.Location = new System.Drawing.Point(89, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(43, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Consultar Aviones";
            // 
            // cmb_Modelo
            // 
            this.cmb_Modelo.FormattingEnabled = true;
            this.cmb_Modelo.Location = new System.Drawing.Point(123, 103);
            this.cmb_Modelo.Name = "cmb_Modelo";
            this.cmb_Modelo.Pp_CampoAceptaNull = true;
            this.cmb_Modelo.Pp_EsPk = false;
            this.cmb_Modelo.Pp_MensajeError = null;
            this.cmb_Modelo.Pp_NombreCampo = "nombre";
            this.cmb_Modelo.Pp_NombreCampoInsert = null;
            this.cmb_Modelo.Pp_NombreTabla = "Modelo";
            this.cmb_Modelo.Pp_PkTabla = "idModelo";
            this.cmb_Modelo.Size = new System.Drawing.Size(106, 21);
            this.cmb_Modelo.TabIndex = 7;
            this.cmb_Modelo.SelectedIndexChanged += new System.EventHandler(this.cmb_Modelo_SelectedIndexChanged);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(123, 72);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Pp_EsPk = false;
            this.txt_numero.Pp_MensajeError = null;
            this.txt_numero.Pp_NombreCampo = null;
            this.txt_numero.Pp_NombreTabla = null;
            this.txt_numero.Size = new System.Drawing.Size(106, 20);
            this.txt_numero.TabIndex = 4;
            // 
            // picBox_buscar
            // 
            this.picBox_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_buscar.BackgroundImage")));
            this.picBox_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_buscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_buscar.Location = new System.Drawing.Point(253, 103);
            this.picBox_buscar.Name = "picBox_buscar";
            this.picBox_buscar.Size = new System.Drawing.Size(30, 22);
            this.picBox_buscar.TabIndex = 12;
            this.picBox_buscar.TabStop = false;
            this.picBox_buscar.Click += new System.EventHandler(this.picBox_buscar_Click);
            // 
            // picBox_actualizar
            // 
            this.picBox_actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_actualizar.BackgroundImage")));
            this.picBox_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_actualizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_actualizar.Location = new System.Drawing.Point(505, 144);
            this.picBox_actualizar.Name = "picBox_actualizar";
            this.picBox_actualizar.Size = new System.Drawing.Size(28, 21);
            this.picBox_actualizar.TabIndex = 13;
            this.picBox_actualizar.TabStop = false;
            this.picBox_actualizar.Click += new System.EventHandler(this.picBox_actualizar_Click);
            // 
            // picBox_agregar
            // 
            this.picBox_agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBox_agregar.BackgroundImage")));
            this.picBox_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox_agregar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox_agregar.Location = new System.Drawing.Point(505, 354);
            this.picBox_agregar.Name = "picBox_agregar";
            this.picBox_agregar.Size = new System.Drawing.Size(32, 25);
            this.picBox_agregar.TabIndex = 14;
            this.picBox_agregar.TabStop = false;
            this.picBox_agregar.Click += new System.EventHandler(this.picBox_agregar_Click);
            // 
            // Frm_ABMAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(650, 581);
            this.Controls.Add(this.picBox_agregar);
            this.Controls.Add(this.picBox_actualizar);
            this.Controls.Add(this.picBox_buscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Modelo);
            this.Controls.Add(this.grid_aviones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numero);
            this.Name = "Frm_ABMAviones";
            this.Text = "Frm_ABMAviones";
            this.Load += new System.EventHandler(this.Frm_ABMAviones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_aviones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_buscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_actualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_agregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid_aviones;
        private Clase.TextBox_Aerolinea txt_numero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Clase.ComboBox_Aerolinea cmb_Modelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdModelo;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.PictureBox picBox_buscar;
        private System.Windows.Forms.PictureBox picBox_actualizar;
        private System.Windows.Forms.PictureBox picBox_agregar;
    }
}