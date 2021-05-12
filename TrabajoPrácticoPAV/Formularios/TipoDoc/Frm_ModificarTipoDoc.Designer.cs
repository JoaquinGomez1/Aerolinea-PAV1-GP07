
namespace TrabajoPrácticoPAV.Formularios.TipoDoc
{
    partial class Frm_ModificarTipoDoc
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_documento = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(227, 193);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 2;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo Documento";
            // 
            // txt_documento
            // 
            this.txt_documento.Location = new System.Drawing.Point(111, 98);
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.Pp_EsPk = false;
            this.txt_documento.Pp_MensajeError = null;
            this.txt_documento.Pp_NombreCampo = null;
            this.txt_documento.Pp_NombreTabla = null;
            this.txt_documento.Size = new System.Drawing.Size(191, 20);
            this.txt_documento.TabIndex = 3;
            this.txt_documento.TextChanged += new System.EventHandler(this.textBox_Aerolinea1_TextChanged);
            // 
            // Frm_ModificarTipoDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(363, 264);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.button1);
            this.Name = "Frm_ModificarTipoDoc";
            this.Text = "Frm_ModificarTipoDoc";
            this.Load += new System.EventHandler(this.Frm_ModificarTipoDoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_borrar;
        private Clase.TextBox_Aerolinea txt_documento;
        private System.Windows.Forms.Label label1;
    }
}