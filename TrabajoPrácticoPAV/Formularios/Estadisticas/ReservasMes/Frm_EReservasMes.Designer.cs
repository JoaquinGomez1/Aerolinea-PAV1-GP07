namespace TrabajoPrácticoPAV.Formularios.Estadisticas.ReservasMes
{
    partial class Frm_EReservasMes
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
            this.rd_PorMes = new System.Windows.Forms.RadioButton();
            this.rd_Todos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Hasta = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Txt_Desde = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.msk_Mes = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.btn_Calcular = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rd_PorMes
            // 
            this.rd_PorMes.AutoSize = true;
            this.rd_PorMes.Location = new System.Drawing.Point(4, 33);
            this.rd_PorMes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_PorMes.Name = "rd_PorMes";
            this.rd_PorMes.Size = new System.Drawing.Size(64, 17);
            this.rd_PorMes.TabIndex = 1;
            this.rd_PorMes.TabStop = true;
            this.rd_PorMes.Text = "Por Mes";
            this.rd_PorMes.UseVisualStyleBackColor = true;
            // 
            // rd_Todos
            // 
            this.rd_Todos.AutoSize = true;
            this.rd_Todos.Location = new System.Drawing.Point(4, 55);
            this.rd_Todos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rd_Todos.Name = "rd_Todos";
            this.rd_Todos.Size = new System.Drawing.Size(55, 17);
            this.rd_Todos.TabIndex = 2;
            this.rd_Todos.TabStop = true;
            this.rd_Todos.Text = "Todos";
            this.rd_Todos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_PorMes);
            this.groupBox1.Controls.Add(this.rd_Todos);
            this.groupBox1.Location = new System.Drawing.Point(322, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadística";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(208, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 29);
            this.label5.TabIndex = 50;
            this.label5.Text = "-";
            // 
            // Txt_Hasta
            // 
            this.Txt_Hasta.Location = new System.Drawing.Point(224, 76);
            this.Txt_Hasta.Name = "Txt_Hasta";
            this.Txt_Hasta.Pp_EsPk = false;
            this.Txt_Hasta.Pp_MensajeError = null;
            this.Txt_Hasta.Pp_NombreCampo = "codigo";
            this.Txt_Hasta.Pp_NombreTabla = "aeropuerto";
            this.Txt_Hasta.Size = new System.Drawing.Size(43, 20);
            this.Txt_Hasta.TabIndex = 49;
            // 
            // Txt_Desde
            // 
            this.Txt_Desde.Location = new System.Drawing.Point(166, 76);
            this.Txt_Desde.Name = "Txt_Desde";
            this.Txt_Desde.Pp_EsPk = false;
            this.Txt_Desde.Pp_MensajeError = null;
            this.Txt_Desde.Pp_NombreCampo = "codigo";
            this.Txt_Desde.Pp_NombreTabla = "aeropuerto";
            this.Txt_Desde.Size = new System.Drawing.Size(43, 20);
            this.Txt_Desde.TabIndex = 48;
            // 
            // msk_Mes
            // 
            this.msk_Mes.Location = new System.Drawing.Point(166, 31);
            this.msk_Mes.Margin = new System.Windows.Forms.Padding(2);
            this.msk_Mes.Mask = "00/00/0000";
            this.msk_Mes.Name = "msk_Mes";
            this.msk_Mes.Pp_EsPk = false;
            this.msk_Mes.Pp_MensajeError = null;
            this.msk_Mes.Pp_NombreCampo = null;
            this.msk_Mes.Pp_NombreTabla = null;
            this.msk_Mes.Size = new System.Drawing.Size(76, 20);
            this.msk_Mes.TabIndex = 5;
            this.msk_Mes.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(514, 76);
            this.btn_Calcular.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Pp_Presionado = false;
            this.btn_Calcular.Size = new System.Drawing.Size(65, 23);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(13, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(681, 246);
            this.reportViewer1.TabIndex = 51;
            // 
            // Frm_EReservasMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 384);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Txt_Hasta);
            this.Controls.Add(this.Txt_Desde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_Mes);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_EReservasMes";
            this.Text = "Frm_EReservasMes";
            this.Load += new System.EventHandler(this.Frm_EReservasMes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rd_PorMes;
        private System.Windows.Forms.RadioButton rd_Todos;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clase.Button_Aerolinea btn_Calcular;
        private Clase.MaskedTextBox_Aerolinea msk_Mes;
        private System.Windows.Forms.Label label1;
        private Clase.TextBox_Aerolinea Txt_Hasta;
        private Clase.TextBox_Aerolinea Txt_Desde;
        private System.Windows.Forms.Label label5;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}