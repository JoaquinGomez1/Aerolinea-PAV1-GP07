
namespace TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXMes
{
    partial class Frm_FacturasXMes
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
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.cmb_Meses = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rv_1
            // 
            this.rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXMes.ReporteFacturasXMes.rdlc" +
    "";
            this.rv_1.Location = new System.Drawing.Point(26, 123);
            this.rv_1.Name = "rv_1";
            this.rv_1.ServerReport.BearerToken = null;
            this.rv_1.Size = new System.Drawing.Size(705, 416);
            this.rv_1.TabIndex = 0;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(608, 94);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(123, 23);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(26, 57);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(144, 17);
            this.rb_1.TabIndex = 3;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "Buscar todas las facturas";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(26, 80);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(99, 17);
            this.rb_2.TabIndex = 4;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "Buscar por Mes";
            this.rb_2.UseVisualStyleBackColor = true;
            this.rb_2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // cmb_Meses
            // 
            this.cmb_Meses.FormattingEnabled = true;
            this.cmb_Meses.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembe",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmb_Meses.Location = new System.Drawing.Point(198, 76);
            this.cmb_Meses.Name = "cmb_Meses";
            this.cmb_Meses.Size = new System.Drawing.Size(121, 21);
            this.cmb_Meses.TabIndex = 5;
            // 
            // Frm_FacturasXMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 555);
            this.Controls.Add(this.cmb_Meses);
            this.Controls.Add(this.rb_2);
            this.Controls.Add(this.rb_1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.rv_1);
            this.Name = "Frm_FacturasXMes";
            this.Text = "Frm_FacturasXFecha";
            this.Load += new System.EventHandler(this.Frm_FacturasXFecha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_1;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.ComboBox cmb_Meses;
    }
}