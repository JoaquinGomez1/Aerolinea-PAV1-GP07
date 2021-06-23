namespace TrabajoPrácticoPAV.Formularios.Estadisticas.AeropuertoPais
{
    partial class Frm_EstadisticaAeroPais
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txt_ciudad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_letra = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Rbu_ciudad = new System.Windows.Forms.RadioButton();
            this.Rbu_porLetra = new System.Windows.Forms.RadioButton();
            this.Rbutodos = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Aerolinea1 = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(12, 134);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(717, 238);
            this.reportViewer1.TabIndex = 4;
            // 
            // txt_ciudad
            // 
            this.txt_ciudad.Location = new System.Drawing.Point(241, 77);
            this.txt_ciudad.Name = "txt_ciudad";
            this.txt_ciudad.Size = new System.Drawing.Size(108, 20);
            this.txt_ciudad.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(139, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "En la ciudad";
            // 
            // txt_letra
            // 
            this.txt_letra.Location = new System.Drawing.Point(241, 47);
            this.txt_letra.Name = "txt_letra";
            this.txt_letra.Size = new System.Drawing.Size(88, 20);
            this.txt_letra.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Rbu_ciudad);
            this.groupBox2.Controls.Add(this.Rbu_porLetra);
            this.groupBox2.Controls.Add(this.Rbutodos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(365, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 116);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selección";
            // 
            // Rbu_ciudad
            // 
            this.Rbu_ciudad.AutoSize = true;
            this.Rbu_ciudad.Location = new System.Drawing.Point(18, 55);
            this.Rbu_ciudad.Name = "Rbu_ciudad";
            this.Rbu_ciudad.Size = new System.Drawing.Size(114, 24);
            this.Rbu_ciudad.TabIndex = 2;
            this.Rbu_ciudad.TabStop = true;
            this.Rbu_ciudad.Text = "En la ciudad";
            this.Rbu_ciudad.UseVisualStyleBackColor = true;
            // 
            // Rbu_porLetra
            // 
            this.Rbu_porLetra.AutoSize = true;
            this.Rbu_porLetra.Location = new System.Drawing.Point(18, 29);
            this.Rbu_porLetra.Name = "Rbu_porLetra";
            this.Rbu_porLetra.Size = new System.Drawing.Size(226, 24);
            this.Rbu_porLetra.TabIndex = 1;
            this.Rbu_porLetra.TabStop = true;
            this.Rbu_porLetra.Text = "Aeropuertos que contengan";
            this.Rbu_porLetra.UseVisualStyleBackColor = true;
            // 
            // Rbutodos
            // 
            this.Rbutodos.AutoSize = true;
            this.Rbutodos.Location = new System.Drawing.Point(18, 81);
            this.Rbutodos.Name = "Rbutodos";
            this.Rbutodos.Size = new System.Drawing.Size(71, 24);
            this.Rbutodos.TabIndex = 0;
            this.Rbutodos.TabStop = true;
            this.Rbutodos.Text = "Todos";
            this.Rbutodos.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(27, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Aeropuertos que contengan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Estadistica de Aeropuertos Por País";
            // 
            // button_Aerolinea1
            // 
            this.button_Aerolinea1.Location = new System.Drawing.Point(654, 93);
            this.button_Aerolinea1.Name = "button_Aerolinea1";
            this.button_Aerolinea1.Pp_Presionado = false;
            this.button_Aerolinea1.Size = new System.Drawing.Size(75, 25);
            this.button_Aerolinea1.TabIndex = 3;
            this.button_Aerolinea1.Text = "Buscar";
            this.button_Aerolinea1.UseVisualStyleBackColor = true;
            this.button_Aerolinea1.Click += new System.EventHandler(this.button_Aerolinea1_Click);
            // 
            // Frm_EstadisticaAeroPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 397);
            this.Controls.Add(this.txt_ciudad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_letra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button_Aerolinea1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EstadisticaAeroPais";
            this.Text = "Frm_EstadisticaAeroPais";
            this.Load += new System.EventHandler(this.Frm_EstadisticaAeroPais_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Clase.Button_Aerolinea button_Aerolinea1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txt_ciudad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_letra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Rbu_ciudad;
        private System.Windows.Forms.RadioButton Rbu_porLetra;
        private System.Windows.Forms.RadioButton Rbutodos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}