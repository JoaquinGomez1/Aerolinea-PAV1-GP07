namespace TrabajoPrácticoPAV.Formularios
{
    partial class Frm_ABMTramos
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
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chb_todos_tramo = new System.Windows.Forms.CheckBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_ADestino = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.cmb_ASalida = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.grid_tramos = new TrabajoPrácticoPAV.Clase.DataGridView_Aerolinea();
            this.txt_numero = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            ((System.ComponentModel.ISupportInitialize)(this.grid_tramos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Registrar nuevo tramo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(107, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 28);
            this.label6.TabIndex = 13;
            this.label6.Text = "Filtros";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(49, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Aeropuerto de destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(61, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Aeropuerto de salida:";
            // 
            // chb_todos_tramo
            // 
            this.chb_todos_tramo.AutoSize = true;
            this.chb_todos_tramo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chb_todos_tramo.Location = new System.Drawing.Point(713, 169);
            this.chb_todos_tramo.Name = "chb_todos_tramo";
            this.chb_todos_tramo.Size = new System.Drawing.Size(90, 29);
            this.chb_todos_tramo.TabIndex = 4;
            this.chb_todos_tramo.Text = "Todos";
            this.chb_todos_tramo.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_buscar.Location = new System.Drawing.Point(824, 259);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(102, 31);
            this.btn_buscar.TabIndex = 3;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(28, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de identificación:";
            // 
            // cmb_ADestino
            // 
            this.cmb_ADestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_ADestino.FormattingEnabled = true;
            this.cmb_ADestino.Location = new System.Drawing.Point(315, 259);
            this.cmb_ADestino.Name = "cmb_ADestino";
            this.cmb_ADestino.Pp_CampoAceptaNull = false;
            this.cmb_ADestino.Pp_MensajeError = null;
            this.cmb_ADestino.Pp_NombreCampo = "nombre";
            this.cmb_ADestino.Pp_NombreTabla = "Aeropuerto";
            this.cmb_ADestino.Pp_PkTabla = "codigo";
            this.cmb_ADestino.Size = new System.Drawing.Size(488, 33);
            this.cmb_ADestino.TabIndex = 6;
            // 
            // cmb_ASalida
            // 
            this.cmb_ASalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmb_ASalida.FormattingEnabled = true;
            this.cmb_ASalida.Location = new System.Drawing.Point(315, 214);
            this.cmb_ASalida.Name = "cmb_ASalida";
            this.cmb_ASalida.Pp_CampoAceptaNull = false;
            this.cmb_ASalida.Pp_MensajeError = null;
            this.cmb_ASalida.Pp_NombreCampo = "nombre";
            this.cmb_ASalida.Pp_NombreTabla = "Aeropuerto";
            this.cmb_ASalida.Pp_PkTabla = "codigo";
            this.cmb_ASalida.Size = new System.Drawing.Size(488, 33);
            this.cmb_ASalida.TabIndex = 5;
            // 
            // grid_tramos
            // 
            this.grid_tramos.AllowUserToAddRows = false;
            this.grid_tramos.AllowUserToDeleteRows = false;
            this.grid_tramos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_tramos.Location = new System.Drawing.Point(66, 318);
            this.grid_tramos.Name = "grid_tramos";
            this.grid_tramos.Pp_FormatoGrid = "codigo,ID , 50;nombre, Aeropuerto Salida, 250;nombre, Aeropuerto destino, 250;alg" +
    "o, Duración, 75;algo, Distancia, 75";
            this.grid_tramos.Pp_NombreTabla = null;
            this.grid_tramos.ReadOnly = true;
            this.grid_tramos.RowTemplate.Height = 24;
            this.grid_tramos.Size = new System.Drawing.Size(850, 162);
            this.grid_tramos.TabIndex = 2;
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txt_numero.Location = new System.Drawing.Point(315, 170);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Pp_MensajeError = null;
            this.txt_numero.Pp_NombreCampo = null;
            this.txt_numero.Pp_NombreTabla = null;
            this.txt_numero.Size = new System.Drawing.Size(147, 30);
            this.txt_numero.TabIndex = 1;
            // 
            // Frm_ABMTramos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(999, 510);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_ADestino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_ASalida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chb_todos_tramo);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.grid_tramos);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ABMTramos";
            this.Text = "Frm_ABMTramos";
            this.Load += new System.EventHandler(this.Frm_ABMTramos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_tramos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_numero;
        private Clase.DataGridView_Aerolinea grid_tramos;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Clase.ComboBox_Aerolinea cmb_ADestino;
        private Clase.ComboBox_Aerolinea cmb_ASalida;
        private System.Windows.Forms.CheckBox chb_todos_tramo;
    }
}