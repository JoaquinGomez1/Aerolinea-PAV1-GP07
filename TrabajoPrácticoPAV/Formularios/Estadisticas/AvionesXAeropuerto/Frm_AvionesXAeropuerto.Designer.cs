namespace TrabajoPrácticoPAV.Formularios.Estadisticas.AvionesXAeropuerto
{
    partial class Frm_AvionesXAeropuerto
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
            this.rp_aero = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_todo = new System.Windows.Forms.RadioButton();
            this.btn_rangoAv = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Hasta = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Txt_Desde = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.btn_calcular = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rp_aero
            // 
            this.rp_aero.Location = new System.Drawing.Point(12, 171);
            this.rp_aero.Name = "rp_aero";
            this.rp_aero.ServerReport.BearerToken = null;
            this.rp_aero.Size = new System.Drawing.Size(971, 267);
            this.rp_aero.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(13, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(356, 28);
            this.label4.TabIndex = 53;
            this.label4.Text = "Reporte de Aviones por Aeropuerto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_todo);
            this.groupBox1.Controls.Add(this.btn_rangoAv);
            this.groupBox1.Location = new System.Drawing.Point(486, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 87);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            // 
            // btn_todo
            // 
            this.btn_todo.AutoSize = true;
            this.btn_todo.Location = new System.Drawing.Point(18, 49);
            this.btn_todo.Name = "btn_todo";
            this.btn_todo.Size = new System.Drawing.Size(69, 21);
            this.btn_todo.TabIndex = 0;
            this.btn_todo.TabStop = true;
            this.btn_todo.Text = "Todos";
            this.btn_todo.UseVisualStyleBackColor = true;
            // 
            // btn_rangoAv
            // 
            this.btn_rangoAv.AutoSize = true;
            this.btn_rangoAv.Location = new System.Drawing.Point(18, 22);
            this.btn_rangoAv.Name = "btn_rangoAv";
            this.btn_rangoAv.Size = new System.Drawing.Size(181, 21);
            this.btn_rangoAv.TabIndex = 0;
            this.btn_rangoAv.TabStop = true;
            this.btn_rangoAv.Text = "Rango número de avión";
            this.btn_rangoAv.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(13, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 61;
            this.label3.Text = "Número de avión";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(240, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 36);
            this.label5.TabIndex = 64;
            this.label5.Text = "-";
            // 
            // Txt_Hasta
            // 
            this.Txt_Hasta.Location = new System.Drawing.Point(261, 58);
            this.Txt_Hasta.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Hasta.Name = "Txt_Hasta";
            this.Txt_Hasta.Pp_EsPk = false;
            this.Txt_Hasta.Pp_MensajeError = null;
            this.Txt_Hasta.Pp_NombreCampo = "codigo";
            this.Txt_Hasta.Pp_NombreTabla = "aeropuerto";
            this.Txt_Hasta.Size = new System.Drawing.Size(56, 22);
            this.Txt_Hasta.TabIndex = 63;
            // 
            // Txt_Desde
            // 
            this.Txt_Desde.Location = new System.Drawing.Point(185, 58);
            this.Txt_Desde.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Desde.Name = "Txt_Desde";
            this.Txt_Desde.Pp_EsPk = false;
            this.Txt_Desde.Pp_MensajeError = null;
            this.Txt_Desde.Pp_NombreCampo = "codigo";
            this.Txt_Desde.Pp_NombreTabla = "aeropuerto";
            this.Txt_Desde.Size = new System.Drawing.Size(56, 22);
            this.Txt_Desde.TabIndex = 62;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(486, 124);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Pp_Presionado = false;
            this.btn_calcular.Size = new System.Drawing.Size(108, 33);
            this.btn_calcular.TabIndex = 59;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // Frm_AvionesXAeropuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.Txt_Hasta);
            this.Controls.Add(this.Txt_Desde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rp_aero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_AvionesXAeropuerto";
            this.Text = "Frm_AvionesXAeropuerto";
            this.Load += new System.EventHandler(this.Frm_AvionesXAeropuerto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rp_aero;
        private System.Windows.Forms.Label label4;
        private Clase.Button_Aerolinea btn_calcular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btn_todo;
        private System.Windows.Forms.RadioButton btn_rangoAv;
        private Clase.TextBox_Aerolinea Txt_Hasta;
        private Clase.TextBox_Aerolinea Txt_Desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}