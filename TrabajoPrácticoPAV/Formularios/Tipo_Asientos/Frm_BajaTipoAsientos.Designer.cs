namespace TrabajoPrácticoPAV.Formularios.Tipo_Asientos
{
    partial class Frm_BajaTipoAsientos
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
            this.txt_Costo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombreBaja = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.btn_Cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_Eliminar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.Titulo = new System.Windows.Forms.Label();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Costo
            // 
            this.txt_Costo.Enabled = false;
            this.txt_Costo.Location = new System.Drawing.Point(215, 181);
            this.txt_Costo.Name = "txt_Costo";
            this.txt_Costo.Pp_EsPk = false;
            this.txt_Costo.Pp_MensajeError = null;
            this.txt_Costo.Pp_NombreCampo = "costo";
            this.txt_Costo.Pp_NombreTabla = "Tipo_Asiento";
            this.txt_Costo.Size = new System.Drawing.Size(100, 22);
            this.txt_Costo.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(122, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Costo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID";
            // 
            // txt_nombreBaja
            // 
            this.txt_nombreBaja.Enabled = false;
            this.txt_nombreBaja.Location = new System.Drawing.Point(215, 138);
            this.txt_nombreBaja.Name = "txt_nombreBaja";
            this.txt_nombreBaja.Pp_EsPk = false;
            this.txt_nombreBaja.Pp_MensajeError = "Por favor, ingrese el nombre de la clase ";
            this.txt_nombreBaja.Pp_NombreCampo = "nombre";
            this.txt_nombreBaja.Pp_NombreTabla = "Tipo_Asiento";
            this.txt_nombreBaja.Size = new System.Drawing.Size(100, 22);
            this.txt_nombreBaja.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(107, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(215, 97);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Pp_EsPk = true;
            this.txt_ID.Pp_MensajeError = null;
            this.txt_ID.Pp_NombreCampo = "idTipo";
            this.txt_ID.Pp_NombreTabla = "Tipo_Asiento";
            this.txt_ID.Size = new System.Drawing.Size(100, 22);
            this.txt_ID.TabIndex = 36;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Cancelar.Location = new System.Drawing.Point(489, 273);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Pp_Presionado = false;
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 34);
            this.btn_Cancelar.TabIndex = 32;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Eliminar.Location = new System.Drawing.Point(261, 273);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Pp_Presionado = false;
            this.btn_Eliminar.Size = new System.Drawing.Size(99, 34);
            this.btn_Eliminar.TabIndex = 31;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.Titulo);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(855, 39);
            this.BarraSuperior.TabIndex = 48;
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(12, 7);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(267, 27);
            this.Titulo.TabIndex = 4;
            this.Titulo.Text = "ELIMINAR TIPO ASIENTO";
            // 
            // Frm_BajaTipoAsientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(227)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(855, 366);
            this.Controls.Add(this.BarraSuperior);
            this.Controls.Add(this.txt_Costo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombreBaja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Eliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_BajaTipoAsientos";
            this.Text = "Frm_BajaTipoAsientos";
            this.Load += new System.EventHandler(this.Frm_BajaTipoAsientos_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Clase.TextBox_Aerolinea txt_Costo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Clase.TextBox_Aerolinea txt_nombreBaja;
        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_ID;
        private Clase.Button_Aerolinea btn_Cancelar;
        private Clase.Button_Aerolinea btn_Eliminar;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label Titulo;
    }
}