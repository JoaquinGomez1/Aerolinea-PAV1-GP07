
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
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grid_aviones = new System.Windows.Forms.DataGridView();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdModelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_alta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.textBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            ((System.ComponentModel.ISupportInitialize)(this.grid_aviones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aviones";
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(440, 217);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(96, 36);
            this.btn_actualizar.TabIndex = 9;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Modelo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Numero ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(271, 539);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grid_aviones
            // 
            this.grid_aviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_aviones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Modelo,
            this.Nombre,
            this.IdModelo});
            this.grid_aviones.Location = new System.Drawing.Point(53, 259);
            this.grid_aviones.Name = "grid_aviones";
            this.grid_aviones.Size = new System.Drawing.Size(483, 265);
            this.grid_aviones.TabIndex = 3;
            this.grid_aviones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Numero";
            this.Modelo.Name = "Modelo";
            this.Modelo.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Modelo";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // IdModelo
            // 
            this.IdModelo.HeaderText = "IdModelo";
            this.IdModelo.Name = "IdModelo";
            this.IdModelo.Visible = false;
            // 
            // btn_alta
            // 
            this.btn_alta.Location = new System.Drawing.Point(53, 539);
            this.btn_alta.Name = "btn_alta";
            this.btn_alta.Size = new System.Drawing.Size(79, 33);
            this.btn_alta.TabIndex = 3;
            this.btn_alta.Text = "Nuevo avion";
            this.btn_alta.UseVisualStyleBackColor = true;
            this.btn_alta.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // comboBox_Aerolinea1
            // 
            this.comboBox_Aerolinea1.FormattingEnabled = true;
            this.comboBox_Aerolinea1.Location = new System.Drawing.Point(129, 180);
            this.comboBox_Aerolinea1.Name = "comboBox_Aerolinea1";
            this.comboBox_Aerolinea1.Pp_CampoAceptaNull = false;
            this.comboBox_Aerolinea1.Pp_MensajeError = null;
            this.comboBox_Aerolinea1.Pp_NombreCampo = null;
            this.comboBox_Aerolinea1.Pp_NombreTabla = null;
            this.comboBox_Aerolinea1.Pp_PkTabla = null;
            this.comboBox_Aerolinea1.Size = new System.Drawing.Size(166, 21);
            this.comboBox_Aerolinea1.TabIndex = 7;
            // 
            // textBox_Aerolinea1
            // 
            this.textBox_Aerolinea1.Location = new System.Drawing.Point(129, 149);
            this.textBox_Aerolinea1.Name = "textBox_Aerolinea1";
            this.textBox_Aerolinea1.Pp_MensajeError = null;
            this.textBox_Aerolinea1.Pp_NombreCampo = null;
            this.textBox_Aerolinea1.Size = new System.Drawing.Size(166, 20);
            this.textBox_Aerolinea1.TabIndex = 4;
            // 
            // Frm_ABMAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(942, 698);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Aerolinea1);
            this.Controls.Add(this.grid_aviones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Aerolinea1);
            this.Controls.Add(this.btn_alta);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "Frm_ABMAviones";
            this.Text = "Frm_ABMAviones";
            this.Load += new System.EventHandler(this.Frm_ABMAviones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_aviones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_alta;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView grid_aviones;
        private Clase.TextBox_Aerolinea textBox_Aerolinea1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdModelo;
        private System.Windows.Forms.Label label4;
        private Clase.ComboBox_Aerolinea comboBox_Aerolinea1;
        private System.Windows.Forms.Button btn_actualizar;
    }
}