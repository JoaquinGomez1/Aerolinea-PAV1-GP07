
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rv_1
            // 
            this.rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXPago.ReporteFacturasXPago.rd" +
    "lc";
            this.rv_1.Location = new System.Drawing.Point(24, 101);
            this.rv_1.Name = "rv_1";
            this.rv_1.ServerReport.BearerToken = null;
            this.rv_1.Size = new System.Drawing.Size(713, 305);
            this.rv_1.TabIndex = 0;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Calcular.Location = new System.Drawing.Point(642, 54);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(95, 41);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_1.Location = new System.Drawing.Point(6, 25);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(71, 24);
            this.rb_1.TabIndex = 2;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "Todas";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_2.Location = new System.Drawing.Point(6, 48);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(158, 24);
            this.rb_2.TabIndex = 3;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "Por año de factura";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desde el año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(213, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "hasta";
            // 
            // msk_annoHasta
            // 
            this.msk_annoHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.msk_annoHasta.Location = new System.Drawing.Point(263, 54);
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
            this.msk_annoDesde.Location = new System.Drawing.Point(158, 54);
            this.msk_annoDesde.Mask = "0000";
            this.msk_annoDesde.Name = "msk_annoDesde";
            this.msk_annoDesde.Pp_EsPk = false;
            this.msk_annoDesde.Pp_MensajeError = null;
            this.msk_annoDesde.Pp_NombreCampo = null;
            this.msk_annoDesde.Pp_NombreTabla = null;
            this.msk_annoDesde.Size = new System.Drawing.Size(54, 24);
            this.msk_annoDesde.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_1);
            this.groupBox2.Controls.Add(this.rb_2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 83);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estadistica de Facturas por pago";
            // 
            // Frm_FacturasXPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_annoHasta);
            this.Controls.Add(this.msk_annoDesde);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.rv_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_FacturasXPago";
            this.Text = "Frm_FacturasXPago";
            this.Load += new System.EventHandler(this.Frm_FacturasXPago_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
    }
}