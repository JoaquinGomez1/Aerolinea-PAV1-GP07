namespace TrabajoPrácticoPAV.Formularios.Modelo
{
    partial class Frm_AltaModelo
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
            this.textBox_Aerolinea1 = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.SuspendLayout();
            // 
            // textBox_Aerolinea1
            // 
            this.textBox_Aerolinea1.Location = new System.Drawing.Point(225, 107);
            this.textBox_Aerolinea1.Name = "textBox_Aerolinea1";
            this.textBox_Aerolinea1.Pp_EsPk = false;
            this.textBox_Aerolinea1.Pp_MensajeError = null;
            this.textBox_Aerolinea1.Pp_NombreCampo = "nombre";
            this.textBox_Aerolinea1.Pp_NombreTabla = "Modelo";
            this.textBox_Aerolinea1.Size = new System.Drawing.Size(100, 20);
            this.textBox_Aerolinea1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(99, 242);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Pp_Presionado = false;
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 2;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(251, 242);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(75, 23);
            this.btn_cerrar.TabIndex = 3;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Frm_AltaModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(658, 303);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Aerolinea1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AltaModelo";
            this.Text = "Frm_AltaModelo";
            this.Load += new System.EventHandler(this.Frm_AltaModelo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.TextBox_Aerolinea textBox_Aerolinea1;
        private System.Windows.Forms.Label label1;
        private Clase.Button_Aerolinea btn_registrar;
        private Clase.Button_Aerolinea btn_cerrar;
    }
}