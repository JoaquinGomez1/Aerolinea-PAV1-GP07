
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
            this.rb_1 = new System.Windows.Forms.RadioButton();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_3 = new System.Windows.Forms.RadioButton();
            this.button_Aerolinea1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
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
            this.rv_1.ZoomPercent = 75;
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Location = new System.Drawing.Point(28, 33);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(101, 17);
            this.rb_1.TabIndex = 2;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "Todos los viajes";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(28, 53);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(93, 17);
            this.rb_2.TabIndex = 3;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "Viajes directos";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Location = new System.Drawing.Point(28, 73);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(160, 17);
            this.rb_3.TabIndex = 4;
            this.rb_3.TabStop = true;
            this.rb_3.Text = "Vaijes con una escala o mas";
            this.rb_3.UseVisualStyleBackColor = true;
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
            // Frm_viajesXFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 468);
            this.Controls.Add(this.rb_3);
            this.Controls.Add(this.rb_2);
            this.Controls.Add(this.rb_1);
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
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.RadioButton rb_3;
    }
}