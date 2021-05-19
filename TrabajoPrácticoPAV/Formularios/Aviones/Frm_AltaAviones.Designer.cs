
namespace TrabajoPrácticoPAV.Formularios
{
    partial class Frm_AltaAviones
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_Modelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.txt_numero = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.btn_registrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(83, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Registrar Nuevo Avion";
            // 
            // cmb_Modelo
            // 
            this.cmb_Modelo.FormattingEnabled = true;
            this.cmb_Modelo.Location = new System.Drawing.Point(112, 141);
            this.cmb_Modelo.Name = "cmb_Modelo";
            this.cmb_Modelo.Pp_CampoAceptaNull = true;
            this.cmb_Modelo.Pp_EsPk = false;
            this.cmb_Modelo.Pp_MensajeError = null;
            this.cmb_Modelo.Pp_NombreCampo = "nombre";
            this.cmb_Modelo.Pp_NombreCampoInsert = null;
            this.cmb_Modelo.Pp_NombreTabla = "Modelo";
            this.cmb_Modelo.Pp_PkTabla = "idModelo";
            this.cmb_Modelo.Size = new System.Drawing.Size(158, 21);
            this.cmb_Modelo.TabIndex = 1;
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(112, 105);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Pp_EsPk = false;
            this.txt_numero.Pp_MensajeError = null;
            this.txt_numero.Pp_NombreCampo = null;
            this.txt_numero.Pp_NombreTabla = null;
            this.txt_numero.Size = new System.Drawing.Size(158, 20);
            this.txt_numero.TabIndex = 0;
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(96, 205);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Pp_Presionado = false;
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 7;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(195, 205);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Pp_Presionado = false;
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Frm_AltaAviones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(334, 291);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Modelo);
            this.Controls.Add(this.txt_numero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_AltaAviones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AltaAviones";
            this.Load += new System.EventHandler(this.Frm_AltaAviones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.TextBox_Aerolinea txt_numero;
        private Clase.ComboBox_Aerolinea cmb_Modelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Clase.Button_Aerolinea btn_registrar;
        private Clase.Button_Aerolinea btn_cancelar;
    }
}