namespace TrabajoPrácticoPAV.Formularios.Provincia
{
    partial class Frm_AltaProvincia
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
            this.label2 = new System.Windows.Forms.Label();
            this.BarraSuperior = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Pais = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.btn_cancelar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.btn_registar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.txt_nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.BarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(361, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nombre";
            // 
            // BarraSuperior
            // 
            this.BarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.BarraSuperior.Controls.Add(this.label15);
            this.BarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.BarraSuperior.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BarraSuperior.Name = "BarraSuperior";
            this.BarraSuperior.Size = new System.Drawing.Size(716, 39);
            this.BarraSuperior.TabIndex = 74;
            this.BarraSuperior.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BarraSuperior_MouseMove);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(12, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(235, 27);
            this.label15.TabIndex = 4;
            this.label15.Text = "REGISTAR PROVINCIA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label1.Location = new System.Drawing.Point(84, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "País";
            // 
            // cmb_Pais
            // 
            this.cmb_Pais.FormattingEnabled = true;
            this.cmb_Pais.Location = new System.Drawing.Point(146, 91);
            this.cmb_Pais.Name = "cmb_Pais";
            this.cmb_Pais.Pp_CampoAceptaNull = false;
            this.cmb_Pais.Pp_EsPk = false;
            this.cmb_Pais.Pp_MensajeError = "Seleccione un país";
            this.cmb_Pais.Pp_NombreCampo = "nombrePais";
            this.cmb_Pais.Pp_NombreCampoInsert = "idPais";
            this.cmb_Pais.Pp_NombreTabla = "Pais";
            this.cmb_Pais.Pp_PkTabla = "idPais";
            this.cmb_Pais.Size = new System.Drawing.Size(141, 24);
            this.cmb_Pais.TabIndex = 76;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cancelar.Location = new System.Drawing.Point(373, 171);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Pp_Presionado = false;
            this.btn_cancelar.Size = new System.Drawing.Size(120, 34);
            this.btn_cancelar.TabIndex = 73;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_registar
            // 
            this.btn_registar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_registar.Location = new System.Drawing.Point(221, 171);
            this.btn_registar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Pp_Presionado = false;
            this.btn_registar.Size = new System.Drawing.Size(120, 34);
            this.btn_registar.TabIndex = 72;
            this.btn_registar.Text = "Registrar";
            this.btn_registar.UseVisualStyleBackColor = true;
            this.btn_registar.Click += new System.EventHandler(this.btn_registar_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txt_nombre.Location = new System.Drawing.Point(449, 90);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Pp_EsPk = false;
            this.txt_nombre.Pp_MensajeError = "Ingrese un nombre";
            this.txt_nombre.Pp_NombreCampo = "nombreProvincia";
            this.txt_nombre.Pp_NombreTabla = "Provincia";
            this.txt_nombre.Size = new System.Drawing.Size(141, 27);
            this.txt_nombre.TabIndex = 71;
            // 
            // Frm_AltaProvincia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Pais);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_registar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.BarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AltaProvincia";
            this.Text = "Frm_AltaProvincia";
            this.Load += new System.EventHandler(this.Frm_AltaProvincia_Load);
            this.BarraSuperior.ResumeLayout(false);
            this.BarraSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.Button_Aerolinea btn_cancelar;
        private Clase.Button_Aerolinea btn_registar;
        private System.Windows.Forms.Label label2;
        private Clase.TextBox_Aerolinea txt_nombre;
        private System.Windows.Forms.Panel BarraSuperior;
        private System.Windows.Forms.Label label15;
        private Clase.ComboBox_Aerolinea cmb_Pais;
        private System.Windows.Forms.Label label1;
    }
}