namespace TrabajoPrácticoPAV.Formularios.Tipo_Asientos
{
    partial class Frm_ModificarTipoAsiento
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
            this.msktxt_Costo = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.btn_Actualizar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_Cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.txt_Nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.txt_idTipo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(113, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(131, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Costo";
            // 
            // msktxt_Costo
            // 
            this.msktxt_Costo.Location = new System.Drawing.Point(236, 155);
            this.msktxt_Costo.Mask = "00000";
            this.msktxt_Costo.Name = "msktxt_Costo";
            this.msktxt_Costo.Pp_EsPk = false;
            this.msktxt_Costo.Pp_MensajeError = "Por favor, modifique el costo";
            this.msktxt_Costo.Pp_NombreCampo = "costo";
            this.msktxt_Costo.Pp_NombreTabla = "Tipo_Asiento";
            this.msktxt_Costo.Size = new System.Drawing.Size(100, 22);
            this.msktxt_Costo.TabIndex = 3;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Actualizar.Location = new System.Drawing.Point(159, 232);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Pp_Presionado = false;
            this.btn_Actualizar.Size = new System.Drawing.Size(99, 34);
            this.btn_Actualizar.TabIndex = 4;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click_1);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(133)))), ((int)(((byte)(74)))));
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Cancelar.Location = new System.Drawing.Point(313, 232);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Pp_Presionado = false;
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 34);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(236, 115);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Pp_EsPk = false;
            this.txt_Nombre.Pp_MensajeError = "Por favor, modifique el nombre";
            this.txt_Nombre.Pp_NombreCampo = "nombre";
            this.txt_Nombre.Pp_NombreTabla = "Tipo_Asiento";
            this.txt_Nombre.Size = new System.Drawing.Size(262, 22);
            this.txt_Nombre.TabIndex = 6;
            // 
            // txt_idTipo
            // 
            this.txt_idTipo.Enabled = false;
            this.txt_idTipo.Location = new System.Drawing.Point(236, 75);
            this.txt_idTipo.Name = "txt_idTipo";
            this.txt_idTipo.Pp_EsPk = true;
            this.txt_idTipo.Pp_MensajeError = null;
            this.txt_idTipo.Pp_NombreCampo = "idTipo";
            this.txt_idTipo.Pp_NombreTabla = "Tipo_Asiento";
            this.txt_idTipo.Size = new System.Drawing.Size(100, 22);
            this.txt_idTipo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(165, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID";
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
            this.BarraSuperior.TabIndex = 47;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(12, 7);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(284, 27);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "MODIFICAR TIPO ASIENTO";
            // 
            // Frm_ModificarTipoAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(591, 298);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_idTipo);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Actualizar);
            this.Controls.Add(this.msktxt_Costo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ModificarTipoAsiento";
            this.Text = "Frm_ModificarTipoAsiento";
            this.Load += new System.EventHandler(this.Frm_ModificarTipoAsiento_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Clase.MaskedTextBox_Aerolinea msktxt_Costo;
        private Clase.Button_Aerolinea btn_Actualizar;
        private Clase.Button_Aerolinea btn_Cancelar;
        private Clase.TextBox_Aerolinea txt_Nombre;
        private Clase.TextBox_Aerolinea txt_idTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
    }
}