
namespace TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXPago
{
    partial class Frm_FacturasXPago
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.msk_annoHasta = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.msk_annoDesde = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.SuspendLayout();
            // 
            // rv_1
            // 
            this.rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXPago.ReporteFacturasXPago.rd" +
    "lc";
            this.rv_1.Location = new System.Drawing.Point(12, 68);
            this.rv_1.Name = "rv_1";
            this.rv_1.ServerReport.BearerToken = null;
            this.rv_1.Size = new System.Drawing.Size(713, 334);
            this.rv_1.TabIndex = 0;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_Calcular.Location = new System.Drawing.Point(624, 12);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(101, 43);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb_1.Location = new System.Drawing.Point(405, 10);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(68, 22);
            this.rb_1.TabIndex = 2;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "Todas";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.rb_2.Location = new System.Drawing.Point(405, 33);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(148, 22);
            this.rb_2.TabIndex = 3;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "Por año de factura";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(26, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desde el año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(187, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "hasta";
            // 
            // msk_annoHasta
            // 
            this.msk_annoHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.msk_annoHasta.Location = new System.Drawing.Point(237, 33);
            this.msk_annoHasta.Mask = "0000";
            this.msk_annoHasta.Name = "msk_annoHasta";
            this.msk_annoHasta.Pp_EsPk = false;
            this.msk_annoHasta.Pp_MensajeError = null;
            this.msk_annoHasta.Pp_NombreCampo = null;
            this.msk_annoHasta.Pp_NombreTabla = null;
            this.msk_annoHasta.Size = new System.Drawing.Size(54, 24);
            this.msk_annoHasta.TabIndex = 5;
            // 
            // msk_annoDesde
            // 
            this.msk_annoDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.msk_annoDesde.Location = new System.Drawing.Point(127, 33);
            this.msk_annoDesde.Mask = "0000";
            this.msk_annoDesde.Name = "msk_annoDesde";
            this.msk_annoDesde.Pp_EsPk = false;
            this.msk_annoDesde.Pp_MensajeError = null;
            this.msk_annoDesde.Pp_NombreCampo = null;
            this.msk_annoDesde.Pp_NombreTabla = null;
            this.msk_annoDesde.Size = new System.Drawing.Size(54, 24);
            this.msk_annoDesde.TabIndex = 4;
            // 
            // Frm_FacturasXPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 407);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_annoHasta);
            this.Controls.Add(this.msk_annoDesde);
            this.Controls.Add(this.rb_2);
            this.Controls.Add(this.rb_1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.rv_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FacturasXPago";
            this.Text = "Frm_FacturasXPago";
            this.Load += new System.EventHandler(this.Frm_FacturasXPago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_1;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.RadioButton rb_2;
        private Clase.MaskedTextBox_Aerolinea msk_annoDesde;
        private Clase.MaskedTextBox_Aerolinea msk_annoHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}