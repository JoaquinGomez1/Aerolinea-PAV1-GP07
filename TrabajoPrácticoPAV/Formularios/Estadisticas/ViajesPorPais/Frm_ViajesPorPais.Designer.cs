
namespace TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorPais
{
    partial class Frm_ViajesPorPais
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
            this.rv_1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.btn_Calcular = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.txt_letras = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.SuspendLayout();
            // 
            // rv_1
            // 
            this.rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorPais.ReporteViajesPorPais.rd" +
    "lc";
            this.rv_1.Location = new System.Drawing.Point(34, 131);
            this.rv_1.Name = "rv_1";
            this.rv_1.ServerReport.BearerToken = null;
            this.rv_1.Size = new System.Drawing.Size(699, 325);
            this.rv_1.TabIndex = 0;
            this.rv_1.ZoomPercent = 75;
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(34, 57);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(167, 17);
            this.rb_1.TabIndex = 2;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "Viajes realizados en cada pais";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(34, 80);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(180, 17);
            this.rb_2.TabIndex = 3;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "Filtrar paises que empiecen con: ";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(606, 96);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Pp_Presionado = false;
            this.btn_Calcular.Size = new System.Drawing.Size(127, 23);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_letras
            // 
            this.txt_letras.Location = new System.Drawing.Point(219, 77);
            this.txt_letras.Name = "txt_letras";
            this.txt_letras.Pp_EsPk = false;
            this.txt_letras.Pp_MensajeError = null;
            this.txt_letras.Pp_NombreCampo = null;
            this.txt_letras.Pp_NombreTabla = null;
            this.txt_letras.Size = new System.Drawing.Size(36, 20);
            this.txt_letras.TabIndex = 4;
            this.txt_letras.TextChanged += new System.EventHandler(this.textBox_Aerolinea1_TextChanged);
            // 
            // Frm_ViajesPorPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 483);
            this.Controls.Add(this.txt_letras);
            this.Controls.Add(this.rb_2);
            this.Controls.Add(this.rb_1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.rv_1);
            this.Name = "Frm_ViajesPorPais";
            this.Text = "Frm_ViajesPorPais";
            this.Load += new System.EventHandler(this.Frm_ViajesPorPais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_1;
        private Clase.Button_Aerolinea btn_Calcular;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.RadioButton rb_2;
        private Clase.TextBox_Aerolinea txt_letras;
    }
}