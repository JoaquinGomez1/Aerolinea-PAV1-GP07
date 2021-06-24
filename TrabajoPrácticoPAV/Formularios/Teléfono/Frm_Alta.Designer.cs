
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
            this.txt_nroDoc = new Clase11.Clases.LabelText02();
            this.txt_tipoDoc = new Clase11.Clases.LabelText02();
            this.txt_nroTelefono = new Clase11.Clases.LabelText02();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nroDoc
            // 
            this.txt_nroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroDoc.Location = new System.Drawing.Point(84, 149);
            this.txt_nroDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nroDoc.Name = "txt_nroDoc";
            this.txt_nroDoc.Pp_ancho = 10;
            this.txt_nroDoc.Pp_decimales = 2;
            this.txt_nroDoc.Pp_Etiqueta = "Nro. de documento";
            this.txt_nroDoc.Pp_mensajeError = null;
            this.txt_nroDoc.Pp_nombre_campo = null;
            this.txt_nroDoc.Pp_nombre_tabla = null;
            this.txt_nroDoc.Pp_ReadOnly = false;
            this.txt_nroDoc.Pp_Text = "";
            this.txt_nroDoc.Pp_tipoDato = Clase11.Clases.LabelText02.TipoDato.texto;
            this.txt_nroDoc.Pp_validable = false;
            this.txt_nroDoc.Size = new System.Drawing.Size(228, 28);
            this.txt_nroDoc.TabIndex = 23;
            // 
            // txt_tipoDoc
            // 
            this.txt_tipoDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipoDoc.Location = new System.Drawing.Point(84, 120);
            this.txt_tipoDoc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tipoDoc.Name = "txt_tipoDoc";
            this.txt_tipoDoc.Pp_ancho = 10;
            this.txt_tipoDoc.Pp_decimales = 2;
            this.txt_tipoDoc.Pp_Etiqueta = "Tipo documento";
            this.txt_tipoDoc.Pp_mensajeError = null;
            this.txt_tipoDoc.Pp_nombre_campo = null;
            this.txt_tipoDoc.Pp_nombre_tabla = null;
            this.txt_tipoDoc.Pp_ReadOnly = false;
            this.txt_tipoDoc.Pp_Text = "";
            this.txt_tipoDoc.Pp_tipoDato = Clase11.Clases.LabelText02.TipoDato.texto;
            this.txt_tipoDoc.Pp_validable = false;
            this.txt_tipoDoc.Size = new System.Drawing.Size(228, 28);
            this.txt_tipoDoc.TabIndex = 24;
            // 
            // txt_nroTelefono
            // 
            this.txt_nroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroTelefono.Location = new System.Drawing.Point(84, 84);
            this.txt_nroTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nroTelefono.Name = "txt_nroTelefono";
            this.txt_nroTelefono.Pp_ancho = 10;
            this.txt_nroTelefono.Pp_decimales = 2;
            this.txt_nroTelefono.Pp_Etiqueta = "Número de teléfono";
            this.txt_nroTelefono.Pp_mensajeError = null;
            this.txt_nroTelefono.Pp_nombre_campo = null;
            this.txt_nroTelefono.Pp_nombre_tabla = "Telefono";
            this.txt_nroTelefono.Pp_ReadOnly = false;
            this.txt_nroTelefono.Pp_Text = "";
            this.txt_nroTelefono.Pp_tipoDato = Clase11.Clases.LabelText02.TipoDato.texto;
            this.txt_nroTelefono.Pp_validable = false;
            this.txt_nroTelefono.Size = new System.Drawing.Size(228, 28);
            this.txt_nroTelefono.TabIndex = 25;
            // 
            // btn_registrar
            // 
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_registrar.Location = new System.Drawing.Point(94, 211);
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
            this.button1.Location = new System.Drawing.Point(222, 211);
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
            // Frm_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(390, 277);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.txt_nroDoc);
            this.Controls.Add(this.txt_tipoDoc);
            this.Controls.Add(this.txt_nroTelefono);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Alta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Alta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase11.Clases.LabelText02 txt_nroDoc;
        private Clase11.Clases.LabelText02 txt_tipoDoc;
        private Clase11.Clases.LabelText02 txt_nroTelefono;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}