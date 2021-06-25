
namespace TrabajoPrácticoPAV.Formularios.Teléfono
{
    partial class Frm_Borrar_Telefono
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nroTelefono = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_nroDoc = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_tipoDoc = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(108, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 34;
            this.label1.Text = "Eliminar teléfono";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.button1.Location = new System.Drawing.Point(213, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_eliminar.Location = new System.Drawing.Point(62, 214);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(90, 28);
            this.btn_eliminar.TabIndex = 32;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(58, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Nro. Documento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(58, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Tipo de documento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(58, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Nro. de Teléfono";
            // 
            // txt_nroTelefono
            // 
            this.txt_nroTelefono.Enabled = false;
            this.txt_nroTelefono.Location = new System.Drawing.Point(203, 103);
            this.txt_nroTelefono.Name = "txt_nroTelefono";
            this.txt_nroTelefono.Pp_EsPk = false;
            this.txt_nroTelefono.Pp_MensajeError = null;
            this.txt_nroTelefono.Pp_NombreCampo = null;
            this.txt_nroTelefono.Pp_NombreTabla = null;
            this.txt_nroTelefono.Size = new System.Drawing.Size(100, 20);
            this.txt_nroTelefono.TabIndex = 43;
            // 
            // txt_nroDoc
            // 
            this.txt_nroDoc.Enabled = false;
            this.txt_nroDoc.Location = new System.Drawing.Point(203, 155);
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Pp_EsPk = false;
            this.txt_nroDoc.Pp_MensajeError = null;
            this.txt_nroDoc.Pp_NombreCampo = null;
            this.txt_nroDoc.Pp_NombreTabla = null;
            this.txt_nroDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_nroDoc.TabIndex = 44;
            // 
            // txt_tipoDoc
            // 
            this.txt_tipoDoc.Enabled = false;
            this.txt_tipoDoc.Location = new System.Drawing.Point(203, 129);
            this.txt_tipoDoc.Name = "txt_tipoDoc";
            this.txt_tipoDoc.Pp_EsPk = false;
            this.txt_tipoDoc.Pp_MensajeError = null;
            this.txt_tipoDoc.Pp_NombreCampo = null;
            this.txt_tipoDoc.Pp_NombreTabla = null;
            this.txt_tipoDoc.Size = new System.Drawing.Size(100, 20);
            this.txt_tipoDoc.TabIndex = 45;
            // 
            // Frm_Borrar_Telefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(351, 300);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nroTelefono);
            this.Controls.Add(this.txt_nroDoc);
            this.Controls.Add(this.txt_tipoDoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_eliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Borrar_Telefono";
            this.Text = "Frm_Borrar_Telefono";
            this.Load += new System.EventHandler(this.Frm_Borrar_Telefono_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_nroTelefono;
        private Clase.TextBox_Aerolinea txt_nroDoc;
        private Clase.TextBox_Aerolinea txt_tipoDoc;
    }
}