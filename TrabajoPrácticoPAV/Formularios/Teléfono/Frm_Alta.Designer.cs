
namespace TrabajoPrácticoPAV.Formularios.Teléfono
{
    partial class Frm_Alta
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
            this.btn_registrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nroTelefono = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_nroDoc = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_tipoDoc = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.SuspendLayout();
            // 
            // btn_registrar
            // 
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_registrar.Location = new System.Drawing.Point(81, 184);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(90, 28);
            this.btn_registrar.TabIndex = 26;
            this.btn_registrar.Text = "Registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button1.Location = new System.Drawing.Point(232, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 27;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(127, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Registrar teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(77, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "Nro. Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(77, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tipo de documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(77, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nro. de Teléfono";
            // 
            // txt_nroTelefono
            // 
            this.txt_nroTelefono.Location = new System.Drawing.Point(222, 87);
            this.txt_nroTelefono.Name = "txt_nroTelefono";
            this.txt_nroTelefono.Pp_EsPk = false;
            this.txt_nroTelefono.Pp_MensajeError = null;
            this.txt_nroTelefono.Pp_NombreCampo = null;
            this.txt_nroTelefono.Pp_NombreTabla = null;
            this.txt_nroTelefono.Size = new System.Drawing.Size(100, 20);
            this.txt_nroTelefono.TabIndex = 37;
            // 
            // txt_nroDoc
            // 
            this.txt_nroDoc.Location = new System.Drawing.Point(222, 139);
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Pp_EsPk = false;
            this.txt_nroDoc.Pp_MensajeError = null;
            this.txt_nroDoc.Pp_NombreCampo = null;
            this.txt_nroDoc.Pp_NombreTabla = null;
            this.txt_nroDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_nroDoc.TabIndex = 38;
            // 
            // txt_tipoDoc
            // 
            this.txt_tipoDoc.Location = new System.Drawing.Point(222, 113);
            this.txt_tipoDoc.Name = "txt_tipoDoc";
            this.txt_tipoDoc.Pp_EsPk = false;
            this.txt_tipoDoc.Pp_MensajeError = null;
            this.txt_tipoDoc.Pp_NombreCampo = null;
            this.txt_tipoDoc.Pp_NombreTabla = null;
            this.txt_tipoDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_tipoDoc.TabIndex = 39;
            // 
            // Frm_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(390, 277);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nroTelefono);
            this.Controls.Add(this.txt_nroDoc);
            this.Controls.Add(this.txt_tipoDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_registrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_nroTelefono;
        private Clase.TextBox_Aerolinea txt_nroDoc;
        private Clase.TextBox_Aerolinea txt_tipoDoc;
    }
}