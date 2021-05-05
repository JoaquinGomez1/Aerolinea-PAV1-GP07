
namespace TrabajoPrácticoPAV.Formularios
{
    partial class Frm_ModificarAvion
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
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Numero = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.cmb_Modelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(76, 213);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(59, 23);
            this.btn_modificar.TabIndex = 2;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(155, 213);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(62, 23);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label.Location = new System.Drawing.Point(72, 29);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(145, 20);
            this.label.TabIndex = 4;
            this.label.Text = "Modificar Campos";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_Numero);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.cmb_Modelo);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_modificar);
            this.panel1.Location = new System.Drawing.Point(23, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 308);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(76, 108);
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Pp_MensajeError = null;
            this.txt_Numero.Pp_NombreCampo = null;
            this.txt_Numero.Pp_NombreTabla = null;
            this.txt_Numero.Size = new System.Drawing.Size(141, 20);
            this.txt_Numero.TabIndex = 1;
            this.txt_Numero.TextChanged += new System.EventHandler(this.textBox_Aerolinea1_TextChanged);
            // 
            // cmb_Modelo
            // 
            this.cmb_Modelo.FormattingEnabled = true;
            this.cmb_Modelo.Location = new System.Drawing.Point(76, 134);
            this.cmb_Modelo.Name = "cmb_Modelo";
            this.cmb_Modelo.Pp_CampoAceptaNull = true;
            this.cmb_Modelo.Pp_MensajeError = null;
            this.cmb_Modelo.Pp_NombreCampo = "nombre";
            this.cmb_Modelo.Pp_NombreTabla = "Modelo";
            this.cmb_Modelo.Pp_PkTabla = "idModelo";
            this.cmb_Modelo.Size = new System.Drawing.Size(141, 21);
            this.cmb_Modelo.TabIndex = 0;
            this.cmb_Modelo.SelectedIndexChanged += new System.EventHandler(this.cmb_Modelo_SelectedIndexChanged);
            // 
            // Frm_ModificarAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 385);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ModificarAvion";
            this.Text = "Frm_ModificarAvion";
            this.Load += new System.EventHandler(this.Frm_ModificarAvion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Clase.ComboBox_Aerolinea cmb_Modelo;
        private Clase.TextBox_Aerolinea txt_Numero;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Panel panel1;
    }
}