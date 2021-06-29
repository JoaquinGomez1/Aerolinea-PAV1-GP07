
namespace TrabajoPrácticoPAV.Formularios.Estadisticas.PasajerosMayores
{
    partial class Frm_PasajerosMayores
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
            this.rv_pasajerosMayores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_cerrar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rv_pasajerosMayores
            // 
            this.rv_pasajerosMayores.Location = new System.Drawing.Point(12, 71);
            this.rv_pasajerosMayores.Name = "rv_pasajerosMayores";
            this.rv_pasajerosMayores.ServerReport.BearerToken = null;
            this.rv_pasajerosMayores.Size = new System.Drawing.Size(727, 335);
            this.rv_pasajerosMayores.TabIndex = 0;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cerrar.Location = new System.Drawing.Point(644, 12);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Pp_Presionado = false;
            this.btn_cerrar.Size = new System.Drawing.Size(95, 41);
            this.btn_cerrar.TabIndex = 16;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Estadistica de Pasajeros mayores de Edad";
            // 
            // Frm_PasajerosMayores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.rv_pasajerosMayores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_PasajerosMayores";
            this.Text = "Frm_PasajerosMayores";
            this.Load += new System.EventHandler(this.Frm_PasajerosMayores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_pasajerosMayores;
        private Clase.Button_Aerolinea btn_cerrar;
        private System.Windows.Forms.Label label5;
    }
}