namespace TrabajoPrácticoPAV.Formularios.Tipo_Asientos
{
    partial class Frm_ConsultarTipoAsiento
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
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_idTipo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_Nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.btn_aceptar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.msktxt_Costo = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BarraSuperior.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(591, 39);
            this.BarraSuperior.TabIndex = 56;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(12, 7);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(291, 27);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "CONSULTAR TIPO ASIENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(157, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "ID";
            // 
            // txt_idTipo
            // 
            this.txt_idTipo.Enabled = false;
            this.txt_idTipo.Location = new System.Drawing.Point(237, 29);
            this.txt_idTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_idTipo.Name = "txt_idTipo";
            this.txt_idTipo.Pp_EsPk = true;
            this.txt_idTipo.Pp_MensajeError = null;
            this.txt_idTipo.Pp_NombreCampo = "idTipo";
            this.txt_idTipo.Pp_NombreTabla = "Tipo_Asiento";
            this.txt_idTipo.Size = new System.Drawing.Size(100, 22);
            this.txt_idTipo.TabIndex = 54;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Enabled = false;
            this.txt_Nombre.Location = new System.Drawing.Point(237, 71);
            this.txt_Nombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Pp_EsPk = false;
            this.txt_Nombre.Pp_MensajeError = "Por favor, modifique el nombre";
            this.txt_Nombre.Pp_NombreCampo = "nombre";
            this.txt_Nombre.Pp_NombreTabla = "Tipo_Asiento";
            this.txt_Nombre.Size = new System.Drawing.Size(262, 22);
            this.txt_Nombre.TabIndex = 53;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_aceptar.Location = new System.Drawing.Point(237, 172);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Pp_Presionado = false;
            this.btn_aceptar.Size = new System.Drawing.Size(99, 34);
            this.btn_aceptar.TabIndex = 51;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // msktxt_Costo
            // 
            this.msktxt_Costo.Enabled = false;
            this.msktxt_Costo.Location = new System.Drawing.Point(237, 113);
            this.msktxt_Costo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.msktxt_Costo.Mask = "00000";
            this.msktxt_Costo.Name = "msktxt_Costo";
            this.msktxt_Costo.Pp_EsPk = false;
            this.msktxt_Costo.Pp_MensajeError = "Por favor, modifique el costo";
            this.msktxt_Costo.Pp_NombreCampo = "costo";
            this.msktxt_Costo.Pp_NombreTabla = "Tipo_Asiento";
            this.msktxt_Costo.Size = new System.Drawing.Size(103, 22);
            this.msktxt_Costo.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(126, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Costo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(105, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_aceptar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.msktxt_Costo);
            this.panel1.Controls.Add(this.txt_Nombre);
            this.panel1.Controls.Add(this.txt_idTipo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 240);
            this.panel1.TabIndex = 57;
            // 
            // Frm_ConsultarTipoAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(591, 298);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ConsultarTipoAsiento";
            this.Text = "Frm_ConsultarTipoAsiento";
            this.Load += new System.EventHandler(this.Frm_ConsultarTipoAsiento_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label label3;
        private Clase.TextBox_Aerolinea txt_idTipo;
        private Clase.TextBox_Aerolinea txt_Nombre;
        private Clase.Button_Aerolinea btn_aceptar;
        private Clase.MaskedTextBox_Aerolinea msktxt_Costo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}