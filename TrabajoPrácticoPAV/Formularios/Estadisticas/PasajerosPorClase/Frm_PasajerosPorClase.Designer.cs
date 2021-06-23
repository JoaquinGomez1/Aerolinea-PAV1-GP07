
namespace TrabajoPrácticoPAV.Formularios.Estadisticas.PasajerosPorViaje
{
    partial class Frm_PasajerosPorViaje
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
            this.rv_pasajerosPorViaje = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.SuspendLayout();
            // 
            // rv_pasajerosPorViaje
            // 
            this.rv_pasajerosPorViaje.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.PasajerosPorViaje.EstadisticaPasajero" +
    "sPorViaje.rdlc";
            this.rv_pasajerosPorViaje.Location = new System.Drawing.Point(12, 12);
            this.rv_pasajerosPorViaje.Name = "rv_pasajerosPorViaje";
            this.rv_pasajerosPorViaje.ServerReport.BearerToken = null;
            this.rv_pasajerosPorViaje.Size = new System.Drawing.Size(727, 355);
            this.rv_pasajerosPorViaje.TabIndex = 1;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btn_cerrar.Location = new System.Drawing.Point(649, 373);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(90, 28);
            this.btn_cerrar.TabIndex = 17;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Frm_PasajerosPorViaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 413);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.rv_pasajerosPorViaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_PasajerosPorViaje";
            this.Text = "Frm_PasajerosPorViaje";
            this.Load += new System.EventHandler(this.Frm_PasajerosPorViaje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_pasajerosPorViaje;
        private Clase.Button_Aerolinea btn_cerrar;
    }
}