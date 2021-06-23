
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
            this.cmb_Pagos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rv_1
            // 
            this.rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.FacturasXPago.ReporteFacturasXPago.rd" +
    "lc";
            this.rv_1.Location = new System.Drawing.Point(46, 116);
            this.rv_1.Name = "rv_1";
            this.rv_1.ServerReport.BearerToken = null;
            this.rv_1.Size = new System.Drawing.Size(684, 322);
            this.rv_1.TabIndex = 0;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(563, 73);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(149, 23);
            this.btn_Calcular.TabIndex = 1;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(73, 24);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(144, 17);
            this.rb_1.TabIndex = 2;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "Buscar todas las facturas";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(73, 47);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(144, 17);
            this.rb_2.TabIndex = 3;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "Buscar Por Tipo de Pago";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // cmb_Pagos
            // 
            this.cmb_Pagos.FormattingEnabled = true;
            this.cmb_Pagos.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Debito"});
            this.cmb_Pagos.Location = new System.Drawing.Point(262, 46);
            this.cmb_Pagos.Name = "cmb_Pagos";
            this.cmb_Pagos.Size = new System.Drawing.Size(125, 21);
            this.cmb_Pagos.TabIndex = 4;
            // 
            // Frm_FacturasXPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmb_Pagos);
            this.Controls.Add(this.rb_2);
            this.Controls.Add(this.rb_1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.rv_1);
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
        private System.Windows.Forms.ComboBox cmb_Pagos;
    }
}