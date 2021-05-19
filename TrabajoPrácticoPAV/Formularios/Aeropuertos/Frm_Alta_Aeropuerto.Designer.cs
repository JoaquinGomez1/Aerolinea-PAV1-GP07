
namespace TrabajoPrácticoPAV.Formularios.Aeropuertos
{
    partial class Frm_Alta_Aeropuerto
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
            this.btn_volver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_ciudades = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_codigo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_volver.Location = new System.Drawing.Point(176, 171);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(82, 33);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Cancelar";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(73, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(67, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_aceptar.Location = new System.Drawing.Point(88, 171);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(82, 33);
            this.btn_aceptar.TabIndex = 2;
            this.btn_aceptar.Text = "Registrar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(73, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ciudad";
            // 
            // cmb_ciudades
            // 
            this.cmb_ciudades.FormattingEnabled = true;
            this.cmb_ciudades.Location = new System.Drawing.Point(138, 106);
            this.cmb_ciudades.Name = "cmb_ciudades";
            this.cmb_ciudades.Pp_CampoAceptaNull = false;
            this.cmb_ciudades.Pp_EsPk = false;
            this.cmb_ciudades.Pp_MensajeError = "No se a cargado una id de ciudad .";
            this.cmb_ciudades.Pp_NombreCampo = "nombreCiudad";
            this.cmb_ciudades.Pp_NombreCampoInsert = "idCiudad";
            this.cmb_ciudades.Pp_NombreTabla = "Ciudad";
            this.cmb_ciudades.Pp_PkTabla = "idCiudad";
            this.cmb_ciudades.Size = new System.Drawing.Size(135, 21);
            this.cmb_ciudades.TabIndex = 6;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(138, 77);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_EsPk = false;
            this.txt_nombre.Pp_MensajeError = "Falta cargar nombre del aeropuerto.";
            this.txt_nombre.Pp_NombreCampo = "nombre";
            this.txt_nombre.Pp_NombreTabla = "Aeropuerto";
            this.txt_nombre.Size = new System.Drawing.Size(135, 20);
            this.txt_nombre.TabIndex = 5;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(138, 50);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Pp_EsPk = true;
            this.txt_codigo.Pp_MensajeError = "Falta cargar codigo del aeropuerto.";
            this.txt_codigo.Pp_NombreCampo = "codigo";
            this.txt_codigo.Pp_NombreTabla = "Aeropuerto";
            this.txt_codigo.Size = new System.Drawing.Size(82, 20);
            this.txt_codigo.TabIndex = 5;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(338, 32);
            this.BarraSuperior.TabIndex = 59;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(9, 6);
            this.Titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(205, 22);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "AGREGAR AEROPUERTO";
            // 
            // Frm_Alta_Aeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(338, 220);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.cmb_ciudades);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.btn_volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Alta_Aeropuerto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ABM_Aeropuerto";
            this.Load += new System.EventHandler(this.Frm_Alta_Aeropuerto_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Label label4;
        private Clase.TextBox_Aerolinea txt_codigo;
        private Clase.TextBox_Aerolinea txt_nombre;
        private Clase.ComboBox_Aerolinea cmb_ciudades;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
    }
}