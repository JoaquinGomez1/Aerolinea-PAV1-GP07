
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
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rv_1
            // 
            this.rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesPorPais.ReporteViajesPorPais.rd" +
    "lc";
            this.rv_1.Location = new System.Drawing.Point(12, 115);
            this.rv_1.Name = "rv_1";
            this.rv_1.ServerReport.BearerToken = null;
            this.rv_1.Size = new System.Drawing.Size(723, 291);
            this.rv_1.TabIndex = 0;
            this.rv_1.ZoomPercent = 75;
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(6, 25);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(240, 24);
            this.rb_1.TabIndex = 2;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "Viajes realizados en cada pais";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(6, 48);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(259, 24);
            this.rb_2.TabIndex = 3;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "Filtrar paises que empiecen con: ";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Calcular.Location = new System.Drawing.Point(640, 60);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Pp_Presionado = false;
            this.btn_Calcular.Size = new System.Drawing.Size(95, 41);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // txt_letras
            // 
            this.txt_letras.Location = new System.Drawing.Point(271, 48);
            this.txt_letras.Name = "txt_letras";
            this.txt_letras.Pp_EsPk = false;
            this.txt_letras.Pp_MensajeError = null;
            this.txt_letras.Pp_NombreCampo = null;
            this.txt_letras.Pp_NombreTabla = null;
            this.txt_letras.Size = new System.Drawing.Size(36, 26);
            this.txt_letras.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Estadistica de Viajes por País";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_1);
            this.groupBox1.Controls.Add(this.rb_2);
            this.groupBox1.Controls.Add(this.txt_letras);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(272, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 92);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selección";
            // 
            // Frm_ViajesPorPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.rv_1);
            this.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ViajesPorPais";
            this.Text = "Frm_ViajesPorPais";
            this.Load += new System.EventHandler(this.Frm_ViajesPorPais_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_1;
        private Clase.Button_Aerolinea btn_Calcular;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.RadioButton rb_2;
        private Clase.TextBox_Aerolinea txt_letras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}