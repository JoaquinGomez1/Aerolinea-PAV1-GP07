
namespace TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesXFecha
{
    partial class Frm_viajesXFecha
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
            this.button_Aerolinea1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.msk_fecha = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.SuspendLayout();
            // 
            // rv_1
            // 
            this.rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesXFecha.ViajesXFecha.rdlc";
            this.rv_1.Location = new System.Drawing.Point(28, 111);
            this.rv_1.Name = "rv_1";
            this.rv_1.ServerReport.BearerToken = null;
            this.rv_1.Size = new System.Drawing.Size(728, 327);
            this.rv_1.TabIndex = 0;
            // 
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.Location = new System.Drawing.Point(626, 73);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(101, 23);
            this.button_Aerolinea1.TabIndex = 1;
            this.button_Aerolinea1.Text = "Calcular";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            this.button_Aerolinea1.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // msk_fecha
            // 
            this.msk_fecha.Location = new System.Drawing.Point(139, 76);
            this.msk_fecha.Mask = "00/00/0000";
            this.msk_fecha.Name = "msk_fecha";
            this.msk_fecha.Pp_EsPk = false;
            this.msk_fecha.Pp_MensajeError = null;
            this.msk_fecha.Pp_NombreCampo = null;
            this.msk_fecha.Pp_NombreTabla = null;
            this.msk_fecha.Size = new System.Drawing.Size(66, 20);
            this.msk_fecha.TabIndex = 2;
            this.msk_fecha.ValidatingType = typeof(System.DateTime);
            // 
            // Frm_viajesXFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 468);
            this.Controls.Add(this.msk_fecha);
            this.Controls.Add(this.button_Aerolinea1);
            this.Controls.Add(this.rv_1);
            this.Name = "Frm_viajesXFecha";
            this.Text = "Frm_viajesXFecha";
            this.Load += new System.EventHandler(this.Frm_viajesXFecha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_1;
        private Clase.Button_Aerolinea button_Aerolinea1;
        private Clase.MaskedTextBox_Aerolinea msk_fecha;
    }
}