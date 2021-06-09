namespace TrabajoPrácticoPAV.Formularios.Listados.Aeropuertos
{
    partial class Frm_ReporteVueloXAeropuerto
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
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Txt_Codigo = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Txt_Nombre = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rbu_Numero = new System.Windows.Forms.RadioButton();
            this.Rbu_Todos = new System.Windows.Forms.RadioButton();
            this.Rbu_Nombre = new System.Windows.Forms.RadioButton();
            this.Rbu_Codigo = new System.Windows.Forms.RadioButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Txt_Desde = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Hasta = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Reporte de Vuelos por Aeropuerto";
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(581, 80);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Pp_Presionado = false;
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 31);
            this.Btn_Buscar.TabIndex = 28;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click);
            // 
            // Txt_Codigo
            // 
            this.Txt_Codigo.Location = new System.Drawing.Point(159, 63);
            this.Txt_Codigo.Name = "Txt_Codigo";
            this.Txt_Codigo.Pp_EsPk = false;
            this.Txt_Codigo.Pp_MensajeError = null;
            this.Txt_Codigo.Pp_NombreCampo = "codigo";
            this.Txt_Codigo.Pp_NombreTabla = "aeropuerto";
            this.Txt_Codigo.Size = new System.Drawing.Size(100, 20);
            this.Txt_Codigo.TabIndex = 25;
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.Location = new System.Drawing.Point(159, 39);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Pp_EsPk = false;
            this.Txt_Nombre.Pp_MensajeError = null;
            this.Txt_Nombre.Pp_NombreCampo = "nombre";
            this.Txt_Nombre.Pp_NombreTabla = "Aeropuerto";
            this.Txt_Nombre.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nombre.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(94, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Código";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(4, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre Aeropuerto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rbu_Numero);
            this.groupBox1.Controls.Add(this.Rbu_Todos);
            this.groupBox1.Controls.Add(this.Rbu_Nombre);
            this.groupBox1.Controls.Add(this.Rbu_Codigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(345, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 105);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo búsqueda";
            // 
            // Rbu_Numero
            // 
            this.Rbu_Numero.AutoSize = true;
            this.Rbu_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rbu_Numero.Location = new System.Drawing.Point(17, 61);
            this.Rbu_Numero.Name = "Rbu_Numero";
            this.Rbu_Numero.Size = new System.Drawing.Size(158, 21);
            this.Rbu_Numero.TabIndex = 4;
            this.Rbu_Numero.Text = "Por número de vuelo";
            this.Rbu_Numero.UseVisualStyleBackColor = true;
            // 
            // Rbu_Todos
            // 
            this.Rbu_Todos.AutoSize = true;
            this.Rbu_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rbu_Todos.Location = new System.Drawing.Point(17, 82);
            this.Rbu_Todos.Name = "Rbu_Todos";
            this.Rbu_Todos.Size = new System.Drawing.Size(66, 21);
            this.Rbu_Todos.TabIndex = 3;
            this.Rbu_Todos.Text = "Todos";
            this.Rbu_Todos.UseVisualStyleBackColor = true;
            // 
            // Rbu_Nombre
            // 
            this.Rbu_Nombre.AutoSize = true;
            this.Rbu_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rbu_Nombre.Location = new System.Drawing.Point(17, 19);
            this.Rbu_Nombre.Name = "Rbu_Nombre";
            this.Rbu_Nombre.Size = new System.Drawing.Size(100, 21);
            this.Rbu_Nombre.TabIndex = 0;
            this.Rbu_Nombre.Text = "Por nombre";
            this.Rbu_Nombre.UseVisualStyleBackColor = true;
            // 
            // Rbu_Codigo
            // 
            this.Rbu_Codigo.AutoSize = true;
            this.Rbu_Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Rbu_Codigo.Location = new System.Drawing.Point(17, 40);
            this.Rbu_Codigo.Name = "Rbu_Codigo";
            this.Rbu_Codigo.Size = new System.Drawing.Size(94, 21);
            this.Rbu_Codigo.TabIndex = 2;
            this.Rbu_Codigo.Text = "Por código";
            this.Rbu_Codigo.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Vuelos.Reporte_VuelosXAeropuerto.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(8, 117);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(648, 246);
            this.reportViewer1.TabIndex = 30;
            // 
            // Txt_Desde
            // 
            this.Txt_Desde.Location = new System.Drawing.Point(159, 89);
            this.Txt_Desde.Name = "Txt_Desde";
            this.Txt_Desde.Pp_EsPk = false;
            this.Txt_Desde.Pp_MensajeError = null;
            this.Txt_Desde.Pp_NombreCampo = "codigo";
            this.Txt_Desde.Pp_NombreTabla = "aeropuerto";
            this.Txt_Desde.Size = new System.Drawing.Size(43, 20);
            this.Txt_Desde.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(25, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Número de vuelo";
            // 
            // Txt_Hasta
            // 
            this.Txt_Hasta.Location = new System.Drawing.Point(216, 89);
            this.Txt_Hasta.Name = "Txt_Hasta";
            this.Txt_Hasta.Pp_EsPk = false;
            this.Txt_Hasta.Pp_MensajeError = null;
            this.Txt_Hasta.Pp_NombreCampo = "codigo";
            this.Txt_Hasta.Pp_NombreTabla = "aeropuerto";
            this.Txt_Hasta.Size = new System.Drawing.Size(43, 20);
            this.Txt_Hasta.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(200, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 29);
            this.label5.TabIndex = 35;
            this.label5.Text = "-";
            // 
            // Frm_ReporteVueloXAeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 382);
            this.Controls.Add(this.Txt_Hasta);
            this.Controls.Add(this.Txt_Desde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Codigo);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ReporteVueloXAeropuerto";
            this.Text = "Frm_ReporteVueloXAeropuerto";
            this.Load += new System.EventHandler(this.Frm_ReporteVueloXAeropuerto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Clase.Button_Aerolinea Btn_Buscar;
        private Clase.TextBox_Aerolinea Txt_Codigo;
        private Clase.TextBox_Aerolinea Txt_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rbu_Todos;
        private System.Windows.Forms.RadioButton Rbu_Nombre;
        private System.Windows.Forms.RadioButton Rbu_Codigo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton Rbu_Numero;
        private Clase.TextBox_Aerolinea Txt_Desde;
        private System.Windows.Forms.Label label3;
        private Clase.TextBox_Aerolinea Txt_Hasta;
        private System.Windows.Forms.Label label5;
    }
}