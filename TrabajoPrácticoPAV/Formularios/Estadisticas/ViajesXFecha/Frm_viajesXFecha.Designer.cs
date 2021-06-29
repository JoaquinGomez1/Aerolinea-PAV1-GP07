
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
            this.label5 = new System.Windows.Forms.Label();
            this.Selección = new System.Windows.Forms.GroupBox();
            this.Selección.SuspendLayout();
            this.SuspendLayout();
            // 
            // rv_1
            // 
            this.rv_1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.ViajesXFecha.ViajesXFecha.rdlc";
            this.rv_1.Location = new System.Drawing.Point(16, 111);
            this.rv_1.Name = "rv_1";
            this.rv_1.ServerReport.BearerToken = null;
            this.rv_1.Size = new System.Drawing.Size(740, 271);
            this.rv_1.TabIndex = 0;
            this.rv_1.ZoomPercent = 75;
            // 
            // rb_1
            // 
            this.rb_1.AutoSize = true;
            this.rb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_1.Location = new System.Drawing.Point(6, 26);
            this.rb_1.Name = "rb_1";
            this.rb_1.Size = new System.Drawing.Size(138, 24);
            this.rb_1.TabIndex = 2;
            this.rb_1.TabStop = true;
            this.rb_1.Text = "Todos los viajes";
            this.rb_1.UseVisualStyleBackColor = true;
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_2.Location = new System.Drawing.Point(6, 46);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(130, 24);
            this.rb_2.TabIndex = 3;
            this.rb_2.TabStop = true;
            this.rb_2.Text = "Viajes directos";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // rb_3
            // 
            this.rb_3.AutoSize = true;
            this.rb_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb_3.Location = new System.Drawing.Point(6, 66);
            this.rb_3.Name = "rb_3";
            this.rb_3.Size = new System.Drawing.Size(228, 24);
            this.rb_3.TabIndex = 4;
            this.rb_3.TabStop = true;
            this.rb_3.Text = "Viajes con una escala o más";
            this.rb_3.UseVisualStyleBackColor = true;
            // 
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Aerolinea1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_Aerolinea1.Location = new System.Drawing.Point(662, 60);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(91, 45);
            this.button_Aerolinea1.TabIndex = 1;
            this.button_Aerolinea1.Text = "Calcular";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            this.button_Aerolinea1.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Listado de viajes por fecha";
            // 
            // Selección
            // 
            this.Selección.Controls.Add(this.rb_2);
            this.Selección.Controls.Add(this.rb_1);
            this.Selección.Controls.Add(this.rb_3);
            this.Selección.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Selección.Location = new System.Drawing.Point(422, 5);
            this.Selección.Name = "Selección";
            this.Selección.Size = new System.Drawing.Size(234, 100);
            this.Selección.TabIndex = 15;
            this.Selección.TabStop = false;
            this.Selección.Text = "Selección";
            // 
            // Frm_viajesXFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 391);
            this.Controls.Add(this.Selección);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Aerolinea1);
            this.Controls.Add(this.rv_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_viajesXFecha";
            this.Text = "Frm_viajesXFecha";
            this.Load += new System.EventHandler(this.Frm_viajesXFecha_Load);
            this.Selección.ResumeLayout(false);
            this.Selección.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_1;
        private Clase.Button_Aerolinea button_Aerolinea1;
        private System.Windows.Forms.RadioButton rb_1;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.RadioButton rb_3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Selección;
    }
}