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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rd_PorMes = new System.Windows.Forms.RadioButton();
            this.rd_Todos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Calcular = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.msk_Mes = new TrabajoPrácticoPAV.Clase.MaskedTextBox_Aerolinea();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Estadisticas.ReservasMes.Estadistica_ReservasMes.r" +
    "dlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 146);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(827, 376);
            this.reportViewer1.TabIndex = 0;
            // 
            // rd_PorMes
            // 
            this.rd_PorMes.AutoSize = true;
            this.rd_PorMes.Location = new System.Drawing.Point(84, 32);
            this.rd_PorMes.Name = "rd_PorMes";
            this.rd_PorMes.Size = new System.Drawing.Size(81, 21);
            this.rd_PorMes.TabIndex = 1;
            this.rd_PorMes.TabStop = true;
            this.rd_PorMes.Text = "Por Mes";
            this.rd_PorMes.UseVisualStyleBackColor = true;
            // 
            // rd_Todos
            // 
            this.rd_Todos.AutoSize = true;
            this.rd_Todos.Location = new System.Drawing.Point(84, 59);
            this.rd_Todos.Name = "rd_Todos";
            this.rd_Todos.Size = new System.Drawing.Size(69, 21);
            this.rd_Todos.TabIndex = 2;
            this.rd_Todos.TabStop = true;
            this.rd_Todos.Text = "Todos";
            this.rd_Todos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_PorMes);
            this.groupBox1.Controls.Add(this.rd_Todos);
            this.groupBox1.Location = new System.Drawing.Point(429, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadística";
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(685, 93);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Pp_Presionado = false;
            this.btn_Calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // msk_Mes
            // 
            this.msk_Mes.Location = new System.Drawing.Point(222, 74);
            this.msk_Mes.Mask = "00/00/0000";
            this.msk_Mes.Name = "msk_Mes";
            this.msk_Mes.Pp_EsPk = false;
            this.msk_Mes.Pp_MensajeError = null;
            this.msk_Mes.Pp_NombreCampo = null;
            this.msk_Mes.Pp_NombreTabla = null;
            this.msk_Mes.Size = new System.Drawing.Size(100, 22);
            this.msk_Mes.TabIndex = 5;
            this.msk_Mes.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mes";
            // 
            // Frm_EReservasMes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 521);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_Mes);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_EReservasMes";
            this.Text = "Frm_EReservasMes";
            this.Load += new System.EventHandler(this.Frm_EReservasMes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.RadioButton rd_PorMes;
        private System.Windows.Forms.RadioButton rd_Todos;
        private System.Windows.Forms.GroupBox groupBox1;
        private Clase.Button_Aerolinea btn_Calcular;
        private Clase.MaskedTextBox_Aerolinea msk_Mes;
        private System.Windows.Forms.Label label1;
    }
}