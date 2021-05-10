namespace TrabajoPrácticoPAV.Formularios.Modelo
{
    partial class Frm_ModificarModelo
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
            this.btn_eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_codigoModelo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(392, 236);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 11;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(240, 236);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Pp_Presionado = false;
            this.btn_eliminar.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar.TabIndex = 10;
            this.btn_eliminar.Text = "Modificar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre del modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(191, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo del modelo";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(305, 83);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_EsPk = false;
            this.txt_nombre.Pp_MensajeError = "Ingrese el nombre del modelo";
            this.txt_nombre.Pp_NombreCampo = "nombre";
            this.txt_nombre.Pp_NombreTabla = "Modelo";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 7;
            // 
            // txt_codigoModelo
            // 
            this.txt_codigoModelo.Enabled = false;
            this.txt_codigoModelo.Location = new System.Drawing.Point(305, 43);
            this.txt_codigoModelo.Name = "txt_codigoModelo";
            this.txt_codigoModelo.Pp_EsPk = true;
            this.txt_codigoModelo.Pp_MensajeError = null;
            this.txt_codigoModelo.Pp_NombreCampo = "idModelo";
            this.txt_codigoModelo.Pp_NombreTabla = "Modelo";
            this.txt_codigoModelo.Size = new System.Drawing.Size(100, 20);
            this.txt_codigoModelo.TabIndex = 6;
            // 
            // Frm_ModificarModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(658, 303);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_codigoModelo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ModificarModelo";
            this.Text = "Frm_ModificarModelo";
            this.Load += new System.EventHandler(this.Frm_ModificarModelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.Button_Aerolinea btn_cerrar;
        private Clase.Button_Aerolinea btn_eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Clase.TextBox_Aerolinea txt_nombre;
        private Clase.TextBox_Aerolinea txt_codigoModelo;
    }
}