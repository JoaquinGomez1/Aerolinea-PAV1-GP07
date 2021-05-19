namespace TrabajoPrácticoPAV.Formularios.Modelo
{
    partial class Frm_ConsultaModelo
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
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_codigoModelo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cerrar.Location = new System.Drawing.Point(236, 175);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(100, 39);
            this.btn_cerrar.TabIndex = 11;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(94, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre del modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(101, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo del modelo";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Location = new System.Drawing.Point(271, 114);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_EsPk = false;
            this.txt_nombre.Pp_MensajeError = null;
            this.txt_nombre.Pp_NombreCampo = "nombre";
            this.txt_nombre.Pp_NombreTabla = "Modelo";
            this.txt_nombre.Size = new System.Drawing.Size(212, 22);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_codigoModelo
            // 
            this.txt_codigoModelo.Enabled = false;
            this.txt_codigoModelo.Location = new System.Drawing.Point(271, 65);
            this.txt_codigoModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_codigoModelo.Name = "txt_codigoModelo";
            this.txt_codigoModelo.Pp_EsPk = false;
            this.txt_codigoModelo.Pp_MensajeError = null;
            this.txt_codigoModelo.Pp_NombreCampo = "idModelo";
            this.txt_codigoModelo.Pp_NombreTabla = "Modelo";
            this.txt_codigoModelo.Size = new System.Drawing.Size(161, 22);
            this.txt_codigoModelo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Consultar modelo";
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(582, 39);
            this.BarraSuperior.TabIndex = 51;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(12, 7);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(236, 27);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "CONSULTAR MODELO";
            // 
            // Frm_ConsultaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(582, 250);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigoModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_ConsultaModelo";
            this.Text = "Frm_ConsultaModelo";
            this.Load += new System.EventHandler(this.Frm_ConsultaModelo_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.Button_Aerolinea btn_cerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clase.TextBox_Aerolinea txt_nombre;
        private Clase.TextBox_Aerolinea txt_codigoModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
    }
}