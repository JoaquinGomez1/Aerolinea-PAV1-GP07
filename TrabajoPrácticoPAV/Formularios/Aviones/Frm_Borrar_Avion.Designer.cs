
namespace TrabajoPrácticoPAV.Formularios.Aviones
{
    partial class Frm_Borrar_Avion
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.cmb_modelos = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.button_Aerolinea2 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.txt_idModelo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_numero = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(37, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(39, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(39, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID Modelo";
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(305, 32);
            this.BarraSuperior.TabIndex = 60;
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
            this.Titulo.Size = new System.Drawing.Size(151, 22);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "ELIMINAR AVION";
            // 
            // cmb_modelos
            // 
            this.cmb_modelos.Enabled = false;
            this.cmb_modelos.FormattingEnabled = true;
            this.cmb_modelos.Location = new System.Drawing.Point(125, 91);
            this.cmb_modelos.Name = "cmb_modelos";
            this.cmb_modelos.Pp_CampoAceptaNull = false;
            this.cmb_modelos.Pp_EsPk = false;
            this.cmb_modelos.Pp_MensajeError = null;
            this.cmb_modelos.Pp_NombreCampo = "nombre";
            this.cmb_modelos.Pp_NombreCampoInsert = null;
            this.cmb_modelos.Pp_NombreTabla = "Modelo";
            this.cmb_modelos.Pp_PkTabla = "idModelo";
            this.cmb_modelos.Size = new System.Drawing.Size(121, 21);
            this.cmb_modelos.TabIndex = 3;
            // 
            // button_Aerolinea2
            // 
            this.button_Aerolinea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.button_Aerolinea2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Aerolinea2.Location = new System.Drawing.Point(180, 180);
            this.button_Aerolinea2.Name = "button_Aerolinea2";
            this.button_Aerolinea2.Pp_Presionado = false;
            this.button_Aerolinea2.Size = new System.Drawing.Size(82, 33);
            this.button_Aerolinea2.TabIndex = 2;
            this.button_Aerolinea2.Text = "Cancelar";
            this.button_Aerolinea2.UseVisualStyleBackColor = false;
            this.button_Aerolinea2.Click += new System.EventHandler(this.button_Aerolinea2_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_eliminar.Location = new System.Drawing.Point(78, 180);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Pp_Presionado = false;
            this.btn_eliminar.Size = new System.Drawing.Size(82, 33);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = false;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // txt_idModelo
            // 
            this.txt_idModelo.Enabled = false;
            this.txt_idModelo.Location = new System.Drawing.Point(125, 134);
            this.txt_idModelo.Name = "txt_idModelo";
            this.txt_idModelo.Pp_EsPk = false;
            this.txt_idModelo.Pp_MensajeError = null;
            this.txt_idModelo.Pp_NombreCampo = null;
            this.txt_idModelo.Pp_NombreTabla = null;
            this.txt_idModelo.Size = new System.Drawing.Size(100, 20);
            this.txt_idModelo.TabIndex = 1;
            // 
            // txt_numero
            // 
            this.txt_numero.Enabled = false;
            this.txt_numero.Location = new System.Drawing.Point(125, 48);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Pp_EsPk = false;
            this.txt_numero.Pp_MensajeError = null;
            this.txt_numero.Pp_NombreCampo = null;
            this.txt_numero.Pp_NombreTabla = null;
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 1;
            // 
            // Frm_Borrar_Avion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(305, 231);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.cmb_modelos);
            this.Controls.Add(this.button_Aerolinea2);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.txt_idModelo);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Borrar_Avion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Borrar_Avion";
            this.Load += new System.EventHandler(this.Frm_Borrar_Avion_Load_1);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Clase.TextBox_Aerolinea txt_numero;
        private Clase.Button_Aerolinea btn_eliminar;
        private Clase.Button_Aerolinea button_Aerolinea2;
        private Clase.ComboBox_Aerolinea cmb_modelos;
        private Clase.TextBox_Aerolinea txt_idModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
    }
}