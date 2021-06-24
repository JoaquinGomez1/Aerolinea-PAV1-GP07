namespace TrabajoPrácticoPAV.Formularios.Listados.Asientos
{
    partial class Frm_ReporteAsientoXAvion
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ds_ReporteAsientoXAvion = new TrabajoPrácticoPAV.Formularios.Listados.Asientos.Ds_ReporteAsientoXAvion();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Rbu_Numero = new System.Windows.Forms.RadioButton();
            this.Rbu_Todos = new System.Windows.Forms.RadioButton();
            this.Rbu_Avion = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_Modelo = new TrabajoPrácticoPAV.Clase.ComboBox_Aerolinea();
            this.Txt_Hasta = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Txt_Desde = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.Btn_Buscar = new TrabajoPrácticoPAV.Clase.Button_Aerolinea();
            this.Txt_Numero = new TrabajoPrácticoPAV.Clase.TextBox_Aerolinea();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_ReporteAsientoXAvion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.Ds_ReporteAsientoXAvion;
            // 
            // Ds_ReporteAsientoXAvion
            // 
            this.Ds_ReporteAsientoXAvion.DataSetName = "Ds_ReporteAsientoXAvion";
            this.Ds_ReporteAsientoXAvion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(92, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 44;
            this.label3.Text = "Número de asiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 21);
            this.label4.TabIndex = 42;
            this.label4.Text = "Reporte de Estado de Asientos por Avión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(87, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Número por Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(174, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Modelo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rbu_Numero);
            this.groupBox1.Controls.Add(this.Rbu_Todos);
            this.groupBox1.Controls.Add(this.Rbu_Avion);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(396, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 103);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo búsqueda";
            // 
            // Rbu_Numero
            // 
            this.Rbu_Numero.AutoSize = true;
            this.Rbu_Numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rbu_Numero.Location = new System.Drawing.Point(17, 47);
            this.Rbu_Numero.Name = "Rbu_Numero";
            this.Rbu_Numero.Size = new System.Drawing.Size(187, 24);
            this.Rbu_Numero.TabIndex = 4;
            this.Rbu_Numero.Text = "Por número de asiento";
            this.Rbu_Numero.UseVisualStyleBackColor = true;
            // 
            // Rbu_Todos
            // 
            this.Rbu_Todos.AutoSize = true;
            this.Rbu_Todos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rbu_Todos.Location = new System.Drawing.Point(17, 74);
            this.Rbu_Todos.Name = "Rbu_Todos";
            this.Rbu_Todos.Size = new System.Drawing.Size(71, 24);
            this.Rbu_Todos.TabIndex = 3;
            this.Rbu_Todos.Text = "Todos";
            this.Rbu_Todos.UseVisualStyleBackColor = true;
            // 
            // Rbu_Avion
            // 
            this.Rbu_Avion.AutoSize = true;
            this.Rbu_Avion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rbu_Avion.Location = new System.Drawing.Point(17, 20);
            this.Rbu_Avion.Name = "Rbu_Avion";
            this.Rbu_Avion.Size = new System.Drawing.Size(92, 24);
            this.Rbu_Avion.TabIndex = 2;
            this.Rbu_Avion.Text = "Por avión";
            this.Rbu_Avion.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label5.Location = new System.Drawing.Point(282, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "-";
            // 
            // cmb_Modelo
            // 
            this.cmb_Modelo.FormattingEnabled = true;
            this.cmb_Modelo.Location = new System.Drawing.Point(241, 42);
            this.cmb_Modelo.Name = "cmb_Modelo";
            this.cmb_Modelo.Pp_CampoAceptaNull = true;
            this.cmb_Modelo.Pp_EsPk = false;
            this.cmb_Modelo.Pp_MensajeError = null;
            this.cmb_Modelo.Pp_NombreCampo = "nombre";
            this.cmb_Modelo.Pp_NombreCampoInsert = null;
            this.cmb_Modelo.Pp_NombreTabla = "Modelo";
            this.cmb_Modelo.Pp_PkTabla = "idModelo";
            this.cmb_Modelo.Size = new System.Drawing.Size(100, 21);
            this.cmb_Modelo.TabIndex = 48;
            // 
            // Txt_Hasta
            // 
            this.Txt_Hasta.Location = new System.Drawing.Point(298, 93);
            this.Txt_Hasta.Name = "Txt_Hasta";
            this.Txt_Hasta.Pp_EsPk = false;
            this.Txt_Hasta.Pp_MensajeError = null;
            this.Txt_Hasta.Pp_NombreCampo = "codigo";
            this.Txt_Hasta.Pp_NombreTabla = "aeropuerto";
            this.Txt_Hasta.Size = new System.Drawing.Size(43, 20);
            this.Txt_Hasta.TabIndex = 46;
            // 
            // Txt_Desde
            // 
            this.Txt_Desde.Location = new System.Drawing.Point(241, 93);
            this.Txt_Desde.Name = "Txt_Desde";
            this.Txt_Desde.Pp_EsPk = false;
            this.Txt_Desde.Pp_MensajeError = null;
            this.Txt_Desde.Pp_NombreCampo = "codigo";
            this.Txt_Desde.Pp_NombreTabla = "aeropuerto";
            this.Txt_Desde.Size = new System.Drawing.Size(43, 20);
            this.Txt_Desde.TabIndex = 45;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_Buscar.Location = new System.Drawing.Point(642, 67);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Pp_Presionado = false;
            this.Btn_Buscar.Size = new System.Drawing.Size(95, 41);
            this.Btn_Buscar.TabIndex = 41;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            this.Btn_Buscar.Click += new System.EventHandler(this.Btn_Buscar_Click_1);
            // 
            // Txt_Numero
            // 
            this.Txt_Numero.Location = new System.Drawing.Point(241, 67);
            this.Txt_Numero.Name = "Txt_Numero";
            this.Txt_Numero.Pp_EsPk = false;
            this.Txt_Numero.Pp_MensajeError = null;
            this.Txt_Numero.Pp_NombreCampo = "codigo";
            this.Txt_Numero.Pp_NombreTabla = "aeropuerto";
            this.Txt_Numero.Size = new System.Drawing.Size(100, 20);
            this.Txt_Numero.TabIndex = 40;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TrabajoPrácticoPAV.Formularios.Listados.Asientos.Reporte_AsientoXAvion.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(16, 121);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(721, 285);
            this.reportViewer1.TabIndex = 49;
            // 
            // Frm_ReporteAsientoXAvion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 418);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cmb_Modelo);
            this.Controls.Add(this.Txt_Hasta);
            this.Controls.Add(this.Txt_Desde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_Buscar);
            this.Controls.Add(this.Txt_Numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ReporteAsientoXAvion";
            this.Text = "Frm_ReporteAsientoXAvion";
            this.Load += new System.EventHandler(this.Frm_ReporteAsientoXAvion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_ReporteAsientoXAvion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Clase.TextBox_Aerolinea Txt_Hasta;
        private Clase.TextBox_Aerolinea Txt_Desde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Clase.Button_Aerolinea Btn_Buscar;
        private Clase.TextBox_Aerolinea Txt_Numero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Rbu_Numero;
        private System.Windows.Forms.RadioButton Rbu_Todos;
        private System.Windows.Forms.RadioButton Rbu_Avion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private Ds_ReporteAsientoXAvion Ds_ReporteAsientoXAvion;
        private Clase.ComboBox_Aerolinea cmb_Modelo;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}